using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContestManagementSystem
{
    public partial class MrMsSTISummary : Form
    {
        DatabaseManager dm;
        DataTable[,,] summaryData = new DataTable[3, 3, 2];

        public MrMsSTISummary()
        {
            InitializeComponent();
            dm = new DatabaseManager();
        }

        private void MrMsSTISummary_Load(object sender, EventArgs e)
        {/*
            try
            {
                //Incomplete Database To be Completed Once Mr And Ms STI Database has been given
                //where clause Missing due to database(Incomplete);
                string contestantQuery = "select firstName,middleName,lastname,id_number,contestant_number,course from contestant";
                DataTable contestTable = dm.Select(contestantQuery);
                dm.Insert(contestantQuery);

                dm.Select(contestantQuery);
                dataGridView1.DataSource = contestTable;
            }
            catch (Exception er)
            {
                MessageBox.Show("Please choose database. or " + er.Message);
            } */
            LoadToDataTable();
            LoadToDataGridView();
        }

        private void LoadToDataTable()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        String query = "SELECT contestant.contestant_number, contestant.firstname, contestant.lastname, AVG(score.score) AS score FROM contestant INNER JOIN score ON contestant.contestant_id = score.contestant_id WHERE score.criteria_id = " + (i + 5) + " AND contestant.course_id = " + (j + 1) + " AND contestant.gender_id = " + (k + 1) + " GROUP BY contestant.contestant_number, contestant.firstname, contestant.lastname, score";
                        String query1 = "SELECT contestant.contestant_number, contestant.firstname, contestant.lastname, summary.average FROM (SELECT DISTINCT contestant_id, criteria_id    , ROUND(AVG(score), 2) AS average FROM score GROUP BY contestant_id, criteria_id)  AS summary INNER JOIN contestant ON summary.contestant_id = contestant.contestant_id WHERE summary.criteria_id = " + (i + 5) + " AND contestant.course_id  = " + (j + 1) + " AND contestant.gender_id = " + (k + 1) + " GROUP BY contestant.contestant_number, contestant.firstname, contestant.lastname, average";
                        summaryData[i, j, k] = dm.Select(query1);
                    }
                }
            }
        }

        private void LoadToDataGridView()
        {
            int criteria = Criteria_comboBox.SelectedIndex;
            int course = Course_comboBox.SelectedIndex;
            int gender = Gender_comboBox.SelectedIndex;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = summaryData[criteria, course, gender];
            dataGridView1.Columns[0].DataPropertyName = "contestant_number";
            dataGridView1.Columns[1].DataPropertyName = "firstname";
            dataGridView1.Columns[2].DataPropertyName = "lastname";
            dataGridView1.Columns[3].DataPropertyName = "average";
        }

        private void Course_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadToDataGridView();
        }

        private void Criteria_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadToDataGridView();
        }

        private void Gender_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadToDataGridView();
        }
    }
}
