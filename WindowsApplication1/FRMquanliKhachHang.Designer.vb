<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMquanliKhachHang
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
        Me.lblMKH = New System.Windows.Forms.Label()
        Me.LblTKH = New System.Windows.Forms.Label()
        Me.LblGT = New System.Windows.Forms.Label()
        Me.LblSDT = New System.Windows.Forms.Label()
        Me.LblDC = New System.Windows.Forms.Label()
        Me.txtMKH = New System.Windows.Forms.TextBox()
        Me.txtTKH = New System.Windows.Forms.TextBox()
        Me.txtGT = New System.Windows.Forms.TextBox()
        Me.txtSDT = New System.Windows.Forms.TextBox()
        Me.txtDC = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.BtnXoa = New System.Windows.Forms.Button()
        Me.BtnSua = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMKH
        '
        Me.lblMKH.AutoSize = True
        Me.lblMKH.Location = New System.Drawing.Point(12, 22)
        Me.lblMKH.Name = "lblMKH"
        Me.lblMKH.Size = New System.Drawing.Size(85, 13)
        Me.lblMKH.TabIndex = 0
        Me.lblMKH.Text = "Mã Khách Hàng"
        '
        'LblTKH
        '
        Me.LblTKH.AutoSize = True
        Me.LblTKH.Location = New System.Drawing.Point(12, 50)
        Me.LblTKH.Name = "LblTKH"
        Me.LblTKH.Size = New System.Drawing.Size(87, 13)
        Me.LblTKH.TabIndex = 1
        Me.LblTKH.Text = "Tên Khách hàng"
        '
        'LblGT
        '
        Me.LblGT.AutoSize = True
        Me.LblGT.Location = New System.Drawing.Point(299, 22)
        Me.LblGT.Name = "LblGT"
        Me.LblGT.Size = New System.Drawing.Size(51, 13)
        Me.LblGT.TabIndex = 2
        Me.LblGT.Text = "Giới Tính"
        '
        'LblSDT
        '
        Me.LblSDT.AutoSize = True
        Me.LblSDT.Location = New System.Drawing.Point(299, 50)
        Me.LblSDT.Name = "LblSDT"
        Me.LblSDT.Size = New System.Drawing.Size(78, 13)
        Me.LblSDT.TabIndex = 3
        Me.LblSDT.Text = "Số Điện Thoại "
        '
        'LblDC
        '
        Me.LblDC.AutoSize = True
        Me.LblDC.Location = New System.Drawing.Point(569, 32)
        Me.LblDC.Name = "LblDC"
        Me.LblDC.Size = New System.Drawing.Size(41, 13)
        Me.LblDC.TabIndex = 4
        Me.LblDC.Text = "Địa Chỉ"
        '
        'txtMKH
        '
        Me.txtMKH.Location = New System.Drawing.Point(118, 22)
        Me.txtMKH.Name = "txtMKH"
        Me.txtMKH.Size = New System.Drawing.Size(128, 20)
        Me.txtMKH.TabIndex = 5
        '
        'txtTKH
        '
        Me.txtTKH.Location = New System.Drawing.Point(118, 50)
        Me.txtTKH.Name = "txtTKH"
        Me.txtTKH.Size = New System.Drawing.Size(128, 20)
        Me.txtTKH.TabIndex = 6
        '
        'txtGT
        '
        Me.txtGT.Location = New System.Drawing.Point(383, 22)
        Me.txtGT.Name = "txtGT"
        Me.txtGT.Size = New System.Drawing.Size(128, 20)
        Me.txtGT.TabIndex = 7
        '
        'txtSDT
        '
        Me.txtSDT.Location = New System.Drawing.Point(383, 50)
        Me.txtSDT.Name = "txtSDT"
        Me.txtSDT.Size = New System.Drawing.Size(128, 20)
        Me.txtSDT.TabIndex = 8
        '
        'txtDC
        '
        Me.txtDC.Location = New System.Drawing.Point(616, 25)
        Me.txtDC.Name = "txtDC"
        Me.txtDC.Size = New System.Drawing.Size(128, 20)
        Me.txtDC.TabIndex = 9
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(27, 107)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(659, 324)
        Me.DataGridView1.TabIndex = 10
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(728, 146)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 23)
        Me.btnThem.TabIndex = 11
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'BtnXoa
        '
        Me.BtnXoa.Location = New System.Drawing.Point(728, 219)
        Me.BtnXoa.Name = "BtnXoa"
        Me.BtnXoa.Size = New System.Drawing.Size(75, 23)
        Me.BtnXoa.TabIndex = 12
        Me.BtnXoa.Text = "Xóa"
        Me.BtnXoa.UseVisualStyleBackColor = True
        '
        'BtnSua
        '
        Me.BtnSua.Location = New System.Drawing.Point(728, 308)
        Me.BtnSua.Name = "BtnSua"
        Me.BtnSua.Size = New System.Drawing.Size(75, 23)
        Me.BtnSua.TabIndex = 13
        Me.BtnSua.Text = "Sữa"
        Me.BtnSua.UseVisualStyleBackColor = True
        '
        'FRMquanliKhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 458)
        Me.Controls.Add(Me.BtnSua)
        Me.Controls.Add(Me.BtnXoa)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtDC)
        Me.Controls.Add(Me.txtSDT)
        Me.Controls.Add(Me.txtGT)
        Me.Controls.Add(Me.txtTKH)
        Me.Controls.Add(Me.txtMKH)
        Me.Controls.Add(Me.LblDC)
        Me.Controls.Add(Me.LblSDT)
        Me.Controls.Add(Me.LblGT)
        Me.Controls.Add(Me.LblTKH)
        Me.Controls.Add(Me.lblMKH)
        Me.Name = "FRMquanliKhachHang"
        Me.Text = "Quản Lí Khách Hàng"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMKH As System.Windows.Forms.Label
    Friend WithEvents LblTKH As System.Windows.Forms.Label
    Friend WithEvents LblGT As System.Windows.Forms.Label
    Friend WithEvents LblSDT As System.Windows.Forms.Label
    Friend WithEvents LblDC As System.Windows.Forms.Label
    Friend WithEvents txtMKH As System.Windows.Forms.TextBox
    Friend WithEvents txtTKH As System.Windows.Forms.TextBox
    Friend WithEvents txtGT As System.Windows.Forms.TextBox
    Friend WithEvents txtSDT As System.Windows.Forms.TextBox
    Friend WithEvents txtDC As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents BtnXoa As System.Windows.Forms.Button
    Friend WithEvents BtnSua As System.Windows.Forms.Button
End Class
