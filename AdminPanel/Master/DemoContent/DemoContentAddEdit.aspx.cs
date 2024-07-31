using GNForm3C;
using GNForm3C.BAL;
using System;
using System.Web.UI;

public partial class AdminPanel_Master_DemoContent_DemoContentAddEdit : System.Web.UI.Page
{
    #region 10.0 Local Variables 

    String FormName = "DemoContent";

    #endregion 10.0 Variables 

    #region 11.0 Page Load Event 
    protected void Page_Load(object sender, EventArgs e)
    {
        #region 11.1 Check User Login 

        if (Session["UserID"] == null)
            Response.Redirect(CV.LoginPageURL);

        #endregion 11.1 Check User Login 

        if (!Page.IsPostBack)
        {
            #region 11.2 Fill Labels 

            FillLabels(FormName);

            #endregion 11.2 Fill Labels 

            #region 11.3 DropDown List Fill Section 

            FillDropDownList();

            #endregion 11.3 DropDown List Fill Section 

            #region 11.4 Set Control Default Value 

            upr.DisplayAfter = CV.UpdateProgressDisplayAfter;
            txtFirstName.Focus();

            #endregion 11.4 Set Control Default Value 

            #region 11.5 Fill Controls 

            FillControls();

            #endregion 11.5 Fill Controls 

            #region 11.6 Set Help Text 

            ucHelp.ShowHelp("Help Text will be shown here");

            #endregion 11.6 Set Help Text 

        }

    }
    #endregion

    #region 12.0 FillLabels 
    private void FillLabels(String FormName)
    {
    }

    #endregion 12.0 FillLabels 

    #region 13.0 Fill DropDownList 

    private void FillDropDownList()
    {
    }

    #endregion 13.0 Fill DropDownList

    #region 14.0 FillControls By PK  
    private void FillControls()
    {
        if (Request.QueryString["DemoContentID"] != null)
        {
            DemoContentBAL balDemoContent = new DemoContentBAL();
            DemoContentENT entDemoContent = new DemoContentENT();
            entDemoContent = balDemoContent.SelectPK(CommonFunctions.DecryptBase64Int32(Request.QueryString["DemoContentID"]));

            if (!entDemoContent.FirstName.IsNull)
                txtFirstName.Text = entDemoContent.FirstName.Value.ToString();

            if (!entDemoContent.LastName.IsNull)
                txtLastName.Text = entDemoContent.LastName.Value.ToString();

            if (!entDemoContent.Salary.IsNull)
                txtSalary.Text = entDemoContent.Salary.Value.ToString();

            if (!entDemoContent.JoiningDate.IsNull)
                txtJoiningDate.Text= entDemoContent.JoiningDate.Value.ToString();

        }
    }

    #endregion 14.0 FillControls By PK 

    #region 15.0 Save Button Event 
    protected void btnSave_Click(object sender, EventArgs e)
    {
        Page.Validate();
        if (Page.IsValid)
        {
            try
            {
                DemoContentBAL balDemoContent = new DemoContentBAL();
                DemoContentENT entDemoContent = new DemoContentENT();

                #region 15.1 Validate Fields 

                String ErrorMsg = String.Empty;
                if (txtFirstName.Text.Trim() == String.Empty)
                    ErrorMsg += " - " + CommonMessage.ErrorRequiredField("First Name");
                if (txtLastName.Text.Trim() == String.Empty)
                    ErrorMsg += " - " + CommonMessage.ErrorRequiredField("Last Name");
                if (txtSalary.Text.Trim() == String.Empty)
                    ErrorMsg += " - " + CommonMessage.ErrorRequiredField("Salary");
                if (txtJoiningDate.Text.Trim() == String.Empty)
                    ErrorMsg += " - " + CommonMessage.ErrorRequiredField("Joining Date");

                if (ErrorMsg != String.Empty)
                {
                    ErrorMsg = CommonMessage.ErrorPleaseCorrectFollowing() + ErrorMsg;
                    ucMessage.ShowError(ErrorMsg);
                    return;
                }

                #endregion 15.1 Validate Fields

                #region 15.2 Gather Data 


                if (txtFirstName.Text.Trim() != String.Empty)
                    entDemoContent.FirstName = txtFirstName.Text.Trim();

                if (txtLastName.Text.Trim() != String.Empty)
                    entDemoContent.LastName = txtLastName.Text.Trim();

                if (txtSalary.Text.Trim() != String.Empty)
                    entDemoContent.Salary = Convert.ToDecimal(txtSalary.Text.Trim());

                if (txtJoiningDate.Text.Trim() != String.Empty)
                    entDemoContent.JoiningDate = Convert.ToDateTime(txtJoiningDate.Text.Trim());

                

                entDemoContent.Created = DateTime.Now;

                entDemoContent.Modified = DateTime.Now;


                #endregion 15.2 Gather Data 


                #region 15.3 Insert,Update,Copy 

                if (Request.QueryString["DemoContentID"] != null && Request.QueryString["Copy"] == null)
                {
                    entDemoContent.DemoContentID = CommonFunctions.DecryptBase64Int32(Request.QueryString["DemoContentID"]);
                    if (balDemoContent.Update(entDemoContent))
                    {
                        Response.Redirect("DemoContentList.aspx");
                    }
                    else
                    {
                        ucMessage.ShowError(balDemoContent.Message);
                    }
                }
                else
                {
                    if (Request.QueryString["DemoContentID"] == null || Request.QueryString["Copy"] != null)
                    {
                        if (balDemoContent.Insert(entDemoContent))
                        {
                            ucMessage.ShowSuccess(CommonMessage.RecordSaved());
                            ClearControls();
                        }
                    }
                }

                #endregion 15.3 Insert,Update,Copy

            }
            catch (Exception ex)
            {
                ucMessage.ShowError(ex.Message);
            }
        }
    }

    #endregion 15.0 Save Button Event 

    #region 16.0 Clear Controls 

    private void ClearControls()
    {
        txtFirstName.Text = String.Empty;
        txtLastName.Text = String.Empty;
        txtSalary.Text = String.Empty;
        txtJoiningDate.Text = String.Empty;
        txtFirstName.Focus();
    }

    #endregion 16.0 Clear Controls 
}