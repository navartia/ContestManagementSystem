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
    public partial class ContestControl : Form
    {
        public ContestControl()
        {
            InitializeComponent();
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();

            RegistrationForm rf = new RegistrationForm();
            rf.ShowDialog();

            this.Show();
        }

        private void buttonMasterList_Click(object sender, EventArgs e)
        {
            this.Hide();

            MasterList ml = new MasterList();
            ml.ShowDialog();

            this.Show();
        }
    }
}
