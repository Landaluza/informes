Public Class frmEnvasadosMensuales
    Private connection As String

    Public Sub New(ByVal cadena As String)
        InitializeComponent()

        Me.connection = cadena
        My.Settings.Item("LAConnectionString") = Me.connection
    End Sub
    Private Sub frmEnvasadosMensuales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LADataSet.ListadoFormatosPorMes' Puede moverla o quitarla según sea necesario.
        
    End Sub

    Private Sub recargar()
        Dim fechaIni As Date = New Date(Me.DateTimePicker1.Value.Date.Year, 1, 1)
        Dim fechaFin As Date = New Date(Me.DateTimePicker1.Value.Date.Year, 12, 31)

        Me.ListadoFormatosPorMesTableAdapter.Fill(Me.LADataSet.ListadoFormatosPorMes, fechaIni, fechaFin)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        recargar()
    End Sub
End Class