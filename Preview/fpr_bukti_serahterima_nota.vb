Public Class fpr_bukti_serahterima_nota 

    Private Sub btkeluar_Click(sender As Object, e As EventArgs) Handles btkeluar.Click
        Me.Close()
    End Sub

    Private Sub fpr_bukti_serahterima_nota_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ttgl.Focus()
    End Sub

    Private Sub fpr_bukti_serahterima_nota_Load(sender As Object, e As EventArgs) Handles Me.Load
        ttgl.EditValue = DateValue(Date.Now)
        ttgl2.EditValue = DateValue(Date.Now)
    End Sub

    Private Sub btload_Click(sender As Object, e As EventArgs) Handles btload.Click

        Dim sql As String = String.Format("SELECT tr_beli.nobukti, tr_beli.tanggal_beli, ms_penjual.nama, tr_beli.note, tr_beli.total_nett, tr_beli.no_nota, tr_beli.nobukti_ps " & _
        "FROM tr_beli INNER JOIN " & _
        "ms_penjual ON tr_beli.kd_penjual = ms_penjual.kode " & _
        "WHERE tr_beli.sbatal=0 and tr_beli.tanggal_beli>='{0}' and tr_beli.tanggal_beli<='{1}'", convert_date_to_eng(ttgl.EditValue), convert_date_to_eng(ttgl2.EditValue))

        Dim periode As String = String.Format("Periode : {0} s.d {1}", convert_date_to_ind(ttgl.EditValue), convert_date_to_ind(ttgl2.EditValue))

        Using fkar2 As New fpr_bukti_serahterima_nota2 With {.WindowState = FormWindowState.Maximized, .sql = sql, .periode = periode}
            fkar2.ShowDialog(Me)
        End Using

    End Sub

End Class