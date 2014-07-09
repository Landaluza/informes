Public Class frmExistenciasPorDeposito

    

    Private Sub frmExistenciasPorDeposito_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim p1 As New Microsoft.Reporting.WinForms.ReportParameter("f1", DateTime.Now.ToShortDateString)
        Me.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter() {p1})

        'TODO: This line of code loads data into the 'DatosVinagreJerez.DepositosInforme' table. You can move, or remove it, as needed.
        Me.DepositosInformeTableAdapter.Fill(Me.DatosVinagreJerez.DepositosInforme)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class