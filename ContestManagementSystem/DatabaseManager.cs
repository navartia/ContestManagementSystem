using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContestManagementSystem
{
    using ContestantTable = ContestDataSet.ContestantDataTable;
    using ScoreTable = ContestDataSet.ScoreDataTable;

    public class DatabaseManager
    {
        private ContestantTable tableContestant;
        private ScoreTable tableScore;

        public DatabaseManager()
        {
            tableContestant = new ContestantTable();
            tableScore = new ScoreTable();
        }

        public DataTable LoadTable()
        {
           throw new NotImplementedException();
        }

        public bool SaveTable(DataTable table, String tableName)
        {
            throw new NotImplementedException();
        }
    }
}
