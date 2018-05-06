<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lbTen = New System.Windows.Forms.Label()
        Me.lbHoTen = New System.Windows.Forms.Label()
        Me.lbGioiTinh = New System.Windows.Forms.Label()
        Me.lbNgaySinh = New System.Windows.Forms.Label()
        Me.lbDiaChi = New System.Windows.Forms.Label()
        Me.lbLop = New System.Windows.Forms.Label()
        Me.lbID = New System.Windows.Forms.Label()
        Me.txbMHS = New System.Windows.Forms.TextBox()
        Me.txbHT = New System.Windows.Forms.TextBox()
        Me.txbDC = New System.Windows.Forms.TextBox()
        Me.txbL = New System.Windows.Forms.TextBox()
        Me.btnDong = New System.Windows.Forms.Button()
        Me.btnNhap = New System.Windows.Forms.Button()
        Me.dtpNS = New System.Windows.Forms.DateTimePicker()
        Me.txbGT = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbTen
        '
        Me.lbTen.AutoSize = True
        Me.lbTen.Location = New System.Drawing.Point(120, 9)
        Me.lbTen.Name = "lbTen"
        Me.lbTen.Size = New System.Drawing.Size(120, 13)
        Me.lbTen.TabIndex = 0
        Me.lbTen.Text = "TIẾP NHẬN HỌC SINH"
        '
        'lbHoTen
        '
        Me.lbHoTen.AutoSize = True
        Me.lbHoTen.Location = New System.Drawing.Point(26, 103)
        Me.lbHoTen.Name = "lbHoTen"
        Me.lbHoTen.Size = New System.Drawing.Size(43, 13)
        Me.lbHoTen.TabIndex = 1
        Me.lbHoTen.Text = "Họ Tên"
        '
        'lbGioiTinh
        '
        Me.lbGioiTinh.AutoSize = True
        Me.lbGioiTinh.Location = New System.Drawing.Point(26, 148)
        Me.lbGioiTinh.Name = "lbGioiTinh"
        Me.lbGioiTinh.Size = New System.Drawing.Size(51, 13)
        Me.lbGioiTinh.TabIndex = 1
        Me.lbGioiTinh.Text = "Giới Tính"
        '
        'lbNgaySinh
        '
        Me.lbNgaySinh.AutoSize = True
        Me.lbNgaySinh.Location = New System.Drawing.Point(26, 195)
        Me.lbNgaySinh.Name = "lbNgaySinh"
        Me.lbNgaySinh.Size = New System.Drawing.Size(56, 13)
        Me.lbNgaySinh.TabIndex = 1
        Me.lbNgaySinh.Text = "Ngày Sinh"
        '
        'lbDiaChi
        '
        Me.lbDiaChi.AutoSize = True
        Me.lbDiaChi.Location = New System.Drawing.Point(26, 248)
        Me.lbDiaChi.Name = "lbDiaChi"
        Me.lbDiaChi.Size = New System.Drawing.Size(41, 13)
        Me.lbDiaChi.TabIndex = 1
        Me.lbDiaChi.Text = "Địa Chỉ"
        '
        'lbLop
        '
        Me.lbLop.AutoSize = True
        Me.lbLop.Location = New System.Drawing.Point(26, 293)
        Me.lbLop.Name = "lbLop"
        Me.lbLop.Size = New System.Drawing.Size(25, 13)
        Me.lbLop.TabIndex = 1
        Me.lbLop.Text = "Lớp"
        '
        'lbID
        '
        Me.lbID.AutoSize = True
        Me.lbID.Location = New System.Drawing.Point(26, 57)
        Me.lbID.Name = "lbID"
        Me.lbID.Size = New System.Drawing.Size(69, 13)
        Me.lbID.TabIndex = 1
        Me.lbID.Text = "Mã Học Sinh"
        '
        'txbMHS
        '
        Me.txbMHS.Location = New System.Drawing.Point(108, 50)
        Me.txbMHS.Name = "txbMHS"
        Me.txbMHS.ReadOnly = True
        Me.txbMHS.Size = New System.Drawing.Size(205, 20)
        Me.txbMHS.TabIndex = 2
        '
        'txbHT
        '
        Me.txbHT.Location = New System.Drawing.Point(108, 95)
        Me.txbHT.Name = "txbHT"
        Me.txbHT.Size = New System.Drawing.Size(205, 20)
        Me.txbHT.TabIndex = 2
        '
        'txbDC
        '
        Me.txbDC.Location = New System.Drawing.Point(108, 241)
        Me.txbDC.Name = "txbDC"
        Me.txbDC.Size = New System.Drawing.Size(205, 20)
        Me.txbDC.TabIndex = 2
        '
        'txbL
        '
        Me.txbL.Location = New System.Drawing.Point(108, 290)
        Me.txbL.Name = "txbL"
        Me.txbL.Size = New System.Drawing.Size(205, 20)
        Me.txbL.TabIndex = 2
        '
        'btnDong
        '
        Me.btnDong.Location = New System.Drawing.Point(202, 333)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(122, 23)
        Me.btnDong.TabIndex = 4
        Me.btnDong.Text = "Nhập và Đóng"
        Me.btnDong.UseVisualStyleBackColor = True
        '
        'btnNhap
        '
        Me.btnNhap.Location = New System.Drawing.Point(62, 333)
        Me.btnNhap.Name = "btnNhap"
        Me.btnNhap.Size = New System.Drawing.Size(122, 23)
        Me.btnNhap.TabIndex = 5
        Me.btnNhap.Text = "Nhập"
        Me.btnNhap.UseVisualStyleBackColor = True
        '
        'dtpNS
        '
        Me.dtpNS.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNS.Location = New System.Drawing.Point(108, 189)
        Me.dtpNS.Name = "dtpNS"
        Me.dtpNS.Size = New System.Drawing.Size(205, 20)
        Me.dtpNS.TabIndex = 6
        '
        'txbGT
        '
        Me.txbGT.Location = New System.Drawing.Point(108, 141)
        Me.txbGT.Name = "txbGT"
        Me.txbGT.Size = New System.Drawing.Size(205, 20)
        Me.txbGT.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 368)
        Me.Controls.Add(Me.txbGT)
        Me.Controls.Add(Me.dtpNS)
        Me.Controls.Add(Me.btnNhap)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.txbL)
        Me.Controls.Add(Me.txbDC)
        Me.Controls.Add(Me.txbHT)
        Me.Controls.Add(Me.txbMHS)
        Me.Controls.Add(Me.lbID)
        Me.Controls.Add(Me.lbLop)
        Me.Controls.Add(Me.lbDiaChi)
        Me.Controls.Add(Me.lbNgaySinh)
        Me.Controls.Add(Me.lbGioiTinh)
        Me.Controls.Add(Me.lbHoTen)
        Me.Controls.Add(Me.lbTen)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbTen As Label
    Friend WithEvents lbHoTen As Label
    Friend WithEvents lbGioiTinh As Label
    Friend WithEvents lbNgaySinh As Label
    Friend WithEvents lbDiaChi As Label
    Friend WithEvents lbLop As Label
    Friend WithEvents lbID As Label
    Friend WithEvents txbMHS As TextBox
    Friend WithEvents txbHT As TextBox
    Friend WithEvents txbDC As TextBox
    Friend WithEvents txbL As TextBox
    Friend WithEvents btnDong As Button
    Friend WithEvents btnNhap As Button
    Friend WithEvents dtpNS As DateTimePicker
    Friend WithEvents txbGT As TextBox
End Class
