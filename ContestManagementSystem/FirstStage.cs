using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

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
            OleDbConnection connection = new OleDbConnection();
            OleDbCommand command = new OleDbCommand();

            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = \\HANZ21\Joel Arbole\contest_db.accdb";

            connection.Open();

            command.Connection = connection;
            string query = "select ID from Table1";
            command.CommandText = query;
            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string fname = reader[""].ToString();
                string lname = reader[""].ToString();
                contestantsListbox.Items.Add(fname + " " + lname);
            }

            connection.Close();
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

        private void contestantsCheckedlistbox_ItemCheck(object sender, ItemCheckEventArgs e)
        {

        }

        private void contestantsListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
