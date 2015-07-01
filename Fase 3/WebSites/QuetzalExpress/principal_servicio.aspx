<%@ Page Language="C#" AutoEventWireup="true" CodeFile="principal_servicio.aspx.cs" Inherits="principal_servicio" %>

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
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/entregar_paquete.aspx">Entrega de paquetes</asp:HyperLink>
            </td>
            <td>
                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/devolucion.aspx">Devolución</asp:HyperLink>
            </td>
            <td>
                <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/buscar_cliente.aspx">Buscar cliente</asp:HyperLink>
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
