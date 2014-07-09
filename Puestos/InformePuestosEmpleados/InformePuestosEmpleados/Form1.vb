Public Class Form1

    Public Sub New()
        InitializeComponent()
    End Sub
    Public Sub New(ByVal conexion As String)

        InitializeComponent()

        My.Settings.Item("LAConnectionString") = conexion
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtPuestosTableAdapter.Fill(Me.LADataSet.dtPuestos)

        Me.ReportViewer1.RefreshReport()
    End Sub

End Class
