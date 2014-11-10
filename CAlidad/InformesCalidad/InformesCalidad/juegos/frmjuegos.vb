Public Class frmjuegos
    Private connection As String
    Private fecha As DateTime


    Public Sub New()
        InitializeComponent()
        Me.fecha = DateTime.Now.Date.AddDays(-4)
        'Throw New Exception("Constructor no valido")
    End Sub

    Public Sub New(ByVal cadena As String, ByVal fecha As DateTime)
        InitializeComponent()

        Me.connection = cadena
        My.Settings.Item("LAConnectionString") = Me.connection
        Me.fecha = fecha
    End Sub

    Private Sub frmjuegos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.LADataSet.EnforceConstraints = False
        Dim cad_fecha As String = Me.fecha.ToShortDateString

        'TODO: This line of code loads data into the 'LADataSet.FechaOEE' table. You can move, or remove it, as needed.
        Me.FechaOEETableAdapter.Fill(Me.LADataSet.FechaOEE, cad_fecha)

        'TODO: This line of code loads data into the 'LADataSet.ListadoIncidenciasDiarias' table. You can move, or remove it, as needed.
        Me.ListadoIncidenciasDiariasTableAdapter.Fill(Me.LADataSet.ListadoIncidenciasDiarias, cad_fecha)
        'TODO: This line of code loads data into the 'LADataSet.CalculoOEE' table. You can move, or remove it, as needed.
        Me.CalculoOEETableAdapter.Fill(Me.LADataSet.CalculoOEE, Me.fecha)
        'TODO: This line of code loads data into the 'LADataSet.CalculoEficaciaPorFormato' table. You can move, or remove it, as needed.
        Me.CalculoEficaciaPorFormatoTableAdapter.Fill(Me.LADataSet.CalculoEficaciaPorFormato, Me.fecha)
        'TODO: This line of code loads data into the 'LADataSet.AnalisisParadasIntrinsecas' table. You can move, or remove it, as needed.
        Me.AnalisisParadasIntrinsecasTableAdapter.Fill(Me.LADataSet.AnalisisParadasIntrinsecas, cad_fecha)
        'TODO: This line of code loads data into the 'LADataSet.CambiosFormatosMaquina' table. You can move, or remove it, as needed.
        Me.CambiosFormatosMaquinaTableAdapter.Fill(Me.LADataSet.CambiosFormatosMaquina, Me.fecha)
        'TODO: This line of code loads data into the 'LADataSet.CambiosFormatosProducto' table. You can move, or remove it, as needed.
        Me.CambiosFormatosProductoTableAdapter.Fill(Me.LADataSet.CambiosFormatosProducto, Me.fecha)



        Me.ReportViewer1.RefreshReport()
    End Sub

  
End Class