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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContestControl));
            this.buttonMasterList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSingingIdol = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonMrSTI = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonMasterList
            // 
            this.buttonMasterList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonMasterList.Font = new System.Drawing.Font("Cambria", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMasterList.Location = new System.Drawing.Point(86, 221);
            this.buttonMasterList.Name = "buttonMasterList";
            this.buttonMasterList.Size = new System.Drawing.Size(120, 30);
            this.buttonMasterList.TabIndex = 5;
            this.buttonMasterList.Text = "Master List";
            this.buttonMasterList.UseVisualStyleBackColor = true;
            this.buttonMasterList.Click += new System.EventHandler(this.buttonMasterList_Click_1);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label1.Location = new System.Drawing.Point(67, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Contest Control";
            // 
            // buttonSingingIdol
            // 
            this.buttonSingingIdol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSingingIdol.Font = new System.Drawing.Font("Cambria", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSingingIdol.Location = new System.Drawing.Point(86, 257);
            this.buttonSingingIdol.Name = "buttonSingingIdol";
            this.buttonSingingIdol.Size = new System.Drawing.Size(120, 30);
            this.buttonSingingIdol.TabIndex = 10;
            this.buttonSingingIdol.Text = "Singing Idol";
            this.buttonSingingIdol.UseVisualStyleBackColor = true;
            this.buttonSingingIdol.Click += new System.EventHandler(this.buttonSingingIdol_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 150);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.buttonMrSTI);
            this.panel2.Controls.Add(this.buttonBack);
            this.panel2.Controls.Add(this.buttonRegistration);
            this.panel2.Controls.Add(this.buttonMasterList);
            this.panel2.Controls.Add(this.buttonSingingIdol);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 381);
            this.panel2.TabIndex = 16;
            // 
            // buttonMrSTI
            // 
            this.buttonMrSTI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonMrSTI.Font = new System.Drawing.Font("Cambria", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMrSTI.Location = new System.Drawing.Point(86, 293);
            this.buttonMrSTI.Name = "buttonMrSTI";
            this.buttonMrSTI.Size = new System.Drawing.Size(120, 30);
            this.buttonMrSTI.TabIndex = 14;
            this.buttonMrSTI.Text = "Mr and Ms STI";
            this.buttonMrSTI.UseVisualStyleBackColor = true;
            this.buttonMrSTI.Click += new System.EventHandler(this.buttonMrSTI_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBack.Font = new System.Drawing.Font("Cambria", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(86, 329);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(120, 30);
            this.buttonBack.TabIndex = 13;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRegistration.Font = new System.Drawing.Font("Cambria", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistration.Location = new System.Drawing.Point(86, 185);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(120, 30);
            this.buttonRegistration.TabIndex = 12;
            this.buttonRegistration.Text = "Registration";
            this.buttonRegistration.UseVisualStyleBackColor = true;
            this.buttonRegistration.Click += new System.EventHandler(this.buttonRegistration_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 381);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 19);
            this.panel3.TabIndex = 17;
            // 
            // ContestControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(300, 400);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ContestControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContestControl";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMasterList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSingingIdol;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonRegistration;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonMrSTI;

    }
}