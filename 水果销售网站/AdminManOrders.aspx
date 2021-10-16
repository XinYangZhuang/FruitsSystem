<%@ Page Title="" Language="C#" MasterPageFile="~/AdminLayout.Master" AutoEventWireup="true" CodeBehind="AdminManOrders.aspx.cs" Inherits="水果销售网站.AdminManOrders" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td></td>
            <td>订单号:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                &nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="搜索" Width="73px" />
                &nbsp; &nbsp; </td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td colspan="7" rowspan="6">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id" Height="186px" Width="1060px">
                    <Columns>
                        <asp:BoundField DataField="Id" HeaderText="订单号" />
                        <asp:BoundField DataField="F_Name" HeaderText="商品名称" />
                        <asp:BoundField DataField="quantity" HeaderText="数量" />
                        <asp:BoundField DataField="totalprice" HeaderText="总价" />
                        <asp:BoundField DataField="pro" HeaderText="收货省份" />
                        <asp:BoundField DataField="city" HeaderText="收货城市" />
                        <asp:BoundField DataField="area" HeaderText="收货区域" />
                        <asp:BoundField DataField="address" HeaderText="收货地址" />
                        <asp:BoundField DataField="receiver" HeaderText="收件人" />
                        <asp:BoundField DataField="phone" HeaderText="电话" />
                        <asp:BoundField DataField="State" HeaderText="订单状态" />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton2" runat="server" CommandArgument='<%# Eval("Id") %>' OnClick="LinkButton2_Click">修改订单状态</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%# Eval("Id") %>' ForeColor="Red" OnClick="LinkButton1_Click">删除</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
