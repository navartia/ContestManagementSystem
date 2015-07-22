using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContestManagementSystem
{
    public class DatabaseManager
    {
        private OleDbConnection connection;
        private OleDbCommand command;
        private String connString;

        public DatabaseManager()
        {
            connString = Properties.Settings.Default.ConnectionString;
            connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = " + connString;

            //Console.WriteLine(connString)
        }

        public void Insert(String query)
        {
            try
            {
                connection.Open();

                command = new OleDbCommand();
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

        public DataTable Select(String query)
        {
            DataTable dt = new DataTable();
            try
            {
                connection.Open();

                command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                da.Fill(dt);

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

            return dt;
        }
    }
}
