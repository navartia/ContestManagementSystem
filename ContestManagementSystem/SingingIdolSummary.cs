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
            try
            {
                //where clause Missing due to database(Incomplete);
            string contestantQuery  = "select firstName,middleName,lastname,id_number,contestant_number,course from contestant";
            DataTable contestTable = dm.Select(contestantQuery);
            dm.Insert(contestantQuery);


            dm.Select(contestantQuery) ;
            dataGridView1.DataSource = contestTable;
            }
            catch(Exception er)
            {
                MessageBox.Show("Please choose database. or " + er.Message);
            }
        }

    }
}
