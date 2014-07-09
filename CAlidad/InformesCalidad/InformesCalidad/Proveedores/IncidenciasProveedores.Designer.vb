<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IncidenciasProveedores
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
        Me.EvolucionGravedadIncidenciasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Proveedores = New InformesCalidad.Proveedores()
        Me.EvolucionMinutosIncidenciasProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EntregaPedidosProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListadoProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.EvolucionGravedadIncidenciasTableAdapter = New InformesCalidad.ProveedoresTableAdapters.EvolucionGravedadIncidenciasTableAdapter()
        Me.EvolucionMinutosIncidenciasProveedoresTableAdapter = New InformesCalidad.ProveedoresTableAdapters.EvolucionMinutosIncidenciasProveedoresTableAdapter()
        Me.EntregaPedidosProveedorTableAdapter = New InformesCalidad.ProveedoresTableAdapters.EntregaPedidosProveedorTableAdapter()
        Me.ListadoProveedoresTableAdapter = New InformesCalidad.ProveedoresTableAdapters.ListadoProveedoresTableAdapter()
        CType(Me.EvolucionGravedadIncidenciasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Proveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EvolucionMinutosIncidenciasProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EntregaPedidosProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListadoProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EvolucionGravedadIncidenciasBindingSource
        '
        Me.EvolucionGravedadIncidenciasBindingSource.DataMember = "EvolucionGravedadIncidencias"
        Me.EvolucionGravedadIncidenciasBindingSource.DataSource = Me.Proveedores
        '
        'Proveedores
        '
        Me.Proveedores.DataSetName = "Proveedores"
        Me.Proveedores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EvolucionMinutosIncidenciasProveedoresBindingSource
        '
        Me.EvolucionMinutosIncidenciasProveedoresBindingSource.DataMember = "EvolucionMinutosIncidenciasProveedores"
        Me.EvolucionMinutosIncidenciasProveedoresBindingSource.DataSource = Me.Proveedores
        '
        'EntregaPedidosProveedorBindingSource
        '
        Me.EntregaPedidosProveedorBindingSource.DataMember = "EntregaPedidosProveedor"
        Me.EntregaPedidosProveedorBindingSource.DataSource = Me.Proveedores
        '
        'ListadoProveedoresBindingSource
        '
        Me.ListadoProveedoresBindingSource.DataMember = "ListadoProveedores"
        Me.ListadoProveedoresBindingSource.DataSource = Me.Proveedores
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "EvolucionIncidenciasProveedores"
        ReportDataSource1.Value = Me.EvolucionGravedadIncidenciasBindingSource
        ReportDataSource2.Name = "MinutosIncidenciasProveedores"
        ReportDataSource2.Value = Me.EvolucionMinutosIncidenciasProveedoresBindingSource
        ReportDataSource3.Name = "EntregasPedidosProveedores"
        ReportDataSource3.Value = Me.EntregaPedidosProveedorBindingSource
        ReportDataSource4.Name = "ListadoProveedores"
        ReportDataSource4.Value = Me.ListadoProveedoresBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "InformesCalidad.IncidenciasProveedores.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(379, 322)
        Me.ReportViewer1.TabIndex = 0
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage
        '
        'EvolucionGravedadIncidenciasTableAdapter
        '
        Me.EvolucionGravedadIncidenciasTableAdapter.ClearBeforeFill = True
        '
        'EvolucionMinutosIncidenciasProveedoresTableAdapter
        '
        Me.EvolucionMinutosIncidenciasProveedoresTableAdapter.ClearBeforeFill = True
        '
        'EntregaPedidosProveedorTableAdapter
        '
        Me.EntregaPedidosProveedorTableAdapter.ClearBeforeFill = True
        '
        'ListadoProveedoresTableAdapter
        '
        Me.ListadoProveedoresTableAdapter.ClearBeforeFill = True
        '
        'IncidenciasProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 322)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "IncidenciasProveedores"
        Me.Text = "Form2"
        CType(Me.EvolucionGravedadIncidenciasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Proveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EvolucionMinutosIncidenciasProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EntregaPedidosProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListadoProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Private WithEvents EvolucionGravedadIncidenciasBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents Proveedores As InformesCalidad.Proveedores
    Private WithEvents EvolucionMinutosIncidenciasProveedoresBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents EntregaPedidosProveedorBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents ListadoProveedoresBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents EvolucionGravedadIncidenciasTableAdapter As InformesCalidad.ProveedoresTableAdapters.EvolucionGravedadIncidenciasTableAdapter
    Private WithEvents EvolucionMinutosIncidenciasProveedoresTableAdapter As InformesCalidad.ProveedoresTableAdapters.EvolucionMinutosIncidenciasProveedoresTableAdapter
    Private WithEvents EntregaPedidosProveedorTableAdapter As InformesCalidad.ProveedoresTableAdapters.EntregaPedidosProveedorTableAdapter
    Private WithEvents ListadoProveedoresTableAdapter As InformesCalidad.ProveedoresTableAdapters.ListadoProveedoresTableAdapter
End Class
