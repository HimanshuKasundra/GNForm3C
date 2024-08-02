using GNForm3C;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web.UI.WebControls;

public partial class AdminPanel_Master_MST_Student_MST_BranchIntake : System.Web.UI.Page
{
    #region Variables

    String FormName = "Branch Intake";
    static Int32 PageRecordSize = CV.PageRecordSize; // Size of record per page
    Int32 PageDisplaySize = CV.PageDisplaySize;
    Int32 DisplayIndex = CV.DisplayIndex;

    #endregion Variables

    #region Page Load event

    protected void Page_Load(object sender, EventArgs e)
    {
        #region Check User Login

        if (Session["UserID"] == null)
            Response.Redirect(CV.LoginPageURL);

        #endregion Check User Login

        if (!Page.IsPostBack)
        {
            Search(1);

            #region Set Help Text
            //ucHelp.ShowHelp("Help Text will be shown here");
            #endregion Set Help Text
        }
    }

    #endregion Page Load event

    #region 15.0 Search

    #region 15.1 Button Search Click Event

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        Search(1);
    }

    #endregion 15.1 Button Search Click Event

    #region 15.2 Search Function

    private void Search(int PageNo)
    {

        MST_BranchIntakeBAL balMST_BranchIntake = new MST_BranchIntakeBAL();
        DataTable dt = balMST_BranchIntake.GetBranchIntakeData();


        if (dt != null && dt.Rows.Count > 0)
        {

            rpAddmissionYearHead.DataSource = CommonFunctions.ColumnOfDataTable(dt);
            rpAddmissionYearHead.DataBind();
            rpIntakeData.DataSource = dt;
            rpIntakeData.DataBind();

        }
        else
        {

            ucMessage.ShowError(CommonMessage.NoRecordFound());
        }
    }

    #endregion 15.2 Search Function

   

    #region 15.3 rpIntake_ItemDataBound
    protected void rpIntake_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {

        Repeater rpAddmissionYearBody = (Repeater)e.Item.FindControl("rpAddmissionYearBody");

        MST_BranchIntakeBAL balMST_BranchIntake = new MST_BranchIntakeBAL();
        DataTable dt = balMST_BranchIntake.GetBranchIntakeData();


        List<String> column = CommonFunctions.ColumnOfDataTable(dt);

        rpAddmissionYearBody.DataSource = column.GetRange(1, column.Count - 1); ;
        rpAddmissionYearBody.DataBind();

    }
    #endregion 15.3 rpIntake_ItemDataBound

    #endregion 15.0 Search

    //protected void rptBranches_ItemCommand(object source, RepeaterCommandEventArgs e)
    //{
    //    if (e.CommandName == "DeleteRecord")
    //    {
    //        string branch = e.CommandArgument.ToString();
    //        MST_BranchIntakeBAL balMST_BranchIntake = new MST_BranchIntakeBAL();
    //        balMST_BranchIntake.DeleteBranchIntakeData(branch);
    //        BindData();
    //    }
    //}

    //protected void btnClear_Click(object sender, EventArgs e)
    //{
    //    foreach (RepeaterItem item in rptBranches.Items)
    //    {
    //        ((TextBox)item.FindControl("txt2022")).Text = string.Empty;
    //        ((TextBox)item.FindControl("txt2023")).Text = string.Empty;
    //        ((TextBox)item.FindControl("txt2024")).Text = string.Empty;
    //    }
    //}
}
