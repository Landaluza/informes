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
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.VjrEmbotelladoAlbaranBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatosVinagreJerez = New InformesVinagreJerez.DatosVinagreJerez()
        Me.VjrEmbotelladoExpedidoArticuloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalidasGranelVjrBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VjrComoIngredienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmbotelladoVjrPorArticuloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.VjrEmbotelladoAlbaranTableAdapter = New InformesVinagreJerez.DatosVinagreJerezTableAdapters.VjrEmbotelladoAlbaranTableAdapter()
        Me.VjrEmbotelladoExpedidoArticuloTableAdapter = New InformesVinagreJerez.DatosVinagreJerezTableAdapters.VjrEmbotelladoExpedidoArticuloTableAdapter()
        Me.SalidasGranelVjrTableAdapter = New InformesVinagreJerez.DatosVinagreJerezTableAdapters.SalidasGranelVjrTableAdapter()
        Me.VjrComoIngredienteTableAdapter = New InformesVinagreJerez.DatosVinagreJerezTableAdapters.VjrComoIngredienteTableAdapter()
        Me.EmbotelladoVjrPorArticuloTableAdapter = New InformesVinagreJerez.DatosVinagreJerezTableAdapters.EmbotelladoVjrPorArticuloTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        CType(Me.VjrEmbotelladoAlbaranBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatosVinagreJerez, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VjrEmbotelladoExpedidoArticuloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalidasGranelVjrBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VjrComoIngredienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmbotelladoVjrPorArticuloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'VjrEmbotelladoAlbaranBindingSource
        '
        Me.VjrEmbotelladoAlbaranBindingSource.DataMember = "VjrEmbotelladoAlbaran"
        Me.VjrEmbotelladoAlbaranBindingSource.DataSource = Me.DatosVinagreJerez
        '
        'DatosVinagreJerez
        '
        Me.DatosVinagreJerez.DataSetName = "DatosVinagreJerez"
        Me.DatosVinagreJerez.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VjrEmbotelladoExpedidoArticuloBindingSource
        '
        Me.VjrEmbotelladoExpedidoArticuloBindingSource.DataMember = "VjrEmbotelladoExpedidoArticulo"
        Me.VjrEmbotelladoExpedidoArticuloBindingSource.DataSource = Me.DatosVinagreJerez
        '
        'SalidasGranelVjrBindingSource
        '
        Me.SalidasGranelVjrBindingSource.DataMember = "SalidasGranelVjr"
        Me.SalidasGranelVjrBindingSource.DataSource = Me.DatosVinagreJerez
        '
        'VjrComoIngredienteBindingSource
        '
        Me.VjrComoIngredienteBindingSource.DataMember = "VjrComoIngrediente"
        Me.VjrComoIngredienteBindingSource.DataSource = Me.DatosVinagreJerez
        '
        'EmbotelladoVjrPorArticuloBindingSource
        '
        Me.EmbotelladoVjrPorArticuloBindingSource.DataMember = "EmbotelladoVjrPorArticulo"
        Me.EmbotelladoVjrPorArticuloBindingSource.DataSource = Me.DatosVinagreJerez
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "ExpedicionesPorAlbaran"
        ReportDataSource1.Value = Me.VjrEmbotelladoAlbaranBindingSource
        ReportDataSource2.Name = "ExpedicionesPorArticulo"
        ReportDataSource2.Value = Me.VjrEmbotelladoExpedidoArticuloBindingSource
        ReportDataSource3.Name = "SalidasGranel"
        ReportDataSource3.Value = Me.SalidasGranelVjrBindingSource
        ReportDataSource4.Name = "VinagreUsadoIngrediente"
        ReportDataSource4.Value = Me.VjrComoIngredienteBindingSource
        ReportDataSource5.Name = "EmbotelladosVinagresPorArticulo"
        ReportDataSource5.Value = Me.EmbotelladoVjrPorArticuloBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource5)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "InformesVinagreJerez.ResumenVinagreJerez.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 48)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(4)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(847, 421)
        Me.ReportViewer1.TabIndex = 0
        '
        'VjrEmbotelladoAlbaranTableAdapter
        '
        Me.VjrEmbotelladoAlbaranTableAdapter.ClearBeforeFill = True
        '
        'VjrEmbotelladoExpedidoArticuloTableAdapter
        '
        Me.VjrEmbotelladoExpedidoArticuloTableAdapter.ClearBeforeFill = True
        '
        'SalidasGranelVjrTableAdapter
        '
        Me.SalidasGranelVjrTableAdapter.ClearBeforeFill = True
        '
        'VjrComoIngredienteTableAdapter
        '
        Me.VjrComoIngredienteTableAdapter.ClearBeforeFill = True
        '
        'EmbotelladoVjrPorArticuloTableAdapter
        '
        Me.EmbotelladoVjrPorArticuloTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(847, 48)
        Me.Panel1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(327, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Hasta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Desde"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(378, 14)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(118, 22)
        Me.DateTimePicker2.TabIndex = 1
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(76, 14)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(122, 22)
        Me.DateTimePicker1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 469)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.VjrEmbotelladoAlbaranBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatosVinagreJerez, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VjrEmbotelladoExpedidoArticuloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalidasGranelVjrBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VjrComoIngredienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmbotelladoVjrPorArticuloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Private WithEvents VjrEmbotelladoAlbaranBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents DatosVinagreJerez As InformesVinagreJerez.DatosVinagreJerez
    Private WithEvents VjrEmbotelladoAlbaranTableAdapter As InformesVinagreJerez.DatosVinagreJerezTableAdapters.VjrEmbotelladoAlbaranTableAdapter
    Private WithEvents VjrEmbotelladoExpedidoArticuloBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents VjrEmbotelladoExpedidoArticuloTableAdapter As InformesVinagreJerez.DatosVinagreJerezTableAdapters.VjrEmbotelladoExpedidoArticuloTableAdapter
    Private WithEvents SalidasGranelVjrBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents SalidasGranelVjrTableAdapter As InformesVinagreJerez.DatosVinagreJerezTableAdapters.SalidasGranelVjrTableAdapter
    Private WithEvents VjrComoIngredienteBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents VjrComoIngredienteTableAdapter As InformesVinagreJerez.DatosVinagreJerezTableAdapters.VjrComoIngredienteTableAdapter
    Private WithEvents EmbotelladoVjrPorArticuloBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents EmbotelladoVjrPorArticuloTableAdapter As InformesVinagreJerez.DatosVinagreJerezTableAdapters.EmbotelladoVjrPorArticuloTableAdapter
    Private WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Private WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents Label1 As System.Windows.Forms.Label

End Class
