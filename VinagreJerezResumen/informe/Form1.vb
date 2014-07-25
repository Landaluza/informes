Public Class Form1
    Private fechaInicio As Date
    Private fechaFin As Date

    Public Sub New()

        InitializeComponent()

        fechaInicio = Now.Date.AddMonths(-1)
        fechaFin = Now.Date
    End Sub

    Public Sub New(ByVal fechaIni As Date, ByVal fechaF As Date)

        InitializeComponent()

        Me.fechaFin = fechaF
        Me.fechaInicio = fechaIni
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim parametro As New Microsoft.Reporting.WinForms.ReportParameter("FechaInicio", Me.fechaInicio.ToShortDateString)
        Dim parametro2 As New Microsoft.Reporting.WinForms.ReportParameter("FechaFin", Me.fechaFin.ToShortDateString)
        Me.VisorDeReporte.LocalReport.SetParameters(parametro)
        Me.VisorDeReporte.LocalReport.SetParameters(parametro2)

        'TODO: This line of code loads data into the 'LADataSet.ResumenEmbotelladosIncluyePicos' table. You can move, or remove it, as needed.
        Me.ResumenEmbotelladosIncluyePicosTableAdapter.Fill(Me.LADataSet.ResumenEmbotelladosIncluyePicos, Me.fechaInicio, Me.fechaFin)
        Me.ResumenEmbotelladosTableAdapter.Fill(Me.LADataSet.ResumenEmbotellados, Me.fechaInicio, Me.fechaFin)
        'TODO: This line of code loads data into the 'LADataSet.ResumenComprasMateriasPrimas' table. You can move, or remove it, as needed.
        Me.ResumenComprasMateriasPrimasTableAdapter.Fill(Me.LADataSet.ResumenComprasMateriasPrimas, Me.fechaInicio, Me.fechaFin)
        'TODO: This line of code loads data into the 'LADataSet.DetalleExpedicionesEmbotellado' table. You can move, or remove it, as needed.
        Me.DetalleExpedicionesEmbotelladoTableAdapter.Fill(Me.LADataSet.DetalleExpedicionesEmbotellado, Me.fechaInicio, Me.fechaFin)
        'TODO: This line of code loads data into the 'LADataSet.ResumenUsadoIngrediente' table. You can move, or remove it, as needed.
        Me.ResumenUsadoIngredienteTableAdapter.Fill(Me.LADataSet.ResumenUsadoIngrediente, Me.fechaInicio, Me.fechaFin)
        'TODO: This line of code loads data into the 'LADataSet.ResumenExpedicionEmbotellados' table. You can move, or remove it, as needed.
        Me.ResumenExpedicionEmbotelladosTableAdapter.Fill(Me.LADataSet.ResumenExpedicionEmbotellados, Me.fechaInicio, Me.fechaFin)
        'TODO: This line of code loads data into the 'LADataSet.ResumenExpedicionGranel' table. You can move, or remove it, as needed.
        Me.ResumenExpedicionGranelTableAdapter.Fill(Me.LADataSet.ResumenExpedicionGranel, Me.fechaInicio, Me.fechaFin)

        Me.VisorDeReporte.RefreshReport()
    End Sub

End Class
