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
    public partial class TestDB : Form
    {
        public TestDB()
        {
            InitializeComponent();
        }

        private void TestDB_Load(object sender, EventArgs e)
        {
            fetchDB();
        }

        private void fetchDB()
        {
            OleDbConnection connection = new OleDbConnection();
            OleDbCommand command = new OleDbCommand();

            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = \\HANZ21\Joel Arbole\contest_db.accdb";

            connection.Open();

            command.Connection = connection;
            string query = "select ID from Table1";
            command.CommandText = query;
            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                comboBox1.Items.Add(reader["ID"].ToString());
            }

            connection.Close();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            fetchDB();
        }
    }
}
