<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListadoProveedores
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
        Me.ListadoProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Proveedores = New InformesCalidad.Proveedores()
        Me.ListadoProveedoresCeroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ListadoProveedoresTableAdapter = New InformesCalidad.ProveedoresTableAdapters.ListadoProveedoresTableAdapter()
        Me.ListadoProveedoresCeroTableAdapter = New InformesCalidad.ProveedoresTableAdapters.ListadoProveedoresCeroTableAdapter()
        CType(Me.ListadoProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Proveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListadoProveedoresCeroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListadoProveedoresBindingSource
        '
        Me.ListadoProveedoresBindingSource.DataMember = "ListadoProveedores"
        Me.ListadoProveedoresBindingSource.DataSource = Me.Proveedores
        '
        'Proveedores
        '
        Me.Proveedores.DataSetName = "Proveedores"
        Me.Proveedores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ListadoProveedoresCeroBindingSource
        '
        Me.ListadoProveedoresCeroBindingSource.DataMember = "ListadoProveedoresCero"
        Me.ListadoProveedoresCeroBindingSource.DataSource = Me.Proveedores
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "ListadoProveedores"
        ReportDataSource1.Value = Me.ListadoProveedoresBindingSource
        ReportDataSource2.Name = "ListadoProveedoresCero"
        ReportDataSource2.Value = Me.ListadoProveedoresCeroBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "InformesCalidad.ListadoProveedores.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(860, 322)
        Me.ReportViewer1.TabIndex = 0
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        '
        'ListadoProveedoresTableAdapter
        '
        Me.ListadoProveedoresTableAdapter.ClearBeforeFill = True
        '
        'ListadoProveedoresCeroTableAdapter
        '
        Me.ListadoProveedoresCeroTableAdapter.ClearBeforeFill = True
        '
        'ListadoProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 322)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ListadoProveedores"
        Me.Text = "ListadoProveedores"
        CType(Me.ListadoProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Proveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListadoProveedoresCeroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Private WithEvents ListadoProveedoresBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents Proveedores As InformesCalidad.Proveedores
    Private WithEvents ListadoProveedoresTableAdapter As InformesCalidad.ProveedoresTableAdapters.ListadoProveedoresTableAdapter
    Private WithEvents ListadoProveedoresCeroBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents ListadoProveedoresCeroTableAdapter As InformesCalidad.ProveedoresTableAdapters.ListadoProveedoresCeroTableAdapter
End Class
