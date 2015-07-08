using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ContestManagementSystem
{
    public partial class FirstStage : Form
    {
        public FirstStage()
        {
            InitializeComponent();
        }

        private void FirstStage_Load(object sender, EventArgs e)
        {
            //get COMPLETE list of contestants from DB with their ID number
        }

        private void contestantsCheckedlistbox_SelectedIndexChanged(object sender, EventArgs e)
        {

                int totalContestants = 0;
                for (int ctr = 0; ctr < contestantsCheckedlistbox.Items.Count; ctr++)
                {
                    
                    if (contestantsCheckedlistbox.GetItemCheckState(ctr) == CheckState.Checked)
                    {
                        totalContestants += 1;
                    }
                }
                totalvalLabel.Text = Convert.ToString(totalContestants);
            
        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            //set columns of checked contestants
            string[] proceedingContestants = new string[Convert.ToInt32(totalvalLabel.Text)];

            for (int ctr = 0; ctr < contestantsCheckedlistbox.Items.Count; ctr++)
            {
                int ctr2 = 0;
                if (contestantsCheckedlistbox.GetItemCheckState(ctr) == CheckState.Checked)
                {
                proceedingContestants [ctr2] = Convert.ToString(contestantsCheckedlistbox.SelectedIndex);
                ctr2++;
                }

                MessageBox.Show(Convert.ToString(proceedingContestants[ctr]));
            }

        }

        private void contestantsCheckedlistbox_DoubleClick(object sender, EventArgs e)
        {
            int totalContestants = 0;
            for (int ctr = 0; ctr < contestantsCheckedlistbox.Items.Count; ctr++)
            {
                if (contestantsCheckedlistbox.GetItemCheckState(ctr) == CheckState.Checked)
                {
                    totalContestants += 1;
                }
            }
            totalvalLabel.Text = Convert.ToString(totalContestants);
        }

        private void contestantsCheckedlistbox_Click(object sender, EventArgs e)
        {
        
                int totalContestants = 0;
                for (int ctr = 0; ctr < contestantsCheckedlistbox.Items.Count; ctr++)
                {
                    if (contestantsCheckedlistbox.GetItemCheckState(ctr) == CheckState.Checked)
                    {
                        totalContestants += 1;
                    }
                }
                totalvalLabel.Text = Convert.ToString(totalContestants);
            
        }


    }
}
