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
        private DatabaseManager dm;
        private DataTable[, ,] contestantData;

        private int criteria_number;
        private int courseCount, genderCount, criteriaCount;
        private String[] CATEGORY = { "CASUAL WEAR", "SPORTS WEAR", "FORMAL WEAR", "QUESTION AND ANSWER", "OVERALL APPREARANCE" };
        private int[] criteria_limit = { 10, 10, 10, 15, 5 };
        private int rowIndex;

        public MrMsSTI()
        {
            InitializeComponent();

            dm = new DatabaseManager();
            contestantData =new DataTable[5,3,2];
            courseCount = 3;
            criteriaCount = 5;
            genderCount = 2;
        }

        private void CasualWear_Load(object sender, EventArgs e)
        {
            criteria_number = 0;
            labelCategory.Text = CATEGORY[criteria_number];

            LoadToDataTable();
            LoadToDataGridView();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Save all data.", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Boolean noProblems = true;
                for (int i = 0; i < courseCount; i++)
                {
                    for (int j = 0; j < genderCount; j++)
                    {
                        foreach (DataRow row in contestantData[criteria_number, i, j].Rows)
                        {
                            int score_id = Convert.ToInt32(row["score_id"]);
                            int score = Convert.ToInt32(row["score"]);
                            String query = "UPDATE score SET score = " + score + " WHERE score_id = " + score_id;

                            if (!dm.Update(query))
                                noProblems = false;
                        }
                    }
                }

                if (noProblems)
                    MessageBox.Show("Data has been Updated!");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Clear all data.", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                for (int i = 0; i < courseCount; i++)
                {
                    for (int j = 0; j < genderCount; j++)
                    {
                        foreach (DataRow row in contestantData[criteria_number, i, j].Rows)
                        {
                            row["score"] = 0;
                        }
                    }
                }

                DataTableRanking(dataGridView1);
                DataTableRanking(dataGridView2);
                DataTableRanking(dataGridView3);
                DataTableRanking(dataGridView4);
                DataTableRanking(dataGridView5);
                DataTableRanking(dataGridView6);

            }
        }
        private void buttonNext_Click(object sender, EventArgs e)
        {
            criteria_number = (criteria_number + 1) % criteriaCount;
            labelCategory.Text = CATEGORY[criteria_number];
            LoadToDataGridView();
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            criteria_number = (criteria_number + criteriaCount - 1) % criteriaCount;
            labelCategory.Text = CATEGORY[criteria_number];
            LoadToDataGridView();
        }

        private void LoadToDataTable()
        {
            int judgeID = Properties.Settings.Default.JudgeID;
            for (int i = 0; i < criteriaCount; i++)
            {
                for (int j = 0; j < courseCount; j++)
                {
                    for (int k = 0; k < genderCount; k++)
                    {
                        String query = "SELECT score.score_id, contestant.contestant_number, contestant.firstname & \" \" & contestant.lastname AS name, score.score FROM contestant INNER JOIN score ON contestant.contestant_id = score.contestant_id WHERE score.judge_id = " + judgeID + " AND score.criteria_id = " + (i + 5) + " AND contestant.course_id = " + (j + 1) + " AND contestant.gender_id = " + (k + 1) + " ORDER BY contestant.contestant_number ASC";
                        contestantData[i, j, k] = dm.Select(query);
                    }
                }
            }
        }

        private void LoadToDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = contestantData[criteria_number, 0, 0];
            dataGridView1.Columns[0].DataPropertyName = "contestant_number";
            dataGridView1.Columns[1].DataPropertyName = "name";
            dataGridView1.Columns[2].DataPropertyName = "score";
            DataTableRanking(dataGridView1);

            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.DataSource = contestantData[criteria_number, 0, 1];
            dataGridView2.Columns[0].DataPropertyName = "contestant_number";
            dataGridView2.Columns[1].DataPropertyName = "name";
            dataGridView2.Columns[2].DataPropertyName = "score";
            DataTableRanking(dataGridView2);

            dataGridView3.AutoGenerateColumns = false;
            dataGridView3.DataSource = contestantData[criteria_number, 1, 0];
            dataGridView3.Columns[0].DataPropertyName = "contestant_number";
            dataGridView3.Columns[1].DataPropertyName = "name";
            dataGridView3.Columns[2].DataPropertyName = "score";
            DataTableRanking(dataGridView3);

            dataGridView4.AutoGenerateColumns = false;
            dataGridView4.DataSource = contestantData[criteria_number, 1, 1];
            dataGridView4.Columns[0].DataPropertyName = "contestant_number";
            dataGridView4.Columns[1].DataPropertyName = "name";
            dataGridView4.Columns[2].DataPropertyName = "score";
            DataTableRanking(dataGridView4);

            dataGridView5.AutoGenerateColumns = false;
            dataGridView5.DataSource = contestantData[criteria_number, 2, 0];
            dataGridView5.Columns[0].DataPropertyName = "contestant_number";
            dataGridView5.Columns[1].DataPropertyName = "name";
            dataGridView5.Columns[2].DataPropertyName = "score";
            DataTableRanking(dataGridView5);

            dataGridView6.AutoGenerateColumns = false;
            dataGridView6.DataSource = contestantData[criteria_number, 2, 1];
            dataGridView6.Columns[0].DataPropertyName = "contestant_number";
            dataGridView6.Columns[1].DataPropertyName = "name";
            dataGridView6.Columns[2].DataPropertyName = "score";
            DataTableRanking(dataGridView6);
        }

        private void DataTableRanking(DataGridView dgv)
        {
            int count = dgv.Rows.Count;
            if (count > 1)
            {
                for (int i = 0; i < count; i++)
                {
                    int rank = 1;
                    String rankString = "";

                    String scoreValueI = dgv.Rows[i].Cells[2].Value.ToString();
                    for (int j = 0; j < count; j++)
                    {
                        String scoreValueJ = dgv.Rows[j].Cells[2].Value.ToString();
                        if (scoreValueI.Length > 0 && scoreValueJ.Length > 0)
                        {
                            double scoreI = Convert.ToDouble(scoreValueI);
                            double scoreJ = Convert.ToDouble(scoreValueJ);
                            if (scoreI < scoreJ)
                            {
                                rank++;
                            }
                            else if (scoreI == scoreJ && i != j)
                            {
                                rankString = " - Tie";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Leaving a cell blank is not allowed. Input at least 1. (maawa ka naman sa contestant)");
                            return;
                        }
                    }

                    dgv.Rows[i].Cells[3].Value = Convert.ToString(rank) + rankString;
                }
            }
        }

        TextBox tb;
        private void CheckFormatInput(DataGridView dgv, DataGridViewEditingControlShowingEventArgs e)
        {
            rowIndex = dgv.CurrentCell.RowIndex;

            if (dgv.CurrentCell.ColumnIndex == 2)
            {
                tb = (TextBox)e.Control;
                tb.TextChanged += new EventHandler(tb_TextChanged);
            }

            e.Control.KeyPress += new KeyPressEventHandler(Control_KeyPress);
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {
            if (tb.Text.Length > 0)
            {
                Boolean disimal = false;
                textBox1.Text = tb.Text;
                for (int ctr = 0; ctr < tb.Text.Length; ctr++)
                {
                    if (tb.Text[ctr] == '.')
                    {
                        if (ctr + 1 < tb.Text.Length)
                        {
                            if (Char.IsNumber(tb.Text[ctr + 1]))
                            {
                                disimal = true;
                            }
                            else
                            {
                                MessageBox.Show("Invalid format");
                                disimal = false;
                                tb.Text = "";
                            }
                        }
                    }
                    else if (!Char.IsNumber(tb.Text[ctr]))
                    {
                        disimal = false;
                        tb.Text = "";
                    }
                    else
                    {
                        disimal = true;
                    }
                }
                if (disimal)
                {
                    if (Convert.ToDouble(tb.Text) > criteria_limit[criteria_number])
                    {
                        MessageBox.Show("0 to " + criteria_limit[criteria_number] + " is the only allowed input.");//Convert.ToString(tb.Text.Length));
                        tb.Text = criteria_limit[criteria_number].ToString();
                        dataGridView1.Rows[rowIndex].Cells[2].Value = criteria_limit[criteria_number].ToString();
                    }
                }
            }
        }

        private void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            //char yeah = Convert.ToInt16(e.KeyChar);
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            {
                int verify = 0;

                if (e.KeyChar == '.')
                {

                    for (int ctr = 0; ctr < tb.Text.Length; ctr++)
                    {
                        if (tb.Text[ctr] == '.')
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

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataTableRanking(dataGridView1);
        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataTableRanking(dataGridView2);
        }

        private void dataGridView3_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataTableRanking(dataGridView3);
        }

        private void dataGridView4_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataTableRanking(dataGridView4);
        }

        private void dataGridView5_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataTableRanking(dataGridView5);
        }

        private void dataGridView6_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataTableRanking(dataGridView6);
        }
       
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            CheckFormatInput(dataGridView1, e);
        }

        private void dataGridView2_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            CheckFormatInput(dataGridView2, e);
        }

        private void dataGridView3_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            CheckFormatInput(dataGridView3, e);
        }

        private void dataGridView4_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            CheckFormatInput(dataGridView4, e);
        }

        private void dataGridView5_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            CheckFormatInput(dataGridView5, e);
        }

        private void dataGridView6_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            CheckFormatInput(dataGridView6, e);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Close program.", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void dataGridView2_EditingControlShowing_1(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            CheckFormatInput(dataGridView2, e);
        }

        

    }
}