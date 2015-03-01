<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQuanLiNhanVien
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
        Me.LblMNV = New System.Windows.Forms.Label()
        Me.LblTenNV = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMaNV = New System.Windows.Forms.TextBox()
        Me.txtTenNV = New System.Windows.Forms.TextBox()
        Me.txtGioiTinh = New System.Windows.Forms.TextBox()
        Me.TxtDiaChi = New System.Windows.Forms.TextBox()
        Me.TxtSDT = New System.Windows.Forms.TextBox()
        Me.Dgvquanlinhanvien = New System.Windows.Forms.DataGridView()
        Me.Btnthem = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        CType(Me.Dgvquanlinhanvien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblMNV
        '
        Me.LblMNV.AutoSize = True
        Me.LblMNV.Location = New System.Drawing.Point(31, 27)
        Me.LblMNV.Name = "LblMNV"
        Me.LblMNV.Size = New System.Drawing.Size(75, 13)
        Me.LblMNV.TabIndex = 0
        Me.LblMNV.Text = "Mã Nhân Viên"
        '
        'LblTenNV
        '
        Me.LblTenNV.AutoSize = True
        Me.LblTenNV.Location = New System.Drawing.Point(27, 56)
        Me.LblTenNV.Name = "LblTenNV"
        Me.LblTenNV.Size = New System.Drawing.Size(79, 13)
        Me.LblTenNV.TabIndex = 1
        Me.LblTenNV.Text = "Tên Nhân Viên"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(298, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ĐỊa Chỉ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(298, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Giới Tính"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(533, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Số Điện thoại"
        '
        'txtMaNV
        '
        Me.txtMaNV.Location = New System.Drawing.Point(112, 24)
        Me.txtMaNV.Name = "txtMaNV"
        Me.txtMaNV.Size = New System.Drawing.Size(147, 20)
        Me.txtMaNV.TabIndex = 5
        '
        'txtTenNV
        '
        Me.txtTenNV.Location = New System.Drawing.Point(112, 54)
        Me.txtTenNV.Name = "txtTenNV"
        Me.txtTenNV.Size = New System.Drawing.Size(147, 20)
        Me.txtTenNV.TabIndex = 6
        '
        'txtGioiTinh
        '
        Me.txtGioiTinh.Location = New System.Drawing.Point(355, 58)
        Me.txtGioiTinh.Name = "txtGioiTinh"
        Me.txtGioiTinh.Size = New System.Drawing.Size(147, 20)
        Me.txtGioiTinh.TabIndex = 7
        '
        'TxtDiaChi
        '
        Me.TxtDiaChi.Location = New System.Drawing.Point(355, 24)
        Me.TxtDiaChi.Name = "TxtDiaChi"
        Me.TxtDiaChi.Size = New System.Drawing.Size(147, 20)
        Me.TxtDiaChi.TabIndex = 7
        '
        'TxtSDT
        '
        Me.TxtSDT.Location = New System.Drawing.Point(610, 24)
        Me.TxtSDT.Name = "TxtSDT"
        Me.TxtSDT.Size = New System.Drawing.Size(147, 20)
        Me.TxtSDT.TabIndex = 8
        '
        'Dgvquanlinhanvien
        '
        Me.Dgvquanlinhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgvquanlinhanvien.Location = New System.Drawing.Point(34, 150)
        Me.Dgvquanlinhanvien.Name = "Dgvquanlinhanvien"
        Me.Dgvquanlinhanvien.Size = New System.Drawing.Size(707, 254)
        Me.Dgvquanlinhanvien.TabIndex = 9
        '
        'Btnthem
        '
        Me.Btnthem.Location = New System.Drawing.Point(205, 104)
        Me.Btnthem.Name = "Btnthem"
        Me.Btnthem.Size = New System.Drawing.Size(75, 23)
        Me.Btnthem.TabIndex = 10
        Me.Btnthem.Text = "Thêm"
        Me.Btnthem.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(340, 104)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 23)
        Me.btnXoa.TabIndex = 11
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(479, 104)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 23)
        Me.btnSua.TabIndex = 12
        Me.btnSua.Text = "Sữa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'FrmQuanLiNhanVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 477)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.Btnthem)
        Me.Controls.Add(Me.Dgvquanlinhanvien)
        Me.Controls.Add(Me.TxtSDT)
        Me.Controls.Add(Me.TxtDiaChi)
        Me.Controls.Add(Me.txtGioiTinh)
        Me.Controls.Add(Me.txtTenNV)
        Me.Controls.Add(Me.txtMaNV)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LblTenNV)
        Me.Controls.Add(Me.LblMNV)
        Me.Name = "FrmQuanLiNhanVien"
        Me.Text = "FrmQuanLiNhanVien"
        CType(Me.Dgvquanlinhanvien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblMNV As System.Windows.Forms.Label
    Friend WithEvents LblTenNV As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMaNV As System.Windows.Forms.TextBox
    Friend WithEvents txtTenNV As System.Windows.Forms.TextBox
    Friend WithEvents txtGioiTinh As System.Windows.Forms.TextBox
    Friend WithEvents TxtDiaChi As System.Windows.Forms.TextBox
    Friend WithEvents TxtSDT As System.Windows.Forms.TextBox
    Friend WithEvents Dgvquanlinhanvien As System.Windows.Forms.DataGridView
    Friend WithEvents Btnthem As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
End Class
