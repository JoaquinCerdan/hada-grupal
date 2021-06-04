<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Busqueda.aspx.cs" Inherits="iqueaWeb.Busqueda" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:GridView ID="GridView" runat="server" AutoGenerateColumns="False" ShowHeader="False" Width="256px" HorizontalAlign="Center" OnSelectedIndexChanged="GridView_SelectedIndexChanged" AutoGenerateSelectButton="True">
        <Columns>
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
            <asp:ImageField DataImageUrlField="Imagen" HeaderText="Imagen">
                <FooterStyle HorizontalAlign="Center" />
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
            </asp:ImageField>
        </Columns>
    </asp:GridView>

</asp:Content>
