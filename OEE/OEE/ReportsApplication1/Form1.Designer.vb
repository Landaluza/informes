<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form invalida a Dispose para limpiar la lista de componentes.
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

    'Requerido por Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTA: Windows Form Designer requiere el procedimiento siguiente
    'No puede modificarse con Windows Form Designer.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.OEEAnoTotalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LADataSet = New OEE.LADataSet()
        Me.OEEMesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OEEMesTotalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.OEEAnoTotalTableAdapter = New OEE.LADataSetTableAdapters.OEEAnoTotalTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OEEMesTableAdapter = New OEE.LADataSetTableAdapters.OEEMesTableAdapter()
        Me.OEEMesTotalTableAdapter = New OEE.LADataSetTableAdapters.OEEMesTotalTableAdapter()
        CType(Me.OEEAnoTotalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OEEMesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OEEMesTotalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OEEAnoTotalBindingSource
        '
        Me.OEEAnoTotalBindingSource.DataMember = "OEEAnoTotal"
        Me.OEEAnoTotalBindingSource.DataSource = Me.LADataSet
        '
        'LADataSet
        '
        Me.LADataSet.DataSetName = "LADataSet"
        Me.LADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OEEMesBindingSource
        '
        Me.OEEMesBindingSource.DataMember = "OEEMes"
        Me.OEEMesBindingSource.DataSource = Me.LADataSet
        '
        'OEEMesTotalBindingSource
        '
        Me.OEEMesTotalBindingSource.DataMember = "OEEMesTotal"
        Me.OEEMesTotalBindingSource.DataSource = Me.LADataSet
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.OEEAnoTotalBindingSource
        ReportDataSource2.Name = "mes"
        ReportDataSource2.Value = Me.OEEMesBindingSource
        ReportDataSource3.Name = "mestotal"
        ReportDataSource3.Value = Me.OEEMesTotalBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "OEE.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 41)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(682, 345)
        Me.ReportViewer1.TabIndex = 0
        '
        'OEEAnoTotalTableAdapter
        '
        Me.OEEAnoTotalTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(682, 41)
        Me.Panel1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.OEE.My.Resources.Resources.view_refresh_4
        Me.Button1.Location = New System.Drawing.Point(344, 10)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 20)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Actualizar"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(142, 10)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(199, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha para el rango"
        '
        'OEEMesTableAdapter
        '
        Me.OEEMesTableAdapter.ClearBeforeFill = True
        '
        'OEEMesTotalTableAdapter
        '
        Me.OEEMesTotalTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 386)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculo OEE"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.OEEAnoTotalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OEEMesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OEEMesTotalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Private WithEvents OEEAnoTotalBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents LADataSet As OEE.LADataSet
    Private WithEvents OEEAnoTotalTableAdapter As OEE.LADataSetTableAdapters.OEEAnoTotalTableAdapter
    Private WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents Button1 As System.Windows.Forms.Button
    Private WithEvents OEEMesBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents OEEMesTotalBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents OEEMesTableAdapter As OEE.LADataSetTableAdapters.OEEMesTableAdapter
    Private WithEvents OEEMesTotalTableAdapter As OEE.LADataSetTableAdapters.OEEMesTotalTableAdapter

End Class
