<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_estadisticas
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
        Me.EnvasadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetEstadisticas = New InformesCalidad.DataSetEstadisticas()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.EnvasadosTableAdapter = New InformesCalidad.DataSetEstadisticasTableAdapters.EnvasadosTableAdapter()
        CType(Me.EnvasadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetEstadisticas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EnvasadosBindingSource
        '
        Me.EnvasadosBindingSource.DataMember = "Envasados"
        Me.EnvasadosBindingSource.DataSource = Me.DataSetEstadisticas
        '
        'DataSetEstadisticas
        '
        Me.DataSetEstadisticas.DataSetName = "DataSetEstadisticas"
        Me.DataSetEstadisticas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.EnvasadosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "InformesCalidad.ReportEstadisticas.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(927, 699)
        Me.ReportViewer1.TabIndex = 0
        '
        'EnvasadosTableAdapter
        '
        Me.EnvasadosTableAdapter.ClearBeforeFill = True
        '
        'form_estadisticas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 699)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "form_estadisticas"
        Me.Text = "form_estadisticas"
        CType(Me.EnvasadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetEstadisticas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Private WithEvents EnvasadosBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents DataSetEstadisticas As InformesCalidad.DataSetEstadisticas
    Private WithEvents EnvasadosTableAdapter As InformesCalidad.DataSetEstadisticasTableAdapters.EnvasadosTableAdapter
End Class
