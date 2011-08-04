using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using Microsoft.Win32;

namespace McMoonPunch
{
    public partial class frmIniSetup : Form
    {
        string installDir;
        string fileName;
        string chosenServer;

        public frmIniSetup()
        {
            InitializeComponent();
        }

        // Select the installation directory using the folder selector
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = this.InstallationDir.ShowDialog();
            if (result == DialogResult.OK)
            {
                tboxLocation.Text = InstallationDir.SelectedPath;
            }

        }

        // Download the selected server to the chosen location
        private void btnDownloadInstall_Click(object sender, EventArgs e)
        {
            if (btnDownloadInstall.Text == "Finish && Close...")
            {
                DialogResult result = MessageBox.Show(String.Format("Your Minecraft Server has been installed to {0}\nThis is only a test version, there are going to be many more additions yet!", GlobalVar.cleanDir),"McMoonServer", MessageBoxButtons.OK);
                Application.Exit();
                //Close();
            }
            else
            {
                dirSoap();

                if (File.Exists(installDir))
                {
                    DialogResult Result = MessageBox.Show(string.Format("A {0} server already exists, do you wish to continue? \r\n(Files will be overwritten)", lstServerChoice.Text, fileName),
                                                  String.Format("{0} Installation Detected", lstServerChoice.Text), MessageBoxButtons.YesNo);
                    if (Result == DialogResult.Yes)
                    {
                        install();
                    }
                    else
                    {
                        lblStatus.Text = "User Cancelled: File already exists.";
                    }
                }
                else
                {
                    install();
                }
            }
        }

        private void frmIniSetup_Load(object sender, EventArgs e)
        {
            lblStatus.Text = null;
            this.Width = 575;
        }

        // ========================================================
        // Custom Methods - BEGINNING
        // --------------------------------------------------------
        // All custom methods created for the downloader/installer
        // can be found below, along with full explanations of
        // what they do, edit anything you want but be careful!
        // ========================================================

        // Installation directory cleaner and misc operations
        private void dirSoap()
        {
            string rawDir = tboxLocation.Text;

            if (lstServerChoice.Text == "Bukkit")
            {
                GlobalVar.cleanDir = rawDir.Replace("\\", "\\\\");                         // Replace all occurances of '/' with '//'
                Directory.CreateDirectory(GlobalVar.cleanDir);                             // Creates all the directories within the stated path
                installDir = (GlobalVar.cleanDir + "\\\\" + GlobalVar.bukkitFileName);     // Appends the filename onto the end of the installation dir
                fileName = GlobalVar.bukkitFileName;                             // Sets the filename used in the installation (bukkit*.*.*.jar)
                chosenServer = GlobalVar.BukkitDownload;                         // Sets the download link for the Bukkit server
            }
            else if (lstServerChoice.Text == "Official")
            {
                GlobalVar.cleanDir = rawDir.Replace("\\", "\\\\");
                Directory.CreateDirectory(GlobalVar.cleanDir);
                installDir = (GlobalVar.cleanDir + "\\\\" + GlobalVar.officialFileName);
                fileName = GlobalVar.officialFileName;                  // (minecraft_server.jar)
                chosenServer = GlobalVar.OfficialDownload;
            }
        }

        // Installation process
        private void install()
        {
            lblStatus.Text = "Creating directories";
            WebClient webClient = new WebClient();                                                          // Creates a webclient
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);                   // Uses the Event Handler to check whether the download is complete
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);  // Uses the Event Handler to check for progress made
            webClient.DownloadFileAsync(new Uri(chosenServer), installDir);                                 // Defines the URL and destination directory for the downloaded file
            lblStatus.Text = "Applying custom settings";        
        }

        // Download progress
        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            prgDownloadInstall.Value = e.ProgressPercentage;
            lblStatus.Text = String.Format("Downloading Latest {0} Version...", lstServerChoice.Text);
        }

        // Download completed
        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            lblStatus.Text = "Download Complete!";
            serverConfig();
        }

        // Server Properties creator
        private void serverConfig()
        {
            btnDownloadInstall.Enabled = false;
            lblStatus.Text = "Applying Custom Configuration...";
            // The following creates the server.properties file using the settings provided during setup
            using (StreamWriter serverProperties = new StreamWriter(GlobalVar.cleanDir + @"\server.properties"))
            {
                serverProperties.WriteLine(String.Format("#{0} server properties", lstServerChoice.Text));
                serverProperties.WriteLine(String.Format("#{0}-{1}-{2} ({3}:{4})", DateTime.Now.Day, DateTime.Now.Month,
                                                                                   DateTime.Now.Year, DateTime.Now.Hour,
                                                                                   DateTime.Now.Minute));
                serverProperties.WriteLine(String.Format("#Generated by MCMoonPunch Server Admin"));
                serverProperties.WriteLine(String.Format("level-name={0}", tboxWorldName.Text));
                serverProperties.WriteLine(String.Format("view-distance={0}", numViewDist.Value));
                serverProperties.WriteLine(String.Format("spawn-monsters={0}", chkMonsters.Checked));
                serverProperties.WriteLine(String.Format("online-mode={0}", chkOnlineMode.Checked));
                serverProperties.WriteLine(String.Format("spawn-animals={0}", chkAnimals.Checked));
                serverProperties.WriteLine(String.Format("max-players={0}", tboxMaxPlayers.Text));
                serverProperties.WriteLine(String.Format("server-ip={0}", tboxServerIp.Text));
                serverProperties.WriteLine(String.Format("pvp={0}", chkAllowPvP.Checked));
                serverProperties.WriteLine(String.Format("level-seed={0}", tboxLvlSeed.Text));
                serverProperties.WriteLine(String.Format("server-port={0}", tboxPort.Text));
                serverProperties.WriteLine(String.Format("allow-flight={0}", chkFlight.Checked));
                serverProperties.WriteLine(String.Format("white-list={0}", chkWhiteList.Checked));
            }

            if (chkWhiteList.Checked)
            {
                // This will take the comma seperated list of users to add to the white list
                // and put them into the white-lists.txt file, if the user wants to use white list
                string rawUser = rtboxWhiteList.Text.Replace(" ", "");
                string[] list = rawUser.Split(new char[] { ',' });
                using (StreamWriter whiteList = new StreamWriter(GlobalVar.cleanDir + @"\white-list.txt"))
                {
                    foreach (string user in list)
                    {
                        whiteList.WriteLine(String.Format("{0}", user));
                    }
                }
            }

            if (chkOperators.Checked)
            {
                // This will take the comma seperated list of users who recieve operator status
                // when joining the server, it will write their usernames to ops.txt, if the user has it checked
                string rawUser = rtboxOperators.Text.Replace(" ", "");
                string[] list = rawUser.Split(new char[] { ',' });
                using (StreamWriter opsList = new StreamWriter(GlobalVar.cleanDir + @"\ops.txt"))
                {
                    foreach (string user in list)
                    {
                        opsList.WriteLine(String.Format("{0}", user));
                    }
                }
            }
            if (lstServerChoice.Text == "Bukkit")
            {
                using (StreamWriter batchStart = new StreamWriter(GlobalVar.cleanDir + GlobalVar.batchFileName))
                {
                    batchStart.WriteLine("@ECHO OFF");
                    batchStart.WriteLine("SET BINDIR=%~DP0");
                    batchStart.WriteLine(String.Format("{0} -Xincgc -Xmx1G -jar {1}", GlobalVar.javaLocation, fileName));
                }
            }
            else
            {
                using (StreamWriter batchStart = new StreamWriter(GlobalVar.cleanDir + GlobalVar.batchFileName))
                {
                    batchStart.WriteLine(String.Format("@ECHO OFF"));
                    batchStart.WriteLine(String.Format("{0} {1} nogui", GlobalVar.javaLocation, fileName));
                }
            }
            lblStatus.Text = "Installation && Configuration complete!";
            btnDownloadInstall.Text = "Finish && Close...";
            btnDownloadInstall.Enabled = true;
        }

        //==============================
        //----Custom Methods - END------
        //==============================

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            chkWhiteList.Checked = true;    // Automatically check the box when the user enters text
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            if (this.Width == 575)
            {
                btnMore.Text = "<< Less";
                this.Width = 785;
            }
            else
            {
                btnMore.Text = "More >>";
                this.Width = 575;
            }
        }

        private void rtboxOperators_TextChanged(object sender, EventArgs e)
        {
            chkOperators.Checked = true;
        }

        private void rtboxOperators_Enter(object sender, EventArgs e)
        {
            if (rtboxOperators.Text == "Enter a comma seperated list of operators/admins of your server.")
            {
                rtboxOperators.Clear();
            }
        }

        private void rtboxOperators_Leave(object sender, EventArgs e)
        {
            if (rtboxOperators.Text == String.Empty)
            {
                rtboxOperators.Text = "Enter a comma seperated list of operators/admins of your server.";
                chkOperators.Checked = false;
            }
        }

        private void rtboxWhiteList_Enter(object sender, EventArgs e)
        {
            if (rtboxWhiteList.Text == "Enter a comma seperated list of allowed users.")
            {
                rtboxWhiteList.Clear();
            }
        }
        
        private void rtboxWhiteList_Leave(object sender, EventArgs e)
        {
            if (rtboxWhiteList.Text == String.Empty)
            {
                rtboxWhiteList.Text = "Enter a comma seperated list of allowed users.";
                chkWhiteList.Checked = false;
            }
        }
    }
}
