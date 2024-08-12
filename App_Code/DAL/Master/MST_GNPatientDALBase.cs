using GNForm3C.DAL;
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
/// Summary description for MST_GNPatientDALBase
/// </summary>
public class MST_GNPatientDALBase:DataBaseConfig
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
    public MST_GNPatientDALBase()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    #endregion Constructor

    #region Insert Patient
    public SqlInt32 Insert(MST_GNPatientENT entMST_GNPatient)
    {
        SqlInt32 PatientID = -1;

        try
        {
            SqlDatabase sqlDB = new SqlDatabase(myConnectionString);
            DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_MST_GNPatient_Insert");

            sqlDB.AddOutParameter(dbCMD, "@PatientID", SqlDbType.Int, 4);
            sqlDB.AddInParameter(dbCMD, "@PatientName", SqlDbType.NVarChar, entMST_GNPatient.PatientName);
            sqlDB.AddInParameter(dbCMD, "@Age", SqlDbType.Int, entMST_GNPatient.Age);
            sqlDB.AddInParameter(dbCMD, "@MobileNo", SqlDbType.NVarChar, entMST_GNPatient.MobileNo);
            sqlDB.AddInParameter(dbCMD, "@DOB", SqlDbType.DateTime, entMST_GNPatient.DOB);
            sqlDB.AddInParameter(dbCMD, "@PrimaryDesc", SqlDbType.NVarChar, entMST_GNPatient.PrimaryDesc);
            sqlDB.AddInParameter(dbCMD, "@UserID", SqlDbType.Int, entMST_GNPatient.UserID);
            sqlDB.AddInParameter(dbCMD, "@PatientPhotoPath", SqlDbType.NVarChar, entMST_GNPatient.PatientPhotoPath);
            sqlDB.AddInParameter(dbCMD, "@Created", SqlDbType.DateTime, entMST_GNPatient.Created);
            sqlDB.AddInParameter(dbCMD, "@Modified", SqlDbType.DateTime, entMST_GNPatient.Modified);

            DataBaseHelper DBH = new DataBaseHelper();
            DBH.ExecuteNonQuery(sqlDB, dbCMD);

            if (!(dbCMD.Parameters["@PatientID"].Value).Equals(DBNull.Value))
            {
                entMST_GNPatient.PatientID = (SqlInt32)Convert.ToInt32(dbCMD.Parameters["@PatientID"].Value);
                PatientID = entMST_GNPatient.PatientID;
            }

            return PatientID;
        }
        catch (SqlException sqlex)
        {
            Message = SQLDataExceptionMessage(sqlex);
            if (SQLDataExceptionHandler(sqlex))
                throw;
            return PatientID;
        }
        catch (Exception ex)
        {
            Message = ExceptionMessage(ex);
            if (ExceptionHandler(ex))
                throw;
            return PatientID;
        }
    }

    #endregion Insert Patient

    #region Select Operation

    #region Select View
    public DataTable SelectView(SqlInt32 PatientID)
    {
        try
        {
            SqlDatabase sqlDB = new SqlDatabase(myConnectionString);
            DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_MST_GNPatient_SelectView");

            sqlDB.AddInParameter(dbCMD, "@PatientID", SqlDbType.Int, PatientID);

            DataTable dtACC_GNTransaction = new DataTable("PR_MST_GNPatient_SelectView");

            DataBaseHelper DBH = new DataBaseHelper();
            DBH.LoadDataTable(sqlDB, dbCMD, dtACC_GNTransaction);

            return dtACC_GNTransaction;
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
    #endregion Select View
     
    #endregion Select Operation
}