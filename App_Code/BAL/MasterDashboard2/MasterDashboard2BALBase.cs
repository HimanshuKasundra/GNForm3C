using System;
using GNForm3C.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for MST_DSB2BALBase
/// </summary>
/// 
namespace GNForm3C.BAL
{
    public class MasterDashboard2BALBase
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

        public MasterDashboard2BALBase()
        {

        }

        #endregion Constructor

        #region Select
        public DataTable SelectCount(SqlInt32 FinYearID)
        {
            MasterDashboard2DAL dalMasterDashboard2 = new MasterDashboard2DAL();
            return dalMasterDashboard2.SelectCount(FinYearID);
        }

        public DataTable CategoryWiseIncomeTotalList(SqlInt32 FinYearID)
        {
            MasterDashboard2DAL dalMasterDashboard2 = new MasterDashboard2DAL();
            return dalMasterDashboard2.CategoryWiseIncomeTotalList(FinYearID);
        }

        public DataTable CategoryWiseExpenseTotalList(SqlInt32 FinYearID)
        {
            MasterDashboard2DAL dalMasterDashboard2 = new MasterDashboard2DAL();
            return dalMasterDashboard2.CategoryWiseExpenseTotalList(FinYearID);
        }

        public DataTable HospitalWisePatientCountList(SqlInt32 FinYearID)
        {
            MasterDashboard2DAL dalMasterDashboard2 = new MasterDashboard2DAL();
            return dalMasterDashboard2.HospitalWisePatientCountList(FinYearID);
        }

        public DataTable AccountTranscationList(SqlInt32 FinYearID)
        {
            MasterDashboard2DAL dalMasterDashboard2 = new MasterDashboard2DAL();
            return dalMasterDashboard2.AccountTranscationList(FinYearID);
        }

        #endregion Select

    }
}