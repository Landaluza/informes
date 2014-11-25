Public Class Etiqueta
    Private loteador As Loteado
    Private barcode As CodigoBarra
    Private barc As BarcodeLib.Barcode
    Public id As Integer
    Private LADataSet As etiquetas.LADataSet
    Private EtiquetasPaletSelectTableAdapter As etiquetas.LADataSetTableAdapters.EtiquetasPaletSelectTableAdapter
    Private EtiquetasPaletSelectBindingSource As System.Windows.Forms.BindingSource
    Private ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource
    Private local As Microsoft.Reporting.WinForms.LocalReport
    Private printer As printer
    Public Sub New(ByVal id As Integer, ByVal connection As String)
        My.Settings.Item("LAConnectionString") = connection
        Me.id = id
        loteador = New Loteado
        barcode = New CodigoBarra
        barc = New BarcodeLib.Barcode
        Me.LADataSet = New etiquetas.LADataSet()
        Me.EtiquetasPaletSelectTableAdapter = New etiquetas.LADataSetTableAdapters.EtiquetasPaletSelectTableAdapter()
        Me.LADataSet.DataSetName = "LADataSet"
        Me.LADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        Me.EtiquetasPaletSelectTableAdapter.ClearBeforeFill = True
        Me.EtiquetasPaletSelectBindingSource = New System.Windows.Forms.BindingSource
        Me.EtiquetasPaletSelectBindingSource.DataMember = "EtiquetasPaletSelect"
        Me.EtiquetasPaletSelectBindingSource.DataSource = Me.LADataSet
        ReportDataSource1 = New Microsoft.Reporting.WinForms.ReportDataSource()
        local = New Microsoft.Reporting.WinForms.LocalReport()
        printer = New printer
        printer.cargar_ajustes()
    End Sub

    Public Sub New(ByVal id As Integer)
        Me.id = id
        loteador = New Loteado
        barcode = New CodigoBarra
        barc = New BarcodeLib.Barcode
        Me.LADataSet = New etiquetas.LADataSet()
        Me.EtiquetasPaletSelectTableAdapter = New etiquetas.LADataSetTableAdapters.EtiquetasPaletSelectTableAdapter()
        Me.LADataSet.DataSetName = "LADataSet"
        Me.LADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        Me.EtiquetasPaletSelectTableAdapter.ClearBeforeFill = True
        Me.EtiquetasPaletSelectBindingSource = New System.Windows.Forms.BindingSource
        Me.EtiquetasPaletSelectBindingSource.DataMember = "EtiquetasPaletSelect"
        Me.EtiquetasPaletSelectBindingSource.DataSource = Me.LADataSet
        ReportDataSource1 = New Microsoft.Reporting.WinForms.ReportDataSource()
        local = New Microsoft.Reporting.WinForms.LocalReport()
        printer = New printer
        printer.cargar_ajustes()
    End Sub
    Public Sub print()
        cargar()

        local.DataSources.Clear()

        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.EtiquetasPaletSelectBindingSource
        local.DataSources.Add(ReportDataSource1)
        local.ReportEmbeddedResource = "etiquetas.Report1.rdlc"

        'print_reports.print_microsoft_report(local, "A4")

        printer.print_microsoft_report(local)
    End Sub


    Private Sub cargar()
        Dim dt As etiquetas.LADataSet.EtiquetasPaletSelectDataTable = Me.LADataSet.EtiquetasPaletSelect
        Me.EtiquetasPaletSelectTableAdapter.Fill(dt, id)

        Try

            If Not Me.LADataSet.EtiquetasPaletSelect(0).IsloteNull Then
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
            If Not Me.LADataSet.EtiquetasPaletSelect(0).Isean14Null Then
                Me.LADataSet.EtiquetasPaletSelect(0).SCC = barcode.ajustarSCC_Con_Digito_Control(Me.LADataSet.EtiquetasPaletSelect(0).SCC, Me.LADataSet.EtiquetasPaletSelect(0).ean14)
            Else
                Me.LADataSet.EtiquetasPaletSelect(0).SCC = barcode.ajustarSCC_Con_Digito_Control(Me.LADataSet.EtiquetasPaletSelect(0).SCC, "")
            End If
        Catch ex As Exception
            Me.LADataSet.EtiquetasPaletSelect(0).SCC = barcode.ajustarSCC_Con_Digito_Control(Me.LADataSet.EtiquetasPaletSelect(0).SCC, "")
        End Try

        If Me.LADataSet.EtiquetasPaletSelect(0).IsanoscaducidadNull Then
            Me.LADataSet.EtiquetasPaletSelect(0).CaducidadTexto = ""
        Else
            If Me.LADataSet.EtiquetasPaletSelect(0).anoscaducidad = "" Or Me.LADataSet.EtiquetasPaletSelect(0).anoscaducidad = "0" Then
                Me.LADataSet.EtiquetasPaletSelect(0).CaducidadTexto = ""
            Else
                Me.LADataSet.EtiquetasPaletSelect(0).CaducidadTexto = Convert.ToDateTime(Me.LADataSet.EtiquetasPaletSelect(0).lote).AddYears(Me.LADataSet.EtiquetasPaletSelect(0).anoscaducidad).ToString("yyMMdd")
            End If
        End If


        Try
            If Not Me.LADataSet.EtiquetasPaletSelect(0).Isean14Null Then
                If Me.LADataSet.EtiquetasPaletSelect(0).loteTexto <> "" Then
                    generarCB1()
                Else
                    generarCB1Corto()
                End If
            Else
                Me.LADataSet.EtiquetasPaletSelect(0).img1 = imagenVacia()
            End If
        Catch ex As Exception
            Me.LADataSet.EtiquetasPaletSelect(0).img1 = imagenVacia
        End Try

        generarCB2()

    End Sub


    Private Function imagenVacia() As Byte()
        Dim temp As New Bitmap(1280, 700)
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

        barc.Alignment = BarcodeLib.AlignmentPositions.LEFT
        barc.IncludeLabel = False
        barc.LabelPosition = BarcodeLib.LabelPositions.BOTTOMLEFT

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


End Class
