<%@ Page Title="" Language="C#" MasterPageFile="~/AdminLayout.Master" AutoEventWireup="true" CodeBehind="AdminInsertFruit.aspx.cs" Inherits="水果销售网站.AdminInsertFruit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
                        <asp:FileUpload ID="FileUpload1" runat="server" CssClass="form-control" />
                    </div>
                </div>
                <div class="form-group">
                    <asp:Button ID="Button1" runat="server" Text="水果上架" CssClass="form-control" OnClick="Button1_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
