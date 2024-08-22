using GNForm3C.DAL;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Util;
namespace GNForm3C
{
    public class ACC_ExpInm_LedgerDALBase:DataBaseConfig
    {
        #region Constructor
        public ACC_ExpInm_LedgerDALBase()
        {
           
        }
        #endregion

        #region Properties

        private string _Message;
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

        #endregion Properties

        #region SelectOperation
        public DataTable SelectPage(SqlInt32 PageOffset, SqlInt32 PageSize, out Int32 TotalRecords, SqlDateTime LedgerFromDate, SqlDateTime LedgerToDate,SqlString LedgerType)
        {
            TotalRecords = 0;
            try
            {
                SqlDatabase sqlDB = new SqlDatabase(myConnectionString);
                DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_ACC_ExpInm_LedgerSelectPage");
                sqlDB.AddInParameter(dbCMD, "@PageOffset", SqlDbType.Int, PageOffset);
                sqlDB.AddInParameter(dbCMD, "@PageSize", SqlDbType.Int, PageSize);
                sqlDB.AddInParameter(dbCMD, "@FromDate", SqlDbType.DateTime, LedgerFromDate);
                sqlDB.AddInParameter(dbCMD, "@Type", SqlDbType.NVarChar, LedgerType);

                sqlDB.AddInParameter(dbCMD, "@ToDate", SqlDbType.DateTime, LedgerToDate);

                sqlDB.AddOutParameter(dbCMD, "@TotalRecords", SqlDbType.Int, 4);

                DataTable dtDemoContent = new DataTable("PR_ACC_ExpInm_LedgerSelectPage");

                DataBaseHelper DBH = new DataBaseHelper();
                DBH.LoadDataTable(sqlDB, dbCMD, dtDemoContent);

                TotalRecords = Convert.ToInt32(dbCMD.Parameters["@TotalRecords"].Value);

                return dtDemoContent;
            }
            catch (SqlException sqlex)
            {
                Message = SQLDataExceptionMessage(sqlex);
                if (SQLDataExceptionHandler(sqlex))
                    throw;
                return null;
            }
            catch (Exception ex)
            {
                Message = ExceptionMessage(ex);
                if (ExceptionHandler(ex))
                    throw;
                return null;
            }
        }

        #endregion SelectOperation

        #region Report 
        public DataTable RPT_FinYearWiseHospitalWiseIncomeExpense()
        {
            try
            {
                SqlDatabase sqlDB = new SqlDatabase(myConnectionString);
                DbCommand dbCMD = sqlDB.GetStoredProcCommand("PP_FinYearWise_HospitalWise_IncomeExpense");

                DataTable dtACC_Expense = new DataTable("PP_FinYearWise_HospitalWise_IncomeExpenseList");

                DataBaseHelper DBH = new DataBaseHelper();
                DBH.LoadDataTable(sqlDB, dbCMD, dtACC_Expense);

                return dtACC_Expense;
            }
            catch (SqlException sqlex)
            {
                Message = SQLDataExceptionMessage(sqlex);
                if (SQLDataExceptionHandler(sqlex))
                    throw;
                return null;
            }
            catch (Exception ex)
            {
                Message = ExceptionMessage(ex);
                if (ExceptionHandler(ex))
                    throw;
                return null;
            }
        }

        public DataTable RPT_Ledger(SqlInt32 HospitalID, SqlInt32 FinYearID)
        {
            try
            {
                SqlDatabase sqlDB = new SqlDatabase(myConnectionString);
                DbCommand dbCMD = sqlDB.GetStoredProcCommand("PP_ACC_Ledger_HospitalWise_FinYearWise_IncomeExpenseBalanceList");
                sqlDB.AddInParameter(dbCMD, "@HospitalID", SqlDbType.Int, HospitalID);
                sqlDB.AddInParameter(dbCMD, "@FinYearID", SqlDbType.Int, FinYearID);


                DataTable dtACC_Expense = new DataTable("PP_ACC_Ledger_HospitalWise_FinYearWise_IncomeExpenseBalanceList");

                DataBaseHelper DBH = new DataBaseHelper();
                DBH.LoadDataTable(sqlDB, dbCMD, dtACC_Expense);

                return dtACC_Expense;
            }
            catch (SqlException sqlex)
            {
                Message = SQLDataExceptionMessage(sqlex);
                if (SQLDataExceptionHandler(sqlex))
                    throw;
                return null;
            }
            catch (Exception ex)
            {
                Message = ExceptionMessage(ex);
                if (ExceptionHandler(ex))
                    throw;
                return null;
            }
        }

        #endregion Report
    }
}