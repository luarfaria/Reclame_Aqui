<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="ReclameAqui.WEB._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Bem vindo ao Reclame aqui
    </h2>
    <p>
        Se você tem um problema e deseja comunicar às autoridades competentes esse é o seu canal.
    </p>
    <label>Selecione a categoria do seu problema:</label>
    <asp:DropDownList ID="ddlCategoria" runat="server"></asp:DropDownList>
    <br /><br />
    <label>Selecione seu estado:</label>
    <asp:DropDownList ID="ddlEstado" runat="server"></asp:DropDownList>
    <br /><br />
    <label>Descreva seu problema:</label>
    <br />
    <textarea id="txtProblema" runat="server" style="width: 100%"></textarea>
    <br /><br />
    <asp:Button ID="btnEnviar" runat="server" Text="Enviar" />
</asp:Content>
