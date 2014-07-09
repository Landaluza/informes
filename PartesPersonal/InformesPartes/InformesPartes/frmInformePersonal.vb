Public Class frmInformePersonal

    Private Sub frmInformePersonal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.Empleados' table. You can move, or remove it, as needed.
        Me.EmpleadosTableAdapter.FillByParametro(Me.DataSet1.Empleados, "iván")

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
