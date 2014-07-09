<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExistenciasPorDeposito
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
        Me.DepositosInformeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatosVinagreJerez = New InformesDepositos.DatosVinagreJerez()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DepositosInformeTableAdapter = New InformesDepositos.DatosVinagreJerezTableAdapters.DepositosInformeTableAdapter()
        CType(Me.DepositosInformeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatosVinagreJerez, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DepositosInformeBindingSource
        '
        Me.DepositosInformeBindingSource.DataMember = "DepositosInforme"
        Me.DepositosInformeBindingSource.DataSource = Me.DatosVinagreJerez
        '
        'DatosVinagreJerez
        '
        Me.DatosVinagreJerez.DataSetName = "DatosVinagreJerez"
        Me.DatosVinagreJerez.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetDepositosExistencias"
        ReportDataSource1.Value = Me.DepositosInformeBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "InformesDepositos.existenciasPorDeposito.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(867, 431)
        Me.ReportViewer1.TabIndex = 0
        '
        'DepositosInformeTableAdapter
        '
        Me.DepositosInformeTableAdapter.ClearBeforeFill = True
        '
        'frmExistenciasPorDeposito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 431)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmExistenciasPorDeposito"
        Me.Text = "frmExistenciasPorDeposito"
        CType(Me.DepositosInformeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatosVinagreJerez, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Private WithEvents DepositosInformeBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents DatosVinagreJerez As InformesDepositos.DatosVinagreJerez
    Private WithEvents DepositosInformeTableAdapter As InformesDepositos.DatosVinagreJerezTableAdapters.DepositosInformeTableAdapter
End Class
