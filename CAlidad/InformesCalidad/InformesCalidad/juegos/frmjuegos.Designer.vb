<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmjuegos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource6 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource7 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ListadoIncidenciasDiariasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LADataSet = New InformesCalidad.LADataSet()
        Me.CalculoOEEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CalculoEficaciaPorFormatoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnalisisParadasIntrinsecasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CambiosFormatosMaquinaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CambiosFormatosProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FechaOEEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ListadoIncidenciasDiariasTableAdapter = New InformesCalidad.LADataSetTableAdapters.ListadoIncidenciasDiariasTableAdapter()
        Me.CalculoOEETableAdapter = New InformesCalidad.LADataSetTableAdapters.CalculoOEETableAdapter()
        Me.CalculoEficaciaPorFormatoTableAdapter = New InformesCalidad.LADataSetTableAdapters.CalculoEficaciaPorFormatoTableAdapter()
        Me.AnalisisParadasIntrinsecasTableAdapter = New InformesCalidad.LADataSetTableAdapters.AnalisisParadasIntrinsecasTableAdapter()
        Me.CambiosFormatosMaquinaTableAdapter = New InformesCalidad.LADataSetTableAdapters.CambiosFormatosMaquinaTableAdapter()
        Me.CambiosFormatosProductoTableAdapter = New InformesCalidad.LADataSetTableAdapters.CambiosFormatosProductoTableAdapter()
        Me.FechaOEETableAdapter = New InformesCalidad.LADataSetTableAdapters.FechaOEETableAdapter()
        CType(Me.ListadoIncidenciasDiariasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CalculoOEEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CalculoEficaciaPorFormatoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnalisisParadasIntrinsecasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CambiosFormatosMaquinaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CambiosFormatosProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechaOEEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListadoIncidenciasDiariasBindingSource
        '
        Me.ListadoIncidenciasDiariasBindingSource.DataMember = "ListadoIncidenciasDiarias"
        Me.ListadoIncidenciasDiariasBindingSource.DataSource = Me.LADataSet
        '
        'LADataSet
        '
        Me.LADataSet.DataSetName = "LADataSet"
        Me.LADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CalculoOEEBindingSource
        '
        Me.CalculoOEEBindingSource.DataMember = "CalculoOEE"
        Me.CalculoOEEBindingSource.DataSource = Me.LADataSet
        '
        'CalculoEficaciaPorFormatoBindingSource
        '
        Me.CalculoEficaciaPorFormatoBindingSource.DataMember = "CalculoEficaciaPorFormato"
        Me.CalculoEficaciaPorFormatoBindingSource.DataSource = Me.LADataSet
        '
        'AnalisisParadasIntrinsecasBindingSource
        '
        Me.AnalisisParadasIntrinsecasBindingSource.DataMember = "AnalisisParadasIntrinsecas"
        Me.AnalisisParadasIntrinsecasBindingSource.DataSource = Me.LADataSet
        '
        'CambiosFormatosMaquinaBindingSource
        '
        Me.CambiosFormatosMaquinaBindingSource.DataMember = "CambiosFormatosMaquina"
        Me.CambiosFormatosMaquinaBindingSource.DataSource = Me.LADataSet
        '
        'CambiosFormatosProductoBindingSource
        '
        Me.CambiosFormatosProductoBindingSource.DataMember = "CambiosFormatosProducto"
        Me.CambiosFormatosProductoBindingSource.DataSource = Me.LADataSet
        '
        'FechaOEEBindingSource
        '
        Me.FechaOEEBindingSource.DataMember = "FechaOEE"
        Me.FechaOEEBindingSource.DataSource = Me.LADataSet
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "ListadoIncidenciasDiarias"
        ReportDataSource1.Value = Me.ListadoIncidenciasDiariasBindingSource
        ReportDataSource2.Name = "CalculoOEE"
        ReportDataSource2.Value = Me.CalculoOEEBindingSource
        ReportDataSource3.Name = "CalculoEfectividad"
        ReportDataSource3.Value = Me.CalculoEficaciaPorFormatoBindingSource
        ReportDataSource4.Name = "AnalisisArranqueParada"
        ReportDataSource4.Value = Me.AnalisisParadasIntrinsecasBindingSource
        ReportDataSource5.Name = "CambioFormatoMaquina"
        ReportDataSource5.Value = Me.CambiosFormatosMaquinaBindingSource
        ReportDataSource6.Name = "CambiosFormatoProducto"
        ReportDataSource6.Value = Me.CambiosFormatosProductoBindingSource
        ReportDataSource7.Name = "FechaSeleccion"
        ReportDataSource7.Value = Me.FechaOEEBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource5)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource6)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource7)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "InformesCalidad.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(470, 417)
        Me.ReportViewer1.TabIndex = 0
        '
        'ListadoIncidenciasDiariasTableAdapter
        '
        Me.ListadoIncidenciasDiariasTableAdapter.ClearBeforeFill = True
        '
        'CalculoOEETableAdapter
        '
        Me.CalculoOEETableAdapter.ClearBeforeFill = True
        '
        'CalculoEficaciaPorFormatoTableAdapter
        '
        Me.CalculoEficaciaPorFormatoTableAdapter.ClearBeforeFill = True
        '
        'AnalisisParadasIntrinsecasTableAdapter
        '
        Me.AnalisisParadasIntrinsecasTableAdapter.ClearBeforeFill = True
        '
        'CambiosFormatosMaquinaTableAdapter
        '
        Me.CambiosFormatosMaquinaTableAdapter.ClearBeforeFill = True
        '
        'CambiosFormatosProductoTableAdapter
        '
        Me.CambiosFormatosProductoTableAdapter.ClearBeforeFill = True
        '
        'FechaOEETableAdapter
        '
        Me.FechaOEETableAdapter.ClearBeforeFill = True
        '
        'frmjuegos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 417)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmjuegos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmjuegos"
        CType(Me.ListadoIncidenciasDiariasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CalculoOEEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CalculoEficaciaPorFormatoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnalisisParadasIntrinsecasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CambiosFormatosMaquinaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CambiosFormatosProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechaOEEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Private WithEvents ListadoIncidenciasDiariasBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents LADataSet As InformesCalidad.LADataSet
    Private WithEvents CalculoOEEBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents CalculoEficaciaPorFormatoBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents AnalisisParadasIntrinsecasBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents CambiosFormatosMaquinaBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents CambiosFormatosProductoBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents ListadoIncidenciasDiariasTableAdapter As InformesCalidad.LADataSetTableAdapters.ListadoIncidenciasDiariasTableAdapter
    Private WithEvents CalculoOEETableAdapter As InformesCalidad.LADataSetTableAdapters.CalculoOEETableAdapter
    Private WithEvents CalculoEficaciaPorFormatoTableAdapter As InformesCalidad.LADataSetTableAdapters.CalculoEficaciaPorFormatoTableAdapter
    Private WithEvents AnalisisParadasIntrinsecasTableAdapter As InformesCalidad.LADataSetTableAdapters.AnalisisParadasIntrinsecasTableAdapter
    Private WithEvents CambiosFormatosMaquinaTableAdapter As InformesCalidad.LADataSetTableAdapters.CambiosFormatosMaquinaTableAdapter
    Private WithEvents CambiosFormatosProductoTableAdapter As InformesCalidad.LADataSetTableAdapters.CambiosFormatosProductoTableAdapter
    Private WithEvents FechaOEEBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents FechaOEETableAdapter As InformesCalidad.LADataSetTableAdapters.FechaOEETableAdapter
End Class
