﻿using System;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonSingingIdol_Click(object sender, EventArgs e)
        {
            this.Hide();

            SingingIdol si = new SingingIdol();
            si.ShowDialog();

            this.Show();
        }

        private void buttonMrSTI_Click(object sender, EventArgs e)
        {
            this.Hide();

            MrMsSTI mr = new MrMsSTI();
            mr.ShowDialog();

            this.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void linkLabelServer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            ServerSettings ss = new ServerSettings();
            ss.ShowDialog();

            this.Show();
        }

        private void buttonContestControl_Click(object sender, EventArgs e)
        {
            this.Hide();

            ContestControl cs = new ContestControl();
            cs.ShowDialog();

            this.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

            string Judge;
            Judge = Properties.Settings.Default.JudgeID.ToString();
            
            char checker;
            checker = Convert.ToChar(Judge);
            if (checker == '1' || checker == '2' || checker == '3')
            {
                buttonMrSTI.Enabled = false;
            }
            else if (checker == '4' || checker == '5' || checker == '6')
            {
                buttonSingingIdol.Enabled = false;
            }
        }
    }
}
