<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    登录</p>
<p>
    &nbsp; 账号：&nbsp; <asp:TextBox ID="txtUname" runat="server"></asp:TextBox>
</p>
<br />
&nbsp;密码：&nbsp;&nbsp;<asp:TextBox ID="txtUpwd" runat="server" TextMode="Password"></asp:TextBox>
<br />
<br />
<asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="登录" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnRegister" runat="server" OnClick="btnRegister_Click" Text="注册" />
</asp:Content>

