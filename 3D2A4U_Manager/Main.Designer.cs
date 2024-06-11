namespace _3D2A4U_Manager
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblWelcomeTitle = new Label();
            tabControl1 = new TabControl();
            tabWelcome = new TabPage();
            tabFiles = new TabPage();
            spcFileSearch = new SplitContainer();
            tblFileFilters = new TableLayoutPanel();
            fDeveloper = new FilterKvp();
            fDevTeam = new FilterKvp();
            fRailType = new FilterKvp();
            fGripPattern = new FilterKvp();
            fStockPattern = new FilterKvp();
            fFireControlPattern = new FilterKvp();
            fModelType = new FilterKvp();
            fCloneOf = new FilterKvp();
            fFileFormat = new FilterKvp();
            fBarrelLength = new FilterKvp();
            fBarrelPattern = new FilterKvp();
            fMagPattern = new FilterKvp();
            fCaliber = new FilterKvp();
            fReceiverPattern = new FilterKvp();
            btnSearch = new Button();
            btnClearResults = new Button();
            gvFileSearchResults = new DataGridView();
            tabVendors = new TabPage();
            tabResources = new TabPage();
            tabConnect = new TabPage();
            tabSettings = new TabPage();
            groupBox1 = new GroupBox();
            chkAllowLookupEdit = new CheckBox();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            btnCheckForUpdates = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            txtWadPath = new TextBox();
            label1 = new Label();
            btnNewFile = new Button();
            toolTip1 = new ToolTip(components);
            tabControl1.SuspendLayout();
            tabWelcome.SuspendLayout();
            tabFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spcFileSearch).BeginInit();
            spcFileSearch.Panel1.SuspendLayout();
            spcFileSearch.Panel2.SuspendLayout();
            spcFileSearch.SuspendLayout();
            tblFileFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvFileSearchResults).BeginInit();
            tabSettings.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcomeTitle
            // 
            lblWelcomeTitle.AutoSize = true;
            lblWelcomeTitle.Location = new Point(616, 279);
            lblWelcomeTitle.Name = "lblWelcomeTitle";
            lblWelcomeTitle.Size = new Size(160, 15);
            lblWelcomeTitle.TabIndex = 0;
            lblWelcomeTitle.Text = "3D2A4U - The GunCAD Index";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabWelcome);
            tabControl1.Controls.Add(tabFiles);
            tabControl1.Controls.Add(tabVendors);
            tabControl1.Controls.Add(tabResources);
            tabControl1.Controls.Add(tabConnect);
            tabControl1.Controls.Add(tabSettings);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1424, 861);
            tabControl1.TabIndex = 1;
            // 
            // tabWelcome
            // 
            tabWelcome.Controls.Add(lblWelcomeTitle);
            tabWelcome.Location = new Point(4, 24);
            tabWelcome.Name = "tabWelcome";
            tabWelcome.Padding = new Padding(3);
            tabWelcome.Size = new Size(1416, 833);
            tabWelcome.TabIndex = 0;
            tabWelcome.Text = "Welcome";
            tabWelcome.UseVisualStyleBackColor = true;
            // 
            // tabFiles
            // 
            tabFiles.Controls.Add(spcFileSearch);
            tabFiles.Location = new Point(4, 24);
            tabFiles.Name = "tabFiles";
            tabFiles.Padding = new Padding(3);
            tabFiles.Size = new Size(1416, 833);
            tabFiles.TabIndex = 1;
            tabFiles.Text = "Files";
            tabFiles.UseVisualStyleBackColor = true;
            // 
            // spcFileSearch
            // 
            spcFileSearch.Dock = DockStyle.Fill;
            spcFileSearch.FixedPanel = FixedPanel.Panel1;
            spcFileSearch.IsSplitterFixed = true;
            spcFileSearch.Location = new Point(3, 3);
            spcFileSearch.Name = "spcFileSearch";
            spcFileSearch.Orientation = Orientation.Horizontal;
            // 
            // spcFileSearch.Panel1
            // 
            spcFileSearch.Panel1.Controls.Add(btnNewFile);
            spcFileSearch.Panel1.Controls.Add(tblFileFilters);
            spcFileSearch.Panel1.Controls.Add(btnSearch);
            spcFileSearch.Panel1.Controls.Add(btnClearResults);
            spcFileSearch.Panel1MinSize = 166;
            // 
            // spcFileSearch.Panel2
            // 
            spcFileSearch.Panel2.Controls.Add(gvFileSearchResults);
            spcFileSearch.Size = new Size(1410, 827);
            spcFileSearch.SplitterDistance = 166;
            spcFileSearch.TabIndex = 1;
            spcFileSearch.SplitterMoved += spcFileSearch_SplitterMoved;
            // 
            // tblFileFilters
            // 
            tblFileFilters.ColumnCount = 4;
            tblFileFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblFileFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblFileFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblFileFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblFileFilters.Controls.Add(fDeveloper, 0, 3);
            tblFileFilters.Controls.Add(fDevTeam, 0, 3);
            tblFileFilters.Controls.Add(fRailType, 0, 2);
            tblFileFilters.Controls.Add(fGripPattern, 2, 1);
            tblFileFilters.Controls.Add(fStockPattern, 1, 1);
            tblFileFilters.Controls.Add(fFireControlPattern, 0, 1);
            tblFileFilters.Controls.Add(fModelType, 0, 0);
            tblFileFilters.Controls.Add(fCloneOf, 1, 2);
            tblFileFilters.Controls.Add(fFileFormat, 2, 2);
            tblFileFilters.Controls.Add(fBarrelLength, 3, 2);
            tblFileFilters.Controls.Add(fBarrelPattern, 3, 1);
            tblFileFilters.Controls.Add(fMagPattern, 3, 0);
            tblFileFilters.Controls.Add(fCaliber, 2, 0);
            tblFileFilters.Controls.Add(fReceiverPattern, 1, 0);
            tblFileFilters.Dock = DockStyle.Top;
            tblFileFilters.Location = new Point(0, 0);
            tblFileFilters.Name = "tblFileFilters";
            tblFileFilters.RowCount = 4;
            tblFileFilters.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblFileFilters.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblFileFilters.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblFileFilters.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblFileFilters.Size = new Size(1410, 134);
            tblFileFilters.TabIndex = 0;
            // 
            // fDeveloper
            // 
            fDeveloper.ComboBoxDataSource = null;
            fDeveloper.LabelText = "Developer";
            fDeveloper.Location = new Point(3, 102);
            fDeveloper.MinimumSize = new Size(338, 30);
            fDeveloper.Name = "fDeveloper";
            fDeveloper.Size = new Size(346, 30);
            fDeveloper.TabIndex = 14;
            // 
            // fDevTeam
            // 
            fDevTeam.ComboBoxDataSource = null;
            fDevTeam.LabelText = "Dev Team";
            fDevTeam.Location = new Point(355, 102);
            fDevTeam.MinimumSize = new Size(338, 30);
            fDevTeam.Name = "fDevTeam";
            fDevTeam.Size = new Size(346, 30);
            fDevTeam.TabIndex = 13;
            // 
            // fRailType
            // 
            fRailType.ComboBoxDataSource = null;
            fRailType.LabelText = "Rail Type";
            fRailType.Location = new Point(3, 69);
            fRailType.MinimumSize = new Size(338, 30);
            fRailType.Name = "fRailType";
            fRailType.Size = new Size(346, 30);
            fRailType.TabIndex = 11;
            // 
            // fGripPattern
            // 
            fGripPattern.ComboBoxDataSource = null;
            fGripPattern.LabelText = "Grip Pattern";
            fGripPattern.Location = new Point(707, 36);
            fGripPattern.MinimumSize = new Size(338, 30);
            fGripPattern.Name = "fGripPattern";
            fGripPattern.Size = new Size(346, 30);
            fGripPattern.TabIndex = 8;
            // 
            // fStockPattern
            // 
            fStockPattern.ComboBoxDataSource = null;
            fStockPattern.LabelText = "Stock Pattern";
            fStockPattern.Location = new Point(355, 36);
            fStockPattern.MinimumSize = new Size(338, 30);
            fStockPattern.Name = "fStockPattern";
            fStockPattern.Size = new Size(346, 30);
            fStockPattern.TabIndex = 6;
            // 
            // fFireControlPattern
            // 
            fFireControlPattern.ComboBoxDataSource = null;
            fFireControlPattern.LabelText = "Fire Control Pattern";
            fFireControlPattern.Location = new Point(3, 36);
            fFireControlPattern.MinimumSize = new Size(338, 30);
            fFireControlPattern.Name = "fFireControlPattern";
            fFireControlPattern.Size = new Size(346, 30);
            fFireControlPattern.TabIndex = 4;
            // 
            // fModelType
            // 
            fModelType.ComboBoxDataSource = null;
            fModelType.LabelText = "Model Type";
            fModelType.Location = new Point(3, 3);
            fModelType.MinimumSize = new Size(338, 30);
            fModelType.Name = "fModelType";
            fModelType.Size = new Size(346, 30);
            fModelType.TabIndex = 9;
            // 
            // fCloneOf
            // 
            fCloneOf.ComboBoxDataSource = null;
            fCloneOf.LabelText = "Clone Of";
            fCloneOf.Location = new Point(355, 69);
            fCloneOf.MinimumSize = new Size(338, 30);
            fCloneOf.Name = "fCloneOf";
            fCloneOf.Size = new Size(346, 30);
            fCloneOf.TabIndex = 10;
            // 
            // fFileFormat
            // 
            fFileFormat.ComboBoxDataSource = null;
            fFileFormat.LabelText = "File Format";
            fFileFormat.Location = new Point(707, 69);
            fFileFormat.MinimumSize = new Size(338, 30);
            fFileFormat.Name = "fFileFormat";
            fFileFormat.Size = new Size(346, 30);
            fFileFormat.TabIndex = 12;
            // 
            // fBarrelLength
            // 
            fBarrelLength.ComboBoxDataSource = null;
            fBarrelLength.LabelText = "Barrel Length";
            fBarrelLength.Location = new Point(1059, 69);
            fBarrelLength.MinimumSize = new Size(338, 30);
            fBarrelLength.Name = "fBarrelLength";
            fBarrelLength.Size = new Size(346, 30);
            fBarrelLength.TabIndex = 7;
            // 
            // fBarrelPattern
            // 
            fBarrelPattern.ComboBoxDataSource = null;
            fBarrelPattern.LabelText = "Barrel Pattern";
            fBarrelPattern.Location = new Point(1059, 36);
            fBarrelPattern.MinimumSize = new Size(338, 30);
            fBarrelPattern.Name = "fBarrelPattern";
            fBarrelPattern.Size = new Size(346, 30);
            fBarrelPattern.TabIndex = 5;
            // 
            // fMagPattern
            // 
            fMagPattern.ComboBoxDataSource = null;
            fMagPattern.LabelText = "Magazine Pattern";
            fMagPattern.Location = new Point(1059, 3);
            fMagPattern.MinimumSize = new Size(338, 30);
            fMagPattern.Name = "fMagPattern";
            fMagPattern.Size = new Size(346, 30);
            fMagPattern.TabIndex = 3;
            // 
            // fCaliber
            // 
            fCaliber.ComboBoxDataSource = null;
            fCaliber.LabelText = "Caliber";
            fCaliber.Location = new Point(707, 3);
            fCaliber.MinimumSize = new Size(338, 30);
            fCaliber.Name = "fCaliber";
            fCaliber.Size = new Size(346, 30);
            fCaliber.TabIndex = 0;
            // 
            // fReceiverPattern
            // 
            fReceiverPattern.ComboBoxDataSource = null;
            fReceiverPattern.LabelText = "Receiver Pattern";
            fReceiverPattern.Location = new Point(355, 3);
            fReceiverPattern.MinimumSize = new Size(338, 30);
            fReceiverPattern.Name = "fReceiverPattern";
            fReceiverPattern.Size = new Size(346, 30);
            fReceiverPattern.TabIndex = 15;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSearch.Location = new Point(1065, 139);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(168, 23);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search Repo";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnClearResults
            // 
            btnClearResults.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClearResults.Location = new Point(1239, 137);
            btnClearResults.Name = "btnClearResults";
            btnClearResults.Size = new Size(168, 26);
            btnClearResults.TabIndex = 2;
            btnClearResults.Text = "Clear All";
            btnClearResults.UseVisualStyleBackColor = true;
            btnClearResults.Click += btnClearResults_Click;
            // 
            // gvFileSearchResults
            // 
            gvFileSearchResults.AllowUserToAddRows = false;
            gvFileSearchResults.AllowUserToDeleteRows = false;
            gvFileSearchResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvFileSearchResults.Dock = DockStyle.Fill;
            gvFileSearchResults.Location = new Point(0, 0);
            gvFileSearchResults.Name = "gvFileSearchResults";
            gvFileSearchResults.ReadOnly = true;
            gvFileSearchResults.Size = new Size(1410, 657);
            gvFileSearchResults.TabIndex = 0;
            // 
            // tabVendors
            // 
            tabVendors.Location = new Point(4, 24);
            tabVendors.Name = "tabVendors";
            tabVendors.Size = new Size(1416, 833);
            tabVendors.TabIndex = 3;
            tabVendors.Text = "Vendors";
            tabVendors.UseVisualStyleBackColor = true;
            // 
            // tabResources
            // 
            tabResources.Location = new Point(4, 24);
            tabResources.Name = "tabResources";
            tabResources.Size = new Size(1416, 833);
            tabResources.TabIndex = 4;
            tabResources.Text = "Resources";
            tabResources.UseVisualStyleBackColor = true;
            // 
            // tabConnect
            // 
            tabConnect.Location = new Point(4, 24);
            tabConnect.Name = "tabConnect";
            tabConnect.Size = new Size(1416, 833);
            tabConnect.TabIndex = 5;
            tabConnect.Text = "Connect";
            tabConnect.UseVisualStyleBackColor = true;
            // 
            // tabSettings
            // 
            tabSettings.Controls.Add(groupBox1);
            tabSettings.Location = new Point(4, 24);
            tabSettings.Name = "tabSettings";
            tabSettings.Size = new Size(1416, 833);
            tabSettings.TabIndex = 2;
            tabSettings.Text = "Settings";
            tabSettings.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkAllowLookupEdit);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnCheckForUpdates);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtWadPath);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(8, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1400, 117);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Data Wad";
            // 
            // chkAllowLookupEdit
            // 
            chkAllowLookupEdit.AutoSize = true;
            chkAllowLookupEdit.Location = new Point(873, 24);
            chkAllowLookupEdit.Name = "chkAllowLookupEdit";
            chkAllowLookupEdit.Size = new Size(189, 19);
            chkAllowLookupEdit.TabIndex = 3;
            chkAllowLookupEdit.Text = "Allow Editing of Lookup Values";
            chkAllowLookupEdit.UseVisualStyleBackColor = true;
            chkAllowLookupEdit.CheckedChanged += chkAllowLookupEdit_CheckedChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(767, 51);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(673, 54);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 7;
            label4.Text = "Last Checked";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(767, 22);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(673, 25);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 5;
            label3.Text = "Current Version";
            // 
            // btnCheckForUpdates
            // 
            btnCheckForUpdates.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCheckForUpdates.Location = new Point(6, 80);
            btnCheckForUpdates.Name = "btnCheckForUpdates";
            btnCheckForUpdates.Size = new Size(861, 23);
            btnCheckForUpdates.TabIndex = 4;
            btnCheckForUpdates.Text = "Check Repo for Updated File";
            btnCheckForUpdates.UseVisualStyleBackColor = true;
            btnCheckForUpdates.Click += btnCheckForUpdates_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(94, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(568, 23);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 54);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 2;
            label2.Text = "Repo URL";
            // 
            // txtWadPath
            // 
            txtWadPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtWadPath.Location = new Point(94, 22);
            txtWadPath.Name = "txtWadPath";
            txtWadPath.Size = new Size(568, 23);
            txtWadPath.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Local Path";
            // 
            // btnNewFile
            // 
            btnNewFile.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNewFile.Location = new Point(891, 139);
            btnNewFile.Name = "btnNewFile";
            btnNewFile.Size = new Size(168, 23);
            btnNewFile.TabIndex = 3;
            btnNewFile.Text = "Add New Entry...";
            btnNewFile.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1424, 861);
            Controls.Add(tabControl1);
            MinimumSize = new Size(1440, 900);
            Name = "Main";
            Text = "3D2A4U - GunCAD Index";
            tabControl1.ResumeLayout(false);
            tabWelcome.ResumeLayout(false);
            tabWelcome.PerformLayout();
            tabFiles.ResumeLayout(false);
            spcFileSearch.Panel1.ResumeLayout(false);
            spcFileSearch.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)spcFileSearch).EndInit();
            spcFileSearch.ResumeLayout(false);
            tblFileFilters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gvFileSearchResults).EndInit();
            tabSettings.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblWelcomeTitle;
        private TabControl tabControl1;
        private TabPage tabWelcome;
        private TabPage tabFiles;
        private SplitContainer spcFileSearch;
        private DataGridView gvFileSearchResults;
        private TabPage tabVendors;
        private TabPage tabResources;
        private TabPage tabConnect;
        private TabPage tabSettings;
        private TableLayoutPanel tblFileFilters;
        private FilterKvp fCaliber;
        private Button btnSearch;
        private Button btnClearResults;
        private FilterKvp fFireControlPattern;
        private FilterKvp fMagPattern;
        private FilterKvp fBarrelPattern;
        private FilterKvp fStockPattern;
        private FilterKvp fBarrelLength;
        private FilterKvp fGripPattern;
        private FilterKvp fModelType;
        private FilterKvp fRailType;
        private FilterKvp fCloneOf;
        private FilterKvp fFileFormat;
        private FilterKvp fDeveloper;
        private FilterKvp fDevTeam;
        private FilterKvp fReceiverPattern;
        private GroupBox groupBox1;
        private Button btnCheckForUpdates;
        private TextBox textBox1;
        private Label label2;
        private TextBox txtWadPath;
        private Label label1;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private CheckBox chkAllowLookupEdit;
        private Button btnNewFile;
        private ToolTip toolTip1;
    }
}
