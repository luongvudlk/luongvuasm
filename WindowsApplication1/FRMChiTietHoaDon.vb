Imports System.Data
Imports System.Data.SqlClient
Public Class FRMChiTietHoaDon
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
            DataGridView1.DataSource = datatable
        Catch ex As Exception

            MessageBox.Show("Có lỗi xẩy ra khi tải dữ liệu")
        End Try
        dongketnoi()
    End Sub

    Private Sub FRMChiTietHoaDon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        laydulieu("select * from Chi_Tiet_Hoa_Don")
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Dim loaddulieu As Integer = DataGridView1.CurrentCell.RowIndex

        txtMSP.Text = DataGridView1.Rows(loaddulieu).Cells(1).Value.ToString()
        TxtGia.Text = DataGridView1.Rows(loaddulieu).Cells(2).Value.ToString()
        TxtSoLuong.Text = DataGridView1.Rows(loaddulieu).Cells(3).Value.ToString()
        txtTien.Text = DataGridView1.Rows(loaddulieu).Cells(4).Value.ToString()
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

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        thucthi("insert into Chi_Tiet_Hoa_Don(MaSP,Gia,SoLuong,ThanhTien) values('" & txtMSP.Text & "','" & TxtGia.Text & "','" & TxtSoLuong.Text & "','" & txtTien.Text & "') ")
        laydulieu("select * from Chi_Tiet_Hoa_Don")
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim xoadulieu As Integer = DataGridView1.CurrentCell.RowIndex
        Dim id As Integer = Integer.Parse(DataGridView1.Rows(xoadulieu).Cells(0).Value.ToString())
        If MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            thucthi("delete from Chi_Tiet_Hoa_Don where MaCTHD ='" & id & "'")

        End If
        laydulieu("select * from Chi_Tiet_Hoa_Don")
    End Sub

    Private Sub Btnsua_Click(sender As Object, e As EventArgs) Handles Btnsua.Click
        Dim suadulieu As Integer = DataGridView1.CurrentCell.RowIndex
        Dim id As Integer = Integer.Parse(DataGridView1.Rows(suadulieu).Cells(0).Value.ToString())
        If MessageBox.Show("Bạn có chắc chắn muốn sửa không", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            thucthi("update Chi_Tiet_Hoa_Don set MaSP = '" & txtMSP.Text & "',Gia= '" & TxtGia.Text & "',SoLuong= '" & TxtSoLuong.Text & "',ThanhTien= '" & txtTien.Text & "' where MaCTHD='" & id & "'")
        End If
        laydulieu("select * from Chi_Tiet_Hoa_Don")
    End Sub

End Class