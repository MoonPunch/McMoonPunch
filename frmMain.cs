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
            using (Process p = new Process())
            {
                p.StartInfo.WorkingDirectory = GlobalVar.cleanDir;
                p.StartInfo.FileName = GlobalVar.cleanDir+GlobalVar.batchFileName;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;
                p.Start();
                p.WaitForExit();

                // Capture output from batch file written to stdout and put in the 
                // RunResults textbox
                string output = p.StandardOutput.ReadToEnd();
                if (!String.IsNullOrEmpty(output) && output.Trim() != "")
                {
                    this.rtboxServerOut.Text = output;
                }

                // Capture any errors written to stderr and put in the errors textbox.
                string errors = p.StandardError.ReadToEnd();
                if (!String.IsNullOrEmpty(errors) & errors.Trim() != "")
                {
                    this.rtboxErrors.Text = errors;
                }
            }
        }
    }
}