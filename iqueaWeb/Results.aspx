<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Results.aspx.cs" Inherits="iqueaWeb.Results" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <asp:Label ID="etiqueta" runat="server" Text=""></asp:Label>
    <asp:GridView ID="GridView" runat="server" AutoGenerateColumns="False" ShowHeader="False" Width="256px" HorizontalAlign="Center" OnRowCommand="GridView_RowCommand1" OnSelectedIndexChanged="GridView_SelectedIndexChanged">
        <Columns>
            <asp:ButtonField DataTextField="Nombre" Text="Botón_nombre" CommandName="id" >
            <FooterStyle HorizontalAlign="Center" />
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle HorizontalAlign="Center" />
            </asp:ButtonField>
            <asp:ImageField DataImageUrlField="Imagen" HeaderText="Imagen">
                <FooterStyle HorizontalAlign="Center" />
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
            </asp:ImageField>
        </Columns>
    </asp:GridView>
</asp:Content>