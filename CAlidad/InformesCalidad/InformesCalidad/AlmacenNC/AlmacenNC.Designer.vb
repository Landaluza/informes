<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlmacenNC
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
        Me.AlmacenNCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlmacenNoConforme = New InformesCalidad.AlmacenNoConforme()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.AlmacenNCTableAdapter = New InformesCalidad.AlmacenNoConformeTableAdapters.AlmacenNCTableAdapter()
        CType(Me.AlmacenNCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlmacenNoConforme, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AlmacenNCBindingSource
        '
        Me.AlmacenNCBindingSource.DataMember = "AlmacenNC"
        Me.AlmacenNCBindingSource.DataSource = Me.AlmacenNoConforme
        '
        'AlmacenNoConforme
        '
        Me.AlmacenNoConforme.DataSetName = "AlmacenNoConforme"
        Me.AlmacenNoConforme.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "ListadoAlmacenNC"
        ReportDataSource1.Value = Me.AlmacenNCBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "InformesCalidad.AlmacenNC.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(720, 322)
        Me.ReportViewer1.TabIndex = 0
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        '
        'AlmacenNCTableAdapter
        '
        Me.AlmacenNCTableAdapter.ClearBeforeFill = True
        '
        'AlmacenNC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 322)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "AlmacenNC"
        Me.Text = "AlmacenNC"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AlmacenNCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlmacenNoConforme, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents AlmacenNCBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents AlmacenNoConforme As InformesCalidad.AlmacenNoConforme
    Private WithEvents AlmacenNCTableAdapter As InformesCalidad.AlmacenNoConformeTableAdapters.AlmacenNCTableAdapter
    Private WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
