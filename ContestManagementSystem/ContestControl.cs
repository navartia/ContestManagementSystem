using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContestManagementSystem
{
    public partial class ContestControl : Form
    {
        public ContestControl()
        {
            InitializeComponent();
        }


        private void buttonRegistration_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            RegistrationForm rf = new RegistrationForm();
            rf.ShowDialog();

            this.Show();
        }

        private void buttonMasterList_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            MasterList ml = new MasterList();
            ml.ShowDialog();

            this.Show();

        }



        private void buttonSingingIdol_Click(object sender, EventArgs e)
        {
            this.Hide();

            SingingIdolSummary si = new SingingIdolSummary();
            si.ShowDialog();

            this.Show();
        }

        private void buttonMrSTI_Click(object sender, EventArgs e)
        {
            this.Hide();

            MrMsSTISummary mr = new MrMsSTISummary();
            mr.ShowDialog();

            this.Show();

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ContestControl_Load(object sender, EventArgs e)
        {
              string Judge;
            Judge = Properties.Settings.Default.JudgeID.ToString();
            char checker;
            checker = Convert.ToChar(Judge);
            if (checker == '1' || checker == '2' || checker == '3')
            {
                buttonRegistration.Enabled = false;
                buttonMasterList.Enabled = false;
                buttonMrSTI.Enabled = false;
            }
            else if (checker == '4' || checker == '5' || checker == '6')
            {
                buttonRegistration.Enabled = false;
                buttonMasterList.Enabled = false;
                buttonSingingIdol.Enabled = false;
            }
        }
    }
}
