<%@ Page Language="C#" AutoEventWireup="true" CodeFile="agregar_precio.aspx.cs" Inherits="agregar_precio" %>

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
                    <asp:GridView ID="gvimagen" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="Q3" OnRowCommand="gvimagen_RowCommand">
                        <Columns>
                            <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                            <asp:ImageField DataImageUrlField="imagen" DataImageUrlFormatString="/imagen/{0}" HeaderText="Factura">
                            </asp:ImageField>
                            <asp:ButtonField ButtonType="Button" CommandName="editar" HeaderText="Editar" ShowHeader="True" Text=":)" />                            
                        </Columns>                        
                    </asp:GridView>
                    <asp:SqlDataSource ID="Q3" runat="server" ConnectionString="<%$ ConnectionStrings:Qu3tzal3xpr3ssCS %>" SelectCommand="SELECT id, imagen FROM PAQUETE WHERE imagen !='' AND estado = 'pendiente'"></asp:SqlDataSource>
                </td>
                <td>
                    <table id="tbleditar" runat="server" visible="false">
                        <tr>
                            <td>
                                ID:
                            </td>
                            <td>
                                <asp:Label ID="lblid" runat="server" Text=""></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Precio:
                            </td>
                            <td>
                                <asp:TextBox ID="txtprecio" runat="server"></asp:TextBox>
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
                                <asp:Button ID="btncancelar" runat="server" Text="Cancelar" OnClick="btncancelar_Click" />
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblerror2" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnvolver" runat="server" Text="Volver" OnClick="btnvolver_Click"/>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
