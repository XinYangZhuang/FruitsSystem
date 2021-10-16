<%@ Page Title="" Language="C#" MasterPageFile="~/AdminLayout.Master" AutoEventWireup="true" CodeBehind="AdminManUsr.aspx.cs" Inherits="水果销售网站.AdminManUsr" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
    <tr>
        <td>&nbsp;</td>
        <td>用户名称:<asp:TextBox ID="TextBox1" runat="server" Width="321px"></asp:TextBox>
&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="搜索" Width="59px" />
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td colspan="3">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Height="243px" Width="1069px">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="用户ID" />
                    <asp:BoundField DataField="U_Account" HeaderText="账户" />
                    <asp:BoundField DataField="U_PassWord" HeaderText="用户密码" />
                    <asp:BoundField DataField="UserName" HeaderText="用户姓名" />
                    <asp:BoundField DataField="Sex" HeaderText="性别" />
                    <asp:BoundField DataField="Job" HeaderText="工作" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%# Eval("Id") %>' OnClick="LinkButton1_Click1">注销</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </td>
    </tr>
</table>
</asp:Content>
