<%@ Page Title="" Language="C#" MasterPageFile="~/UserLayout.Master" AutoEventWireup="true" CodeBehind="MyCart.aspx.cs" Inherits="水果销售网站.MyCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td></td>
            <td>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="672px">
                    <Columns>
                        <asp:BoundField DataField="F_Name" HeaderText="商品名称" />
                        <asp:BoundField DataField="total_price" HeaderText="价格" />
                        <asp:BoundField DataField="quantity" HeaderText="数量" />
                        <asp:BoundField DataField="total_price" HeaderText="总价" />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton5" runat="server" CommandArgument='<%# Eval("Id") %>' Text="购买" OnClick="LinkButton5_Click"></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton6" runat="server" CommandArgument='<%# Eval("Id") %>' OnClick="LinkButton6_Click">删除</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td>
            <td></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;</p>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
