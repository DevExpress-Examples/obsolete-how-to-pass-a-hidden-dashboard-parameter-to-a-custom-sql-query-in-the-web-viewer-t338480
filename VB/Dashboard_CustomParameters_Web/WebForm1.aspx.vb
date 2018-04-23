Imports System
Imports System.Linq
Imports DevExpress.DashboardWeb
Imports DevExpress.DataAccess.ConnectionParameters

Namespace Dashboard_CustomParameters_Web
    Partial Public Class WebForm1
        Inherits System.Web.UI.Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

        End Sub

        Protected Sub ASPxDashboardViewer1_CustomParameters(ByVal sender As Object, _
                                                            ByVal e As CustomParametersWebEventArgs)
            Dim custIDParameter = e.Parameters.FirstOrDefault(Function(p) p.Name = "custIDDashboardParameter")
            If custIDParameter IsNot Nothing Then
                custIDParameter.Value = "AROUT"
            End If
        End Sub

        Protected Sub ASPxDashboardViewer1_ConfigureDataConnection(ByVal sender As Object, _
                                                                   ByVal e As ConfigureDataConnectionWebEventArgs)
            If e.DataSourceName = "SQL Data Source 1" Then
                Dim parameters As Access97ConnectionParameters =
                    CType(e.ConnectionParameters, Access97ConnectionParameters)
                Dim databasePath As String = Server.MapPath("App_Data/nwind.mdb")
                parameters.FileName = databasePath
            End If
        End Sub
    End Class
End Namespace