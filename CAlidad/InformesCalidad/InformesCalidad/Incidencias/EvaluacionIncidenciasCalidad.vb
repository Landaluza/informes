Public Class EvaluacionIncidenciasCalidad

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        My.Settings.Item("LAConnectionString") = "Data Source=192.168.1.130;Initial Catalog=LA;Persist Security Info=True;User ID=ssa;Password=Trucha0122"

    End Sub
    Private Sub EvaluacionIncidenciasCalidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AlmacenNoConforme.AlmacenNC' table. You can move, or remove it, as needed.
        Me.AlmacenNCTableAdapter.Fill(Me.AlmacenNoConforme.AlmacenNC)
        'TODO: This line of code loads data into the 'Controlncidencias.IncidenciasCalidadGeneral' table. You can move, or remove it, as needed.
        Me.IncidenciasCalidadGeneralTableAdapter.Fill(Me.Controlncidencias.IncidenciasCalidadGeneral)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class