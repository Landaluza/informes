﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEtiqueta
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
        Me.EtiquetasPaletSelectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LADataSet = New etiquetas.LADataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.EtiquetasPaletSelectTableAdapter = New etiquetas.LADataSetTableAdapters.EtiquetasPaletSelectTableAdapter()
        CType(Me.EtiquetasPaletSelectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EtiquetasPaletSelectBindingSource
        '
        Me.EtiquetasPaletSelectBindingSource.DataMember = "EtiquetasPaletSelect"
        Me.EtiquetasPaletSelectBindingSource.DataSource = Me.LADataSet
        '
        'LADataSet
        '
        Me.LADataSet.DataSetName = "LADataSet"
        Me.LADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.EtiquetasPaletSelectBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "etiquetas.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(752, 761)
        Me.ReportViewer1.TabIndex = 0
        '
        'EtiquetasPaletSelectTableAdapter
        '
        Me.EtiquetasPaletSelectTableAdapter.ClearBeforeFill = True
        '
        'frmEtiqueta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 761)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmEtiqueta"
        Me.Text = "Form1"
        CType(Me.EtiquetasPaletSelectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents EtiquetasPaletSelectBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LADataSet As etiquetas.LADataSet
    Friend WithEvents EtiquetasPaletSelectTableAdapter As etiquetas.LADataSetTableAdapters.EtiquetasPaletSelectTableAdapter

End Class
