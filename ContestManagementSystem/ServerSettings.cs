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

namespace Grading_System
{
    public partial class ServerSettings : Form
    {
        public ServerSettings()
        {
            InitializeComponent();
        }

        private void buildConString()
        {
            conStringtxt.Text = "datasource=" + datasource.Text + ";port=" + Port.Text + ";username=" + Username.Text + ";password=" + Password.Text;
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

        private void button1_Click(object sender, EventArgs e)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            connectionStringSection.ConnectionStrings["MySql1"].ConnectionString = conStringtxt.Text;
            config.Save();

            Properties.Settings.Default.Save();

            ConfigurationManager.RefreshSection("connectionStrings");
            MyGlobals.sqlConnect = ConfigurationManager.ConnectionStrings["MySql1"].ConnectionString;
            MessageBox.Show("Connection String Updated", "Update Success!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
