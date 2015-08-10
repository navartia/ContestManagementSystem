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
    public partial class MrMsSTI_New : Form
    {
        private DatabaseManager dm;
        private DataTable[, ,] contestantData;

        private int criteria_number;
        private int courseCount, genderCount, criteriaCount;
        private String[] CATEGORY = { "CASUAL WEAR", "SPORTS WEAR", "FORMAL WEAR" };

        public MrMsSTI_New()
        {
            InitializeComponent();

            dm = new DatabaseManager();
            contestantData =new DataTable[3,3,2];
            courseCount = 3;
            criteriaCount = 3;
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

            if(noProblems)
                MessageBox.Show("Data has been Updated!");
        }

        private void buttonClear_Click(object sender, EventArgs e)
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
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            criteria_number = (criteria_number + 1) % 3;
            labelCategory.Text = CATEGORY[criteria_number];
            LoadToDataGridView();
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            criteria_number = (criteria_number + 2) % 3;
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
                        String query = "SELECT score.score_id, contestant.contestant_number, contestant.firstname & \" \" & contestant.lastname AS name, score.score FROM contestant INNER JOIN score ON contestant.contestant_id = score.contestant_id WHERE score.judge_id = " + judgeID + " AND score.criteria_id = " + (i + 5) + " AND contestant.course_id = " + (j + 1) + " AND contestant.gender_id = " + (k + 1);
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

            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.DataSource = contestantData[criteria_number, 0, 1];
            dataGridView2.Columns[0].DataPropertyName = "contestant_number";
            dataGridView2.Columns[1].DataPropertyName = "name";
            dataGridView2.Columns[2].DataPropertyName = "score";

            dataGridView3.AutoGenerateColumns = false;
            dataGridView3.DataSource = contestantData[criteria_number, 1, 0];
            dataGridView3.Columns[0].DataPropertyName = "contestant_number";
            dataGridView3.Columns[1].DataPropertyName = "name";
            dataGridView3.Columns[2].DataPropertyName = "score";

            dataGridView4.AutoGenerateColumns = false;
            dataGridView4.DataSource = contestantData[criteria_number, 1, 1];
            dataGridView4.Columns[0].DataPropertyName = "contestant_number";
            dataGridView4.Columns[1].DataPropertyName = "name";
            dataGridView4.Columns[2].DataPropertyName = "score";

            dataGridView5.AutoGenerateColumns = false;
            dataGridView5.DataSource = contestantData[criteria_number, 2, 0];
            dataGridView5.Columns[0].DataPropertyName = "contestant_number";
            dataGridView5.Columns[1].DataPropertyName = "name";
            dataGridView5.Columns[2].DataPropertyName = "score";

            dataGridView6.AutoGenerateColumns = false;
            dataGridView6.DataSource = contestantData[criteria_number, 2, 1];
            dataGridView6.Columns[0].DataPropertyName = "contestant_number";
            dataGridView6.Columns[1].DataPropertyName = "name";
            dataGridView6.Columns[2].DataPropertyName = "score";
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {
                for (int c = 0; c < dataGridView1.Rows.Count-1; c++)
                {
                    Boolean thigh = false;
                    int rank = 3;
                    String rak = "";
                    for (int c1 = 0; c1 < dataGridView1.Rows.Count-1; c1++)
                    {
                        if (dataGridView1.Rows[c].Cells[2].Value.ToString().Length > 0)
                        {
                            if (Convert.ToInt32(dataGridView1.Rows[c].Cells[2].Value.ToString()) > Convert.ToInt32(dataGridView1.Rows[c1].Cells[2].Value.ToString()))
                            {
                                rank--;
                                rak = "";
                            }
                            else if (Convert.ToInt32(dataGridView1.Rows[c].Cells[2].Value.ToString()) == Convert.ToInt32(dataGridView1.Rows[c1].Cells[2].Value.ToString()))
                            {
                                rak = " - Tie";
                                thigh = true; 
                            }
                            MessageBox.Show(Convert.ToString(rank)); ;
                        }
                    }
                    if (thigh)
                    { this.dataGridView1.Rows[c].Cells[3].Value = Convert.ToString(rank) + rak; }
                    else 
                    { 
                        this.dataGridView1.Rows[c].Cells[3].Value = (Convert.ToString(rank) + rak); 
                    }
                }
            }
        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Rows.Count > 1)
            {
                for (int c = 0; c < dataGridView2.Rows.Count - 1; c++)
                {
                    Boolean thigh = false;
                    int rank = 3;
                    String rak = "";
                    for (int c1 = 0; c1 < dataGridView2.Rows.Count - 1; c1++)
                    {
                        if (dataGridView2.Rows[c].Cells[2].Value.ToString().Length > 0)
                        {
                            if (Convert.ToInt32(dataGridView2.Rows[c].Cells[2].Value.ToString()) > Convert.ToInt32(dataGridView2.Rows[c1].Cells[2].Value.ToString()))
                            {
                                rank--;
                                rak = "";
                            }
                            else if (Convert.ToInt32(dataGridView2.Rows[c].Cells[2].Value.ToString()) == Convert.ToInt32(dataGridView2.Rows[c1].Cells[2].Value.ToString()))
                            {
                                rak = " - Tie";
                                thigh = true;
                            }
                            MessageBox.Show(Convert.ToString(rank)); ;
                
                        }
                    }
                    if (thigh)
                    { this.dataGridView2.Rows[c].Cells[3].Value = Convert.ToString(rank) + rak; }
                    else
                    {
                        this.dataGridView2.Rows[c].Cells[3].Value = (Convert.ToString(rank) + rak);
                    }
                }
            }
        }

        private void dataGridView3_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
                if (dataGridView3.Rows.Count > 1)
                {
                    for (int c = 0; c < dataGridView3.Rows.Count - 1; c++)
                    {
                        Boolean thigh = false;
                        int rank = 3;
                        String rak = "";
                        for (int c1 = 0; c1 < dataGridView3.Rows.Count - 1; c1++)
                        {
                            if (dataGridView3.Rows[c].Cells[2].Value.ToString().Length > 0)
                            {
                                if (Convert.ToInt32(dataGridView3.Rows[c].Cells[2].Value.ToString()) > Convert.ToInt32(dataGridView3.Rows[c1].Cells[2].Value.ToString()))
                                {
                                    rank--;
                                    rak = "";
                                }
                                else if (Convert.ToInt32(dataGridView3.Rows[c].Cells[2].Value.ToString()) == Convert.ToInt32(dataGridView3.Rows[c1].Cells[2].Value.ToString()))
                                {
                                    rak = " - Tie";
                                    thigh = true;
                                }
                                MessageBox.Show(Convert.ToString(rank)); ;
                            }
                        }
                        if (thigh)
                        { this.dataGridView3.Rows[c].Cells[3].Value = Convert.ToString(rank) + rak; }
                        else
                        {
                            this.dataGridView3.Rows[c].Cells[3].Value = (Convert.ToString(rank) + rak);
                        }
                    }
            }
        }

        private void dataGridView4_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView4.Rows.Count > 1)
            {
                for (int c = 0; c < dataGridView4.Rows.Count - 1; c++)
                {
                    Boolean thigh = false;
                    int rank = 3;
                    String rak = "";
                    for (int c1 = 0; c1 < dataGridView4.Rows.Count - 1; c1++)
                    {
                        if (dataGridView4.Rows[c].Cells[2].Value.ToString().Length > 0)
                        {
                            if (Convert.ToInt32(dataGridView4.Rows[c].Cells[2].Value.ToString()) > Convert.ToInt32(dataGridView4.Rows[c1].Cells[2].Value.ToString()))
                            {
                                rank--;
                                rak = "";
                            }
                            else if (Convert.ToInt32(dataGridView4.Rows[c].Cells[2].Value.ToString()) == Convert.ToInt32(dataGridView4.Rows[c1].Cells[2].Value.ToString()))
                            {
                                rak = " - Tie";
                                thigh = true;
                            }
                            MessageBox.Show(Convert.ToString(rank)); ;
                        }
                    }
                    if (thigh)
                    { this.dataGridView4.Rows[c].Cells[3].Value = Convert.ToString(rank) + rak; }
                    else
                    {
                        this.dataGridView4.Rows[c].Cells[3].Value = (Convert.ToString(rank) + rak);
                    }
                }
            }
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView4.Rows.Count > 1)
            {
                for (int c = 0; c < dataGridView4.Rows.Count - 1; c++)
                {
                    Boolean thigh = false;
                    int rank = 3;
                    String rak = "";
                    for (int c1 = 0; c1 < dataGridView4.Rows.Count - 1; c1++)
                    {
                        if (dataGridView4.Rows[c].Cells[2].Value.ToString().Length > 0)
                        {
                            if (Convert.ToInt32(dataGridView4.Rows[c].Cells[2].Value.ToString()) > Convert.ToInt32(dataGridView4.Rows[c1].Cells[2].Value.ToString()))
                            {
                                rank--;
                                rak = "";
                            }
                            else if (Convert.ToInt32(dataGridView4.Rows[c].Cells[2].Value.ToString()) == Convert.ToInt32(dataGridView4.Rows[c1].Cells[2].Value.ToString()))
                            {
                                rak = " - Tie";
                                thigh = true;
                            }
                            MessageBox.Show(Convert.ToString(rank)); ;
                        }
                    }
                    if (thigh)
                    { this.dataGridView4.Rows[c].Cells[3].Value = Convert.ToString(rank) + rak; }
                    else
                    {
                        this.dataGridView4.Rows[c].Cells[3].Value = (Convert.ToString(rank) + rak);
                    }
                }
            }
        }

        private void dataGridView5_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView5.Rows.Count > 1)
            {
                for (int c = 0; c < dataGridView5.Rows.Count - 1; c++)
                {
                    Boolean thigh = false;
                    int rank = 3;
                    String rak = "";
                    for (int c1 = 0; c1 < dataGridView5.Rows.Count - 1; c1++)
                    {
                        if (dataGridView5.Rows[c].Cells[2].Value.ToString().Length > 0)
                        {
                            if (Convert.ToInt32(dataGridView5.Rows[c].Cells[2].Value.ToString()) > Convert.ToInt32(dataGridView5.Rows[c1].Cells[2].Value.ToString()))
                            {
                                rank--;
                                rak = "";
                            }
                            else if (Convert.ToInt32(dataGridView5.Rows[c].Cells[2].Value.ToString()) == Convert.ToInt32(dataGridView5.Rows[c1].Cells[2].Value.ToString()))
                            {
                                rak = " - Tie";
                                thigh = true;
                            }
                            MessageBox.Show(Convert.ToString(rank)); ;
                        }
                    }
                    if (thigh)
                    { this.dataGridView5.Rows[c].Cells[3].Value = Convert.ToString(rank) + rak; }
                    else
                    {
                        this.dataGridView5.Rows[c].Cells[3].Value = (Convert.ToString(rank) + rak);
                    }
                }
            }
        }

        private void dataGridView6_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView6.Rows.Count > 1)
            {
                for (int c = 0; c < dataGridView6.Rows.Count - 1; c++)
                {
                    Boolean thigh = false;
                    int rank = 3;
                    String rak = "";
                    for (int c1 = 0; c1 < dataGridView6.Rows.Count - 1; c1++)
                    {
                        if (dataGridView6.Rows[c].Cells[2].Value.ToString().Length > 0)
                        {
                            if (Convert.ToInt32(dataGridView6.Rows[c].Cells[2].Value.ToString()) > Convert.ToInt32(dataGridView6.Rows[c1].Cells[2].Value.ToString()))
                            {
                                rank--;
                                rak = "";
                            }
                            else if (Convert.ToInt32(dataGridView6.Rows[c].Cells[2].Value.ToString()) == Convert.ToInt32(dataGridView6.Rows[c1].Cells[2].Value.ToString()))
                            {
                                rak = " - Tie";
                                thigh = true;
                            }
                            MessageBox.Show(Convert.ToString(rank)); ;
                        }
                    }
                    if (thigh)
                    { this.dataGridView6.Rows[c].Cells[3].Value = Convert.ToString(rank) + rak; }
                    else
                    {
                        this.dataGridView6.Rows[c].Cells[3].Value = (Convert.ToString(rank) + rak);
                    }
                }
            }
        }
    }
}
