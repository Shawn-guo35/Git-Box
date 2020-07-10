<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Retrieveuserandpasswordn.aspx.cs" Inherits="Retrieveuserandpasswordn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        用户名：<asp:Label ID="lblRnuname" runat="server"></asp:Label>
    </p>
    <p>
        密码：<asp:Label ID="lblRnupwd" runat="server"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Button ID="btnReturnrn" runat="server" Text="返回登录" OnClick="btnReturnrn_Click" />
    </p>
</asp:Content>

