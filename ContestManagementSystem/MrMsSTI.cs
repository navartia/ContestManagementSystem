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
    public partial class MrMsSTI : Form
    {
        public MrMsSTI()
        {
            InitializeComponent();
        }

        private void hScrollBarVQ_Scroll(object sender, ScrollEventArgs e)
        {
            int value = hScrollBarVQ.Value;
            float adjustedValue = value / 91f * 10f;
            textBoxVQ.Text = Convert.ToInt32(adjustedValue).ToString();
        }

        private void hScrollBarOrg_Scroll(object sender, ScrollEventArgs e)
        {
            int value = hScrollBarOrg.Value;
            float adjustedValue = value / 91f * 10;

            textBoxOrg.Text = Convert.ToInt32(adjustedValue).ToString();
        }
    }
}
