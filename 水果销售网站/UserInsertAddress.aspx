<%@ Page Title="" Language="C#" MasterPageFile="~/UserLayout.Master" AutoEventWireup="true" CodeBehind="UserInsertAddress.aspx.cs" Inherits="水果销售网站.UserInsertAddress" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

          .auto-style8 {
              width: 46px;
              height: 45px;
          }
          .auto-style9 {
            width: 151px;
            height: 45px;
        }
        .auto-style10 {
            width: 225px;
            height: 45px;
        }
        .auto-style11 {
            width: 226px;
            height: 38px;
        }
        .auto-style13 {
            width: 229px;
            height: 38px;
        }
        .auto-style17 {
            width: 315px;
        }
          .auto-style18 {
            height: 23px;
        }
        .auto-style19 {
            width: 315px;
            height: 23px;
        }
        .auto-style20 {
            width: 230px;
            height: 38px;
        }
        .auto-style23 {
            width: 232px;
            height: 38px;
        }
        .auto-style24 {
            width: 315px;
            height: 38px;
        }
        .auto-style25 {
            width: 230px;
            height: 43px;
        }
        .auto-style27 {
            width: 315px;
            height: 43px;
        }
        .auto-style28 {
            width: 232px;
            height: 43px;
        }
        .auto-style29 {
            height: 42px;
        }
        .auto-style30 {
            width: 315px;
            height: 42px;
        }
        .auto-style31 {
            width: 315px;
            height: 45px;
        }
          .auto-style32 {
            width: 151px;
        }
        .auto-style33 {
            height: 42px;
            width: 151px;
        }
        .auto-style34 {
            height: 23px;
            width: 151px;
        }
        .auto-style35 {
            width: 151px;
            height: 38px;
        }
        .auto-style36 {
            width: 151px;
            height: 43px;
        }
          </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style32">&nbsp;</td>
        <td class="auto-style17">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style32">省:</td>
        <td class="auto-style17">
            <asp:DropDownList ID="ddlProvince" runat="server" AutoPostBack="True" Height="40px" OnSelectedIndexChanged="ddlProvince_SelectedIndexChanged" Width="154px">
            </asp:DropDownList>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style29"></td>
        <td class="auto-style33"></td>
        <td class="auto-style30"></td>
        <td class="auto-style29"></td>
        <td class="auto-style29"></td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style32">市:</td>
        <td class="auto-style17">
            <asp:DropDownList ID="ddlCity" runat="server" AutoPostBack="True" Height="40px" OnSelectedIndexChanged="ddlCity_SelectedIndexChanged" Width="154px">
            </asp:DropDownList>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style8"></td>
        <td class="auto-style9"></td>
        <td class="auto-style31"></td>
        <td class="auto-style10"></td>
        <td class="auto-style10"></td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style32">区:</td>
        <td class="auto-style17">
            <asp:DropDownList ID="ddlArea" runat="server" Height="40px" Width="154px">
            </asp:DropDownList>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style11"></td>
        <td class="auto-style35"></td>
        <td class="auto-style24"></td>
        <td class="auto-style13"></td>
        <td class="auto-style13"></td>
    </tr>
    <tr>
        <td class="auto-style18"></td>
        <td class="auto-style34">具体地址:</td>
        <td class="auto-style19">
            <asp:TextBox ID="txt_address" runat="server" Height="28px" Width="186px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txt_address" ErrorMessage="必填" ForeColor="Red" ValidationGroup="1"></asp:RequiredFieldValidator>
        </td>
        <td class="auto-style18"></td>
        <td class="auto-style18"></td>
    </tr>
    <tr>
        <td class="auto-style20"></td>
        <td class="auto-style35"></td>
        <td class="auto-style24"></td>
        <td class="auto-style23"></td>
        <td class="auto-style23"></td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style32">收件人：</td>
        <td class="auto-style17">
            <asp:TextBox ID="txt_receiver" runat="server" Height="30px" Width="186px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txt_receiver" ErrorMessage="必填" ForeColor="Red" ValidationGroup="1"></asp:RequiredFieldValidator>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style25"></td>
        <td class="auto-style36"></td>
        <td class="auto-style27"></td>
        <td class="auto-style28"></td>
        <td class="auto-style28"></td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style32">电话：</td>
        <td class="auto-style17">
            <asp:TextBox ID="txt_phone" runat="server" Height="25px" Width="186px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txt_phone" ErrorMessage="必填" ForeColor="Red" ValidationGroup="1"></asp:RequiredFieldValidator>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style32">&nbsp;</td>
        <td class="auto-style17">
            &nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style32">&nbsp;</td>
        <td class="auto-style17">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="提交" ValidationGroup="1" Width="106px" />
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style32">&nbsp;</td>
        <td class="auto-style17">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style32">&nbsp;</td>
        <td class="auto-style17">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>
