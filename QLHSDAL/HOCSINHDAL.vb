Imports System.Configuration
Imports System.Data.SqlClient
Imports QLHSDTO
Imports Utility

Public Class HOCSINHDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub


    Public Function buildmahs(ByRef nextmahs As String) As Result 'ex: 18222229

        nextmahs = String.Empty
        Dim y = DateTime.Now.Year
        Dim x = y.ToString().Substring(2)
        nextmahs = x + "000000"

        Dim query As String = String.Empty
        query &= "SELECT TOP (1000) [mahs],[hoten],[gioitinh],[diachi],[lop],[ngaysinh] "
        query &= " FROM [QLHS].[dbo].[tblHocSinh] "
        query &= "Order By [mahs] DESC "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    Dim msOnDB As String
                    msOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            msOnDB = reader("mahs")
                        End While
                    End If
                    If (msOnDB <> Nothing And msOnDB.Length >= 8) Then
                        Dim currentYear = DateTime.Now.Year.ToString().Substring(2)
                        Dim iCurrentYear = Integer.Parse(currentYear)
                        Dim currentYearOnDB = msOnDB.Substring(0, 2)
                        Dim icurrentYearOnDB = Integer.Parse(currentYearOnDB)
                        Dim year = iCurrentYear
                        If (year < icurrentYearOnDB) Then
                            year = icurrentYearOnDB
                        End If
                        nextmahs = year.ToString()
                        Dim v = msOnDB.Substring(2)
                        Dim convertDecimal = Convert.ToDecimal(v)
                        convertDecimal = convertDecimal + 1
                        Dim tmp = convertDecimal.ToString()
                        tmp = tmp.PadLeft(msOnDB.Length - 2, "0")
                        nextmahs = nextmahs + tmp
                        System.Console.WriteLine(nextmahs)
                    End If

                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tự động Mã số Học sinh kế tiếp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert(hs As HOCSINHDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [dbo].[tblHocSinh]([mahs],[hoten],[gioitinh],[diachi],[lop],[ngaysinh])"
        query &= "VALUES (@mahs,@hoten,@gioitinh,@diachi,@lop,@ngaysinh)"

        'get mahs
        Dim nextmahs = "1"
        buildmahs(nextmahs)
        hs.MaHS1 = nextmahs

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@mahs", hs.MaHS1)
                    .Parameters.AddWithValue("@hoten", hs.HoTen1)
                    .Parameters.AddWithValue("@gioitinh", hs.GioiTinh1)
                    .Parameters.AddWithValue("@diachi", hs.DiaChi1)
                    .Parameters.AddWithValue("@lop", hs.Lop1)
                    .Parameters.AddWithValue("@ngaysinh", hs.NgaySinh1)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm Học sinh không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    'Public Function selectALL(ByRef listHocSinh As List(Of HOCSINHDTO)) As Result

    '    Dim query As String = String.Empty
    '    query &= "SELECT [mahs],[hoten],[gioitinh],[diachi],[lop],[ngaysinh]"
    '    query &= "FROM [dbo].[tblHocSinh]"


    '    Using conn As New SqlConnection(connectionString)
    '        Using comm As New SqlCommand()
    '            With comm
    '                .Connection = conn
    '                .CommandType = CommandType.Text
    '                .CommandText = query
    '            End With
    '            Try
    '                conn.Open()
    '                Dim reader As SqlDataReader
    '                reader = comm.ExecuteReader()
    '                If reader.HasRows = True Then
    '                    listHocSinh.Clear()
    '                    While reader.Read()
    '                        listHocSinh.Add(New HOCSINHDTO(reader("mahs"), reader("hoten"), reader("diachi"), reader("ngaysinh"), reader("lop")))
    '                    End While
    '                End If

    '            Catch ex As Exception
    '                conn.Close()
    '                System.Console.WriteLine(ex.StackTrace)
    '                Return New Result(False, "Lấy tất cả Học sinh không thành công", ex.StackTrace)
    '            End Try
    '        End Using
    '    End Using
    '    Return New Result(True) ' thanh cong
    'End Function

    'Public Function selectALL_ByType(maLoai As Integer, ByRef listHocSinh As List(Of HOCSINHDTO)) As Result

    '    Dim query As String = String.Empty
    '    query &= "SELECT [mahs], [maloaihocsinh], [hoten], [diachi], [ngaysinh] "
    '    query &= "FROM [tblHocSinh] "
    '    query &= "WHERE [maloaihocsinh] = @maloaihocsinh "

    '    Using conn As New SqlConnection(connectionString)
    '        Using comm As New SqlCommand()
    '            With comm
    '                .Connection = conn
    '                .CommandType = CommandType.Text
    '                .CommandText = query
    '                .Parameters.AddWithValue("@maloaihocsinh", maLoai)
    '            End With
    '            Try
    '                conn.Open()
    '                Dim reader As SqlDataReader
    '                reader = comm.ExecuteReader()
    '                If reader.HasRows = True Then
    '                    listHocSinh.Clear()
    '                    While reader.Read()
    '                        listHocSinh.Add(New HOCSINHDTO(reader("mahs"), reader("maloaihocsinh"), reader("hoten"), reader("diachi"), reader("ngaysinh")))
    '                    End While
    '                End If

    '            Catch ex As Exception
    '                conn.Close()
    '                System.Console.WriteLine(ex.StackTrace)
    '                Return New Result(False, "Lấy tất cả Học sinh theo Loại không thành công", ex.StackTrace)
    '            End Try
    '        End Using
    '    End Using
    '    Return New Result(True) ' thanh cong
    'End Function


    'Public Function update(hs As HOCSINHDTO) As Result

    '    Dim query As String = String.Empty
    '    query &= " UPDATE [tblHocSinh] SET"
    '    query &= " [maloaihocsinh] = @maloaihocsinh "
    '    query &= " ,[hoten] = @hoten "
    '    query &= " ,[diachi] = @diachi "
    '    query &= " ,[ngaysinh] = @ngaysinh "
    '    query &= " WHERE "
    '    query &= " [mahs] = @mahs "

    '    Using conn As New SqlConnection(connectionString)
    '        Using comm As New SqlCommand()
    '            With comm
    '                .Connection = conn
    '                .CommandType = CommandType.Text
    '                .CommandText = query
    '                .Parameters.AddWithValue("@hoten", hs.HoTen1)
    '                .Parameters.AddWithValue("@diachi", hs.DiaChi1)
    '                .Parameters.AddWithValue("@ngaysinh", hs.NgaySinh1)
    '                .Parameters.AddWithValue("@mahs", hs.MaHS1)
    '                .Parameters.AddWithValue("@lop", hs.Lop1)
    '            End With
    '            Try
    '                conn.Open()
    '                comm.ExecuteNonQuery()
    '            Catch ex As Exception
    '                Console.WriteLine(ex.StackTrace)
    '                conn.Close()
    '                System.Console.WriteLine(ex.StackTrace)
    '                Return New Result(False, "Cập nhật Học sinh không thành công", ex.StackTrace)
    '            End Try
    '        End Using
    '    End Using
    '    Return New Result(True) ' thanh cong
    'End Function


    'Public Function delete(maHocSinh As String) As Result

    '    Dim query As String = String.Empty
    '    query &= " DELETE FROM [tblHocSinh] "
    '    query &= " WHERE "
    '    query &= " [mahs] = @mahs "

    '    Using conn As New SqlConnection(connectionString)
    '        Using comm As New SqlCommand()
    '            With comm
    '                .Connection = conn
    '                .CommandType = CommandType.Text
    '                .CommandText = query
    '                .Parameters.AddWithValue("@mahs", maHocSinh)
    '            End With
    '            Try
    '                conn.Open()
    '                comm.ExecuteNonQuery()
    '            Catch ex As Exception
    '                Console.WriteLine(ex.StackTrace)
    '                conn.Close()
    '                System.Console.WriteLine(ex.StackTrace)
    '                Return New Result(False, "Xóa Học sinh không thành công", ex.StackTrace)
    '            End Try
    '        End Using
    '    End Using
    '    Return New Result(True)  ' thanh cong
    'End Function
End Class
