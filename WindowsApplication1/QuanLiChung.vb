Public Class QuanLiChung

    Private Sub Btnqlsp_Click(sender As Object, e As EventArgs) Handles Btnqlsp.Click
        FRMSanPham.ShowDialog()
    End Sub

    Private Sub btnqlhd_Click(sender As Object, e As EventArgs) Handles btnqlhd.Click
        FRMhoadon.ShowDialog()
    End Sub

    Private Sub btnqlcthd_Click(sender As Object, e As EventArgs) Handles btnqlcthd.Click
        FRMChiTietHoaDon.ShowDialog()
    End Sub

    Private Sub btnqlkh_Click(sender As Object, e As EventArgs) Handles btnqlkh.Click
        FRMquanliKhachHang.ShowDialog()
    End Sub

    Private Sub btnquanlinhanvien_Click(sender As Object, e As EventArgs) Handles btnquanlinhanvien.Click
        FrmQuanLiNhanVien.ShowDialog()
    End Sub

    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        Close()
    End Sub
End Class