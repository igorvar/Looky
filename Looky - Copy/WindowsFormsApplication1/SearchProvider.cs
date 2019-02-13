using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Xml.XPath;//System.Xml;
using System.IO;
namespace WindowsFormsApplication1
{
    enum SearchType { PlainText, Regex, xPath };
    static class SearchProvider
    {

        private static RichTextBox _rtb = null;
        private static Point[] _matches;
        private const byte _BLUE_MIN = 10; // minimum value of blue color in matched selection on GUI
        private const byte _BLUE_MAX = 220 - 20;// maximum value of blue color in matched selection on GUI
        private const byte _CHAR_COUNT_FOR_MINIMUM_BLUE = 40;
        private static Color _NONSELECTED_COLOR;
        private static Regex _searchRegexChars = new Regex(@"([\(\)\.\[\]\}\\\$\^\|\+|\*\?])", RegexOptions.Compiled);
        private static Regex _searchXML = new Regex(
            //                                tag name               attribute  with " or '   attribute value  " or '  zero or more attributes   end tag  
            //@"<(\w+)      (?:\s+\w+\s*=\s*?(['" + "\"" + @"])   .*?              \2)     *\s*?>    .*?             </\1>", RegexOptions.Singleline | RegexOptions.IgnorePatternWhitespace | RegexOptions.Compiled);
              @"<(\w+)      (?:\s+\w+\s*=\s*?(['" + "\"" + @"])   .*?              \2)     *\s*?>    .*?             </\1\s*>", 
          RegexOptions.Singleline | RegexOptions.IgnorePatternWhitespace | RegexOptions.Compiled);

        public static RichTextBox RTB
        {
            get { return _rtb; }
            set
            {
                _rtb = value;
                _NONSELECTED_COLOR = value.BackColor;
                _rtb.MouseDoubleClick += new MouseEventHandler(_rtb_MouseDoubleClick);
            }
        }
        /// <summary>
        /// If double click on one of matched item - select it, no action by default (selecting word)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static void _rtb_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int currentCursorPosition = RTB.GetCharIndexFromPosition(e.Location);
            for (int i = 0; i < _matches.Length; i++)
                if (_matches[i].X <= currentCursorPosition && currentCursorPosition < _matches[i].X + _matches[i].Y)
                {
                    RTB.Select(_matches[i].X, _matches[i].Y);
                    return;
                }
        }



        public static int CurrentMatchedSelected { get; private set; } //for external use
        private static PositionInMatches CursorBetweenMatches()
        {

            int lastSelectionNumber = -1;
            bool cursorOnBeginMatchedItem = false;
            int currentCursorPosition = RTB.SelectionStart;
            for (int i = 0; i < _matches.Length; i++)
                if (currentCursorPosition < _matches[i].X) 
                    break;
                else 
                    lastSelectionNumber = i;

            cursorOnBeginMatchedItem = lastSelectionNumber >= 0 &&
                lastSelectionNumber < _matches.Length &&
                currentCursorPosition == _matches[lastSelectionNumber].X;
            //&& RTB.SelectionLength == _matches[lastSelectionNumber].Y;
            return new PositionInMatches(lastSelectionNumber, cursorOnBeginMatchedItem);
        }
        public static void SelectNextMatched()
        {
            RTB.Focus();
            if (_matches.Length == 0) return;
            PositionInMatches p = CursorBetweenMatches();
            if (p.NextMatchedNumber >= _matches.Length) return;
            int selectMatches;
            if (p.CursorOnBeginMatchedItem && RTB.SelectionLength != _matches[p.PreviosMatchedNumber].Y) //if no previus matched selected, select it, other select next matched
                selectMatches = p.PreviosMatchedNumber;
            else
                selectMatches = p.NextMatchedNumber;

            if (selectMatches < 0) selectMatches = 0;
            //if (selectMatches > _matches.Length - 1) selectMatches = _matches.Length - 1; canceled: added check in start of function

            RTB.Select(_matches[selectMatches].X, _matches[selectMatches].Y);
            CurrentMatchedSelected = selectMatches + 1;
        }
        public static void SelectPreviosMatched()
        {
            RTB.Focus();
            if (_matches.Length == 0) return;
            PositionInMatches p = CursorBetweenMatches();
            int selectMatches = p.PreviosMatchedNumber;
            if (selectMatches < 0) return;
            if (p.CursorOnBeginMatchedItem) selectMatches--;
            if (selectMatches < 0) selectMatches = 0;

            RTB.Select(_matches[selectMatches].X, _matches[selectMatches].Y);
            CurrentMatchedSelected = selectMatches + 1;
        }
        public static int Matched { get { return _matches.Length; } }
        
        /// <summary>
        /// Mark by yellow matched text present in RTB if Type = PlainText, Regex or XML if it contain nodes, matched by xPath string
        /// </summary>
        /// <param name="template">string, regex expression or xPath expression</param>
        /// <param name="type">one of values: PlainText, Regex, xPath</param>
        /// <param name="IsIgnoreCase">not relevant for xPath</param>
        public static void Search(string template, SearchType type, bool IsIgnoreCase)
        {
            ClearMatched();
            _matches = new Point[0];
            int blueValue;
            RegexOptions reOpt;
            if (type == SearchType.xPath)
                SerarchAsXpath(template);
            else
            {
                if (string.IsNullOrEmpty(template)) return;
                reOpt = RegexOptions.Multiline;
                if (IsIgnoreCase) reOpt |= RegexOptions.IgnoreCase;
                if (type == SearchType.PlainText)
                    template = _searchRegexChars.Replace(template, @"\$1");
                SearchAsRegex(template, reOpt);
            }
            for (int i = 0; i < _matches.Length; i++)
            {

                if (_matches[i].Y < _CHAR_COUNT_FOR_MINIMUM_BLUE)
                    blueValue = _BLUE_MIN + _matches[i].Y * (_BLUE_MAX - _BLUE_MIN) / _CHAR_COUNT_FOR_MINIMUM_BLUE;
                else
                    blueValue = _BLUE_MAX;
                RTB.SelectionStart = _matches[i].X;
                RTB.SelectionLength = _matches[i].Y;
                RTB.SelectionBackColor = Color.FromArgb(250, 250, blueValue);

            }

        }
        private static void ClearMatched()
        {
            CurrentMatchedSelected = 0;
            if (_matches == null) return;
            for (int i = 0; i < _matches.Length; i++)
            {
                RTB.SelectionStart = _matches[i].X;
                RTB.SelectionLength = _matches[i].Y;
                RTB.SelectionBackColor = _NONSELECTED_COLOR;
            }
        }

        private static bool IsXpathMatched(XPathDocument doc, string xPath)
        {
            try
            {
                //System.Xml.XPath.XPathDocument d = new System.Xml.XPath.XPathDocument(
                //MemoryStream s = new MemoryStream(Encoding.UTF8.GetBytes(strXml));
                //XPathDocument doc = new XPathDocument(s);
                XPathNavigator nav = doc.CreateNavigator();
                /*System.Xml.XmlDocument d = new System.Xml.XmlDocument();
                d.LoadXml(strXml);
                d.SelectNodes(xPath);*/
                return nav.SelectSingleNode(xPath) != null;
                //return doc.SelectNodes(xPath).Count > 0;
            }
            catch (XPathException) { return false; }
        }
        private static void SerarchAsXpath(string xpath)
        {
            //XmlDocument doc = new XmlDocument();
            XPathDocument document;
            MemoryStream stream;
            try
            {
                //
                stream = new MemoryStream(Encoding.UTF8.GetBytes(RTB.Text));
                document = new XPathDocument(stream);
                if (IsXpathMatched(document, xpath)) _matches = new Point[1] { new Point(1, RTB.Text.Length) };
            }
            catch (System.Xml.XmlException ex)// xmlloadexception
            {
                MatchCollection xmlCollection = _searchXML.Matches(RTB.Text);
                List<Point> matchedXmls = new List<Point>();//(xmlCollection.Count);
                for (int i = 0; i < xmlCollection.Count; i++)
                {
                    try
                    {
                        //doc.LoadXml(xmlCollection[i].Value);
                        stream = new MemoryStream(Encoding.UTF8.GetBytes(xmlCollection[i].Value));
                        document = new XPathDocument(stream);
                        if (string.IsNullOrWhiteSpace(xpath) || IsXpathMatched(document, xpath))
                            matchedXmls.Add(new Point(xmlCollection[i].Index, xmlCollection[i].Length));
                    }
                    catch (System.Xml.XmlException ex1)
                    {
                        // nothing to do
                    }

                }
                _matches = matchedXmls.ToArray();
            }

        }

        private static void SearchAsRegex(string template, RegexOptions reOpt)
        {
            MatchCollection mc = Regex.Matches(RTB.Text, template, reOpt);
            _matches = new Point[mc.Count];
            for (int i = 0; i < mc.Count; i++)
                _matches[i] = new Point(mc[i].Index, mc[i].Length);
        }

    }
    struct PositionInMatches
    {
        private int previosMatchedNumber;
        public int PreviosMatchedNumber { get { return previosMatchedNumber; } }

        private int nextMatchedNumber;
        public int NextMatchedNumber { get { return nextMatchedNumber; } /*set; */}

        private bool cursorOnBeginMatchedItem;
        public bool CursorOnBeginMatchedItem { get { return cursorOnBeginMatchedItem; } }

        public PositionInMatches(int previosMatchedNumber, bool previosMatchedSelected)
        {
            this.previosMatchedNumber = previosMatchedNumber;
            this.nextMatchedNumber = previosMatchedNumber + 1;
            this.cursorOnBeginMatchedItem = previosMatchedSelected;
        }
    }
}
