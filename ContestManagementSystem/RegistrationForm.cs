using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
namespace ContestManagementSystem
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            //
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
                Boolean invalidInput = false;
                if (txt_fname.Text == "" || txt_Mname.Text == "" || txt_Lname.Text == "" || txt_IDNumber.Text == "" || txt_Contestant.Text == "" || txt_Course.Text == "" || txt_Sy.Text == "" || txt_Number.Text == "")
                {
                    invalidInput = true;
                    MessageBox.Show("Please check If all fields has Data inputs");
                }
                if (!invalidInput)
                {
                    byte[] imageBT = null;
                    FileStream fstream = new FileStream(Photo, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fstream);
                    imageBT = br.ReadBytes((int)fstream.Length);
                    string myConnection = "datasource=localhost;port=3306;username=root;password=1234";
                    //Incomplete database.Student(Entities)
                    string Query = "insert into database.Student( Photo) values('" + txt_fname.Text + "','" + txt_Mname.Text + "','" + txt_Lname.Text + "','" + txt_IDNumber.Text + "','" + txt_Contestant.Text + "' ,'" + txt_Course.Text + "','" + txt_Sy.Text + "','" + txt_Number.Text + "', @IMG);";
                    MySqlConnection myConn = new MySqlConnection(myConnection);

                    MySqlCommand slctCom = new MySqlCommand(Query, myConn);

                    MySqlDataReader myReader;
                    // string query = "insert into database.studentschedule(StudentNumber,Course) values('"+label58.Text+"', '"+label6.Text+"');";
                }
                try
                {
                    myConn.Open();
                    myReader = slctCom.ExecuteReader();
                    MessageBox.Show("Saved!");



                    myConn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR on" + ex);
            }
        }
    }
}
