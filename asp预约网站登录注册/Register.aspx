<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        &nbsp;</p>
    <p>
        帐号：&nbsp;&nbsp; 
        <asp:TextBox ID="txtUidi" runat="server"></asp:TextBox>
    </p>
    <p>
        用户名：<asp:TextBox ID="txtUnamei" runat="server"></asp:TextBox>
    </p>
    <p>
        身份：&nbsp;&nbsp; 
        <asp:DropDownList ID="ddlUidentity" runat="server" Width="183px">
            <asp:ListItem>校内人员</asp:ListItem>
            <asp:ListItem>校外人员</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>
        密码：&nbsp;&nbsp; 
        <asp:TextBox ID="txtUpwdi" runat="server" TextMode="Password"></asp:TextBox>
    </p>
    <p>
        确认密码：<asp:TextBox ID="txtConfirm" runat="server" TextMode="Password" Width="136px"></asp:TextBox>
    </p>
    <p>
        电话：&nbsp;&nbsp; 
        <asp:TextBox ID="txtUphonei" runat="server"></asp:TextBox>
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 备注：&nbsp; 
        <asp:TextBox ID="txtUremarksi" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Font-Size="XX-Small" Text="*选填"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Button ID="btnRegisteri" runat="server" OnClick="btnRegisteri_Click" Text="确认注册" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnReturnl" runat="server" OnClick="btnReturnl_Click" Text="返回登录" />
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" Font-Italic="False" Font-Size="Small" Text="注：校内人员账号默认为工号或学号；校外人员请用电话号码用作账号注册。"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
</asp:Content>

