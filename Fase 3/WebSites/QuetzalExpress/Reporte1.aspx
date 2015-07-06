<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Reporte1.aspx.cs" Inherits="Reporte1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table title="Resumen de paquetes por categoria">
            
            <tr>
                <td>
                    <asp:GridView ID="gv1" runat="server"></asp:GridView>
                </td>
                <td>
                    <asp:GridView ID="gv2" runat="server"></asp:GridView>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnvolver" runat="server" Text="Volver" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
