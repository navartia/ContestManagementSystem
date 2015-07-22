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
    public partial class SingingIdol : Form
    {
        Contestant contestant;

        public SingingIdol()
        {
            InitializeComponent();

            contestant = new Contestant();
            //cm = new ClientManager();
        }

        private void hScrollBarVQ_Scroll(object sender, ScrollEventArgs e)
        {
            int value = hScrollBarVQ.Value;
            float adjustedValue = value / 91f * 50f;

            textBoxVQ.Text = Convert.ToInt32(adjustedValue).ToString();
        }

        private void hScrollBarOrg_Scroll(object sender, ScrollEventArgs e)
        {
            int value = hScrollBarOrg.Value;
            float adjustedValue = value / 91f * 30f;

            textBoxOrg.Text = Convert.ToInt32(adjustedValue).ToString();
        }

        private void hScrollBarSQ_Scroll(object sender, ScrollEventArgs e)
        {
            int value = hScrollBarSQ.Value;
            float adjustedValue = value / 91f * 10f;

            textBoxSQ.Text = Convert.ToInt32(adjustedValue).ToString();
        }

        private void hScrollBarSP_Scroll(object sender, ScrollEventArgs e)
        {
            int value = hScrollBarSP.Value;
            float adjustedValue = value / 91f * 10f;

            textBoxSP.Text = Convert.ToInt32(adjustedValue).ToString();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            hScrollBarVQ.Value = 0;
            hScrollBarOrg.Value = 0;
            hScrollBarSQ.Value = 0;
            hScrollBarSP.Value = 0;

            textBoxVQ.Text = "0";
            textBoxOrg.Text = "0";
            textBoxSQ.Text = "0";
            textBoxSP.Text = "0";
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            int[] score = new int[4];
            score[0] = Convert.ToInt32(textBoxVQ.Text);
            score[1] = Convert.ToInt32(textBoxOrg.Text);
            score[2] = Convert.ToInt32(textBoxSQ.Text);
            score[3] = Convert.ToInt32(textBoxSP.Text);

            contestant.score = score;
        }

        private void SingingIdol_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
