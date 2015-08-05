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
            }
        }
    }
}
