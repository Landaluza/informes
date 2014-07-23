Public Class frmIncidenciasEntreFehcas
    Private connection As String
    Private fecha As DateTime


    Public Sub New()
        InitializeComponent()
        Me.fecha = DateTime.Now.Date.AddDays(-2)
        'Throw New Exception("Constructor no valido")
    End Sub

    Public Sub New(ByVal cadena As String, ByVal fecha As DateTime)
        InitializeComponent()

        Me.connection = cadena
        My.Settings.Item("LAConnectionString") = Me.connection
        Me.fecha = fecha
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        recargar()
    End Sub

    Private Sub recargar()
        Me.LADataSet.EnforceConstraints = False
        'TODO: esta línea de código carga datos en la tabla 'LADataSet.ListadoIncidencias' Puede moverla o quitarla según sea necesario.
        Me.ListadoIncidenciasTableAdapter.Fill(Me.LADataSet.ListadoIncidencias, Me.fecha)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
