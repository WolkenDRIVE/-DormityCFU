<%@ Page Title="Информация о заселенных студентах" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListStudent.aspx.cs" Inherits="DormityCFU.Pages.Students.ListStudent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 style="color: #000000"><%: Title %></h1>
    <p style="color: #000000">На данной странице вы можете узнать информацию о заселенных студентах.</p>
    <br />
    <asp:Button ID="ButtonAdd" runat="server" Text="Добавить данные" Style="color: #000000" PostBackUrl="~/Pages/Students/AddStudent.aspx" />
    <br />
    <br />
    <asp:GridView ID="GridViewStudent" runat="server" BackColor="LightGoldenrodYellow" OnRowDeleting="GridViewStudent_RowDeleting" OnRowDataBound="GridViewStudent_RowDataBound" OnRowEditing="GridViewStudent_RowEditing" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None">
        <AlternatingRowStyle BackColor="PaleGoldenrod" />
        <Columns>
            <asp:BoundField DataField="IdStudent" HeaderText="Id" SortExpression="IdStudent" />
            <asp:CommandField HeaderText="Удалить" ShowDeleteButton="True" ShowHeader="True" />
            <asp:CommandField HeaderText="Редактировать" ShowEditButton="True" ShowHeader="True" />
            <asp:BoundField DataField="SecondName" HeaderText="Фамилия Студента " SortExpression="SecondName" />
            <asp:BoundField DataField="FirstName" HeaderText="Имя Студента " SortExpression="FirstName" />
            <asp:BoundField DataField="Surname" HeaderText="Отчество Студента " SortExpression="Surname" />
            <asp:TemplateField HeaderText="Дата рождения ">
                <ItemTemplate>
                    <asp:Label ID="lblDateOfBirth" runat="server" Text='<%# Bind("DateOfBirth","{0:d}") %>'></asp:Label>
                </ItemTemplate>
                <FooterStyle HorizontalAlign="Center" />
            </asp:TemplateField>
            <asp:BoundField DataField="Direction" HeaderText="Направление " SortExpression="Direction" />
            <asp:BoundField DataField="Course" HeaderText="Курс " SortExpression="Course" />
            <asp:TemplateField HeaderText="Дата регистрации студента ">
                <ItemTemplate>
                    <asp:Label ID="lblDateOfRegistr" runat="server" Text='<%# Bind("DateOfRegistr","{0:d}") %>'></asp:Label>
                </ItemTemplate>
                <FooterStyle HorizontalAlign="Center" />
            </asp:TemplateField>
            <asp:BoundField DataField="IdDormitory" HeaderText="Общежитие" SortExpression="IdDormitory" />
            <asp:BoundField DataField="NumbRoom" HeaderText="Номер комнаты " SortExpression="NumbRoom" />
        </Columns>
        <FooterStyle BackColor="Tan" />
        <HeaderStyle BackColor="Tan" Font-Bold="True" />
        <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
        <SortedAscendingCellStyle BackColor="#FAFAE7" />
        <SortedAscendingHeaderStyle BackColor="#DAC09E" />
        <SortedDescendingCellStyle BackColor="#E1DB9C" />
        <SortedDescendingHeaderStyle BackColor="#C2A47B" />
    </asp:GridView>
</asp:Content>
