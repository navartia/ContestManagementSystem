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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.buttonSingingIdol = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.linkLabelServer = new System.Windows.Forms.LinkLabel();
            this.buttonMrSTI = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonContestControl = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSingingIdol
            // 
            this.buttonSingingIdol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSingingIdol.Font = new System.Drawing.Font("Cambria", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSingingIdol.Location = new System.Drawing.Point(86, 53);
            this.buttonSingingIdol.Name = "buttonSingingIdol";
            this.buttonSingingIdol.Size = new System.Drawing.Size(134, 30);
            this.buttonSingingIdol.TabIndex = 5;
            this.buttonSingingIdol.Text = "STI Singing Idol";
            this.buttonSingingIdol.UseVisualStyleBackColor = true;
            this.buttonSingingIdol.Click += new System.EventHandler(this.buttonSingingIdol_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonExit.Font = new System.Drawing.Font("Cambria", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(86, 125);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(134, 30);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // linkLabelServer
            // 
            this.linkLabelServer.AutoSize = true;
            this.linkLabelServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelServer.LinkColor = System.Drawing.Color.White;
            this.linkLabelServer.Location = new System.Drawing.Point(9, 25);
            this.linkLabelServer.Name = "linkLabelServer";
            this.linkLabelServer.Size = new System.Drawing.Size(79, 13);
            this.linkLabelServer.TabIndex = 11;
            this.linkLabelServer.TabStop = true;
            this.linkLabelServer.Text = "Server Settings";
            this.linkLabelServer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelServer_LinkClicked);
            // 
            // buttonMrSTI
            // 
            this.buttonMrSTI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonMrSTI.Font = new System.Drawing.Font("Cambria", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMrSTI.Location = new System.Drawing.Point(86, 89);
            this.buttonMrSTI.Name = "buttonMrSTI";
            this.buttonMrSTI.Size = new System.Drawing.Size(134, 30);
            this.buttonMrSTI.TabIndex = 11;
            this.buttonMrSTI.Text = "Mr. and Ms. ICT";
            this.buttonMrSTI.UseVisualStyleBackColor = true;
            this.buttonMrSTI.Click += new System.EventHandler(this.buttonMrSTI_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.buttonContestControl);
            this.panel2.Controls.Add(this.buttonSingingIdol);
            this.panel2.Controls.Add(this.buttonExit);
            this.panel2.Controls.Add(this.buttonMrSTI);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 180);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 220);
            this.panel2.TabIndex = 13;
            // 
            // buttonContestControl
            // 
            this.buttonContestControl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonContestControl.Font = new System.Drawing.Font("Cambria", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContestControl.Location = new System.Drawing.Point(86, 17);
            this.buttonContestControl.Name = "buttonContestControl";
            this.buttonContestControl.Size = new System.Drawing.Size(134, 30);
            this.buttonContestControl.TabIndex = 12;
            this.buttonContestControl.Text = "Contest Control";
            this.buttonContestControl.UseVisualStyleBackColor = true;
            this.buttonContestControl.Click += new System.EventHandler(this.buttonContestControl_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.linkLabelServer);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 350);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 50);
            this.panel3.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label1.Location = new System.Drawing.Point(21, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Contest Management System";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 180);
            this.panel1.TabIndex = 12;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(300, 400);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSingingIdol;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.LinkLabel linkLabelServer;
        private System.Windows.Forms.Button buttonMrSTI;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonContestControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}

