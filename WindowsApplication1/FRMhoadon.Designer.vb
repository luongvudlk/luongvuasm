<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMhoadon
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
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.L = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtMHD = New System.Windows.Forms.TextBox()
        Me.TxtMKH = New System.Windows.Forms.TextBox()
        Me.txtMNV = New System.Windows.Forms.TextBox()
        Me.txtMaCTHD = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Hóa Đơn"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mã Khách Hàng"
        '
        'btnxoa
        '
        Me.btnxoa.Location = New System.Drawing.Point(504, 239)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(75, 23)
        Me.btnxoa.TabIndex = 12
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'btnsua
        '
        Me.btnsua.Location = New System.Drawing.Point(504, 295)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(75, 23)
        Me.btnsua.TabIndex = 13
        Me.btnsua.Text = "Sữa"
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(504, 185)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 23)
        Me.btnThem.TabIndex = 14
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(275, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Mã Nhân Viên"
        '
        'L
        '
        Me.L.AutoSize = True
        Me.L.Location = New System.Drawing.Point(275, 73)
        Me.L.Name = "L"
        Me.L.Size = New System.Drawing.Size(55, 13)
        Me.L.TabIndex = 16
        Me.L.Text = "Mã CTHD"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 135)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(474, 325)
        Me.DataGridView1.TabIndex = 17
        '
        'txtMHD
        '
        Me.txtMHD.Location = New System.Drawing.Point(113, 32)
        Me.txtMHD.Name = "txtMHD"
        Me.txtMHD.Size = New System.Drawing.Size(139, 20)
        Me.txtMHD.TabIndex = 18
        '
        'TxtMKH
        '
        Me.TxtMKH.Location = New System.Drawing.Point(113, 70)
        Me.TxtMKH.Name = "TxtMKH"
        Me.TxtMKH.Size = New System.Drawing.Size(139, 20)
        Me.TxtMKH.TabIndex = 19
        '
        'txtMNV
        '
        Me.txtMNV.Location = New System.Drawing.Point(356, 32)
        Me.txtMNV.Name = "txtMNV"
        Me.txtMNV.Size = New System.Drawing.Size(139, 20)
        Me.txtMNV.TabIndex = 20
        '
        'txtMaCTHD
        '
        Me.txtMaCTHD.Location = New System.Drawing.Point(356, 70)
        Me.txtMaCTHD.Name = "txtMaCTHD"
        Me.txtMaCTHD.Size = New System.Drawing.Size(139, 20)
        Me.txtMaCTHD.TabIndex = 21
        '
        'FRMhoadon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 498)
        Me.Controls.Add(Me.txtMaCTHD)
        Me.Controls.Add(Me.txtMNV)
        Me.Controls.Add(Me.TxtMKH)
        Me.Controls.Add(Me.txtMHD)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.L)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.btnsua)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FRMhoadon"
        Me.Text = "Quản Lí Hóa Dơn"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents btnsua As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents L As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtMHD As System.Windows.Forms.TextBox
    Friend WithEvents TxtMKH As System.Windows.Forms.TextBox
    Friend WithEvents txtMNV As System.Windows.Forms.TextBox
    Friend WithEvents txtMaCTHD As System.Windows.Forms.TextBox
End Class
