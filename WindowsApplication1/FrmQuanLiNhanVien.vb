Imports System.Data
Imports System.Data.SqlClient
Public Class FrmQuanLiNhanVien
    Dim con As New SqlConnection("workstation id=vulvpk00113asm.mssql.somee.com;packet size=4096;user id=kutevupro_SQLLogin_1;pwd=ycviu7svop;data source=vulvpk00113asm.mssql.somee.com;persist security info=False;initial catalog=vulvpk00113asm")
    Public Sub moketnoi()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub

    'Hàm đóng kết nối
    Public Sub dongketnoi()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
    End Sub
    'Khai báo datatable dữ liệu
    Public datatable As New DataTable()

    'Hàm lấy dữ liệu (Truyền các câu truy vấn vào)
    Public Sub laydulieu(cmd As String)
        moketnoi()
        Try
            datatable.Rows.Clear()
            Dim com As New SqlCommand(cmd, con)
            Dim da As New SqlDataAdapter(com)
            da.Fill(datatable)
            Dgvquanlinhanvien.DataSource = datatable
        Catch ex As Exception

            MessageBox.Show("Có lỗi xẩy ra khi tải dữ liệu")
        End Try
        dongketnoi()
    End Sub


    Private Sub FrmQuanLiNhanVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        laydulieu("select * from Nhan_Vien")
    End Sub
    Public status As String = ""

    'Hàm thực thi dữ liệu (Insert, Update, Delete)
    Public Sub thucthi(cmd As String)
        moketnoi()
        Try
            Dim com As New SqlCommand(cmd, con)
            com.ExecuteNonQuery()
            status = "ok"
        Catch ex As Exception
            status = "no"
        End Try
        dongketnoi()
    End Sub

    Private Sub Btnthem_Click(sender As Object, e As EventArgs) Handles Btnthem.Click
        thucthi("insert into Nhan_Vien(TenNV,Gioitinh,DiaChi,SoDT) values('" & txtTenNV.Text & "','" & txtGioiTinh.Text & "','" & TxtDiaChi.Text & "','" & TxtSDT.Text & "') ")
        laydulieu("select * from Nhan_Vien")

    End Sub

  
    Private Sub Dgvquanlinhanvien_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgvquanlinhanvien.CellClick
        Dim loaddulieu As Integer = Dgvquanlinhanvien.CurrentCell.RowIndex
        txtTenNV.Text = Dgvquanlinhanvien.Rows(loaddulieu).Cells(1).Value.ToString()
        txtGioiTinh.Text = Dgvquanlinhanvien.Rows(loaddulieu).Cells(2).Value.ToString()
        TxtDiaChi.Text = Dgvquanlinhanvien.Rows(loaddulieu).Cells(3).Value.ToString()
        TxtSDT.Text = Dgvquanlinhanvien.Rows(loaddulieu).Cells(4).Value.ToString()
       
    End Sub


    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim xoadulieu As Integer = Dgvquanlinhanvien.CurrentCell.RowIndex
        Dim id As Integer = Integer.Parse(Dgvquanlinhanvien.Rows(xoadulieu).Cells(0).Value.ToString())
        If MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            thucthi("delete from Nhan_Vien where MaNV ='" & id & "'")

        End If
        laydulieu("select * from Nhan_Vien")
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim suadulieu As Integer = Dgvquanlinhanvien.CurrentCell.RowIndex
        Dim id As Integer = Integer.Parse(Dgvquanlinhanvien.Rows(suadulieu).Cells(0).Value.ToString())
        If MessageBox.Show("Bạn có chắc chắn muốn sửa không", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            thucthi("update Nhan_Vien set TenNV = '" & txtTenNV.Text & "',Gioitinh= '" & txtGioiTinh.Text & "',DiaChi= '" & TxtDiaChi.Text & "',SoDT= '" & TxtSDT.Text & "' where MaNV='" & id & "'")
        End If
        laydulieu("select * from Nhan_Vien")
    End Sub

End Class