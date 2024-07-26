using GNForm3C.DAL;
using GNForm3C.ENT;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DemoContentDALBase
/// </summary>
namespace GNForm3C.DAL
{
    public class DemoContentDALBase : DataBaseConfig

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

        public DemoContentDALBase()
        {

        }

        #endregion Constructor

        #region InsertOperation

        public Boolean Insert(DemoContentENT entDemoContent)
        {
            try
            {
                SqlDatabase sqlDB = new SqlDatabase(myConnectionString);
                DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_DemoContent_Insert");

                sqlDB.AddOutParameter(dbCMD, "@DemoContentID", SqlDbType.Int, 4);
                sqlDB.AddInParameter(dbCMD, "@FirstName", SqlDbType.NVarChar, entDemoContent.FirstName);
                sqlDB.AddInParameter(dbCMD, "@LastName", SqlDbType.NVarChar, entDemoContent.LastName);
                sqlDB.AddInParameter(dbCMD, "@Salary", SqlDbType.Decimal, entDemoContent.Salary);
                sqlDB.AddInParameter(dbCMD, "@JoiningDate", SqlDbType.DateTime, entDemoContent.JoiningDate);
                sqlDB.AddInParameter(dbCMD, "@Created", SqlDbType.DateTime, entDemoContent.Created);
                sqlDB.AddInParameter(dbCMD, "@Modified", SqlDbType.DateTime, entDemoContent.Modified);

                DataBaseHelper DBH = new DataBaseHelper();
                DBH.ExecuteNonQuery(sqlDB, dbCMD);

                entDemoContent.DemoContentID = (SqlInt32)Convert.ToInt32(dbCMD.Parameters["@DemoContentID"].Value);

                return true;
            }
            catch (SqlException sqlex)
            {
                Message = SQLDataExceptionMessage(sqlex);
                if (SQLDataExceptionHandler(sqlex))
                    throw;
                return false;
            }
            catch (Exception ex)
            {
                Message = ExceptionMessage(ex);
                if (ExceptionHandler(ex))
                    throw;
                return false;
            }
        }

        #endregion InsertOperation

        #region UpdateOperation

        public Boolean Update(DemoContentENT entDemoContent)
        {
            try
            {
                SqlDatabase sqlDB = new SqlDatabase(myConnectionString);
                DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_DemoContent_Update");

                sqlDB.AddInParameter(dbCMD, "@DemoContentID", SqlDbType.Int, entDemoContent.DemoContentID);
                sqlDB.AddInParameter(dbCMD, "@FirstName", SqlDbType.NVarChar, entDemoContent.FirstName);
                sqlDB.AddInParameter(dbCMD, "@LastName", SqlDbType.NVarChar, entDemoContent.LastName);
                sqlDB.AddInParameter(dbCMD, "@Salary", SqlDbType.Decimal, entDemoContent.Salary);
                sqlDB.AddInParameter(dbCMD, "@JoiningDate", SqlDbType.DateTime, entDemoContent.JoiningDate);
                sqlDB.AddInParameter(dbCMD, "@Created", SqlDbType.DateTime, entDemoContent.Created);
                sqlDB.AddInParameter(dbCMD, "@Modified", SqlDbType.DateTime, entDemoContent.Modified);

                DataBaseHelper DBH = new DataBaseHelper();
                DBH.ExecuteNonQuery(sqlDB, dbCMD);

                return true;
            }
            catch (SqlException sqlex)
            {
                Message = SQLDataExceptionMessage(sqlex);
                if (SQLDataExceptionHandler(sqlex))
                    throw;
                return false;
            }
            catch (Exception ex)
            {
                Message = ExceptionMessage(ex);
                if (ExceptionHandler(ex))
                    throw;
                return false;
            }
        }

        #endregion UpdateOperation

        #region SelectOperation

        public DemoContentENT SelectPK(SqlInt32 DemoContentID)
        {
            try
            {
                SqlDatabase sqlDB = new SqlDatabase(myConnectionString);
                DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_DemoContent_SelectPK");

                sqlDB.AddInParameter(dbCMD, "@DemoContentID", SqlDbType.Int, DemoContentID);

                DemoContentENT entDemoContent = new DemoContentENT();
                DataBaseHelper DBH = new DataBaseHelper();
                using (IDataReader dr = DBH.ExecuteReader(sqlDB, dbCMD))
                {
                    while (dr.Read())
                    {
                        if (!dr["DemoContentID"].Equals(System.DBNull.Value))
                            entDemoContent.DemoContentID = Convert.ToInt32(dr["DemoContentID"]);

                        if (!dr["FirstName"].Equals(System.DBNull.Value))
                            entDemoContent.FirstName = Convert.ToString(dr["FirstName"]);

                        if (!dr["LastName"].Equals(System.DBNull.Value))
                            entDemoContent.LastName = Convert.ToString(dr["LastName"]);
                        if (!dr["Salary"].Equals(System.DBNull.Value))
                            entDemoContent.Salary = Convert.ToDecimal(dr["Salary"]);
                        if (!dr["JoiningDate"].Equals(System.DBNull.Value))
                            entDemoContent.JoiningDate = Convert.ToDateTime(dr["JoiningDate"]);

                        if (!dr["Created"].Equals(System.DBNull.Value))
                            entDemoContent.Created = Convert.ToDateTime(dr["Created"]);

                        if (!dr["Modified"].Equals(System.DBNull.Value))
                            entDemoContent.Modified = Convert.ToDateTime(dr["Modified"]);

                    }
                }
                return entDemoContent;
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
        public DataTable SelectView(SqlInt32 DemoContentID)
        {
            try
            {
                SqlDatabase sqlDB = new SqlDatabase(myConnectionString);
                DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_DemoContent_SelectView");

                sqlDB.AddInParameter(dbCMD, "@DemoContentID", SqlDbType.Int, DemoContentID);

                DataTable dtDemoContent = new DataTable("PR_DemoContent_SelectView");

                DataBaseHelper DBH = new DataBaseHelper();
                DBH.LoadDataTable(sqlDB, dbCMD, dtDemoContent);

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
        public DataTable SelectAll()
        {
            try
            {
                SqlDatabase sqlDB = new SqlDatabase(myConnectionString);
                DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_DemoContent_SelectAll");

                DataTable dtDemoContent = new DataTable("PR_DemoContent_SelectAll");

                DataBaseHelper DBH = new DataBaseHelper();
                DBH.LoadDataTable(sqlDB, dbCMD, dtDemoContent);

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
        public DataTable SelectPage(SqlInt32 PageOffset, SqlInt32 PageSize, out Int32 TotalRecords, SqlString FirstName)
        {
            TotalRecords = 0;
            try
            {
                SqlDatabase sqlDB = new SqlDatabase(myConnectionString);
                DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_DemoContent_SelectPage");
                sqlDB.AddInParameter(dbCMD, "@PageOffset", SqlDbType.Int, PageOffset);
                sqlDB.AddInParameter(dbCMD, "@PageSize", SqlDbType.Int, PageSize);
                sqlDB.AddInParameter(dbCMD, "@FirstName", SqlDbType.Text, FirstName);
                sqlDB.AddOutParameter(dbCMD, "@TotalRecords", SqlDbType.Int, 4);

                DataTable dtDemoContent = new DataTable("PR_MST_ExpenseType_SelectPage");

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

        #region DeleteOperation

        public Boolean Delete(SqlInt32 DemoContentID)
        {
            try
            {
                SqlDatabase sqlDB = new SqlDatabase(myConnectionString);
                DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_DemoContent_Delete");

                sqlDB.AddInParameter(dbCMD, "@DemoContentID", SqlDbType.Int, DemoContentID);

                DataBaseHelper DBH = new DataBaseHelper();
                DBH.ExecuteNonQuery(sqlDB, dbCMD);

                return true;
            }
            catch (SqlException sqlex)
            {
                Message = SQLDataExceptionMessage(sqlex);
                if (SQLDataExceptionHandler(sqlex))
                    throw;
                return false;
            }
            catch (Exception ex)
            {
                Message = ExceptionMessage(ex);
                if (ExceptionHandler(ex))
                    throw;
                return false;
            }
        }

        #endregion DeleteOperation
    }
}