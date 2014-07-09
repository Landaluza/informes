Public Class frmInformeContratoEmpleados
    Public Sub New(ByVal conexion As String)

        InitializeComponent()

        My.Settings.Item("LAConnectionString") = conexion
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.EmpleadosContratosTableAdapter.Fill(Me.dsContratosEmpleados.EmpleadosContratos)
        Me.ReportViewer1.LocalReport.EnableExternalImages = True

        Dim dt As DataTable = dsContratosEmpleados.Tables(0)
        Dim s As String

        For Each row As DataRow In dt.Rows
            s = row.Item("Ruta").ToString()
            LoadImage(row, s)
        Next

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub LoadImage(ByRef objDataRow As DataRow, FilePath As String)
        If FilePath = "" Then
            Return
        End If

        If IO.File.Exists(FilePath) Then
            Try
                Dim fs As New IO.FileStream(FilePath, System.IO.FileMode.Open, System.IO.FileAccess.Read)
                '//byte[] Image = new byte[fs.Length];
                '//fs.Read(Image, 0, Convert.ToInt32(fs.Length));

                Dim br As New IO.BinaryReader(fs)
                Dim imgbyte(fs.Length + 1) As Byte

                imgbyte = br.ReadBytes(Convert.ToInt32((fs.Length)))
                fs.Close()

                objDataRow.Item("Image") = imgbyte
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class
