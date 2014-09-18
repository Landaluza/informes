Public Class frmExistenciasPorDepositoFecha

    Sub New(ByVal connectionstring As String)
        InitializeComponent()

        My.Settings.Item("LAConnectionString") = connectionstring
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub frmExistenciasPorDepositoFecha_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim p1 As New Microsoft.Reporting.WinForms.ReportParameter("f1", Me.DateTimePicker1.Value.ToShortDateString)
        Me.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter() {p1})

        Me.DepositosInformeTableAdapter.Fill(Me.DatosVinagreJerez.DepositosInforme)
        Me.ReportViewer1.RefreshReport()
    End Sub

   

    Private Sub DateTimePicker1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        Try
            Dim p1 As New Microsoft.Reporting.WinForms.ReportParameter("f1", Me.DateTimePicker1.Value.ToShortDateString)
            Me.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter() {p1})

            Me.DepositosInformeTableAdapter.Fill(Me.DatosVinagreJerez.DepositosInforme)
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
        End Try
    End Sub
End Class