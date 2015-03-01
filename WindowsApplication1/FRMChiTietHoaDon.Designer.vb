<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMChiTietHoaDon
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMaCTHD = New System.Windows.Forms.TextBox()
        Me.txtMSP = New System.Windows.Forms.TextBox()
        Me.TxtGia = New System.Windows.Forms.TextBox()
        Me.TxtSoLuong = New System.Windows.Forms.TextBox()
        Me.txtTien = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.Btnsua = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã CTHD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mã Sản Phẩm"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(294, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Giá"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(294, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Số Lượng"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(521, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Thành Tiền"
        '
        'txtMaCTHD
        '
        Me.txtMaCTHD.Location = New System.Drawing.Point(121, 27)
        Me.txtMaCTHD.Name = "txtMaCTHD"
        Me.txtMaCTHD.Size = New System.Drawing.Size(100, 20)
        Me.txtMaCTHD.TabIndex = 5
        '
        'txtMSP
        '
        Me.txtMSP.Location = New System.Drawing.Point(121, 68)
        Me.txtMSP.Name = "txtMSP"
        Me.txtMSP.Size = New System.Drawing.Size(100, 20)
        Me.txtMSP.TabIndex = 6
        '
        'TxtGia
        '
        Me.TxtGia.Location = New System.Drawing.Point(370, 31)
        Me.TxtGia.Name = "TxtGia"
        Me.TxtGia.Size = New System.Drawing.Size(100, 20)
        Me.TxtGia.TabIndex = 7
        '
        'TxtSoLuong
        '
        Me.TxtSoLuong.Location = New System.Drawing.Point(370, 68)
        Me.TxtSoLuong.Name = "TxtSoLuong"
        Me.TxtSoLuong.Size = New System.Drawing.Size(100, 20)
        Me.TxtSoLuong.TabIndex = 8
        '
        'txtTien
        '
        Me.txtTien.Location = New System.Drawing.Point(600, 31)
        Me.txtTien.Name = "txtTien"
        Me.txtTien.Size = New System.Drawing.Size(100, 20)
        Me.txtTien.TabIndex = 9
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(31, 132)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(569, 282)
        Me.DataGridView1.TabIndex = 10
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(624, 144)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 23)
        Me.btnThem.TabIndex = 11
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(625, 212)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 23)
        Me.btnXoa.TabIndex = 12
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'Btnsua
        '
        Me.Btnsua.Location = New System.Drawing.Point(625, 283)
        Me.Btnsua.Name = "Btnsua"
        Me.Btnsua.Size = New System.Drawing.Size(75, 23)
        Me.Btnsua.TabIndex = 13
        Me.Btnsua.Text = "Sữa"
        Me.Btnsua.UseVisualStyleBackColor = True
        '
        'FRMChiTietHoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 447)
        Me.Controls.Add(Me.Btnsua)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtTien)
        Me.Controls.Add(Me.TxtSoLuong)
        Me.Controls.Add(Me.TxtGia)
        Me.Controls.Add(Me.txtMSP)
        Me.Controls.Add(Me.txtMaCTHD)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FRMChiTietHoaDon"
        Me.Text = "Chi Tiết Hóa Đơn"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMaCTHD As System.Windows.Forms.TextBox
    Friend WithEvents txtMSP As System.Windows.Forms.TextBox
    Friend WithEvents TxtGia As System.Windows.Forms.TextBox
    Friend WithEvents TxtSoLuong As System.Windows.Forms.TextBox
    Friend WithEvents txtTien As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents Btnsua As System.Windows.Forms.Button
End Class
