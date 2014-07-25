Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LADataSet.ResumenEmbotelladosIncluyePicos' table. You can move, or remove it, as needed.
        Me.ResumenEmbotelladosIncluyePicosTableAdapter.Fill(Me.LADataSet.ResumenEmbotelladosIncluyePicos, "01/07/2014", "23/07/2014")
        Me.ResumenEmbotelladosTableAdapter.Fill(Me.LADataSet.ResumenEmbotellados, "01/07/2014", "23/07/2014")
        'TODO: This line of code loads data into the 'LADataSet.ResumenComprasMateriasPrimas' table. You can move, or remove it, as needed.
        Me.ResumenComprasMateriasPrimasTableAdapter.Fill(Me.LADataSet.ResumenComprasMateriasPrimas, "01/07/2014", "23/07/2014")
        'TODO: This line of code loads data into the 'LADataSet.DetalleExpedicionesEmbotellado' table. You can move, or remove it, as needed.
        Me.DetalleExpedicionesEmbotelladoTableAdapter.Fill(Me.LADataSet.DetalleExpedicionesEmbotellado, "01/07/2014", "23/07/2014")
        'TODO: This line of code loads data into the 'LADataSet.ResumenUsadoIngrediente' table. You can move, or remove it, as needed.
        Me.ResumenUsadoIngredienteTableAdapter.Fill(Me.LADataSet.ResumenUsadoIngrediente, "01/07/2014", "23/07/2014")
        'TODO: This line of code loads data into the 'LADataSet.ResumenExpedicionEmbotellados' table. You can move, or remove it, as needed.
        Me.ResumenExpedicionEmbotelladosTableAdapter.Fill(Me.LADataSet.ResumenExpedicionEmbotellados, "01/07/2014", "23/07/2014")
        'TODO: This line of code loads data into the 'LADataSet.ResumenExpedicionGranel' table. You can move, or remove it, as needed.
        Me.ResumenExpedicionGranelTableAdapter.Fill(Me.LADataSet.ResumenExpedicionGranel, "01/07/2014", "23/07/2014")

        Me.ReportViewer1.RefreshReport()
    End Sub

End Class
