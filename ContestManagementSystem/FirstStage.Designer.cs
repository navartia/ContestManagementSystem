namespace ContestManagementSystem
{
    partial class FirstStage
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
            this.contestantsCheckedlistbox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.proceedButton = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalvalLabel = new System.Windows.Forms.Label();
            this.contestantsListbox = new System.Windows.Forms.ListBox();
            this.studentnumberListbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // contestantsCheckedlistbox
            // 
            this.contestantsCheckedlistbox.FormattingEnabled = true;
            this.contestantsCheckedlistbox.Items.AddRange(new object[] {
            "01 Tina Moran",
            "02 Rey Piñoco",
            "03 Gina Cole",
            "04 Eddie Huwaw"});
            this.contestantsCheckedlistbox.Location = new System.Drawing.Point(156, 71);
            this.contestantsCheckedlistbox.Name = "contestantsCheckedlistbox";
            this.contestantsCheckedlistbox.Size = new System.Drawing.Size(255, 349);
            this.contestantsCheckedlistbox.TabIndex = 0;
            this.contestantsCheckedlistbox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.contestantsCheckedlistbox_ItemCheck);
            this.contestantsCheckedlistbox.Click += new System.EventHandler(this.contestantsCheckedlistbox_Click);
            this.contestantsCheckedlistbox.SelectedIndexChanged += new System.EventHandler(this.contestantsCheckedlistbox_SelectedIndexChanged);
            this.contestantsCheckedlistbox.DoubleClick += new System.EventHandler(this.contestantsCheckedlistbox_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tsekan ang hindi mahapdi sa mata.";
            // 
            // proceedButton
            // 
            this.proceedButton.Location = new System.Drawing.Point(236, 437);
            this.proceedButton.Name = "proceedButton";
            this.proceedButton.Size = new System.Drawing.Size(75, 23);
            this.proceedButton.TabIndex = 2;
            this.proceedButton.Text = "Proceed";
            this.proceedButton.UseVisualStyleBackColor = true;
            this.proceedButton.Click += new System.EventHandler(this.proceedButton_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(343, 46);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(37, 13);
            this.totalLabel.TabIndex = 3;
            this.totalLabel.Text = "Total: ";
            // 
            // totalvalLabel
            // 
            this.totalvalLabel.AutoSize = true;
            this.totalvalLabel.Location = new System.Drawing.Point(376, 46);
            this.totalvalLabel.Name = "totalvalLabel";
            this.totalvalLabel.Size = new System.Drawing.Size(13, 13);
            this.totalvalLabel.TabIndex = 4;
            this.totalvalLabel.Text = "0";
            // 
            // contestantsListbox
            // 
            this.contestantsListbox.FormattingEnabled = true;
            this.contestantsListbox.Location = new System.Drawing.Point(156, 71);
            this.contestantsListbox.Name = "contestantsListbox";
            this.contestantsListbox.Size = new System.Drawing.Size(120, 95);
            this.contestantsListbox.TabIndex = 5;
            this.contestantsListbox.Visible = false;
            this.contestantsListbox.SelectedIndexChanged += new System.EventHandler(this.contestantsListbox_SelectedIndexChanged);
            // 
            // studentnumberListbox
            // 
            this.studentnumberListbox.FormattingEnabled = true;
            this.studentnumberListbox.Location = new System.Drawing.Point(156, 71);
            this.studentnumberListbox.Name = "studentnumberListbox";
            this.studentnumberListbox.Size = new System.Drawing.Size(120, 95);
            this.studentnumberListbox.TabIndex = 6;
            this.studentnumberListbox.Visible = false;
            // 
            // FirstStage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 514);
            this.Controls.Add(this.studentnumberListbox);
            this.Controls.Add(this.contestantsListbox);
            this.Controls.Add(this.totalvalLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.proceedButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contestantsCheckedlistbox);
            this.Name = "FirstStage";
            this.Text = "First Stage";
            this.Load += new System.EventHandler(this.FirstStage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox contestantsCheckedlistbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button proceedButton;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label totalvalLabel;
        private System.Windows.Forms.ListBox contestantsListbox;
        private System.Windows.Forms.ListBox studentnumberListbox;
    }
}