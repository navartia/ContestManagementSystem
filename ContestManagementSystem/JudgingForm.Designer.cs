namespace ContestManagementSystem
{
    partial class JudgingForm
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
            this.categoryLabel = new System.Windows.Forms.Label();
            this.categoryListbox = new System.Windows.Forms.ListBox();
            this.mrButton = new System.Windows.Forms.Button();
            this.msButton = new System.Windows.Forms.Button();
            this.mrcontestantsListbox = new System.Windows.Forms.ListBox();
            this.criteriaGroupbox = new System.Windows.Forms.GroupBox();
            this.totalvalLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.percent4Textbox = new System.Windows.Forms.TextBox();
            this.percent3Textbox = new System.Windows.Forms.TextBox();
            this.percent2Textbox = new System.Windows.Forms.TextBox();
            this.percent1Textbox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.percent4Label = new System.Windows.Forms.Label();
            this.percent3Label = new System.Windows.Forms.Label();
            this.percent2Label = new System.Windows.Forms.Label();
            this.percent1Label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mscontestantsListbox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.criteriaGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.Location = new System.Drawing.Point(70, 430);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(117, 32);
            this.categoryLabel.TabIndex = 0;
            this.categoryLabel.Text = "Category";
            // 
            // categoryListbox
            // 
            this.categoryListbox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryListbox.FormattingEnabled = true;
            this.categoryListbox.ItemHeight = 19;
            this.categoryListbox.Items.AddRange(new object[] {
            "Category1",
            "Category2",
            "Category3"});
            this.categoryListbox.Location = new System.Drawing.Point(76, 486);
            this.categoryListbox.Name = "categoryListbox";
            this.categoryListbox.Size = new System.Drawing.Size(197, 232);
            this.categoryListbox.TabIndex = 1;
            // 
            // mrButton
            // 
            this.mrButton.Enabled = false;
            this.mrButton.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.mrButton.Location = new System.Drawing.Point(318, 430);
            this.mrButton.Name = "mrButton";
            this.mrButton.Size = new System.Drawing.Size(74, 36);
            this.mrButton.TabIndex = 2;
            this.mrButton.Text = "MR.";
            this.mrButton.UseVisualStyleBackColor = true;
            this.mrButton.Click += new System.EventHandler(this.mrButton_Click);
            // 
            // msButton
            // 
            this.msButton.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msButton.ForeColor = System.Drawing.Color.Red;
            this.msButton.Location = new System.Drawing.Point(413, 430);
            this.msButton.Name = "msButton";
            this.msButton.Size = new System.Drawing.Size(74, 36);
            this.msButton.TabIndex = 3;
            this.msButton.Text = "MS.";
            this.msButton.UseVisualStyleBackColor = true;
            this.msButton.Click += new System.EventHandler(this.msButton_Click);
            // 
            // mrcontestantsListbox
            // 
            this.mrcontestantsListbox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcontestantsListbox.FormattingEnabled = true;
            this.mrcontestantsListbox.ItemHeight = 19;
            this.mrcontestantsListbox.Items.AddRange(new object[] {
            "Carlo Bernal",
            "Louie Sadiz",
            "Ken Concepcion"});
            this.mrcontestantsListbox.Location = new System.Drawing.Point(305, 486);
            this.mrcontestantsListbox.Name = "mrcontestantsListbox";
            this.mrcontestantsListbox.Size = new System.Drawing.Size(197, 232);
            this.mrcontestantsListbox.TabIndex = 4;
            // 
            // criteriaGroupbox
            // 
            this.criteriaGroupbox.Controls.Add(this.totalvalLabel);
            this.criteriaGroupbox.Controls.Add(this.totalLabel);
            this.criteriaGroupbox.Controls.Add(this.percent4Textbox);
            this.criteriaGroupbox.Controls.Add(this.percent3Textbox);
            this.criteriaGroupbox.Controls.Add(this.percent2Textbox);
            this.criteriaGroupbox.Controls.Add(this.percent1Textbox);
            this.criteriaGroupbox.Controls.Add(this.label12);
            this.criteriaGroupbox.Controls.Add(this.label11);
            this.criteriaGroupbox.Controls.Add(this.label10);
            this.criteriaGroupbox.Controls.Add(this.label9);
            this.criteriaGroupbox.Controls.Add(this.percent4Label);
            this.criteriaGroupbox.Controls.Add(this.percent3Label);
            this.criteriaGroupbox.Controls.Add(this.percent2Label);
            this.criteriaGroupbox.Controls.Add(this.percent1Label);
            this.criteriaGroupbox.Controls.Add(this.label4);
            this.criteriaGroupbox.Controls.Add(this.label3);
            this.criteriaGroupbox.Controls.Add(this.label2);
            this.criteriaGroupbox.Controls.Add(this.label1);
            this.criteriaGroupbox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criteriaGroupbox.Location = new System.Drawing.Point(541, 466);
            this.criteriaGroupbox.Name = "criteriaGroupbox";
            this.criteriaGroupbox.Size = new System.Drawing.Size(503, 252);
            this.criteriaGroupbox.TabIndex = 5;
            this.criteriaGroupbox.TabStop = false;
            this.criteriaGroupbox.Text = "Criteria";
            // 
            // totalvalLabel
            // 
            this.totalvalLabel.AutoSize = true;
            this.totalvalLabel.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalvalLabel.Location = new System.Drawing.Point(216, 190);
            this.totalvalLabel.Name = "totalvalLabel";
            this.totalvalLabel.Size = new System.Drawing.Size(32, 23);
            this.totalvalLabel.TabIndex = 24;
            this.totalvalLabel.Text = "00";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(125, 190);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(73, 23);
            this.totalLabel.TabIndex = 23;
            this.totalLabel.Text = "TOTAL:";
            // 
            // percent4Textbox
            // 
            this.percent4Textbox.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percent4Textbox.Location = new System.Drawing.Point(205, 137);
            this.percent4Textbox.Name = "percent4Textbox";
            this.percent4Textbox.Size = new System.Drawing.Size(64, 31);
            this.percent4Textbox.TabIndex = 22;
            this.percent4Textbox.Text = "0";
            this.percent4Textbox.TextChanged += new System.EventHandler(this.percent4Textbox_TextChanged);
            this.percent4Textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.percent4Textbox_KeyPress);
            // 
            // percent3Textbox
            // 
            this.percent3Textbox.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percent3Textbox.Location = new System.Drawing.Point(205, 100);
            this.percent3Textbox.Name = "percent3Textbox";
            this.percent3Textbox.Size = new System.Drawing.Size(64, 31);
            this.percent3Textbox.TabIndex = 21;
            this.percent3Textbox.Text = "0";
            this.percent3Textbox.TextChanged += new System.EventHandler(this.percent3Textbox_TextChanged);
            this.percent3Textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.percent3Textbox_KeyPress);
            // 
            // percent2Textbox
            // 
            this.percent2Textbox.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percent2Textbox.Location = new System.Drawing.Point(205, 65);
            this.percent2Textbox.Name = "percent2Textbox";
            this.percent2Textbox.Size = new System.Drawing.Size(64, 31);
            this.percent2Textbox.TabIndex = 20;
            this.percent2Textbox.Text = "0";
            this.percent2Textbox.TextChanged += new System.EventHandler(this.percent2Textbox_TextChanged);
            this.percent2Textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.percent2Textbox_KeyPress);
            // 
            // percent1Textbox
            // 
            this.percent1Textbox.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percent1Textbox.Location = new System.Drawing.Point(205, 30);
            this.percent1Textbox.Name = "percent1Textbox";
            this.percent1Textbox.Size = new System.Drawing.Size(64, 31);
            this.percent1Textbox.TabIndex = 19;
            this.percent1Textbox.Text = "0";
            this.percent1Textbox.TextChanged += new System.EventHandler(this.percent1Textbox_TextChanged);
            this.percent1Textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.percent1Textbox_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(149, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 19);
            this.label12.TabIndex = 18;
            this.label12.Text = "%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(149, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 19);
            this.label11.TabIndex = 17;
            this.label11.Text = "%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(149, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 19);
            this.label10.TabIndex = 16;
            this.label10.Text = "%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(149, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 19);
            this.label9.TabIndex = 15;
            this.label9.Text = "%";
            // 
            // percent4Label
            // 
            this.percent4Label.AutoSize = true;
            this.percent4Label.Location = new System.Drawing.Point(125, 143);
            this.percent4Label.Name = "percent4Label";
            this.percent4Label.Size = new System.Drawing.Size(27, 19);
            this.percent4Label.TabIndex = 14;
            this.percent4Label.Text = "25";
            // 
            // percent3Label
            // 
            this.percent3Label.AutoSize = true;
            this.percent3Label.Location = new System.Drawing.Point(125, 107);
            this.percent3Label.Name = "percent3Label";
            this.percent3Label.Size = new System.Drawing.Size(27, 19);
            this.percent3Label.TabIndex = 13;
            this.percent3Label.Text = "25";
            // 
            // percent2Label
            // 
            this.percent2Label.AutoSize = true;
            this.percent2Label.Location = new System.Drawing.Point(125, 72);
            this.percent2Label.Name = "percent2Label";
            this.percent2Label.Size = new System.Drawing.Size(27, 19);
            this.percent2Label.TabIndex = 12;
            this.percent2Label.Text = "30";
            // 
            // percent1Label
            // 
            this.percent1Label.AutoSize = true;
            this.percent1Label.Location = new System.Drawing.Point(125, 37);
            this.percent1Label.Name = "percent1Label";
            this.percent1Label.Size = new System.Drawing.Size(27, 19);
            this.percent1Label.TabIndex = 11;
            this.percent1Label.Text = "20";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "criteria1.4 -";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "criteria1.3 -";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "criteria1.2 -";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "criteria1.1 -";
            // 
            // mscontestantsListbox
            // 
            this.mscontestantsListbox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mscontestantsListbox.FormattingEnabled = true;
            this.mscontestantsListbox.ItemHeight = 19;
            this.mscontestantsListbox.Items.AddRange(new object[] {
            "Hanz Pena",
            "Kimberlyn Driz",
            "Ivy Salamanca"});
            this.mscontestantsListbox.Location = new System.Drawing.Point(305, 486);
            this.mscontestantsListbox.Name = "mscontestantsListbox";
            this.mscontestantsListbox.Size = new System.Drawing.Size(197, 232);
            this.mscontestantsListbox.TabIndex = 6;
            this.mscontestantsListbox.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1007, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 29);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Items.AddRange(new object[] {
            "Hanz Pena",
            "Kimberlyn Driz",
            "Ivy Salamanca"});
            this.listBox1.Location = new System.Drawing.Point(305, 486);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(197, 232);
            this.listBox1.TabIndex = 8;
            this.listBox1.Visible = false;
            // 
            // JudgingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 772);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mscontestantsListbox);
            this.Controls.Add(this.criteriaGroupbox);
            this.Controls.Add(this.mrcontestantsListbox);
            this.Controls.Add(this.msButton);
            this.Controls.Add(this.mrButton);
            this.Controls.Add(this.categoryListbox);
            this.Controls.Add(this.categoryLabel);
            this.Name = "JudgingForm";
            this.Text = "Judging Form";
            this.criteriaGroupbox.ResumeLayout(false);
            this.criteriaGroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.ListBox categoryListbox;
        private System.Windows.Forms.Button mrButton;
        private System.Windows.Forms.Button msButton;
        private System.Windows.Forms.ListBox mrcontestantsListbox;
        private System.Windows.Forms.GroupBox criteriaGroupbox;
        private System.Windows.Forms.ListBox mscontestantsListbox;
        private System.Windows.Forms.TextBox percent1Textbox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label percent4Label;
        private System.Windows.Forms.Label percent3Label;
        private System.Windows.Forms.Label percent2Label;
        private System.Windows.Forms.Label percent1Label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox percent4Textbox;
        private System.Windows.Forms.TextBox percent3Textbox;
        private System.Windows.Forms.TextBox percent2Textbox;
        private System.Windows.Forms.Label totalvalLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;

    }
}

