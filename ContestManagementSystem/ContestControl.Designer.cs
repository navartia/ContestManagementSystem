namespace ContestManagementSystem
{
    partial class ContestControl
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
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.buttonMasterList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.Location = new System.Drawing.Point(45, 35);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(75, 23);
            this.buttonRegistration.TabIndex = 0;
            this.buttonRegistration.Text = "Registration";
            this.buttonRegistration.UseVisualStyleBackColor = true;
            this.buttonRegistration.Click += new System.EventHandler(this.buttonRegistration_Click);
            // 
            // buttonMasterList
            // 
            this.buttonMasterList.Location = new System.Drawing.Point(45, 64);
            this.buttonMasterList.Name = "buttonMasterList";
            this.buttonMasterList.Size = new System.Drawing.Size(75, 23);
            this.buttonMasterList.TabIndex = 1;
            this.buttonMasterList.Text = "Master List";
            this.buttonMasterList.UseVisualStyleBackColor = true;
            this.buttonMasterList.Click += new System.EventHandler(this.buttonMasterList_Click);
            // 
            // ContestControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonMasterList);
            this.Controls.Add(this.buttonRegistration);
            this.Name = "ContestControl";
            this.Text = "ContestControl";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRegistration;
        private System.Windows.Forms.Button buttonMasterList;
    }
}