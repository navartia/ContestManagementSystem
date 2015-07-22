using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContestManagementSystem
{
    public class Contestant
    {
        public String name { get; set; }
        public String gender { get; set; }
        public String id_number { get; set; }
        public String course { get; set; }
        public String contact_number { get; set; }

        public String contest { get; set; }
        public int contestant_id { get; set; }
        public int contestant_number { get; set; }

        public int judge_id { get; set; }

        public int[] score { get; set; }

    }
}
