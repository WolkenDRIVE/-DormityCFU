<%@ Page Title="Статус комнат" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListRoom.aspx.cs" Inherits="DormityCFU.Pages.RoomDate.ListRoom" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 style="color: #F1F1F2"><%: Title %></h1>
    <p style="color: #F1F1F2">На данной странице вы можете узнать информацию об комнатах.</p>
    <br />
    <asp:GridView ID="GridViewDormitory" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None">
        <AlternatingRowStyle BackColor="PaleGoldenrod" />
        <Columns>
            <asp:BoundField DataField="IdDormitory" ><ControlStyle CssClass="hiddenColumn" /><FooterStyle CssClass="hiddenColumn" /><HeaderStyle CssClass="hiddenColumn" /><ItemStyle CssClass="hiddenColumn" /></asp:BoundField>
            <%--<asp:BoundField DataField="IdDormitory" HeaderText="Номер общежития" SortExpression="IdDormitory" />--%>
             <asp:BoundField DataField="RowNumb" HeaderText="№" SortExpression="RowNumb" />
             <asp:BoundField DataField="NameDormitory" HeaderText="Название общежития" SortExpression="NameDormitory" />
             <asp:BoundField DataField="PhoneNumbD" HeaderText="Номер телефона " SortExpression="PhoneNumbD" />
             <asp:BoundField DataField="Adress" HeaderText="Адрес " SortExpression="Adress" />
             <asp:BoundField DataField="NumbOfRooms" HeaderText="Кол-во комнат " SortExpression="NumbOfRooms" />
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
    <asp:Button ID="ButtonAdd" runat="server" Text="Добавить данные" Style="color: #000000" PostBackUrl="~/Pages/RoomDate/AddRoom.aspx" />
    <br />
    <br />
    <asp:GridView ID="GridViewRoom" runat="server" BackColor="LightGoldenrodYellow" OnRowDeleting="GridViewRoom_RowDeleting" OnRowDataBound="GridViewRoom_RowDataBound" OnRowEditing="GridViewRoom_RowEditing" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None">
        <AlternatingRowStyle BackColor="PaleGoldenrod" />
        <Columns>
            <asp:BoundField DataField="IdRoom" ><ControlStyle CssClass="hiddenColumn" /><FooterStyle CssClass="hiddenColumn" /><HeaderStyle CssClass="hiddenColumn" /><ItemStyle CssClass="hiddenColumn" /></asp:BoundField>
            <%--<asp:BoundField DataField="IdRoom" HeaderText="Id" SortExpression="IdRoom" />--%>
             <asp:BoundField DataField="RowNumb" HeaderText="№" SortExpression="RowNumb" />
            <asp:CommandField HeaderText="Удалить" ShowDeleteButton="True" ShowHeader="True" />
            <asp:CommandField HeaderText="Редактировать" ShowEditButton="True" ShowHeader="True" />
            <asp:BoundField DataField="NameDormitory" HeaderText="Общежитие " SortExpression="NameDormitory" />
            <asp:BoundField DataField="RoomStatusNotation" HeaderText="Статус комнат " SortExpression="RoomStatusNotation" />
            <asp:BoundField DataField="MaxNumberOfResidents" HeaderText="Максимальное кол-во студентов в комнате " SortExpression="MaxNumberOfResidents" />
            <asp:BoundField DataField="NumberOfResidents" HeaderText="Проживающих по факту " SortExpression="NumberOfResidents" />
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
