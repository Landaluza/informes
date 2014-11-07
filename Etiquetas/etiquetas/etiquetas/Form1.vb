Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LADataSet.EtiquetasPaletSelect' Puede moverla o quitarla según sea necesario.
        ' Me.EtiquetasPaletSelectTableAdapter.Fill(Me.LADataSet.EtiquetasPaletSelect, 0)
        Me.ReportViewer1.RefreshReport()
    End Sub

End Class
