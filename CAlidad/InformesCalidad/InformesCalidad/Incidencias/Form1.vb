Public Class Form1
    Private connection As String

    Public Sub New()
        InitializeComponent()
        Throw New Exception("Constructor no valido")
    End Sub

    Public Sub New(ByVal cadena As String)

        InitializeComponent()

        Me.connection = cadena
        My.Settings.Item("LAConnectionString") = Me.connection
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IncidenciasEnvasados.EvolucionIncidencia' table. You can move, or remove it, as needed.
        Me.EvolucionIncidenciaTableAdapter.Fill(Me.IncidenciasEnvasados.EvolucionIncidencia)
        'TODO: This line of code loads data into the 'Controlncidencias.IncidenciasCalidadGeneral' table. You can move, or remove it, as needed.
        Me.IncidenciasCalidadGeneralTableAdapter.Fill(Me.Controlncidencias.IncidenciasCalidadGeneral)
        'TODO: This line of code loads data into the 'Controlncidencias.ControlIncidencias' table. You can move, or remove it, as needed.
        Me.ControlIncidenciasTableAdapter.Fill(Me.Controlncidencias.ControlIncidencias)

        Me.ReportViewer1.RefreshReport()
    End Sub


End Class