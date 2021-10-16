<%@ Page Title="" Language="C#" MasterPageFile="~/AdminLayout.Master" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="水果销售网站.AdminLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="container" style="width: 30%">
        <div class="text-center">
            <div class="form-horizontal">
                <div class="form-group">
                    <label class="control-label col-sm-3">账号</label>
                    <div class="col-sm-7">
                        <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" Style="left: 0px; top: 0px"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-sm-3">密码</label>
                    <div class="col-sm-7">
                        <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" Style="left: 0px; top: 0px"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Button ID="btn_Login" runat="server" Text="登陆" CssClass="form-control" OnClick="btn_Login_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
