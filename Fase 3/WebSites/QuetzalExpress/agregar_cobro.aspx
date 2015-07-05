<%@ Page Language="C#" AutoEventWireup="true" CodeFile="agregar_cobro.aspx.cs" Inherits="agregar_cobro" %>

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
                    Nombre:
                </td>
                <td>
                    <asp:TextBox ID="txtnombre" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Valor:
                </td>
                <td>
                    <asp:TextBox ID="txtvalor" runat="server" TextMode="Number"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblerror" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnguardar" runat="server" Text="Guardar" OnClick="btnguardar_Click" />
                </td>
                <td>
                    <asp:Button ID="btnvolver" runat="server" Text="Volver" OnClick="btnvolver_Click" />
                </td>
            </tr>
        </table>
        <table>
            <tr>
                <td>
                    <asp:FileUpload ID="fuimp" runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblerror2" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btncargar" runat="server" Text="Cargar" OnClick="btncargar_Click" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
