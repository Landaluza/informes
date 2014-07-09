Public Class IncidenciasCalidad

    Private Sub IncidenciasCalidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LADataSet.IncidenciasCalidadEnvasado' table. You can move, or remove it, as needed.
        Me.IncidenciasCalidadEnvasadoTableAdapter.Fill(Me.LADataSet.IncidenciasCalidadEnvasado, "05/05/2014", "05/05/2014")

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class