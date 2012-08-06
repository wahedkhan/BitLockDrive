namespace BitLockDrive
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
            this.lblDriveToLock = new System.Windows.Forms.Label();
            this.cmbDriveSelect = new System.Windows.Forms.ComboBox();
            this.btnLock = new System.Windows.Forms.Button();
            this.lblDriveLockMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDriveToLock
            // 
            this.lblDriveToLock.AutoSize = true;
            this.lblDriveToLock.Location = new System.Drawing.Point(33, 39);
            this.lblDriveToLock.Name = "lblDriveToLock";
            this.lblDriveToLock.Size = new System.Drawing.Size(108, 13);
            this.lblDriveToLock.TabIndex = 0;
            this.lblDriveToLock.Text = "Select Drive To Lock";
            // 
            // cmbDriveSelect
            // 
            this.cmbDriveSelect.FormattingEnabled = true;
            this.cmbDriveSelect.Location = new System.Drawing.Point(147, 35);
            this.cmbDriveSelect.Name = "cmbDriveSelect";
            this.cmbDriveSelect.Size = new System.Drawing.Size(121, 21);
            this.cmbDriveSelect.TabIndex = 1;
            // 
            // btnLock
            // 
            this.btnLock.Location = new System.Drawing.Point(274, 34);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(83, 23);
            this.btnLock.TabIndex = 3;
            this.btnLock.Text = "Lock";
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // lblDriveLockMsg
            // 
            this.lblDriveLockMsg.AutoSize = true;
            this.lblDriveLockMsg.Location = new System.Drawing.Point(33, 71);
            this.lblDriveLockMsg.Name = "lblDriveLockMsg";
            this.lblDriveLockMsg.Size = new System.Drawing.Size(32, 13);
            this.lblDriveLockMsg.TabIndex = 4;
            this.lblDriveLockMsg.Text = "Drive";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(401, 135);
            this.Controls.Add(this.lblDriveLockMsg);
            this.Controls.Add(this.btnLock);
            this.Controls.Add(this.cmbDriveSelect);
            this.Controls.Add(this.lblDriveToLock);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "BitLocker Drive Lock Utility";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDriveToLock;
        private System.Windows.Forms.ComboBox cmbDriveSelect;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.Label lblDriveLockMsg;

    }
}

