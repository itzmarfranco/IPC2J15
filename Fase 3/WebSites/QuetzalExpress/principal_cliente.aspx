﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="principal_cliente.aspx.cs" Inherits="principal_cliente" %>

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
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/informacion_paquetes.aspx">Información de paquetes</asp:HyperLink>
                </td>            
                <td>
                    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/cotizacion.aspx">Cotización</asp:HyperLink>
                </td>            
                <td>
                    <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/editar_cliente.aspx">Editar perfil</asp:HyperLink>
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
