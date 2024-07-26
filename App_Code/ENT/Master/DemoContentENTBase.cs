using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DemoContentENTBase
/// </summary>
public class DemoContentENTBase
{
    #region Constructor

    public DemoContentENTBase()
    {

    }

    #endregion Constructor

    #region Properties

    protected SqlInt32 _DemoContentID;
    public SqlInt32 DemoContentID
    {
        get { return _DemoContentID; }
        set { _DemoContentID = value; }

    }

    protected SqlString _FirstName;
    public SqlString FirstName
    {
        get { return _FirstName; }
        set { _FirstName = value; }
    }
    protected SqlString _LastName;
    public SqlString LastName
    {
        get { return _LastName; }
        set { _LastName = value; }
    }
    protected SqlDecimal _Salary;
    public SqlDecimal Salary
    {
        get { return _Salary; }
        set { _Salary = value; }
    }
    protected SqlDateTime _JoiningDate;
    public SqlDateTime JoiningDate
    {
        get { return _JoiningDate; }
        set { _JoiningDate = value; }
    }
    protected SqlDateTime _Created;
    public SqlDateTime Created
    {

        get { return _Created; }
        set { _Created = value; }
    }
    protected SqlDateTime _Modified;
    public SqlDateTime Modified
    {
        get { return _Modified; }
        set { _Modified = value; }
    }

    #endregion

    #region ToString()

    public override string ToString()
    {
        String DemoContent_String = String.Empty;
        if (!DemoContentID.IsNull)
        {
            DemoContent_String += " DemoContentID = " + DemoContentID.Value.ToString();
        }
        if (!FirstName.IsNull) {
            DemoContent_String += "| FirstName = " + FirstName.Value;
        }
        if (!LastName.IsNull)
        {
            DemoContent_String += "| LastName = " + LastName.Value;
        }
        if (!Salary.IsNull)
        {
            DemoContent_String += "| Salary = " + Salary.Value.ToString();
        }

        if (!JoiningDate.IsNull)
        {
            DemoContent_String += "| JoiningDate = " + JoiningDate.Value.ToString();
        }
        if (!Created.IsNull)
        {
            DemoContent_String += "| Created = " + Created.Value;
        }
        if (!Modified.IsNull)
        {
            DemoContent_String += "| Modified = " + Modified.Value;
        }
        DemoContent_String= DemoContent_String.Trim();
        return DemoContent_String;
    }

    #endregion

}