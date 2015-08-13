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
    public partial class SingingIdolSummary : Form
    {
        DatabaseManager dm;
        DataTable[] course = new DataTable[3];

        public SingingIdolSummary()
        {
            InitializeComponent();
             dm = new DatabaseManager();

        }

        private void SingingIdolSummary_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                String resultQuery = "SELECT contestant.contestant_number, contestant.firstname & \" \" & contestant.lastname AS name, judge_score.sum_of_score / 3 AS total_score FROM (SELECT contestant_id, SUM(score) AS sum_of_score FROM Score GROUP BY contestant_id)  AS judge_score INNER JOIN contestant ON judge_score.contestant_id = contestant.contestant_id WHERE contestant.contest_id = 1 AND contestant.course_id = " + (i + 1);
                course[i] = dm.Select(resultQuery);
            }
        }

        private void comboBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = course[comboBoxCourse.SelectedIndex];
            dataGridView1.Columns[0].DataPropertyName = "contestant_number";
            dataGridView1.Columns[1].DataPropertyName = "name";
            dataGridView1.Columns[2].DataPropertyName = "total_score";
        }

        private void buttonSummary_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
