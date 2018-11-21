<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ServicioWeb_Enfermedad_Consumidor.aspx.cs" Inherits="Prueba_4_Enfermedades.Web.ServicioWeb_Enfermedad_Consumidor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 262px">


    <form id="form1" runat="server">
        <asp:TextBox ID="txtBuscar" runat="server"></asp:TextBox>
        <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar enfermedad por id" />
        <br />
        <asp:Label ID="lblResultado" runat="server"></asp:Label>
    </form>


</body>
</html>
