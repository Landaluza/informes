Public Class ControlEmpleados
    Private connection As String

    Public Sub New()
        InitializeComponent()
        'Throw New Exception ("Contructor no valido")
    End Sub

    Public Sub New(ByVal cadena As String)

        InitializeComponent()

        Me.connection = cadena
        My.Settings.Item("LAConnectionString1") = Me.connection
        'My.Settings.Save()
    End Sub

    Private Sub ControlEmpleados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.LADataSet.EnforceConstraints = False
        Me.ListadoVestuarioTableAdapter.Fill(Me.LADataSet.ListadoVestuario)

        Me.ListadoOficinasTableAdapter.Fill(Me.LADataSet.ListadoOficinas)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class