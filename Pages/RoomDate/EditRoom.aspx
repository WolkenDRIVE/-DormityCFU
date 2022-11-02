<%@ Page Title="Редактирование" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditRoom.aspx.cs" Inherits="DormityCFU.Pages.RoomDate.EditRoom" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 style="color: #F1F1F2"><%: Title %></h1>
    <br />
    <asp:Label ID="LabelMessage" runat="server" Text="Label"></asp:Label>
    <table>
        <tr>
        <td style="color: #F1F1F2">Общежитие</td>
        <td>
            <asp:DropDownList ID="DropDownListIdDormitory" runat="server"></asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td style="color: #F1F1F2">Статус комнаты</td>
        <td>
            <asp:TextBox ID="TextBoxRoomStatusNotation" runat="server"></asp:TextBox>
        </td>
    </tr>      
        <tr>
        <td style="color: #F1F1F2">Максимальное кол-во студентов в комнате</td>
        <td>
            <asp:TextBox ID="TextBoxMaxNumberOfResidents" runat="server"></asp:TextBox>
        </td>
    </tr>
        <tr>
        <td style="color: #F1F1F2">Проживающих по факту</td>
        <td>
            <asp:TextBox ID="TextBoxNumberOfResidents" runat="server"></asp:TextBox>
        </td>
    </tr>
        <tr>
        <td style="color: #F1F1F2">Номер комнаты</td>
        <td>
            <asp:TextBox ID="TextBoxNumbRoom" runat="server"></asp:TextBox>
        </td>
    </tr>
        </table>
        <table>
        <tr>
            <td>
                <asp:HyperLink ID="HyperLinkCancel" runat="server" NavigateUrl="~/Pages/RoomDate/ListRoom.aspx" style="color: #F1F1F2">Отмена</asp:HyperLink>
            </td>
            <td>
                <asp:Button ID="ButtonSave" runat="server" Text="Сохранить" OnClick="ButtonSave_Click" /></td>
        </tr>
    </table>
</asp:Content>
