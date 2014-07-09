<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.IncidenciasCalidadGeneralBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Controlncidencias = New InformesCalidad.Controlncidencias()
        Me.EvolucionIncidenciaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IncidenciasEnvasados = New InformesCalidad.IncidenciasEnvasados()
        Me.ControlIncidenciasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.IncidenciasCalidadGeneralTableAdapter = New InformesCalidad.ControlncidenciasTableAdapters.IncidenciasCalidadGeneralTableAdapter()
        Me.EvolucionIncidenciaTableAdapter = New InformesCalidad.IncidenciasEnvasadosTableAdapters.EvolucionIncidenciaTableAdapter()
        Me.ControlIncidenciasTableAdapter = New InformesCalidad.ControlncidenciasTableAdapters.ControlIncidenciasTableAdapter()
        CType(Me.IncidenciasCalidadGeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Controlncidencias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EvolucionIncidenciaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IncidenciasEnvasados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ControlIncidenciasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IncidenciasCalidadGeneralBindingSource
        '
        Me.IncidenciasCalidadGeneralBindingSource.DataMember = "IncidenciasCalidadGeneral"
        Me.IncidenciasCalidadGeneralBindingSource.DataSource = Me.Controlncidencias
        '
        'Controlncidencias
        '
        Me.Controlncidencias.DataSetName = "Controlncidencias"
        Me.Controlncidencias.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EvolucionIncidenciaBindingSource
        '
        Me.EvolucionIncidenciaBindingSource.DataMember = "EvolucionIncidencia"
        Me.EvolucionIncidenciaBindingSource.DataSource = Me.IncidenciasEnvasados
        '
        'IncidenciasEnvasados
        '
        Me.IncidenciasEnvasados.DataSetName = "IncidenciasEnvasados"
        Me.IncidenciasEnvasados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ControlIncidenciasBindingSource
        '
        Me.ControlIncidenciasBindingSource.DataMember = "ControlIncidencias"
        Me.ControlIncidenciasBindingSource.DataSource = Me.Controlncidencias
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "FichaIncidencia"
        ReportDataSource1.Value = Me.IncidenciasCalidadGeneralBindingSource
        ReportDataSource2.Name = "EvolucionIncidencia"
        ReportDataSource2.Value = Me.EvolucionIncidenciaBindingSource
        ReportDataSource3.Name = "IncidenciasAbiertas"
        ReportDataSource3.Value = Me.ControlIncidenciasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "InformesCalidad.SeguimientoIncidencias.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1195, 530)
        Me.ReportViewer1.TabIndex = 0
        '
        'IncidenciasCalidadGeneralTableAdapter
        '
        Me.IncidenciasCalidadGeneralTableAdapter.ClearBeforeFill = True
        '
        'EvolucionIncidenciaTableAdapter
        '
        Me.EvolucionIncidenciaTableAdapter.ClearBeforeFill = True
        '
        'ControlIncidenciasTableAdapter
        '
        Me.ControlIncidenciasTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1195, 530)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.IncidenciasCalidadGeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Controlncidencias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EvolucionIncidenciaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IncidenciasEnvasados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ControlIncidenciasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Private WithEvents IncidenciasCalidadGeneralBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents Controlncidencias As InformesCalidad.Controlncidencias
    Private WithEvents EvolucionIncidenciaBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents IncidenciasEnvasados As InformesCalidad.IncidenciasEnvasados
    Private WithEvents ControlIncidenciasBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents IncidenciasCalidadGeneralTableAdapter As InformesCalidad.ControlncidenciasTableAdapters.IncidenciasCalidadGeneralTableAdapter
    Private WithEvents EvolucionIncidenciaTableAdapter As InformesCalidad.IncidenciasEnvasadosTableAdapters.EvolucionIncidenciaTableAdapter
    Private WithEvents ControlIncidenciasTableAdapter As InformesCalidad.ControlncidenciasTableAdapters.ControlIncidenciasTableAdapter
End Class
