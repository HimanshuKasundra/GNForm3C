using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Data.Common;
using System.Data.SqlClient;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using Microsoft.Practices.EnterpriseLibrary.Data;
using GNForm3C;

namespace GNForm3C.DAL
{
    public class DEF_CountDALBase : DataBaseConfig
    {
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

        #region Constructor

        public DEF_CountDALBase()
        {

        }

        #endregion Constructor

        #region Select
        public DataTable SelectCount()
        {
            try
            {
                SqlDatabase sqlDB = new SqlDatabase(myConnectionString);
                DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_DSB_Count");

                DataTable dtCount = new DataTable("PR_DSB_Count");

                DataBaseHelper DBH = new DataBaseHelper();
                DBH.LoadDataTable(sqlDB, dbCMD, dtCount);

                return dtCount;
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

        public DataTable TOP10IncomeList()
        {
            try
            {
                SqlDatabase sqlDB = new SqlDatabase(myConnectionString);
                DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_DSB_TOP10_IncomeList");

                DataTable dtCount = new DataTable("PR_DSB_TOP10_IncomeList");

                DataBaseHelper DBH = new DataBaseHelper();
                DBH.LoadDataTable(sqlDB, dbCMD, dtCount);

                return dtCount;
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

        public DataTable TOP10ExpenseList()
        {
            try
            {
                SqlDatabase sqlDB = new SqlDatabase(myConnectionString);
                DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_DSB_TOP10_ExpenseList");

                DataTable dtCount = new DataTable("PR_DSB_TOP10_ExpenseList");

                DataBaseHelper DBH = new DataBaseHelper();
                DBH.LoadDataTable(sqlDB, dbCMD, dtCount);

                return dtCount;
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
        #endregion Select

        #region Select Total Income/Expense
        public DataTable SelectTotalIncomeExpense(SqlInt32 hospitalID)
        {
            try
            {
                // Create a new SqlDatabase instance with the connection string
                SqlDatabase sqlDB = new SqlDatabase(myConnectionString);

                // Create a DbCommand for the stored procedure with a parameter
                DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_DSB_GetTotalIncomeExpenseAmountPatientCount");
                sqlDB.AddInParameter(dbCMD, "@HospitalID", DbType.Int32, hospitalID);

                // Create a DataTable to hold the results
                DataTable dtCount = new DataTable("PR_DSB_GetTotalIncomeExpenseAmountPatientCount");

                // Load the DataTable with the results from the stored procedure
                DataBaseHelper DBH = new DataBaseHelper();
                DBH.LoadDataTable(sqlDB, dbCMD, dtCount);

                return dtCount;
            }
            catch (SqlException sqlex)
            {
                // Handle SQL exceptions
                Message = SQLDataExceptionMessage(sqlex);
                if (SQLDataExceptionHandler(sqlex))
                    throw;
                return null;
            }
            catch (Exception ex)
            {
                // Handle general exceptions
                Message = ExceptionMessage(ex);
                if (ExceptionHandler(ex))
                    throw;
                return null;
            }
        }
        #endregion Select Total Income/Expense

        #region Select Day Wise Month Wise Income
        public DataTable SelectDayWiseMonthWiseIncome(SqlInt32 HospitalID)
        {
            try
            {
                SqlDatabase sqlDB = new SqlDatabase(myConnectionString);
                DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_DSB_GetDayWiseMonthWiseIncome");
                sqlDB.AddInParameter(dbCMD, "@HospitalID", DbType.Int32, HospitalID);
                DataTable dtCount = new DataTable("DayWiseMonthWiseIncome");

                DataBaseHelper DBH = new DataBaseHelper();
                DBH.LoadDataTable(sqlDB, dbCMD, dtCount);

                return dtCount;
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
        #endregion Select Day Wise Month Wise Income

        #region Select Day Wise Month Wise Expense
        public DataTable SelectDayWiseMonthWiseExpense(SqlInt32 HospitalID)
        {
            try
            {
                SqlDatabase sqlDB = new SqlDatabase(myConnectionString);
                DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_DSB_GetDayWiseMonthWiseExpense");
                sqlDB.AddInParameter(dbCMD, "@HospitalID", DbType.Int32, HospitalID);
                DataTable dtCount = new DataTable("DayWiseMonthWiseIncome");

                DataBaseHelper DBH = new DataBaseHelper();
                DBH.LoadDataTable(sqlDB, dbCMD, dtCount);

                return dtCount;
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
        #endregion Select Day Wise Month Wise Income


        #region Select Day Wise Month Wise Expense
        public DataTable SelectTreatmentWiseSummary(SqlInt32 HospitalID)
        {
            try
            {
                SqlDatabase sqlDB = new SqlDatabase(myConnectionString);
                DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_DSB_TreatmentWiseSummary");
                sqlDB.AddInParameter(dbCMD, "@HospitalID", DbType.Int32, HospitalID);
                DataTable dtCount = new DataTable("PR_DSB_TreatmentWiseSummary");

                DataBaseHelper DBH = new DataBaseHelper();
                DBH.LoadDataTable(sqlDB, dbCMD, dtCount);

                return dtCount;
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
        #endregion Select Day Wise Month Wise Income
    }
}