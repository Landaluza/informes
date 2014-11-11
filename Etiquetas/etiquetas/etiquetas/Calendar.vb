Public Class Calendar
    Public Shared testDateTime As Boolean

 



    '**********************************************
    'Función que devuelve la fecha Juliana
    '**********************************************
    Public Function DevuelveFechaJuliana(ByVal Fecha As DateTime) As String
        Dim aux As DateTime
        Dim c As TimeSpan
        aux = New DateTime(Fecha.Year - 1, 12, 31, 0, 0, 0)
        'c = Fecha - aux
        c = Fecha.Subtract(aux)
        'a la fecha Juliana le añadimos al final las dos últimas cifras del año.
        'Return String.Format("000", c.Days) & Fecha.Year.ToString.Substring(Fecha.Year.ToString.Length - 2, 2)
        Return Format(c.Days, "000") & Fecha.Year.ToString.Substring(Fecha.Year.ToString.Length - 2, 2)
    End Function

    '**************************************************************************************
    'Función que devuelve un valor de hora, partiendo del valor de minutos pasado
    '**************************************************************************************
    Public Function DevuelveHora(ByVal Minutos As Double) As String
        Return (Convert.ToInt32(Minutos) \ 60).ToString & ":" & String.Format((Convert.ToInt32(Minutos) Mod 60).ToString, "00")
    End Function

    ' // This function will not convert dates to 19xx, only 20xx so if you need to consider 19xx dates
    ' || you'll need to add some logic to incorporate a switch point and determine whether to add 1000 or
    ' || 2000 in the calculation
    Public Function JulianToSerial(ByVal strJulian As String) As Date
        Try
            JulianToSerial = New DateTime(2000 + CType(CType(strJulian, Integer) / 1000, Integer), 1, CType(strJulian, Integer) Mod 1000)
        Catch ex As Exception
            messageBox.show("Error. " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function
End Class
