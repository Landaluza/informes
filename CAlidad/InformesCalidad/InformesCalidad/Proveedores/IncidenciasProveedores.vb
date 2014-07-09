Public Class IncidenciasProveedores

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

    Private Sub IncidenciasProveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Throw New Exception("Constructor no valido")

        Me.Proveedores.EnforceConstraints = False
        'TODO: This line of code loads data into the 'Proveedores.ListadoProveedores' table. You can move, or remove it, as needed.
        Me.ListadoProveedoresTableAdapter.Fill(Me.Proveedores.ListadoProveedores)
        'TODO: This line of code loads data into the 'Proveedores.EntregaPedidosProveedor' table. You can move, or remove it, as needed.
        Me.EntregaPedidosProveedorTableAdapter.Fill(Me.Proveedores.EntregaPedidosProveedor)

        'TODO: This line of code loads data into the 'Proveedores.EvolucionMinutosIncidenciasProveedores' table. You can move, or remove it, as needed.
        Me.EvolucionMinutosIncidenciasProveedoresTableAdapter.Fill(Me.Proveedores.EvolucionMinutosIncidenciasProveedores)
        'TODO: This line of code loads data into the 'Proveedores.Proveedores' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'Proveedores.EvolucionGravedadIncidencias' table. You can move, or remove it, as needed.
        Me.EvolucionGravedadIncidenciasTableAdapter.Fill(Me.Proveedores.EvolucionGravedadIncidencias)
        'TODO: This line of code loads data into the 'Proveedores.Proveedores' table. You can move, or remove it, as needed.


        Me.ReportViewer1.RefreshReport()
    End Sub
End Class