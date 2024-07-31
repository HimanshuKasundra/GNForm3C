using GNForm3C;
using System;
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
            BindData();

            #region Set Help Text
            ucHelp.ShowHelp("Help Text will be shown here");
            #endregion Set Help Text
        }
    }

    #endregion Page Load event

    private void BindData()
    {
        MST_BranchIntakeBAL balMST_BranchIntake = new MST_BranchIntakeBAL();
        DataTable dt = balMST_BranchIntake.GetBranchIntakeData();
        rptBranches.DataSource = dt;
        rptBranches.DataBind();
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        MST_BranchIntakeBAL balMST_BranchIntake = new MST_BranchIntakeBAL();

        foreach (RepeaterItem item in rptBranches.Items)
        {
            string branch = ((Label)item.FindControl("lblBranch")).Text;
            int intake2022 = int.Parse(((TextBox)item.FindControl("txt2022")).Text);
            int intake2023 = int.Parse(((TextBox)item.FindControl("txt2023")).Text);
            int intake2024 = int.Parse(((TextBox)item.FindControl("txt2024")).Text);

            balMST_BranchIntake.SaveBranchIntakeData(branch, intake2022, intake2023, intake2024);
        }

        BindData();
    }

    protected void rptBranches_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "DeleteRecord")
        {
            string branch = e.CommandArgument.ToString();
            MST_BranchIntakeBAL balMST_BranchIntake = new MST_BranchIntakeBAL();
            balMST_BranchIntake.DeleteBranchIntakeData(branch);
            BindData();
        }
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        foreach (RepeaterItem item in rptBranches.Items)
        {
            ((TextBox)item.FindControl("txt2022")).Text = string.Empty;
            ((TextBox)item.FindControl("txt2023")).Text = string.Empty;
            ((TextBox)item.FindControl("txt2024")).Text = string.Empty;
        }
    }
}
