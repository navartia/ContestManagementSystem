using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.OleDb;
namespace ContestManagementSystem
{
    public partial class MasterList : Form
    {
        private DatabaseManager dm;

        public MasterList()
        {
            InitializeComponent();
            dm = new DatabaseManager();
        }

        private void Summary_Load(object sender, EventArgs e)
        {
            String query = "SELECT firstname, middlename, lastname, id_number, contestant_number from contestant";  
            DataTable dt = dm.Select(query);
            dataGridView1.DataSource = dt;
        }
    }
}
