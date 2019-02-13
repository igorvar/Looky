using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading;
using System.Windows.Forms;
using System.IO;
using Ude;


namespace WindowsFormsApplication1
{
    
    /**/
    class BlockReadedEventArg : EventArgs
    {
        public BlockReadedEventArg(byte readedPercent)
        {
            ReadedPercent = readedPercent;
        }
        public int ReadedPercent { get; private set; }

    }
    static class TextFileReader
    {
        //public static event EventHandler BlockReaded;
        private delegate void AddBlockDelegate(string fileName);
        private delegate void ReadingCompletedDelegate();
        public delegate void TextReaderEventHendler(object sender, BlockReadedEventArg e);

        public static event TextReaderEventHendler BlockReaded;
        public static event EventHandler FileReadingCompleted;
        public static Encoding DefaultEncoding{ get; set; } 
        public static RichTextBox RTB { get; set; }
        public static int BufferSize { get; set; }
        private static byte ReadedPercent { get; set; }
        
        private static Control RtbParent
        {
            get
            {
                return RTB.Parent;
            }
        }
        public static Encoding GetEncoding(FileInfo file)
        {
            try
            {
                using (FileStream fs = File.OpenRead(file.FullName))
                {
                    ICharsetDetector cdet = new CharsetDetector();
                    cdet.Feed(fs);
                    cdet.DataEnd();
                    if (cdet.Charset != null)
                        return Encoding.GetEncoding(cdet.Charset);
                    else
                        return DefaultEncoding;
                    //return cdet.Charset;
                }
            }
            catch (IOException)
            {

                return null;
            }
        }
        public static void BeginRead(/*FileInfo*/ object File)
        {
            char[] buffer = new char[BufferSize];
            int readedChars = -1;
            FileInfo fi = ((FileInfoExtended)File).FileInfoStandard;

            //using (StreamReader sr = new StreamReader(fi.FullName))
            Encoding encoding = ((FileInfoExtended)File).FileEncoding;
            //using (StreamReader sr = new StreamReader(fi.FullName,,))
            using (StreamReader sr = new StreamReader(fi.FullName, encoding))
            {
                do
                {
                    readedChars = sr.ReadBlock(buffer, 0, BufferSize);
                    ReadedPercent = (byte)(100.0 * sr.BaseStream.Position / sr.BaseStream.Length);
                    AddBlock(new string(buffer, 0, readedChars));
                    OnBlockReaded();
                }
                while (readedChars > 0);
                OnFileReadingCompleted();
            }
        }
        private static void OnFileReadingCompleted()
        {
            
            //if (FileReadingCompleted == null) return;
            if (RTB.Parent.InvokeRequired)
            {
                if (FileReadingCompleted == null) return;
                ReadingCompletedDelegate del = new ReadingCompletedDelegate(OnFileReadingCompleted);
                RTB.Parent.Invoke(del);
            }
            else
                FileReadingCompleted(null, new EventArgs());
        }
        private static void OnBlockReaded()
        {
            //if (BlockReaded == null) return;
            if (RTB.Parent.InvokeRequired)
            {
                if (BlockReaded == null) return;
                ReadingCompletedDelegate del = new ReadingCompletedDelegate(OnBlockReaded);
                RtbParent.Parent.Invoke(del);
            }
            else
                BlockReaded(null, new BlockReadedEventArg(ReadedPercent));
        }

        
        private static void AddBlock(string line)
        {
            if (RTB.InvokeRequired)
            {
                AddBlockDelegate del = new AddBlockDelegate(AddBlock);
                RTB.Parent.Invoke(del, new object[] { line });
            }
            else
            {
                RTB.AppendText(line);
                //OnBlockReaded();
            }
        }
    }
}
