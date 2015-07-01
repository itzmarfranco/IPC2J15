<%@ Page Language="C#" AutoEventWireup="true" CodeFile="cobros.aspx.cs" Inherits="cobros" %>

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
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/agregar_cobro.aspx">Agregar</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:GridView ID="gvcobros" runat="server" OnRowCommand="gvcobros_RowCommand">
                        <Columns>
                            <asp:ButtonField ButtonType="Button" CommandName="modificar" Text="Modificar" />
                            <asp:ButtonField ButtonType="Button" CommandName="inhabilitar" Text="Inhabilitar" />
                        </Columns>
                    </asp:GridView>
                </td>
                <td>
                    <table id="ta" runat="server" visible="false">
                        <tr>
                            <td>
                                <asp:Label ID="lblid" runat="server" Text=""></asp:Label>
                            </td>
                        </tr>
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
                                <asp:Button ID="btnactualizar" runat="server" Text="Actualizar" OnClick="btnactualizar_Click" />
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
                                <asp:Label ID="lblerror" runat="server" Text=""></asp:Label>
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
