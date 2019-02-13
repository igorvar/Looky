using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.IO;
using Shell32;
using System.Runtime.InteropServices;

namespace Experiments
{
    
    public partial class Form1 : Form
    {
        //[DllImport ("Shell32.dll")]
        

        //        private Timer _timer = new Timer();
        //bool _isRefreshNeed = false;
        private delegate void AddToLV(string fileName);
        private delegate void AddToLV_Arr(string[] fileNames);
        private System.Threading.Thread newTh;
       

        public Form1()
        {
            InitializeComponent();
            //            _timer.Tick += new EventHandler(_timer_Tick);
        }

        //      void _timer_Tick(object sender, EventArgs e)
        //        {
        //            _isRefreshNeed = true;
        //        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void WriteFiles(object _files)
        {
            System.IO.FileInfo[] files = (System.IO.FileInfo[])_files;
            string[] filesStr;
            var filesCount = 100;
            int i = 0;
            for (i = 0; i < files.Length; i += filesStr.Length)
            {
                filesStr = new string[filesCount];
                for (int j = 0; j < filesStr.Length && i + j < files.Length; j++)
                    filesStr[j] = files[i + j].Name;

                PutInLV(filesStr);


            }
            //foreach (System.IO.FileInfo fi in files)
            //PutInLV(fi.Name);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(/*@"c:\"*/@"\\Clalit\dfs$\SiebelFS\Sieblog");
            System.IO.FileInfo[] fi = di.GetFiles();

            var filteredFiles = from f in fi
                                where f.CreationTime.Date == DateTime.Today
                                select f;

            fi = filteredFiles.ToArray<System.IO.FileInfo>();


            listView1.Items.Clear();
            newTh = new System.Threading.Thread(new System.Threading.ParameterizedThreadStart(WriteFiles));
            newTh.Start(fi);

        }
        private void PutInLV(string fileName)
        {
            if (listView1.InvokeRequired)
            {
                AddToLV add = new AddToLV(PutInLV);
                Invoke(add, new object[] { fileName });

            }
            else
                listView1.Items.Add(fileName);

        }
        private void PutInLV(string[] files)
        {
            if (listView1.InvokeRequired)
            {
                //listView1.IsHandleCreated
                AddToLV_Arr add = new AddToLV_Arr(PutInLV);
                Invoke(add, new object[] { files });

            }
            else
            {
                int i;
                int arraySize = files.Length;
                if (files[arraySize - 1] == null)
                    arraySize = Array.IndexOf(files, null);
                ListViewItem[] listViewItems = new ListViewItem[arraySize];
                for (i = 0; i < arraySize && files[i] != null; i++)
                {
                    listViewItems[i] = new ListViewItem(files[i]);
                }
                listView1.BeginUpdate();
                listView1.Items.AddRange(listViewItems);
                listView1.EndUpdate();
                listView1.RedrawItems(0, 10, true);
            }
        }
        //

        StreamReader _sr;
        char[] _fileBuffer = null;
        int _bufferSize = 200;
        //int _readedBufferNo = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(@"\\Clalit\dfs$\SiebelFS\Sieblog\BCCHILAIF_20140625-081618.log");
            _sr = new StreamReader(file.FullName);
            _fileBuffer = new char[_bufferSize];
            ReadNextBlock();
            
        }
        void ReadNextBlock()
        {
            int charsReaded = -1;
            int currentPosition;
            charsReaded = _sr.ReadBlock(_fileBuffer, 0, _bufferSize);
            currentPosition = richTextBox1.SelectionStart;
            
            //richTextBox1.Text += new string(_fileBuffer, 0, charsReaded);
            richTextBox1.AppendText(new string(_fileBuffer, 0, charsReaded));
            richTextBox1.SelectionStart = currentPosition;
            richTextBox1.ScrollToCaret();
            //_readedBufferNo++;
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(@"\\Clalit\dfs$\SiebelFS\Sieblog\BCCHILAIF_20140625-081618.log");
            int bufferSize = 2048;
            char[] buf = null;
            int charsReaded = -1;
            string txt = string.Empty;
            using (StreamReader sr = new StreamReader(file.FullName))
            {
                buf = new char[bufferSize];
                charsReaded = sr.ReadBlock(buf, 0, bufferSize);
            }
            txt = new string(buf,0,charsReaded);
            richTextBox1.Text = txt;
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            StringBuilder sb = new StringBuilder();
            DateTime dt1;
            DateTime dt2;
            string resStr;
            //string fileName = @"\\Clalit\dfs$\SiebelFS\Sieblog\HIAMSA_20140713-080526.log";
            string fileName = @"\\Clalit\dfs$\SiebelFS\Sieblog\BCCHILAIF_20140625-081618.log";
            dt1 = DateTime.Now;
            using (StreamReader sr = new StreamReader(fileName))
            {
                int i;
                string txt;

                char[] buf = new char[100000];
                //while (line = sr.ReadBlock(buf,0,buf.Length)
                
                do
                {

                    i = sr.ReadBlock(buf, 0, buf.Length);
                    //txt = new string(buf);
                    sb.Append(buf, 0, i);
                }
                while (i > 0);

            }
            resStr = sb.ToString();
            dt2 = DateTime.Now;
            

            dt1 = DateTime.Now;
            resStr = File.ReadAllText(fileName);
            dt2 = DateTime.Now;
            dt1 = DateTime.Now;
           richTextBox1.Text = sb.ToString();
            dt2 = DateTime.Now;


        }
        private void f1()
        {
            string fileName = @"\\Clalit\dfs$\SiebelFS\Sieblog\HIAMSA_20140713-080526.log";
            FileStream f = new FileStream(fileName, FileMode.Open, FileAccess.Read/*, FileShare.None, 1024, FileOptions.Asynchronous*/);
            BufferedStream bs = new BufferedStream(f, 4096);
            byte[] b = new byte[4096];
            string s = "";
            int buf = 0;
            buf = bs.Read(b, 0, b.Length);

            for (int i = 0; i < b.Length; i++)
                s += b[i];
        }

        private void richTextBox1_ContentsResized(object sender, ContentsResizedEventArgs e)
        {

        }

        private void richTextBox1_VScroll(object sender, EventArgs e)
        {
            int row = richTextBox1.GetLineFromCharIndex(richTextBox1.SelectionStart) + 1;
            //richTextBox1.GetLineFromCharIndex(richTextBox1.SelectionStart);
            if (row >= richTextBox1.Lines.Length)
                ReadNextBlock();
            
        }

        private void btnShowProp_Click(object sender, EventArgs e)
        {

        }
        [DllImport("Kernel32.dll")]
        public extern static IntPtr LoadLibrary(string libName);
        [DllImport("User32.dll")]
        public extern static IntPtr LoadIcon(IntPtr libHandle, int lpIconName);

        private void GetIcons_Click(object sender, EventArgs e)
        {
            //Icon.ExtractAssociatedIcon(@"c:\WINDOWS\system32\shell32.dll");
            
            Icon[] pic = new Icon[150];
            Image[] im = new Image[150];
            IntPtr lib = LoadLibrary("shell32.dll");
            for (int i = 0; i < 150; i++)
            {
                

                //IntPtr gg = LoadIcon(LoadLibrary("shell32.dll"), 80);
                pic[i] = Icon.FromHandle(LoadIcon(LoadLibrary("shell32.dll"), i + 1));
                im[i] = pic[i].ToBitmap();
                im[i].Save(@"C:\pic\" + i.ToString() + ".Png", System.Drawing.Imaging.ImageFormat.Png);
            }
        }


    }
}
