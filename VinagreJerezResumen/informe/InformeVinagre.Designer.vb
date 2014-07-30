<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InformeVinagre
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
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
        Me.ResumenExpedicionEmbotelladosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LADataSet = New InformeResumenVinagre.LADataSet()
        Me.ResumenExpedicionGranelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ResumenUsadoIngredienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DetalleExpedicionesEmbotelladoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ResumenComprasMateriasPrimasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ResumenEmbotelladosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ResumenEmbotelladosIncluyePicosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VisorDeReporte = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ResumenExpedicionEmbotelladosTableAdapter = New InformeResumenVinagre.LADataSetTableAdapters.ResumenExpedicionEmbotelladosTableAdapter()
        Me.ResumenExpedicionGranelTableAdapter = New InformeResumenVinagre.LADataSetTableAdapters.ResumenExpedicionGranelTableAdapter()
        Me.ResumenUsadoIngredienteTableAdapter = New InformeResumenVinagre.LADataSetTableAdapters.ResumenUsadoIngredienteTableAdapter()
        Me.DetalleExpedicionesEmbotelladoTableAdapter = New InformeResumenVinagre.LADataSetTableAdapters.DetalleExpedicionesEmbotelladoTableAdapter()
        Me.ResumenComprasMateriasPrimasTableAdapter = New InformeResumenVinagre.LADataSetTableAdapters.ResumenComprasMateriasPrimasTableAdapter()
        Me.ResumenEmbotelladosTableAdapter = New InformeResumenVinagre.LADataSetTableAdapters.ResumenEmbotelladosTableAdapter()
        Me.ResumenEmbotelladosIncluyePicosTableAdapter = New InformeResumenVinagre.LADataSetTableAdapters.ResumenEmbotelladosIncluyePicosTableAdapter()
        CType(Me.ResumenExpedicionEmbotelladosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResumenExpedicionGranelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResumenUsadoIngredienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetalleExpedicionesEmbotelladoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResumenComprasMateriasPrimasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResumenEmbotelladosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResumenEmbotelladosIncluyePicosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ResumenExpedicionEmbotelladosBindingSource
        '
        Me.ResumenExpedicionEmbotelladosBindingSource.DataMember = "ResumenExpedicionEmbotellados"
        Me.ResumenExpedicionEmbotelladosBindingSource.DataSource = Me.LADataSet
        '
        'LADataSet
        '
        Me.LADataSet.DataSetName = "LADataSet"
        Me.LADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ResumenExpedicionGranelBindingSource
        '
        Me.ResumenExpedicionGranelBindingSource.DataMember = "ResumenExpedicionGranel"
        Me.ResumenExpedicionGranelBindingSource.DataSource = Me.LADataSet
        '
        'ResumenUsadoIngredienteBindingSource
        '
        Me.ResumenUsadoIngredienteBindingSource.DataMember = "ResumenUsadoIngrediente"
        Me.ResumenUsadoIngredienteBindingSource.DataSource = Me.LADataSet
        '
        'DetalleExpedicionesEmbotelladoBindingSource
        '
        Me.DetalleExpedicionesEmbotelladoBindingSource.DataMember = "DetalleExpedicionesEmbotellado"
        Me.DetalleExpedicionesEmbotelladoBindingSource.DataSource = Me.LADataSet
        '
        'ResumenComprasMateriasPrimasBindingSource
        '
        Me.ResumenComprasMateriasPrimasBindingSource.DataMember = "ResumenComprasMateriasPrimas"
        Me.ResumenComprasMateriasPrimasBindingSource.DataSource = Me.LADataSet
        '
        'ResumenEmbotelladosBindingSource
        '
        Me.ResumenEmbotelladosBindingSource.DataMember = "ResumenEmbotellados"
        Me.ResumenEmbotelladosBindingSource.DataSource = Me.LADataSet
        '
        'ResumenEmbotelladosIncluyePicosBindingSource
        '
        Me.ResumenEmbotelladosIncluyePicosBindingSource.DataMember = "ResumenEmbotelladosIncluyePicos"
        Me.ResumenEmbotelladosIncluyePicosBindingSource.DataSource = Me.LADataSet
        '
        'VisorDeReporte
        '
        Me.VisorDeReporte.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "ResumenExpedicionEmbotellados"
        ReportDataSource1.Value = Me.ResumenExpedicionEmbotelladosBindingSource
        ReportDataSource2.Name = "ResumenExpedicionGranel"
        ReportDataSource2.Value = Me.ResumenExpedicionGranelBindingSource
        ReportDataSource3.Name = "ResumenUsadoIngrediente"
        ReportDataSource3.Value = Me.ResumenUsadoIngredienteBindingSource
        ReportDataSource4.Name = "DetalleExpedicionesEmbotellado"
        ReportDataSource4.Value = Me.DetalleExpedicionesEmbotelladoBindingSource
        ReportDataSource5.Name = "ResumenComprasMateriasPrimas"
        ReportDataSource5.Value = Me.ResumenComprasMateriasPrimasBindingSource
        ReportDataSource6.Name = "ResumenEmbotellados"
        ReportDataSource6.Value = Me.ResumenEmbotelladosBindingSource
        ReportDataSource7.Name = "ResumenEmbotelladosIncluyePicos"
        ReportDataSource7.Value = Me.ResumenEmbotelladosIncluyePicosBindingSource
        Me.VisorDeReporte.LocalReport.DataSources.Add(ReportDataSource1)
        Me.VisorDeReporte.LocalReport.DataSources.Add(ReportDataSource2)
        Me.VisorDeReporte.LocalReport.DataSources.Add(ReportDataSource3)
        Me.VisorDeReporte.LocalReport.DataSources.Add(ReportDataSource4)
        Me.VisorDeReporte.LocalReport.DataSources.Add(ReportDataSource5)
        Me.VisorDeReporte.LocalReport.DataSources.Add(ReportDataSource6)
        Me.VisorDeReporte.LocalReport.DataSources.Add(ReportDataSource7)
        Me.VisorDeReporte.LocalReport.ReportEmbeddedResource = "InformeResumenVinagre.Report1.rdlc"
        Me.VisorDeReporte.Location = New System.Drawing.Point(0, 0)
        Me.VisorDeReporte.Name = "VisorDeReporte"
        Me.VisorDeReporte.Size = New System.Drawing.Size(565, 386)
        Me.VisorDeReporte.TabIndex = 0
        '
        'ResumenExpedicionEmbotelladosTableAdapter
        '
        Me.ResumenExpedicionEmbotelladosTableAdapter.ClearBeforeFill = True
        '
        'ResumenExpedicionGranelTableAdapter
        '
        Me.ResumenExpedicionGranelTableAdapter.ClearBeforeFill = True
        '
        'ResumenUsadoIngredienteTableAdapter
        '
        Me.ResumenUsadoIngredienteTableAdapter.ClearBeforeFill = True
        '
        'DetalleExpedicionesEmbotelladoTableAdapter
        '
        Me.DetalleExpedicionesEmbotelladoTableAdapter.ClearBeforeFill = True
        '
        'ResumenComprasMateriasPrimasTableAdapter
        '
        Me.ResumenComprasMateriasPrimasTableAdapter.ClearBeforeFill = True
        '
        'ResumenEmbotelladosTableAdapter
        '
        Me.ResumenEmbotelladosTableAdapter.ClearBeforeFill = True
        '
        'ResumenEmbotelladosIncluyePicosTableAdapter
        '
        Me.ResumenEmbotelladosIncluyePicosTableAdapter.ClearBeforeFill = True
        '
        'InformeVinagre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 386)
        Me.Controls.Add(Me.VisorDeReporte)
        Me.Name = "InformeVinagre"
        Me.Text = "Resumen vinagre"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ResumenExpedicionEmbotelladosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResumenExpedicionGranelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResumenUsadoIngredienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetalleExpedicionesEmbotelladoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResumenComprasMateriasPrimasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResumenEmbotelladosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResumenEmbotelladosIncluyePicosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents VisorDeReporte As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ResumenExpedicionEmbotelladosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LADataSet As InformeResumenVinagre.LADataSet
    Friend WithEvents ResumenExpedicionGranelBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ResumenUsadoIngredienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DetalleExpedicionesEmbotelladoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ResumenExpedicionEmbotelladosTableAdapter As InformeResumenVinagre.LADataSetTableAdapters.ResumenExpedicionEmbotelladosTableAdapter
    Friend WithEvents ResumenExpedicionGranelTableAdapter As InformeResumenVinagre.LADataSetTableAdapters.ResumenExpedicionGranelTableAdapter
    Friend WithEvents ResumenUsadoIngredienteTableAdapter As InformeResumenVinagre.LADataSetTableAdapters.ResumenUsadoIngredienteTableAdapter
    Friend WithEvents DetalleExpedicionesEmbotelladoTableAdapter As InformeResumenVinagre.LADataSetTableAdapters.DetalleExpedicionesEmbotelladoTableAdapter
    Friend WithEvents ResumenComprasMateriasPrimasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ResumenComprasMateriasPrimasTableAdapter As InformeResumenVinagre.LADataSetTableAdapters.ResumenComprasMateriasPrimasTableAdapter
    Friend WithEvents ResumenEmbotelladosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ResumenEmbotelladosTableAdapter As InformeResumenVinagre.LADataSetTableAdapters.ResumenEmbotelladosTableAdapter
    Friend WithEvents ResumenEmbotelladosIncluyePicosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ResumenEmbotelladosIncluyePicosTableAdapter As InformeResumenVinagre.LADataSetTableAdapters.ResumenEmbotelladosIncluyePicosTableAdapter

End Class
