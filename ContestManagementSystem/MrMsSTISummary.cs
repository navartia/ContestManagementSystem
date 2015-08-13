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
        DataTable[,,] summaryData = new DataTable[4, 3, 2];

        public MrMsSTISummary()
        {
            InitializeComponent();
            dm = new DatabaseManager();
        }

        private void MrMsSTISummary_Load(object sender, EventArgs e)
        {
            LoadToDataTable();
        }

        private void LoadToDataTable()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        String query = "SELECT contestant.contestant_number, contestant.firstname & \" \" & contestant.lastname AS name, summary.average FROM (SELECT DISTINCT contestant_id, criteria_id, ROUND(AVG(score), 2) AS average FROM score GROUP BY contestant_id, criteria_id)  AS summary INNER JOIN contestant ON summary.contestant_id = contestant.contestant_id WHERE summary.criteria_id = " + (i + 5) + " AND contestant.course_id  = " + (j + 1) + " AND contestant.gender_id = " + (k + 1) + " GROUP BY contestant.contestant_number, contestant.firstname, contestant.lastname, average ORDER BY average DESC";
                        summaryData[i, j, k] = dm.Select(query);
                    }
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    String query = "SELECT contestant.contestant_number, contestant.firstname & \" \" & contestant.lastname AS name, finalScore.average FROM (SELECT summary1.contestant_id, summary1.score1 + summary2.score2 AS average FROM (SELECT contestant_id, SUM(score) / 9 AS score1 FROM score WHERE criteria_id BETWEEN 5 AND 7 GROUP BY contestant_id)  AS summary1 INNER JOIN (SELECT contestant_id, SUM(score) / 6 AS score2 FROM score WHERE criteria_id BETWEEN 8 AND 9 GROUP BY contestant_id)  AS summary2 ON summary1.contestant_id = summary2.contestant_id)  AS finalScore INNER JOIN contestant ON finalScore.contestant_id = contestant.contestant_id WHERE contestant.course_id = " + (i + 1) + " AND contestant.gender_id = " + (j + 1) + " ORDER BY average DESC";
                    summaryData[3, i, j] = dm.Select(query);
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
            dataGridView1.Columns[1].DataPropertyName = "name";
            dataGridView1.Columns[2].DataPropertyName = "average";
        }

        private void Course_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Criteria_comboBox.SelectedIndex != -1 && Gender_comboBox.SelectedIndex != -1)
                LoadToDataGridView();
        }

        private void Criteria_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Gender_comboBox.SelectedIndex != -1 && Course_comboBox.SelectedIndex != -1)
                LoadToDataGridView();
        }

        private void Gender_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Criteria_comboBox.SelectedIndex != -1 && Course_comboBox.SelectedIndex != -1)
                LoadToDataGridView();
        }

        private DataTable[] GetSummaryResult()
        {
            DataTable[] result = new DataTable[4];
            for (int i = 0; i < 4; i++)
            {
                result[i] = new DataTable();
                result[i].Columns.Add("contestant_number");
                result[i].Columns.Add("name");
                result[i].Columns.Add("average");
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        result[i].Rows.Add(summaryData[i, j, k].Rows[0].ItemArray);
                    }
                }
            }
            
            return result;
        }

        private void buttonSummary_Click(object sender, EventArgs e)
        {
            this.Hide();

            MrMsSTISummary2 ms = new MrMsSTISummary2(GetSummaryResult());
            ms.ShowDialog();

            this.Show();
        }
    }
}
