<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Changepassword.aspx.cs" Inherits="Changepassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        用户：<asp:Label ID="Label1" runat="server"></asp:Label>
    </p>
    <p>
        原密码：&nbsp;&nbsp;&nbsp; 
        <asp:TextBox ID="txtUpwdo" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUpwdo" Display="Dynamic" ErrorMessage="密码不能为空" Font-Size="XX-Small" ForeColor="Red"></asp:RequiredFieldValidator>
    </p>
    <p>
&nbsp; 新密码：&nbsp;&nbsp;&nbsp; 
        <asp:TextBox ID="txtUpwdn" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtUpwdn" Display="Dynamic" ErrorMessage="密码不能为空" Font-Size="XX-Small" ForeColor="Red"></asp:RequiredFieldValidator>
    </p>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 确认密码：<asp:TextBox ID="txtConfirmc" runat="server"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtUpwdn" ControlToValidate="txtConfirmc" ErrorMessage="密码不一致" Font-Size="XX-Small" ForeColor="Red"></asp:CompareValidator>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Button ID="btnChangepasswaord" runat="server" OnClick="btnChangepasswaord_Click" Text="修改" />
        <asp:Button ID="btnCrreturn" runat="server" OnClick="btnCrreturn_Click" Text="返回登录" />
    </p>
    <p>
        <asp:Label ID="lblMessage" runat="server" ForeColor="Black"></asp:Label>
    </p>
</asp:Content>

