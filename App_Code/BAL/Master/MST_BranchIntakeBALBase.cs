using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace GNForm3C
{
    public class MST_BranchIntakeBALBase
    {
        #region Private Fields

        private string _Message;

        #endregion Private Fields

        #region Public Properties

        public string Message
        {
            get
            {
                return _Message;
            }
            set
            {
                _Message = value;
            }
        }

        #endregion Public Properties

        #region Constructor
        public MST_BranchIntakeBALBase()
        {

        }
        #endregion Constructor

        #region Select BranchIntake Data
        public DataTable GetBranchIntakeData()
        {
            MST_BranchIntakeDAL dalMST_BranchIntake = new MST_BranchIntakeDAL();

            return dalMST_BranchIntake.GetBranchIntakeData();
        }


        #endregion Select BranchIntake Data

        #region Insert/Update Intake DATA

        public void SaveBranchIntakeData(string branch, Dictionary<int, int> yearIntakeData)
        {
            try
            {
                DataTable branchIntakeTable = new DataTable();
                branchIntakeTable.Columns.Add("Branch", typeof(string));
                branchIntakeTable.Columns.Add("AdmissionYear", typeof(string));
                branchIntakeTable.Columns.Add("Intake", typeof(int));

                foreach (var entry in yearIntakeData)
                {
                    branchIntakeTable.Rows.Add(branch, entry.Key.ToString(), entry.Value);
                }

                MST_BranchIntakeDAL dalMST_BranchIntake = new MST_BranchIntakeDAL();
                dalMST_BranchIntake.SaveBranchIntakeData(branchIntakeTable);
            }
            catch (Exception ex)
            {
                //// Handle general exceptions
                //Message = ExceptionMessage(ex);
                //if (ExceptionHandler(ex))
                    throw;
            }
        }


        #endregion Insert/Update Intake DATA

        #region Delete BranchIntake Data
        public void DeleteBranchIntakeData(string branch)
        {
            MST_BranchIntakeDAL dalMST_BranchIntake = new MST_BranchIntakeDAL();

            dalMST_BranchIntake.DeleteBranchIntakeData(branch);
        }

        #endregion Delete BranchIntake Data

       

    }
}