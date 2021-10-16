<%@ Page Title="" Language="C#" MasterPageFile="~/AdminLayout.Master" AutoEventWireup="true" CodeBehind="AdminUpdateFruit.aspx.cs" Inherits="水果销售网站.AdminUpdateFruit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="width: 960px; margin: 0 auto">
        <asp:GridView ID="FruitDataTable" runat="server" CssClass="table table-condensed" Width="100%" Height="500px" AutoGenerateColumns="False" OnPageIndexChanging="FruitDataTable_PageIndexChanging" AllowPaging="True" EmptyDataText="还没有添加商品，快去购买吧！">
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
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%# Eval("Id") %>' OnClick="LinkButton1_Click">设为热门商品</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton2" runat="server" CommandArgument='<%# Eval("Id") %>' OnClick="LinkButton2_Click">选择</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    <div class="container" style="width: 30%">
        <div class="text-center">
            <div class="form-horizontal">
                <div class="form-group">
                    <label class="control-label col-sm-3">水果名:</label>
                    <div class="col-sm-7">
                        <asp:TextBox ID="tbx_name" runat="server" CssClass="form-control" Style="left: 0px; top: 0px"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-sm-3">类型:</label>
                    <div class="col-sm-7">
                        <asp:TextBox ID="tbx_class" runat="server" CssClass="form-control" Style="left: 0px; top: 0px"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-sm-3">价格:</label>
                    <div class="col-sm-7">
                        <asp:TextBox ID="tbx_price" runat="server" CssClass="form-control" Style="left: 0px; top: 0px" TextMode="Number"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-sm-3">简介:</label>
                    <div class="col-sm-7">
                        <asp:TextBox ID="tbx_info" runat="server" CssClass="form-control" Style="left: 0px; top: 0px"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-sm-3">数量:</label>
                    <div class="col-sm-7">
                        <asp:TextBox ID="tbx_count" runat="server" CssClass="form-control" Style="left: 0px; top: 0px" TextMode="Number"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-sm-3">图片:</label>
                    <div class="col-sm-7">
                        <asp:FileUpload ID="FileUpload1" runat="server" CssClass="form-control" Width="378px" />
                    </div>
                </div>
                <div class="form-group">
                    <asp:Button ID="Button1" runat="server" Text="更新" CssClass="form-control" OnClick="Button1_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
