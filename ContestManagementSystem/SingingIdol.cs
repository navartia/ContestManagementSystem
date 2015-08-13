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
        ArrayList[] contestantList;
        DatabaseManager dm;

        public SingingIdol()
        {
            InitializeComponent();

            dm = new DatabaseManager();
        }

        private void SingingIdol_Load(object sender, EventArgs e)
        {
            contestantList = new ArrayList[3];
            FormLoad();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Save all data.", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
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
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Clear all data.", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
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
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            int index = (comboBoxName.SelectedIndex + 1) % comboBoxName.Items.Count;

            comboBoxName.SelectedIndex = index;
            SetSelectedContestant(comboBoxCourse.SelectedIndex, index);
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
                                  comboBoxName.SelectedIndex);
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            FormLoad();
        }

        private void comboBoxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetSelectedContestant(comboBoxCourse.SelectedIndex,
                                  comboBoxName.SelectedIndex);
        }

        private void comboBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetSelectedList(comboBoxCourse.SelectedIndex);
        }
        
        private void FormLoad()
        {
            String contestID = "1";

            for (int i = 0; i < 3; i++)
            {
                String contestantQuery = "SELECT * FROM contestant WHERE contest_id = " + contestID + "AND course_id = " + (i + 1);
                DataTable contestTable = dm.Select(contestantQuery);

                contestantList[i] = LoadDataTableToList(contestTable);
            }

            comboBoxCourse.SelectedIndex = 0;
        }
        
        private ArrayList LoadDataTableToList(DataTable table)
        {
            ArrayList list = new ArrayList();
            foreach (DataRow row in table.Rows)
            {
                Contestant contestant = new Contestant();
                contestant.name = row["firstname"] + " " + row["middlename"] + " " + row["lastname"];
                contestant.id_number = row["id_number"].ToString();
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
        
        private void SetSelectedList(int course) {
            comboBoxName.Items.Clear();
            foreach(Contestant contestant in contestantList[course])
            {
                comboBoxName.Items.Add(contestant.name);

            }

            comboBoxName.SelectedIndex = 0;
            SetSelectedContestant(comboBoxCourse.SelectedIndex,
                                  comboBoxName.SelectedIndex);
        }

        private void SetSelectedContestant(int course, int name)
        {
            Contestant selected = contestantList[course][name] as Contestant;

            labelName.Text = selected.name;
            labelNumber.Text = "Contestant # " + Convert.ToString(selected.contestant_number);

            int[] score = selected.score;
            textBoxVQ.Text = Convert.ToString(score[0]);
            textBoxOrig.Text = Convert.ToString(score[1]);
            textBoxSQ.Text = Convert.ToString(score[2]);
            textBoxSP.Text = Convert.ToString(score[3]);
        }

        private Contestant GetSelectedContestant()
        {
            int indexCourse = comboBoxCourse.SelectedIndex;
            int indexName = comboBoxName.SelectedIndex;
            Contestant selected = contestantList[indexCourse][indexName] as Contestant;

            return selected;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Close program.", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void textBoxVQ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            {
                int verify = 0;

                if (e.KeyChar == '.')
                {

                    for (int ctr = 0; ctr < textBoxVQ.Text.Length; ctr++)
                    {
                        if (textBoxVQ.Text[ctr] == '.')
                        {
                            verify++;
                        }
                    }
                    //  MessageBox.Show(Convert.ToString(verify));
                    if (verify >= 1)
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    e.Handled = false;
                }

            }
            else if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxOrig_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            {
                int verify = 0;

                if (e.KeyChar == '.')
                {

                    for (int ctr = 0; ctr < textBoxOrig.Text.Length; ctr++)
                    {
                        if (textBoxOrig.Text[ctr] == '.')
                        {
                            verify++;
                        }
                    }
                    //  MessageBox.Show(Convert.ToString(verify));
                    if (verify >= 1)
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    e.Handled = false;
                }

            }
            else if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxSQ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            {
                int verify = 0;

                if (e.KeyChar == '.')
                {

                    for (int ctr = 0; ctr < textBoxSQ.Text.Length; ctr++)
                    {
                        if (textBoxSQ.Text[ctr] == '.')
                        {
                            verify++;
                        }
                    }
                    //  MessageBox.Show(Convert.ToString(verify));
                    if (verify >= 1)
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    e.Handled = false;
                }

            }
            else if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            {
                int verify = 0;

                if (e.KeyChar == '.')
                {

                    for (int ctr = 0; ctr < textBoxSP.Text.Length; ctr++)
                    {
                        if (textBoxSP.Text[ctr] == '.')
                        {
                            verify++;
                        }
                    }
                    //  MessageBox.Show(Convert.ToString(verify));
                    if (verify >= 1)
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    e.Handled = false;
                }

            }
            else if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxSP_TextChanged(object sender, EventArgs e)
        {
            int hello = textBoxSP.Text.Length;
            if (textBoxSP.Text.Length > 0)
            {
                if (Char.IsNumber(textBoxSP.Text[hello - 1]))
                {
                    if (Convert.ToDouble(textBoxSP.Text) > 10)
                    {
                        textBoxSP.Text = "10";
                    }
                }
            }
        }

        private void textBoxVQ_TextChanged(object sender, EventArgs e)
        {
            int hello = textBoxVQ.Text.Length;
            if (textBoxVQ.Text.Length > 0)
            {
                if (Char.IsNumber(textBoxVQ.Text[hello - 1]))
                {
                    if (Convert.ToDouble(textBoxVQ.Text) > 50)
                    {
                        textBoxVQ.Text = "50";
                    }
                }
            }
        }

        private void textBoxOrig_TextChanged(object sender, EventArgs e)
        {
            int hello = textBoxOrig.Text.Length;
            if (textBoxOrig.Text.Length > 0)
            {
                if (Char.IsNumber(textBoxOrig.Text[hello - 1]))
                {
                    if (Convert.ToDouble(textBoxOrig.Text) > 30)
                    {
                        textBoxOrig.Text = "30";
                    }
                }
            }
        }

        private void textBoxSQ_TextChanged(object sender, EventArgs e)
        {
            int hello = textBoxSQ.Text.Length;
            if (textBoxSQ.Text.Length > 0)
            {
                if (Char.IsNumber(textBoxSQ.Text[hello - 1]))
                {
                    if (Convert.ToDouble(textBoxSQ.Text) > 10)
                    {
                        textBoxSQ.Text = "10";
                    }
                }
            }
        }
    }
}