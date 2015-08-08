using System;
<<<<<<< HEAD
=======
using System.Collections;
>>>>>>> origin/carlo
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
    public partial class CasualWear : Form
    {
<<<<<<< HEAD
        public CasualWear()
        {
            InitializeComponent();
        }
=======
        DatabaseManager dm;
        public CasualWear()
        {
            InitializeComponent();
            dm = new DatabaseManager();
        }

        private void CasualWear_Load(object sender, EventArgs e)
        {
            string contestantQuery = "select firstName,middleName,lastname,id_number,contestant_number,course from contestant WHERE gender="+ "Female"+ " AND course =" + "Bachelor of Science in Computer Science";

            dm.Insert(contestantQuery);
            DataTable contestTable = dm.Select(contestantQuery);
            


            dm.Select(contestantQuery);
            dataGridView1.DataSource = contestTable;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
       
>>>>>>> origin/carlo
    }
}
