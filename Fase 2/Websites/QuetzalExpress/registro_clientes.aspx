<%@ Page Language="C#" AutoEventWireup="true" CodeFile="registro_clientes.aspx.cs" Inherits="registro_clientes" %>

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
                    Nombre*:
                </td>
                <td>
                    <asp:TextBox ID="txtnombre" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Apellido*:
                </td>
                <td>
                    <asp:TextBox ID="txtapellido" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    NIT:
                </td>
                <td>
                    <asp:TextBox ID="txtnit" runat="server"></asp:TextBox>
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
                    Sucursal de preferencia:
                </td>
                <td>
                    <asp:DropDownList ID="ddlsucursales" runat="server">
                        <asp:ListItem>Ninguna</asp:ListItem>
                        <asp:ListItem>Luego</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    Tarjeta crédito/débito*:
                </td>
                <td>
                    <asp:TextBox ID="txttarjeta" runat="server"></asp:TextBox>
                </td>
                <td>
                    Debe ingresar un número de tarjeta para poder registrarse como cliente
                </td>
            </tr>
            <tr>
                <td>
                    Correo*:
                </td>
                <td>
                    <asp:TextBox ID="txtcorreo" runat="server"></asp:TextBox>
                </td>                
            </tr>             
            <tr>
                <td>
                    Contraseña*:
                </td>
                <td>
                    <asp:TextBox ID="txtcontra" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Confirmar contraseña*:
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
                    <asp:Button ID="btnregistrar" runat="server" Text="Registrarse" OnClick="btnregistrar_Click" />
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
