<%@ Page Title="" Language="C#" MasterPageFile="~/UserLayout.Master" AutoEventWireup="true" CodeBehind="LoginPanel.aspx.cs" Inherits="水果销售网站.LoginPanel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="container" style="width:30%">
        <div class="text-center" >
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
                    <asp:Button ID="btn_Register" runat="server" Text="注册" CssClass="form-control" OnClick="btn_Register_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
