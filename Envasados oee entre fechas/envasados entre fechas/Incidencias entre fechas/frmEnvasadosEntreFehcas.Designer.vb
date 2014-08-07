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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ListadoIncidenciasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LADataSet = New Envasados_entre_fechas.LADataSet()
        Me.ListadoIncidenciasTableAdapter = New Envasados_entre_fechas.LADataSetTableAdapters.ListadoIncidenciasTableAdapter()
        CType(Me.ListadoIncidenciasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dsIncidencias"
        ReportDataSource1.Value = Me.ListadoIncidenciasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Incidencias_entre_fechas.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(682, 386)
        Me.ReportViewer1.TabIndex = 0
        '
        'ListadoIncidenciasBindingSource
        '
        Me.ListadoIncidenciasBindingSource.DataMember = "ListadoIncidencias"
        Me.ListadoIncidenciasBindingSource.DataSource = Me.LADataSet
        '
        'LADataSet
        '
        Me.LADataSet.DataSetName = "LADataSet"
        Me.LADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ListadoIncidenciasTableAdapter
        '
        Me.ListadoIncidenciasTableAdapter.ClearBeforeFill = True
        '
        'frmIncidenciasEntreFehcas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 386)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmIncidenciasEntreFehcas"
        Me.Text = "Form1"
        CType(Me.ListadoIncidenciasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Private WithEvents LADataSet As Envasados_entre_fechas.LADataSet
    Private WithEvents ListadoIncidenciasBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents ListadoIncidenciasTableAdapter As Envasados_entre_fechas.LADataSetTableAdapters.ListadoIncidenciasTableAdapter

End Class
