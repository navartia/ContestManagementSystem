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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.linkLabelServer = new System.Windows.Forms.LinkLabel();
            this.buttonMrSTI = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSingingIdol
            // 
            this.buttonSingingIdol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSingingIdol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSingingIdol.Location = new System.Drawing.Point(137, 25);
            this.buttonSingingIdol.Name = "buttonSingingIdol";
            this.buttonSingingIdol.Size = new System.Drawing.Size(120, 30);
            this.buttonSingingIdol.TabIndex = 5;
            this.buttonSingingIdol.Text = "STI Singing Idol";
            this.buttonSingingIdol.UseVisualStyleBackColor = true;
            this.buttonSingingIdol.Click += new System.EventHandler(this.buttonSingingIdol_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Contest Management System";
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(137, 97);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(120, 30);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // linkLabelServer
            // 
            this.linkLabelServer.AutoSize = true;
            this.linkLabelServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelServer.Location = new System.Drawing.Point(12, 28);
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
            this.buttonMrSTI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMrSTI.Location = new System.Drawing.Point(137, 61);
            this.buttonMrSTI.Name = "buttonMrSTI";
            this.buttonMrSTI.Size = new System.Drawing.Size(120, 30);
            this.buttonMrSTI.TabIndex = 11;
            this.buttonMrSTI.Text = "Mr. and Ms. STI";
            this.buttonMrSTI.UseVisualStyleBackColor = true;
            this.buttonMrSTI.Click += new System.EventHandler(this.buttonMrSTI_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 150);
            this.panel1.TabIndex = 12;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(110, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(180, 108);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 229;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonSingingIdol);
            this.panel2.Controls.Add(this.buttonExit);
            this.panel2.Controls.Add(this.buttonMrSTI);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 210);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.linkLabelServer);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 310);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 50);
            this.panel3.TabIndex = 14;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(400, 360);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSingingIdol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.LinkLabel linkLabelServer;
        private System.Windows.Forms.Button buttonMrSTI;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

