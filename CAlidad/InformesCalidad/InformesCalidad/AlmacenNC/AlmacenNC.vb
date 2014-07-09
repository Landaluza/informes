Public Class AlmacenNC
    Private connection As String

    Public Sub New(ByVal cadena As String)

        InitializeComponent()

        Me.connection = cadena
        My.Settings.Item("LAConnectionString") = Me.connection
    End Sub

    Private Sub AlmacenNC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AlmacenNoConforme.AlmacenNC' table. You can move, or remove it, as needed.
        Me.AlmacenNCTableAdapter.Fill(Me.AlmacenNoConforme.AlmacenNC)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class