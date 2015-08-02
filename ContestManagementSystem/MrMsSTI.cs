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
    public partial class MrMsSTI : Form
    {
        ArrayList contestantList;
        DatabaseManager dm;

        public MrMsSTI()
        {
            InitializeComponent();
            dm = new DatabaseManager();
            contestantList = new ArrayList();

        }
    }
}
