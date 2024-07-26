using GNForm3C.BAL;
using GNForm3C;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminPanel_Master_DemoContent_DemoContentView : System.Web.UI.Page
{
    #region Page Load Event 

    protected void Page_Load(object sender, EventArgs e)
    {
        #region 10.1 Check User Login 

        if (Session["UserID"] == null)
            Response.Redirect(CV.LoginPageURL);

        #endregion 10.1 Check User Login 

        if (!Page.IsPostBack)
        {
            if (Request.QueryString["DemoContentID"] != null)
            {
                FillControls();
            }
        }
    }

    #endregion

    #region FillControls
    private void FillControls()
    {
        if (Request.QueryString["DemoContentID"] != null)
        {
            DemoContentBAL balDemoContent = new DemoContentBAL();
            DataTable dtDemoContent = balDemoContent.SelectView(CommonFunctions.DecryptBase64Int32(Request.QueryString["DemoContentID"]));
            if (dtDemoContent != null)
            {
                foreach (DataRow dr in dtDemoContent.Rows)
                {

                    if (!dr["DemoContentID"].Equals(DBNull.Value))
                        lblDemoContentID.Text = Convert.ToString(dr["DemoContentID"]);

                    if (!dr["FirstName"].Equals(DBNull.Value))
                        lblFirstName.Text = Convert.ToString(dr["FirstName"]);

                    if (!dr["LastName"].Equals(DBNull.Value))
                        lblLastName.Text = Convert.ToString(dr["LastName"]);

                    if (!dr["Salary"].Equals(DBNull.Value))
                        lblSalary.Text = Convert.ToString(dr["Salary"]);

                    if (!dr["JoiningDate"].Equals(DBNull.Value))
                        lblJoiningDate.Text = Convert.ToString(dr["JoiningDate"]);

                    if (!dr["Created"].Equals(DBNull.Value))
                        lblCreated.Text = Convert.ToDateTime(dr["Created"]).ToString(CV.DefaultDateTimeFormat);

                    if (!dr["Modified"].Equals(DBNull.Value))
                        lblModified.Text = Convert.ToDateTime(dr["Modified"]).ToString(CV.DefaultDateTimeFormat);

                }
            }
        }
    }
    #endregion FillControls
}