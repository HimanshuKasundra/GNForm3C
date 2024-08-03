<%@ Page Title="" Language="C#" MasterPageFile="~/Default/MasterPageView.master" AutoEventWireup="true" CodeFile="MST_StudentAddEditPopup.aspx.cs" Inherits="AdminPanel_Master_MST_Student_MST_StudentAddEditPopup" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cphPageContent" runat="Server">
    <asp:ScriptManager ID="sm" runat="server" />
    <asp:UpdatePanel ID="upSTU_Student" runat="server" UpdateMode="Conditional" ChildrenAsTriggers="true">
        <contenttemplate>

            <div class="portlet light">
                <div class="portlet-title">
                    <div class="caption">
                        <asp:Label ID="lblFormHeader" runat="server" Text=""></asp:Label>
                    </div>
                    <div class="tools">
                        <a id="CloseButton" href="javascript:void(0);" class="close" onclick="hideModal();"></a>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-12">
                        <ucMessage:ShowMessage ID="ucMessage" runat="server" />
                        <asp:ValidationSummary ID="ValidationSummary1" SkinID="VS" runat="server" />
                    </div>
                </div>
                <div class="portlet-body form">
                    <div class="form-horizontal" role="form">
                        <div class="form-body">
                            <div class="form-group">
                                <label class="col-md-3 control-label">
                                    <span class="required">*</span>
                                    <asp:Label ID="lblStudentName_XXXXX" runat="server" Text="Student Name"></asp:Label>
                                </label>
                                <div class="col-md-5">
                                    <asp:TextBox ID="txtStudentName" CssClass="form-control" runat="server" PlaceHolder="Enter Student Name"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvStudentName" ControlToValidate="txtStudentName" Display="Dynamic" runat="server" ErrorMessage="Enter Student Name" ValidationGroup="vgStudent" EnableClientScript="true"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-md-3 control-label">
                                    <span class="required">*</span>
                                    <asp:Label ID="lblEnrollmentNo_XXXXX" runat="server" Text="Enrollment No"></asp:Label>
                                </label>
                                <div class="col-md-5">
                                    <asp:TextBox ID="txtEnrollmentNo" CssClass="form-control" runat="server" PlaceHolder="Enter Enrollment No"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvEnrollmentNo" ControlToValidate="txtEnrollmentNo" Display="Dynamic" runat="server" ErrorMessage="Enter Enrollment No" ValidationGroup="vgStudent" EnableClientScript="true"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-md-3 control-label">
                                    <span class="required">*</span>
                                    <asp:Label ID="lblCurrentSem_XXXXX" runat="server" Text="Current Sem"></asp:Label>
                                </label>
                                <div class="col-md-5">
                                    <asp:DropDownList ID="ddlCurrentSem" CssClass="form-control select2me" runat="server"></asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="rfvCurrentSem" ControlToValidate="ddlCurrentSem" Display="Dynamic" runat="server" ErrorMessage="Select Current Sem" InitialValue="-99" ValidationGroup="vgStudent" EnableClientScript="true"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-md-3 control-label">
                                    <asp:Label ID="lblEmailInstitute_XXXXX" runat="server" Text="Email Institute"></asp:Label>
                                </label>
                                <div class="col-md-5">
                                    <asp:TextBox ID="txtEmailInstitute" CssClass="form-control" runat="server" PlaceHolder="Enter Email Institute"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-md-3 control-label">
                                    <span class="required">*</span>
                                    <asp:Label ID="lblEmailPersonal_XXXXX" runat="server" Text="Email Personal"></asp:Label>
                                </label>
                                <div class="col-md-5">
                                    <asp:TextBox ID="txtEmailPersonal" CssClass="form-control" runat="server" PlaceHolder="Enter Email Personal"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvEmailPersonal" ControlToValidate="txtEmailPersonal" Display="Dynamic" runat="server" ErrorMessage="Enter Email Personal" ValidationGroup="vgStudent" EnableClientScript="true"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-md-3 control-label">
                                    <span class="required">*</span>
                                    <asp:Label ID="lblGender" runat="server" Text="Gender"></asp:Label>
                                </label>
                                <div class="col-md-5">
                                    <asp:DropDownList ID="ddlGender" CssClass="form-control select2me" runat="server"></asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="rfvGender" ControlToValidate="ddlGender" Display="Dynamic" runat="server" ErrorMessage="Select Gender" InitialValue="-99" ValidationGroup="vgStudent" EnableClientScript="true"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-md-3 control-label">
                                    <asp:Label ID="lblRollNo_XXXXX" runat="server" Text="Roll No"></asp:Label>
                                </label>
                                <div class="col-md-5">
                                    <asp:TextBox ID="txtRollNo" CssClass="form-control" runat="server" onkeypress="return IsPositiveInteger(event)" PlaceHolder="Enter RollNo"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-md-3 control-label">
                                    <span class="required">*</span>
                                    <asp:Label ID="lblBirthDate_XXXXX" runat="server" Text="Birth Date"></asp:Label>
                                </label>
                                <div class="col-md-5">
                                    <div class="input-group input-medium date date-picker" data-date-format='<%=GNForm3C.CV.DefaultHTMLDateFormat.ToString()%>'>
                                        <asp:TextBox ID="dtpBirthDate" CssClass="form-control" runat="server" placeholder="Birth Date"></asp:TextBox>
                                        <span class="input-group-btn">
                                            <button class="btn default" type="button"><i class="fa fa-calendar"></i></button>
                                        </span>
                                    </div>
                                    <asp:RequiredFieldValidator ID="rfvBirthDate" ControlToValidate="dtpBirthDate" Display="Dynamic" runat="server" ErrorMessage="Enter Birth Date" ValidationGroup="vgStudent" EnableClientScript="true"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-md-3 control-label">
                                    <span class="required">*</span>
                                    <asp:Label ID="lblContactNo" runat="server" Text="Contact No"></asp:Label>
                                </label>
                                <div class="col-md-5">
                                    <asp:TextBox ID="txtContactNo" CssClass="form-control" runat="server" PlaceHolder="Enter Contact No"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvContactNo" ControlToValidate="txtContactNo" Display="Dynamic" runat="server" ErrorMessage="Enter Contact No" ValidationGroup="vgStudent" EnableClientScript="true"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                        </div>
                        <div class="form-actions">
                            <div class="row">
                                <div class="col-md-offset-3 col-md-9">
                                    <asp:Button ID="btnSave" SkinID="btnSave" runat="server" OnClick="btnSave_Click" Text="Save" />
                                    <asp:HyperLink ID="hlCancel" SkinID="hlCancel" runat="server" NavigateUrl="~/AdminPanel/Master/MST_Student/MST_StudentList.aspx" Text="Cancel"></asp:HyperLink>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </contenttemplate>
    </asp:UpdatePanel>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="cphScripts" runat="Server">
    <script>
        function showModal() {
            $('#view').modal('show');
        }

        function hideModal() {
            $('#view').modal('hide');
        }

        $(document).ready(function () {
            // Initialize modal visibility
            showModal();
        });

        $(document).keyup(function (e) {
            if (e.keyCode == 27) {
                hideModal();
            }
        });
    </script>
</asp:Content>
