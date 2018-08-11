Public Class fpr_pakaiperkelompok 

    Private Sub btkeluar_Click(sender As Object, e As EventArgs) Handles btkeluar.Click
        Me.Close()
    End Sub

    Private Sub fpr_pakaiperkelompok_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ttgl.Focus()
    End Sub

    Private Sub fpr_pakaiperkelompok_Load(sender As Object, e As EventArgs) Handles Me.Load
        ttgl.EditValue = DateValue(Date.Now)
        ttgl2.EditValue = DateValue(Date.Now)
    End Sub

    Private Sub btload_Click(sender As Object, e As EventArgs) Handles btload.Click

        Dim sql As String = String.Format("SELECT     ms_barang.kelompok,ms_barang.kd_barang,ms_barang.nama_barang, " & _
        "case when sum(v_trpakai_perbarang.qtykecil) >=  (ms_barang.qty1 * ms_barang.qty2)then " & _
        "(SUM(v_trpakai_perbarang.qtykecil) - SUM(v_trpakai_perbarang.qtykecil) % (ms_barang.qty1 * ms_barang.qty2)) / (ms_barang.qty1 * ms_barang.qty2) " & _
        "else 0 end as qty1, " & _
        "case when sum(v_trpakai_perbarang.qtykecil) >=  (ms_barang.qty1 * ms_barang.qty2) then  " & _
        "(SUM(v_trpakai_perbarang.qtykecil)% (ms_barang.qty1 * ms_barang.qty2)) " & _
        "else sum(v_trpakai_perbarang.qtykecil) end as qty2,SUM(v_trpakai_perbarang.jumlah) as jumlah " & _
        " FROM         v_trpakai_perbarang INNER JOIN " & _
        "ms_barang ON v_trpakai_perbarang.kd_barang = ms_barang.kd_barang " & _
        " WHERE v_trpakai_perbarang.tanggal>='{0}' and v_trpakai_perbarang.tanggal<='{1}' " & _
        "group by ms_barang.kelompok,ms_barang.qty1,ms_barang.qty2,ms_barang.kd_barang,ms_barang.nama_barang", convert_date_to_eng(ttgl.EditValue), convert_date_to_eng(ttgl2.EditValue))

        Dim periode As String = String.Format("Periode : {0} s.d {1}", ttgl.Text, ttgl2.Text)

        Using fkar2 As New fpr_pakaiperkelompok2 With {.WindowState = FormWindowState.Maximized, .sql = sql, .periode = periode}
            fkar2.ShowDialog(Me)
        End Using

    End Sub

End Class