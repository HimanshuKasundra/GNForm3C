﻿using GNForm3C.DAL;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GNForm3C
{
    public class MST_BranchIntakeDALBase : DataBaseConfig
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

        public MST_BranchIntakeDALBase()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        #endregion Constructor

        #region GetBranchIntake Data

        //public DataTable GetBranchIntakeData()
        //{
        //    try
        //    {
        //        // Initialize the SqlDatabase object with the connection string
        //        SqlDatabase sqlDB = new SqlDatabase(myConnectionString);

        //        // Create a command object with the stored procedure name
        //        DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_MST_BranchIntake_SelectAll");

        //        // Execute the command and fill the DataTable
        //        DataSet ds = sqlDB.ExecuteDataSet(dbCMD);
        //        DataTable dt = ds.Tables[0];

        //        return dt;
        //    }
        //    catch (SqlException sqlex)
        //    {
        //        // Handle SQL exceptions
        //        Message = SQLDataExceptionMessage(sqlex);
        //        if (SQLDataExceptionHandler(sqlex))
        //            throw;
        //        return null;
        //    }
        //    catch (Exception ex)
        //    {
        //        // Handle general exceptions
        //        Message = ExceptionMessage(ex);
        //        if (ExceptionHandler(ex))
        //            throw;
        //        return null;
        //    }
        //}

        #endregion GetBranchIntake DATA

        #region SaveBranchIntake Data
        //public Boolean SaveBranchIntakeData(string branch, int admissionYear, int intake)
        //{
        //    try
        //    {
        //        // Initialize the SqlDatabase object with the connection string
        //        SqlDatabase sqlDB = new SqlDatabase(myConnectionString);

        //        // Create a command object with the stored procedure name
        //        DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_MST_BranchIntake_InsertUpdate");

        //        // Add the parameters to the command
        //        sqlDB.AddInParameter(dbCMD, "@Branch", SqlDbType.NVarChar, branch);
        //        sqlDB.AddInParameter(dbCMD, "@AdmissionYear", SqlDbType.Int, admissionYear);
        //        sqlDB.AddInParameter(dbCMD, "@Intake", SqlDbType.Int, intake);

        //        // Execute the command
        //        DataBaseHelper DBH = new DataBaseHelper();
        //        DBH.ExecuteNonQuery(sqlDB, dbCMD);

        //        return true;
        //    }
        //    catch (SqlException sqlex)
        //    {
        //        // Handle SQL exceptions
        //        Message = SQLDataExceptionMessage(sqlex);
        //        if (SQLDataExceptionHandler(sqlex))
        //            throw;
        //        return false;
        //    }
        //    catch (Exception ex)
        //    {
        //        // Handle general exceptions
        //        Message = ExceptionMessage(ex);
        //        if (ExceptionHandler(ex))
        //            throw;
        //        return false;
        //    }
        //}
        #endregion SaveBranchIntake Data

        #region Delete BranchIntake Data
        public Boolean DeleteBranchIntakeData(string branch)
        {
            try
            {
                // Initialize the SqlDatabase object with the connection string
                SqlDatabase sqlDB = new SqlDatabase(myConnectionString);

                // Create a command object with the stored procedure name
                DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_MST_BranchIntake_Delete");

                // Add the branch parameter to the command
                sqlDB.AddInParameter(dbCMD, "@Branch", SqlDbType.NVarChar, branch);

                // Initialize the helper class for database operations
                DataBaseHelper DBH = new DataBaseHelper();

                // Execute the command
                DBH.ExecuteNonQuery(sqlDB, dbCMD);

                return true;
            }
            catch (SqlException sqlex)
            {
                // Handle SQL exceptions
                Message = SQLDataExceptionMessage(sqlex);
                if (SQLDataExceptionHandler(sqlex))
                    throw;
                return false;
            }
            catch (Exception ex)
            {
                // Handle general exceptions
                Message = ExceptionMessage(ex);
                if (ExceptionHandler(ex))
                    throw;
                return false;
            }
        }

        #endregion Delete BranchIntake Data

        public DataTable GetBranchIntakeData()
        {
            try
            {
                SqlDatabase sqlDB = new SqlDatabase(myConnectionString);
                DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_MST_BranchIntake_SelectAll");
                DataSet ds = sqlDB.ExecuteDataSet(dbCMD);
                DataTable dt = ds.Tables[0];
                return dt;
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

        public void SaveBranchIntakeData(string branch, int year, int intake)
        {
            try
            {
                SqlDatabase sqlDB = new SqlDatabase(myConnectionString);
                DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_MST_BranchIntake_InsertUpdate");

                sqlDB.AddInParameter(dbCMD, "@Branch", DbType.String, branch);
                sqlDB.AddInParameter(dbCMD, "@Year", DbType.Int32, year);
                sqlDB.AddInParameter(dbCMD, "@Intake", DbType.Int32, intake);

                sqlDB.ExecuteNonQuery(dbCMD);
            }
            catch (SqlException sqlex)
            {
                Message = SQLDataExceptionMessage(sqlex);
                if (SQLDataExceptionHandler(sqlex))
                    throw;
            }
            catch (Exception ex)
            {
                Message = ExceptionMessage(ex);
                if (ExceptionHandler(ex))
                    throw;
            }
        }


    }
}