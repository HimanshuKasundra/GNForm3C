﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Default/MasterPage.master" AutoEventWireup="true" CodeFile="ACC_GNTransactionList.aspx.cs" Inherits="AdminPanel_Account_ACC_GNTransaction_ACC_GNTransactionList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphPageHeader" runat="Server">
    <asp:Label ID="lblPageHeader_XXXXX" runat="server" Text="Transaction"></asp:Label>
    <small>
        <asp:Label ID="lblPageHeaderInfo_XXXXX" runat="server" Text="Account"></asp:Label></small>
    <span class="pull-right">
        <small>
            <asp:HyperLink ID="hlShowHelp" SkinID="hlShowHelp" runat="server"></asp:HyperLink>
        </small>
    </span>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphBreadcrumb" runat="Server">
    <li>
        <i class="fa fa-home"></i>
        <asp:HyperLink ID="hlHome" runat="server" NavigateUrl="~/AdminPanel/Default.aspx" Text="Home"></asp:HyperLink>
        <i class="fa fa-angle-right"></i>
    </li>
    <li class="active">
        <asp:Label ID="lblBreadCrumbLast" runat="server" Text="Transaction"></asp:Label>
    </li>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphPageContent" runat="Server">
    <!--Help Text-->
    <ucHelp:ShowHelp ID="ucHelp" runat="server" />
    <!--Help Text End-->
    <asp:ScriptManager ID="sm" runat="server">
    </asp:ScriptManager>

    <%-- Search --%>
    <asp:UpdatePanel ID="upApplicationFeature" runat="server">
        <ContentTemplate>
            <div class="portlet light">
                <div class="portlet-title">
                    <div class="caption">
                        <asp:Label SkinID="lblSearchHeaderIcon" runat="server"></asp:Label>
                        <asp:Label ID="lblSearchHeader" SkinID="lblSearchHeaderText" runat="server"></asp:Label>
                    </div>
                    <div class="tools">
                        <a href="javascript:;" class="collapse pull-right"></a>
                    </div>
                </div>
                <div class="portlet-body form">
                    <div role="form">
                        <div class="form-body">
                            <div class="row">
                                <div class="col-md-4">
                                    <div class="form-group">
                                        <div class="input-group">
                                            <span class="input-group-addon">
                                                <i class="fa fa-search"></i>
                                            </span>
                                            <asp:TextBox ID="txtPatient" CssClass="First form-control" runat="server" PlaceHolder="Enter Patient"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-4">
                                    <div class="form-group">
                                        <div class="input-group">
                                            <span class="input-group-addon">
                                                <i class="fa fa-search"></i>
                                            </span>
                                            <asp:DropDownList ID="ddlTreatmentID" CssClass="form-control select2me" runat="server"></asp:DropDownList>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-4">
                                    <div class="form-group">
                                        <div class="input-group">
                                            <span class="input-group-addon">
                                                <i class="fa fa-search"></i>
                                            </span>
                                            <asp:TextBox ID="txtAmount" CssClass="form-control" runat="server" PlaceHolder="Enter Amount"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-4">
                                    <div class="form-group">
                                        <div class="input-group">
                                            <span class="input-group-addon">
                                                <i class="fa fa-search"></i>
                                            </span>
                                            <asp:TextBox ID="txtSerialNo" CssClass="form-control" runat="server" PlaceHolder="Enter Serial No"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-4">
                                    <div class="form-group">
                                        <div class="input-group">
                                            <span class="input-group-addon">
                                                <i class="fa fa-search"></i>
                                            </span>
                                            <asp:TextBox ID="txtReferenceDoctor" CssClass="form-control" runat="server" PlaceHolder="Enter Reference Doctor"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-4">
                                    <div class="form-group">
                                        <div class="input-group">
                                            <span class="input-group-addon">
                                                <i class="fa fa-search"></i>
                                            </span>
                                            <asp:TextBox ID="txtCount" CssClass="form-control" runat="server" PlaceHolder="Enter Count"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-4">
                                    <div class="form-group">
                                        <div class="input-group">
                                            <span class="input-group-addon">
                                                <i class="fa fa-search"></i>
                                            </span>
                                            <asp:TextBox ID="txtReceiptNo" CssClass="form-control" runat="server" PlaceHolder="Enter Receipt No"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-4">
                                    <div class="form-group">
                                        <div class="input-group date date-picker" data-date-format="dd-mm-yyyy">
                                            <span class="input-group-btn">
                                                <button class="btn default" type="button"><i class="fa fa-calendar"></i></button>
                                            </span>
                                            <asp:TextBox ID="dtpDate" CssClass="form-control" runat="server" placeholder="Date"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-4">
                                    <div class="form-group">
                                        <div class="input-group date date-picker" data-date-format="dd-mm-yyyy">
                                            <span class="input-group-btn">
                                                <button class="btn default" type="button"><i class="fa fa-calendar"></i></button>
                                            </span>
                                            <asp:TextBox ID="dtpDateOfAdmission" CssClass="form-control" runat="server" placeholder="Date Of Admission"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-4">
                                    <div class="form-group">
                                        <div class="input-group date date-picker" data-date-format="dd-mm-yyyy">
                                            <span class="input-group-btn">
                                                <button class="btn default" type="button"><i class="fa fa-calendar"></i></button>
                                            </span>
                                            <asp:TextBox ID="dtpDateOfDischarge" CssClass="form-control" runat="server" placeholder="Date Of Discharge"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-4">
                                    <div class="form-group">
                                        <div class="input-group">
                                            <span class="input-group-addon">
                                                <i class="fa fa-search"></i>
                                            </span>
                                            <asp:TextBox ID="txtDeposite" CssClass="form-control" runat="server" PlaceHolder="Enter Deposite"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-4">
                                    <div class="form-group">
                                        <div class="input-group">
                                            <span class="input-group-addon">
                                                <i class="fa fa-search"></i>
                                            </span>
                                            <asp:TextBox ID="txtNetAmount" CssClass="form-control" runat="server" PlaceHolder="Enter Net Amount"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-4">
                                    <div class="form-group">
                                        <div class="input-group">
                                            <span class="input-group-addon">
                                                <i class="fa fa-search"></i>
                                            </span>
                                            <asp:TextBox ID="txtNoOfDays" CssClass="form-control" runat="server" PlaceHolder="Enter No Of Days"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-4">
                                    <div class="form-group">
                                        <div class="input-group">
                                            <span class="input-group-addon">
                                                <i class="fa fa-search"></i>
                                            </span>
                                            <asp:DropDownList ID="ddlHospitalID" CssClass="form-control select2me" runat="server"></asp:DropDownList>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-4">
                                    <div class="form-group">
                                        <div class="input-group">
                                            <span class="input-group-addon">
                                                <i class="fa fa-search"></i>
                                            </span>
                                            <asp:DropDownList ID="ddlFinYearID" CssClass="form-control select2me" runat="server"></asp:DropDownList>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-4">
                                    <div class="form-group">
                                        <div class="input-group">
                                            <span class="input-group-addon">
                                                <i class="fa fa-search"></i>
                                            </span>
                                            <asp:DropDownList ID="ddlReceiptTypeID" CssClass="form-control select2me" runat="server"></asp:DropDownList>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="form-actions">
                            <div class="row">
                                <div class="col-md-9">
                                    <asp:Button ID="btnSearch" SkinID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
                                    <asp:Button ID="btnClear" runat="server" SkinID="btnClear" Text="Clear" OnClick="btnClear_Click" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
    <%-- End Search --%>

    <%-- List --%>
    <asp:UpdatePanel ID="upList" runat="server" UpdateMode="Conditional">
        <ContentTemplate>
            <div class="row">
                <div class="col-md-12">
                    <ucMessage:ShowMessage ID="ucMessage" runat="server" ViewStateMode="Disabled" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <!-- BEGIN EXAMPLE TABLE PORTLET-->
                    <div class="portlet light">
                        <div class="portlet-title">
                            <div class="caption">
                                <asp:Label SkinID="lblSearchResultHeaderIcon" runat="server"></asp:Label>
                                <asp:Label ID="lblSearchResultHeader" SkinID="lblSearchResultHeaderText" runat="server"></asp:Label>
                                <label class="control-label">&nbsp;</label>
                                <label class="control-label pull-right">
                                    <asp:Label ID="lblRecordInfoTop" Text="No entries found" CssClass="pull-right" runat="server"></asp:Label>
                                </label>
                            </div>
                            <div class="tools">
                                <div>
                                    <asp:HyperLink SkinID="hlAddNew" ID="hlAddNew" NavigateUrl="~/AdminPanel/Account/ACC_Transaction/ACC_TransactionAddEdit.aspx" runat="server"></asp:HyperLink>
                                    <div class="btn-group" runat="server" id="Div_ExportOption" visible="false">
                                        <button class="btn dropdown-toggle" data-toggle="dropdown">
                                            Export <i class="fa fa-angle-down"></i>
                                        </button>
                                        <ul class="dropdown-menu pull-right">
                                            <li>
                                                <asp:LinkButton ID="lbtnExportPDF" runat="server" CommandArgument="PDF" OnClick="lbtnExport_Click">PDF</asp:LinkButton>
                                            </li>
                                            <li>
                                                <asp:LinkButton ID="lbtnExportExcel" runat="server" CommandArgument="Excel" OnClick="lbtnExport_Click">Excel</asp:LinkButton>
                                            </li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="portlet-body">
                            <div class="row" runat="server" id="Div_SearchResult" visible="false">
                                <div class="col-md-12">
                                    <div id="TableContent">
                                        <table class="table table-bordered table-advanced table-striped table-hover" id="sample_1">
                                            <%-- Table Header --%>
                                            <thead>
                                                <tr class="TRDark">
                                                    <th>
                                                        <asp:Label ID="lbhPatient" runat="server" Text="Patient"></asp:Label>
                                                    </th>
                                                    <th>
                                                        <asp:Label ID="lbhTreatmentID" runat="server" Text="Treatment"></asp:Label>
                                                    </th>
                                                    <th>
                                                        <asp:Label ID="lbhAmount" runat="server" Text="Amount"></asp:Label>
                                                    </th>
                                                    <th>
                                                        <asp:Label ID="lbhSerialNo" runat="server" Text="Serial No"></asp:Label>
                                                    </th>
                                                    <th>
                                                        <asp:Label ID="lbhReferenceDoctor" runat="server" Text="Reference Doctor"></asp:Label>
                                                    </th>
                                                    <th>
                                                        <asp:Label ID="lbhCount" runat="server" Text="Count"></asp:Label>
                                                    </th>
                                                    <th>
                                                        <asp:Label ID="lbhReceiptNo" runat="server" Text="Receipt No"></asp:Label>
                                                    </th>
                                                    <th class="text-center">
                                                        <asp:Label ID="lbhDate" runat="server" Text="Date"></asp:Label>
                                                    </th>
                                                    <th>
                                                        <asp:Label ID="lbhDateOfAdmission" runat="server" Text="Date Of Admission"></asp:Label>
                                                    </th>
                                                    <th>
                                                        <asp:Label ID="lbhDateOfDischarge" runat="server" Text="Date Of Discharge"></asp:Label>
                                                    </th>
                                                    <th>
                                                        <asp:Label ID="lbhDeposite" runat="server" Text="Deposite"></asp:Label>
                                                    </th>
                                                    <th>
                                                        <asp:Label ID="lbhNetAmount" runat="server" Text="Net Amount"></asp:Label>
                                                    </th>
                                                    <th>
                                                        <asp:Label ID="lbhNoOfDays" runat="server" Text="No Of Days"></asp:Label>
                                                    </th>
                                                    <th>
                                                        <asp:Label ID="lbhHospitalID" runat="server" Text="Hospital"></asp:Label>
                                                    </th>
                                                    <th>
                                                        <asp:Label ID="lbhFinYearID" runat="server" Text="Fin Year"></asp:Label>
                                                    </th>
                                                    <th>
                                                        <asp:Label ID="lbhReceiptTypeID" runat="server" Text="Receipt Type"></asp:Label>
                                                    </th>
                                                    <th class="nosortsearch text-nowrap text-center">
                                                        <asp:Label ID="lbhAction" runat="server" Text="Action"></asp:Label>
                                                    </th>
                                                </tr>
                                            </thead>
                                            <%-- END Table Header --%>

                                            <tbody>
                                                <asp:Repeater ID="rpData" runat="server" OnItemCommand="rpData_ItemCommand">
                                                    <ItemTemplate>
                                                        <%-- Table Rows --%>
                                                        <tr class="odd gradeX">
                                                            <td>
                                                                <asp:HyperLink ID="hlViewTransactionID" NavigateUrl='<%# "~/AdminPanel/Account/ACC_Transaction/ACC_TransactionView.aspx?TransactionID=" + GNForm3C.CommonFunctions.EncryptBase64(Eval("TransactionID").ToString()) %>' data-target="#viewiFrameReg" CssClass="modalButton" data-toggle="modal" runat="server"><%#Eval("Patient") %></asp:HyperLink>
                                                            </td>
                                                            <td>
                                                                <%#Eval("Treatment") %>
                                                            </td>
                                                            <td>
                                                                <%#Eval("Amount",GNForm3C.CV.DefaultCurrencyFormatWithOutDecimalPoint) %>
                                                            </td>
                                                            <td>
                                                                <%#Eval("SerialNo") %>
                                                            </td>
                                                            <td>
                                                                <%#Eval("ReferenceDoctor") %>
                                                            </td>
                                                            <td>
                                                                <%#Eval("Count") %>
                                                            </td>
                                                            <td>
                                                                <%#Eval("ReceiptNo") %>
                                                            </td>
                                                            <td class="text-center">
                                                                <%#Eval("Date", GNForm3C.CV.DefaultDateFormatForGrid) %>
                                                            </td>
                                                            <td>
                                                                <%#Eval("DateOfAdmission") %>
                                                            </td>
                                                            <td>
                                                                <%#Eval("DateOfDischarge") %>
                                                            </td>
                                                            <td>
                                                                <%#Eval("Deposite") %>
                                                            </td>
                                                            <td>
                                                                <%#Eval("NetAmount",GNForm3C.CV.DefaultCurrencyFormatWithOutDecimalPoint) %>
                                                            </td>
                                                            <td>
                                                                <%#Eval("NoOfDays") %>
                                                            </td>
                                                            <td>
                                                                <%#Eval("Hospital") %>
                                                            </td>
                                                            <td>
                                                                <%#Eval("FinYearName") %>
                                                            </td>
                                                            <td>
                                                                <%#Eval("ReceiptTypeName") %>
                                                            </td>
                                                            <td class="text-nowrap text-center">
                                                                <asp:HyperLink ID="hlView" SkinID="View" NavigateUrl='<%# "~/AdminPanel/Account/ACC_Transaction/ACC_TransactionView.aspx?TransactionID=" + GNForm3C.CommonFunctions.EncryptBase64(Eval("TransactionID").ToString()) %>' data-target="#viewiFrameReg" data-toggle="modal" runat="server"></asp:HyperLink>
                                                                <asp:HyperLink ID="hlEdit" SkinID="Edit" NavigateUrl='<%# "~/AdminPanel/Account/ACC_Transaction/ACC_TransactionAddEdit.aspx?TransactionID=" + GNForm3C.CommonFunctions.EncryptBase64(Eval("TransactionID").ToString()) %>' runat="server"></asp:HyperLink>
                                                                <asp:LinkButton ID="lbtnDelete" runat="server"
                                                                    SkinID="Delete"
                                                                    OnClientClick="javascript:return confirm('Are you sure you want to delete record ? ');"
                                                                    CommandName="DeleteRecord"
                                                                    CommandArgument='<%#Eval("TransactionID") %>'>
                                                                </asp:LinkButton>
                                                            </td>
                                                        </tr>
                                                        <%-- END Table Rows --%>
                                                    </ItemTemplate>
                                                </asp:Repeater>
                                            </tbody>
                                        </table>
                                    </div>

                                    <%-- Pagination --%>
                                    <div class="row">
                                        <div class="col-md-4">
                                            <label class="control-label">
                                                <asp:Label ID="lblRecordInfoBottom" Text="No entries found" runat="server"></asp:Label></label>
                                        </div>
                                        <div class="col-md-5">
                                            <div class="dataTables_paginate paging_simple_numbers" runat="server" id="Div_Pagination">
                                                <ul class="pagination">
                                                    <li class="paginate_button previous disabled" id="liFirstPage" runat="server">
                                                        <asp:LinkButton ID="lbtnFirstPage" Enabled="false" OnClick="PageChange_Click" CommandName="FirstPage" CommandArgument="1" runat="server"><i class="fa fa-angle-double-left"></i></asp:LinkButton></li>
                                                    <li class="paginate_button previous disabled" id="liPrevious" runat="server">
                                                        <asp:LinkButton ID="lbtnPrevious" Enabled="false" OnClick="PageChange_Click" CommandArgument="1" CommandName="PreviousPage" runat="server"><i class="fa fa-angle-left"></i></asp:LinkButton></li>
                                                    <asp:Repeater ID="rpPagination" runat="server" OnItemDataBound="rpPagination_ItemDataBound">
                                                        <ItemTemplate>
                                                            <li>
                                                                <li class="paginate_button" id="liPageNo" runat="server">
                                                                    <asp:LinkButton ID="lbtnPageNo" runat="server" OnClick="PageChange_Click" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "PageNo")%>' CommandName="PageNo"><%# DataBinder.Eval(Container.DataItem, "PageNo")%></asp:LinkButton></li>
                                                            </li>
                                                        </ItemTemplate>
                                                    </asp:Repeater>
                                                    <li class="paginate_button next disabled" id="liNext" runat="server">
                                                        <asp:LinkButton ID="lbtnNext" Enabled="false" OnClick="PageChange_Click" CommandArgument="1" CommandName="NextPage" runat="server"><i class="fa fa-angle-right"></i></asp:LinkButton></li>
                                                    <li class="paginate_button previous disabled" id="liLastPage" runat="server">
                                                        <asp:LinkButton ID="lbtnLastPage" Enabled="false" OnClick="PageChange_Click" CommandName="LastPage" CommandArgument="-99" runat="server"><i class="fa fa-angle-double-right"></i></asp:LinkButton></li>
                                                </ul>
                                            </div>
                                        </div>
                                        <div class="col-md-3 pull-right">
                                            <div class="btn-group" runat="server" id="Div_GoToPageNo">
                                                <asp:TextBox ID="txtPageNo" placeholder="Page No" onkeypress="return IsNumeric(event)" runat="server" CssClass="pagination-panel-input form-control input-xsmall input-inline col-md-4" MaxLength="9"></asp:TextBox>
                                                <asp:LinkButton ID="lbtnGoToPageNo" runat="server" CssClass="btn btn-default input-inline col-md-4" CommandName="GoPageNo" CommandArgument="0" OnClick="PageChange_Click">Go</asp:LinkButton>
                                            </div>
                                            <div class="btn-group pull-right" runat="server" id="Div_PageSize">
                                                <label class="control-label">Page Size</label>
                                                <asp:DropDownList ID="ddlPageSizeBottom" AutoPostBack="true" CssClass="form-control input-xsmall" runat="server" OnSelectedIndexChanged="ddlPageSizeBottom_SelectedIndexChanged">
                                                </asp:DropDownList>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">
                                    </div>
                                    <%-- END Pagination --%>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- END EXAMPLE TABLE PORTLET-->
                </div>
            </div>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="btnSearch" EventName="Click" />
            <asp:AsyncPostBackTrigger ControlID="btnClear" EventName="Click" />
            <asp:PostBackTrigger ControlID="lbtnExportExcel" />
            <asp:PostBackTrigger ControlID="lbtnExportPDF" />
        </Triggers>
    </asp:UpdatePanel>
    <%-- END List --%>

    <%-- Loading  --%>
    <asp:UpdateProgress ID="upr" runat="server">
        <ProgressTemplate>
            <div class="divWaiting">
                <asp:Label ID="lblWait" runat="server" Text=" Please wait... " />
                <asp:Image ID="imgWait" runat="server" SkinID="UpdatePanelLoding" />
            </div>
        </ProgressTemplate>
    </asp:UpdateProgress>
    <%-- END Loading  --%>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="cphScripts" runat="Server">
    <script>

        $(window).keydown(function (e) {
            GNWebKeyEvents(e.keyCode, '<%=hlAddNew.ClientID%>', '<%=btnSearch.ClientID%>');
        });

        SearchGridUI('<%=btnSearch.ClientID%>', 'sample_1', 1);
    </script>
</asp:Content>


