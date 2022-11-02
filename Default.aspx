<%@ Page Title="Главная страница" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DormityCFU._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div style="background:transparent !important"  class="jumbotron">
        <h1 style="color: #F1F1F2">Общежитие КФУ</h1>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2 style="color: #F1F1F2">О нас</h2>
            <p style="color: #F1F1F2">
                
            </p>
            <p>
                <a class="btn btn-default" href="About">Подробнее &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2 style="color: #F1F1F2">Контакты</h2>
            <p style="color: #F1F1F2">
               
            </p>
            <p>
                <a class="btn btn-default" href="Contact">Подробнее &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2 style="color: #F1F1F2">Направления и группы</h2>
            <p style="color: #F1F1F2">
                
            </p>
            <p>
                <a class="btn btn-default" href="Pages/GroupsDate/ListGroup.aspx">Подробнее &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
