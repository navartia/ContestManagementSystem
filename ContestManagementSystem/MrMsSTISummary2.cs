using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ContestManagementSystem
{
    public partial class MrMsSTISummary2 : Form
    {
        private DataTable[] summaryResult;
        private FileManager fm;

        public MrMsSTISummary2(DataTable[] summaryResult)
        {
            this.summaryResult = summaryResult;
            fm = new FileManager();
            InitializeComponent();
        }

        public void LoadToDataGridView()
        {
            int index = comboBoxCourse.SelectedIndex;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = summaryResult[index];
            dataGridView1.Columns[1].DataPropertyName = "contestant_number";
            dataGridView1.Columns[2].DataPropertyName = "name";
            dataGridView1.Columns[3].DataPropertyName = "average";

            dataGridView1.Rows[0].Cells[0].Value = "BS CS Male";
            dataGridView1.Rows[1].Cells[0].Value = "BS CS Female";
            dataGridView1.Rows[2].Cells[0].Value = "BS CpE Male";
            dataGridView1.Rows[3].Cells[0].Value = "BS CpE Female";
            dataGridView1.Rows[4].Cells[0].Value = "BS IT Male";
            dataGridView1.Rows[5].Cells[0].Value = "BS IT Female";
        }

        private void comboBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadToDataGridView();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            String filepath = fm.SaveFile();
            MessageBox.Show(filepath);
            if (filepath != "")
            {
                using (var doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35))
                {
                    using (var result = PdfWriter.GetInstance(doc, new FileStream(filepath, FileMode.Create)))
                    {
                        BaseFont font = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);
                        doc.Open();

                        Paragraph title = new Paragraph("Style and Symphony");
                        title.Font = new Font(font, 24);
                        title.Alignment = Element.ALIGN_CENTER;
                        doc.Add(title);

                        doc.Add(Chunk.NEWLINE);

                        Paragraph title2 = new Paragraph("Mr. and Ms. ICT");
                        title2.Font = new Font(font, 12);
                        title2.Alignment = Element.ALIGN_CENTER;
                        doc.Add(title2);

                        title2 = new Paragraph("LIST OF WINNERS");
                        title2.Font = new Font(font, 12);
                        title2.Alignment = Element.ALIGN_CENTER;
                        doc.Add(title2);

                        doc.Add(Chunk.NEWLINE);

                        String category = comboBoxCourse.SelectedItem.ToString();
                        title2 = new Paragraph(category);
                        title2.Font = new Font(font, 12);
                        title2.Alignment = Element.ALIGN_CENTER;
                        doc.Add(title2);

                        doc.Add(Chunk.NEWLINE);

                        PdfPTable table = new PdfPTable(dataGridView1.Columns.Count);
                        table.AddCell("Category");
                        table.AddCell("Number");
                        table.AddCell("Name");
                        table.AddCell("Score");
                        table.SetWidths(new int[] {2, 1, 3, 2});
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                table.AddCell(cell.Value.ToString());
                            }
                        }
                        doc.Add(table);

                        doc.Close();
                    }

                }
            }
        }
    }
}
