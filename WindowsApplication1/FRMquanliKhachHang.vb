﻿Imports System.Data
Imports System.Data.SqlClient
Public Class FRMquanliKhachHang
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



    Private Sub FRMquanliKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        laydulieu("select * from Bang_Khach_Hang")
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim loaddulieu As Integer = DataGridView1.CurrentCell.RowIndex
        txtTKH.Text = DataGridView1.Rows(loaddulieu).Cells(1).Value.ToString()
        txtGT.Text = DataGridView1.Rows(loaddulieu).Cells(2).Value.ToString()
        txtSDT.Text = DataGridView1.Rows(loaddulieu).Cells(3).Value.ToString()
        txtDC.Text = DataGridView1.Rows(loaddulieu).Cells(4).Value.ToString()
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
        thucthi("insert into Bang_Khach_hang(TenKH,GioiTinh,SoDT,DiaChi) values('" & txtTKH.Text & "','" & txtGT.Text & "','" & txtSDT.Text & "','" & txtDC.Text & "') ")
        laydulieu("select * from Bang_Khach_hang")
    End Sub

    Private Sub BtnXoa_Click(sender As Object, e As EventArgs) Handles BtnXoa.Click
        Dim xoadulieu As Integer = DataGridView1.CurrentCell.RowIndex
        Dim id As Integer = Integer.Parse(DataGridView1.Rows(xoadulieu).Cells(0).Value.ToString())
        If MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            thucthi("delete from Bang_Khach_hang where MaKH ='" & id & "'")

        End If
        laydulieu("select * from Bang_Khach_hang")
    End Sub

    Private Sub BtnSua_Click(sender As Object, e As EventArgs) Handles BtnSua.Click
        Dim suadulieu As Integer = DataGridView1.CurrentCell.RowIndex
        Dim id As Integer = Integer.Parse(DataGridView1.Rows(suadulieu).Cells(0).Value.ToString())
        If MessageBox.Show("Bạn có chắc chắn muốn sửa không", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            thucthi("update Bang_Khach_hang set TenKH = '" & txtTKH.Text & "',Gioitinh= '" & txtGT.Text & "',SoDT= '" & txtSDT.Text & "',DiaChi= '" & txtDC.Text & "' where MaKH='" & id & "'")
        End If
        laydulieu("select * from Bang_Khach_hang")
    End Sub
End Class