<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Retrieveuserandpassword.aspx.cs" Inherits="Retrieveuserandpassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        输入电话号码：<asp:TextBox ID="txtRetrievea" runat="server"></asp:TextBox>
        <asp:Button ID="btnRertievea" runat="server" OnClick="btnRertievea_Click" Text="下一步" />
    </p>
</asp:Content>

