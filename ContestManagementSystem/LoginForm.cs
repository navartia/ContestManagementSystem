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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();

            RegistrationForm reg = new RegistrationForm();
            reg.ShowDialog();

            this.Show();
        }

        private void buttonJudging_Click(object sender, EventArgs e)
        {
            this.Hide();

            JudgingForm judge = new JudgingForm();
            judge.ShowDialog();

            this.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonFirststage_Click(object sender, EventArgs e)
        {
            this.Hide();

            FirstStage fs = new FirstStage();
            fs.ShowDialog();

            this.Show();
        }
    }
}
