<%@ Page Title="Направления подготовки и группы" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListGroup.aspx.cs" Inherits="DormityCFU.Pages.GroupsDate.ListGroup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 style="color: #F1F1F2"><%: Title %></h1>
    <p style="color: #F1F1F2">На данной странице вы можете узнать информацию о напрвалении и группах студентов.</p>
    <br />
    <p style="color: #F1F1F2">Информация о направлениях.</p> 
     <asp:Button ID="ButtonAdd" runat="server" Text="Добавить данные" Style="color: #000000" PostBackUrl="~/Pages/GroupSDate/AddDirection.aspx" />
    <br />
    <br />
    <asp:GridView ID="GridViewDirection" runat="server" BackColor="LightGoldenrodYellow" OnRowDeleting="GridViewDirection_RowDeleting" OnRowDataBound="GridViewDirection_RowDataBound" OnRowEditing="GridViewDirection_RowEditing" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None">
        <AlternatingRowStyle BackColor="PaleGoldenrod" />
        <Columns>
            <asp:BoundField DataField="IdDirection" ><ControlStyle CssClass="hiddenColumn" /><FooterStyle CssClass="hiddenColumn" /><HeaderStyle CssClass="hiddenColumn" /><ItemStyle CssClass="hiddenColumn" /></asp:BoundField>
            <%--<asp:BoundField DataField="IdDirection" HeaderText="Id" SortExpression="IdDirection" />--%>
            <asp:BoundField DataField="RowNumb" HeaderText="№" SortExpression="RowNumb" />
            <asp:CommandField HeaderText="Удалить" ShowDeleteButton="True" ShowHeader="True" />
            <asp:CommandField HeaderText="Редактировать" ShowEditButton="True" ShowHeader="True" />
            <asp:BoundField DataField="Direction" HeaderText="Направление " SortExpression="Direction" />
            <asp:BoundField DataField="CodeDirection" HeaderText="Код направления " SortExpression="CodeDirection" />
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
    <br />
    <p style="color: #F1F1F2">Информация о группах.</p> 
     <asp:Button ID="Button1" runat="server" Text="Добавить данные" Style="color: #000000" PostBackUrl="~/Pages/GroupSDate/AddGroup.aspx" />
    <br />
    <br />
    <asp:GridView ID="GridViewGroup" runat="server" BackColor="LightGoldenrodYellow" OnRowDeleting="GridViewGroup_RowDeleting" OnRowDataBound="GridViewGroup_RowDataBound" OnRowEditing="GridViewGroup_RowEditing" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None">
        <AlternatingRowStyle BackColor="PaleGoldenrod" />
        <Columns>
            <asp:BoundField DataField="IdGroup" ><ControlStyle CssClass="hiddenColumn" /><FooterStyle CssClass="hiddenColumn" /><HeaderStyle CssClass="hiddenColumn" /><ItemStyle CssClass="hiddenColumn" /></asp:BoundField>
            <%--<asp:BoundField DataField="IdGroup" HeaderText="Id" SortExpression="IdGroup" />--%>
            <asp:BoundField DataField="RowNumb" HeaderText="№" SortExpression="RowNumb" />
            <asp:CommandField HeaderText="Удалить" ShowDeleteButton="True" ShowHeader="True" />
            <asp:CommandField HeaderText="Редактировать" ShowEditButton="True" ShowHeader="True" />
            <asp:BoundField DataField="CodeDirection" HeaderText="Код направления" SortExpression="CodeDirection" />
            <asp:BoundField DataField="Course" HeaderText="Курс" SortExpression="Course" />
            <asp:BoundField DataField="CodeGroup" HeaderText="Код группы " SortExpression="CodeGroup" />
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
