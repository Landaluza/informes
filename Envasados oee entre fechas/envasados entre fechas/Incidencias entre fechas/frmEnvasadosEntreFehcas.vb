Public Class frmEnvasadosEntreFehcas
    Private connection As String
    Private fecha As Date
    Private fecha2 As Date


    Public Sub New()
        InitializeComponent()
        Me.fecha = DateTime.Now.Date.AddMonths(-1)
        Me.fecha2 = DateTime.Now.Date.AddDays(-1)
        Me.fecha = New Date(2015, 1, 1) 'DateTime.Now.Date.AddMonths(-12)
        Me.fecha2 = New Date(2015, 4, 1) 'DateTime.Now.Date.AddDays(-1)
        'Throw New Exception("Constructor no valido")
        My.Settings.Item("LAConnectionString") = "Data Source=192.168.1.200;Initial Catalog=LA;Persist Security Info=False;User ID=ssa;Password=Trucha0122;Trusted_Connection=False;"
    End Sub

    Public Sub New(ByVal cadena As String, ByVal fechaInicio As Date, ByVal fechafin As Date)
        InitializeComponent()

        Me.connection = cadena
        My.Settings.Item("LAConnectionString") = Me.connection
        Me.fecha = fechaInicio
        Me.fecha2 = fechafin
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        recargar()
    End Sub

    Private Sub recargar()
        Me.LADataSet.EnforceConstraints = False
        Dim par1 As New Microsoft.Reporting.WinForms.ReportParameter("fecha1", Me.fecha.ToShortDateString)
        Dim par2 As New Microsoft.Reporting.WinForms.ReportParameter("fecha2", Me.fecha2.ToShortDateString)


        ReportViewer1.LocalReport.SetParameters(par1)
        ReportViewer1.LocalReport.SetParameters(par2)
        'TODO: esta línea de código carga datos en la tabla 'LADataSet.ListadoIncidencias' Puede moverla o quitarla según sea necesario.
        Me.ListadoFormatosTableAdapter.Fill(Me.LADataSet.ListadoFormatos, Me.fecha, Me.fecha2)


        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
