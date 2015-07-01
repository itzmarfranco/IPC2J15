<%@ Page Language="C#" AutoEventWireup="true" CodeFile="contratar_empleado.aspx.cs" Inherits="contratar_empleado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td>
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/principal.aspx">Inicio</asp:HyperLink>
                </td>
            </tr>
        </table>
        <table>
            <tr>
                <td>
                    Nombre:
                </td>
                <td>
                    <asp:TextBox ID="txtnombre" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Apellido:
                </td>
                <td>
                    <asp:TextBox ID="txtapellido" runat="server"></asp:TextBox>
                </td>
            </tr>            
            <tr>
                <td>
                    Teléfono:
                </td>
                <td>
                    <asp:TextBox ID="txttel" runat="server" TextMode="Number"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Domicilio:
                </td>
                <td>
                    <asp:TextBox ID="txtdomicilio" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Sueldo:
                </td>
                <td>
                    <asp:TextBox ID="txtsueldo" runat="server" TextMode="Number"></asp:TextBox>
                </td>
            </tr>           
            <tr>
                <td>
                    Correo:
                </td>
                <td>
                    <asp:TextBox ID="txtcorreo" runat="server"></asp:TextBox>
                </td>                
            </tr>             
            <tr>
                <td>
                    Contraseña:
                </td>
                <td>
                    <asp:TextBox ID="txtcontra" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Confirmar contraseña:
                </td>
                <td>
                    <asp:TextBox ID="txtconfirmar" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblerror" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btncontratar" runat="server" Text="Contratar" OnClick="btncontratar_Click"/>
                </td>
                <td>
                    <asp:Button ID="btnvolver" runat="server" Text="Volver" OnClick="btnvolver_Click" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
