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
    public partial class JudgingForm : Form
    {
        public JudgingForm()
        {
            InitializeComponent();
        }

        private void mrButton_Click(object sender, EventArgs e)
        {
            //get contestants(mr) first name + last name from db
            mrcontestantsListbox.Visible = true;
            mscontestantsListbox.Visible = false;
            mrButton.Enabled = false;
            msButton.Enabled = true;
        }

        private void msButton_Click(object sender, EventArgs e)
        {
            mscontestantsListbox.Visible = true;
            mrcontestantsListbox.Visible = false;
            msButton.Enabled = false;
            mrButton.Enabled = true;
        }

        private void percent1Textbox_TextChanged(object sender, EventArgs e)
        {
            if (percent1Textbox.Text.Length > 0)
            {
                if (Convert.ToInt32(percent1Textbox.Text) > Convert.ToInt32(percent1Label.Text))
                {
                    percent1Textbox.Text = percent1Label.Text;
                }

                int total = Convert.ToInt32(percent1Textbox.Text);

                if (percent2Textbox.Text.Length > 0)
                { total += Convert.ToInt32(percent2Textbox.Text); }

                if (percent3Textbox.Text.Length > 0)
                { total += Convert.ToInt32(percent3Textbox.Text); }

                if (percent4Textbox.Text.Length > 0)
                { total += Convert.ToInt32(percent4Textbox.Text); }
                totalvalLabel.Text = Convert.ToString(total);
            }
            else
            {
                percent1Textbox.Text = "00";
            }
            
        }

        private void percent2Textbox_TextChanged(object sender, EventArgs e)
        {
            if (percent2Textbox.Text.Length > 0)
            {
                if (Convert.ToInt32(percent2Textbox.Text) > Convert.ToInt32(percent2Label.Text))
                {
                    percent2Textbox.Text = percent2Label.Text;
                }

                int total = Convert.ToInt32(percent2Textbox.Text);

                if (percent1Textbox.Text.Length > 0)
                { total += Convert.ToInt32(percent1Textbox.Text); }

                if (percent3Textbox.Text.Length > 0)
                { total += Convert.ToInt32(percent3Textbox.Text); }

                if (percent4Textbox.Text.Length > 0)
                { total += Convert.ToInt32(percent4Textbox.Text); }
                totalvalLabel.Text = Convert.ToString(total);
            }
            else
            {
                percent2Textbox.Text = "00";
            }
            
        }

        private void percent3Textbox_TextChanged(object sender, EventArgs e)
        {
            if (percent3Textbox.Text.Length > 0)
            {
                if (Convert.ToInt32(percent3Textbox.Text) > Convert.ToInt32(percent3Label.Text))
                {
                    percent3Textbox.Text = percent3Label.Text;
                }

                int total = Convert.ToInt32(percent3Textbox.Text);

                if (percent1Textbox.Text.Length > 0)
                { total += Convert.ToInt32(percent1Textbox.Text); }

                if (percent2Textbox.Text.Length > 0)
                { total += Convert.ToInt32(percent2Textbox.Text); }

                if (percent4Textbox.Text.Length > 0)
                { total += Convert.ToInt32(percent4Textbox.Text); }
                totalvalLabel.Text = Convert.ToString(total);
            }
            else
            {
                percent3Textbox.Text = "00";
            }
           
        }

        private void percent4Textbox_TextChanged(object sender, EventArgs e)
        {
            if (percent4Textbox.Text.Length > 0)
            {
                if (Convert.ToInt32(percent4Textbox.Text) > Convert.ToInt32(percent4Label.Text))
                {
                    percent4Textbox.Text = percent4Label.Text;
                }

                int total = Convert.ToInt32(percent4Textbox.Text);

                if (percent1Textbox.Text.Length > 0)
                { total += Convert.ToInt32(percent1Textbox.Text); }

                if (percent2Textbox.Text.Length > 0)
                { total += Convert.ToInt32(percent2Textbox.Text); }

                if (percent3Textbox.Text.Length > 0)
                { total += Convert.ToInt32(percent3Textbox.Text); }
                totalvalLabel.Text = Convert.ToString(total);
            }
            else
            {
                percent4Textbox.Text = "00";
            }
            
        }

        private void percent1Textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void percent2Textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void percent3Textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void percent4Textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
    }
}
