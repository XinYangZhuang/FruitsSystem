<%@ Page Title="" Language="C#" MasterPageFile="~/AdminLayout.Master" AutoEventWireup="true" CodeBehind="AdminChangeOrderStatus.aspx.cs" Inherits="水果销售网站.AdminChangeOrderStatus" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
        }
        .auto-style2 {
            width: 81px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td class="auto-style1" colspan="2"><strong>修改订单状态</strong></td>
            <td>&nbsp;</td>
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
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
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
            <td colspan="12">
                <table style="width:100%;">
                    <tr>
                        <td>订单号</td>
                        <td>商品名称</td>
                        <td>总价</td>
                        <td>收货省份</td>
                        <td>收货城市</td>
                        <td>收货区域</td>
                        <td>收件人</td>
                        <td>电话</td>
                        <td colspan="2">订单状态</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lbl_orderid" runat="server" Text="Label"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="lbl_fname" runat="server" Text="Label"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="lbl_totalprice" runat="server" Text="Label"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="lbl_pro" runat="server" Text="Label"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="lbl_city" runat="server" Text="Label"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="lbl_area" runat="server" Text="Label"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="lbl_rece" runat="server" Text="Label"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="lbl_phone" runat="server" Text="Label"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList1" runat="server">
                                <asp:ListItem>提交订单</asp:ListItem>
                                <asp:ListItem>已发货</asp:ListItem>
                                <asp:ListItem>已收货</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="提交" />
                        </td>
                        <td>
                            &nbsp;</td>
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
                        <td colspan="2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
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
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
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
