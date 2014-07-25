Public Class SelectorFecha
    'Public Sub New(ByVal connectionstring As String)


    '    InitializeComponent()

    '    My.Settings.Item("LAConnectionString") = connectionstring

    'End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVer.Click
        Dim informe As InformeVinagre
        If Me.dtbFechaInicio.Checked And dtpFechaFin.Checked Then
            informe = New InformeVinagre(Me.dtbFechaInicio.Value, Me.dtpFechaFin.Value)
        Else
            informe = New InformeVinagre()
        End If


        informe.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class