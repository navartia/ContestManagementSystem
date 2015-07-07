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

namespace ContestManagementSystem
{
    public partial class ServerSettings : Form
    {
        public ServerSettings()
        {
            InitializeComponent();
        }

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
            Properties.Settings.Default.contest_dbConnectionString = 
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void ServerSettings_Load(object sender, EventArgs e)
        {

        }

        private void Port_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
