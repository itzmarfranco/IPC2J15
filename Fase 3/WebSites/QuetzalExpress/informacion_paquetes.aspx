<%@ Page Language="C#" AutoEventWireup="true" CodeFile="informacion_paquetes.aspx.cs" Inherits="informacion_paquetes" %>

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
                    Historial de paquetes: <asp:Label ID="lbl" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:GridView ID="gvpaquetes" runat="server" OnRowCommand="gvpaquetes_RowCommand">
                        <Columns>
                            <asp:ButtonField ButtonType="Button" CommandName="ver" HeaderText="Info" ShowHeader="True" Text="Ver" />
                            <asp:ButtonField ButtonType="Button" CommandName="verindividual" HeaderText="Info" ShowHeader="True" Text="Ver mas" />
                            <asp:ButtonField ButtonType="Button" CommandName="agregarfactura" HeaderText="Factura" ShowHeader="True" Text="Agregar" />
                        </Columns>
                    </asp:GridView>
                </td>
                <td>
                    <table id="fu" runat="server" visible="false">
                        <tr>
                            <td>
                                Seleccione la imagen de su factura del paquete: 
                            </td>
                            <td>
                                <asp:Label ID="lblid" runat="server" Text=""></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:FileUpload ID="fuimagen" runat="server" />
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
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    Si su paquete tiene 0 en el precio, debe agregar la factura de compra
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnvolver" runat="server" Text="Volver" OnClick="btnvolver_Click" />
                </td>
            </tr>
        </table>
        <table>
            <tr>
                <td>
                    <asp:GridView ID="gvpaquete" runat="server"></asp:GridView>
                </td>
            </tr>
            <tr>
                <td>
                    Monto aproximado:
                </td>
                <td>
                    <asp:Label ID="lblmonto" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
