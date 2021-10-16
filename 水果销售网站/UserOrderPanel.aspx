<%@ Page Title="" Language="C#" MasterPageFile="~/UserLayout.Master" AutoEventWireup="true" CodeBehind="UserOrderPanel.aspx.cs" Inherits="水果销售网站.UserOrderPanel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div style="width: 960px; margin: 0 auto">
        <asp:GridView ID="OrderDataTable" runat="server" CssClass="table table-condensed" Width="100%" Height="500px" AutoGenerateColumns="False" OnSelectedIndexChanged="OrderDataTable_SelectedIndexChanged" OnPageIndexChanging="OrderDataTable_PageIndexChanging" AllowPaging="True" EmptyDataText="还没有添加商品，快去购买吧！">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="ID" />
                <asp:BoundField DataField="UserName" HeaderText="用户名" />
                <asp:BoundField DataField="F_Name" HeaderText="水果名" />
                <asp:BoundField DataField="F_Price" HeaderText="价钱" />
                <asp:BoundField DataField="State" HeaderText="订单状态" />
                <asp:ImageField DataImageUrlField="F_Image" HeaderText="图片" ControlStyle-Width="80px" ControlStyle-Height="80px">
                    <ControlStyle Height="80px" Width="80px"></ControlStyle>
                </asp:ImageField>
                <asp:TemplateField HeaderText="删除">
                    <ItemTemplate>
                        <asp:LinkButton ID="lbtn_Delete" runat="server" OnClick="lbtn_Delete_Click">删除</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
