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
        public MrMsSTISummary()
        {
            InitializeComponent();
            dm = new DatabaseManager();
        }

        private void MrMsSTISummary_Load(object sender, EventArgs e)
        {
            //string contestantQuery = "select firstName,middleName,lastname,id_number,contestant_number,course from contestant";
            String resultQuery = "SELECT contestant.firstname, contestant.lastname, AVG(judge_score.sum_of_score) AS total_score FROM (SELECT DISTINCT contestant_id, judge_id, SUM(score) AS sum_of_score FROM Score GROUP BY contestant_id, judge_id)  AS judge_score INNER JOIN contestant ON judge_score.contestant_id = contestant.contestant_id WHERE contestant.contest_id =  2 GROUP BY contestant.firstname, contestant.lastname";
            DataTable contestTable = dm.Select(resultQuery);
            dataGridView1.DataSource = contestTable;
        }
    }
}
