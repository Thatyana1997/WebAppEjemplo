<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="WebAppEjemplo.Paginas.WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Ejercicio 1</title>
</head>
<body>
    <form id="form1" runat="server">
        <div><!--ctrl + K + D >>Identar el código -->
            <h2>Formulario para validar edad</h2>
            
            <label for="txtNombre">Nombre:</label>
            <asp:TextBox ID="txtNombre" runat="server" required="true"></asp:TextBox>
            <br /><br />
            <label for="txtEdad">Edad:</label>
            <asp:TextBox ID="txtEdad"  runat="server" required="true"></asp:TextBox>
             <br /><br />
            <asp:Button ID="btnEnviar" runat="server" Text="Enviar" OnClick="btnEnviar_Click" />
             <br /><br />
            <asp:Label ID="lblMensaje" runat="server"></asp:Label>  
             
        </div>
    </form>
</body>
</html>
