Public Class frmOee
    Private con As System.Data.SqlClient.SqlConnection
    Private cmd As System.Data.SqlClient.SqlCommand
    Private reader As System.Data.SqlClient.SqlDataReader
    Private reg As LADataSet.OEEAnoTotalRow
    'Public Sub New()
    '    InitializeComponent()
    '    My.Settings.Item("LAConnectionString") = "workstation id=192.168.1.200;packet size=4096;Connect Timeout = 3000;User ID=ssa;Password=Trucha0122;Trusted_Connection=False;data source= 192.168.1.200;persist security info=False;initial catalog=LA"

    '    con = New System.Data.SqlClient.SqlConnection(My.Settings.Item("LAConnectionString"))
    'End Sub

    Public Sub New(ByVal conexion As String)
        InitializeComponent()
        My.Settings.Item("LAConnectionString") = conexion

        con = New System.Data.SqlClient.SqlConnection(My.Settings.Item("LAConnectionString"))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        refrescar()
    End Sub
    Private Sub refrescar()
        Me.Cursor = Cursors.WaitCursor

        Try

            con.Open()
            cmd = New System.Data.SqlClient.SqlCommand("OEEAnoTotal", con)
            cmd.CommandTimeout = 500
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@fecha", Me.DateTimePicker1.Value)
            reader = cmd.ExecuteReader()

            Me.LADataSet.OEEAnoTotal.Clear()

            While reader.Read
                reg = Me.LADataSet.OEEAnoTotal.NewOEEAnoTotalRow
                reg.fecha = reader("fecha")
                reg.Linea = reader("Linea")
                reg.OEE = reader("OEE")
                Me.LADataSet.OEEAnoTotal.AddOEEAnoTotalRow(reg)
            End While

        Catch ex As Exception
            MessageBox.Show("Error al cargar datos anuales. Detalles: " & Environment.NewLine & ex.Message, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Finally
            'reader.Close()
            If con.State = ConnectionState.Open Then con.Close()
        End Try

        Try
            Me.OEEMesTableAdapter.Fill(Me.LADataSet.OEEMes, Me.DateTimePicker1.Value)
        Catch ex As Exception
            MessageBox.Show("Error al cargar datos diarios. Detalles: " & Environment.NewLine & ex.Message, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        Try
            Me.OEEMesTableAdapter.Adapter.SelectCommand = New System.Data.SqlClient.SqlCommand()
            Me.OEEMesTableAdapter.Adapter.SelectCommand.CommandTimeout = 300
            Me.OEEMesTotalTableAdapter.Fill(Me.LADataSet.OEEMesTotal, Me.DateTimePicker1.Value)
        Catch ex As Exception
            MessageBox.Show("Error al cargar datos mensuales. Detalles: " & Environment.NewLine & ex.Message, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        Me.ReportViewer1.RefreshReport()
        Me.Cursor = Cursors.Default
    End Sub
End Class
