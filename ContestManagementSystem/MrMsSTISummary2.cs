using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ContestManagementSystem
{
    public partial class MrMsSTISummary2 : Form
    {
        private DataTable[] summaryResult;

        public MrMsSTISummary2(DataTable[] summaryResult)
        {
            this.summaryResult = summaryResult;
            InitializeComponent();
        }

        public void LoadToDataGridView()
        {
            int index = comboBoxCourse.SelectedIndex;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = summaryResult[index];
            dataGridView1.Columns[1].DataPropertyName = "name";
            dataGridView1.Columns[2].DataPropertyName = "average";

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
    }
}
