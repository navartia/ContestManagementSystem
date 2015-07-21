using System;
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
    public partial class RegistrationForm : Form
    {
<<<<<<< HEAD
        public String photo;
        private DatabaseManager dm;
        private FileManager fm;

=======
        public String Photo;
        private OleDbConnection connection = new OleDbConnection();
        private OleDbCommand command = new OleDbCommand();
>>>>>>> pena
        public RegistrationForm()
        {
            InitializeComponent();

            dm = new DatabaseManager();
            fm = new FileManager();
        }

        private void btn_importpic_Click(object sender, EventArgs e)
        {
            photo = fm.OpenFile();
            pictureBox1.ImageLocation = photo;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            String command = "insert into contestant (firstName,middleName,LastName,gender,studentNumber,course,ContestantNumber,SchoolYear,phone) values('" + txt_fname.Text + "','" + txt_Mname.Text + "','" + txt_Lname.Text + "','" + txt_IDNumber + "','" + txt_Course.Text + "','" + txt_Number.Text + "')";
            String command2 = "insert into contestant (firstname, middlename, lastname, contestant_number) values('test', 'test', 'test', 0)";
            
            dm.ExecuteCommand(command2);
=======
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
>>>>>>> pena
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Summary sc = new Summary();
            sc.Show();
            this.Hide();
        }
<<<<<<< HEAD
=======

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
>>>>>>> pena
    }
}
