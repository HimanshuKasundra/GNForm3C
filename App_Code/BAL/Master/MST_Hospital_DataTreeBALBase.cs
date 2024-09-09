using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for MST_DataTree_HospitalBALBase
/// </summary>
public class MST_Hospital_DataTreeBALBase
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
    public MST_Hospital_DataTreeBALBase()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    #endregion Constructor

    #region SelectOperation
    public DataTable SelectPage(SqlInt32 HospitalID, SqlInt32 FinYearID, SqlDateTime OneDateOfMonth)
    {
        MST_Hospital_DataTreeDAL dalMST_Hospital_DataTree = new MST_Hospital_DataTreeDAL();
        return dalMST_Hospital_DataTree.SelectPage(HospitalID, FinYearID, OneDateOfMonth);
    }

    #endregion SelectOperation
}

