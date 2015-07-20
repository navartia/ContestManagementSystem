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

        public ServerSettings()
        {
            InitializeComponent();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            filepath = OpenFile();
            textBoxConn.Text = filepath;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ConnectionString = filepath;
            this.Dispose();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //Helper methods
        private String OpenFile()
        {
            String filename = "";
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    filename = ofd.FileName;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

            return filename;
        }

    }
}
