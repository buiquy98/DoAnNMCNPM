Public Class HOCSINHDTO

    Private mahs As String
    Private hoTen As String
    Private gioiTinh As String
    Private diaChi As String
    Private ngaySinh As DateTime
    Private lop As String
    Private v1 As Object
    Private v2 As Object
    Private v3 As Object
    Private v4 As Object
    Private v5 As Object

    Public Sub New()
    End Sub

    Public Sub New(v1 As Object, v2 As Object, v3 As Object, v4 As Object, v5 As Object)
        Me.v1 = v1
        Me.v2 = v2
        Me.v3 = v3
        Me.v4 = v4
        Me.v5 = v5
    End Sub

    Public Sub New(mahs As String, hoTen As String, gioiTinh As String, diaChi As String, ngaySinh As DateTime, lop As String)
        Me.mahs = mahs
        Me.hoTen = hoTen
        Me.gioiTinh = gioiTinh
        Me.diaChi = diaChi
        Me.ngaySinh = ngaySinh
        Me.lop = lop
    End Sub
    Public Property MaHS1 As String
        Get
            Return mahs
        End Get
        Set(value As String)
            mahs = value
        End Set
    End Property

    Public Property HoTen1 As String
        Get
            Return hoTen
        End Get
        Set(value As String)
            hoTen = value
        End Set
    End Property

    Public Property GioiTinh1 As String
        Get
            Return gioiTinh
        End Get
        Set(value As String)
            gioiTinh = value
        End Set
    End Property

    Public Property DiaChi1 As String
        Get
            Return diaChi
        End Get
        Set(value As String)
            diaChi = value
        End Set
    End Property

    Public Property NgaySinh1 As Date
        Get
            Return ngaySinh
        End Get
        Set(value As Date)
            ngaySinh = value
        End Set
    End Property

    Public Property Lop1 As String
        Get
            Return lop
        End Get
        Set(value As String)
            lop = value
        End Set
    End Property
End Class
