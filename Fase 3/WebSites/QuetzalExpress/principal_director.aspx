<%@ Page Language="C#" AutoEventWireup="true" CodeFile="principal_director.aspx.cs" Inherits="principal_director" %>

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
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/contratar_empleado.aspx">Contratar</asp:HyperLink>
                </td>                
                <td>
                    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/ver_departamento.aspx">Ver departamento</asp:HyperLink>
                </td>
                <td>
                    <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/principal.aspx">Salir</asp:HyperLink>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
