using GNForm3C.DAL;
using GNForm3C.ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

namespace GNForm3C.BAL
{
    public  class DemoContentBALBase
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

        public DemoContentBALBase()
        {

        }

        #endregion Constructor

        #region InsertOperation

        public Boolean Insert(DemoContentENT entDemoContent)
        {
            DemoContentDAL dalDemoContent = new DemoContentDAL();
            if (dalDemoContent.Insert(entDemoContent))
            {
                return true;
            }
            else
            {
                this.Message = dalDemoContent.Message;
                return false;
            }
        }

        #endregion InsertOperation

        #region UpdateOperation

        public Boolean Update(DemoContentENT entDemoContent)
        {
            DemoContentDAL dalDemoContent = new DemoContentDAL();
            if (dalDemoContent.Update(entDemoContent))
            {
                return true;
            }
            else
            {
                this.Message = dalDemoContent.Message;
                return false;
            }
        }

        #endregion UpdateOperation

        #region Select operation

        public DemoContentENT SelectPK(SqlInt32 DemoContentID)
        {
            DemoContentDAL dalDemoContent = new DemoContentDAL();
            return dalDemoContent.SelectPK(DemoContentID);
        }
        public DataTable SelectView(SqlInt32 DemoContentID)
        {
            DemoContentDAL dalDemoContent = new DemoContentDAL();
            return dalDemoContent.SelectView(DemoContentID);
        }
        public DataTable SelectAll(SqlInt32 DemoContentID)
        {
            DemoContentDAL dalDemoContent = new DemoContentDAL();
            return dalDemoContent.SelectAll();
        }
        public DataTable SelectPage(SqlInt32 PageOffset, SqlInt32 PageSize, out Int32 TotalRecords, SqlString FirstName)
        {
            DemoContentDAL dalDemoContent = new DemoContentDAL();
            return dalDemoContent.SelectPage(PageOffset, PageSize, out TotalRecords, FirstName);
        }
        #endregion

        #region DeleteOperation

        public Boolean Delete(SqlInt32 DemoContentID)
        {
            DemoContentDAL dalDemoContent = new DemoContentDAL();
            if (dalDemoContent.Delete(DemoContentID))
            {
                return true;
            }
            else
            {
                this.Message = dalDemoContent.Message;
                return false;
            }
        }

        #endregion DeleteOperation
    }
}