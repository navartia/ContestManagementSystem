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
            this.mrButton = new System.Windows.Forms.Button();
            this.msButton = new System.Windows.Forms.Button();
            this.criteriaGroupbox = new System.Windows.Forms.GroupBox();
            this.totalvalLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.percent2Textbox = new System.Windows.Forms.TextBox();
            this.percent1Textbox = new System.Windows.Forms.TextBox();
            this.percent2Label = new System.Windows.Forms.Label();
            this.percent1Label = new System.Windows.Forms.Label();
            this.criteriaLabel2 = new System.Windows.Forms.Label();
            this.criteriaLabel1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.criteriaGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.Location = new System.Drawing.Point(24, 432);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(117, 32);
            this.categoryLabel.TabIndex = 0;
            this.categoryLabel.Text = "Category";
            // 
            // mrButton
            // 
            this.mrButton.Enabled = false;
            this.mrButton.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.mrButton.Location = new System.Drawing.Point(272, 432);
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
            this.msButton.Location = new System.Drawing.Point(367, 432);
            this.msButton.Name = "msButton";
            this.msButton.Size = new System.Drawing.Size(74, 36);
            this.msButton.TabIndex = 3;
            this.msButton.Text = "MS.";
            this.msButton.UseVisualStyleBackColor = true;
            this.msButton.Click += new System.EventHandler(this.msButton_Click);
            // 
            // criteriaGroupbox
            // 
            this.criteriaGroupbox.Controls.Add(this.totalvalLabel);
            this.criteriaGroupbox.Controls.Add(this.totalLabel);
            this.criteriaGroupbox.Controls.Add(this.percent2Textbox);
            this.criteriaGroupbox.Controls.Add(this.percent1Textbox);
            this.criteriaGroupbox.Controls.Add(this.percent2Label);
            this.criteriaGroupbox.Controls.Add(this.percent1Label);
            this.criteriaGroupbox.Controls.Add(this.criteriaLabel2);
            this.criteriaGroupbox.Controls.Add(this.criteriaLabel1);
            this.criteriaGroupbox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criteriaGroupbox.Location = new System.Drawing.Point(543, 432);
            this.criteriaGroupbox.Name = "criteriaGroupbox";
            this.criteriaGroupbox.Size = new System.Drawing.Size(543, 252);
            this.criteriaGroupbox.TabIndex = 5;
            this.criteriaGroupbox.TabStop = false;
            this.criteriaGroupbox.Text = "Criteria";
            // 
            // totalvalLabel
            // 
            this.totalvalLabel.AutoSize = true;
            this.totalvalLabel.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalvalLabel.Location = new System.Drawing.Point(204, 214);
            this.totalvalLabel.Name = "totalvalLabel";
            this.totalvalLabel.Size = new System.Drawing.Size(32, 23);
            this.totalvalLabel.TabIndex = 24;
            this.totalvalLabel.Text = "00";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(125, 214);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(73, 23);
            this.totalLabel.TabIndex = 23;
            this.totalLabel.Text = "TOTAL:";
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
            // percent2Label
            // 
            this.percent2Label.AutoSize = true;
            this.percent2Label.Location = new System.Drawing.Point(125, 72);
            this.percent2Label.Name = "percent2Label";
            this.percent2Label.Size = new System.Drawing.Size(27, 19);
            this.percent2Label.TabIndex = 12;
            this.percent2Label.Text = "10";
            // 
            // percent1Label
            // 
            this.percent1Label.AutoSize = true;
            this.percent1Label.Location = new System.Drawing.Point(125, 37);
            this.percent1Label.Name = "percent1Label";
            this.percent1Label.Size = new System.Drawing.Size(27, 19);
            this.percent1Label.TabIndex = 11;
            this.percent1Label.Text = "10";
            // 
            // criteriaLabel2
            // 
            this.criteriaLabel2.AutoSize = true;
            this.criteriaLabel2.Location = new System.Drawing.Point(27, 72);
            this.criteriaLabel2.Name = "criteriaLabel2";
            this.criteriaLabel2.Size = new System.Drawing.Size(89, 19);
            this.criteriaLabel2.TabIndex = 8;
            this.criteriaLabel2.Text = "criteria1.2 -";
            // 
            // criteriaLabel1
            // 
            this.criteriaLabel1.AutoSize = true;
            this.criteriaLabel1.Location = new System.Drawing.Point(27, 37);
            this.criteriaLabel1.Name = "criteriaLabel1";
            this.criteriaLabel1.Size = new System.Drawing.Size(89, 19);
            this.criteriaLabel1.TabIndex = 7;
            this.criteriaLabel1.Text = "criteria1.1 -";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(961, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 29);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // JudgingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 772);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.criteriaGroupbox);
            this.Controls.Add(this.msButton);
            this.Controls.Add(this.mrButton);
            this.Controls.Add(this.categoryLabel);
            this.Name = "JudgingForm";
            this.Text = "Judging Form";
            this.Load += new System.EventHandler(this.JudgingForm_Load);
            this.criteriaGroupbox.ResumeLayout(false);
            this.criteriaGroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Button mrButton;
        private System.Windows.Forms.Button msButton;
        private System.Windows.Forms.GroupBox criteriaGroupbox;
        private System.Windows.Forms.TextBox percent1Textbox;
        private System.Windows.Forms.Label percent2Label;
        private System.Windows.Forms.Label percent1Label;
        private System.Windows.Forms.Label criteriaLabel2;
        private System.Windows.Forms.Label criteriaLabel1;
        private System.Windows.Forms.TextBox percent2Textbox;
        private System.Windows.Forms.Label totalvalLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button button1;

    }
}

