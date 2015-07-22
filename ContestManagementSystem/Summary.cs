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
    public partial class Summary : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand command = new OleDbCommand();
        public Summary()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = \\HANZ21\Joel Arbole\contest_db.accdb";
        }

        private void Summary_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                command.Connection = con;
                string query = "select firstName,middleName,LastName,studentNumber,ContestantNumber from contestant";
                command.CommandText = query;
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

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
