namespace ContestManagementSystem
{
    partial class MrMsSTISummary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MrMsSTISummary));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contestant_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonPrintReport = new System.Windows.Forms.Button();
            this.Course_comboBox = new System.Windows.Forms.ComboBox();
            this.Gender_comboBox = new System.Windows.Forms.ComboBox();
            this.Criteria_comboBox = new System.Windows.Forms.ComboBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contestant_Number,
            this.name,
            this.Score});
            this.dataGridView1.Location = new System.Drawing.Point(136, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(600, 85);
            this.dataGridView1.TabIndex = 15;
            // 
            // contestant_Number
            // 
            this.contestant_Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.contestant_Number.HeaderText = "Contestant Number";
            this.contestant_Number.Name = "contestant_Number";
            this.contestant_Number.ReadOnly = true;
            this.contestant_Number.Width = 123;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // Score
            // 
            this.Score.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Score.HeaderText = "Score";
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            this.Score.Width = 60;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(242, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 34);
            this.label1.TabIndex = 14;
            this.label1.Text = "STI GLOBAL CITY - MR AND MS. STI";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.buttonRefresh);
            this.panel1.Controls.Add(this.buttonPrintReport);
            this.panel1.Controls.Add(this.Course_comboBox);
            this.panel1.Controls.Add(this.Gender_comboBox);
            this.panel1.Controls.Add(this.Criteria_comboBox);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 494);
            this.panel1.TabIndex = 17;
            // 
            // buttonPrintReport
            // 
            this.buttonPrintReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrintReport.Location = new System.Drawing.Point(463, 342);
            this.buttonPrintReport.Name = "buttonPrintReport";
            this.buttonPrintReport.Size = new System.Drawing.Size(120, 30);
            this.buttonPrintReport.TabIndex = 19;
            this.buttonPrintReport.Text = "Print Report";
            this.buttonPrintReport.UseVisualStyleBackColor = true;
            this.buttonPrintReport.Click += new System.EventHandler(this.buttonPrintReport_Click);
            // 
            // Course_comboBox
            // 
            this.Course_comboBox.Font = new System.Drawing.Font("Cambria", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Course_comboBox.FormattingEnabled = true;
            this.Course_comboBox.Items.AddRange(new object[] {
            "Bachelor of Science in Computer Science",
            "Bachelor of Science in Computer Engineering",
            "Bachelor of Science in Information Technology"});
            this.Course_comboBox.Location = new System.Drawing.Point(330, 174);
            this.Course_comboBox.Name = "Course_comboBox";
            this.Course_comboBox.Size = new System.Drawing.Size(262, 24);
            this.Course_comboBox.TabIndex = 18;
            this.Course_comboBox.SelectedIndexChanged += new System.EventHandler(this.Course_comboBox_SelectedIndexChanged);
            // 
            // Gender_comboBox
            // 
            this.Gender_comboBox.BackColor = System.Drawing.Color.White;
            this.Gender_comboBox.Font = new System.Drawing.Font("Cambria", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender_comboBox.FormattingEnabled = true;
            this.Gender_comboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Gender_comboBox.Location = new System.Drawing.Point(738, 174);
            this.Gender_comboBox.Name = "Gender_comboBox";
            this.Gender_comboBox.Size = new System.Drawing.Size(121, 24);
            this.Gender_comboBox.TabIndex = 17;
            this.Gender_comboBox.SelectedIndexChanged += new System.EventHandler(this.Gender_comboBox_SelectedIndexChanged);
            // 
            // Criteria_comboBox
            // 
            this.Criteria_comboBox.BackColor = System.Drawing.Color.White;
            this.Criteria_comboBox.Font = new System.Drawing.Font("Cambria", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Criteria_comboBox.FormattingEnabled = true;
            this.Criteria_comboBox.Items.AddRange(new object[] {
            "Casual Wear",
            "Sports Wear",
            "Formal Wear",
            "Final Round"});
            this.Criteria_comboBox.Location = new System.Drawing.Point(52, 174);
            this.Criteria_comboBox.Name = "Criteria_comboBox";
            this.Criteria_comboBox.Size = new System.Drawing.Size(121, 24);
            this.Criteria_comboBox.TabIndex = 16;
            this.Criteria_comboBox.SelectedIndexChanged += new System.EventHandler(this.Criteria_comboBox_SelectedIndexChanged);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.Location = new System.Drawing.Point(330, 342);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(120, 30);
            this.buttonRefresh.TabIndex = 22;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // MrMsSTISummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 487);
            this.Controls.Add(this.panel1);
            this.Name = "MrMsSTISummary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Summary";
            this.Load += new System.EventHandler(this.MrMsSTISummary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox Course_comboBox;
        private System.Windows.Forms.ComboBox Gender_comboBox;
        private System.Windows.Forms.ComboBox Criteria_comboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn contestant_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.Button buttonPrintReport;
        private System.Windows.Forms.Button buttonRefresh;
    }
}