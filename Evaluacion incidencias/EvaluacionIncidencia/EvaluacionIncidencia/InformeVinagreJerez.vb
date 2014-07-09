Public Class InformeVinagreJerez

    Private Sub InformeVinagreJerez_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.TiposProductos' table. You can move, or remove it, as needed.
        Me.TiposProductosTableAdapter.Fill(Me.DataSet1.TiposProductos)
        'TODO: This line of code loads data into the 'LADataSet.ControlIncidencias' table. You can move, or remove it, as needed.
        Me.ControlIncidenciasTableAdapter.Fill(Me.LADataSet.ControlIncidencias)
        'TODO: This line of code loads data into the 'LADataSet.IncidenciasClientes' table. You can move, or remove it, as needed.
        Me.IncidenciasClientesTableAdapter.Fill(Me.LADataSet.IncidenciasClientes)
        'TODO: This line of code loads data into the 'LADataSet.IncidenciasProveedores' table. You can move, or remove it, as needed.
        Me.IncidenciasProveedoresTableAdapter.Fill(Me.LADataSet.IncidenciasProveedores)
        'TODO: This line of code loads data into the 'LADataSet.IncidenciasInternas' table. You can move, or remove it, as needed.
        Me.IncidenciasInternasTableAdapter.Fill(Me.LADataSet.IncidenciasInternas)
        'TODO: This line of code loads data into the 'LADataSet.ControlIncidencias' table. You can move, or remove it, as needed.
        Me.ControlIncidenciasTableAdapter.Fill(Me.LADataSet.ControlIncidencias)
        'TODO: This line of code loads data into the 'LADataSet.IncidenciasClientes' table. You can move, or remove it, as needed.
        Me.IncidenciasClientesTableAdapter.Fill(Me.LADataSet.IncidenciasClientes)
        'TODO: This line of code loads data into the 'LADataSet.IncidenciasProveedores' table. You can move, or remove it, as needed.
        Me.IncidenciasProveedoresTableAdapter.Fill(Me.LADataSet.IncidenciasProveedores)
        'TODO: This line of code loads data into the 'LADataSet.IncidenciasInternas' table. You can move, or remove it, as needed.
        Me.IncidenciasInternasTableAdapter.Fill(Me.LADataSet.IncidenciasInternas)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub BindingSource1_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class