using System;
using System.Collections;
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
        ArrayList contestantList;
        DatabaseManager dm;

        public MrMsSTI()
        {
            InitializeComponent();
            dm = new DatabaseManager();
            contestantList = new ArrayList();

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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            Contestant contestant = new Contestant();

            int[] score = new int[2];
            score[0] = Convert.ToInt32(textBoxVQ.Text);
            score[1] = Convert.ToInt32(textBoxOrg.Text);
            
            contestant.score = score;

            
            int index = comboBoxContestant.SelectedIndex;
            Contestant selected = contestantList[index] as Contestant;
            selected.score = score;

            String scoreQuery = "SELECT * FROM score WHERE score.contestant_id = " + selected.contestant_id + " AND score.judge_id = " + selected.judge_id;
            DataTable dt = dm.Select(scoreQuery);

            if (dt.Rows.Count == 0)
            {
                String scoreInsertQuery = "INSERT INTO score (criteria_id, contestant_id, judge_id, score) VALUES (1, " + selected.contestant_id + ", " + selected.judge_id + ", " + score[0] + ")";
                dm.Insert(scoreInsertQuery);

                scoreInsertQuery = "INSERT INTO score (criteria_id, contestant_id, judge_id, score) VALUES (2, " + selected.contestant_id + ", " + selected.judge_id + ", " + score[1] + ")";
                dm.Insert(scoreInsertQuery);

                MessageBox.Show("Data has been Saved!");
            }
            else
            {
                String scoreInsertQuery = "UPDATE score SET score = " + score[0] + " WHERE score.contestant_id = " + selected.contestant_id + " AND score.judge_id = " + selected.judge_id + " AND score.criteria_id = 1";
                dm.Insert(scoreInsertQuery);

                scoreInsertQuery = "UPDATE score SET score = " + score[1] + " WHERE score.contestant_id = " + selected.contestant_id + " AND score.judge_id = " + selected.judge_id + " AND score.criteria_id = 2";
                dm.Insert(scoreInsertQuery);

                MessageBox.Show("Data has been Updated!");
            }
        }

        private void MrMsSTI_Load(object sender, EventArgs e)
        {
            String contestID = "2";
            String contestantQuery = "SELECT * FROM contestant WHERE contest_id = " + contestID + "";
            DataTable contestTable = dm.Select(contestantQuery);

            foreach (DataRow row in contestTable.Rows)
            {
                Contestant contestant = new Contestant();
                contestant.name = row["firstname"] + " " + row["middlename"] + " " + row["lastname"];
                contestant.gender = row["gender"].ToString();
                contestant.id_number = row["id_number"].ToString();
                contestant.course = row["course"].ToString();
                contestant.contact_number = row["contact_number"].ToString();

                contestant.contest_id = Convert.ToInt32(row["contest_id"]);
                contestant.contestant_id = Convert.ToInt32(row["contestant_id"]);
                contestant.contestant_number = Convert.ToInt32(row["contestant_number"]);

                contestant.judge_id = Properties.Settings.Default.JudgeID;

                String scoreQuery = "SELECT * FROM score WHERE score.contestant_id = " + contestant.contestant_id + " AND score.judge_id = " + contestant.judge_id;
                DataTable scoreTable = dm.Select(scoreQuery);

                int[] score = new int[2];
                int index = 0;
                foreach (DataRow scoreRow in scoreTable.Rows)
                {
                    score[index] = Convert.ToInt32(scoreRow["score"]);
                    index++;
                }

                contestant.score = score;

                contestantList.Add(contestant);
                comboBoxContestant.Items.Add(contestant.contestant_number + " " + contestant.name);

                comboBoxContestant.SelectedIndex = 0;
            }
        }

        private void comboBoxContestant_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxContestant.SelectedIndex;
            Contestant selected = contestantList[index] as Contestant;

            label7.Text = selected.name;
            label8.Text = Convert.ToString(selected.contestant_number);

            int[] score = selected.score;
            textBoxVQ.Text = Convert.ToString(score[0]);
            textBoxOrg.Text = Convert.ToString(score[1]);

            hScrollBarVQ.Value = Convert.ToInt32(score[0] / 50f * 91f);
            hScrollBarOrg.Value = Convert.ToInt32(score[1] / 30f * 91f);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            hScrollBarVQ.Value = 0;
            hScrollBarOrg.Value = 0;

            textBoxVQ.Text = "0";
            textBoxOrg.Text = "0";

            int[] score = new int[4];
            score[0] = Convert.ToInt32(textBoxVQ.Text);
            score[1] = Convert.ToInt32(textBoxOrg.Text);

            int index = comboBoxContestant.SelectedIndex;
            Contestant selected = contestantList[index] as Contestant;
            selected.score = score;
        }
    }
}
