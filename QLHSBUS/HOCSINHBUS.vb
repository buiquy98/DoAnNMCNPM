Imports QLHSDAL
Imports QLHSDTO
Imports Utility

Public Class HOCSINHBUS
    Private hsDAL As HOCSINHDAL
    Public Sub New()
        hsDAL = New HOCSINHDAL()
    End Sub
    Public Sub New(connectionString As String)
        hsDAL = New HOCSINHDAL(connectionString)
    End Sub
    Public Function isValidName(hs As HOCSINHDTO) As Boolean

        If (hs.HoTen1.Length < 1) Then
            Return False
        End If

        Return True
    End Function
    Public Function insert(hs As HOCSINHDTO) As Result
        Return hsDAL.insert(hs)
    End Function

    Public Function buildmaHS(ByRef nextMahs As Integer) As Result
        Return hsDAL.buildmaHS(nextMahs)
    End Function
End Class
