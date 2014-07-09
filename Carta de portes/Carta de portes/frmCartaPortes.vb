Public Class frmCartaDePortes
    Private texto As String
    Private pie As String
    Private pie2 As String
    Private detalle As String
    Private cabecera As String

    Public Sub New()
        InitializeComponent()

    End Sub
    Public Sub New(ByVal cabecera As String, ByVal texto As String, ByVal detalle As String, ByVal pie As String, ByVal pie2 As String)
        InitializeComponent()

        Me.cabecera = cabecera
        Me.pie = pie
        Me.pie2 = pie2
        Me.detalle = detalle
        Me.texto = texto
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim params(4) As Microsoft.Reporting.WinForms.ReportParameter



        params(0) = New Microsoft.Reporting.WinForms.ReportParameter("cabecera", cabecera)
        params(1) = New Microsoft.Reporting.WinForms.ReportParameter("texto", texto)
        params(2) = New Microsoft.Reporting.WinForms.ReportParameter("pie", pie)
        params(3) = New Microsoft.Reporting.WinForms.ReportParameter("pie2", pie2)
        params(4) = New Microsoft.Reporting.WinForms.ReportParameter("detalle", detalle)

        Me.ReportViewer1.LocalReport.SetParameters(params)

        Me.ReportViewer1.RefreshReport()

    End Sub
End Class
