<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim ReportDataSource8 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource9 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource10 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource11 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.AccionesInmediatasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.datasetJacinto = New InformesCalidad.datasetJacinto()
        Me.AccionesPreventivasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccionesCorrectivasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SegumientosIncidenciasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CausasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CausantesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DecripcionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlmacenNoConformeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EvaluacionIncidenciaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IncidenciasEnvasadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.AccionesInmediatasTableAdapter = New InformesCalidad.datasetJacintoTableAdapters.AccionesInmediatasTableAdapter()
        Me.AccionesPreventivasTableAdapter = New InformesCalidad.datasetJacintoTableAdapters.AccionesPreventivasTableAdapter()
        Me.AccionesCorrectivasTableAdapter = New InformesCalidad.datasetJacintoTableAdapters.AccionesCorrectivasTableAdapter()
        Me.SegumientosIncidenciasTableAdapter = New InformesCalidad.datasetJacintoTableAdapters.SegumientosIncidenciasTableAdapter()
        Me.CausasTableAdapter = New InformesCalidad.datasetJacintoTableAdapters.CausasTableAdapter()
        Me.CausantesTableAdapter = New InformesCalidad.datasetJacintoTableAdapters.CausantesTableAdapter()
        Me.DecripcionTableAdapter = New InformesCalidad.datasetJacintoTableAdapters.DecripcionTableAdapter()
        Me.AlmacenNoConformeTableAdapter = New InformesCalidad.datasetJacintoTableAdapters.AlmacenNoConformeTableAdapter()
        Me.EvaluacionIncidenciaTableAdapter = New InformesCalidad.datasetJacintoTableAdapters.EvaluacionIncidenciaTableAdapter()
        Me.IncidenciasEnvasadoTableAdapter = New InformesCalidad.datasetJacintoTableAdapters.IncidenciasEnvasadoTableAdapter()
        CType(Me.AccionesInmediatasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datasetJacinto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccionesPreventivasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccionesCorrectivasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SegumientosIncidenciasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CausasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CausantesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecripcionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlmacenNoConformeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EvaluacionIncidenciaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IncidenciasEnvasadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AccionesInmediatasBindingSource
        '
        Me.AccionesInmediatasBindingSource.DataMember = "AccionesInmediatas"
        Me.AccionesInmediatasBindingSource.DataSource = Me.datasetJacinto
        '
        'datasetJacinto
        '
        Me.datasetJacinto.DataSetName = "datasetJacinto"
        Me.datasetJacinto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AccionesPreventivasBindingSource
        '
        Me.AccionesPreventivasBindingSource.DataMember = "AccionesPreventivas"
        Me.AccionesPreventivasBindingSource.DataSource = Me.datasetJacinto
        '
        'AccionesCorrectivasBindingSource
        '
        Me.AccionesCorrectivasBindingSource.DataMember = "AccionesCorrectivas"
        Me.AccionesCorrectivasBindingSource.DataSource = Me.datasetJacinto
        '
        'SegumientosIncidenciasBindingSource
        '
        Me.SegumientosIncidenciasBindingSource.DataMember = "SegumientosIncidencias"
        Me.SegumientosIncidenciasBindingSource.DataSource = Me.datasetJacinto
        '
        'CausasBindingSource
        '
        Me.CausasBindingSource.DataMember = "Causas"
        Me.CausasBindingSource.DataSource = Me.datasetJacinto
        '
        'CausantesBindingSource
        '
        Me.CausantesBindingSource.DataMember = "Causantes"
        Me.CausantesBindingSource.DataSource = Me.datasetJacinto
        '
        'DecripcionBindingSource
        '
        Me.DecripcionBindingSource.DataMember = "Decripcion"
        Me.DecripcionBindingSource.DataSource = Me.datasetJacinto
        '
        'AlmacenNoConformeBindingSource
        '
        Me.AlmacenNoConformeBindingSource.DataMember = "AlmacenNoConforme"
        Me.AlmacenNoConformeBindingSource.DataSource = Me.datasetJacinto
        '
        'EvaluacionIncidenciaBindingSource
        '
        Me.EvaluacionIncidenciaBindingSource.DataMember = "EvaluacionIncidencia"
        Me.EvaluacionIncidenciaBindingSource.DataSource = Me.datasetJacinto
        '
        'IncidenciasEnvasadoBindingSource
        '
        Me.IncidenciasEnvasadoBindingSource.DataMember = "IncidenciasEnvasado"
        Me.IncidenciasEnvasadoBindingSource.DataSource = Me.datasetJacinto
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "AccionesInmediatas"
        ReportDataSource1.Value = Me.AccionesInmediatasBindingSource
        ReportDataSource2.Name = "AccionesPreventivas"
        ReportDataSource2.Value = Me.AccionesPreventivasBindingSource
        ReportDataSource3.Name = "accionesCorrectivas"
        ReportDataSource3.Value = Me.AccionesCorrectivasBindingSource
        ReportDataSource4.Name = "Seguimiento"
        ReportDataSource4.Value = Me.SegumientosIncidenciasBindingSource
        ReportDataSource5.Name = "Causas"
        ReportDataSource5.Value = Me.CausasBindingSource
        ReportDataSource6.Name = "Causantes"
        ReportDataSource6.Value = Me.CausantesBindingSource
        ReportDataSource7.Name = "General"
        ReportDataSource7.Value = Me.DecripcionBindingSource
        ReportDataSource8.Name = "AlmacenNoConforme"
        ReportDataSource8.Value = Me.AlmacenNoConformeBindingSource
        ReportDataSource9.Name = "EvaluacionIncidencia"
        ReportDataSource9.Value = Me.EvaluacionIncidenciaBindingSource
        ReportDataSource10.Name = "IncidenciasEnvasado"
        ReportDataSource10.Value = Me.IncidenciasEnvasadoBindingSource
        ReportDataSource11.Name = "AccionesCorrectivas"
        ReportDataSource11.Value = Me.AccionesCorrectivasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource5)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource6)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource7)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource8)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource9)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource10)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource11)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "InformesCalidad.reporte1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(628, 407)
        Me.ReportViewer1.TabIndex = 0
        '
        'AccionesInmediatasTableAdapter
        '
        Me.AccionesInmediatasTableAdapter.ClearBeforeFill = True
        '
        'AccionesPreventivasTableAdapter
        '
        Me.AccionesPreventivasTableAdapter.ClearBeforeFill = True
        '
        'AccionesCorrectivasTableAdapter
        '
        Me.AccionesCorrectivasTableAdapter.ClearBeforeFill = True
        '
        'SegumientosIncidenciasTableAdapter
        '
        Me.SegumientosIncidenciasTableAdapter.ClearBeforeFill = True
        '
        'CausasTableAdapter
        '
        Me.CausasTableAdapter.ClearBeforeFill = True
        '
        'CausantesTableAdapter
        '
        Me.CausantesTableAdapter.ClearBeforeFill = True
        '
        'DecripcionTableAdapter
        '
        Me.DecripcionTableAdapter.ClearBeforeFill = True
        '
        'AlmacenNoConformeTableAdapter
        '
        Me.AlmacenNoConformeTableAdapter.ClearBeforeFill = True
        '
        'EvaluacionIncidenciaTableAdapter
        '
        Me.EvaluacionIncidenciaTableAdapter.ClearBeforeFill = True
        '
        'IncidenciasEnvasadoTableAdapter
        '
        Me.IncidenciasEnvasadoTableAdapter.ClearBeforeFill = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 407)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Main"
        Me.Text = "Form1"
        CType(Me.AccionesInmediatasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datasetJacinto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccionesPreventivasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccionesCorrectivasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SegumientosIncidenciasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CausasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CausantesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecripcionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlmacenNoConformeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EvaluacionIncidenciaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IncidenciasEnvasadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Private WithEvents AccionesInmediatasBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents datasetJacinto As InformesCalidad.datasetJacinto
    Private WithEvents AccionesPreventivasBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents AccionesCorrectivasBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents SegumientosIncidenciasBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents CausasBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents CausantesBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents DecripcionBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents AlmacenNoConformeBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents EvaluacionIncidenciaBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents IncidenciasEnvasadoBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents AccionesInmediatasTableAdapter As InformesCalidad.datasetJacintoTableAdapters.AccionesInmediatasTableAdapter
    Private WithEvents AccionesPreventivasTableAdapter As InformesCalidad.datasetJacintoTableAdapters.AccionesPreventivasTableAdapter
    Private WithEvents AccionesCorrectivasTableAdapter As InformesCalidad.datasetJacintoTableAdapters.AccionesCorrectivasTableAdapter
    Private WithEvents SegumientosIncidenciasTableAdapter As InformesCalidad.datasetJacintoTableAdapters.SegumientosIncidenciasTableAdapter
    Private WithEvents CausasTableAdapter As InformesCalidad.datasetJacintoTableAdapters.CausasTableAdapter
    Private WithEvents CausantesTableAdapter As InformesCalidad.datasetJacintoTableAdapters.CausantesTableAdapter
    Private WithEvents DecripcionTableAdapter As InformesCalidad.datasetJacintoTableAdapters.DecripcionTableAdapter
    Private WithEvents AlmacenNoConformeTableAdapter As InformesCalidad.datasetJacintoTableAdapters.AlmacenNoConformeTableAdapter
    Private WithEvents EvaluacionIncidenciaTableAdapter As InformesCalidad.datasetJacintoTableAdapters.EvaluacionIncidenciaTableAdapter
    Private WithEvents IncidenciasEnvasadoTableAdapter As InformesCalidad.datasetJacintoTableAdapters.IncidenciasEnvasadoTableAdapter

End Class
