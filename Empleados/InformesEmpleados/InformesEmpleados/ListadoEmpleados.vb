Public Class ListadoEmpleados

    Private connection As String

    Public Sub New()

        InitializeComponent()
        'Throw New Exception("Contructor no valido")
    End Sub

    Public Sub New(ByVal cadena As String)

        InitializeComponent()

        Me.connection = cadena
        My.Settings.Item("LAConnectionString1") = Me.connection
        'My.Settings.Save()
    End Sub

    Private Sub ListadoEmpleados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LADataSet.Empleados' table. You can move, or remove it, as needed.
        Me.EmpleadosTableAdapter.Fill(Me.LADataSet.Empleados)
        'TODO: This line of code loads data into the 'LADataSet.Empleados' table. You can move, or remove it, as needed.
        Me.EmpleadosTableAdapter.Fill(Me.LADataSet.Empleados)
        'TODO: This line of code loads data into the 'LADataSet.Empleados' table. You can move, or remove it, as needed.
        Me.EmpleadosTableAdapter.Fill(Me.LADataSet.Empleados)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
