using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContestManagementSystem
{
    public class DatabaseManager
    {
        private OleDbConnection connection = new OleDbConnection();
        private String connString;

        public DatabaseManager()
        {
            connString = Properties.Settings.Default.ConnectionString;
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = " + connString;
        }

        public void ExecuteCommand(String query)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.ExecuteNonQuery();

                MessageBox.Show("Data has been Saved!");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }
    }
}
