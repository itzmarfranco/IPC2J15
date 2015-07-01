<%@ Page Language="C#" AutoEventWireup="true" CodeFile="entregar_paquete.aspx.cs" Inherits="entregar_paquete" %>

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
                    Casilla del cliente:
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
                    <asp:Button ID="btnbuscar" runat="server" Text="Buscar" OnClick="btnbuscar_Click" />
                </td>
                <td>
                    <asp:Button ID="btnvolver" runat="server" Text="Volver" OnClick="btnvolver_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:GridView ID="gvpaquetes" runat="server" OnRowCommand="gvpaquetes_RowCommand">
                        <Columns>
                            <asp:ButtonField ButtonType="Button" CommandName="entregar" HeaderText="Entregar" ShowHeader="True" Text=":)" />
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
        </table>
        <table>
            <tr>
                <td>
                    Factura:
                </td>
            </tr>
            <tr>
                <td>
                    <asp:GridView ID="gvfactura" runat="server"></asp:GridView>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
