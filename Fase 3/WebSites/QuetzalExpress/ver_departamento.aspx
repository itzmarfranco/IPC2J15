<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ver_departamento.aspx.cs" Inherits="ver_departamento" %>

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
                    <asp:GridView ID="gvdepartamento" runat="server" OnRowCommand="gvdepartamento_RowCommand">
                        <Columns>
                            <asp:ButtonField ButtonType="Button" CommandName="modificar" Text="Modificar" />
                            <asp:ButtonField ButtonType="Button" CommandName="despedir" HeaderText="Despedir" ShowHeader="True" Text=":(" />
                        </Columns>
                    </asp:GridView>
                </td>
                <td>
                    <table id ="ta" runat="server" visible="false">
                        <tr>
                            <td>
                                <asp:Label ID="lblid" runat="server" Text=""></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Sueldo:
                            </td>
                            <td>
                                <asp:TextBox ID="txtsueldo" runat="server" TextMode="Number"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Sucursal:
                            </td>
                            <td>
                                <asp:TextBox ID="txtsucursal" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Departamento:
                            </td>
                            <td>
                                <asp:TextBox ID="txtdepartamento" runat="server"></asp:TextBox>
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
