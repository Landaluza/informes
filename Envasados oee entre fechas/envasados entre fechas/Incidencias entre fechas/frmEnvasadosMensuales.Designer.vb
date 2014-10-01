<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnvasadosMensuales
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListadoFormatosPorMesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LADataSet = New Envasados_entre_fechas.LADataSet()
        Me.ListadoFormatosPorMesTableAdapter = New Envasados_entre_fechas.LADataSetTableAdapters.ListadoFormatosPorMesTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.ListadoFormatosPorMesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetOEEMEnsual"
        ReportDataSource1.Value = Me.ListadoFormatosPorMesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Envasados_entre_fechas.Report2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 49)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(823, 500)
        Me.ReportViewer1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(823, 49)
        Me.Panel1.TabIndex = 1
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(214, 15)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(80, 20)
        Me.DateTimePicker1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mostrar resultados para el año"
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.Envasados_entre_fechas.My.Resources.Resources.glyphicons_198_ok
        Me.Button1.Location = New System.Drawing.Point(300, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 34)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListadoFormatosPorMesBindingSource
        '
        Me.ListadoFormatosPorMesBindingSource.DataMember = "ListadoFormatosPorMes"
        Me.ListadoFormatosPorMesBindingSource.DataSource = Me.LADataSet
        '
        'LADataSet
        '
        Me.LADataSet.DataSetName = "LADataSet"
        Me.LADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ListadoFormatosPorMesTableAdapter
        '
        Me.ListadoFormatosPorMesTableAdapter.ClearBeforeFill = True
        '
        'frmEnvasadosMensuales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 549)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmEnvasadosMensuales"
        Me.Text = "frmEnvasadosMensuales"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ListadoFormatosPorMesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ListadoFormatosPorMesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LADataSet As Envasados_entre_fechas.LADataSet
    Friend WithEvents ListadoFormatosPorMesTableAdapter As Envasados_entre_fechas.LADataSetTableAdapters.ListadoFormatosPorMesTableAdapter
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents Button1 As System.Windows.Forms.Button
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
End Class
