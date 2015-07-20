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
        public String photo;
        private DatabaseManager dm;
        private FileManager fm;

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
            String command = "insert into contestant (firstName,middleName,LastName,gender,studentNumber,course,ContestantNumber,SchoolYear,phone) values('" + txt_fname.Text + "','" + txt_Mname.Text + "','" + txt_Lname.Text + "','" + txt_IDNumber + "','" + txt_Course.Text + "','" + txt_Number.Text + "')";
            String command2 = "insert into contestant (firstname, middlename, lastname, contestant_number) values('test', 'test', 'test', 0)";
            
            dm.ExecuteCommand(command2);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Summary sc = new Summary();
            sc.Show();
            this.Hide();
        }
    }
}