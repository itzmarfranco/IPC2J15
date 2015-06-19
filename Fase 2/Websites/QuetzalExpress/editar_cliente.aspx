<%@ Page Language="C#" AutoEventWireup="true" CodeFile="editar_cliente.aspx.cs" Inherits="editar_cliente" %>

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
                    Casilla:
                </td>
                <td>
                    <asp:Label ID="lblcasilla" runat="server" Text=""></asp:Label>
                </td>
            </tr>
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
                    <asp:DropDownList ID="ddlsucursales" runat="server"></asp:DropDownList>
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
                    Debe ingresar un número de tarjeta para poder permanecer como cliente
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
                    <asp:Button ID="btnactualizar" runat="server" Text="Actualizar" OnClick="btnactualizar_Click"/>
                </td>
                <td>
                    <asp:Button ID="btnvolver" runat="server" Text="Volver" OnClick="btnvolver_Click"/>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
