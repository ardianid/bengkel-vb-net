Imports System.Data
Imports System.Data.OleDb
Imports StokBengkel.Clsmy

Public Class fpr_pakainett_perkend

    Private Sub fpr_pakainett_perkend_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ttgl.Focus()
    End Sub

    Private Sub fpr_pakainett_perkend_Load(sender As Object, e As EventArgs) Handles Me.Load
        ttgl.EditValue = DateValue(Date.Now)
        ttgl2.EditValue = DateValue(Date.Now)

        tjenis.SelectedIndex = 0

    End Sub

    Private Sub btload_Click(sender As System.Object, e As System.EventArgs) Handles btload.Click

        'Dim sql As String = String.Format("SELECT     ms_kendaraan.jenis_kend, ms_kendaraan.nopol, sum(tr_pakai2.jumlah) as jumlah " & _
        '"FROM         tr_pakai INNER JOIN " & _
        '"tr_pakai2 ON tr_pakai.nobukti = tr_pakai2.nobukti INNER JOIN " & _
        '"ms_kendaraan ON tr_pakai.nopol = ms_kendaraan.nopol " & _
        '"where tr_pakai.sbatal=0 and tr_pakai.tanggal>='{0}' and tr_pakai.tanggal<='{1}'", convert_date_to_eng(ttgl.EditValue), convert_date_to_eng(ttgl2.EditValue))

        'Dim sql2 As String = String.Format("SELECT ms_kendaraan.jenis_kend, tr_beli.nopol, sum(tr_beli2.jumlah) " & _
        '"FROM tr_beli INNER JOIN tr_beli2 ON tr_beli.nobukti = tr_beli2.nobukti INNER JOIN " & _
        '"ms_barang ON tr_beli2.kd_barang = ms_barang.kd_barang INNER JOIN ms_kendaraan ON tr_beli.nopol = ms_kendaraan.nopol " & _
        '"WHERE tr_beli.sbatal=0 and tr_beli.beliperbaikan=1 and tr_beli.tanggal>='{0}' and tr_beli.tanggal<='{1}'", convert_date_to_eng(ttgl.EditValue), convert_date_to_eng(ttgl2.EditValue))

        'If Not tjenis.EditValue.ToString.Equals("ALL") Then
        '    sql = String.Format(" {0} and ms_kendaraan.jenis_kend='{1}'", sql, tjenis.EditValue)
        '    sql2 = String.Format(" {0} and ms_kendaraan.jenis_kend='{1}'", sql2, tjenis.EditValue)
        'End If

        'sql = String.Format("{0} group by ms_kendaraan.jenis_kend, ms_kendaraan.nopol", sql)
        'sql2 = String.Format("{0} GROUP BY ms_kendaraan.jenis_kend, tr_beli.nopol", sql2)

        'Dim sqljadi As String = String.Format("{0} union all {1}", sql, sql2)

        Dim sqlt As String = String.Format("select jenis_kend,nopol,SUM(jumlah) as jumlah from v_pakainett_perkend where tanggal>='{0}' and tanggal<='{1}'", convert_date_to_eng(ttgl.EditValue), convert_date_to_eng(ttgl2.EditValue))

        If Not tjenis.EditValue.ToString.Equals("ALL") Then
            sqlt = String.Format("{0} and jenis_kend='{1}'", sqlt, tjenis.EditValue)
        End If

        sqlt = String.Format("{0} group by jenis_kend,nopol", sqlt)

        Dim periode As String = String.Format("Periode : {0} s.d {1}", ttgl.Text, ttgl2.Text)

        Using fkar2 As New fpr_pakainett_perkend2 With {.WindowState = FormWindowState.Maximized, .sql = sqlt, .periode = periode}
            fkar2.ShowDialog(Me)
        End Using

    End Sub

    Private Sub btkeluar_Click(sender As Object, e As EventArgs) Handles btkeluar.Click
        Me.Close()
    End Sub

End Class