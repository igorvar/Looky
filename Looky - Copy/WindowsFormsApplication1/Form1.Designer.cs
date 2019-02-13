namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.cntxtMnFolder = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mniFavoritesManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.mniFavoritesAddFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.mniFavoritesNewName = new System.Windows.Forms.ToolStripTextBox();
            this.mniFavoritesNewAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mniFavoritesRemoveFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.txtFileMask = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.grpDate = new System.Windows.Forms.GroupBox();
            this.rbDateNoRelevant = new System.Windows.Forms.RadioButton();
            this.rbDateTypeModification = new System.Windows.Forms.RadioButton();
            this.rbDateTypeCreation = new System.Windows.Forms.RadioButton();
            this.grpPeriod = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.datePickerPeriodTo = new System.Windows.Forms.DateTimePicker();
            this.datePickerPeriodFrom = new System.Windows.Forms.DateTimePicker();
            this.rbPeriodDates = new System.Windows.Forms.RadioButton();
            this.rbPeriodMonth = new System.Windows.Forms.RadioButton();
            this.rbPeriodWeek = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.checkWithSubfolders = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbSizeNoRelevant = new System.Windows.Forms.RadioButton();
            this.rbSizeLess = new System.Windows.Forms.RadioButton();
            this.rbSizeMore = new System.Windows.Forms.RadioButton();
            this.numSize = new System.Windows.Forms.NumericUpDown();
            this.grpSizeUnits = new System.Windows.Forms.GroupBox();
            this.rbSizeUnitsKb = new System.Windows.Forms.RadioButton();
            this.rbSizeUnits1000Kb = new System.Windows.Forms.RadioButton();
            this.splitConditionalRezults = new System.Windows.Forms.SplitContainer();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbContentXpath = new System.Windows.Forms.RadioButton();
            this.rbContentRegex = new System.Windows.Forms.RadioButton();
            this.rbContentText = new System.Windows.Forms.RadioButton();
            this.lstRezults = new System.Windows.Forms.ListView();
            this.clmnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnInFolder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnDateCreated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnDateModidied = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageListSmallImagesForListView = new System.Windows.Forms.ImageList(this.components);
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.panelTextContent = new System.Windows.Forms.Panel();
            this.btnContextSearchPrev = new System.Windows.Forms.Button();
            this.btnContextSearchNext = new System.Windows.Forms.Button();
            this.btnContextSearchExecute = new System.Windows.Forms.Button();
            this.chkBoxContextSearchCaseSensitive = new System.Windows.Forms.CheckBox();
            this.rbContextSearchXpath = new System.Windows.Forms.RadioButton();
            this.rbContextSearchRegexp = new System.Windows.Forms.RadioButton();
            this.rbContextSearchText = new System.Windows.Forms.RadioButton();
            this.txtContextSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numContextShowSizeUpBound = new System.Windows.Forms.NumericUpDown();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusFilesFound = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelContextSearchResults = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelPositionInTextRow = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelFileEncoding = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBarProcessingFiles = new System.Windows.Forms.ToolStripProgressBar();
            this.chkBoxContentWrapText = new System.Windows.Forms.CheckBox();
            this.rtbFileContent = new System.Windows.Forms.RichTextBox();
            this.checkBoxRegex = new System.Windows.Forms.CheckBox();
            this.imageListFavoritMenu = new System.Windows.Forms.ImageList(this.components);
            this.cntxtMnFolder.SuspendLayout();
            this.grpDate.SuspendLayout();
            this.grpPeriod.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).BeginInit();
            this.grpSizeUnits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitConditionalRezults)).BeginInit();
            this.splitConditionalRezults.Panel1.SuspendLayout();
            this.splitConditionalRezults.Panel2.SuspendLayout();
            this.splitConditionalRezults.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.panelTextContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numContextShowSizeUpBound)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Folder";
            // 
            // txtFolder
            // 
            this.txtFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFolder.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtFolder.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtFolder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFolder.ContextMenuStrip = this.cntxtMnFolder;
            this.txtFolder.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtFolder.Location = new System.Drawing.Point(51, 10);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(210, 17);
            this.txtFolder.TabIndex = 0;
            this.txtFolder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFolder_KeyPress);
            // 
            // cntxtMnFolder
            // 
            this.cntxtMnFolder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFavoritesManagement});
            this.cntxtMnFolder.Name = "cntxtMnFolder";
            this.cntxtMnFolder.ShowImageMargin = false;
            this.cntxtMnFolder.Size = new System.Drawing.Size(155, 26);
            this.cntxtMnFolder.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cntxtMnFolder_ItemClicked);
            // 
            // mniFavoritesManagement
            // 
            this.mniFavoritesManagement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFavoritesAddFolder,
            this.mniFavoritesRemoveFolder});
            this.mniFavoritesManagement.Name = "mniFavoritesManagement";
            this.mniFavoritesManagement.Size = new System.Drawing.Size(154, 22);
            this.mniFavoritesManagement.Text = "Favorite management";
            // 
            // mniFavoritesAddFolder
            // 
            this.mniFavoritesAddFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mniFavoritesAddFolder.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFavoritesNewName,
            this.mniFavoritesNewAdd});
            this.mniFavoritesAddFolder.Name = "mniFavoritesAddFolder";
            this.mniFavoritesAddFolder.Size = new System.Drawing.Size(221, 22);
            this.mniFavoritesAddFolder.Text = "Add current folder to favorites";
            // 
            // mniFavoritesNewName
            // 
            this.mniFavoritesNewName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mniFavoritesNewName.Name = "mniFavoritesNewName";
            this.mniFavoritesNewName.Size = new System.Drawing.Size(100, 21);
            this.mniFavoritesNewName.ToolTipText = "Type lable for folder and select \"Add\"";
            // 
            // mniFavoritesNewAdd
            // 
            this.mniFavoritesNewAdd.Image = ((System.Drawing.Image)(resources.GetObject("mniFavoritesNewAdd.Image")));
            this.mniFavoritesNewAdd.Name = "mniFavoritesNewAdd";
            this.mniFavoritesNewAdd.Size = new System.Drawing.Size(160, 22);
            this.mniFavoritesNewAdd.Text = "Add";
            this.mniFavoritesNewAdd.Click += new System.EventHandler(this.mniFavoritesNewAdd_Click);
            // 
            // mniFavoritesRemoveFolder
            // 
            this.mniFavoritesRemoveFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mniFavoritesRemoveFolder.Name = "mniFavoritesRemoveFolder";
            this.mniFavoritesRemoveFolder.Size = new System.Drawing.Size(221, 22);
            this.mniFavoritesRemoveFolder.Text = "Remove from favorites";
            this.mniFavoritesRemoveFolder.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mniFavoritesRemoveFolder_DropDownItemClicked);
            // 
            // txtFileMask
            // 
            this.txtFileMask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileMask.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFileMask.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtFileMask.Location = new System.Drawing.Point(70, 36);
            this.txtFileMask.Name = "txtFileMask";
            this.txtFileMask.Size = new System.Drawing.Size(278, 17);
            this.txtFileMask.TabIndex = 2;
            this.txtFileMask.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFileMask_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(2, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "File mask";
            // 
            // txtContent
            // 
            this.txtContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContent.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtContent.Location = new System.Drawing.Point(3, 22);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(332, 17);
            this.txtContent.TabIndex = 0;
            this.txtContent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContent_KeyPress);
            // 
            // grpDate
            // 
            this.grpDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDate.Controls.Add(this.rbDateNoRelevant);
            this.grpDate.Controls.Add(this.rbDateTypeModification);
            this.grpDate.Controls.Add(this.rbDateTypeCreation);
            this.grpDate.Controls.Add(this.grpPeriod);
            this.grpDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpDate.Font = new System.Drawing.Font("Tahoma", 10F);
            this.grpDate.Location = new System.Drawing.Point(5, 130);
            this.grpDate.Name = "grpDate";
            this.grpDate.Size = new System.Drawing.Size(344, 124);
            this.grpDate.TabIndex = 3;
            this.grpDate.TabStop = false;
            this.grpDate.Text = "Date";
            // 
            // rbDateNoRelevant
            // 
            this.rbDateNoRelevant.AutoSize = true;
            this.rbDateNoRelevant.Checked = true;
            this.rbDateNoRelevant.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbDateNoRelevant.Font = new System.Drawing.Font("Tahoma", 10F);
            this.rbDateNoRelevant.Location = new System.Drawing.Point(6, 19);
            this.rbDateNoRelevant.Name = "rbDateNoRelevant";
            this.rbDateNoRelevant.Size = new System.Drawing.Size(95, 21);
            this.rbDateNoRelevant.TabIndex = 0;
            this.rbDateNoRelevant.TabStop = true;
            this.rbDateNoRelevant.Text = "No relevant";
            this.rbDateNoRelevant.UseVisualStyleBackColor = true;
            this.rbDateNoRelevant.CheckedChanged += new System.EventHandler(this.grpPeriod_EnabledChange);
            this.rbDateNoRelevant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rbDateNoRelevant_KeyPress);
            // 
            // rbDateTypeModification
            // 
            this.rbDateTypeModification.AutoSize = true;
            this.rbDateTypeModification.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbDateTypeModification.Font = new System.Drawing.Font("Tahoma", 10F);
            this.rbDateTypeModification.Location = new System.Drawing.Point(199, 19);
            this.rbDateTypeModification.Name = "rbDateTypeModification";
            this.rbDateTypeModification.Size = new System.Drawing.Size(96, 21);
            this.rbDateTypeModification.TabIndex = 2;
            this.rbDateTypeModification.Text = "Modification";
            this.rbDateTypeModification.UseVisualStyleBackColor = true;
            this.rbDateTypeModification.CheckedChanged += new System.EventHandler(this.grpPeriod_EnabledChange);
            this.rbDateTypeModification.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rbDateTypeModification_KeyPress);
            // 
            // rbDateTypeCreation
            // 
            this.rbDateTypeCreation.AutoSize = true;
            this.rbDateTypeCreation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbDateTypeCreation.Font = new System.Drawing.Font("Tahoma", 10F);
            this.rbDateTypeCreation.Location = new System.Drawing.Point(112, 19);
            this.rbDateTypeCreation.Name = "rbDateTypeCreation";
            this.rbDateTypeCreation.Size = new System.Drawing.Size(76, 21);
            this.rbDateTypeCreation.TabIndex = 1;
            this.rbDateTypeCreation.Text = "Creation";
            this.rbDateTypeCreation.UseVisualStyleBackColor = true;
            this.rbDateTypeCreation.CheckedChanged += new System.EventHandler(this.grpPeriod_EnabledChange);
            this.rbDateTypeCreation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rbDateTypeCreation_KeyPress);
            // 
            // grpPeriod
            // 
            this.grpPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPeriod.Controls.Add(this.label6);
            this.grpPeriod.Controls.Add(this.label5);
            this.grpPeriod.Controls.Add(this.datePickerPeriodTo);
            this.grpPeriod.Controls.Add(this.datePickerPeriodFrom);
            this.grpPeriod.Controls.Add(this.rbPeriodDates);
            this.grpPeriod.Controls.Add(this.rbPeriodMonth);
            this.grpPeriod.Controls.Add(this.rbPeriodWeek);
            this.grpPeriod.Enabled = false;
            this.grpPeriod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpPeriod.Font = new System.Drawing.Font("Tahoma", 10F);
            this.grpPeriod.Location = new System.Drawing.Point(4, 42);
            this.grpPeriod.Name = "grpPeriod";
            this.grpPeriod.Size = new System.Drawing.Size(337, 72);
            this.grpPeriod.TabIndex = 4;
            this.grpPeriod.TabStop = false;
            this.grpPeriod.Text = "Period";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "to";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "From";
            // 
            // datePickerPeriodTo
            // 
            this.datePickerPeriodTo.Font = new System.Drawing.Font("Tahoma", 10F);
            this.datePickerPeriodTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerPeriodTo.Location = new System.Drawing.Point(155, 43);
            this.datePickerPeriodTo.Name = "datePickerPeriodTo";
            this.datePickerPeriodTo.Size = new System.Drawing.Size(87, 24);
            this.datePickerPeriodTo.TabIndex = 6;
            this.datePickerPeriodTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.datePickerPeriodTo_KeyPress);
            this.datePickerPeriodTo.Validated += new System.EventHandler(this.datePickerPeriodTo_Validated);
            // 
            // datePickerPeriodFrom
            // 
            this.datePickerPeriodFrom.Font = new System.Drawing.Font("Tahoma", 10F);
            this.datePickerPeriodFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerPeriodFrom.Location = new System.Drawing.Point(43, 43);
            this.datePickerPeriodFrom.Name = "datePickerPeriodFrom";
            this.datePickerPeriodFrom.Size = new System.Drawing.Size(87, 24);
            this.datePickerPeriodFrom.TabIndex = 4;
            this.datePickerPeriodFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.datePickerPeriodFrom_KeyPress);
            this.datePickerPeriodFrom.Validated += new System.EventHandler(this.datePickerPeriodFrom_Validated);
            // 
            // rbPeriodDates
            // 
            this.rbPeriodDates.AutoSize = true;
            this.rbPeriodDates.Checked = true;
            this.rbPeriodDates.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbPeriodDates.Location = new System.Drawing.Point(213, 20);
            this.rbPeriodDates.Name = "rbPeriodDates";
            this.rbPeriodDates.Size = new System.Drawing.Size(108, 21);
            this.rbPeriodDates.TabIndex = 2;
            this.rbPeriodDates.TabStop = true;
            this.rbPeriodDates.Text = "Specify Dates";
            this.rbPeriodDates.UseVisualStyleBackColor = true;
            this.rbPeriodDates.CheckedChanged += new System.EventHandler(this.PeriodDates_Enabled);
            this.rbPeriodDates.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rbPeriodDates_KeyPress);
            // 
            // rbPeriodMonth
            // 
            this.rbPeriodMonth.AutoSize = true;
            this.rbPeriodMonth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbPeriodMonth.Location = new System.Drawing.Point(100, 20);
            this.rbPeriodMonth.Name = "rbPeriodMonth";
            this.rbPeriodMonth.Size = new System.Drawing.Size(103, 21);
            this.rbPeriodMonth.TabIndex = 1;
            this.rbPeriodMonth.TabStop = true;
            this.rbPeriodMonth.Text = "Last 30 days";
            this.rbPeriodMonth.UseVisualStyleBackColor = true;
            this.rbPeriodMonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rbPeriodMonth_KeyPress);
            // 
            // rbPeriodWeek
            // 
            this.rbPeriodWeek.AutoSize = true;
            this.rbPeriodWeek.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbPeriodWeek.Location = new System.Drawing.Point(5, 20);
            this.rbPeriodWeek.Name = "rbPeriodWeek";
            this.rbPeriodWeek.Size = new System.Drawing.Size(85, 21);
            this.rbPeriodWeek.TabIndex = 0;
            this.rbPeriodWeek.TabStop = true;
            this.rbPeriodWeek.Text = "Last week";
            this.rbPeriodWeek.UseVisualStyleBackColor = true;
            this.rbPeriodWeek.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rbPeriodWeek_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnSearch.Location = new System.Drawing.Point(2, 340);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Fetch!";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // checkWithSubfolders
            // 
            this.checkWithSubfolders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkWithSubfolders.AutoSize = true;
            this.checkWithSubfolders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkWithSubfolders.Font = new System.Drawing.Font("Tahoma", 10F);
            this.checkWithSubfolders.Location = new System.Drawing.Point(264, 8);
            this.checkWithSubfolders.Name = "checkWithSubfolders";
            this.checkWithSubfolders.Size = new System.Drawing.Size(89, 21);
            this.checkWithSubfolders.TabIndex = 1;
            this.checkWithSubfolders.Text = "Subfolders";
            this.checkWithSubfolders.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.numSize);
            this.groupBox1.Controls.Add(this.grpSizeUnits);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox1.Location = new System.Drawing.Point(3, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 79);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbSizeNoRelevant);
            this.groupBox4.Controls.Add(this.rbSizeLess);
            this.groupBox4.Controls.Add(this.rbSizeMore);
            this.groupBox4.Location = new System.Drawing.Point(7, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(142, 56);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // rbSizeNoRelevant
            // 
            this.rbSizeNoRelevant.AutoSize = true;
            this.rbSizeNoRelevant.Checked = true;
            this.rbSizeNoRelevant.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbSizeNoRelevant.Location = new System.Drawing.Point(6, 11);
            this.rbSizeNoRelevant.Name = "rbSizeNoRelevant";
            this.rbSizeNoRelevant.Size = new System.Drawing.Size(126, 21);
            this.rbSizeNoRelevant.TabIndex = 0;
            this.rbSizeNoRelevant.TabStop = true;
            this.rbSizeNoRelevant.Text = "Don\'t remember";
            this.rbSizeNoRelevant.UseVisualStyleBackColor = true;
            this.rbSizeNoRelevant.CheckedChanged += new System.EventHandler(this.grpSize_EnabledChange);
            this.rbSizeNoRelevant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rbSizeNoRelevant_KeyPress);
            // 
            // rbSizeLess
            // 
            this.rbSizeLess.AutoSize = true;
            this.rbSizeLess.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbSizeLess.Location = new System.Drawing.Point(61, 31);
            this.rbSizeLess.Name = "rbSizeLess";
            this.rbSizeLess.Size = new System.Drawing.Size(35, 21);
            this.rbSizeLess.TabIndex = 2;
            this.rbSizeLess.Text = "<";
            this.rbSizeLess.UseVisualStyleBackColor = true;
            this.rbSizeLess.CheckedChanged += new System.EventHandler(this.grpSize_EnabledChange);
            this.rbSizeLess.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rbSizeLess_KeyPress);
            // 
            // rbSizeMore
            // 
            this.rbSizeMore.AutoSize = true;
            this.rbSizeMore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbSizeMore.Location = new System.Drawing.Point(5, 31);
            this.rbSizeMore.Name = "rbSizeMore";
            this.rbSizeMore.Size = new System.Drawing.Size(35, 21);
            this.rbSizeMore.TabIndex = 1;
            this.rbSizeMore.Text = ">";
            this.rbSizeMore.UseVisualStyleBackColor = true;
            this.rbSizeMore.CheckedChanged += new System.EventHandler(this.grpSize_EnabledChange);
            this.rbSizeMore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rbSizeMore_KeyPress);
            // 
            // numSize
            // 
            this.numSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numSize.Enabled = false;
            this.numSize.Font = new System.Drawing.Font("Tahoma", 10F);
            this.numSize.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numSize.Location = new System.Drawing.Point(155, 29);
            this.numSize.Maximum = new decimal(new int[] {
            652835027,
            2097,
            0,
            0});
            this.numSize.Name = "numSize";
            this.numSize.Size = new System.Drawing.Size(84, 20);
            this.numSize.TabIndex = 0;
            this.numSize.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numSize_KeyPress);
            // 
            // grpSizeUnits
            // 
            this.grpSizeUnits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSizeUnits.Controls.Add(this.rbSizeUnitsKb);
            this.grpSizeUnits.Controls.Add(this.rbSizeUnits1000Kb);
            this.grpSizeUnits.Enabled = false;
            this.grpSizeUnits.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpSizeUnits.Location = new System.Drawing.Point(246, 11);
            this.grpSizeUnits.Name = "grpSizeUnits";
            this.grpSizeUnits.Size = new System.Drawing.Size(97, 57);
            this.grpSizeUnits.TabIndex = 1;
            this.grpSizeUnits.TabStop = false;
            // 
            // rbSizeUnitsKb
            // 
            this.rbSizeUnitsKb.AutoSize = true;
            this.rbSizeUnitsKb.Checked = true;
            this.rbSizeUnitsKb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbSizeUnitsKb.Location = new System.Drawing.Point(6, 8);
            this.rbSizeUnitsKb.Name = "rbSizeUnitsKb";
            this.rbSizeUnitsKb.Size = new System.Drawing.Size(41, 21);
            this.rbSizeUnitsKb.TabIndex = 0;
            this.rbSizeUnitsKb.TabStop = true;
            this.rbSizeUnitsKb.Text = "Kb";
            this.rbSizeUnitsKb.UseVisualStyleBackColor = true;
            this.rbSizeUnitsKb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rbSizeUnitsKb_KeyPress);
            // 
            // rbSizeUnits1000Kb
            // 
            this.rbSizeUnits1000Kb.AutoSize = true;
            this.rbSizeUnits1000Kb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbSizeUnits1000Kb.Location = new System.Drawing.Point(5, 31);
            this.rbSizeUnits1000Kb.Name = "rbSizeUnits1000Kb";
            this.rbSizeUnits1000Kb.Size = new System.Drawing.Size(77, 21);
            this.rbSizeUnits1000Kb.TabIndex = 1;
            this.rbSizeUnits1000Kb.Text = "1000 Kb";
            this.rbSizeUnits1000Kb.UseVisualStyleBackColor = true;
            this.rbSizeUnits1000Kb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rbSizeUnits1000Kb_KeyPress);
            // 
            // splitConditionalRezults
            // 
            this.splitConditionalRezults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitConditionalRezults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitConditionalRezults.Location = new System.Drawing.Point(0, 0);
            this.splitConditionalRezults.Name = "splitConditionalRezults";
            // 
            // splitConditionalRezults.Panel1
            // 
            this.splitConditionalRezults.Panel1.Controls.Add(this.groupBox5);
            this.splitConditionalRezults.Panel1.Controls.Add(this.label1);
            this.splitConditionalRezults.Panel1.Controls.Add(this.groupBox1);
            this.splitConditionalRezults.Panel1.Controls.Add(this.txtFolder);
            this.splitConditionalRezults.Panel1.Controls.Add(this.btnSearch);
            this.splitConditionalRezults.Panel1.Controls.Add(this.txtFileMask);
            this.splitConditionalRezults.Panel1.Controls.Add(this.checkWithSubfolders);
            this.splitConditionalRezults.Panel1.Controls.Add(this.label4);
            this.splitConditionalRezults.Panel1.Controls.Add(this.grpDate);
            this.splitConditionalRezults.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitConditionalRezults.Panel1MinSize = 275;
            // 
            // splitConditionalRezults.Panel2
            // 
            this.splitConditionalRezults.Panel2.Controls.Add(this.lstRezults);
            this.splitConditionalRezults.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitConditionalRezults.Size = new System.Drawing.Size(1026, 370);
            this.splitConditionalRezults.SplitterDistance = 358;
            this.splitConditionalRezults.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.rbContentXpath);
            this.groupBox5.Controls.Add(this.rbContentRegex);
            this.groupBox5.Controls.Add(this.rbContentText);
            this.groupBox5.Controls.Add(this.txtContent);
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox5.Location = new System.Drawing.Point(9, 57);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(341, 69);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Content";
            // 
            // rbContentXpath
            // 
            this.rbContentXpath.AutoSize = true;
            this.rbContentXpath.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbContentXpath.Font = new System.Drawing.Font("Tahoma", 10F);
            this.rbContentXpath.Location = new System.Drawing.Point(154, 43);
            this.rbContentXpath.Name = "rbContentXpath";
            this.rbContentXpath.Size = new System.Drawing.Size(61, 21);
            this.rbContentXpath.TabIndex = 3;
            this.rbContentXpath.Text = "xPath";
            this.rbContentXpath.UseVisualStyleBackColor = true;
            this.rbContentXpath.CheckedChanged += new System.EventHandler(this.ContentSearchTypeExpression_Changed);
            // 
            // rbContentRegex
            // 
            this.rbContentRegex.AutoSize = true;
            this.rbContentRegex.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbContentRegex.Font = new System.Drawing.Font("Tahoma", 10F);
            this.rbContentRegex.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbContentRegex.Location = new System.Drawing.Point(71, 43);
            this.rbContentRegex.Name = "rbContentRegex";
            this.rbContentRegex.Size = new System.Drawing.Size(72, 21);
            this.rbContentRegex.TabIndex = 2;
            this.rbContentRegex.Text = "Regexp";
            this.rbContentRegex.UseVisualStyleBackColor = true;
            this.rbContentRegex.CheckedChanged += new System.EventHandler(this.ContentSearchTypeExpression_Changed);
            this.rbContentRegex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rbContentRegex_KeyPress);
            // 
            // rbContentText
            // 
            this.rbContentText.AutoSize = true;
            this.rbContentText.Checked = true;
            this.rbContentText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbContentText.Font = new System.Drawing.Font("Tahoma", 10F);
            this.rbContentText.Location = new System.Drawing.Point(7, 43);
            this.rbContentText.Name = "rbContentText";
            this.rbContentText.Size = new System.Drawing.Size(53, 21);
            this.rbContentText.TabIndex = 1;
            this.rbContentText.TabStop = true;
            this.rbContentText.Text = "Text";
            this.rbContentText.UseVisualStyleBackColor = true;
            this.rbContentText.CheckedChanged += new System.EventHandler(this.ContentSearchTypeExpression_Changed);
            this.rbContentText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rbContentText_KeyPress);
            // 
            // lstRezults
            // 
            this.lstRezults.AllowColumnReorder = true;
            this.lstRezults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstRezults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmnName,
            this.clmnInFolder,
            this.clmnSize,
            this.clmnType,
            this.clmnDateCreated,
            this.clmnDateModidied});
            this.lstRezults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstRezults.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lstRezults.HideSelection = false;
            this.lstRezults.LabelEdit = true;
            this.lstRezults.Location = new System.Drawing.Point(0, 0);
            this.lstRezults.Name = "lstRezults";
            this.lstRezults.Size = new System.Drawing.Size(662, 368);
            this.lstRezults.SmallImageList = this.imageListSmallImagesForListView;
            this.lstRezults.TabIndex = 0;
            this.lstRezults.UseCompatibleStateImageBehavior = false;
            this.lstRezults.View = System.Windows.Forms.View.Details;
            this.lstRezults.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lstRezults_ColumnClick);
            this.lstRezults.SelectedIndexChanged += new System.EventHandler(this.lstRezults_SelectedIndexChanged);
            this.lstRezults.DoubleClick += new System.EventHandler(this.lstRezults_DoubleClick);
            // 
            // clmnName
            // 
            this.clmnName.Tag = "";
            this.clmnName.Text = "Name";
            this.clmnName.Width = 200;
            // 
            // clmnInFolder
            // 
            this.clmnInFolder.Text = "In Folder";
            this.clmnInFolder.Width = 150;
            // 
            // clmnSize
            // 
            this.clmnSize.Tag = "Size";
            this.clmnSize.Text = "Size";
            this.clmnSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // clmnType
            // 
            this.clmnType.Text = "Type";
            this.clmnType.Width = 100;
            // 
            // clmnDateCreated
            // 
            this.clmnDateCreated.Tag = "DateCreated";
            this.clmnDateCreated.Text = "Date Created";
            this.clmnDateCreated.Width = 100;
            // 
            // clmnDateModidied
            // 
            this.clmnDateModidied.Tag = "DateModidied";
            this.clmnDateModidied.Text = "Date Modified";
            this.clmnDateModidied.Width = 100;
            // 
            // imageListSmallImagesForListView
            // 
            this.imageListSmallImagesForListView.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmallImagesForListView.ImageStream")));
            this.imageListSmallImagesForListView.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmallImagesForListView.Images.SetKeyName(0, "SortDesc");
            this.imageListSmallImagesForListView.Images.SetKeyName(1, "SortAsc");
            this.imageListSmallImagesForListView.Images.SetKeyName(2, "SortAsc_verySmall");
            this.imageListSmallImagesForListView.Images.SetKeyName(3, "SortDesc_verySmall");
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.splitConditionalRezults);
            this.splitContainerMain.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.panelTextContent);
            this.splitContainerMain.Panel2.Controls.Add(this.checkBoxRegex);
            this.splitContainerMain.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainerMain.Size = new System.Drawing.Size(1026, 619);
            this.splitContainerMain.SplitterDistance = 370;
            this.splitContainerMain.TabIndex = 9;
            // 
            // panelTextContent
            // 
            this.panelTextContent.Controls.Add(this.btnContextSearchPrev);
            this.panelTextContent.Controls.Add(this.btnContextSearchNext);
            this.panelTextContent.Controls.Add(this.btnContextSearchExecute);
            this.panelTextContent.Controls.Add(this.chkBoxContextSearchCaseSensitive);
            this.panelTextContent.Controls.Add(this.rbContextSearchXpath);
            this.panelTextContent.Controls.Add(this.rbContextSearchRegexp);
            this.panelTextContent.Controls.Add(this.rbContextSearchText);
            this.panelTextContent.Controls.Add(this.txtContextSearch);
            this.panelTextContent.Controls.Add(this.label7);
            this.panelTextContent.Controls.Add(this.label3);
            this.panelTextContent.Controls.Add(this.label2);
            this.panelTextContent.Controls.Add(this.numContextShowSizeUpBound);
            this.panelTextContent.Controls.Add(this.statusStrip);
            this.panelTextContent.Controls.Add(this.chkBoxContentWrapText);
            this.panelTextContent.Controls.Add(this.rtbFileContent);
            this.panelTextContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTextContent.Location = new System.Drawing.Point(0, 0);
            this.panelTextContent.Name = "panelTextContent";
            this.panelTextContent.Size = new System.Drawing.Size(1024, 243);
            this.panelTextContent.TabIndex = 0;
            // 
            // btnContextSearchPrev
            // 
            this.btnContextSearchPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContextSearchPrev.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnContextSearchPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnContextSearchPrev.Location = new System.Drawing.Point(652, 1);
            this.btnContextSearchPrev.Name = "btnContextSearchPrev";
            this.btnContextSearchPrev.Size = new System.Drawing.Size(24, 24);
            this.btnContextSearchPrev.TabIndex = 12;
            this.btnContextSearchPrev.Text = "<";
            this.btnContextSearchPrev.UseVisualStyleBackColor = true;
            this.btnContextSearchPrev.Click += new System.EventHandler(this.btnContextSearchPrev_Click);
            // 
            // btnContextSearchNext
            // 
            this.btnContextSearchNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContextSearchNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnContextSearchNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnContextSearchNext.Location = new System.Drawing.Point(675, 1);
            this.btnContextSearchNext.Name = "btnContextSearchNext";
            this.btnContextSearchNext.Size = new System.Drawing.Size(24, 24);
            this.btnContextSearchNext.TabIndex = 11;
            this.btnContextSearchNext.Text = ">";
            this.btnContextSearchNext.UseVisualStyleBackColor = true;
            this.btnContextSearchNext.Click += new System.EventHandler(this.btnContextSearchNext_Click);
            // 
            // btnContextSearchExecute
            // 
            this.btnContextSearchExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContextSearchExecute.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnContextSearchExecute.BackgroundImage")));
            this.btnContextSearchExecute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnContextSearchExecute.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnContextSearchExecute.Font = new System.Drawing.Font("Webdings", 10F);
            this.btnContextSearchExecute.Location = new System.Drawing.Point(622, 1);
            this.btnContextSearchExecute.Name = "btnContextSearchExecute";
            this.btnContextSearchExecute.Size = new System.Drawing.Size(24, 24);
            this.btnContextSearchExecute.TabIndex = 9;
            this.btnContextSearchExecute.UseVisualStyleBackColor = true;
            this.btnContextSearchExecute.Click += new System.EventHandler(this.btnContextSearchExecute_Click);
            // 
            // chkBoxContextSearchCaseSensitive
            // 
            this.chkBoxContextSearchCaseSensitive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkBoxContextSearchCaseSensitive.AutoSize = true;
            this.chkBoxContextSearchCaseSensitive.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkBoxContextSearchCaseSensitive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkBoxContextSearchCaseSensitive.Location = new System.Drawing.Point(705, 3);
            this.chkBoxContextSearchCaseSensitive.Name = "chkBoxContextSearchCaseSensitive";
            this.chkBoxContextSearchCaseSensitive.Size = new System.Drawing.Size(116, 21);
            this.chkBoxContextSearchCaseSensitive.TabIndex = 8;
            this.chkBoxContextSearchCaseSensitive.Text = "Case sensitive";
            this.chkBoxContextSearchCaseSensitive.UseVisualStyleBackColor = true;
            this.chkBoxContextSearchCaseSensitive.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chkBoxContextSearchCaseSensitive_KeyPress);
            // 
            // rbContextSearchXpath
            // 
            this.rbContextSearchXpath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbContextSearchXpath.AutoSize = true;
            this.rbContextSearchXpath.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbContextSearchXpath.Font = new System.Drawing.Font("Tahoma", 10F);
            this.rbContextSearchXpath.Location = new System.Drawing.Point(960, 3);
            this.rbContextSearchXpath.Name = "rbContextSearchXpath";
            this.rbContextSearchXpath.Size = new System.Drawing.Size(61, 21);
            this.rbContextSearchXpath.TabIndex = 7;
            this.rbContextSearchXpath.Text = "xPath";
            this.rbContextSearchXpath.UseVisualStyleBackColor = true;
            this.rbContextSearchXpath.CheckedChanged += new System.EventHandler(this.chkBoxSearchCaseSensitive_EnabledChange);
            this.rbContextSearchXpath.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rbContextSearchXpath_KeyPress);
            // 
            // rbContextSearchRegexp
            // 
            this.rbContextSearchRegexp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbContextSearchRegexp.AutoSize = true;
            this.rbContextSearchRegexp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbContextSearchRegexp.Font = new System.Drawing.Font("Tahoma", 10F);
            this.rbContextSearchRegexp.Location = new System.Drawing.Point(885, 3);
            this.rbContextSearchRegexp.Name = "rbContextSearchRegexp";
            this.rbContextSearchRegexp.Size = new System.Drawing.Size(72, 21);
            this.rbContextSearchRegexp.TabIndex = 7;
            this.rbContextSearchRegexp.Text = "Regexp";
            this.rbContextSearchRegexp.UseVisualStyleBackColor = true;
            this.rbContextSearchRegexp.CheckedChanged += new System.EventHandler(this.chkBoxSearchCaseSensitive_EnabledChange);
            this.rbContextSearchRegexp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rbContextSearchRegexp_KeyPress);
            // 
            // rbContextSearchText
            // 
            this.rbContextSearchText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbContextSearchText.AutoSize = true;
            this.rbContextSearchText.Checked = true;
            this.rbContextSearchText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbContextSearchText.Font = new System.Drawing.Font("Tahoma", 10F);
            this.rbContextSearchText.Location = new System.Drawing.Point(826, 3);
            this.rbContextSearchText.Name = "rbContextSearchText";
            this.rbContextSearchText.Size = new System.Drawing.Size(53, 21);
            this.rbContextSearchText.TabIndex = 7;
            this.rbContextSearchText.TabStop = true;
            this.rbContextSearchText.Text = "Text";
            this.rbContextSearchText.UseVisualStyleBackColor = true;
            this.rbContextSearchText.CheckedChanged += new System.EventHandler(this.chkBoxSearchCaseSensitive_EnabledChange);
            this.rbContextSearchText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rbContextSearchText_KeyPress);
            // 
            // txtContextSearch
            // 
            this.txtContextSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContextSearch.BackColor = System.Drawing.SystemColors.Window;
            this.txtContextSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContextSearch.Font = new System.Drawing.Font("Courier New", 10F);
            this.txtContextSearch.Location = new System.Drawing.Point(404, 5);
            this.txtContextSearch.Name = "txtContextSearch";
            this.txtContextSearch.Size = new System.Drawing.Size(212, 16);
            this.txtContextSearch.TabIndex = 6;
            this.txtContextSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContextSearch_KeyPress);
            this.txtContextSearch.Validating += new System.ComponentModel.CancelEventHandler(this.txtContextSearch_Validating);
            this.txtContextSearch.Validated += new System.EventHandler(this.txtContextSearch_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label7.Location = new System.Drawing.Point(282, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Search in content";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(257, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kb";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(70, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Skip files lagest then";
            // 
            // numContextShowSizeUpBound
            // 
            this.numContextShowSizeUpBound.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numContextShowSizeUpBound.Font = new System.Drawing.Font("Tahoma", 10F);
            this.numContextShowSizeUpBound.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numContextShowSizeUpBound.Location = new System.Drawing.Point(205, 3);
            this.numContextShowSizeUpBound.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numContextShowSizeUpBound.Name = "numContextShowSizeUpBound";
            this.numContextShowSizeUpBound.Size = new System.Drawing.Size(46, 20);
            this.numContextShowSizeUpBound.TabIndex = 1;
            this.numContextShowSizeUpBound.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // statusStrip
            // 
            this.statusStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusFilesFound,
            this.toolStripStatusLabelContextSearchResults,
            this.toolStripStatusLabelPositionInTextRow,
            this.toolStripStatusLabelFileEncoding,
            this.progressBarProcessingFiles});
            this.statusStrip.Location = new System.Drawing.Point(0, 221);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1024, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusFilesFound
            // 
            this.toolStripStatusFilesFound.AutoSize = false;
            this.toolStripStatusFilesFound.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusFilesFound.Margin = new System.Windows.Forms.Padding(0, 3, 10, 2);
            this.toolStripStatusFilesFound.Name = "toolStripStatusFilesFound";
            this.toolStripStatusFilesFound.Size = new System.Drawing.Size(100, 17);
            // 
            // toolStripStatusLabelContextSearchResults
            // 
            this.toolStripStatusLabelContextSearchResults.AutoSize = false;
            this.toolStripStatusLabelContextSearchResults.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelContextSearchResults.Margin = new System.Windows.Forms.Padding(0, 3, 10, 2);
            this.toolStripStatusLabelContextSearchResults.Name = "toolStripStatusLabelContextSearchResults";
            this.toolStripStatusLabelContextSearchResults.Size = new System.Drawing.Size(109, 17);
            // 
            // toolStripStatusLabelPositionInTextRow
            // 
            this.toolStripStatusLabelPositionInTextRow.AutoSize = false;
            this.toolStripStatusLabelPositionInTextRow.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelPositionInTextRow.Margin = new System.Windows.Forms.Padding(0, 3, 10, 2);
            this.toolStripStatusLabelPositionInTextRow.Name = "toolStripStatusLabelPositionInTextRow";
            this.toolStripStatusLabelPositionInTextRow.Size = new System.Drawing.Size(169, 17);
            this.toolStripStatusLabelPositionInTextRow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabelFileEncoding
            // 
            this.toolStripStatusLabelFileEncoding.AutoSize = false;
            this.toolStripStatusLabelFileEncoding.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelFileEncoding.Margin = new System.Windows.Forms.Padding(0, 3, 10, 2);
            this.toolStripStatusLabelFileEncoding.Name = "toolStripStatusLabelFileEncoding";
            this.toolStripStatusLabelFileEncoding.Size = new System.Drawing.Size(100, 17);
            // 
            // progressBarProcessingFiles
            // 
            this.progressBarProcessingFiles.AutoSize = false;
            this.progressBarProcessingFiles.Margin = new System.Windows.Forms.Padding(1, 6, 1, 6);
            this.progressBarProcessingFiles.Name = "progressBarProcessingFiles";
            this.progressBarProcessingFiles.Size = new System.Drawing.Size(100, 10);
            this.progressBarProcessingFiles.Step = 1;
            this.progressBarProcessingFiles.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarProcessingFiles.Visible = false;
            // 
            // chkBoxContentWrapText
            // 
            this.chkBoxContentWrapText.AutoSize = true;
            this.chkBoxContentWrapText.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkBoxContentWrapText.Checked = true;
            this.chkBoxContentWrapText.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxContentWrapText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkBoxContentWrapText.Font = new System.Drawing.Font("Tahoma", 10F);
            this.chkBoxContentWrapText.Location = new System.Drawing.Point(3, 3);
            this.chkBoxContentWrapText.Name = "chkBoxContentWrapText";
            this.chkBoxContentWrapText.Size = new System.Drawing.Size(59, 21);
            this.chkBoxContentWrapText.TabIndex = 0;
            this.chkBoxContentWrapText.Text = "Wrap";
            this.chkBoxContentWrapText.UseVisualStyleBackColor = true;
            this.chkBoxContentWrapText.CheckedChanged += new System.EventHandler(this.chkBoxContentWrapText_CheckedChanged);
            // 
            // rtbFileContent
            // 
            this.rtbFileContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbFileContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbFileContent.DetectUrls = false;
            this.rtbFileContent.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbFileContent.Location = new System.Drawing.Point(0, 26);
            this.rtbFileContent.Name = "rtbFileContent";
            this.rtbFileContent.ShowSelectionMargin = true;
            this.rtbFileContent.Size = new System.Drawing.Size(1024, 192);
            this.rtbFileContent.TabIndex = 2;
            this.rtbFileContent.Text = "";
            this.rtbFileContent.SelectionChanged += new System.EventHandler(this.rtbFileContent_SelectionChanged);
            this.rtbFileContent.Enter += new System.EventHandler(this.rtbFileContent_Enter);
            this.rtbFileContent.Leave += new System.EventHandler(this.rtbFileContent_Leave);
            // 
            // checkBoxRegex
            // 
            this.checkBoxRegex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxRegex.AutoSize = true;
            this.checkBoxRegex.Location = new System.Drawing.Point(463, 5);
            this.checkBoxRegex.Name = "checkBoxRegex";
            this.checkBoxRegex.Size = new System.Drawing.Size(57, 17);
            this.checkBoxRegex.TabIndex = 1;
            this.checkBoxRegex.Text = "Regex";
            this.checkBoxRegex.UseVisualStyleBackColor = true;
            // 
            // imageListFavoritMenu
            // 
            this.imageListFavoritMenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListFavoritMenu.ImageStream")));
            this.imageListFavoritMenu.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListFavoritMenu.Images.SetKeyName(0, "Folder_Favorites.png");
            this.imageListFavoritMenu.Images.SetKeyName(1, "ico-delete.gif");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 619);
            this.Controls.Add(this.splitContainerMain);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Looky";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.cntxtMnFolder.ResumeLayout(false);
            this.grpDate.ResumeLayout(false);
            this.grpDate.PerformLayout();
            this.grpPeriod.ResumeLayout(false);
            this.grpPeriod.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).EndInit();
            this.grpSizeUnits.ResumeLayout(false);
            this.grpSizeUnits.PerformLayout();
            this.splitConditionalRezults.Panel1.ResumeLayout(false);
            this.splitConditionalRezults.Panel1.PerformLayout();
            this.splitConditionalRezults.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitConditionalRezults)).EndInit();
            this.splitConditionalRezults.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            this.splitContainerMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.panelTextContent.ResumeLayout(false);
            this.panelTextContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numContextShowSizeUpBound)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.TextBox txtFileMask;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.GroupBox grpDate;
        private System.Windows.Forms.RadioButton rbDateTypeModification;
        private System.Windows.Forms.RadioButton rbDateTypeCreation;
        private System.Windows.Forms.GroupBox grpPeriod;
        private System.Windows.Forms.RadioButton rbPeriodWeek;
        private System.Windows.Forms.RadioButton rbDateNoRelevant;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker datePickerPeriodTo;
        private System.Windows.Forms.DateTimePicker datePickerPeriodFrom;
        private System.Windows.Forms.RadioButton rbPeriodDates;
        private System.Windows.Forms.RadioButton rbPeriodMonth;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckBox checkWithSubfolders;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numSize;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbSizeNoRelevant;
        private System.Windows.Forms.RadioButton rbSizeLess;
        private System.Windows.Forms.RadioButton rbSizeMore;
        private System.Windows.Forms.GroupBox grpSizeUnits;
        private System.Windows.Forms.RadioButton rbSizeUnitsKb;
        private System.Windows.Forms.RadioButton rbSizeUnits1000Kb;
        private System.Windows.Forms.SplitContainer splitConditionalRezults;
        private System.Windows.Forms.ListView lstRezults;
        private System.Windows.Forms.ColumnHeader clmnName;
        private System.Windows.Forms.ColumnHeader clmnInFolder;
        private System.Windows.Forms.ColumnHeader clmnSize;
        private System.Windows.Forms.ColumnHeader clmnType;
        private System.Windows.Forms.ColumnHeader clmnDateCreated;
        private System.Windows.Forms.ColumnHeader clmnDateModidied;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.Panel panelTextContent;
        private System.Windows.Forms.RichTextBox rtbFileContent;
        private System.Windows.Forms.ImageList imageListSmallImagesForListView;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rbContentXpath;
        private System.Windows.Forms.RadioButton rbContentRegex;
        private System.Windows.Forms.RadioButton rbContentText;
        private System.Windows.Forms.CheckBox checkBoxRegex;
        private System.Windows.Forms.CheckBox chkBoxContentWrapText;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar progressBarProcessingFiles;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelPositionInTextRow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numContextShowSizeUpBound;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusFilesFound;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelContextSearchResults;
        private System.Windows.Forms.TextBox txtContextSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbContextSearchXpath;
        private System.Windows.Forms.RadioButton rbContextSearchRegexp;
        private System.Windows.Forms.RadioButton rbContextSearchText;
        private System.Windows.Forms.CheckBox chkBoxContextSearchCaseSensitive;
        private System.Windows.Forms.Button btnContextSearchExecute;
        private System.Windows.Forms.Button btnContextSearchNext;
        private System.Windows.Forms.Button btnContextSearchPrev;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelFileEncoding;
        private System.Windows.Forms.ContextMenuStrip cntxtMnFolder;
        private System.Windows.Forms.ToolStripMenuItem mniFavoritesManagement;
        private System.Windows.Forms.ToolStripMenuItem mniFavoritesAddFolder;
        private System.Windows.Forms.ToolStripMenuItem mniFavoritesRemoveFolder;
        private System.Windows.Forms.ToolStripTextBox mniFavoritesNewName;
        private System.Windows.Forms.ToolStripMenuItem mniFavoritesNewAdd;
        private System.Windows.Forms.ImageList imageListFavoritMenu;
    }
}

