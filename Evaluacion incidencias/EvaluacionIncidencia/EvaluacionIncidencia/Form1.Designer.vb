<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
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
        Me.ControlIncidenciasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LADataSet = New EvaluacionIncidencia.LADataSet()
        Me.IncidenciasClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IncidenciasProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ControlIncidenciasTableAdapter = New EvaluacionIncidencia.LADataSetTableAdapters.ControlIncidenciasTableAdapter()
        Me.IncidenciasClientesTableAdapter = New EvaluacionIncidencia.LADataSetTableAdapters.IncidenciasClientesTableAdapter()
        Me.IncidenciasProveedoresTableAdapter = New EvaluacionIncidencia.LADataSetTableAdapters.IncidenciasProveedoresTableAdapter()
        Me.IncidenciasInternasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IncidenciasInternasTableAdapter = New EvaluacionIncidencia.LADataSetTableAdapters.IncidenciasInternasTableAdapter()
        CType(Me.ControlIncidenciasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IncidenciasClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IncidenciasProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.IncidenciasInternasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ControlIncidenciasBindingSource
        '
        Me.ControlIncidenciasBindingSource.DataMember = "ControlIncidencias"
        Me.ControlIncidenciasBindingSource.DataSource = Me.LADataSet
        '
        'LADataSet
        '
        Me.LADataSet.DataSetName = "LADataSet"
        Me.LADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IncidenciasClientesBindingSource
        '
        Me.IncidenciasClientesBindingSource.DataMember = "IncidenciasClientes"
        Me.IncidenciasClientesBindingSource.DataSource = Me.LADataSet
        '
        'IncidenciasProveedoresBindingSource
        '
        Me.IncidenciasProveedoresBindingSource.DataMember = "IncidenciasProveedores"
        Me.IncidenciasProveedoresBindingSource.DataSource = Me.LADataSet
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ControlIncidenciasBindingSource
        ReportDataSource2.Name = "Clientes"
        ReportDataSource2.Value = Me.IncidenciasClientesBindingSource
        ReportDataSource3.Name = "Proveedores"
        ReportDataSource3.Value = Me.IncidenciasProveedoresBindingSource
        ReportDataSource4.Name = "Internas"
        ReportDataSource4.Value = Me.IncidenciasInternasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "EvaluacionIncidencia.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 48)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(682, 338)
        Me.ReportViewer1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(682, 48)
        Me.Panel1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(622, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(36, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(340, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Hasta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Desde"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(399, 18)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 1
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(79, 18)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 0
        '
        'ControlIncidenciasTableAdapter
        '
        Me.ControlIncidenciasTableAdapter.ClearBeforeFill = True
        '
        'IncidenciasClientesTableAdapter
        '
        Me.IncidenciasClientesTableAdapter.ClearBeforeFill = True
        '
        'IncidenciasProveedoresTableAdapter
        '
        Me.IncidenciasProveedoresTableAdapter.ClearBeforeFill = True
        '
        'IncidenciasInternasBindingSource
        '
        Me.IncidenciasInternasBindingSource.DataMember = "IncidenciasInternas"
        Me.IncidenciasInternasBindingSource.DataSource = Me.LADataSet
        '
        'IncidenciasInternasTableAdapter
        '
        Me.IncidenciasInternasTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 386)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.ControlIncidenciasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IncidenciasClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IncidenciasProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.IncidenciasInternasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ControlIncidenciasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LADataSet As EvaluacionIncidencia.LADataSet
    Friend WithEvents IncidenciasClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ControlIncidenciasTableAdapter As EvaluacionIncidencia.LADataSetTableAdapters.ControlIncidenciasTableAdapter
    Friend WithEvents IncidenciasClientesTableAdapter As EvaluacionIncidencia.LADataSetTableAdapters.IncidenciasClientesTableAdapter
    Friend WithEvents IncidenciasProveedoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IncidenciasProveedoresTableAdapter As EvaluacionIncidencia.LADataSetTableAdapters.IncidenciasProveedoresTableAdapter
    Friend WithEvents IncidenciasInternasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IncidenciasInternasTableAdapter As EvaluacionIncidencia.LADataSetTableAdapters.IncidenciasInternasTableAdapter

End Class
