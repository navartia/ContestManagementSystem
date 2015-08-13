using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContestManagementSystem
{
    public class FileManager
    {
        public String OpenFile()
        {
            String filename = "";
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    filename = ofd.FileName;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

            return filename;
        }

        public String SaveFile()
        {
            String filename = "";
            String filter = "All files (*.*)|*.*";
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = filter;
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    filename = sfd.FileName;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

            return filename;
        }
    }
}
