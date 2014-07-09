Public Class form_estadisticas
    Private connection As String

    Public Sub New()
        InitializeComponent()
        'Throw New Exception("Constructor no valido")
    End Sub

    Public Sub New(ByVal cadena As String)

        InitializeComponent()

        Me.connection = cadena
        My.Settings.Item("LAConnectionString") = Me.connection
    End Sub

    Private Sub form_estadisticas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Throw New Exception("Constructor no valido")

        'TODO: This line of code loads data into the 'DataSetEstadisticas.Envasados' table. You can move, or remove it, as needed.
        Me.EnvasadosTableAdapter.Fill(Me.DataSetEstadisticas.Envasados)
        'TODO: This line of code loads data into the 'DataSetEstadisticas.Envasados' table. You can move, or remove it, as needed.
        Me.EnvasadosTableAdapter.Fill(Me.DataSetEstadisticas.Envasados)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class