using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContestManagementSystem
{
    public partial class DatabaseManager : Component
    {
        public DatabaseManager()
        {
            InitializeComponent();
        }

        public DatabaseManager(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
