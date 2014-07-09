Public Class ControlExpediciones

    Private Sub ControlExpediciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Expediciones.ControlExpediciones' table. You can move, or remove it, as needed.
        Me.ControlExpedicionesTableAdapter.Fill(Me.Expediciones.ControlExpediciones, 800)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class