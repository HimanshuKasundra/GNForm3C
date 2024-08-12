using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for MST_PatientBALBase
/// </summary>
public class MST_GNPatientBALBase
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
    public MST_GNPatientBALBase()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    #endregion Constructor

    #region Insert
    public SqlInt32 Insert(MST_GNPatientENT entMST_GNPatient)
    {
        MST_GNPatientDAL dalMST_GNPatient = new MST_GNPatientDAL();
        SqlInt32 PatientID = dalMST_GNPatient.Insert(entMST_GNPatient);

        if (PatientID > 0)
        {
            return PatientID;
        }
        else
        {
            this.Message = dalMST_GNPatient.Message;
            return PatientID;
        }
    }
    #endregion Insert

    #region Select Operation
    #region Select View
    public DataTable SelectView(SqlInt32 PatientID)
    {
        MST_GNPatientDAL dalMST_GNPatient = new MST_GNPatientDAL();
        return dalMST_GNPatient.SelectView(PatientID);
    }
    #endregion Select View
    #endregion Select Operation
}