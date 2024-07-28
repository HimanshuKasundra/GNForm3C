using GNForm3C.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

namespace GNForm3C
{
    public class MasterDashboardBALBase
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
        public MasterDashboardBALBase()
        {
        }
        #endregion Constructor

        #region Select
        public DataTable SelectDayWiseMonthWiseIncome(SqlInt32 HospitalID,SqlInt32 FinYearID)
        {
            MasterDashboardDAL masterDashboardDAL = new MasterDashboardDAL();
            return masterDashboardDAL.SelectDayWiseMonthWiseIncome(HospitalID, FinYearID);
        }
        public DataTable SelectDayWiseMonthWiseExpense(SqlInt32 HospitalID, SqlInt32 FinYearID)
        {
            MasterDashboardDAL masterDashboardDAL = new MasterDashboardDAL();
            return masterDashboardDAL.SelectDayWiseMonthWiseExpense(HospitalID, FinYearID);
        }
        public DataTable SelectTreatmentWiseSummary(SqlInt32 HospitalID,SqlInt32 FinYearID)
        {
            MasterDashboardDAL masterDashboardDAL = new MasterDashboardDAL();
            return masterDashboardDAL.SelectTreatmentWiseSummary(HospitalID, FinYearID);
        }

        #region Total Income/Expense
        public DataTable SelectTotalIncomeExpense(SqlInt32 HositalID,SqlInt32 FinYearID)
        {
            MasterDashboardDAL masterDashboardDAL = new MasterDashboardDAL();
            return masterDashboardDAL.SelectTotalIncomeExpense(HositalID, FinYearID);
        }
        #endregion Total Income/Expense

        #endregion Select
    }
}