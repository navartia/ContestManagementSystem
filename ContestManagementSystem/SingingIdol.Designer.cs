namespace ContestManagementSystem
{
    partial class SingingIdol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SingingIdol));
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(197, 39);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(539, 32);
            this.label6.TabIndex = 14;
            this.label6.Text = "STI GLOBAL CITY - SINGING IDOL CONTEST";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 103);
            this.panel1.TabIndex = 15;
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(96, 207);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(189, 26);
            this.labelName.TabIndex = 16;
            this.labelName.Text = "Contestant Name:";
            // 
            // labelNumber
            // 
            this.labelNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNumber.AutoSize = true;
            this.labelNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelNumber.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelNumber.Location = new System.Drawing.Point(96, 243);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(160, 26);
            this.labelNumber.TabIndex = 17;
            this.labelNumber.Text = "Contestant No:";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxGender.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Location = new System.Drawing.Point(423, 178);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(377, 26);
            this.comboBoxGender.TabIndex = 18;
            this.comboBoxGender.SelectedIndexChanged += new System.EventHandler(this.comboBoxContestant_SelectedIndexChanged);
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.Location = new System.Drawing.Point(806, 300);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(50, 33);
            this.buttonNext.TabIndex = 27;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrev.Location = new System.Drawing.Point(45, 300);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(50, 33);
            this.buttonPrev.TabIndex = 28;
            this.buttonPrev.Text = "<";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(101, 300);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(699, 205);
            this.dataGridView1.TabIndex = 29;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.Location = new System.Drawing.Point(710, 242);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(90, 31);
            this.buttonRefresh.TabIndex = 30;
            this.buttonRefresh.Text = "Refresh\r\n";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(96, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 26);
            this.label1.TabIndex = 31;
            this.label1.Text = "Contestant Gender:";
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxCourse.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(423, 146);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(378, 26);
            this.comboBoxCourse.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(96, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 26);
            this.label2.TabIndex = 33;
            this.label2.Text = "Contestant Course:";
            // 
            // comboBoxName
            // 
            this.comboBoxName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxName.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(423, 210);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(377, 26);
            this.comboBoxName.TabIndex = 34;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Image = ((System.Drawing.Image)(resources.GetObject("buttonSubmit.Image")));
            this.buttonSubmit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSubmit.Location = new System.Drawing.Point(625, 514);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(85, 72);
            this.buttonSubmit.TabIndex = 36;
            this.buttonSubmit.Text = "UPDATE";
            this.buttonSubmit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSubmit.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Image = ((System.Drawing.Image)(resources.GetObject("buttonClear.Image")));
            this.buttonClear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonClear.Location = new System.Drawing.Point(720, 514);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonClear.Size = new System.Drawing.Size(81, 72);
            this.buttonClear.TabIndex = 35;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // SingingIdol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(888, 595);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.comboBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxCourse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "SingingIdol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STI Global City - Singing Idol Contest";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SingingIdol_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCourse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonClear;

    }
}