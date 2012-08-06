using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace BitLockDrive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDriveLockMsg.Hide();
            BindComboBoxToDrives();
        }

        private void BindComboBoxToDrives()
        {
            List<string> sysDriveList = new List<string>();
            sysDriveList.InsertRange(0, System.IO.Directory.GetLogicalDrives());
            BindingSource drvSource = new BindingSource();
            drvSource.DataSource = sysDriveList;
            cmbDriveSelect.DataSource = drvSource;
        }

        private void btnLock_Click(object sender, EventArgs e)
        {                   
            string drvSelected = cmbDriveSelect.SelectedValue.ToString();
            string sysDirWithBDE = Environment.SystemDirectory + "\\manage-bde.exe";
            string lockStatus = String.Empty;

            // This is the code for the base process
            Process myProcess = new Process();
              
            // Start a new instance of this program
            ProcessStartInfo myProcessStartInfo = new ProcessStartInfo(sysDirWithBDE, " -LOCK " + drvSelected.Remove(2));
            //Set Use Shell to false so as to redirect process run info to application
            myProcessStartInfo.UseShellExecute = false;           
            myProcessStartInfo.RedirectStandardOutput = true;
            myProcess.StartInfo = myProcessStartInfo;
            try
            {                 
                myProcess.Start();
                lblDriveLockMsg.Show(); 
            }
            catch (Exception err)
            {                
                lblDriveLockMsg.Text = err.Message;
            }
            //Read the standard output of the process.
            lockStatus = myProcess.StandardOutput.ReadToEnd();
            if (lockStatus.Contains("code 0x80070057"))
                lblDriveLockMsg.Text = "Drive selected is not Bit Locker encrypted";
            else
                lblDriveLockMsg.Text = lockStatus;
           
            myProcess.WaitForExit();
            myProcess.Close();
        }
    }
}
