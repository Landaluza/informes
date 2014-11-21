Public Class frmEtiqueta
    Private loteador As Loteado
    Private barcode As CodigoBarra
    Private barc As BarcodeLib.Barcode
    Private id As Integer
    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        id = 56015
        loteador = New Loteado
        barcode = New CodigoBarra
        barc = New BarcodeLib.Barcode
    End Sub

    Public Sub New(ByVal id As Integer, ByVal connection As String)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        Me.id = id
        My.Settings.Item("LAConnectionString") = connection
        loteador = New Loteado
        barcode = New CodigoBarra
        barc = New BarcodeLib.Barcode
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LADataSet.EtiquetasPaletSelect' Puede moverla o quitarla según sea necesario.

        cargar()
    End Sub

    Private Sub cargar()
        Dim dt As etiquetas.LADataSet.EtiquetasPaletSelectDataTable = Me.LADataSet.EtiquetasPaletSelect
        Me.EtiquetasPaletSelectTableAdapter.Fill(dt, id)

        Try

            If Not Convert.IsDBNull(Me.LADataSet.EtiquetasPaletSelect(0).lote) Then
                If Me.LADataSet.EtiquetasPaletSelect(0).TipoLoteado = Loteado.STANDAR Then
                    Me.LADataSet.EtiquetasPaletSelect(0).loteTexto = loteador.Loteado_standar(Me.LADataSet.EtiquetasPaletSelect(0).lote)
                Else
                    Me.LADataSet.EtiquetasPaletSelect(0).loteTexto = loteador.Loteado_cubos(Convert.ToDateTime(Me.LADataSet.EtiquetasPaletSelect(0).lote).AddYears(Me.LADataSet.EtiquetasPaletSelect(0).anoscaducidad))
                End If
            End If
        Catch ex As Exception
            Me.LADataSet.EtiquetasPaletSelect(0).loteTexto = ""            
        End Try

        Try
            If Not Convert.IsDBNull(Me.LADataSet.EtiquetasPaletSelect(0).ean14) Then
                Me.LADataSet.EtiquetasPaletSelect(0).SCC = barcode.ajustarSCC_Con_Digito_Control(Me.LADataSet.EtiquetasPaletSelect(0).SCC, Me.LADataSet.EtiquetasPaletSelect(0).ean14)
            Else
                Me.LADataSet.EtiquetasPaletSelect(0).SCC = barcode.ajustarSCC_Con_Digito_Control(Me.LADataSet.EtiquetasPaletSelect(0).SCC, "")
            End If
        Catch ex As Exception
            Me.LADataSet.EtiquetasPaletSelect(0).SCC = barcode.ajustarSCC_Con_Digito_Control(Me.LADataSet.EtiquetasPaletSelect(0).SCC, "")
        End Try


        If Me.LADataSet.EtiquetasPaletSelect(0).anoscaducidad = "" Then
            Me.LADataSet.EtiquetasPaletSelect(0).CaducidadTexto = ""
        Else
            Me.LADataSet.EtiquetasPaletSelect(0).CaducidadTexto = Convert.ToDateTime(Me.LADataSet.EtiquetasPaletSelect(0).lote).AddYears(Me.LADataSet.EtiquetasPaletSelect(0).anoscaducidad).ToString("yyMMdd")
        End If

        Try
            If Not Convert.IsDBNull(Me.LADataSet.EtiquetasPaletSelect(0).ean14) Then
                If Me.LADataSet.EtiquetasPaletSelect(0).loteTexto <> "" Then
                    generarCB1()
                Else
                    generarCB1Corto()
                End If
            Else
                Me.LADataSet.EtiquetasPaletSelect(0).img1 = imagenVacia
            End If
        Catch ex As Exception
            Me.LADataSet.EtiquetasPaletSelect(0).img1 = imagenVacia
        End Try

        

        generarCB2()


        Me.ReportViewer1.RefreshReport()

    End Sub


    Private Function imagenVacia() As Byte()
        Dim temp As New Bitmap(1280, 700)
        'temp.SetPixel(0, 0, Me.BackColor)


        Dim bitmapbytes As Byte()
        Using stream As New System.IO.MemoryStream()
            temp.Save(stream, Imaging.ImageFormat.Jpeg)
            bitmapbytes = stream.ToArray
        End Using
        Return bitmapbytes
    End Function

    Private Sub generarCB1()
        Dim gs As GS1 = Me.barcode.calcular_codigo_barras_1(Me.LADataSet.EtiquetasPaletSelect(0).ean14, Me.LADataSet.EtiquetasPaletSelect(0).loteTexto)
        Dim texto As String = gs.Empresa

        Dim temp As Bitmap
        ' Dim temp As New Bitmap(1280, 700)
        'temp.SetPixel(0, 0, Me.BackColor)


        barc.Alignment = BarcodeLib.AlignmentPositions.LEFT
        barc.IncludeLabel = False
        barc.LabelPosition = BarcodeLib.LabelPositions.BOTTOMLEFT
        '        Barcode1.Image = barc.Encode(BarcodeLib.TYPE.CODE128, texto, Color.Black, Color.White, 350, 120)

        temp = New Bitmap(barc.Encode(BarcodeLib.TYPE.LOTE, texto, Color.Black, Color.White, 1280, 700))

        Dim bitmapbytes As Byte()
        Using stream As New System.IO.MemoryStream()
            temp.Save(stream, Imaging.ImageFormat.Jpeg)
            bitmapbytes = stream.ToArray
        End Using
        Me.LADataSet.EtiquetasPaletSelect(0).img1 = bitmapbytes
        Me.LADataSet.EtiquetasPaletSelect(0).texto_codigo1 = gs.Empresa_etiqueta
    End Sub

    Private Sub generarCB1Corto()
        Dim gs As GS1 = Me.barcode.calcular_codigo_barras_1(Me.LADataSet.EtiquetasPaletSelect(0).ean14, "")
        Dim texto As String = gs.Empresa.Replace("(", "").Replace(")", "")
        Dim temp As Bitmap

        barc.Alignment = BarcodeLib.AlignmentPositions.LEFT
        barc.IncludeLabel = False
        barc.LabelPosition = BarcodeLib.LabelPositions.BOTTOMLEFT

        temp = New Bitmap(barc.Encode(BarcodeLib.TYPE.DOYPACK, texto, Color.Black, Color.White, 1280, 700))

        Dim bitmapbytes As Byte()
        Using stream As New System.IO.MemoryStream()
            temp.Save(stream, Imaging.ImageFormat.Jpeg)
            bitmapbytes = stream.ToArray
        End Using
        Me.LADataSet.EtiquetasPaletSelect(0).img1 = bitmapbytes
        Me.LADataSet.EtiquetasPaletSelect(0).texto_codigo1 = gs.Empresa_etiqueta
    End Sub


    Private Sub generarCB2()
        Dim gs As GS1 = Me.barcode.calcular_codigoBarras2(Me.LADataSet.EtiquetasPaletSelect(0).SCC, Me.LADataSet.EtiquetasPaletSelect(0).CaducidadTexto)
        Dim texto As String = gs.SSCC

        Dim temp As Bitmap

        barc.Alignment = BarcodeLib.AlignmentPositions.LEFT
        barc.IncludeLabel = False
        barc.LabelPosition = BarcodeLib.LabelPositions.BOTTOMLEFT
        temp = New Bitmap(barc.Encode(BarcodeLib.TYPE.SSCC, texto, Color.Black, Color.White, 1280, 700))

        Dim bitmapbytes As Byte()
        Using stream As New System.IO.MemoryStream
            temp.Save(stream, Imaging.ImageFormat.Jpeg)
            bitmapbytes = stream.ToArray
        End Using
        Me.LADataSet.EtiquetasPaletSelect(0).img2 = bitmapbytes
        Me.LADataSet.EtiquetasPaletSelect(0).texto_codigo2 = gs.SSCC_etiqueta
    End Sub

    
    Private Sub frmEtiqueta_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim pr As New printer
        pr.print_microsoft_report(Me.ReportViewer1.LocalReport)
        'print_reports.print_microsoft_report(Me.ReportViewer1.LocalReport)
    End Sub
End Class
