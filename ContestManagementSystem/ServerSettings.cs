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
        private String filepath = "";
        private FileManager fm;

        public ServerSettings()
        {
            InitializeComponent();
            fm = new FileManager();

            textBoxConn.Text = Properties.Settings.Default.ConnectionString;
            textBoxJudge.Text = Convert.ToString(Properties.Settings.Default.JudgeID);
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            filepath = fm.OpenFile();
            textBoxConn.Text = filepath;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ConnectionString = filepath;
            Properties.Settings.Default.JudgeID = Convert.ToInt32(textBoxJudge.Text);
            this.Dispose();
            LoginForm lf = new LoginForm();
            lf.ShowDialog();
           
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
