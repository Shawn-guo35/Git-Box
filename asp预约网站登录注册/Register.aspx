<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        帐号：&nbsp;&nbsp; 
        <asp:TextBox ID="txtUidi" runat="server"></asp:TextBox>
    </p>
    <p>
        用户名：<asp:TextBox ID="txtUnamei" runat="server"></asp:TextBox>
    </p>
    <p>
&nbsp; 身份：&nbsp;&nbsp; 
        <asp:DropDownList ID="ddlUidentity" runat="server" Width="173px">
            <asp:ListItem>校内人员</asp:ListItem>
            <asp:ListItem>校外人员</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>
        密码：&nbsp;&nbsp; 
        <asp:TextBox ID="txtUpwdi" runat="server"></asp:TextBox>
    </p>
    <p>
        电话：&nbsp;&nbsp; 
        <asp:TextBox ID="txtUphonei" runat="server"></asp:TextBox>
    </p>
    <p>
        备注：&nbsp;&nbsp; 
        <asp:TextBox ID="txtUremarksi" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnRegisteri" runat="server" OnClick="btnRegisteri_Click" Text="确认注册" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnReturnl" runat="server" OnClick="btnReturnl_Click" Text="返回登录" />
    </p>
    <p>
        &nbsp;</p>
</asp:Content>

