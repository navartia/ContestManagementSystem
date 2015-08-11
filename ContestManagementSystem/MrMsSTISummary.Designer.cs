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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Course_comboBox = new System.Windows.Forms.ComboBox();
            this.Gender_comboBox = new System.Windows.Forms.ComboBox();
            this.Criteria_comboBox = new System.Windows.Forms.ComboBox();
            this.contestant_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contestant_Number,
            this.first_name,
            this.Last_Name,
            this.Score});
            this.dataGridView1.Location = new System.Drawing.Point(128, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(600, 250);
            this.dataGridView1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "STI GLOBAL CITY - MR AND MS. STI";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
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
            // Course_comboBox
            // 
            this.Course_comboBox.Font = new System.Drawing.Font("Cambria", 9F);
            this.Course_comboBox.FormattingEnabled = true;
            this.Course_comboBox.Items.AddRange(new object[] {
            "Bachelor of Science in Computer Science",
            "Bachelor of Science in Computer Engineering",
            "Bachelor of Science in Information Technology"});
            this.Course_comboBox.Location = new System.Drawing.Point(331, 129);
            this.Course_comboBox.Name = "Course_comboBox";
            this.Course_comboBox.Size = new System.Drawing.Size(245, 22);
            this.Course_comboBox.TabIndex = 18;
            this.Course_comboBox.Text = "Bachelor of Science in Computer Science";
            this.Course_comboBox.SelectedIndexChanged += new System.EventHandler(this.Course_comboBox_SelectedIndexChanged);
            // 
            // Gender_comboBox
            // 
            this.Gender_comboBox.Font = new System.Drawing.Font("Cambria", 9F);
            this.Gender_comboBox.FormattingEnabled = true;
            this.Gender_comboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Gender_comboBox.Location = new System.Drawing.Point(746, 129);
            this.Gender_comboBox.Name = "Gender_comboBox";
            this.Gender_comboBox.Size = new System.Drawing.Size(121, 22);
            this.Gender_comboBox.TabIndex = 17;
            this.Gender_comboBox.Text = "Male";
            this.Gender_comboBox.SelectedIndexChanged += new System.EventHandler(this.Gender_comboBox_SelectedIndexChanged);
            // 
            // Criteria_comboBox
            // 
            this.Criteria_comboBox.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Criteria_comboBox.FormattingEnabled = true;
            this.Criteria_comboBox.Items.AddRange(new object[] {
            "Casual Wear",
            "Sports Wear",
            "Formal Wear"});
            this.Criteria_comboBox.Location = new System.Drawing.Point(44, 129);
            this.Criteria_comboBox.Name = "Criteria_comboBox";
            this.Criteria_comboBox.Size = new System.Drawing.Size(121, 22);
            this.Criteria_comboBox.TabIndex = 16;
            this.Criteria_comboBox.Text = "Casual Wear";
            this.Criteria_comboBox.SelectedIndexChanged += new System.EventHandler(this.Criteria_comboBox_SelectedIndexChanged);
            // 
            // contestant_Number
            // 
            this.contestant_Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.contestant_Number.HeaderText = "Contestant Number";
            this.contestant_Number.Name = "contestant_Number";
            this.contestant_Number.ReadOnly = true;
            this.contestant_Number.Width = 123;
            // 
            // first_name
            // 
            this.first_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.first_name.HeaderText = "First Name";
            this.first_name.Name = "first_name";
            this.first_name.ReadOnly = true;
            // 
            // Last_Name
            // 
            this.Last_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Last_Name.HeaderText = "Last Name";
            this.Last_Name.Name = "Last_Name";
            this.Last_Name.ReadOnly = true;
            // 
            // Score
            // 
            this.Score.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Score.HeaderText = "Score";
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            this.Score.Width = 60;
            // 
            // MrMsSTISummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 487);
            this.Controls.Add(this.panel1);
            this.Name = "MrMsSTISummary";
            this.Text = "MrandMsSTISummary";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn first_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
    }
}