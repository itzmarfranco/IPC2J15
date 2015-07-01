<%@ Page Language="C#" AutoEventWireup="true" CodeFile="control_paquetes.aspx.cs" Inherits="Control_de_paquetes" %>

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
                    Paquete:
                </td>
                <td>
                    <asp:DropDownList ID="ddlpaquetes" runat="server"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    Estado:
                </td>
                <td>
                    <asp:DropDownList ID="ddlestados" runat="server">
                        <asp:ListItem>Recibido</asp:ListItem>
                        <asp:ListItem>En lote</asp:ListItem>
                        <asp:ListItem>En avión</asp:ListItem>
                        <asp:ListItem>En bodega</asp:ListItem>
                        <asp:ListItem>Entregado</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblerror" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnactualizar" runat="server" Text="Actualizar" OnClick="btnactualizar_Click" />
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
