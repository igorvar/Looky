using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
/*        enum RtfCreatorColorTypes
        {
            Matched
        }*/
        ListViewColumnSorter _lvwColumnSorter = null;
        FileFilter _fileFilter = null;
        private readonly Encoding DEFAULT_TEXT_ENCODING;
        private readonly Color BACKGROUND_COLOR_SEARCHFIELD_TEXT;
        private readonly Color BACKGROUND_COLOR_SEARCHFIELD_REGEXP;
        private readonly Color BACKGROUND_COLOR_SEARCHFIELD_XPATH;
        Dictionary<string, string> _extentionsDictionary = null;
        
        public Form1()
        {

           


            InitializeComponent();

            
            //cntxtMnFolder.ImageList = imageListFavoritMenu;
            //mniFavoritesNewName.ImageIndex = 1;
            
            //return;
            BACKGROUND_COLOR_SEARCHFIELD_TEXT = SystemColors.Window;
            BACKGROUND_COLOR_SEARCHFIELD_REGEXP = Color.FromArgb(/*192*/225, 255       , /*192*/225);
            BACKGROUND_COLOR_SEARCHFIELD_XPATH =  Color.FromArgb(/*192*/225, /*192*/225, 255);
    
            DEFAULT_TEXT_ENCODING = Encoding.Default;
            _lvwColumnSorter = new ListViewColumnSorter();
            lstRezults.ListViewItemSorter = _lvwColumnSorter;
            _fileFilter = new FileFilter(DEFAULT_TEXT_ENCODING);
            _fileFilter.RaiseFileProcessed += new EventHandler<FileProcessedEventArg>(_fileFilter_RaiseFileProcessed);
            //RtfCreator.AddColor(RtfCreatorColorTypes.Matched.ToString(), Color.Khaki);
            //_fileFilter.TimerElapsed += new EventHandler<ElapsedEventArg>(_fileFilter_TimerElapsed);
            // += new EventHandler<EventArgs>(_fileFilter_TimerElapsed);

            

            TextFileReader.RTB = this.rtbFileContent;
            TextFileReader.BufferSize = 16 * 1024;
            TextFileReader.DefaultEncoding = DEFAULT_TEXT_ENCODING;
            TextFileReader.BlockReaded += new TextFileReader.TextReaderEventHendler(TextFileReader_BlockReaded);
            TextFileReader.FileReadingCompleted += new EventHandler(TextFileReader_FileReadingCompleted);
                //+= new EventHandler(TextFileReader_BlockReaded);
            SearchProvider.RTB = this.rtbFileContent;


            

            /*string[] favoriteFolders = null;
            favoriteFolders = new string[] { @"C:\SiebelLog", @"\\Clalit\dfs$\SiebelFS\Sieblog" };
            for (int i = 0; i < favoriteFolders.Length; i++)
                FavoritesManagement.Add(favoriteFolders[i], favoriteFolders[i]);*/

            InitFavoritesMenu();
            
            //rtbFileContent.ContextMenu
        //        cntxtMnFolder.Items.Add(favoriteFolders[i]);
        //    ToolStripMenuItem o = cntxtMnFolder.Items[0];
            
            
        }

        void mi_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        void mi_DoubleClick(object sender, EventArgs e)
        {
//            throw new NotImplementedException();
        }






        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_fileReadThread != null && _fileReadThread.IsAlive) _fileReadThread.Abort();
        }

        /*void _fileFilter_TimerElapsed(object sender, ElapsedEventArg e)
        {
            progressBarProcessingFiles.Value = e.ProcessedFiles;
            for (int i = 0; i < e.FilteredInThisLoop.Length; i++)
            {
                ShowFile(new FileInfo(e.FilteredInThisLoop[i]));
            }
        }*/

        /*void _fileFilter_TimerElapsed(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            string[] filtered = _fileFilter.MatchedFiles;
            txtSearchIndicator.Text = ""; filtered.Length.ToString("0 files matched");
            progressBarProcessingFiles.Value = 5;//filtered.Length;
            for (int i = lstRezults.Items.Count; i < filtered.Length; i++)
                ShowFile(new FileInfo(filtered[i]));
        }*/

        void _fileFilter_RaiseFileProcessed(object sender, FileProcessedEventArg e)
        {
            //rtbFileContent.Text += e.Number + "\t" + e.IsMatched + "\t" + e.File + "\n";
            toolStripStatusLabelContextSearchResults.Text = e.Matched.ToString("0 files matched");
            //progresBarProcessingFiles.Value = e.Number;
            this.progressBarProcessingFiles.Value = e.Number;
            if (e.IsMatched) ShowFile(new FileInfo(e.File));
        }

        private void ContentSearchTypeExpression_Changed(object sender, EventArgs e)
        {
            if (rbContentText.Checked) txtContent.BackColor = BACKGROUND_COLOR_SEARCHFIELD_TEXT;
            if (rbContentRegex.Checked) txtContent.BackColor = BACKGROUND_COLOR_SEARCHFIELD_REGEXP;
            if (rbContentXpath.Checked) txtContent.BackColor = BACKGROUND_COLOR_SEARCHFIELD_XPATH;
        }

        private void txtFileMask_KeyPress(object sender, KeyPressEventArgs e) { if (e.KeyChar == (char)13) SearchFile(); }
        private void txtFolder_KeyPress(object sender, KeyPressEventArgs e) { if (e.KeyChar == (char)13) SearchFile(); }
        private void txtContent_KeyPress(object sender, KeyPressEventArgs e) { if (e.KeyChar == (char)13) SearchFile(); }
        private void rbDateNoRelevant_KeyPress(object sender, KeyPressEventArgs e) { if (e.KeyChar == (char)13) SearchFile(); }
        private void rbDateTypeCreation_KeyPress(object sender, KeyPressEventArgs e) { if (e.KeyChar == (char)13) SearchFile(); }
        private void rbDateTypeModification_KeyPress(object sender, KeyPressEventArgs e) { if (e.KeyChar == (char)13) SearchFile(); }

        private void rbContentText_KeyPress(object sender, KeyPressEventArgs e) { if (e.KeyChar == (char)13) SearchFile(); }
        private void rbContentRegex_KeyPress(object sender, KeyPressEventArgs e)    { if (e.KeyChar == (char)13) SearchFile(); }
        private void datePickerPeriodFrom_KeyPress(object sender, KeyPressEventArgs e) { if (e.KeyChar == (char)13) SearchFile(); }
        private void datePickerPeriodTo_KeyPress(object sender, KeyPressEventArgs e) { if (e.KeyChar == (char)13) SearchFile(); }
        private void rbPeriodWeek_KeyPress(object sender, KeyPressEventArgs e) { if (e.KeyChar == (char)13) SearchFile(); }
        private void rbPeriodMonth_KeyPress(object sender, KeyPressEventArgs e) { if (e.KeyChar == (char)13) SearchFile(); }
        private void rbPeriodDates_KeyPress(object sender, KeyPressEventArgs e) { if (e.KeyChar == (char)13) SearchFile(); }
        private void rbSizeNoRelevant_KeyPress(object sender, KeyPressEventArgs e) { if (e.KeyChar == (char)13) SearchFile(); }
        private void rbSizeMore_KeyPress(object sender, KeyPressEventArgs e) { if (e.KeyChar == (char)13) SearchFile(); }
        private void rbSizeLess_KeyPress(object sender, KeyPressEventArgs e) { if (e.KeyChar == (char)13) SearchFile(); }
        private void numSize_KeyPress(object sender, KeyPressEventArgs e) { if (e.KeyChar == (char)13) SearchFile(); }
        private void rbSizeUnitsKb_KeyPress(object sender, KeyPressEventArgs e) { if (e.KeyChar == (char)13) SearchFile(); }
        private void rbSizeUnits1000Kb_KeyPress(object sender, KeyPressEventArgs e) { if (e.KeyChar == (char)13) SearchFile(); }
        private void btnSearch_Click(object sender, EventArgs e)    {SearchFile();}


        private void SearchFile()//btnSearch_Click(object sender, EventArgs e)
        {
            /*string delMe = Path.GetDirectoryName(txtFileMask.Text).ToString();
            delMe = Path.GetFileName(txtFileMask.Text);
            //Path.GetDirectoryName
            return;*/

            //string[] files = null; 01.03.17 Nou used filesInfs

            FileInfo[] filesInfs = null;
            //List<FileInfo> listOfFiles = null;
            //FileInfo singleFile = null;
            DateTime dtPeriodFrom = DateTime.MinValue;
            DateTime dtPeriodTo = DateTime.Today;
            //bool isFileMatched = false;
            rtbFileContent.Clear();
            lstRezults.Items.Clear();
            toolStripStatusFilesFound.Text = "";
            toolStripStatusLabelContextSearchResults.Text = "";
            toolStripStatusLabelPositionInTextRow.Text = "";
            toolStripStatusLabelFileEncoding.Text = "";
            progressBarProcessingFiles.Visible = false;

            if (rbPeriodWeek.Checked)
                dtPeriodFrom = dtPeriodTo.Subtract(new TimeSpan(7, 0, 0, 0));
            if (rbPeriodMonth.Checked)
                dtPeriodFrom = dtPeriodTo.Subtract(new TimeSpan(30, 0, 0, 0));
            if (rbPeriodDates.Checked)
            {
                //dtPeriodTo = new DateTime(datePickerPeriodTo.Value.Year,datePickerPeriodTo.Value.Month,datePickerPeriodTo.Value.Day);
                dtPeriodTo = datePickerPeriodTo.Value.Date;
                //dtPeriodFrom = new DateTime(datePickerPeriodFrom.Value.Year, datePickerPeriodFrom.Value.Month, datePickerPeriodFrom.Value.Day);
                dtPeriodFrom = datePickerPeriodFrom.Value.Date;
            }

            if (!string.IsNullOrEmpty(txtFileMask.Text) && !string.IsNullOrEmpty(Path.GetDirectoryName(txtFileMask.Text)))
            {
                txtFolder.Text = Path.GetDirectoryName(txtFileMask.Text);
                txtFileMask.Text = Path.GetFileName(txtFileMask.Text);
                checkWithSubfolders.Checked = false;
            }


            string strFileMask = string.IsNullOrEmpty(txtFileMask.Text) ? "*" : txtFileMask.Text;
            if (!Regex.IsMatch(strFileMask, @"[\.\*\?]")) strFileMask = "*" + strFileMask + "*";
            //txtFileMask.Text = strFileMask;
            if (!Directory.Exists(txtFolder.Text))
            {
                MessageBox.Show("Folder\n" + txtFolder.Text + "\nnot present", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (strFileMask.Replace('*', '_').Replace('?', '_').IndexOfAny(Path.GetInvalidFileNameChars()) != -1)
            {
                //strFileMask.Replace('*','').Replace('?')
                MessageBox.Show("Illegal file name\n" + txtFileMask.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            /*
            files = Directory.GetFiles(txtFolder.Text, strFileMask);
            List<string> tmp = new List<string>(files);
            GetListOfFilesRecursive(txtFolder.Text, strFileMask, ref tmp);
            files = tmp.ToArray();
            */
            bool isContinueOnError = false;
            do
            {
                DirectoryInfo folderForSearch = new DirectoryInfo(txtFolder.Text);
                try
                {
                    
                    filesInfs = folderForSearch.GetFiles(strFileMask, checkWithSubfolders.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
                    /*files = Directory.GetFiles(
                        txtFolder.Text, strFileMask,
                        checkWithSubfolders.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);*/
                }
                catch (UnauthorizedAccessException ex)
                {
                    
                    DialogResult answer;
                    answer = MessageBox.Show(ex.Message + "\nIgnore - continue to search and skip all folders with Access unauthorized", "Access unauthorized", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
                    if (answer == DialogResult.Abort) return;
                    if (answer == DialogResult.Retry) isContinueOnError = true;
                    if (answer== DialogResult.Ignore)
                    {

                        string folderName = ex.Message.Substring(ex.Message.IndexOf("'") + 1, ex.Message.LastIndexOf("'") - ex.Message.IndexOf("'") - 1);
                        //files = Directory.GetFiles(txtFolder.Text, strFileMask);
                        filesInfs = folderForSearch.GetFiles(strFileMask);
                        //List<string> tmp = new List<string>(files);
                        List<FileInfo> tmp = new List<FileInfo>(filesInfs);
                        List<string> skipFolders = new List<string>(new string[] { folderName });
                        GetListOfFilesRecursive(txtFolder.Text, strFileMask, ref tmp, ref skipFolders);
                        MessageBox.Show(String.Join<string>("\n", skipFolders),"Skiped folders:",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        filesInfs = tmp.ToArray();
                    }
                }
            } while (isContinueOnError);

            this.progressBarProcessingFiles.Maximum = filesInfs/*files*/.Length;
            long fileSizeMin = 0;
            long fileSizeMax = long.MaxValue / 1000 / 1024;

            //if (rbSizeUnitsKb.Checked) 
            if (rbSizeMore.Checked)
                fileSizeMin = (long)numSize.Value;
            else fileSizeMax = (long)numSize.Value;


            if (rbSizeUnitsKb.Checked)
                { fileSizeMax *= 1024; fileSizeMin *= 1024; }
            else
                { fileSizeMax *= 1024 * 1000; fileSizeMin *= 1024 * 1000; }

            DateType searchDateType = rbDateNoRelevant.Checked ? DateType.NoRelevant : rbDateTypeCreation.Checked ? DateType.Created : DateType.Updated;
            lstRezults.Items.Clear();
            progressBarProcessingFiles.Visible = true;
            DateTime timeStampStart = DateTime.Now;
            /*_fileFilter.FilterFiles(
                strFileMask, files, 
                searchDateType, dtPeriodFrom, dtPeriodTo, 
                !rbSizeNoRelevant.Checked, fileSizeMin, fileSizeMax,
                txtContent.Text, rbContentText.Checked ? ContentExpressionType.Text : rbContentRegex.Checked ? ContentExpressionType.Regex:ContentExpressionType.Xpath);
            */
            DateTime timeStampEnd = DateTime.Now;

            progressBarProcessingFiles.Visible = false;

            lstRezults.Items.Clear();
            timeStampStart = DateTime.Now;
            FileInfo[] searchRez =
            _fileFilter.FilterFilesLINQ(
                strFileMask,
                //files,
                //(new DirectoryInfo(txtFolder.Text)).GetFiles(strFileMask, checkWithSubfolders.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly),
                filesInfs,
                searchDateType, dtPeriodFrom, dtPeriodTo,
                !rbSizeNoRelevant.Checked, fileSizeMin, fileSizeMax,
                txtContent.Text, rbContentText.Checked ? ContentExpressionType.Text : rbContentRegex.Checked ? ContentExpressionType.Regex : ContentExpressionType.Xpath);
            timeStampEnd = DateTime.Now;
            //return;
            //txtFolder.Text, strFileMask,
            //checkWithSubfolders.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
            //timeStampStart = DateTime.Now;
            /*for (int i = 0; i < searchRez.Length; i++)
            {
                ShowFile(searchRez[i]);
            }*/
            toolStripStatusFilesFound.Text = string.Format(" {0:n0} file{1} found", searchRez.Length, searchRez.Length == 1 ? "" : "s");
            ShowResults(searchRez);
            //timeStampEnd = DateTime.Now;

            txtContextSearch.Text = txtContent.Text;
            rbContextSearchText.Checked = rbContentText.Checked;
            rbContextSearchRegexp.Checked = rbContentRegex.Checked;
            rbContextSearchXpath.Checked = rbContentXpath.Checked;
            
        }

        private void GetListOfFilesRecursive(string folder, string fileMask, ref List<FileInfo> files, ref List<string> skipFolders )
        {
            string[] subFoldersList = Directory.GetDirectories(folder);
            FileInfo[] fileList;
            for (int i = 0; i < subFoldersList.Length; i++)
            {
                if (skipFolders.Contains(subFoldersList[i])) continue;
                //if (subFoldersList[i] == skipFolder) continue;
                try
                {
                    //fileList = Directory.GetFiles(subFoldersList[i], fileMask);
                    fileList = (new DirectoryInfo(subFoldersList[i])).GetFiles(fileMask);
                    files.AddRange(fileList);
                    GetListOfFilesRecursive(subFoldersList[i], fileMask, ref files, ref skipFolders);
                }
                catch(UnauthorizedAccessException)
                {
                    // skip folder with UnauthorizedAccessException
                    skipFolders.Add(subFoldersList[i]);
                }
                
               
            }
        }

        private void ExecuteContextSearch()
        {

            if (rbContextSearchText.Checked)
                SearchProvider.Search(txtContextSearch.Text, SearchType.PlainText, !chkBoxContextSearchCaseSensitive.Checked);
            else if (rbContextSearchRegexp.Checked)
                SearchProvider.Search(txtContextSearch.Text, SearchType.Regex, !chkBoxContextSearchCaseSensitive.Checked);
            else if (rbContextSearchXpath.Checked)
                SearchProvider.Search(txtContextSearch.Text, SearchType.xPath, true);
            toolStripStatusLabelContextSearchResults.Text = string.Format("{0:n0} item{1} found", (SearchProvider.Matched == 0 ? "No" : SearchProvider.Matched.ToString()), SearchProvider.Matched == 1 ? "" : "s");
            rtbFileContent.SelectionStart = 0;
            rtbFileContent.SelectionLength = 0;
            return;

            string txt = rtbFileContent.Text;
            string searchAt = txtContextSearch.Text;
            RegexOptions reOpt = RegexOptions.Multiline ;//& */RegexOptions.IgnoreCase;
            

            if (rbContextSearchText.Checked)
            {
                if (string.IsNullOrEmpty(searchAt)) return;
                searchAt = Regex.Replace(
                          searchAt,
                          @"([\(\)\.\[\]\}\\\$\^\|\+|\*\?])",
                          @"\$1");
            }
            if (!chkBoxContextSearchCaseSensitive.Checked) reOpt |= RegexOptions.IgnoreCase;
            MatchCollection mc = Regex.Matches(txt, searchAt,reOpt );
            for (int i = 0; i < mc.Count; i++)
            {
                rtbFileContent.SelectionStart = mc[i].Index;
                rtbFileContent.SelectionLength = mc[i].Length;
                //rtbFileContent.SelectionBackColor = Color.GreenYellow;
                int blueDelta ; // max value of blue component
                int blueMin = 10;
                int blueMax = 220;
                blueDelta = blueMax;
                if (mc[i].Length < 40) // 40 - chars most light yellow 
                    blueDelta = blueMin + (blueMax - blueMin) / 40 * mc[i].Length;
                //blue = 32;
                rtbFileContent.SelectionBackColor = Color.FromArgb(250, 250, blueDelta);
            }
            toolStripStatusLabelContextSearchResults.Text = string.Format("{0:n0} item{1} found ", SearchProvider.Matched, SearchProvider.Matched == 1 ? "" : "s");
            rtbFileContent.SelectionStart = 0;
            rtbFileContent.SelectionLength = 0;
            
        }
        

        void ShowFile(FileInfo file)
        {
            OsFileInfo osfi;
            if (_extentionsDictionary == null) _extentionsDictionary = new Dictionary<string, string>();
            string fileExt = "EXT_" + file.Extension.ToUpper();
            if (!_extentionsDictionary.ContainsKey(fileExt))
            {
                osfi = GetSystemInfo(file);
                _extentionsDictionary.Add(fileExt, osfi.TypeName);
                lstRezults.SmallImageList.Images.Add(fileExt, osfi.Icon);
            }
            ListViewItem li = new ListViewItem(
            new string[]{file.Name, 
                file.DirectoryName, 
                String.Format("{0:n0} KB", .49 + file.Length / 1024.0),
                _extentionsDictionary[fileExt],
                file.CreationTime.ToString("dd.MM.yy HH:mm"),
                file.LastWriteTime.ToString("dd.MM.yy HH:mm")},
                fileExt);
            li.Tag = file;
            lstRezults.Items.Add(li);
        }
        private void ShowResults(FileInfo[] listOfFiles)
        {
            ListViewItem[] lviCollection = new ListViewItem[listOfFiles.Length];
            lstRezults.Items.Clear();
            //ImageList smallIcons = new ImageList();
            ImageList smallIcons = lstRezults.SmallImageList;
            Dictionary<string, OsFileInfo> extentionsDictionary = new Dictionary<string, OsFileInfo>();
            OsFileInfo osfi;//= null;
            string fileExt;

            for (int i = 0; i < listOfFiles.Length; i++)
            {
                fileExt = listOfFiles[i].Extension.ToUpper();
                if (!extentionsDictionary.ContainsKey(fileExt))
                {
                    osfi = GetSystemInfo(listOfFiles[i]);
                    //osfi.Index = extentionsDictionary.Count;
                    if (!smallIcons.Images.Keys.Contains("EXT_" + fileExt))
                        smallIcons.Images.Add("EXT_" + fileExt, osfi.Icon);

                    //extentionsDictionary.Add(listOfFiles[i].Extension.ToUpper(), extentionsDictionary.Count);
                    extentionsDictionary.Add(fileExt, osfi);
                }
                //lstRezults.SmallImageList.Images.Add(ic);
                ListViewItem li = new ListViewItem(listOfFiles[i].Name);
                //li.Tag = listOfFiles[i];
                li.Tag = new FileInfoExtended(listOfFiles[i], null);
                //li.ImageIndex = (extentionsDictionary[fileExt]).Index;
                li.ImageKey = "EXT_" + fileExt;
                li.SubItems.Add(listOfFiles[i].DirectoryName);
                li.SubItems.Add(String.Format("{0:n0} KB", .49 + listOfFiles[i].Length / 1024.0));
                li.SubItems.Add(/*listOfFiles[i].Extension*/ extentionsDictionary[fileExt].TypeName);
                li.SubItems.Add(listOfFiles[i].CreationTime.ToString("dd.MM.yy HH:mm"));
                li.SubItems.Add(listOfFiles[i].LastWriteTime.ToString("dd.MM.yy HH:mm"));
                lviCollection[i] = li;
                //lstRezults.Items.Add(li);

            }
            lstRezults.Items.AddRange(lviCollection);
            lstRezults.SmallImageList = smallIcons;
        }


        OsFileInfo GetSystemInfo(FileInfo file)
        {
            Icon i = null;
            Shell32.SHFILEINFO shfi = new Shell32.SHFILEINFO();
            Shell32.SHGetFileInfo(file.FullName,
                Shell32.FILE_ATTRIBUTE_NORMAL,
                ref shfi,
                (uint)System.Runtime.InteropServices.Marshal.SizeOf(shfi),
                Shell32.SHGFI_ICON |
                Shell32.SHGFI_USEFILEATTRIBUTES | /*Shell32.SHGFI_LARGEICON*/
                Shell32.SHGFI_SMALLICON |
                Shell32.SHGFI_TYPENAME);
            i = (Icon)Icon.FromHandle(shfi.hIcon).Clone();

            OsFileInfo fi = new OsFileInfo();
            fi.TypeName = shfi.szTypeName;
            fi.Icon = (Icon)Icon.FromHandle(shfi.hIcon).Clone();
            User32.DestroyIcon(shfi.hIcon);
            return fi;
        }
        #region file reading thread
        //private delegate void AddRowDelegate(string row);
        private System.Threading.Thread _fileReadThread = null;//new System.Threading.Thread(new System.Threading.ParameterizedThreadStart(TextFileReader.BeginRead));
        /*private void WriteRow(object fileInfo)
        {
            int _bufferSize = 2048;

            char[] buffer = new char[_bufferSize];
            int readedChars = -1;
            FileInfo file = (FileInfo)fileInfo;


            using (StreamReader sr = new StreamReader(file.FullName))
            {
                do
                {
                    readedChars = sr.ReadBlock(buffer, 0, _bufferSize);
                    AddLine(new string(buffer, 0, readedChars));
                }
                while (readedChars > 0);
            }
            progressBarProcessingFiles.Visible = false;

        }*/
        /*private void AddLine(string line)
        {
            if (rtbFileContent.InvokeRequired)
            {
                AddRowDelegate del = new AddRowDelegate(AddLine);
                this.Invoke(del, new object[] { line });
            }
            else
            {
                //rtbFileContent.Text += line+'\n';
                rtbFileContent.AppendText(line);
                //rtbFileContent.Refresh();
            }
        }*/
        #endregion

        void TextFileReader_FileReadingCompleted(object sender, EventArgs e)
        {
            progressBarProcessingFiles.Visible = false;
            ExecuteContextSearch();
        }
        void TextFileReader_BlockReaded(object sender, BlockReadedEventArg e)
        {
            /*int val = Math.Min(progressBarProcessingFiles.Value + (int)(BytesReaded) / 1024,
                                    progressBarProcessingFiles.Maximum);*/
            if (e.ReadedPercent < 100)
                progressBarProcessingFiles.Value = e.ReadedPercent;
            //else
            //    progressBarProcessingFiles.Visible = false;    

        }
        private void lstRezults_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fileContent;
            DialogResult answer;
            FileInfoExtended fi;
            rtbFileContent.Tag = null;
            if (_fileReadThread != null && _fileReadThread.IsAlive) _fileReadThread.Abort();
            if (lstRezults.SelectedItems.Count == 0) return;
            ListViewItem selectedItem = lstRezults.SelectedItems[lstRezults.SelectedItems.Count - 1];
            progressBarProcessingFiles.Visible = false;
            fi = (FileInfoExtended)lstRezults.SelectedItems[lstRezults.SelectedItems.Count - 1].Tag;
            fi.FileInfoStandard.Refresh();
            if (!fi.FileInfoStandard.Exists)
            {
                answer = MessageBox.Show("File " + fi.FileInfoStandard.Name + " not exist in folder " + fi.FileInfoStandard.DirectoryName + ".\nWould you want remove it from search results?", "File not found", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == System.Windows.Forms.DialogResult.No) return;
                selectedItem.Remove();
                return;
            }

            rtbFileContent.Clear();
            if (fi.FileInfoStandard.Length / 1024 > numContextShowSizeUpBound.Value)
            {
                //rtbFileContent.ForeColor = Color.Red;
                //rtbFileContent.Font = new System.Drawing.Font("Tahoma", 15);
                rtbFileContent.Text = "<< File is too large >>";
                return;
            }
            if (fi.FileEncoding == null)
            {
                Encoding enc = TextFileReader.GetEncoding(fi.FileInfoStandard);
                if (enc == null) enc = DEFAULT_TEXT_ENCODING;
                fi.FileEncoding = enc;
            }
            toolStripStatusLabelFileEncoding.Text = fi.FileEncoding.BodyName;
            if (fi.FileInfoStandard.Length < TextFileReader.BufferSize/* * 1024*/) // for files more then 100 k read without thread
            {
                rtbFileContent.Text = File.ReadAllText(fi.FileInfoStandard.FullName, fi.FileEncoding);
                ExecuteContextSearch();
                return;
            }

            //TextFileReader tfr = new TextFileReader(rtbFileContent, 4 * 1024);

            progressBarProcessingFiles.Value = 0;
            //progressBarProcessingFiles.Maximum = (int)(fi.Length / 1024);
            progressBarProcessingFiles.Maximum = 100;
            progressBarProcessingFiles.Visible = true;
            _fileReadThread = new System.Threading.Thread(new System.Threading.ParameterizedThreadStart(TextFileReader.BeginRead));
            _fileReadThread.Start(fi);
            return;



            /*fileContent = File.ReadAllText(fi.FullName);
            DateTime timeStampEnd = DateTime.Now;
            RtfCreator rtfCreator = new RtfCreator(fileContent);
            rtbFileContent.Clear();
            
            if ((rbContentText.Checked || rbContentRegex.Checked) && !string.IsNullOrEmpty(txtContent.Text))
            {
                MatchCollection mc = null;
                string regExpPatern = txtContent.Text;
                if (rbContentText.Checked)
                    regExpPatern = Regex.Replace(regExpPatern, @"[.?\\*]", "\\$&");
                mc = Regex.Matches(rtfCreator.Text, regExpPatern, RegexOptions.IgnoreCase);
                for (int i = 0; i < mc.Count; i++)
                    rtfCreator.MarkText(RtfCreator.MarkType.BackGround, RtfCreatorColorTypes.Matched.ToString(), mc[i].Index, mc[i].Length);
                rtbFileContent.Rtf = rtfCreator.Rtf;
            }

            else
                rtbFileContent.Text = fileContent;
            timeStampEnd = DateTime.Now;
            rtbFileContent.Tag = null;*/
        }


        private void lstRezults_DoubleClick(object sender, EventArgs e)
        {
            if (lstRezults.SelectedItems.Count <= 0) return;
            FileInfo fi = ((FileInfoExtended)lstRezults.SelectedItems[lstRezults.SelectedItems.Count - 1].Tag).FileInfoStandard;
            try
            {
                OpenFileWithOS(fi.FullName);
            }
            catch (Win32Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void OpenFileWithOS(string fileName)
        {
            System.Diagnostics.Process.Start(fileName);
        }

        private void lstRezults_ColumnClick(object sender, ColumnClickEventArgs e)
        {

            //string arrowUp = " ▲";
            //string arrowDown = " ▼";
            for (int i = 0; i < lstRezults.Columns.Count; i++)
                lstRezults.Columns[i].ImageKey = "";

            if (e.Column == _lvwColumnSorter.ColumnToSort)
                if (_lvwColumnSorter.OrderOfSort == SortOrder.Ascending)
                {
                    _lvwColumnSorter.OrderOfSort = SortOrder.Descending;
                    lstRezults.Columns[e.Column].ImageKey = "SortDesc";
                }
                else
                {
                    _lvwColumnSorter.OrderOfSort = SortOrder.Ascending;
                    lstRezults.Columns[e.Column].ImageKey = "SortAsc";
                }
            else
            {
                _lvwColumnSorter.ColumnToSort = e.Column;
                _lvwColumnSorter.OrderOfSort = SortOrder.Ascending;
                lstRezults.Columns[e.Column].ImageKey = "SortAsc";
            }
            lstRezults.Sort();
        }

        private void chkBoxContentWrapText_CheckedChanged(object sender, EventArgs e)
        {
            rtbFileContent.WordWrap = chkBoxContentWrapText.Checked;
        }

        private void rtbFileContent_Enter(object sender, EventArgs e)
        {
            //rtbFileContent.HideSelection = true;
            /*int start = rtbFileContent.SelectionStart;
            int len = rtbFileContent.SelectionLength;
            rtbFileContent.SelectedRtf = (string)rtbFileContent.Tag;
            rtbFileContent.SelectionStart = start;
            rtbFileContent.SelectionLength = len;
            rtbFileContent.Tag = null;*/

        }

        private void rtbFileContent_Leave(object sender, EventArgs e)
        {
            //rtbFileContent.Tag = rtbFileContent.SelectedRtf;
            //rtbFileContent.SelectionBackColor = Color.Silver;//Color.FromKnownColor(KnownColor.InactiveBorder);
        }

        private void rtbFileContent_SelectionChanged(object sender, EventArgs e)
        {
            int row = rtbFileContent.GetLineFromCharIndex(rtbFileContent.SelectionStart) + 1;
            int column = rtbFileContent.SelectionStart - rtbFileContent.GetFirstCharIndexOfCurrentLine() + 1;
            toolStripStatusLabelPositionInTextRow.Text = "   Ln " + row.ToString() + ", Col " + column.ToString();
        }

        private void grpPeriod_EnabledChange(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            grpPeriod.Enabled = !rbDateNoRelevant.Checked;
        }

        private void grpSize_EnabledChange(object sender, EventArgs e)
        {
            grpSizeUnits.Enabled = numSize.Enabled = !rbSizeNoRelevant.Checked;
        }

        private void chkBoxSearchCaseSensitive_EnabledChange(object sender, EventArgs e)
        {
            chkBoxContextSearchCaseSensitive.Enabled = !rbContextSearchXpath.Checked;
            if (rbContextSearchText.Checked) txtContextSearch.BackColor = BACKGROUND_COLOR_SEARCHFIELD_TEXT;
            if (rbContextSearchRegexp.Checked) txtContextSearch.BackColor = BACKGROUND_COLOR_SEARCHFIELD_REGEXP;
            if (rbContextSearchXpath.Checked) txtContextSearch.BackColor = BACKGROUND_COLOR_SEARCHFIELD_XPATH;
            
        }

        private void txtContextSearch_Validated(object sender, EventArgs e)
        {
            //ExecuteContextSearch();    
        }

        private void txtContextSearch_Validating(object sender, CancelEventArgs e)
        {

        }
        private void txtContextSearch_KeyPress(object sender, KeyPressEventArgs e) { if (e.KeyChar == (char)13) ExecuteContextSearch(); }
        private void chkBoxContextSearchCaseSensitive_KeyPress(object sender, KeyPressEventArgs e) { if (e.KeyChar == (char)13) ExecuteContextSearch(); }
        private void rbContextSearchText_KeyPress(object sender, KeyPressEventArgs e) { if (e.KeyChar == (char)13) ExecuteContextSearch(); }
        private void rbContextSearchRegexp_KeyPress(object sender, KeyPressEventArgs e) { if (e.KeyChar == (char)13) ExecuteContextSearch(); }
        private void rbContextSearchXpath_KeyPress(object sender, KeyPressEventArgs e) { if (e.KeyChar == (char)13) ExecuteContextSearch(); }
        private void btnContextSearchExecute_Click(object sender, EventArgs e)
        {
            ExecuteContextSearch();
            //SearchProvider.SelectNextMatched();
           
        }

        private void btnContextSearchNext_Click(object sender, EventArgs e)
        {
            SearchProvider.SelectNextMatched();
            string selectedMatched;
            selectedMatched = SearchProvider.CurrentMatchedSelected.ToString();
            if (SearchProvider.CurrentMatchedSelected == 1) selectedMatched = "First";
            if (SearchProvider.CurrentMatchedSelected == SearchProvider.Matched) selectedMatched = "Last";
            toolStripStatusLabelContextSearchResults.Text = string.Format("{0} of {1} found", selectedMatched, SearchProvider.Matched);
        }

        private void btnContextSearchPrev_Click(object sender, EventArgs e)
        {
            SearchProvider.SelectPreviosMatched();
            string selectedMatched;
            selectedMatched = SearchProvider.CurrentMatchedSelected.ToString();
            if (SearchProvider.CurrentMatchedSelected == 1) selectedMatched = "First";
            if (SearchProvider.CurrentMatchedSelected == SearchProvider.Matched) selectedMatched = "Last";
            toolStripStatusLabelContextSearchResults.Text = string.Format("{0} of {1} found", selectedMatched, SearchProvider.Matched);
            //toolStripStatusLabelContextSearchResults.Text = string.Format("{0} of {1} found", SearchProvider.CurrentMatchedSelected, SearchProvider.Matched);
        }

        private void datePickerPeriodFrom_Validated(object sender, EventArgs e)
        {
            rbPeriodDates.Checked = true;
        }

        private void datePickerPeriodTo_Validated(object sender, EventArgs e)
        {
            rbPeriodDates.Checked = true;
        }

        private void cntxtMnFolder_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
            string tag = (string)e.ClickedItem.Tag;
            int favIndex = int.Parse(Regex.Match(tag, @"\d+").Value);
            txtFolder.Text = FavoritesManagement.Favorites[favIndex].Value;
            
        }

        private void mniFavoritesNewAdd_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(mniFavoritesNewName.Text);
            FavoritesManagement.Add(mniFavoritesNewName.Text, txtFolder.Text);
            InitFavoritesMenu();
        }

        private void InitFavoritesMenu()
        {
            string tagFavoriteSymbol = "FAVORITE";
            ToolStripMenuItem mi = null;// new ToolStripMenuItem();
            ToolStripMenuItem miRemove = null; //new ToolStripMenuItem();
            string tag;
            for (int i = cntxtMnFolder.Items.Count - 1; i >= 0; i--)
            {
                tag = (string)cntxtMnFolder.Items[i].Tag;
                if (!string.IsNullOrEmpty(tag) && tag.IndexOf(tagFavoriteSymbol) > -1)
                    cntxtMnFolder.Items.Remove(cntxtMnFolder.Items[i]);
            }

            //mniFavoritesManagement
            mniFavoritesRemoveFolder.DropDownItems.Clear();

            
            KeyValuePair<string, string> fav;
            for (int i = 0; i < FavoritesManagement.Favorites.Length; i++)
            {
                fav = FavoritesManagement.Favorites[i];
                
                //mi = cntxtMnFolder.Items[0];
                mi = new ToolStripMenuItem(fav.Key);
                mi.Tag = tagFavoriteSymbol + i.ToString();
                //mi.DisplayStyle = ToolStripItemDisplayStyle.Text;
                mi.ToolTipText = fav.Value;
                /*string s =Path.GetDirectoryName(fav.Value);
                s = Path.GetFileName(fav.Value);
                s = new DirectoryInfo(fav.Value + @"\\\\\\").FullName;
                OsFileInfo o = GetSystemInfo(new FileInfo(@"\\Clalit\dfs$\SiebelFS\Sieblog\"));*/
                //mi.Image = o.Icon.ToBitmap();
                
                //mi.Image = imageListFavoritMenu.Images[0]; now tot showing
                
                cntxtMnFolder.Items.Insert(cntxtMnFolder.Items.Count - 1, mi);
                //cntxtMnFolder.Items.Add(mi);

                miRemove = new ToolStripMenuItem(mi.Text);
                miRemove.ToolTipText = mi.ToolTipText;
                miRemove.Tag = i.ToString();
                miRemove.Image = imageListFavoritMenu.Images[1];
                
                //mi=new ToolStripMenuItem(mi.Text)
                mniFavoritesRemoveFolder.DropDownItems.Add(miRemove);
            }
             return;

        }

        private void mniFavoritesRemoveFolder_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            DialogResult rez =
                MessageBox.Show("Remove reference " + e.ClickedItem.Text + "\n to folder \n" + e.ClickedItem.ToolTipText, "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rez != System.Windows.Forms.DialogResult.Yes) return;
            FavoritesManagement.Remove(int.Parse((string)(e.ClickedItem.Tag)));
            InitFavoritesMenu();
        }


        private void PeriodDates_Enabled(object sender, EventArgs e)
        {
            datePickerPeriodTo.Enabled = datePickerPeriodFrom.Enabled = rbPeriodDates.Checked;
        }
    }
}
