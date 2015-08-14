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
    public partial class SingingIdolSummary : Form
    {
        private DatabaseManager dm;
        private FileManager fm;

        private DataTable[] course = new DataTable[3];
        private DataTable judgeName;

        public SingingIdolSummary()
        {
            InitializeComponent();
            dm = new DatabaseManager();
            fm = new FileManager();
        }

        private void SingingIdolSummary_Load(object sender, EventArgs e)
        {
            FormLoad();
            string Judge;
            Judge = Properties.Settings.Default.JudgeID.ToString();

            char checker;

            checker = Convert.ToChar(Judge);
            if (checker != '0')
            {
                buttonPrintReport.Enabled = false;
            }
            else
            {
                buttonPrintReport.Enabled = true;
            }
        }

        private void comboBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadToDataGridView();
        }

        private void buttonSummary_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonPrintReport_Click(object sender, EventArgs e)
        {
            PrintReport();
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

                        Paragraph title2 = new Paragraph("STI Global City Singing Idol");
                        title2.Font = new Font(font, 12);
                        title2.Alignment = Element.ALIGN_CENTER;
                        doc.Add(title2);

                        title2 = new Paragraph("LIST OF WINNERS");
                        title2.Font = new Font(font, 12);
                        title2.Alignment = Element.ALIGN_CENTER;
                        doc.Add(title2);

                        doc.Add(Chunk.NEWLINE);

                        for (int i = 0; i < 3; i++)
                        {
                            String courseString = comboBoxCourse.Items[i].ToString();
                            title2 = new Paragraph(courseString);
                            title2.Font = new Font(font, 12);
                            title2.Alignment = Element.ALIGN_CENTER;
                            doc.Add(title2);

                            doc.Add(Chunk.NEWLINE);

                            PdfPTable table = new PdfPTable(course[i].Columns.Count + 1);
                            table.AddCell("Number");
                            table.AddCell("Name");
                            table.AddCell("Score");
                            table.AddCell("Rank");
                            table.SetWidths(new int[] { 2, 5, 3, 3 });

                            int rank = 1;
                            foreach (DataRow row in course[i].Rows)
                            {
                                foreach (Object element in row.ItemArray)
                                {
                                    table.AddCell(element.ToString());
                                }
                                table.AddCell(rank.ToString());
                                rank++;
                            }
                            doc.Add(table);

                            doc.Add(Chunk.NEWLINE);
                        }

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

        private void FormLoad()
        {
            for (int i = 0; i < 3; i++)
            {
                String resultQuery = "SELECT contestant.contestant_number, contestant.firstname & \" \" & contestant.lastname AS name, ROUND(judge_score.sum_of_score / 3, 2) AS total_score FROM (SELECT contestant_id, SUM(score) AS sum_of_score FROM Score GROUP BY contestant_id)  AS judge_score INNER JOIN contestant ON judge_score.contestant_id = contestant.contestant_id WHERE contestant.contest_id = 1 AND contestant.course_id = " + (i + 1) + " ORDER BY sum_of_score DESC";
                course[i] = dm.Select(resultQuery);
            }

            String query2 = "SELECT judge.judge_name FROM judge WHERE judge_id BETWEEN 4 AND 6";
            judgeName = dm.Select(query2);
        }

        private void LoadToDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = course[comboBoxCourse.SelectedIndex];
            dataGridView1.Columns[0].DataPropertyName = "contestant_number";
            dataGridView1.Columns[1].DataPropertyName = "name";
            dataGridView1.Columns[2].DataPropertyName = "total_score";
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            FormLoad();
            LoadToDataGridView();
        }
    }
}
