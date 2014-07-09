Public Class ListadoProveedores

    Private Sub ListadoProveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Throw New Exception("Constructor no valido")
        'TODO: This line of code loads data into the 'Proveedores.ListadoProveedoresCero' table. You can move, or remove it, as needed.
        Me.ListadoProveedoresCeroTableAdapter.Fill(Me.Proveedores.ListadoProveedoresCero)
        Me.Proveedores.EnforceConstraints = False
        'TODO: This line of code loads data into the 'Proveedores.ListadoProveedores' table. You can move, or remove it, as needed.
        Me.ListadoProveedoresTableAdapter.Fill(Me.Proveedores.ListadoProveedores)

        Me.ReportViewer1.RefreshReport()

    End Sub
End Class