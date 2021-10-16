<%@ Page Title="" Language="C#" MasterPageFile="~/UserLayout.Master" AutoEventWireup="true" CodeBehind="UserConfirmOrderInfo.aspx.cs" Inherits="水果销售网站.UserConfirmOrderInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 134px
        }
        .auto-style2 {
            width: 131px;
        }
        .auto-style3 {
            width: 69px;
        }
        .auto-style4 {
            width: 99px;
        }
        .auto-style5 {
            width: 308px
        }
        .auto-style6 {
            width: 197px
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td>&nbsp;</td>
            <td><strong>收获地址确认</strong></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" Width="1132px" Height="204px">
                    <Columns>
                        <asp:BoundField DataField="pro" HeaderText="省份" />
                        <asp:BoundField DataField="city" HeaderText="城市" />
                        <asp:BoundField DataField="area" HeaderText="区域" />
                        <asp:BoundField DataField="address" HeaderText="地址" />
                        <asp:BoundField DataField="rece" HeaderText="收件人" />
                        <asp:BoundField DataField="phone" HeaderText="电话" />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%# Eval("addressID") %>' OnClick="LinkButton1_Click">选择</asp:LinkButton>
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
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <table>
                    <tr>
                        <td>&nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                </table>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td><b></b></td>
            <td><b>商品信息确认</b></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <table style="width:100%;">
                    <tr>
                        <td class="auto-style1">&nbsp;</td>
                        <td class="auto-style2">商品名称</td>
                        <td class="auto-style3">购买数量</td>
                        <td class="auto-style4">商品价格</td>
                        <td class="auto-style4">总价</td>
                        <td class="auto-style6">地址</td>
                        <td class="auto-style5">收件人</td>
                        <td class="auto-style5">电话</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1" rowspan="3">
                            <asp:Image ID="Image1" runat="server" Height="113px" Width="121px" />
                        </td>
                        <td class="auto-style2">&nbsp;</td>
                        <td class="auto-style3">&nbsp;</td>
                        <td class="auto-style4">&nbsp;</td>
                        <td class="auto-style4">&nbsp;</td>
                        <td class="auto-style6">&nbsp;</td>
                        <td class="auto-style5">&nbsp;</td>
                        <td class="auto-style5">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="lbl_fname" runat="server" Text="Label"></asp:Label>
                        </td>
                        <td class="auto-style3">
                            <asp:Label ID="lbl_quantity" runat="server" Text="Label"></asp:Label>
                        </td>
                        <td class="auto-style4">
                            <asp:Label ID="lbl_price" runat="server" Text="Label"></asp:Label>
                        </td>
                        <td class="auto-style4">¥<asp:Label ID="lbl_totalprice" runat="server" style="font-size: x-large; color: #000000" Text="Label"></asp:Label>
                        </td>
                        <td class="auto-style6">
                            <asp:Label ID="lbl_address" runat="server" Text="请选择收货地址"></asp:Label>
                        </td>
                        <td class="auto-style5">
                            <asp:Label ID="lbl_receiver" runat="server" Text="请选择收货地址"></asp:Label>
                        </td>
                        <td class="auto-style5">
                            <asp:Label ID="lbl_phone" runat="server" Text="请选择收货地址"></asp:Label>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td class="auto-style3">&nbsp;</td>
                        <td class="auto-style4">&nbsp;</td>
                        <td class="auto-style4">&nbsp;</td>
                        <td class="auto-style6">&nbsp;</td>
                        <td class="auto-style5">&nbsp;</td>
                        <td class="auto-style5">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1">&nbsp;</td>
                        <td class="auto-style2">&nbsp;</td>
                        <td class="auto-style3">&nbsp;</td>
                        <td class="auto-style4">&nbsp;</td>
                        <td class="auto-style4">&nbsp;</td>
                        <td class="auto-style6">&nbsp;</td>
                        <td class="auto-style5">&nbsp;</td>
                        <td class="auto-style5">
                            <asp:Button ID="Button1" runat="server" Height="46px" Text="确认购买" Width="233px" OnClick="Button1_Click" />
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                </table>
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
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
