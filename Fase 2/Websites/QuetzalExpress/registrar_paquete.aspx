<%@ Page Language="C#" AutoEventWireup="true" CodeFile="registrar_paquete.aspx.cs" Inherits="registrar_paquete" %>

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
                    Peso:
                </td>
                <td>
                    <asp:TextBox ID="txtpeso" runat="server" TextMode="Number"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Precio:
                </td>
                <td>
                    <asp:TextBox ID="txtprecio" runat="server" TextMode="Number"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Categoría:
                </td>
                <td>
                    <asp:DropDownList ID="ddlcategorias" runat="server"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    Casilla:
                </td>
                <td>
                    <asp:TextBox ID="txtcasilla" runat="server" TextMode="Number"></asp:TextBox>
                </td>
            </tr>            
            <tr>
                <td>
                    <asp:Label ID="lblerror" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnregistrar" runat="server" Text="Registrar" OnClick="btnregistrar_Click" />
                </td>
                <td>
                    <asp:Button ID="btnvolver" runat="server" Text="Volver" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
