<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EvaluacionIncidenciasCalidad
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
        Me.IncidenciasCalidadGeneralBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Controlncidencias = New InformesCalidad.Controlncidencias()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.IncidenciasCalidadGeneralTableAdapter = New InformesCalidad.ControlncidenciasTableAdapters.IncidenciasCalidadGeneralTableAdapter()
        Me.AlmacenNoConforme = New InformesCalidad.AlmacenNoConforme()
        Me.AlmacenNCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlmacenNCTableAdapter = New InformesCalidad.AlmacenNoConformeTableAdapters.AlmacenNCTableAdapter()
        CType(Me.IncidenciasCalidadGeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Controlncidencias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlmacenNoConforme, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlmacenNCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "ListadoAlmacenNC"
        ReportDataSource1.Value = Me.AlmacenNCBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "InformesCalidad.AlmacenNC.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(707, 423)
        Me.ReportViewer1.TabIndex = 0
        '
        'IncidenciasCalidadGeneralTableAdapter
        '
        Me.IncidenciasCalidadGeneralTableAdapter.ClearBeforeFill = True
        '
        'AlmacenNoConforme
        '
        Me.AlmacenNoConforme.DataSetName = "AlmacenNoConforme"
        Me.AlmacenNoConforme.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AlmacenNCBindingSource
        '
        Me.AlmacenNCBindingSource.DataMember = "AlmacenNC"
        Me.AlmacenNCBindingSource.DataSource = Me.AlmacenNoConforme
        '
        'AlmacenNCTableAdapter
        '
        Me.AlmacenNCTableAdapter.ClearBeforeFill = True
        '
        'EvaluacionIncidenciasCalidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 423)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "EvaluacionIncidenciasCalidad"
        Me.Text = "EvaluacionIncidenciasCalidad"
        CType(Me.IncidenciasCalidadGeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Controlncidencias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlmacenNoConforme, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlmacenNCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents IncidenciasCalidadGeneralBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Controlncidencias As InformesCalidad.Controlncidencias
    Friend WithEvents IncidenciasCalidadGeneralTableAdapter As InformesCalidad.ControlncidenciasTableAdapters.IncidenciasCalidadGeneralTableAdapter
    Friend WithEvents AlmacenNCBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AlmacenNoConforme As InformesCalidad.AlmacenNoConforme
    Friend WithEvents AlmacenNCTableAdapter As InformesCalidad.AlmacenNoConformeTableAdapters.AlmacenNCTableAdapter
End Class
