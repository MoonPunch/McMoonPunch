using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Diagnostics;

namespace McMoonPunch
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.FirstRun)
            {
                frmIniSetup initialSetup = new frmIniSetup();
                initialSetup.ShowDialog();
            }
            else
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int loop = 1;
            serverStart();
            while (loop == 1)
            {
                rtboxServerOut.AppendText(GlobalVar.batchOut);
            }
        }

        private void serverStart()
        {
            // Application path and command line arguments
            string ApplicationPath = GlobalVar.cleanDir + GlobalVar.batchFileName;
            string ApplicationArguments = "-c -x";

            // Create a new process object
            Process ProcessObj = new Process();

            // StartInfo contains the startup information of
            // the new process
            ProcessObj.StartInfo.FileName = ApplicationPath;
            ProcessObj.StartInfo.Arguments = ApplicationArguments;

            // These two optional flags ensure that no DOS window
            // appears
            ProcessObj.StartInfo.UseShellExecute = false;
            ProcessObj.StartInfo.CreateNoWindow = false;

            // If this option is set the DOS window appears again :-/
            // ProcessObj.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

            // This ensures that you get the output from the DOS application
            ProcessObj.StartInfo.RedirectStandardOutput = true;

            // Start the process
            ProcessObj.Start();

            // Wait that the process exits
            ProcessObj.WaitForExit();

            // Now read the output of the DOS application
            GlobalVar.batchOut = ProcessObj.StandardOutput.ReadToEnd();
        }
    }
}