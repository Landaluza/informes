<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlExpediciones
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ControlExpedicionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Expediciones = New EvaluacionIncidencia.Expediciones()
        Me.ControlExpedicionesTableAdapter = New EvaluacionIncidencia.ExpedicionesTableAdapters.ControlExpedicionesTableAdapter()
        CType(Me.ControlExpedicionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Expediciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "ControlExpediciones"
        ReportDataSource1.Value = Me.ControlExpedicionesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "EvaluacionIncidencia.ControlExpediciones.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(585, 262)
        Me.ReportViewer1.TabIndex = 0
        '
        'ControlExpedicionesBindingSource
        '
        Me.ControlExpedicionesBindingSource.DataMember = "ControlExpediciones"
        Me.ControlExpedicionesBindingSource.DataSource = Me.Expediciones
        '
        'Expediciones
        '
        Me.Expediciones.DataSetName = "Expediciones"
        Me.Expediciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ControlExpedicionesTableAdapter
        '
        Me.ControlExpedicionesTableAdapter.ClearBeforeFill = True
        '
        'ControlExpediciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 262)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ControlExpediciones"
        Me.Text = "ControlExpediciones"
        CType(Me.ControlExpedicionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Expediciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ControlExpedicionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Expediciones As EvaluacionIncidencia.Expediciones
    Friend WithEvents ControlExpedicionesTableAdapter As EvaluacionIncidencia.ExpedicionesTableAdapters.ControlExpedicionesTableAdapter
End Class
