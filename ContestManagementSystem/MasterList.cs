using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;
namespace ContestManagementSystem
{
    public partial class MasterList : Form
    {
        private DatabaseManager dm;
        private DataTable[] list;
        public MasterList()
        {
            InitializeComponent();
            dm = new DatabaseManager();
            list = new DataTable[2];
        }

        private void Summary_Load(object sender, EventArgs e)
        {
            String query = "SELECT course.course_name AS course_name, gender.gender_name, contestant.contestant_number, contestant.firstname & \" \" & contestant.lastname AS name FROM gender INNER JOIN (course INNER JOIN contestant ON course.course_id = contestant.course_id) ON gender.gender_id = contestant.gender_id WHERE contestant.contest_id = 1 ORDER BY contestant.course_id, contestant.contestant_number";  
            list[0] = dm.Select(query);

            query = "SELECT course.course_name AS course_name, gender.gender_name, contestant.contestant_number, contestant.firstname & \" \" & contestant.lastname AS name FROM gender INNER JOIN (course INNER JOIN contestant ON course.course_id = contestant.course_id) ON gender.gender_id = contestant.gender_id WHERE contestant.contest_id = 2 ORDER BY contestant.course_id, gender.gender_id, contestant.contestant_number";
            list[1] = dm.Select(query);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = list[comboBox1.SelectedIndex];
            dataGridView1.Columns[0].DataPropertyName = "course_name";
            dataGridView1.Columns[1].DataPropertyName = "gender_name";
            dataGridView1.Columns[2].DataPropertyName = "contestant_number";
            dataGridView1.Columns[3].DataPropertyName = "name";
        }
    }
}
