Public Class Form1
    Private connection As String
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        Me.DateTimePicker1.Value = Me.DateTimePicker2.Value.AddMonths(-1)
    End Sub

    Public Sub New(ByVal cadena As String)

        InitializeComponent()

        Me.DateTimePicker1.Value = Me.DateTimePicker2.Value.AddMonths(-1)
        Me.connection = cadena
        My.Settings.Item("LAConnectionString") = Me.connection
        'My.Settings.Save()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        recargar()
    End Sub

    Private Sub recargar()
        If Me.DateTimePicker1.Value > Me.DateTimePicker2.Value Then
            MessageBox.Show("La fecha 'hasta' no puede ser mayor que la fecha 'desde'", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Me.LADataSet.EnforceConstraints = False
        Me.ControlIncidenciasTableAdapter.Fill(Me.LADataSet.ControlIncidencias, Me.DateTimePicker1.Value, Me.DateTimePicker2.Value)
        Me.IncidenciasClientesTableAdapter.Fill(Me.LADataSet.IncidenciasClientes, Me.DateTimePicker1.Value, Me.DateTimePicker2.Value)
        Me.IncidenciasProveedoresTableAdapter.Fill(Me.LADataSet.IncidenciasProveedores, Me.DateTimePicker1.Value, Me.DateTimePicker2.Value)
        Me.IncidenciasInternasTableAdapter.Fill(Me.LADataSet.IncidenciasInternas, Me.DateTimePicker1.Value, Me.DateTimePicker2.Value)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub
End Class

