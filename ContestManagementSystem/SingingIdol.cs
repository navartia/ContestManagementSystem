﻿using System;
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
        ArrayList contestantList;
        DatabaseManager dm;

        public SingingIdol()
        {
            InitializeComponent();

            dm = new DatabaseManager();
            contestantList = new ArrayList();
        }
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            int[] score = new int[4];

            int index = comboBoxGender.SelectedIndex;
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

                scoreInsertQuery = "INSERT INTO score (criteria_id, contestant_id, judge_id, score) VALUES (3, " + selected.contestant_id + ", " + selected.judge_id + ", " + score[2] + ")";
                dm.Insert(scoreInsertQuery);

                scoreInsertQuery = "INSERT INTO score (criteria_id, contestant_id, judge_id, score) VALUES (4, " + selected.contestant_id + ", " + selected.judge_id + ", " + score[3] + ")";
                dm.Insert(scoreInsertQuery);

                MessageBox.Show("Data has been Saved!");
            }
            else
            {
                String scoreInsertQuery = "UPDATE score SET score = " + score[0] + " WHERE score.contestant_id = " + selected.contestant_id + " AND score.judge_id = " + selected.judge_id + " AND score.criteria_id = 1";
                dm.Insert(scoreInsertQuery);

                scoreInsertQuery = "UPDATE score SET score = " + score[1] + " WHERE score.contestant_id = " + selected.contestant_id + " AND score.judge_id = " + selected.judge_id + " AND score.criteria_id = 2";
                dm.Insert(scoreInsertQuery);

                scoreInsertQuery = "UPDATE score SET score = " + score[2] + " WHERE score.contestant_id = " + selected.contestant_id + " AND score.judge_id = " + selected.judge_id + " AND score.criteria_id = 3";
                dm.Insert(scoreInsertQuery);

                scoreInsertQuery = "UPDATE score SET score = " + score[3] + " WHERE score.contestant_id = " + selected.contestant_id + " AND score.judge_id = " + selected.judge_id + " AND score.criteria_id = 4";
                dm.Insert(scoreInsertQuery);

                MessageBox.Show("Data has been Updated!");
            }
        }

        private void SingingIdol_Load(object sender, EventArgs e)
        {
            String contestID = "1";
            String contestantQuery = "SELECT * FROM contestant WHERE contest_id = " + contestID;
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
                
                int[] score = new int[4];
                int index = 0;
                foreach (DataRow scoreRow in scoreTable.Rows)
                {
                    score[index] = Convert.ToInt32(scoreRow["score"]);
                    index++;
                }

                contestant.score = score;

                contestantList.Add(contestant);
                comboBoxGender.Items.Add(contestant.contestant_number + " " + contestant.name);

                comboBoxGender.SelectedIndex = 0;
            }
        }

        private void comboBoxContestant_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxGender.SelectedIndex;
            Contestant selected = contestantList[index] as Contestant;

            LoadContestant(selected);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            int index = (comboBoxGender.SelectedIndex + 1) % comboBoxGender.Items.Count;
            comboBoxGender.SelectedIndex = index;
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if (comboBoxGender.SelectedIndex != 0)
            {
                int index = (comboBoxGender.SelectedIndex - 1);
                comboBoxGender.SelectedIndex = index;
            }

            else
            {
                comboBoxGender.SelectedIndex = comboBoxGender.Items.Count - 1;
            }
        }

        private void LoadContestant(Contestant selected)
        {
            labelName.Text = selected.name;
            labelNumber.Text = Convert.ToString(selected.contestant_number);

            int[] score = selected.score;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSQ_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
