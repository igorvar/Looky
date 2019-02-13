using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Linq;
using System.Xml.XPath;

namespace WindowsFormsApplication1
{
    enum DateType { NoRelevant, Created, Updated };
    enum ContentExpressionType { Text, Regex, Xpath };


    class FileFilter
    {
        Regex _searchXML = null;
        private readonly Encoding _DEFAULT_ENCODING;
        public FileFilter(Encoding DefaultTextEncoding)
        {
            _DEFAULT_ENCODING = DefaultTextEncoding;
            _searchXML = new Regex(
                //                                tag name               attribute  with " or '   attribute value  " or '  zero or more attributes   end tag  
        //@"<(\w+)      (?:\s+\w+\s*=\s*?(['" + "\"" + @"])   .*?              \2)     *\s*?>    .*?             </\1>"
          @"<(\w+)      (?:\s+\w+\s*=\s*?(['" + "\"" + @"])   .*?              \2)     *\s*?>    .*?             </\1\s*>"
        , RegexOptions.Singleline | RegexOptions.IgnorePatternWhitespace | RegexOptions.Compiled);

        }

        private Encoding GetEncoding(string fileName)
        {
            using (FileStream fs = File.OpenRead(fileName))
            {
                Ude.ICharsetDetector cdet = new Ude.CharsetDetector();
                cdet.Feed(fs);
                cdet.DataEnd();
                if (cdet.Charset != null) return Encoding.GetEncoding(cdet.Charset);
                return _DEFAULT_ENCODING;
            }
        }
        

        public FileInfo[] FilterFilesLINQ(
                            string fileMask, FileInfo[] filesArray,
                            DateType dateType, DateTime dtFrom, DateTime dtTo,
                            bool isFilterBySize, long sizeFrom, long sizeTo,
                            string content, ContentExpressionType expressionType)
        {
            string fileMaskRegexpTemp = fileMask;
            FileInfo[] fiArr = new FileInfo[filesArray.Length];
            fiArr = filesArray;// TODO: to use filesArray  instead fiArr 
            //for (int i = 0; i < filesArray.Length; i++)
            //    fiArr[i] = new FileInfo(filesArray[i]);
            //fileMaskRegexpTemp = fileMaskRegexpTemp.Replace(".", @"\.*");
            //fileMaskRegexpTemp = fileMaskRegexpTemp.Replace("^", @"\^");
            fileMaskRegexpTemp = Regex.Replace(fileMaskRegexpTemp, @"[\^\.\$\(\)]", @"\$&", RegexOptions.IgnoreCase);
            fileMaskRegexpTemp = fileMaskRegexpTemp.Replace("*", ".*");
            fileMaskRegexpTemp = fileMaskRegexpTemp.Replace("?", ".");
            
            Regex reFilemask = new Regex("^" + fileMaskRegexpTemp, RegexOptions.IgnoreCase);

            //var fileList = from FileInfo file in fiArr
            //               where reFilemask.IsMatch(file.Name)
            //               select file;


            var fileList = from FileInfo file in fiArr.AsParallel()
                
                           where !string.IsNullOrEmpty(fileMask) && reFilemask.IsMatch(file.Name)
                           &&
                           (
                                dateType == DateType.NoRelevant 
                                ||
                                dateType == DateType.Created && file.CreationTime.Date >= dtFrom && file.CreationTime.Date <= dtTo
                                ||
                                dateType == DateType.Updated && file.LastWriteTime.Date >= dtFrom && file.LastWriteTime.Date <= dtTo
                           )
                           &&
                           (
                                !isFilterBySize ||
                                file.Length >= sizeFrom && file.Length <= sizeTo
                           )
                           &&
                           (
                                expressionType== ContentExpressionType.Text && (string.IsNullOrEmpty(content) || IsContextMatch(file.FullName,content))




                                ||
                                expressionType == ContentExpressionType.Regex && (string.IsNullOrEmpty(content) || IsContextMatch(file.FullName, new Regex(content, RegexOptions.IgnoreCase)))
                                ||
                                expressionType == ContentExpressionType.Xpath && IsXpathMatched(file.FullName, content)

                           )
                           select file;
            
            
            
            
            return fileList.ToArray<FileInfo>();
        }
        
        public delegate void FileProcesed(object sender, FileProcessedEventArg e);
        private bool IsContextMatch(string file, string text)
        {
            if (!File.Exists(file)) return false;
            string searchAt = text.ToUpper();
            bool isCaseSenc = text.ToUpper() != text.ToLower();
            bool isMatched = false;
            Encoding enc = GetEncoding(file);
            //int counter = 0;
            
            foreach (string line in File.ReadLines(file, enc))
            {
//                counter++;
                if (isCaseSenc)
                {
                    if (line.ToUpper().Contains(searchAt))
                    {
                        isMatched = true;
                        break;
                    }
                }
                else
                {
                    if (line.Contains(searchAt))
                    {
                        isMatched = true;
                        break;
                    }
                }

            }
            return isMatched;

            /*string content = File.ReadAllText(file);
            if (string.IsNullOrEmpty(content)) return false;
            if (text.ToUpper() == text)
                return content.Contains(text);
            else
                return content.ToUpper().Contains(text.ToUpper());
            //return Regex.IsMatch(content, text, RegexOptions.IgnoreCase);*/
        }

        private bool IsContextMatch(string file, Regex regex)
        {
            //string content = File.ReadAllText(file); 
            string content;
            try
            {
                content = File.ReadAllText(file); 
            }
            catch (IOException ex)
            {
                return true; //new FileStream not work;
                using (FileStream fs = new FileStream(file,FileMode.Open,FileAccess.Read))
                {
                    byte[] buff = new byte[new FileInfo(file).Length];
                    fs.Read(buff, 0, buff.Length);
                    Encoding enc = GetEncoding(file);
                    content = enc.GetString(buff);
                    
                }
            }
            
            
            return regex.IsMatch(content);
        }

        private bool IsContextMatch(System.Xml.XmlDocument doc, string xpath)
        {
            if (string.IsNullOrEmpty(xpath)) return true;
            return doc.SelectNodes(xpath).Count > 0;
        }

        private bool IsXpathMatched(string fileName, string xpath)
        {
            bool isMatched = false;
            MatchCollection mc = null;
            XPathDocument doc;
            XPathNavigator nav; 
            string txt;
            try
            {
                doc = new XPathDocument(fileName);
                nav = doc.CreateNavigator();
                if (string.IsNullOrWhiteSpace(xpath)) return true;
                return nav.SelectSingleNode(xpath) != null;

            }
            catch (System.Xml.XmlException ex)
            {
                txt = File.ReadAllText(fileName, GetEncoding(fileName));
                mc = _searchXML.Matches(txt);
                for (int i = 0; i < mc.Count && isMatched == false; i++)
                {
                    MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(mc[i].Value));
                    try
                    {
                        doc = new XPathDocument(ms);
                        nav = doc.CreateNavigator();
                        if (string.IsNullOrWhiteSpace(xpath)) return true;
                        nav.SelectSingleNode(xpath);
                    }
                    catch(Exception ex1){ continue; }
                    try
                    {
                        isMatched = nav.SelectSingleNode(xpath) != null;
                    }
                    catch (Exception ex2) { continue; }
                }
            }
            return isMatched;
        }
        private bool IsXpathMatched_xmlDoc(string fileName, string xpath)
        {
            bool isMatched = false;
            string txt = File.ReadAllText(fileName);
            System.Xml.XmlDocument xDoc = null;
            MatchCollection mc = null;
            if (string.IsNullOrEmpty(xpath)) return _searchXML.IsMatch(txt); // if no present xpath - search XML
            mc = _searchXML.Matches(txt);
            //if (mc.Count==0) return  false;
            for (int i = 0; i < mc.Count && isMatched == false; i++)
            {
                xDoc = new System.Xml.XmlDocument();
                try
                {
                    xDoc.LoadXml(mc[i].Value);
                }
                catch (System.Xml.XmlException)
                {
                    continue;
                }
                try
                {
                    isMatched = (xDoc != null && xDoc.SelectSingleNode(xpath) != null);
                }
                catch (System.Xml.XPath.XPathException ex)
                {

                    continue;
                }
                
                    
                
            }
            return isMatched;
        }

        public event EventHandler<FileProcessedEventArg> RaiseFileProcessed;
        //public event EventHandler<ElapsedEventArg> TimerElapsed;
        /*public double EventInterval
        {
            get
            {
                return _mainTimer.Interval;
            }
            set
            {
                _mainTimer.Interval = value;
            }
        }*/
        List<string> _matchedFiles = null;
        /*public string[] MatchedFiles
        {
            get {return _matchedFiles.ToArray(); }
        }*/
    }

    /*class ElapsedEventArg : EventArgs
    {
        public string[]FilteredInThisLoop { get; private set; }
        public int ProcessedFiles { get; set; }
        public ElapsedEventArg(string[] filteredInThisLoop, int processedFiles)
        {
            ProcessedFiles = processedFiles;
            FilteredInThisLoop = filteredInThisLoop;
        }
    }*/
    class FileProcessedEventArg : EventArgs
    {
        public FileProcessedEventArg(string file, int number, bool isMatched, int matched)
        {
            this.Number = number;
            this.IsMatched = isMatched;
            this.File = file;
            this.Matched = matched;
        }
        public FileProcessedEventArg(FileInfo[] files)
        {
            this.Files = files;
        }

        public int Number { get; private set; }
        public string File { get; private set; }
        public bool IsMatched { get; private set; }
        public int Matched { get; private set; }
        public FileInfo[] Files { get; private set; }
    }
}
