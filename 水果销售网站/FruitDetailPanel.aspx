<%@ Page Title="" Language="C#" MasterPageFile="~/UserLayout.Master" AutoEventWireup="true" CodeBehind="FruitDetailPanel.aspx.cs" Inherits="水果销售网站.FruitDetailPanel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="width: 50%">
        <div class="text-center">
            <div class="form-horizontal">
                <div class="col-lg-4">
                    <asp:Image ID="Image1" runat="server" Width="150px" Height="150px" />
                </div>
                <div class="col-lg-8">
                    <div class="form-group">
                        <label class="control-label col-sm-3">水果名:</label>
                        <div class="col-sm-7">
                            <asp:TextBox ID="tbx_name" runat="server" CssClass="form-control-static" Style="left: 0px; top: 0px" ReadOnly="True"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="control-label col-sm-3">类型:</label>
                        <div class="col-sm-7">
                            <asp:TextBox ID="tbx_class" runat="server" CssClass="form-control" Style="left: 0px; top: 0px" ReadOnly="True"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="control-label col-sm-3">价格:</label>
                        <div class="col-sm-7">
                            <asp:TextBox ID="tbx_price" runat="server" CssClass="form-control" Style="left: 0px; top: 0px" ReadOnly="True"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="control-label col-sm-3">介绍:</label>
                        <div class="col-sm-7">
                            <asp:TextBox ID="tbx_info" runat="server" CssClass="form-control" Style="left: 0px; top: 0px" ReadOnly="True"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="control-label col-sm-3">上架时间:</label>
                        <div class="col-sm-7">
                            <asp:TextBox ID="tbx_time" runat="server" CssClass="form-control" Style="left: 0px; top: 0px" ReadOnly="True"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="control-label col-sm-3">库存数量:</label>
                        <div class="col-sm-7">
                            <asp:TextBox ID="tbx_amount" runat="server" CssClass="form-control" Style="left: 0px; top: 0px" ReadOnly="True"></asp:TextBox>
                        </div>
                    </div>

                     <div class="form-group">
                        <label class="control-label col-sm-3">购买数量/斤:</label>
                        <div class="col-sm-7">
                            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" Style="left: 0px; top: 0px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="*" style="font-size: x-large; color: #FF0000" ValidationGroup="1"></asp:RequiredFieldValidator>
                            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="必须为整数" ForeColor="Red" Operator="DataTypeCheck" Type="Integer" ValidationGroup="1"></asp:CompareValidator>
                        </div>
                    </div>


                </div>
                <div class="form-group">
                    <asp:Button ID="btn_Buy" runat="server" Text="购买" CssClass="form-control" OnClick="btn_Buy_Click" ValidationGroup="1" />
                </div>

                <div class="form-group">
                    <asp:Button ID="Button1" runat="server" Text="加入购物车" CssClass="form-control" OnClick="Button1_Click" ValidationGroup="1"  />
                </div>


            </div>
        </div>
    </div>
</asp:Content>
