<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Reporte1.aspx.cs" Inherits="Reporte1" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

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
        <table>
            <tr>
                <td>
                    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                    <rsweb:ReportViewer ID="mostarReporte" runat="server" Font-Names="Verdana" Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="806px">
                        <LocalReport ReportPath="reporte1.rdlc">
                            <DataSources>
                                <rsweb:ReportDataSource DataSourceId="ObjectDataSource2" Name="DataSet1" />
                                <rsweb:ReportDataSource DataSourceId="ObjectDataSource3" Name="DataSet2" />
                            </DataSources>
                        </LocalReport>
                    </rsweb:ReportViewer>
                    <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" SelectMethod="GetData" TypeName="DataSetTableAdapters.reporte1_2TableAdapter"></asp:ObjectDataSource>
                    <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetData" TypeName="DataSetTableAdapters.reporte1TableAdapter"></asp:ObjectDataSource>
                    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetData" TypeName="Qu3tzal3xpr3ssDataSetTableAdapters.reporte1TableAdapter"></asp:ObjectDataSource>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
