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
    public partial class Summary : Form
    {
        public Summary()
        {
            InitializeComponent();
        }

        private void Summary_Load(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=1234";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                string query = "select StudentNumber, FirstName, MiddleName, SurName, Course from database.student ";
                MySqlCommand slctCom = new MySqlCommand(query, myConn);

                MySqlDataAdapter da = new MySqlDataAdapter(slctCom);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                myConn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm rs = new RegistrationForm();
            rs.Show();
            this.Hide();
        }
    }
}
