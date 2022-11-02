<%@ Page Title="Контакты" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="DormityCFU.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2 style="color: #F1F1F2"><%: Title %>.</h2>
    <h3 style="color: #F1F1F2">Наша страница контактов.</h3>
    <address style="color: #F1F1F2">
       Адресс:<br />
        г. Ялта, ул. Красноармейская, 15а<br />
        <abbr title="Телефон">Т:</abbr>
        +7978ХХХХХХХ
    </address>
    <address style="color: #F1F1F2">
       Адресс:<br />
        г. Ялта, пгт Массандра ул. Стахановская,11<br />
        <abbr title="Телефон">Т:</abbr>
        +7978ХХХХХХХ
    </address>

    <address>
        <strong style="color: #F1F1F2">Support:</strong style="color: #8B0000>   <a href="mailto:Support@example.com">Support@example.com</a><br />
        <strong style="color: #F1F1F2">Marketing:</strong style="color: #8B0000> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
    </address>
</asp:Content>
