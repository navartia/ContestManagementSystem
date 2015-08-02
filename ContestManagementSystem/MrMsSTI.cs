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

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            Contestant contestant = new Contestant();

            int[] score = new int[2];
            score[0] = Convert.ToInt32(textBoxCW.Text);
            score[1] = Convert.ToInt32(textBoxQA.Text);
            
            contestant.score = score;

            
            int index = comboBoxContestant.SelectedIndex;
            Contestant selected = contestantList[index] as Contestant;
            selected.score = score;

            String scoreQuery = "SELECT * FROM score WHERE score.contestant_id = " + selected.contestant_id + " AND score.judge_id = " + selected.judge_id;
            DataTable dt = dm.Select(scoreQuery);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show(Convert.ToString(selected.judge_id) + Convert.ToString(selected.contestant_number) + Convert.ToString(score[0]));
                String scoreInsertQuery = "INSERT INTO score (criteria_id, contestant_id, judge_id, score) VALUES (5, " + selected.contestant_id + ", " + selected.judge_id + ", " + score[0] + ")";
                dm.Insert(scoreInsertQuery);

                scoreInsertQuery = "INSERT INTO score (criteria_id, contestant_id, judge_id, score) VALUES (6, " + selected.contestant_id + ", " + selected.judge_id + ", " + score[1] + ")";
                dm.Insert(scoreInsertQuery);

                MessageBox.Show("Data has been Saved!");
            }
            else
            {
                String scoreInsertQuery = "UPDATE score SET score = " + score[0] + " WHERE score.contestant_id = " + selected.contestant_id + " AND score.judge_id = " + selected.judge_id + " AND score.criteria_id = 5";
                dm.Insert(scoreInsertQuery);

                scoreInsertQuery = "UPDATE score SET score = " + score[1] + " WHERE score.contestant_id = " + selected.contestant_id + " AND score.judge_id = " + selected.judge_id + " AND score.criteria_id = 6";
                dm.Insert(scoreInsertQuery);

                MessageBox.Show("Data has been Updated!");
            }
        }

        private void MrMsSTI_Load(object sender, EventArgs e)
        {
            FormLoad();
        }

        private void comboBoxContestant_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxContestant.SelectedIndex;
            Contestant selected = contestantList[index] as Contestant;

            LoadContestant(selected);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxCW.Text = "0";
            textBoxQA.Text = "0";

            int[] score = new int[2];
            score[0] = Convert.ToInt32(textBoxCW.Text);
            score[1] = Convert.ToInt32(textBoxQA.Text);

            int index = comboBoxContestant.SelectedIndex;
            Contestant selected = contestantList[index] as Contestant;
            selected.score = score;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            int index = (comboBoxContestant.SelectedIndex + 1) % comboBoxContestant.Items.Count;
            comboBoxContestant.SelectedIndex = index;
        }

        private void LoadContestant(Contestant selected)
        {
            label7.Text = selected.name;
            label8.Text = Convert.ToString(selected.contestant_number);

            int[] score = selected.score;
            textBoxCW.Text = Convert.ToString(score[0]);
            textBoxQA.Text = Convert.ToString(score[1]);
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if (comboBoxContestant.SelectedIndex != 0)
            {
                int index = (comboBoxContestant.SelectedIndex - 1);
                comboBoxContestant.SelectedIndex = index;
            }

            else
            {
                comboBoxContestant.SelectedIndex = comboBoxContestant.Items.Count - 1;
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            FormLoad();
        }

        private void FormLoad()
        {
            comboBoxContestant.Items.Clear();
            contestantList = new ArrayList();

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

        private void hScrollBarOrg_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
