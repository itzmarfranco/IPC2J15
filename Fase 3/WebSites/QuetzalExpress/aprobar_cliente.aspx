<%@ Page Language="C#" AutoEventWireup="true" CodeFile="aprobar_cliente.aspx.cs" Inherits="aprobar_cliente" %>

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
                    <asp:GridView ID="gvsolicitudes" runat="server" OnRowCommand="gvsolicitudes_RowCommand"
                        >
                        <Columns>
                            <asp:ButtonField ButtonType="Button" CommandName="aprobar" HeaderText="Aprobar" ShowHeader="True" Text=":)" />
                        </Columns>
                    </asp:GridView>
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
