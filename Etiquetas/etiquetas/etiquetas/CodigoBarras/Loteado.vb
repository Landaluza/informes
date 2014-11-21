Public Class Loteado
    Public Const STANDAR As Integer = 1
    Public Const CUBOS As Integer = 2

    Private calendar As Calendar

    Public Sub New()
        Me.calendar = New Calendar
    End Sub

    Public Function Loteado_standar(ByVal fecha As String) As String
        Return calendar.DevuelveFechaJuliana(fecha)
    End Function

    Public Function Loteado_cubos(ByVal fecha As Date) As String
        Return fecha.ToString("ddMMyy")
    End Function
End Class
