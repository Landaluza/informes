Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim informe As Form1
        If Me.DateTimePicker1.Checked And DateTimePicker2.Checked Then
            informe = New Form1(Me.DateTimePicker1.Value, Me.DateTimePicker2.Value)
        Else
            informe = New Form1()
        End If


        informe.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class