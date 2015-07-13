using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace ContestManagementSystem
{
    public partial class RegistrationForm : Form
    {
        public String Photo;
        private OleDbConnection connection = new OleDbConnection();
        private OleDbCommand command = new OleDbCommand();
        public RegistrationForm()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = \\HANZ21\Joel Arbole\contest_db.accdb";
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            //
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void btn_importpic_Click(object sender, EventArgs e)
        {
            try
            {


                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    String fileName = ofd.FileName;

                    pictureBox1.ImageLocation = fileName;
                    Photo = fileName;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);

            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert into contestant (firstName,middleName,LastName,gender,studentNumbers,course,ContestantNumber,SchoolYear,phone,Photo) values('" + txt_fname.Text + "','" + txt_Mname.Text + "','" + txt_Lname.Text + "','" + txt_Gender.Text + "','" + txt_IDNumber.Text + "','" + txt_Course.Text + "','" + txt_Contestant.Text + "','" + txt_Sy.Text + "','" + txt_Number.Text + "','" + Photo + "')"; command.ExecuteNonQuery();
                MessageBox.Show("Data has been Saved!");
                connection.Close();

                //    this.Dispose();
                //    Form6 f6 = new Form6();
                //    f6.ShowDialog();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Summary sc = new Summary();
            sc.Show();
            this.Hide();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            txt_fname.Text = "";
            txt_Lname.Text = "";
            txt_Mname.Text = "";
            txt_Contestant.Text = "";
            txt_IDNumber.Text = "";
            txt_Sy.Text = "";
            txt_Number.Text = "";
        }
    }
}
