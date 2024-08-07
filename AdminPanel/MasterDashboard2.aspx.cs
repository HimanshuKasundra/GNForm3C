﻿using GNForm3C;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminPanel_MasterDashboard2 : System.Web.UI.Page
{
    #region 10.0 Local Variables

    static Int32 PageRecordSize = CV.PageRecordSize;//Size of record per page   

    #endregion 10.0 Local Variables

    #region 11.0 Page Load Event
    protected void Page_Load(object sender, EventArgs e)
    {
        #region 11.0 Check User Login

        if (Session["UserID"] == null)
            Response.Redirect(CV.LoginPageURL);

        #endregion 11.0 Check User Login

        if (!Page.IsPostBack)
        {
            #region 11.1 DropDown List Fill Section

            FillDropDownList();

            #endregion 11.1 DropDown List Fill Section

            #region 11.2 Set Default Value 
            lblSearchHeader.Text = CV.SearchHeaderText;

            upr.DisplayAfter = CV.UpdateProgressDisplayAfter;

            #endregion 11.2 Set Default Value 


            #region 11.3 Set Help Text
            ucHelp.ShowHelp("Help Text will be shown here");
            #endregion 12.3 Set Help Text
        }
    }


    #endregion 11.0 Page Load Event 

    #region 12.0 Search
    protected void Search(int page)
    {
        if (ddlFinYearID.SelectedIndex > 0)
        {
            SqlInt32 FinYearID = (SqlInt32)Convert.ToInt32(ddlFinYearID.SelectedValue);

            upDashboard.Visible = true;

            MasterDashboard2BAL balMasterDashboard2 = new MasterDashboard2BAL();

            DataTable dtCount = balMasterDashboard2.SelectCount(FinYearID);

            lblIncomeCount.Text = string.Format(GNForm3C.CV.DefaultCurrencyFormatWithDecimalPoint, Convert.ToDecimal(dtCount.Rows[0]["IncomeCount"].ToString()));
            lblExpenseCount.Text = string.Format(GNForm3C.CV.DefaultCurrencyFormatWithDecimalPoint, Convert.ToDecimal(dtCount.Rows[0]["ExpenseCount"].ToString()));
            lblDifferenceCount.Text = string.Format(GNForm3C.CV.DefaultCurrencyFormatWithDecimalPoint, Convert.ToDecimal(dtCount.Rows[0]["DifferenceCount"].ToString()));

            BindCategoryWiseIncomeTotalList(FinYearID);
            BindCategoryWiseExpenseTotalList(FinYearID);
            BindHospitalWisePatientCountList(FinYearID);
            BindAccountTranscationList(FinYearID);

        }

    }
    protected void displayChange(object sender, EventArgs e)
    {
        if (ddlFinYearID.SelectedIndex <= 0)
        {
            upDashboard.Visible = false;
        }
    }
    protected void btnShow_Click(object sender, EventArgs e)
    {
        //upDashboard.Visible = true;
        Search(1);

    }
    #endregion 12.0 Search

    #region 13.0 BindTable

    #region 13.1 BindCategoryWiseIncomeTotalList
    private void BindCategoryWiseIncomeTotalList(SqlInt32 FinYearID)
    {
        upDashboard.Visible = true;
        MasterDashboard2BAL balMasterDashboard2 = new MasterDashboard2BAL();

        DataTable dtCategoryWiseIncomeTotalList = balMasterDashboard2.CategoryWiseIncomeTotalList(FinYearID);

        if (dtCategoryWiseIncomeTotalList.Rows.Count > 0)
        {
            rpCategoryWiseIncomeTotalList.DataSource = dtCategoryWiseIncomeTotalList;
            rpCategoryWiseIncomeTotalList.DataBind();

            lblNoCategoryWiseIncomeTotalListRecords.Visible = false;
            CategoryWiseIncomeTotalList.Visible = true;
        }
        else
        {
            lblNoCategoryWiseIncomeTotalListRecords.Visible = true;
            CategoryWiseIncomeTotalList.Visible = false;
        }


    }

    #endregion 13.1 BindCategoryWiseIncomeTotalList
    #region 13.2 BindExpense

    private void BindCategoryWiseExpenseTotalList(SqlInt32 FinYearID)
    {
        upDashboard.Visible = true;
        MasterDashboard2BAL balMasterDashboard2 = new MasterDashboard2BAL();

        DataTable dtCategoryWiseExpenseTotalList = balMasterDashboard2.CategoryWiseExpenseTotalList(FinYearID);

        if (dtCategoryWiseExpenseTotalList.Rows.Count > 0)
        {
            rpCategoryWiseExpenseTotalList.DataSource = dtCategoryWiseExpenseTotalList;
            rpCategoryWiseExpenseTotalList.DataBind();

            lblNoCategoryWiseExpenseTotalListRecords.Visible = false;
            CategoryWiseExpenseTotalList.Visible = true;
        }
        else
        {

            lblNoCategoryWiseExpenseTotalListRecords.Visible = true;
            CategoryWiseExpenseTotalList.Visible = false;
        }


    }
    #endregion 13.2 BindExpense

    #region 13.3 BindHospitalWisePatientCountList
    private void BindHospitalWisePatientCountList(SqlInt32 FinYearID)
    {
        upDashboard.Visible = true;
        MasterDashboard2BAL balMasterDashboard2 = new MasterDashboard2BAL();

        DataTable dtHospitalWisePatientCountList = balMasterDashboard2.HospitalWisePatientCountList(FinYearID);

        if (dtHospitalWisePatientCountList.Rows.Count > 0)
        {
            rpHospitalWisePatientCountList.DataSource = dtHospitalWisePatientCountList;
            rpHospitalWisePatientCountList.DataBind();

            lblNoHospitalWisePatientCountListRecords.Visible = false;
            HospitalWisePatientCountList.Visible = true;
        }
        else
        {

            lblNoHospitalWisePatientCountListRecords.Visible = true;
            HospitalWisePatientCountList.Visible = false;
        }


    }
    #endregion 13.3 BindHospitalWisePatientCountList
    #region 13.4 BindAccountTranscationList

    private void BindAccountTranscationList(SqlInt32 FinYearID)
    {
        upDashboard.Visible = true;
        MasterDashboard2BAL balMasterDashboard2 = new MasterDashboard2BAL();

        DataTable dtAccountTranscationList = balMasterDashboard2.AccountTranscationList(FinYearID);

        if (dtAccountTranscationList.Rows.Count > 0)
        {
            rpAccountTranscationList.DataSource = dtAccountTranscationList;
            rpAccountTranscationList.DataBind();

            lblNoAccountTranscationListRecords.Visible = false;
            AccountTranscationList.Visible = true;
        }
        else
        {

            lblNoAccountTranscationListRecords.Visible = true;
            AccountTranscationList.Visible = false;
        }


    }


    #endregion 13.4 BindAccountTranscationList

    #endregion BindTable

    #region 14.0 DropDownList

    #region 14.1 Fill DropDownList
    private void FillDropDownList()
    {
        CommonFillMethods.FillSingleDropDownListFinYearID(ddlFinYearID);
    }
    #endregion 14.1 Fill DropDownList

    #endregion 14.0 DropDownList
}