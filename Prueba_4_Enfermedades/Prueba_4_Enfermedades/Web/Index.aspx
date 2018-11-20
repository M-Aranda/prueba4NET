﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Prueba_4_Enfermedades.Web.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #form1 {
            height: 524px;
        }
    </style>
</head>
<body style="height: 484px">



    <form id="gridEnf" runat="server">
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="BD_Enfermedades">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
                <asp:BoundField DataField="descripcion" HeaderText="descripcion" SortExpression="descripcion" />
                <asp:BoundField DataField="anioDeDescubrimiento" HeaderText="anioDeDescubrimiento" SortExpression="anioDeDescubrimiento" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="BD_Enfermedades" runat="server" ConnectionString="<%$ ConnectionStrings:registroDeEnfermedadesConnectionString %>" SelectCommand="SELECT * FROM [Enfermedad]"></asp:SqlDataSource>
        <asp:TextBox ID="txtId" runat="server" Width="258px"></asp:TextBox>
        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" />
        <asp:Button ID="btnCancelar" runat="server" OnClick="btnCancelar_Click" Text="Cancelar" />
        <br />
        Nombre de la enfermedad:
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Descripción:"></asp:Label>
        <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" />
        <asp:Button ID="btnModificar" runat="server" Text="Modificar" />
        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" />
    </form>



</body>
</html>