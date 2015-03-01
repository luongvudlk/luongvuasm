<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuanLiChung
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
        Me.Btnqlsp = New System.Windows.Forms.Button()
        Me.btnqlhd = New System.Windows.Forms.Button()
        Me.btnqlcthd = New System.Windows.Forms.Button()
        Me.btnquanlinhanvien = New System.Windows.Forms.Button()
        Me.btnqlkh = New System.Windows.Forms.Button()
        Me.btnthoat = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btnqlsp
        '
        Me.Btnqlsp.Location = New System.Drawing.Point(36, 54)
        Me.Btnqlsp.Name = "Btnqlsp"
        Me.Btnqlsp.Size = New System.Drawing.Size(194, 23)
        Me.Btnqlsp.TabIndex = 0
        Me.Btnqlsp.Text = "Quản Lí Sản Phẩm"
        Me.Btnqlsp.UseVisualStyleBackColor = True
        '
        'btnqlhd
        '
        Me.btnqlhd.Location = New System.Drawing.Point(36, 103)
        Me.btnqlhd.Name = "btnqlhd"
        Me.btnqlhd.Size = New System.Drawing.Size(194, 23)
        Me.btnqlhd.TabIndex = 1
        Me.btnqlhd.Text = "Quản Lí Hóa Đơn"
        Me.btnqlhd.UseVisualStyleBackColor = True
        '
        'btnqlcthd
        '
        Me.btnqlcthd.Location = New System.Drawing.Point(291, 54)
        Me.btnqlcthd.Name = "btnqlcthd"
        Me.btnqlcthd.Size = New System.Drawing.Size(194, 23)
        Me.btnqlcthd.TabIndex = 2
        Me.btnqlcthd.Text = "Quản Lí Chi Tiết Hóa Đơn"
        Me.btnqlcthd.UseVisualStyleBackColor = True
        '
        'btnquanlinhanvien
        '
        Me.btnquanlinhanvien.Location = New System.Drawing.Point(167, 148)
        Me.btnquanlinhanvien.Name = "btnquanlinhanvien"
        Me.btnquanlinhanvien.Size = New System.Drawing.Size(194, 23)
        Me.btnquanlinhanvien.TabIndex = 3
        Me.btnquanlinhanvien.Text = "Quản Lí Nhân viên"
        Me.btnquanlinhanvien.UseVisualStyleBackColor = True
        '
        'btnqlkh
        '
        Me.btnqlkh.Location = New System.Drawing.Point(291, 103)
        Me.btnqlkh.Name = "btnqlkh"
        Me.btnqlkh.Size = New System.Drawing.Size(194, 23)
        Me.btnqlkh.TabIndex = 4
        Me.btnqlkh.Text = "Quản Lí Khách Hàng"
        Me.btnqlkh.UseVisualStyleBackColor = True
        '
        'btnthoat
        '
        Me.btnthoat.Location = New System.Drawing.Point(222, 177)
        Me.btnthoat.Name = "btnthoat"
        Me.btnthoat.Size = New System.Drawing.Size(75, 23)
        Me.btnthoat.TabIndex = 5
        Me.btnthoat.Text = "Thoát"
        Me.btnthoat.UseVisualStyleBackColor = True
        '
        'QuanLiChung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 259)
        Me.Controls.Add(Me.btnthoat)
        Me.Controls.Add(Me.btnqlkh)
        Me.Controls.Add(Me.btnquanlinhanvien)
        Me.Controls.Add(Me.btnqlcthd)
        Me.Controls.Add(Me.btnqlhd)
        Me.Controls.Add(Me.Btnqlsp)
        Me.Name = "QuanLiChung"
        Me.Text = "QuanLiChung"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btnqlsp As System.Windows.Forms.Button
    Friend WithEvents btnqlhd As System.Windows.Forms.Button
    Friend WithEvents btnqlcthd As System.Windows.Forms.Button
    Friend WithEvents btnquanlinhanvien As System.Windows.Forms.Button
    Friend WithEvents btnqlkh As System.Windows.Forms.Button
    Friend WithEvents btnthoat As System.Windows.Forms.Button
End Class
