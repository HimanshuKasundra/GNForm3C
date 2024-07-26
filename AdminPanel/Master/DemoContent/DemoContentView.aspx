<%@ Page Title="" Language="C#" MasterPageFile="~/Default/MasterPageView.master" AutoEventWireup="true" CodeFile="DemoContentView.aspx.cs" Inherits="AdminPanel_Master_DemoContent_DemoContentView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="cntPageContent" ContentPlaceHolderID="cphPageContent" Runat="Server">
     <div class="portlet light">
         <div class="portlet-title">
             <div class="caption">
                 <asp:Label SkinID="lblViewFormHeaderIcon" ID="lblViewFormHeaderIcon" runat="server"></asp:Label>
                 <span class="caption-subject font-green-sharp bold uppercase">DemoContent ID </span>
             </div>
             <div class="tools">
                 <asp:HyperLink ID="CloseButton" SkinID="hlClosemymodal" runat="server" ClientIDMode="Static"></asp:HyperLink>
             </div>
         </div>
     <div class="portlet-body form">
         <div class="form-horizontal" role="form">
             <table class="table table-bordered table-advance table-hover">
                 <tr>
                     <td class="TDDarkView">
                         <asp:Label ID="lblDemoContentID_XXXXX" Text="DemoContent ID" runat="server"></asp:Label>
                     </td>
                     <td>
                         <asp:Label ID="lblDemoContentID" runat="server"></asp:Label>
                     </td>
                 </tr>
                 <tr>
                     <td class="TDDarkView">
                         <asp:Label ID="lblFirstName_XXXXX" Text="First Name" runat="server"></asp:Label>
                     </td>
                     <td>
                         <asp:Label ID="lblFirstName" runat="server"></asp:Label>
                     </td>
                 </tr>
                 <tr>
                     <td class="TDDarkView">
                         <asp:Label ID="lblLastName_XXXXX" Text="Last Name" runat="server"></asp:Label>
                     </td>
                     <td>
                         <asp:Label ID="lblLastName" runat="server"></asp:Label>
                     </td>
                 </tr>
                 <tr>
                     <td class="TDDarkView">
                         <asp:Label ID="lblSalary_XXXXX" Text="Salary" runat="server"></asp:Label>
                     </td>
                     <td>
                         <asp:Label ID="lblSalary" runat="server"></asp:Label>
                     </td>
                 </tr>
                 <tr>
                     <td class="TDDarkView">
                         <asp:Label ID="lblJoiningDate_XXXXX" Text="Joining Date" runat="server"></asp:Label>
                     </td>
                     <td>
                         <asp:Label ID="lblJoiningDate" runat="server"></asp:Label>
                     </td>
                 </tr>
                 <tr>
                     <td class="TDDarkView">
                         <asp:Label ID="lblCreated_XXXXX" Text="Created" runat="server"></asp:Label>
                     </td>
                     <td>
                         <asp:Label ID="lblCreated" runat="server"></asp:Label>
                     </td>
                 </tr>
                 <tr>
                     <td class="TDDarkView">
                         <asp:Label ID="lblModified_XXXXX" Text="Modified" runat="server"></asp:Label>
                     </td>
                     <td>
                         <asp:Label ID="lblModified" runat="server"></asp:Label>
                     </td>
                 </tr>
                 
             </table>
         </div>
     </div>
 </div>
</asp:Content>
<asp:Content ID="cntScripts" ContentPlaceHolderID="cphScripts" Runat="Server">
    <script>
    $(document).keyup(function (e) {
        if (e.keyCode == 27) {
            ;
            $("#CloseButton").trigger("click");
        }
    });
    </script>
</asp:Content>

