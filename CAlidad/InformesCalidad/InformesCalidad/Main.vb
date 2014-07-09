Public Class Main
    Private id_control_incidencia As Integer
    Private connection As String

    Public Sub New()
        'Public Sub New(Optional ByVal controlIncidencia As Integer = 5)

        InitializeComponent()

        Me.id_control_incidencia = 2108 'controlIncidencia
        Throw New Exception("Constructor no valido")
    End Sub

    Public Sub New(ByVal controlIncidencia As Integer, ByVal cadena As String)

        InitializeComponent()

        Me.id_control_incidencia = controlIncidencia
        Me.connection = cadena
        My.Settings.Item("LAConnectionString") = Me.connection
        'My.Settings.Save()
    End Sub

    Private Sub Main_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        refrescar()

        Me.ReportViewer1.RefreshReport()
        'BORRAR LOS AUTOGENERADOS Y AÑADIR LOS NUEVOS EN REFRESCAR
    End Sub

    Private Sub ReportViewer1_ReportRefresh(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles ReportViewer1.ReportRefresh
        refrescar()
    End Sub

    Private Sub refrescar()
        Me.datasetJacinto.EnforceConstraints = False
        Me.DecripcionTableAdapter.Fill(Me.datasetJacinto.Decripcion, Me.id_control_incidencia)
        Me.AccionesInmediatasTableAdapter.Fill(Me.datasetJacinto.AccionesInmediatas, Me.id_control_incidencia)
        Me.AccionesPreventivasTableAdapter.Fill(Me.datasetJacinto.AccionesPreventivas, Me.id_control_incidencia)
        Me.AccionesCorrectivasTableAdapter.Fill(Me.datasetJacinto.AccionesCorrectivas, Me.id_control_incidencia)
        Me.SegumientosIncidenciasTableAdapter.Fill(Me.datasetJacinto.SegumientosIncidencias, Me.id_control_incidencia)
        Me.CausasTableAdapter.Fill(Me.datasetJacinto.Causas, Me.id_control_incidencia)
        Me.CausantesTableAdapter.Fill(Me.datasetJacinto.Causantes, Me.id_control_incidencia)
        Me.AlmacenNoConformeTableAdapter.Fill(Me.datasetJacinto.AlmacenNoConforme, Me.id_control_incidencia)
        Me.EvaluacionIncidenciaTableAdapter.Fill(Me.datasetJacinto.EvaluacionIncidencia, Me.id_control_incidencia)
        Me.IncidenciasEnvasadoTableAdapter.Fill(Me.datasetJacinto.IncidenciasEnvasado, Me.id_control_incidencia)
        Me.AccionesCorrectivasTableAdapter.Fill(Me.datasetJacinto.AccionesCorrectivas, Me.id_control_incidencia)

    End Sub
End Class
