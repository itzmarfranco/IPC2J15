<%@ Page Language="C#" AutoEventWireup="true" CodeFile="devolucion.aspx.cs" Inherits="devolucion" %>

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
                    Ingrese el número de paquete:
                </td>
                <td>
                    <asp:TextBox ID="txtpaquete" runat="server" TextMode="Number"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblerror" runat="server" Text="" ></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btndevolver" runat="server" Text="Devolver" OnClick="btndevolver_Click"/>
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
