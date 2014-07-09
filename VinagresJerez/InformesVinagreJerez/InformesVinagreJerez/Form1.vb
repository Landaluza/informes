Public Class Form1

    Sub New()
        InitializeComponent()

        Me.DateTimePicker2.Value = New DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)
        Me.DateTimePicker1.Value = Me.DateTimePicker2.Value.AddMonths(-1)
    End Sub

    Sub New(ByVal connectionstring As String)
        InitializeComponent()

        My.Settings.Item("LAConnectionString") = connectionstring        
        Me.DateTimePicker2.Value = New DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)
        Me.DateTimePicker1.Value = Me.DateTimePicker2.Value.AddMonths(-1)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, DateTimePicker1.ValueChanged, DateTimePicker2.ValueChanged
        cargar_datos()
    End Sub


    Private Sub cargar_datos()
        Dim p1 As New Microsoft.Reporting.WinForms.ReportParameter("f1", Me.DateTimePicker1.Value.ToShortDateString)
        Dim p2 As New Microsoft.Reporting.WinForms.ReportParameter("f2", Me.DateTimePicker2.Value.ToShortDateString)
        Me.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter() {p1, p2})

        'TODO: This line of code loads data into the 'DatosVinagreJerez.EmbotelladoVjrPorArticulo' table. You can move, or remove it, as needed.
        Me.EmbotelladoVjrPorArticuloTableAdapter.Fill(Me.DatosVinagreJerez.EmbotelladoVjrPorArticulo, Me.DateTimePicker1.Value, Me.DateTimePicker2.Value)

        Me.VjrComoIngredienteTableAdapter.Fill(Me.DatosVinagreJerez.VjrComoIngrediente, Me.DateTimePicker1.Value, Me.DateTimePicker2.Value)
        'TODO: This line of code loads data into the 'DatosVinagreJerez.VjrEmbotelladoAlbaran' table. You can move, or remove it, as needed.
        Me.VjrEmbotelladoAlbaranTableAdapter.Fill(Me.DatosVinagreJerez.VjrEmbotelladoAlbaran, Me.DateTimePicker1.Value, Me.DateTimePicker2.Value)
        'TODO: This line of code loads data into the 'DatosVinagreJerez.VjrEmbotelladoExpedidoArticulo' table. You can move, or remove it, as needed.
        Me.VjrEmbotelladoExpedidoArticuloTableAdapter.Fill(Me.DatosVinagreJerez.VjrEmbotelladoExpedidoArticulo, Me.DateTimePicker1.Value, Me.DateTimePicker2.Value)
        'TODO: This line of code loads data into the 'DatosVinagreJerez.SalidasGranelVjr' table. You can move, or remove it, as needed.
        Me.SalidasGranelVjrTableAdapter.Fill(Me.DatosVinagreJerez.SalidasGranelVjr, Me.DateTimePicker1.Value, Me.DateTimePicker2.Value)


        Me.ReportViewer1.RefreshReport()
    End Sub

End Class
