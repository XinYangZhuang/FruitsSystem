<%@ Page Title="" Language="C#" MasterPageFile="~/UserLayout.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="水果销售网站.Home" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 33px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div style=" width: 50%;">
                 <asp:Image ID="Image1" runat="server" Height="418px" ImageUrl="~/Image/indeximg.jpg" Width="1130px" />
            </div>
        <div class="container">
        <div class="row">
           <h1>热卖商品</h1>
            <div>
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
                                    <asp:Button ID="Button1" runat="server" CommandArgument='<%# Eval("F_Fruits_id") %>' OnClick="Button1_Click" Text="查看详情" />
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
            </div>
            </div>
    </div>
</asp:Content>
