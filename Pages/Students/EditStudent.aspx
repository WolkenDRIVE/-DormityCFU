<%@ Page Title="Редактирование записи" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditStudent.aspx.cs" Inherits="DormityCFU.Pages.Students.EditStudent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <h1><%: Title %></h1>
    <br />
    <asp:Label ID="LabelMessage" runat="server" Text="Label"></asp:Label>
    <table>
    <tr>
        <td style="color: #000000">Фамилия Студента</td>
        <td>
            <asp:TextBox ID="TextBoxSecondName" runat="server"></asp:TextBox>
        </td>
    </tr>
        <tr>
        <td style="color: #000000">Имя Студента</td>
        <td>
            <asp:TextBox ID="TextBoxFirstName" runat="server"></asp:TextBox>
        </td>
    </tr>
        <tr>
        <td style="color: #000000">Отчество Студента</td>
        <td>
            <asp:TextBox ID="TextBoxSurname" runat="server"></asp:TextBox>
        </td>
    </tr>
        <tr>
        <td style="color: #000000">Дата рождения</td>
        <td>
            <asp:TextBox ID="TextBoxDateOfBirth" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="color: #000000">Направление</td>
        <td>
            <asp:DropDownList ID="DropDownListDirection" runat="server"></asp:DropDownList>
        </td>
    </tr>
        <tr>
        <td style="color: #000000">Курс</td>
        <td>
            <asp:TextBox ID="TextBoxCourse" runat="server"></asp:TextBox>
        </td>
    </tr>
        <tr>
        <td style="color: #000000">Дата регистрации студента</td>
        <td>
            <asp:TextBox ID="TextBoxDateOfRegistr" runat="server"></asp:TextBox>
        </td>
    </tr>
        <tr>
        <td style="color: #000000">Общежитие</td>
        <td>
            <asp:DropDownList ID="DropDownListIdDormitory" runat="server"></asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td style="color: #000000">Номер комнаты</td>
        <td>
            <asp:TextBox ID="TextBoxNumbRoom" runat="server"></asp:TextBox>
        </td>
    </tr>
    </table>
    <table>
        <tr>
            <td>
                <asp:HyperLink ID="HyperLinkCancel" runat="server" NavigateUrl="~/Pages/Students/ListStudent.aspx">Отмена</asp:HyperLink>
            </td>
            <td>
                <asp:Button ID="ButtonSave" runat="server" Text="Сохранить" OnClick="ButtonSave_Click" /></td>
        </tr>
    </table>
</asp:Content>
