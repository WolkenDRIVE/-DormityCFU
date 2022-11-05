<%@ Page Title="Админ" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="DormityCFU.Pages.Registration.AdminPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Table ID="Table1" runat="server" style="margin-left: 20px; margin-top:10px;">
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="Label1" runat="server" Text="Label" style="color: #F1F1F2"></asp:Label>
            </asp:TableCell>
            <asp:TableCell HorizontalAlign="Right">
                <asp:Button ID="Button1" runat="server" Height="35" Text="Выйти" OnClick="Button1_Click"/>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell ColumnSpan="2">
                <asp:Image ID="Image1" ImageUrl="~/Images/emblem.jpg" Height="150px" runat="server" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell HorizontalAlign="Right">
                <asp:Button ID="Button2" runat="server" Height="35" Text="Перейти на главную страницу" OnClick="Button2_Click"/>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>
