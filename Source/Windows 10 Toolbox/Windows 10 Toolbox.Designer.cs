namespace Windows_10_Toolbox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonRestoreAll = new System.Windows.Forms.Button();
            this.buttonRemoveOneDrive = new System.Windows.Forms.Button();
            this.buttonRemoveChosen = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.buttonRemoveWindowsOld = new System.Windows.Forms.Button();
            this.buttonEditStartMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            resources.ApplyResources(this.buttonExit, "buttonExit");
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonRestoreAll
            // 
            resources.ApplyResources(this.buttonRestoreAll, "buttonRestoreAll");
            this.buttonRestoreAll.Name = "buttonRestoreAll";
            this.buttonRestoreAll.UseVisualStyleBackColor = true;
            this.buttonRestoreAll.Click += new System.EventHandler(this.buttonRestoreAll_Click);
            // 
            // buttonRemoveOneDrive
            // 
            resources.ApplyResources(this.buttonRemoveOneDrive, "buttonRemoveOneDrive");
            this.buttonRemoveOneDrive.Name = "buttonRemoveOneDrive";
            this.buttonRemoveOneDrive.UseVisualStyleBackColor = true;
            this.buttonRemoveOneDrive.Click += new System.EventHandler(this.buttonRemoveOneDrive_Click);
            // 
            // buttonRemoveChosen
            // 
            resources.ApplyResources(this.buttonRemoveChosen, "buttonRemoveChosen");
            this.buttonRemoveChosen.Name = "buttonRemoveChosen";
            this.buttonRemoveChosen.UseVisualStyleBackColor = true;
            this.buttonRemoveChosen.Click += new System.EventHandler(this.buttonRemoveChosen_Click);
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // buttonRemoveWindowsOld
            // 
            resources.ApplyResources(this.buttonRemoveWindowsOld, "buttonRemoveWindowsOld");
            this.buttonRemoveWindowsOld.Name = "buttonRemoveWindowsOld";
            this.buttonRemoveWindowsOld.UseVisualStyleBackColor = true;
            this.buttonRemoveWindowsOld.Click += new System.EventHandler(this.buttonRemoveWindowsOld_Click);
            // 
            // buttonEditStartMenu
            // 
            resources.ApplyResources(this.buttonEditStartMenu, "buttonEditStartMenu");
            this.buttonEditStartMenu.Name = "buttonEditStartMenu";
            this.buttonEditStartMenu.UseVisualStyleBackColor = true;
            this.buttonEditStartMenu.Click += new System.EventHandler(this.buttonEditStartMenu_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonEditStartMenu);
            this.Controls.Add(this.buttonRemoveWindowsOld);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.buttonRemoveChosen);
            this.Controls.Add(this.buttonRemoveOneDrive);
            this.Controls.Add(this.buttonRestoreAll);
            this.Controls.Add(this.buttonExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonRestoreAll;
        private System.Windows.Forms.Button buttonRemoveOneDrive;
        private System.Windows.Forms.Button buttonRemoveChosen;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button buttonRemoveWindowsOld;
        private System.Windows.Forms.Button buttonEditStartMenu;
    }
}

