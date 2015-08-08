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
    public partial class FormalWear : Form
    {
        DatabaseManager dm;
        public FormalWear()
        {
            InitializeComponent();
            dm = new DatabaseManager();
        }

        private void FormalWear_Load(object sender, EventArgs e)
        {
            String resultQuery = "SELECT contestant.firstname, contestant.lastname, AVG(judge_score.sum_of_score) AS total_score FROM (SELECT DISTINCT contestant_id, judge_id, SUM(score) AS sum_of_score FROM Score GROUP BY contestant_id, judge_id)  AS judge_score INNER JOIN contestant ON judge_score.contestant_id = contestant.contestant_id WHERE contestant.contest_id =  1 AND contestant.gender = Female AND contesant.course = Bachelor of Science in Information Technology GROUP BY contestant.firstname, contestant.lastname";
            String resultQuery1 = "SELECT contestant.firstname, contestant.lastname, contestant.course, contestant.gender AVG(judge_score.sum_of_score) AS total_score FROM (SELECT DISTINCT contestant_id, judge_id, SUM(score) AS sum_of_score FROM Score GROUP BY contestant_id, judge_id)  AS judge_score INNER JOIN contestant ON judge_score.contestant_id = contestant.contestant_id WHERE contestant.contest_id =  1 GROUP BY contestant.firstname, contestant.lastname, contestant.course, contestant.gender";
            DataTable contestTable = dm.Select(resultQuery);
            dataGridView1.DataSource = contestTable;
            dataGridView2.DataSource = contestTable;
            dataGridView3.DataSource = contestTable;
            dataGridView4.DataSource = contestTable;
            dataGridView5.DataSource = contestTable;
            dataGridView6.DataSource = contestTable;

       //     dataGridView1.Rows[].Cells[].Value.ToString();
        }

        private void filter(DataGridView dataGridview)
        {
            dataGridview.Rows[1].Cells[2].Value.ToString();
        }
    }
}
