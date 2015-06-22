<%@ Page Language="C#" AutoEventWireup="true" CodeFile="reportar_perdido.aspx.cs" Inherits="reportar_perdido" %>

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
                    <asp:GridView ID="gvbodega" runat="server" OnRowCommand="gvbodega_RowCommand">
                        <Columns>
                            <asp:ButtonField ButtonType="Button" CommandName="perdido" HeaderText="Reportar" ShowHeader="True" Text="Perdido" />
                        </Columns>
                    </asp:GridView>
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
