﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="reportes.aspx.cs" Inherits="reportes" %>

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
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Reporte1.aspx">Paquetes por categoria</asp:HyperLink>
                </td>
                <td>
                    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Reporte2.aspx">Paquetes por sucursal</asp:HyperLink>
                </td>
                <td>
                    <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Reporte3.aspx">Empleados por departamento</asp:HyperLink>
                </td>
                <td>
                    <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/Reporte4.aspx">Empleados por sucursal</asp:HyperLink>
                </td>
                <td>
                    <asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="~/Reporte5.aspx">TOP categorias</asp:HyperLink>
                </td>
                <td>
                    <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/principal_admin.aspx">Volver</asp:HyperLink>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
