<%@ Page Language="C#" AutoEventWireup="true" CodeFile="aprobar_precio.aspx.cs" Inherits="aprobar_precio" %>

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
                    <asp:GridView ID="gvpaquetes" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="Q3" OnRowCommand="gvpaquetes_RowCommand">
                        <Columns>
                            <asp:BoundField DataField="id" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                            <asp:ImageField DataImageUrlField="imagen" DataImageUrlFormatString="/imagen/{0}" HeaderText="Factura">
                            </asp:ImageField>
                            <asp:BoundField DataField="precio" HeaderText="Precio" SortExpression="precio" />
                            <asp:ButtonField ButtonType="Button" CommandName="aprobar" HeaderText="Aprobar" ShowHeader="True" Text=":D" />
                            <asp:ButtonField ButtonType="Button" CommandName="rechazar" HeaderText="Rechazar" ShowHeader="True" Text="=O" />
                        </Columns>
                    </asp:GridView>
                    <asp:SqlDataSource ID="Q3" runat="server" ConnectionString="<%$ ConnectionStrings:Qu3tzal3xpr3ssCS %>" SelectCommand="SELECT id, imagen, precio FROM PAQUETE WHERE imagen != '' AND precio &gt; 0 AND estado = 'pendiente'"></asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnvolver" runat="server" Text="Volver" OnClick="btnvolver_Click" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
