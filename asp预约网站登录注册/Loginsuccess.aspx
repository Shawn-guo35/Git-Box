<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Loginsuccess.aspx.cs" Inherits="Loginsuccess" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        欢迎，<asp:Label ID="Label1" runat="server"></asp:Label>
    </p>
    <p>
    </p>
    <p>
        <asp:Button ID="btnLogout" runat="server" OnClick="btnLogout_Click" Text="注销" />
    </p>
    <p>
        <asp:LinkButton ID="LinkButton1" runat="server">用户中心</asp:LinkButton>
    </p>
</asp:Content>

