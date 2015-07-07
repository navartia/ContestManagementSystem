using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace ContestManagementSystem
{
    public partial class ServerSettings : Form
    {
        public ServerSettings()
        {
            InitializeComponent();
        }
        /*
        private void buildConString()
        {
            textBoxConn.Text = "server=" + textBoxServer.Text + ";port=" + textBoxDatabase.Text + ";username=" + textBoxUsername.Text + ";password=" + textBoxPassword.Text;
        }

        private void datasource_TextChanged(object sender, EventArgs e)
        {
            buildConString();
        }

        private void Port_TextChanged(object sender, EventArgs e)
        {
            buildConString();
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {
            buildConString();
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            buildConString();
        }
        */
        private void buttonUpdate_Click(object sender, EventArgs e)
        {/*
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            connectionStringSection.ConnectionStrings["MySql1"].ConnectionString = conStringtxt.Text;
            config.Save();

            Properties.Settings.Default.Save();

            ConfigurationManager.RefreshSection("connectionStrings");
            MyGlobals.sqlConnect = ConfigurationManager.ConnectionStrings["MySql1"].ConnectionString;
            MessageBox.Show("Connection String Updated", "Update Success!"); */
            //Properties.Settings.Default.contest_dbConnectionString = textBoxConn.Text;

            ConnectionStringSettings settings =
            ConfigurationManager.ConnectionStrings["ContestManagementSystem.Properties.Settings.contest_dbConnectionString"];

            string connectString = settings.ConnectionString;

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connectString);

            builder.DataSource = textBoxServer.Text;
            builder.InitialCatalog = textBoxDatabase.Text;
            builder.UserID = textBoxUsername.Text;
            builder.Password = textBoxPassword.Text;

            textBoxConn.Text = connectString;

            MessageBox.Show("Connection String Updated", "Update Success!");
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
