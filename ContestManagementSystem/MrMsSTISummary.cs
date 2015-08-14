using iTextSharp.text;
using iTextSharp.text.pdf;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContestManagementSystem
{
    public partial class MrMsSTISummary : Form
    {
        private DatabaseManager dm;
        private FileManager fm;
        
        private DataTable[,,] summaryData = new DataTable[4, 3, 2];
        private DataTable[] result = new DataTable[4];
        private DataTable judgeName;
        private String[] categoryString = { "BS CS Male", "BS CS Female", "BS COE Male", "BS COE Female", "BS IT Male", "BS IT Female" };

        public MrMsSTISummary()
        {
            InitializeComponent();
            dm = new DatabaseManager();
            fm = new FileManager();
        }

        private void MrMsSTISummary_Load(object sender, EventArgs e)
        {
            Criteria_comboBox.SelectedIndex = 0;
            LoadToDataTable();
            GetSummaryResult();
            
        }

        private void LoadToDataTable()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        String query = "SELECT contestant.contestant_number, contestant.firstname & \" \" & contestant.lastname AS name, summary.average FROM (SELECT DISTINCT contestant_id, criteria_id, ROUND(AVG(score), 2) AS average FROM score GROUP BY contestant_id, criteria_id)  AS summary INNER JOIN contestant ON summary.contestant_id = contestant.contestant_id WHERE summary.criteria_id = " + (i + 5) + " AND contestant.course_id  = " + (j + 1) + " AND contestant.gender_id = " + (k + 1) + " GROUP BY contestant.contestant_number, contestant.firstname, contestant.lastname, average ORDER BY average DESC";
                        summaryData[i, j, k] = dm.Select(query);
                    }
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    String query = "SELECT contestant.contestant_number, contestant.firstname & \" \" & contestant.lastname AS name, finalScore.average FROM (SELECT summary1.contestant_id, ROUND(summary1.score1 + summary2.score2, 2) AS average FROM (SELECT contestant_id, SUM(score) / 9 AS score1 FROM score WHERE criteria_id BETWEEN 5 AND 7 GROUP BY contestant_id)  AS summary1 INNER JOIN (SELECT contestant_id, SUM(score) / 6 AS score2 FROM score WHERE criteria_id BETWEEN 8 AND 9 GROUP BY contestant_id)  AS summary2 ON summary1.contestant_id = summary2.contestant_id)  AS finalScore INNER JOIN contestant ON finalScore.contestant_id = contestant.contestant_id WHERE contestant.course_id = " + (i + 1) + " AND contestant.gender_id = " + (j + 1) + " ORDER BY average DESC";
                    summaryData[3, i, j] = dm.Select(query);
                }
            }

            String query2 = "SELECT judge.judge_name FROM judge WHERE judge_id BETWEEN 1 AND 3";
            judgeName = dm.Select(query2);
        }

        private void LoadToDataGridView()
        {
            int criteria = Criteria_comboBox.SelectedIndex;
            int course = Course_comboBox.SelectedIndex;
            int gender = Gender_comboBox.SelectedIndex;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = summaryData[criteria, course, gender];
            dataGridView1.Columns[0].DataPropertyName = "contestant_number";
            dataGridView1.Columns[1].DataPropertyName = "name";
            dataGridView1.Columns[2].DataPropertyName = "average";
        }

        private void GetSummaryResult()
        {
            for (int i = 0; i < 4; i++)
            {
                result[i] = new DataTable();
                result[i].Columns.Add("contestant_number");
                result[i].Columns.Add("name");
                result[i].Columns.Add("average");
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        result[i].Rows.Add(summaryData[i, j, k].Rows[0].ItemArray);
                    }
                }
            }
        }

        private void PrintReport()
        {
            String filepath = fm.SaveFile();
            if (filepath != "")
            {
                using (var doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35))
                {
                    using (var resultPDF = PdfWriter.GetInstance(doc, new FileStream(filepath, FileMode.Create)))
                    {
                        BaseFont font = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);
                        doc.Open();

                        Paragraph title = new Paragraph("Style and Symphony");
                        title.Font = new Font(font, 24);
                        title.Alignment = Element.ALIGN_CENTER;
                        doc.Add(title);

                        Paragraph title2 = new Paragraph("Mr. and Ms. ICT");
                        title2.Font = new Font(font, 12);
                        title2.Alignment = Element.ALIGN_CENTER;
                        doc.Add(title2);

                        title2 = new Paragraph("LIST OF WINNERS");
                        title2.Font = new Font(font, 12);
                        title2.Alignment = Element.ALIGN_CENTER;
                        doc.Add(title2);

                        doc.Add(Chunk.NEWLINE);

                         
                        String category = Criteria_comboBox.SelectedItem.ToString();
                        title2 = new Paragraph(category);
                        title2.Font = new Font(font, 12);
                        title2.Alignment = Element.ALIGN_CENTER;
                        doc.Add(title2);

                        doc.Add(Chunk.NEWLINE);
                        
                        int criteria = Criteria_comboBox.SelectedIndex;
                        PdfPTable table = new PdfPTable(result[criteria].Columns.Count + 1);
                        table.AddCell("Category");
                        table.AddCell("Number");
                        table.AddCell("Name");
                        table.AddCell("Score");
                        table.SetWidths(new int[] { 2, 1, 3, 2 });

                        int index = 0;
                        foreach(DataRow row in result[criteria].Rows)
                        {
                            table.AddCell(categoryString[index]);
                            foreach (Object element in row.ItemArray)
                            {
                                table.AddCell(element.ToString());
                            }
                            index++;
                        }
                        doc.Add(table);


                        foreach (DataRow row in judgeName.Rows)
                        {
                            doc.Add(Chunk.NEWLINE);

                            Paragraph judge = new Paragraph("___________________");
                            judge.Font = new Font(font, 12);
                            judge.Alignment = Element.ALIGN_CENTER;
                            doc.Add(judge);

                            String judgeNameString = row.ItemArray[0].ToString();
                            judge = new Paragraph(judgeNameString);
                            judge.Font = new Font(font, 12);
                            judge.Alignment = Element.ALIGN_CENTER;
                            doc.Add(judge);
                        }

                        doc.Close();

                        MessageBox.Show("PDF created successfully!");
                    }
                }
            }
        }

        private void Course_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Criteria_comboBox.SelectedIndex != -1 && Gender_comboBox.SelectedIndex != -1)
                LoadToDataGridView();
        }

        private void Criteria_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Gender_comboBox.SelectedIndex != -1 && Course_comboBox.SelectedIndex != -1)
                LoadToDataGridView();
        }

        private void Gender_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Criteria_comboBox.SelectedIndex != -1 && Course_comboBox.SelectedIndex != -1)
                LoadToDataGridView();
        }

        private void buttonPrintReport_Click(object sender, EventArgs e)
        {
            PrintReport();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadToDataTable();
            LoadToDataGridView();
        }
    }
}
