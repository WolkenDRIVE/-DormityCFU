<%@ Page Title="Добавление направления" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddDirection.aspx.cs" Inherits="DormityCFU.Pages.GroupsDate.AddDirection" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <h1 style="color: #F1F1F2"><%: Title %></h1>
    <br />
     <table>
    <tr>
        <td style="color: #F1F1F2">Направление</td>
        <td>
            <asp:TextBox ID="TextBoxDirection" runat="server"></asp:TextBox>
        </td>
    </tr>      
        <tr>
        <td style="color: #F1F1F2">Код направления</td>
        <td>
            <asp:TextBox ID="TextBoxCodeDirection" runat="server"></asp:TextBox>
        </td>
    </tr>
        </table>
        <table>
        <tr>
            <td>
                <asp:HyperLink ID="HyperLinkCancel" runat="server" NavigateUrl="~/Pages/GroupsDate/ListGroup.aspx" style="color: #F1F1F2">Отмена</asp:HyperLink>
            </td>
            <td>
                <asp:Button ID="ButtonSave" runat="server" Text="Сохранить" OnClick="ButtonSave_Click" /></td>
        </tr>
    </table>
</asp:Content>
