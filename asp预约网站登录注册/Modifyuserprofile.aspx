<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Modifyuserprofile.aspx.cs" Inherits="Modifyuserprofile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        账号：<asp:Label ID="lblUidm" runat="server"></asp:Label>
    </p>
    <p>
        用户名：<asp:Label ID="lblUnamem" runat="server"></asp:Label>
    </p>
    <p>
        身份：&nbsp;&nbsp; 
        <asp:DropDownList ID="ddlUidentitym" runat="server" Width="183px">
            <asp:ListItem>校内人员</asp:ListItem>
            <asp:ListItem>校外人员</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>
&nbsp;电话：&nbsp;&nbsp; 
        <asp:TextBox ID="txtUphonem" runat="server"></asp:TextBox>
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 备注：&nbsp; 
        <asp:TextBox ID="txtUremarksm" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Font-Size="XX-Small" Text="*选填"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Button ID="btnModify" runat="server" OnClick="btnModify_Click" Text="修改" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnReturnm" runat="server" OnClick="Button1_Click" Text="返回登录" />
    </p>
    <p>
        <asp:Label ID="lblMessagem" runat="server"></asp:Label>
    </p>
</asp:Content>

