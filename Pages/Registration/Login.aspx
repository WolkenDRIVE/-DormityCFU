<%@ Page Title="Войти" Language="C#" Async="true" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DormityCFU.Pages.Registration.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Table ID="Table1" runat="server">
        <asp:TableRow>
            <asp:TableCell ColumnSpan="2">
                <asp:Label ID="Label1" runat="server" Text="Войти в учетную запись" style="color: #F1F1F2"></asp:Label>
            </asp:TableCell> 
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="Label2" runat="server" Text="Логин" style="color: #F1F1F2"></asp:Label>
            </asp:TableCell> 
            <asp:TableCell>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="Label3" runat="server" Text="Пароль" style="color: #F1F1F2"></asp:Label>
            </asp:TableCell> 
            <asp:TableCell>
                <asp:TextBox ID="TextBox2" TextMode="Password" runat="server"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell ColumnSpan="2" HorizontalAlign="Right">
                <asp:Button ID="Button1" runat="server" Height="35" Width="70" Text="Войти" OnClick="Button1_Click"/>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>
