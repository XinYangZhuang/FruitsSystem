<%@ Page Title="" Language="C#" MasterPageFile="~/UserLayout.Master" AutoEventWireup="true" CodeBehind="RegisterPanel.aspx.cs" Inherits="水果销售网站.RegisterPanel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container" style="width: 30%">
        <div class="text-center">
            <div class="form-horizontal">
                <div class="form-group">
                    <label class="control-label col-sm-3">账号:</label>
                    <div class="col-sm-7">
                        <asp:TextBox ID="tbx_account" runat="server" CssClass="form-control" Style="left: 0px; top: 0px"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-sm-3">密码:</label>
                    <div class="col-sm-7">
                        <asp:TextBox ID="tbx_pass" runat="server" CssClass="form-control" Style="left: 0px; top: 0px" TextMode="Password"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-sm-3">重复:</label>
                    <div class="col-sm-7">
                        <asp:TextBox ID="tbx_repass" runat="server" CssClass="form-control" Style="left: 0px; top: 0px" TextMode="Password"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-sm-3">昵称:</label>
                    <div class="col-sm-7">
                        <asp:TextBox ID="tbx_name" runat="server" CssClass="form-control" Style="left: 0px; top: 0px"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-sm-3">性别:</label>
                    <div class="col-sm-7">
                        <asp:TextBox ID="tbx_sex" runat="server" CssClass="form-control" Style="left: 0px; top: 0px"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-sm-3">工作:</label>
                    <div class="col-sm-7">
                        <asp:TextBox ID="tbx_job" runat="server" CssClass="form-control" Style="left: 0px; top: 0px"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-sm-3">地址:</label>
                    <div class="col-sm-7">
                        <asp:TextBox ID="tbx_adress" runat="server" CssClass="form-control" Style="left: 0px; top: 0px"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-sm-3">头像:</label>
                    <div class="col-sm-7">
                        <asp:FileUpload ID="FileUpload1" runat="server" CssClass="form-control" />
                    </div>
                </div>
                <div class="form-group">
                    <asp:Button ID="Button1" runat="server" Text="立即注册" CssClass="form-control" OnClick="Button1_Click" />
                    <asp:Button ID="Button2" runat="server" Text="返回登陆" CssClass="form-control" OnClick="Button2_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
