<%@ Page Title="" Language="C#" MasterPageFile="~/UserLayout.Master" AutoEventWireup="true" CodeBehind="FruitView.aspx.cs" Inherits="水果销售网站.FruitView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList1" runat="server" CellSpacing="10" RepeatColumns="5" RepeatDirection="Horizontal">
    <ItemTemplate>
        <table style="width:100%;">
            <tr>
                <td colspan="3">
                    <asp:Image ID="Image2" runat="server" Height="291px" ImageUrl='<%# Eval("F_Image") %>' Width="220px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("F_Name") %>'></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" CommandArgument='<%# Eval("Id") %>' OnClick="Button1_Click" Text="查看详情" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </ItemTemplate>
</asp:DataList>
</asp:Content>
