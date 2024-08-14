using GNForm3C.BAL;
using GNForm3C;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Reporting.WebForms;

public partial class AdminPanel_Reports_RPT_ACC_Income_RPT_HospitalWiseIncomeTypeWiseData : System.Web.UI.Page
{

    #region Private Variable
    private DataTable dtACC_Income = new DataTable("dtACC_Income");
    private dsACC_Income objdsACC_Income = new dsACC_Income();

    #endregion
    #region Page Load Event
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            ShowReport();
        }

    }
    #endregion Page Load Event

    #region Show Report
    protected void ShowReport()
    {
        try
        {
            ACC_IncomeBAL balACC_Income = new ACC_IncomeBAL();
            dtACC_Income = balACC_Income.Report_ACC_Income_ByFinYear();
            FillDataSet();
        }
        catch (Exception ex)
        {

        }

    }
    #endregion Show Report

    #region FillDataSet

    protected void FillDataSet()
    {
        foreach (DataRow dr in dtACC_Income.Rows)
        {
            dsACC_Income.dtACC_IncomeRow drACC_Income = objdsACC_Income.dtACC_Income.NewdtACC_IncomeRow();

            if (!dr["Hospital"].Equals(System.DBNull.Value))
                drACC_Income.Hospital = Convert.ToString(dr["Hospital"]);

            if (!dr["FinYear"].Equals(System.DBNull.Value))
                drACC_Income.FinYear = Convert.ToString(dr["FinYear"]);

            if (!dr["IncomeType"].Equals(System.DBNull.Value))
                drACC_Income.IncomeType = Convert.ToString(dr["IncomeType"]);

            if (!dr["Amount"].Equals(System.DBNull.Value))
                drACC_Income.Amount = Convert.ToDecimal(dr["Amount"]);

            if (!dr["IncomeDate"].Equals(System.DBNull.Value))
                drACC_Income.IncomeDate = Convert.ToDateTime(dr["IncomeDate"]).ToString(CV.DefaultDateFormat);


            objdsACC_Income.dtACC_Income.Rows.Add(drACC_Income);
        }

        SetReportParameters();
        this.rvIncomeList.LocalReport.DataSources.Clear();
        this.rvIncomeList.LocalReport.DataSources.Add(new ReportDataSource("dtACC_Income", (DataTable)objdsACC_Income.dtACC_Income));
        this.rvIncomeList.LocalReport.Refresh();
    }
    #endregion FillDataSet


    #region SetReportParameter
    private void SetReportParameters()
    {
        String ReportTitle = "Hospital Wise Income Report";
        DateTime FooterDate = DateTime.Now;

        ReportParameter rptReportTitle = new ReportParameter("ReportTitle", ReportTitle);
        ReportParameter rptFooterDate = new ReportParameter("FooterDate", FooterDate.ToString());

        this.rvIncomeList.LocalReport.SetParameters(new ReportParameter[] { rptReportTitle, rptFooterDate });
    }
    #endregion SetReportParameter
}