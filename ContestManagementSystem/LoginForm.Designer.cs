namespace ContestManagementSystem
{
    partial class LoginForm
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
            this.buttonJudging = new System.Windows.Forms.Button();
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.linkLabelServer = new System.Windows.Forms.LinkLabel();
            this.buttonFirststage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonJudging
            // 
            this.buttonJudging.Location = new System.Drawing.Point(145, 114);
            this.buttonJudging.Name = "buttonJudging";
            this.buttonJudging.Size = new System.Drawing.Size(85, 29);
            this.buttonJudging.TabIndex = 5;
            this.buttonJudging.Text = "Judging";
            this.buttonJudging.UseVisualStyleBackColor = true;
            this.buttonJudging.Click += new System.EventHandler(this.buttonJudging_Click);
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistration.Location = new System.Drawing.Point(145, 74);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(85, 29);
            this.buttonRegistration.TabIndex = 8;
            this.buttonRegistration.Text = "Registration";
            this.buttonRegistration.UseVisualStyleBackColor = true;
            this.buttonRegistration.Click += new System.EventHandler(this.buttonRegistration_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Prelimenary Login Form";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(145, 154);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(85, 29);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // linkLabelServer
            // 
            this.linkLabelServer.AutoSize = true;
            this.linkLabelServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelServer.Location = new System.Drawing.Point(8, 227);
            this.linkLabelServer.Name = "linkLabelServer";
            this.linkLabelServer.Size = new System.Drawing.Size(74, 13);
            this.linkLabelServer.TabIndex = 11;
            this.linkLabelServer.TabStop = true;
            this.linkLabelServer.Text = "Server Setting";
            this.linkLabelServer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelServer_LinkClicked);
            // 
            // buttonFirststage
            // 
            this.buttonFirststage.Location = new System.Drawing.Point(145, 189);
            this.buttonFirststage.Name = "buttonFirststage";
            this.buttonFirststage.Size = new System.Drawing.Size(85, 24);
            this.buttonFirststage.TabIndex = 11;
            this.buttonFirststage.Text = "First Stage";
            this.buttonFirststage.UseVisualStyleBackColor = true;
            this.buttonFirststage.Click += new System.EventHandler(this.buttonFirststage_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.linkLabelServer);
            this.Controls.Add(this.buttonFirststage);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRegistration);
            this.Controls.Add(this.buttonJudging);
            this.Name = "LoginForm";
            this.Text = "Login Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonJudging;
        private System.Windows.Forms.Button buttonRegistration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.LinkLabel linkLabelServer;
        private System.Windows.Forms.Button buttonFirststage;
    }
}

