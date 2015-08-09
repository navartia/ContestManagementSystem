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
    public partial class SingingIdol : Form
    {
        ArrayList[,] contestantList;
        DatabaseManager dm;

        public SingingIdol()
        {
            InitializeComponent();

            dm = new DatabaseManager();
            contestantList = new ArrayList[2, 2];
        }

        private void SingingIdol_Load(object sender, EventArgs e)
        {
            FormLoad();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            int[] score = new int[4];
            score[0] = Convert.ToInt32(textBoxVQ.Text);
            score[1] = Convert.ToInt32(textBoxOrig.Text);
            score[2] = Convert.ToInt32(textBoxSQ.Text);
            score[3] = Convert.ToInt32(textBoxSP.Text);

            Contestant selected = GetSelectedContestant();
            selected.score = score;

            String scoreQuery = "SELECT * FROM score WHERE score.contestant_id = " + selected.contestant_id + " AND score.judge_id = " + selected.judge_id;
            DataTable dt = dm.Select(scoreQuery);

            if (dt.Rows.Count == 0)
            {
                String scoreInsertQuery = "INSERT INTO score (criteria_id, contestant_id, judge_id, score) VALUES (1, " + selected.contestant_id + ", " + selected.judge_id + ", " + score[0] + ")";
                dm.Insert(scoreInsertQuery);

                scoreInsertQuery = "INSERT INTO score (criteria_id, contestant_id, judge_id, score) VALUES (2, " + selected.contestant_id + ", " + selected.judge_id + ", " + score[1] + ")";
                dm.Insert(scoreInsertQuery);

                scoreInsertQuery = "INSERT INTO score (criteria_id, contestant_id, judge_id, score) VALUES (3, " + selected.contestant_id + ", " + selected.judge_id + ", " + score[2] + ")";
                dm.Insert(scoreInsertQuery);

                scoreInsertQuery = "INSERT INTO score (criteria_id, contestant_id, judge_id, score) VALUES (4, " + selected.contestant_id + ", " + selected.judge_id + ", " + score[3] + ")";
                dm.Insert(scoreInsertQuery);

                MessageBox.Show("Data has been Saved!");
            }
            else
            {
                String scoreInsertQuery = "UPDATE score SET score = " + score[0] + " WHERE score.contestant_id = " + selected.contestant_id + " AND score.judge_id = " + selected.judge_id + " AND score.criteria_id = 1";
                dm.Update(scoreInsertQuery);

                scoreInsertQuery = "UPDATE score SET score = " + score[1] + " WHERE score.contestant_id = " + selected.contestant_id + " AND score.judge_id = " + selected.judge_id + " AND score.criteria_id = 2";
                dm.Update(scoreInsertQuery);

                scoreInsertQuery = "UPDATE score SET score = " + score[2] + " WHERE score.contestant_id = " + selected.contestant_id + " AND score.judge_id = " + selected.judge_id + " AND score.criteria_id = 3";
                dm.Update(scoreInsertQuery);

                scoreInsertQuery = "UPDATE score SET score = " + score[3] + " WHERE score.contestant_id = " + selected.contestant_id + " AND score.judge_id = " + selected.judge_id + " AND score.criteria_id = 4";
                dm.Update(scoreInsertQuery);

                MessageBox.Show("Data has been Updated!");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxVQ.Text = "0";
            textBoxOrig.Text = "0";
            textBoxSQ.Text = "0";
            textBoxSP.Text = "0";

            int[] score = new int[4];
            score[0] = Convert.ToInt32(textBoxVQ.Text);
            score[1] = Convert.ToInt32(textBoxOrig.Text);
            score[2] = Convert.ToInt32(textBoxSQ.Text);
            score[3] = Convert.ToInt32(textBoxSP.Text);

            Contestant selected = GetSelectedContestant();
            selected.score = score;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            int index = (comboBoxName.SelectedIndex + 1) % comboBoxName.Items.Count;

            comboBoxName.SelectedIndex = index;
            SetSelectedContestant(comboBoxCourse.SelectedIndex, comboBoxGender.SelectedIndex, index);
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            int index = comboBoxName.SelectedIndex - 1;

            if (index > 0)
            {
                comboBoxName.SelectedIndex = index;
            }
            else
            {
                comboBoxName.SelectedIndex = comboBoxName.Items.Count - 1;
            }

            SetSelectedContestant(comboBoxCourse.SelectedIndex,
                                  comboBoxGender.SelectedIndex,
                                  comboBoxName.SelectedIndex);
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            FormLoad();
        }

        private void comboBoxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetSelectedContestant(comboBoxCourse.SelectedIndex,
                                  comboBoxGender.SelectedIndex,
                                  comboBoxName.SelectedIndex);
        }

        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCourse.SelectedIndex != -1)
                    SetSelectedList(comboBoxCourse.SelectedIndex, comboBoxGender.SelectedIndex);
        }

        private void comboBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxGender.SelectedIndex != -1)
                SetSelectedList(comboBoxCourse.SelectedIndex, comboBoxGender.SelectedIndex);
        }
        
        private void FormLoad()
        {
            String contestID = "1";
            for (int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    String course = comboBoxCourse.Items[i].ToString();
                    String gender = comboBoxGender.Items[j].ToString();
                    String contestantQuery = "SELECT * FROM contestant WHERE contest_id = " + contestID + " AND gender = '" + gender + "' AND course = '" + course + "'";
                    DataTable contestTable = dm.Select(contestantQuery);

                    contestantList[i, j] = LoadDataTableToList(contestTable);
                }
            }

            comboBoxCourse.SelectedIndex = 0;
            comboBoxGender.SelectedIndex = 0;
        }
        
        private ArrayList LoadDataTableToList(DataTable table)
        {
            ArrayList list = new ArrayList();
            foreach (DataRow row in table.Rows)
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

                int[] score = new int[4];
                int index = 0;
                foreach (DataRow scoreRow in scoreTable.Rows)
                {
                    score[index] = Convert.ToInt32(scoreRow["score"]);
                    index++;
                }
                contestant.score = score;

                list.Add(contestant);
            }

            return list;
        }
        
        private void SetSelectedList(int course, int gender) {
            comboBoxName.Items.Clear();
            foreach(Contestant contestant in contestantList[course, gender])
            {
                comboBoxName.Items.Add(contestant.name);

            }

            comboBoxName.SelectedIndex = 0;
            SetSelectedContestant(comboBoxCourse.SelectedIndex,
                                  comboBoxGender.SelectedIndex,
                                  comboBoxName.SelectedIndex);
        }

        private void SetSelectedContestant(int course, int gender, int name)
        {
            Contestant selected = contestantList[course, gender][name] as Contestant;

            labelName.Text = selected.name;
            labelNumber.Text = Convert.ToString(selected.contestant_number);

            int[] score = selected.score;
            textBoxVQ.Text = Convert.ToString(score[0]);
            textBoxOrig.Text = Convert.ToString(score[1]);
            textBoxSQ.Text = Convert.ToString(score[2]);
            textBoxSP.Text = Convert.ToString(score[3]);
        }

        private Contestant GetSelectedContestant()
        {
            int indexCourse = comboBoxCourse.SelectedIndex;
            int indexGender = comboBoxGender.SelectedIndex;
            int indexName = comboBoxName.SelectedIndex;
            Contestant selected = contestantList[indexCourse, indexGender][indexName] as Contestant;

            return selected;
        }
    }
}