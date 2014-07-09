<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlEmpleados
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
        Me.ListadoOficinasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LADataSet = New InformesEmpleados.LADataSet()
        Me.ListadoVestuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ListadoOficinasTableAdapter = New InformesEmpleados.LADataSetTableAdapters.ListadoOficinasTableAdapter()
        Me.ListadoVestuarioTableAdapter = New InformesEmpleados.LADataSetTableAdapters.ListadoVestuarioTableAdapter()
        CType(Me.ListadoOficinasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListadoVestuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListadoOficinasBindingSource
        '
        Me.ListadoOficinasBindingSource.DataMember = "ListadoOficinas"
        Me.ListadoOficinasBindingSource.DataSource = Me.LADataSet
        '
        'LADataSet
        '
        Me.LADataSet.DataSetName = "LADataSet"
        Me.LADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ListadoVestuarioBindingSource
        '
        Me.ListadoVestuarioBindingSource.DataMember = "ListadoVestuario"
        Me.ListadoVestuarioBindingSource.DataSource = Me.LADataSet
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "ListadoOficinas"
        ReportDataSource1.Value = Me.ListadoOficinasBindingSource
        ReportDataSource2.Name = "ListadoVestuarios"
        ReportDataSource2.Value = Me.ListadoVestuarioBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "InformesEmpleados.ControlHorasEmpleados.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(640, 569)
        Me.ReportViewer1.TabIndex = 0
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        '
        'ListadoOficinasTableAdapter
        '
        Me.ListadoOficinasTableAdapter.ClearBeforeFill = True
        '
        'ListadoVestuarioTableAdapter
        '
        Me.ListadoVestuarioTableAdapter.ClearBeforeFill = True
        '
        'ControlEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 569)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ControlEmpleados"
        Me.Text = "Form1"
        CType(Me.ListadoOficinasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListadoVestuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Private WithEvents ListadoOficinasBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents LADataSet As InformesEmpleados.LADataSet
    Private WithEvents ListadoOficinasTableAdapter As InformesEmpleados.LADataSetTableAdapters.ListadoOficinasTableAdapter
    Private WithEvents ListadoVestuarioBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents ListadoVestuarioTableAdapter As InformesEmpleados.LADataSetTableAdapters.ListadoVestuarioTableAdapter
End Class
