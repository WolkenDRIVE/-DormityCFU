<%@ Page Title="Добавление студента" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddStudent.aspx.cs" Inherits="DormityCFU.Pages.Students.AddStudent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 style="color: #F1F1F2"><%: Title %></h1>
    <br />
    <table>
    <tr>
        <td style="color: #F1F1F2">Фамилия Студента</td>
        <td>
            <asp:TextBox ID="TextBoxSecondName" runat="server"></asp:TextBox>
        </td>
    </tr>
        <tr>
        <td style="color: #F1F1F2">Имя Студента</td>
        <td>
            <asp:TextBox ID="TextBoxFirstName" runat="server"></asp:TextBox>
        </td>
    </tr>
        <tr>
        <td style="color: #F1F1F2">Отчество Студента</td>
        <td>
            <asp:TextBox ID="TextBoxSurname" runat="server"></asp:TextBox>
        </td>
    </tr>
        <tr>
        <td style="color: #F1F1F2">Дата рождения</td>
        <td>
            <asp:TextBox ID="TextBoxDateOfBirth" runat="server"></asp:TextBox>
        </td>
    </tr>
    
        <tr>
        <td style="color: #F1F1F2">Курс</td>
        <td>
            <asp:DropDownList ID="DropDownListCourse" runat="server"></asp:DropDownList>
        </td>
    </tr>
        <tr>
        <td style="color: #F1F1F2">Дата регистрации студента</td>
        <td>
            <asp:TextBox ID="TextBoxDateOfRegistr" runat="server"></asp:TextBox>
        </td>
    </tr>
        <tr>
        <td style="color: #F1F1F2">Общежитие</td>
        <td>
            <asp:DropDownList ID="DropDownListIdDormitory" runat="server"></asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td style="color: #F1F1F2">Номер комнаты</td>
        <td>
            <asp:DropDownList ID="DropDownListRoom" runat="server"></asp:DropDownList>
        </td>
    </tr>
    </table>
    <table>
        <tr>
            <td>
                <asp:HyperLink ID="HyperLinkCancel" runat="server" NavigateUrl="~/Pages/Students/ListStudent.aspx" style="color: #F1F1F2">Отмена</asp:HyperLink>
            </td>
            <td>
                <asp:Button ID="ButtonSave" runat="server" Text="Сохранить" OnClick="ButtonSave_Click" /></td>
        </tr>
    </table>
</asp:Content>
