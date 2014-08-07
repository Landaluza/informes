<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnvasadosEntreFehcas
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
        Me.LADataSet = New Envasados_entre_fechas.LADataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ListadoFormatosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListadoFormatosTableAdapter = New Envasados_entre_fechas.LADataSetTableAdapters.ListadoFormatosTableAdapter()
        CType(Me.LADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListadoFormatosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LADataSet
        '
        Me.LADataSet.DataSetName = "LADataSet"
        Me.LADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dsFormatos"
        ReportDataSource1.Value = Me.ListadoFormatosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Envasados_entre_fechas.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(682, 386)
        Me.ReportViewer1.TabIndex = 0
        '
        'ListadoFormatosBindingSource
        '
        Me.ListadoFormatosBindingSource.DataMember = "ListadoFormatos"
        Me.ListadoFormatosBindingSource.DataSource = Me.LADataSet
        '
        'ListadoFormatosTableAdapter
        '
        Me.ListadoFormatosTableAdapter.ClearBeforeFill = True
        '
        'frmEnvasadosEntreFehcas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 386)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmEnvasadosEntreFehcas"
        Me.Text = "Envasados entre fechas"
        CType(Me.LADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListadoFormatosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Private WithEvents LADataSet As Envasados_entre_fechas.LADataSet
    Private WithEvents ListadoFormatosBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents ListadoFormatosTableAdapter As Envasados_entre_fechas.LADataSetTableAdapters.ListadoFormatosTableAdapter

End Class
