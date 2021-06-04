<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Ofertas.aspx.cs" Inherits="iqueaWeb.Ofertas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
    <h1>Aqui estan las super ofertas del momento!!!</h1>

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="descuento" HeaderText="descuento" SortExpression="descuento" />
            <asp:BoundField DataField="fechaValidez" HeaderText="fechaValidez" SortExpression="fechaValidez" />
        </Columns>
    </asp:GridView>
   </center>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Database %>" SelectCommand="SELECT [descuento], [fechaValidez] FROM [oferta]"></asp:SqlDataSource>
</asp:Content>
