Imports QLHSBUS
Imports QLHSDAL
Imports QLHSDTO
Imports Utility
Public Class Form1
    Private hsBus As HOCSINHBUS

    Private Sub btnNhap_Click(sender As Object, e As EventArgs) Handles btnNhap.Click
        Dim hocsinh As HOCSINHDTO
        hocsinh = New HOCSINHDTO()

        '1. Mapping data from GUI control
        hocsinh.MaHS1 = txbMHS.Text
        hocsinh.HoTen1 = txbHT.Text
        hocsinh.DiaChi1 = txbDC.Text
        hocsinh.NgaySinh1 = dtpNS.Value
        hocsinh.GioiTinh1 = txbGT.Text
        hocsinh.Lop1 = txbL.Text
        '2. Business .....
        If (hsBus.isValidName(hocsinh) = False) Then
            MessageBox.Show("Họ tên học sinh không đúng")
            txbHT.Focus()
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = hsBus.insert(hocsinh)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Học sinh thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'set MSSH auto
            Dim nextMaHS = "1"
            result = hsBus.buildmaHS(nextMaHS)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy danh tự động mã Học sinh không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Return
            End If
            txbMHS.Text = nextMaHS
            txbDC.Text = String.Empty
            txbGT.Text = String.Empty
            txbL.Text = String.Empty

        Else
            MessageBox.Show("Thêm Học sinh không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hsBus = New HOCSINHBUS()

        ' Load LoaiHocSinh list
        Dim result As Result

        'set MSSH auto
        Dim nextMaHS = "1"
        result = hsBus.buildmaHS(nextMahs)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động mã Học sinh không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        txbMHS.Text = nextMaHS

    End Sub


    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Dim hocsinh As HOCSINHDTO
        hocsinh = New HOCSINHDTO()

        '1. Mapping data from GUI control
        hocsinh.MaHS1 = txbMHS.Text
        hocsinh.HoTen1 = txbHT.Text
        hocsinh.DiaChi1 = txbDC.Text
        hocsinh.NgaySinh1 = dtpNS.Value
        hocsinh.Lop1 = txbL.Text

        '2. Business .....
        If (hsBus.isValidName(hocsinh) = False) Then
            MessageBox.Show("Họ tên học sinh không đúng")
            txbHT.Focus()
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = hsBus.insert(hocsinh)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Học sinh thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Thêm Học sinh không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class