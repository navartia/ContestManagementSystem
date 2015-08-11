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

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        public void Insert(DataTable dt, String tableName)
        {
            using (connection = new OleDbConnection(connString))
            {
                connection.Open();
                String query = "SELECT * FROM " + tableName;
                
                using(OleDbCommand command = new OleDbCommand(query, connection))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                    {
                        using (OleDbCommandBuilder commandBuilder = new OleDbCommandBuilder(adapter))
                        {
                            adapter.DeleteCommand = commandBuilder.GetDeleteCommand();
                            adapter.InsertCommand = commandBuilder.GetInsertCommand();
                            adapter.UpdateCommand = commandBuilder.GetUpdateCommand();
                        }
                    }
                }
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

        public Boolean Update(String query)
        {
            try
            {
                connection.Open();

                command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.ExecuteNonQuery();

                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
                return false;
            }
        }

        public void Update(DataTable dataTable, String tableName)
        {
            using (connection = new OleDbConnection(connString))
            {
                connection.Open();
                String query = "SELECT * FROM " + tableName;

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                    {
                        using (OleDbCommandBuilder commandBuilder = new OleDbCommandBuilder(adapter))
                        {
                            adapter.DeleteCommand = commandBuilder.GetDeleteCommand();
                            adapter.InsertCommand = commandBuilder.GetInsertCommand();
                            adapter.UpdateCommand = commandBuilder.GetUpdateCommand();

                            adapter.Update(dataTable);
                        }
                    }
                }
            }
        }
    }
}
