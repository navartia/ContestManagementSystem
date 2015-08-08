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
        public SingingIdolSummary()
        {
            InitializeComponent();
             dm = new DatabaseManager();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //Wrong Click :DD
        }

        private void SingingIdolSummary_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
            String resultQuery = "SELECT contestant.firstname, contestant.lastname, AVG(judge_score.sum_of_score) AS total_score FROM (SELECT DISTINCT contestant_id, judge_id, SUM(score) AS sum_of_score FROM Score GROUP BY contestant_id, judge_id)  AS judge_score INNER JOIN contestant ON judge_score.contestant_id = contestant.contestant_id WHERE contestant.contest_id =  1 GROUP BY contestant.firstname, contestant.lastname";
            DataTable contestTable = dm.Select(resultQuery);
=======
<<<<<<< HEAD
            try
            {
                //where clause Missing due to database(Incomplete);
            string contestantQuery  = "select firstName,middleName,lastname,id_number,contestant_number,course from contestant";
            DataTable contestTable = dm.Select(contestantQuery);
            dm.Insert(contestantQuery);


            dm.Select(contestantQuery) ;
=======
            
            String resultQuery = "SELECT contestant.contestant_number, contestant.firstname,contestant.lastname,score.score FROM contestant INNER JOIN score ON contestant.contestant_id = score.contestant_id WHERE score.criteria_id = "4" AND contestant.course = "BS IT" AND contestant.gender = "Male"";
            DataTable contestTable = dm.Select(resultQuery);
>>>>>>> asd
>>>>>>> asd
            dataGridView1.DataSource = contestTable;
        }
    }
}
