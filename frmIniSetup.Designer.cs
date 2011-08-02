namespace McMoonPunch
{
    partial class frmIniSetup
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
            this.tboxLocation = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.grpServerInstall = new System.Windows.Forms.GroupBox();
            this.lstServerChoice = new System.Windows.Forms.ComboBox();
            this.lblServerChoice = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.grpServerProperties = new System.Windows.Forms.GroupBox();
            this.btnMore = new System.Windows.Forms.Button();
            this.chkOnlineMode = new System.Windows.Forms.CheckBox();
            this.tboxPort = new System.Windows.Forms.TextBox();
            this.lblServerPort = new System.Windows.Forms.Label();
            this.chkAllowPvP = new System.Windows.Forms.CheckBox();
            this.tboxMaxPlayers = new System.Windows.Forms.TextBox();
            this.lblMaxPlayers = new System.Windows.Forms.Label();
            this.chkFlight = new System.Windows.Forms.CheckBox();
            this.chkAnimals = new System.Windows.Forms.CheckBox();
            this.tboxWorldName = new System.Windows.Forms.TextBox();
            this.chkMonsters = new System.Windows.Forms.CheckBox();
            this.chkAllowNether = new System.Windows.Forms.CheckBox();
            this.lblLevelName = new System.Windows.Forms.Label();
            this.grpDownloadInstall = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.prgDownloadInstall = new System.Windows.Forms.ProgressBar();
            this.btnDownloadInstall = new System.Windows.Forms.Button();
            this.statBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.InstallationDir = new System.Windows.Forms.FolderBrowserDialog();
            this.numViewDist = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxLvlSeed = new System.Windows.Forms.TextBox();
            this.chkWhiteList = new System.Windows.Forms.CheckBox();
            this.rtboxWhiteList = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtboxOperators = new System.Windows.Forms.RichTextBox();
            this.chkOperators = new System.Windows.Forms.CheckBox();
            this.tboxServerIp = new System.Windows.Forms.TextBox();
            this.lblServerIp = new System.Windows.Forms.Label();
            this.grpMisc = new System.Windows.Forms.GroupBox();
            this.grpServerInstall.SuspendLayout();
            this.grpServerProperties.SuspendLayout();
            this.grpDownloadInstall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numViewDist)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpMisc.SuspendLayout();
            this.SuspendLayout();
            // 
            // tboxLocation
            // 
            this.tboxLocation.Location = new System.Drawing.Point(9, 40);
            this.tboxLocation.Name = "tboxLocation";
            this.tboxLocation.Size = new System.Drawing.Size(254, 20);
            this.tboxLocation.TabIndex = 1;
            this.tboxLocation.Text = "C:\\MPServer\\";
            // 
            // btnBrowse
            // 
            this.btnBrowse.AutoEllipsis = true;
            this.btnBrowse.Location = new System.Drawing.Point(269, 38);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(76, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpServerInstall
            // 
            this.grpServerInstall.Controls.Add(this.lstServerChoice);
            this.grpServerInstall.Controls.Add(this.lblServerChoice);
            this.grpServerInstall.Controls.Add(this.lblLocation);
            this.grpServerInstall.Controls.Add(this.btnBrowse);
            this.grpServerInstall.Controls.Add(this.tboxLocation);
            this.grpServerInstall.Location = new System.Drawing.Point(1, 1);
            this.grpServerInstall.Name = "grpServerInstall";
            this.grpServerInstall.Size = new System.Drawing.Size(354, 104);
            this.grpServerInstall.TabIndex = 5;
            this.grpServerInstall.TabStop = false;
            this.grpServerInstall.Text = "Server Installation";
            // 
            // lstServerChoice
            // 
            this.lstServerChoice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstServerChoice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstServerChoice.FormattingEnabled = true;
            this.lstServerChoice.Items.AddRange(new object[] {
            "Bukkit",
            "Official"});
            this.lstServerChoice.Location = new System.Drawing.Point(233, 72);
            this.lstServerChoice.Name = "lstServerChoice";
            this.lstServerChoice.Size = new System.Drawing.Size(112, 21);
            this.lstServerChoice.TabIndex = 3;
            this.lstServerChoice.Text = "Bukkit";
            // 
            // lblServerChoice
            // 
            this.lblServerChoice.AutoSize = true;
            this.lblServerChoice.Location = new System.Drawing.Point(6, 75);
            this.lblServerChoice.Name = "lblServerChoice";
            this.lblServerChoice.Size = new System.Drawing.Size(221, 13);
            this.lblServerChoice.TabIndex = 6;
            this.lblServerChoice.Text = "Which server software would you like to use?";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(6, 24);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(206, 13);
            this.lblLocation.TabIndex = 5;
            this.lblLocation.Text = "Where would you like to install the server?";
            // 
            // grpServerProperties
            // 
            this.grpServerProperties.Controls.Add(this.tboxLvlSeed);
            this.grpServerProperties.Controls.Add(this.label2);
            this.grpServerProperties.Controls.Add(this.label1);
            this.grpServerProperties.Controls.Add(this.numViewDist);
            this.grpServerProperties.Controls.Add(this.btnMore);
            this.grpServerProperties.Controls.Add(this.chkOnlineMode);
            this.grpServerProperties.Controls.Add(this.tboxPort);
            this.grpServerProperties.Controls.Add(this.lblServerPort);
            this.grpServerProperties.Controls.Add(this.chkAllowPvP);
            this.grpServerProperties.Controls.Add(this.tboxMaxPlayers);
            this.grpServerProperties.Controls.Add(this.lblMaxPlayers);
            this.grpServerProperties.Controls.Add(this.chkFlight);
            this.grpServerProperties.Controls.Add(this.chkAnimals);
            this.grpServerProperties.Controls.Add(this.tboxWorldName);
            this.grpServerProperties.Controls.Add(this.chkMonsters);
            this.grpServerProperties.Controls.Add(this.chkAllowNether);
            this.grpServerProperties.Controls.Add(this.lblLevelName);
            this.grpServerProperties.Location = new System.Drawing.Point(361, 1);
            this.grpServerProperties.Name = "grpServerProperties";
            this.grpServerProperties.Size = new System.Drawing.Size(207, 227);
            this.grpServerProperties.TabIndex = 6;
            this.grpServerProperties.TabStop = false;
            this.grpServerProperties.Text = "Server Properties";
            // 
            // btnMore
            // 
            this.btnMore.Location = new System.Drawing.Point(9, 198);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(179, 23);
            this.btnMore.TabIndex = 15;
            this.btnMore.Text = "More >>";
            this.btnMore.UseVisualStyleBackColor = true;
            this.btnMore.Click += new System.EventHandler(this.btnMore_Click);
            // 
            // chkOnlineMode
            // 
            this.chkOnlineMode.AutoSize = true;
            this.chkOnlineMode.Checked = true;
            this.chkOnlineMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOnlineMode.Location = new System.Drawing.Point(102, 131);
            this.chkOnlineMode.Name = "chkOnlineMode";
            this.chkOnlineMode.Size = new System.Drawing.Size(86, 17);
            this.chkOnlineMode.TabIndex = 10;
            this.chkOnlineMode.Text = "Online Mode";
            this.chkOnlineMode.UseVisualStyleBackColor = true;
            // 
            // tboxPort
            // 
            this.tboxPort.Location = new System.Drawing.Point(74, 59);
            this.tboxPort.Name = "tboxPort";
            this.tboxPort.Size = new System.Drawing.Size(50, 20);
            this.tboxPort.TabIndex = 6;
            this.tboxPort.Text = "25565";
            // 
            // lblServerPort
            // 
            this.lblServerPort.AutoSize = true;
            this.lblServerPort.Location = new System.Drawing.Point(45, 62);
            this.lblServerPort.Name = "lblServerPort";
            this.lblServerPort.Size = new System.Drawing.Size(29, 13);
            this.lblServerPort.TabIndex = 11;
            this.lblServerPort.Text = "Port:";
            // 
            // chkAllowPvP
            // 
            this.chkAllowPvP.AutoSize = true;
            this.chkAllowPvP.Location = new System.Drawing.Point(9, 131);
            this.chkAllowPvP.Name = "chkAllowPvP";
            this.chkAllowPvP.Size = new System.Drawing.Size(74, 17);
            this.chkAllowPvP.TabIndex = 9;
            this.chkAllowPvP.Text = "Allow PvP";
            this.chkAllowPvP.UseVisualStyleBackColor = true;
            // 
            // tboxMaxPlayers
            // 
            this.tboxMaxPlayers.Location = new System.Drawing.Point(74, 36);
            this.tboxMaxPlayers.Name = "tboxMaxPlayers";
            this.tboxMaxPlayers.Size = new System.Drawing.Size(50, 20);
            this.tboxMaxPlayers.TabIndex = 5;
            this.tboxMaxPlayers.Text = "24";
            // 
            // lblMaxPlayers
            // 
            this.lblMaxPlayers.AutoSize = true;
            this.lblMaxPlayers.Location = new System.Drawing.Point(7, 39);
            this.lblMaxPlayers.Name = "lblMaxPlayers";
            this.lblMaxPlayers.Size = new System.Drawing.Size(67, 13);
            this.lblMaxPlayers.TabIndex = 6;
            this.lblMaxPlayers.Text = "Max Players:";
            // 
            // chkFlight
            // 
            this.chkFlight.AutoSize = true;
            this.chkFlight.Checked = true;
            this.chkFlight.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFlight.Location = new System.Drawing.Point(102, 178);
            this.chkFlight.Name = "chkFlight";
            this.chkFlight.Size = new System.Drawing.Size(79, 17);
            this.chkFlight.TabIndex = 14;
            this.chkFlight.Text = "Allow Flight";
            this.chkFlight.UseVisualStyleBackColor = true;
            // 
            // chkAnimals
            // 
            this.chkAnimals.AutoSize = true;
            this.chkAnimals.Checked = true;
            this.chkAnimals.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAnimals.Location = new System.Drawing.Point(9, 178);
            this.chkAnimals.Name = "chkAnimals";
            this.chkAnimals.Size = new System.Drawing.Size(62, 17);
            this.chkAnimals.TabIndex = 13;
            this.chkAnimals.Text = "Animals";
            this.chkAnimals.UseVisualStyleBackColor = true;
            // 
            // tboxWorldName
            // 
            this.tboxWorldName.Location = new System.Drawing.Point(74, 13);
            this.tboxWorldName.Name = "tboxWorldName";
            this.tboxWorldName.Size = new System.Drawing.Size(114, 20);
            this.tboxWorldName.TabIndex = 4;
            this.tboxWorldName.Text = "World1";
            // 
            // chkMonsters
            // 
            this.chkMonsters.AutoSize = true;
            this.chkMonsters.Checked = true;
            this.chkMonsters.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMonsters.Location = new System.Drawing.Point(102, 154);
            this.chkMonsters.Name = "chkMonsters";
            this.chkMonsters.Size = new System.Drawing.Size(69, 17);
            this.chkMonsters.TabIndex = 12;
            this.chkMonsters.Text = "Monsters";
            this.chkMonsters.UseVisualStyleBackColor = true;
            // 
            // chkAllowNether
            // 
            this.chkAllowNether.AutoSize = true;
            this.chkAllowNether.Checked = true;
            this.chkAllowNether.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAllowNether.Location = new System.Drawing.Point(9, 154);
            this.chkAllowNether.Name = "chkAllowNether";
            this.chkAllowNether.Size = new System.Drawing.Size(86, 17);
            this.chkAllowNether.TabIndex = 11;
            this.chkAllowNether.Text = "Allow Nether";
            this.chkAllowNether.UseVisualStyleBackColor = true;
            // 
            // lblLevelName
            // 
            this.lblLevelName.AutoSize = true;
            this.lblLevelName.Location = new System.Drawing.Point(7, 16);
            this.lblLevelName.Name = "lblLevelName";
            this.lblLevelName.Size = new System.Drawing.Size(67, 13);
            this.lblLevelName.TabIndex = 0;
            this.lblLevelName.Text = "Level Name:";
            // 
            // grpDownloadInstall
            // 
            this.grpDownloadInstall.Controls.Add(this.lblStatus);
            this.grpDownloadInstall.Controls.Add(this.prgDownloadInstall);
            this.grpDownloadInstall.Controls.Add(this.btnDownloadInstall);
            this.grpDownloadInstall.Location = new System.Drawing.Point(1, 109);
            this.grpDownloadInstall.Name = "grpDownloadInstall";
            this.grpDownloadInstall.Size = new System.Drawing.Size(354, 73);
            this.grpDownloadInstall.TabIndex = 7;
            this.grpDownloadInstall.TabStop = false;
            this.grpDownloadInstall.Text = "Final Steps!";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(147, 48);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status";
            // 
            // prgDownloadInstall
            // 
            this.prgDownloadInstall.Location = new System.Drawing.Point(6, 13);
            this.prgDownloadInstall.Name = "prgDownloadInstall";
            this.prgDownloadInstall.Size = new System.Drawing.Size(342, 27);
            this.prgDownloadInstall.TabIndex = 1;
            // 
            // btnDownloadInstall
            // 
            this.btnDownloadInstall.Location = new System.Drawing.Point(6, 43);
            this.btnDownloadInstall.Name = "btnDownloadInstall";
            this.btnDownloadInstall.Size = new System.Drawing.Size(135, 23);
            this.btnDownloadInstall.TabIndex = 16;
            this.btnDownloadInstall.Text = "Download && Install...";
            this.btnDownloadInstall.UseVisualStyleBackColor = true;
            this.btnDownloadInstall.Click += new System.EventHandler(this.btnDownloadInstall_Click);
            // 
            // statBar
            // 
            this.statBar.Location = new System.Drawing.Point(0, 229);
            this.statBar.Name = "statBar";
            this.statBar.Size = new System.Drawing.Size(779, 22);
            this.statBar.SizingGrip = false;
            this.statBar.TabIndex = 8;
            this.statBar.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoToolTip = true;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // InstallationDir
            // 
            this.InstallationDir.Description = "Select the directory that you wich to install your server files within:";
            this.InstallationDir.SelectedPath = "C:\\";
            // 
            // numViewDist
            // 
            this.numViewDist.Location = new System.Drawing.Point(74, 105);
            this.numViewDist.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numViewDist.Name = "numViewDist";
            this.numViewDist.Size = new System.Drawing.Size(50, 20);
            this.numViewDist.TabIndex = 8;
            this.numViewDist.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "View Dist.:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Map Seed:";
            // 
            // tboxLvlSeed
            // 
            this.tboxLvlSeed.Location = new System.Drawing.Point(74, 82);
            this.tboxLvlSeed.Name = "tboxLvlSeed";
            this.tboxLvlSeed.Size = new System.Drawing.Size(127, 20);
            this.tboxLvlSeed.TabIndex = 7;
            // 
            // chkWhiteList
            // 
            this.chkWhiteList.AutoSize = true;
            this.chkWhiteList.Location = new System.Drawing.Point(6, 79);
            this.chkWhiteList.Name = "chkWhiteList";
            this.chkWhiteList.Size = new System.Drawing.Size(109, 17);
            this.chkWhiteList.TabIndex = 19;
            this.chkWhiteList.Text = "Enable White List";
            this.chkWhiteList.UseVisualStyleBackColor = true;
            // 
            // rtboxWhiteList
            // 
            this.rtboxWhiteList.Location = new System.Drawing.Point(6, 16);
            this.rtboxWhiteList.Name = "rtboxWhiteList";
            this.rtboxWhiteList.Size = new System.Drawing.Size(188, 62);
            this.rtboxWhiteList.TabIndex = 18;
            this.rtboxWhiteList.Text = "Enter a comma seperated list of allowed users.";
            this.rtboxWhiteList.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.rtboxWhiteList.Enter += new System.EventHandler(this.rtboxWhiteList_Enter);
            this.rtboxWhiteList.Leave += new System.EventHandler(this.rtboxWhiteList_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtboxWhiteList);
            this.groupBox1.Controls.Add(this.chkWhiteList);
            this.groupBox1.Location = new System.Drawing.Point(574, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 97);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "White List";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkOperators);
            this.groupBox2.Controls.Add(this.rtboxOperators);
            this.groupBox2.Location = new System.Drawing.Point(574, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 91);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operator List";
            // 
            // rtboxOperators
            // 
            this.rtboxOperators.Location = new System.Drawing.Point(6, 15);
            this.rtboxOperators.Name = "rtboxOperators";
            this.rtboxOperators.Size = new System.Drawing.Size(188, 59);
            this.rtboxOperators.TabIndex = 20;
            this.rtboxOperators.Text = "Enter a comma seperated list of operators/admins of your server.";
            this.rtboxOperators.TextChanged += new System.EventHandler(this.rtboxOperators_TextChanged);
            this.rtboxOperators.Enter += new System.EventHandler(this.rtboxOperators_Enter);
            this.rtboxOperators.Leave += new System.EventHandler(this.rtboxOperators_Leave);
            // 
            // chkOperators
            // 
            this.chkOperators.AutoSize = true;
            this.chkOperators.Location = new System.Drawing.Point(6, 74);
            this.chkOperators.Name = "chkOperators";
            this.chkOperators.Size = new System.Drawing.Size(122, 17);
            this.chkOperators.TabIndex = 21;
            this.chkOperators.Text = "Enable Operator List";
            this.chkOperators.UseVisualStyleBackColor = true;
            // 
            // tboxServerIp
            // 
            this.tboxServerIp.Location = new System.Drawing.Point(66, 10);
            this.tboxServerIp.Name = "tboxServerIp";
            this.tboxServerIp.Size = new System.Drawing.Size(128, 20);
            this.tboxServerIp.TabIndex = 17;
            // 
            // lblServerIp
            // 
            this.lblServerIp.AutoSize = true;
            this.lblServerIp.Location = new System.Drawing.Point(6, 13);
            this.lblServerIp.Name = "lblServerIp";
            this.lblServerIp.Size = new System.Drawing.Size(54, 13);
            this.lblServerIp.TabIndex = 15;
            this.lblServerIp.Text = "Server IP:";
            // 
            // grpMisc
            // 
            this.grpMisc.Controls.Add(this.lblServerIp);
            this.grpMisc.Controls.Add(this.tboxServerIp);
            this.grpMisc.Location = new System.Drawing.Point(574, 5);
            this.grpMisc.Name = "grpMisc";
            this.grpMisc.Size = new System.Drawing.Size(200, 33);
            this.grpMisc.TabIndex = 16;
            this.grpMisc.TabStop = false;
            this.grpMisc.Text = "Misc";
            // 
            // frmIniSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 251);
            this.Controls.Add(this.grpMisc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statBar);
            this.Controls.Add(this.grpDownloadInstall);
            this.Controls.Add(this.grpServerProperties);
            this.Controls.Add(this.grpServerInstall);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmIniSetup";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  Initial Configuration";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmIniSetup_Load);
            this.grpServerInstall.ResumeLayout(false);
            this.grpServerInstall.PerformLayout();
            this.grpServerProperties.ResumeLayout(false);
            this.grpServerProperties.PerformLayout();
            this.grpDownloadInstall.ResumeLayout(false);
            this.grpDownloadInstall.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numViewDist)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpMisc.ResumeLayout(false);
            this.grpMisc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxLocation;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.GroupBox grpServerInstall;
        private System.Windows.Forms.ComboBox lstServerChoice;
        private System.Windows.Forms.Label lblServerChoice;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.GroupBox grpServerProperties;
        private System.Windows.Forms.TextBox tboxWorldName;
        private System.Windows.Forms.Label lblLevelName;
        private System.Windows.Forms.TextBox tboxMaxPlayers;
        private System.Windows.Forms.Label lblMaxPlayers;
        private System.Windows.Forms.CheckBox chkFlight;
        private System.Windows.Forms.CheckBox chkAnimals;
        private System.Windows.Forms.CheckBox chkMonsters;
        private System.Windows.Forms.CheckBox chkAllowNether;
        private System.Windows.Forms.CheckBox chkAllowPvP;
        private System.Windows.Forms.CheckBox chkOnlineMode;
        private System.Windows.Forms.GroupBox grpDownloadInstall;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ProgressBar prgDownloadInstall;
        private System.Windows.Forms.Button btnDownloadInstall;
        private System.Windows.Forms.StatusStrip statBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.FolderBrowserDialog InstallationDir;
        private System.Windows.Forms.Button btnMore;
        private System.Windows.Forms.TextBox tboxPort;
        private System.Windows.Forms.Label lblServerPort;
        private System.Windows.Forms.TextBox tboxLvlSeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numViewDist;
        private System.Windows.Forms.CheckBox chkWhiteList;
        private System.Windows.Forms.RichTextBox rtboxWhiteList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkOperators;
        private System.Windows.Forms.RichTextBox rtboxOperators;
        private System.Windows.Forms.TextBox tboxServerIp;
        private System.Windows.Forms.Label lblServerIp;
        private System.Windows.Forms.GroupBox grpMisc;
    }
}