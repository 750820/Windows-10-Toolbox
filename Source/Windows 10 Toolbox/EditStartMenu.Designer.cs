namespace Windows_10_Toolbox
{
    partial class EditStartMenu
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
            this.buttonEditForAllUsers = new System.Windows.Forms.Button();
            this.buttonEditOnlyForMe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEditForAllUsers
            // 
            this.buttonEditForAllUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonEditForAllUsers.Location = new System.Drawing.Point(12, 12);
            this.buttonEditForAllUsers.Name = "buttonEditForAllUsers";
            this.buttonEditForAllUsers.Size = new System.Drawing.Size(383, 59);
            this.buttonEditForAllUsers.TabIndex = 0;
            this.buttonEditForAllUsers.Text = "Edit for all users";
            this.buttonEditForAllUsers.UseVisualStyleBackColor = true;
            // 
            // buttonEditOnlyForMe
            // 
            this.buttonEditOnlyForMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonEditOnlyForMe.Location = new System.Drawing.Point(12, 77);
            this.buttonEditOnlyForMe.Name = "buttonEditOnlyForMe";
            this.buttonEditOnlyForMe.Size = new System.Drawing.Size(383, 59);
            this.buttonEditOnlyForMe.TabIndex = 1;
            this.buttonEditOnlyForMe.Text = "Edit only for me";
            this.buttonEditOnlyForMe.UseVisualStyleBackColor = true;
            // 
            // EditStartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 274);
            this.Controls.Add(this.buttonEditOnlyForMe);
            this.Controls.Add(this.buttonEditForAllUsers);
            this.Name = "EditStartMenu";
            this.Text = "EditStartMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEditForAllUsers;
        private System.Windows.Forms.Button buttonEditOnlyForMe;
    }
}