<%@ Page Language="C#" AutoEventWireup="true" CodeFile="agregar_lote.aspx.cs" Inherits="agregar_lote" %>

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
                    Seleccione el paquete:
                </td>
                <td>
                    <asp:DropDownList ID="ddlpaquetes" runat="server"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    Seleccione el lote:
                </td>
                <td>
                    <asp:DropDownList ID="ddllotes" runat="server"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblerror" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnañadir" runat="server" Text="Añadir a lote" OnClick="btnañadir_Click" />
                </td>
                <td>
                    <asp:Button ID="btnvolver" runat="server" Text="Volver" OnClick="btnvolver_Click" />
                </td>
            </tr>
        </table>
        <table>
            <tr>
                <td>
                    Crear lote:
                </td>
            </tr>
            <tr>
                <td>
                    Número:
                </td>
                <td>
                    <asp:TextBox ID="txtnlote" runat="server" TextMode="Number"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblerror2" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btncrear" runat="server" Text="Crear" OnClick="btncrear_Click" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
