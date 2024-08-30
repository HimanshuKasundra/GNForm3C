using GNForm3C.BAL;
using GNForm3C;
using System;
using System.Data.SqlTypes;
using System.Data;
using System.Web.UI;

public partial class UserControl_ucPatient : UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        #region 11.1 Check User Login 

        if (Session["UserID"] == null)
            Response.Redirect(CV.LoginPageURL);


        #endregion 11.1 Check User Login 

        if (!IsPostBack)
        {
            hlPrint.DataBind();
        }
    }

    public void ShowPatient(SqlInt32 PatientID)
    {
        MST_GNPatientBAL balMST_GNPatient = new MST_GNPatientBAL();
        System.Data.DataTable dtPatient = balMST_GNPatient.SelectView(PatientID);
        imhPatient.ImageUrl = CV.DefaultNoImagePath;
        if (dtPatient != null)
        {
            foreach (DataRow dr in dtPatient.Rows)
            {
                if (!dr["PatientID"].Equals(DBNull.Value))
                {
                    ViewState["PatientID"] = dr["PatientID"].ToString();

                }

                if (!dr["PatientName"].Equals(DBNull.Value))
                {
                    lblucPatientName.Text = Convert.ToString(dr["PatientName"]);
                    lblucTitle.Text = Convert.ToString(dr["PatientName"]);

                }

                if (!dr["Age"].Equals(DBNull.Value))
                    lblucPatietAge.Text = Convert.ToString(dr["Age"]);

                if (!dr["DOB"].Equals(DBNull.Value))
                    lblucDOB.Text = Convert.ToDateTime(dr["DOB"]).ToString(CV.DefaultDateTimeFormat);

                if (!dr["MobileNo"].Equals(DBNull.Value))
                    lblucMobileNo.Text = Convert.ToString(dr["MobileNo"]);

                if (!dr["PrimaryDesc"].Equals(DBNull.Value))
                    lblucPrimaryDesc.Text = Convert.ToString(dr["PrimaryDesc"]);

                if (!dr["PatientPhotoPath"].Equals(DBNull.Value))
                    imhPatient.ImageUrl = Convert.ToString(dr["PatientPhotoPath"]);
                else
                    imhPatient.ImageUrl =CV.DefaultNoImagePath;


            }
        }

        mvwPatient.SetActiveView(vwPatient);
        mvwPatient.Visible = true;
    }

}