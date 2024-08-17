<%@ Page Title="" Language="C#" MasterPageFile="~/Default/MasterPage.master" AutoEventWireup="true" CodeFile="RPT_ACC_GNTransactionPatientReceipt.aspx.cs" Inherits="AdminPanel_Reports_RPT_ACC_GNTransaction_RPT_ACC_GNTransactionPatientReceipt" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=15.0.0.0, Culture=neutral, PublicKeyToken=89845DCD8080CC91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphPageHeader" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphBreadcrumb" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphPageContent" Runat="Server">
     <asp:ScriptManager ID="sm" runat="server">
 </asp:ScriptManager>
    <div>
    <rsweb:ReportViewer ID="rvPatientReceipt" runat="server" Width="100%" Height="800px" Visible="false">
        <LocalReport ReportPath="AdminPanel\Reports\RPT_ACC_GNTransaction\RPT_ACC_GNTransactionPatientReceipt.rdlc"></LocalReport>
    </rsweb:ReportViewer>
</div>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="cphScripts" Runat="Server">
</asp:Content>



