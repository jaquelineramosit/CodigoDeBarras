<%@ Page Title="Montar PC Dinâmico" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MontarPCDinamico.aspx.cs" Inherits="LojaOnLine.MontarPCDinamico" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" type="text/css" href="CSS/estilo.css">
    <h2><%: Title %>.</h2>
    <h3>Configure o computador</h3>
    <div id="content">
        <div id="formulario">
            <asp:Label ID="lblProcessador" runat="server" CssClass="label">Processador: </asp:Label>
            <asp:DropDownList ID="ddlProcessador" runat="server" CssClass="DropDownList"></asp:DropDownList>
            <br />
            <asp:Label ID="lblPlacaMae" runat="server"  CssClass="label">Placa mãe</asp:Label>
            <asp:DropDownList ID="ddlPlacaMae" runat="server" CssClass="DropDownList"></asp:DropDownList>
            <br />
            <asp:Label ID="lblMemoria" runat="server"  CssClass="label">Memória: </asp:Label>
            <asp:DropDownList ID="ddlMemoria" runat="server" CssClass="DropDownList"></asp:DropDownList>
            <asp:Label ID="lblQteMemoria" runat="server" Enabled="false" CssClass="label displaynone">Qtde: </asp:Label>
            <asp:TextBox ID="txtQteMemoria" runat="server" Enabled="false" CssClass="label displaynone"></asp:TextBox>
            <br />
            <asp:Label ID="lblHD" runat="server" CssClass="label">HD Interno:</asp:Label>
            <asp:DropDownList ID="ddlHD" runat="server" CssClass="DropDownList"></asp:DropDownList>
            <asp:Label ID="lblQtdeHD" runat="server" Enabled="false" CssClass="label displaynone">Qtde: </asp:Label>
            <asp:TextBox ID="txtQtdeHD" runat="server" Enabled="false" CssClass="displaynone"></asp:TextBox>
            <br />
            <asp:Label ID="lblSSD" runat="server" CssClass="label">SSD:</asp:Label>
            <asp:DropDownList ID="ddlSSD" runat="server" CssClass="DropDownList"></asp:DropDownList>
            <br />
            <asp:Label ID="lblGabinete" runat="server" CssClass="label">Gabinete:</asp:Label>
            <asp:DropDownList ID="ddlGabinete" runat="server" CssClass="DropDownList"></asp:DropDownList>
            <br />
            <asp:Label ID="lblGravadorDVD" runat="server" CssClass="label">Gravador de DVD:</asp:Label>
            <asp:DropDownList ID="ddlGravadorDVD" runat="server" CssClass="DropDownList"></asp:DropDownList>
            <br />
            <asp:Label ID="lblFonte" runat="server" CssClass="label">Fonte ATX:</asp:Label>
            <asp:DropDownList ID="ddlFonte" runat="server" CssClass="DropDownList"></asp:DropDownList>
            <br />
            <asp:Label ID="lblPlacaVideo" runat="server" CssClass="label">Placa de Vídeo</asp:Label>
            <asp:DropDownList ID="ddlPlacaVideo" runat="server" CssClass="DropDownList"></asp:DropDownList>
            <br />
        </div>

    </div>
</asp:Content>
