<%@ Page Title="" Language="C#" MasterPageFile="~/AdminLayout.Master" AutoEventWireup="true" CodeBehind="AdminDeleteFruit.aspx.cs" Inherits="水果销售网站.AdminDeleteFruit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="width: 960px; margin: 0 auto">
        <asp:GridView ID="FruitDataTable" runat="server" CssClass="table table-condensed" Width="100%" Height="500px" AutoGenerateColumns="False" OnSelectedIndexChanged="FruitDataTable_SelectedIndexChanged" OnPageIndexChanging="FruitDataTable_PageIndexChanging" AllowPaging="True" EmptyDataText="还没有添加商品，快去购买吧！">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="ID" />
                <asp:BoundField DataField="F_Name" HeaderText="水果名" />
                <asp:BoundField DataField="F_Class" HeaderText="水果分类" />
                <asp:BoundField DataField="F_Price" HeaderText="价钱" />
                <asp:BoundField DataField="F_Info" HeaderText="水果简介" />
                <asp:BoundField DataField="F_CreateTime" HeaderText="创建时间" />
                <asp:BoundField DataField="F_Count" HeaderText="数量" />
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
