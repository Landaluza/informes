Public Class frmIncidenciasEntreFehcas
    Private connection As String
    Private fecha As DateTime
    Private fecha2 As DateTime


    Public Sub New()
        InitializeComponent()
        Me.fecha = DateTime.Now.Date.AddDays(-10)
        Me.fecha2 = DateTime.Now.Date.AddDays(-2)
        'Throw New Exception("Constructor no valido")
    End Sub

    Public Sub New(ByVal cadena As String, ByVal fechaInicio As DateTime, ByVal fechafin As DateTime)
        InitializeComponent()

        Me.connection = cadena
        My.Settings.Item("LAConnectionString") = Me.connection
        Me.fecha = fechaInicio
        Me.fecha2 = fechafin
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        recargar()
    End Sub

    Private Sub recargar()
        Me.LADataSet.EnforceConstraints = False
        Dim par1 As New Microsoft.Reporting.WinForms.ReportParameter("fecha1", Me.fecha.ToShortDateString)
        Dim par2 As New Microsoft.Reporting.WinForms.ReportParameter("fecha2", Me.fecha2.ToShortDateString)



        ReportViewer1.LocalReport.SetParameters(par1)
        ReportViewer1.LocalReport.SetParameters(par2)
        'TODO: esta línea de código carga datos en la tabla 'LADataSet.ListadoIncidencias' Puede moverla o quitarla según sea necesario.
        Me.ListadoIncidenciasTableAdapter.Fill(Me.LADataSet.ListadoIncidencias, Me.fecha, Me.fecha2)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
