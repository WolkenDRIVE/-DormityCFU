<%@ Page Title="Редактирование" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditGroup.aspx.cs" Inherits="DormityCFU.Pages.GroupsDate.EditGroup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 style="color: #F1F1F2"><%: Title %></h1>
    <br />
    <asp:Label ID="LabelMessage" runat="server" Text="Label"></asp:Label>
    <table>
    <tr>
        <td style="color: #F1F1F2">Id направления</td>
        <td>
            <asp:TextBox ID="TextBoxIdDirection" runat="server"></asp:TextBox>
        </td>
    </tr>      
        <tr>
        <td style="color: #F1F1F2">Курс</td>
        <td>
            <asp:TextBox ID="TextBoxCourse" runat="server"></asp:TextBox>
        </td>
    </tr>
        <tr>
        <td style="color: #F1F1F2">Код группы</td>
        <td>
            <asp:TextBox ID="TextBoxCodeGroup" runat="server"></asp:TextBox>
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
