namespace ContestManagementSystem
{
    partial class DatabaseManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.contestDataSet = new ContestManagementSystem.ContestDataSet();
            this.contestantScoreViewTableAdapter = new ContestManagementSystem.ContestDataSetTableAdapters.ContestantScoreViewTableAdapter();
            this.contestantTableAdapter = new ContestManagementSystem.ContestDataSetTableAdapters.ContestantTableAdapter();
            this.contestTableAdapter = new ContestManagementSystem.ContestDataSetTableAdapters.ContestTableAdapter();
            this.criteriaTableAdapter = new ContestManagementSystem.ContestDataSetTableAdapters.CriteriaTableAdapter();
            this.judgeTableAdapter = new ContestManagementSystem.ContestDataSetTableAdapters.JudgeTableAdapter();
            this.scoreTableAdapter = new ContestManagementSystem.ContestDataSetTableAdapters.ScoreTableAdapter();
            this.tableAdapterManager = new ContestManagementSystem.ContestDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.contestDataSet)).BeginInit();
            // 
            // contestDataSet
            // 
            this.contestDataSet.DataSetName = "ContestDataSet";
            this.contestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contestantScoreViewTableAdapter
            // 
            this.contestantScoreViewTableAdapter.ClearBeforeFill = true;
            // 
            // contestantTableAdapter
            // 
            this.contestantTableAdapter.ClearBeforeFill = true;
            // 
            // contestTableAdapter
            // 
            this.contestTableAdapter.ClearBeforeFill = true;
            // 
            // criteriaTableAdapter
            // 
            this.criteriaTableAdapter.ClearBeforeFill = true;
            // 
            // judgeTableAdapter
            // 
            this.judgeTableAdapter.ClearBeforeFill = true;
            // 
            // scoreTableAdapter
            // 
            this.scoreTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ContestantTableAdapter = this.contestantTableAdapter;
            this.tableAdapterManager.ContestTableAdapter = this.contestTableAdapter;
            this.tableAdapterManager.CriteriaTableAdapter = this.criteriaTableAdapter;
            this.tableAdapterManager.JudgeTableAdapter = this.judgeTableAdapter;
            this.tableAdapterManager.ScoreTableAdapter = this.scoreTableAdapter;
            this.tableAdapterManager.UpdateOrder = ContestManagementSystem.ContestDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            ((System.ComponentModel.ISupportInitialize)(this.contestDataSet)).EndInit();

        }

        #endregion

        private ContestDataSet contestDataSet;
        private ContestDataSetTableAdapters.ContestantScoreViewTableAdapter contestantScoreViewTableAdapter;
        private ContestDataSetTableAdapters.ContestantTableAdapter contestantTableAdapter;
        private ContestDataSetTableAdapters.ContestTableAdapter contestTableAdapter;
        private ContestDataSetTableAdapters.CriteriaTableAdapter criteriaTableAdapter;
        private ContestDataSetTableAdapters.JudgeTableAdapter judgeTableAdapter;
        private ContestDataSetTableAdapters.ScoreTableAdapter scoreTableAdapter;
        private ContestDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}
