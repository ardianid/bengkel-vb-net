Imports System.Data
Imports System.Data.OleDb
Imports StokBengkel.Clsmy

Public Class fpr_pesan_vs_dtang

    Private Sub bts_toko_Click(sender As System.Object, e As System.EventArgs) Handles bts_toko.Click

        Dim fs As New fsoutlet With {.StartPosition = FormStartPosition.CenterParent, .WindowState = FormWindowState.Normal}
        fs.ShowDialog(Me)

        tkd_toko.EditValue = fs.get_KODE
        tnama_toko.EditValue = fs.get_NAMA

        'tkd_toko_EditValueChanged(sender, Nothing)

    End Sub

    Private Sub tkd_toko_EditValueChanged(sender As Object, e As System.EventArgs) Handles tkd_toko.Validated
        If tkd_toko.Text.Trim.Length > 0 Then

            Dim cn As OleDbConnection = Nothing
            Dim sql As String = String.Format("select kode as kd_toko,nama as nama_toko,alamat as alamat_toko from ms_penjual where kode='{0}'", tkd_toko.Text.Trim)

            Try

                cn = New OleDbConnection
                cn = Clsmy.open_conn

                Dim comd As OleDbCommand = New OleDbCommand(sql, cn)
                Dim dread As OleDbDataReader = comd.ExecuteReader

                If dread.HasRows Then
                    If dread.Read Then

                        tkd_toko.EditValue = dread("kd_toko").ToString
                        tnama_toko.EditValue = dread("nama_toko").ToString

                    Else
                        tkd_toko.EditValue = ""
                        tnama_toko.EditValue = ""


                    End If
                Else
                    tkd_toko.EditValue = ""
                    tnama_toko.EditValue = ""

                End If


                dread.Close()

            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Information, "Informasi")
            Finally


                If Not cn Is Nothing Then
                    If cn.State = ConnectionState.Open Then
                        cn.Close()
                    End If
                End If
            End Try

        End If
    End Sub

    Private Sub tkd_toko_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles tkd_toko.KeyDown
        If e.KeyCode = Keys.F4 Then
            bts_toko_Click(sender, Nothing)
        End If
    End Sub

    Private Sub tkd_toko_LostFocus(sender As Object, e As System.EventArgs) Handles tkd_toko.LostFocus
        If tkd_toko.Text.Trim.Length = 0 Then
            tkd_toko.EditValue = ""
            tnama_toko.EditValue = ""
        End If
    End Sub

    Private Sub tkode_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles tkode.KeyDown
        If e.KeyCode = Keys.F4 Then
            bts_barang_Click(sender, Nothing)
        End If
    End Sub

    Private Sub tkode_Validated(sender As System.Object, e As System.EventArgs) Handles tkode.Validated
        If tkode.Text.Trim.Length > 0 Then

            Dim cn As OleDbConnection = Nothing
            Try

                cn = New OleDbConnection
                cn = Clsmy.open_conn

                Dim sql As String = String.Format("select kd_barang,nama_barang,satuan1,satuan2,qty1,qty2,hargabeli from ms_barang where kd_barang='{0}'", tkode.Text.Trim)
                Dim cmd As OleDbCommand = New OleDbCommand(sql, cn)
                Dim drd As OleDbDataReader = cmd.ExecuteReader

                Dim ada As Boolean = False

                If drd.Read Then
                    If Not drd("kd_barang").ToString.Equals("") Then

                        ada = True
                        tkode.Text = drd("kd_barang").ToString
                        tnama.Text = drd("nama_barang").ToString

                    End If
                End If
                drd.Close()

                If ada = False Then
                    tkode.Text = ""
                    tnama.Text = ""
                End If

            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Information, "Informasi")
            Finally

                If Not cn Is Nothing Then
                    If cn.State = ConnectionState.Open Then
                        cn.Close()
                    End If
                End If
            End Try

        End If
    End Sub

    Private Sub tkode_LostFocus(sender As Object, e As System.EventArgs) Handles tkode.LostFocus
        If tkode.Text.Trim.Length = 0 Then
            tnama.Text = ""
        End If
    End Sub

    Private Sub bts_barang_Click(sender As System.Object, e As System.EventArgs) Handles bts_barang.Click

        Dim fs As New fsbarang With {.StartPosition = FormStartPosition.CenterParent, .WindowState = FormWindowState.Normal}
        fs.ShowDialog(Me)

        tkode.EditValue = fs.get_KODE

        tkode_Validated(sender, Nothing)

    End Sub

    Private Sub btkeluar_Click(sender As Object, e As EventArgs) Handles btkeluar.Click
        Me.Close()
    End Sub

    Private Sub fpr_pesan_vs_dtang_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ttgl.Focus()
    End Sub

    Private Sub fpr_pesan_vs_dtang_Load(sender As Object, e As EventArgs) Handles Me.Load

        RadioGroup1.EditValue = 1

        ttgl.EditValue = DateValue(Date.Now)
        ttgl2.EditValue = DateValue(Date.Now)
    End Sub

    Private Sub btload_Click(sender As System.Object, e As System.EventArgs) Handles btload.Click

        Dim sql As String = String.Format("SELECT     tr_pesanbeli.nobukti, tr_pesanbeli.tanggal, ms_penjual.kode, ms_penjual.nama, " & _
        "ms_barang.kd_barang, ms_barang.nama_barang, " & _
        "case when v_beli_pesan2.jmlpesan >= (ms_barang.qty1 * ms_barang.qty2) then " & _
        "v_beli_pesan2.jmlpesan / (ms_barang.qty1 * ms_barang.qty2) else 0 end as qty_ps1, " & _
        "case  " & _
        "when v_beli_pesan2.jmlpesan%(ms_barang.qty1 * ms_barang.qty2)>0 and v_beli_pesan2.jmlpesan>=(ms_barang.qty1 * ms_barang.qty2) then " & _
        "v_beli_pesan2.jmlpesan%(ms_barang.qty1 * ms_barang.qty2) " & _
        "when v_beli_pesan2.jmlpesan<ms_barang.qty1 then " & _
        "v_beli_pesan2.jmlpesan else 0 end as qty_ps2, " & _
        "case when v_beli_pesan2.jmldatang >= (ms_barang.qty1 * ms_barang.qty2) then " & _
        "v_beli_pesan2.jmldatang / (ms_barang.qty1 * ms_barang.qty2) else 0 end as qty_dt1, " & _
        "case  " & _
        "when v_beli_pesan2.jmldatang%(ms_barang.qty1 * ms_barang.qty2)>0 and v_beli_pesan2.jmldatang>=(ms_barang.qty1 * ms_barang.qty2) then " & _
        "v_beli_pesan2.jmldatang%(ms_barang.qty1 * ms_barang.qty2) " & _
        "when v_beli_pesan2.jmldatang<ms_barang.qty1 then " & _
        "v_beli_pesan2.jmldatang else 0 end as qty_dt2 " & _
        "FROM         v_beli_pesan2 INNER JOIN " & _
        "tr_pesanbeli ON v_beli_pesan2.nobukti = tr_pesanbeli.nobukti INNER JOIN " & _
        "ms_barang ON v_beli_pesan2.kd_barang = ms_barang.kd_barang INNER JOIN " & _
        "ms_penjual ON tr_pesanbeli.kd_toko = ms_penjual.kode " & _
        "WHERE " & _
        "tr_pesanbeli.tanggal>='{0}' and tr_pesanbeli.tanggal<='{1}'", convert_date_to_eng(ttgl.EditValue), convert_date_to_eng(ttgl2.EditValue))

        If RadioGroup1.EditValue = 2 Then
            sql = String.Format("{0} and v_beli_pesan2.jmlpesan > v_beli_pesan2.jmldatang", sql)
        End If

        If tkd_toko.Text.Trim.Length > 0 Then
            sql = String.Format(" {0} and ms_penjual.kode='{1}'", sql, tkd_toko.Text.Trim)
        End If

        If tkode.Text.Trim.Length > 0 Then
            sql = String.Format(" {0} and ms_barang.kd_barang='{1}'", sql, tkode.Text.Trim)
        End If

        Dim periode = String.Format("Periode : {0} s.d {1}", convert_date_to_ind(ttgl.EditValue), convert_date_to_ind(ttgl2.EditValue))

        Using fkar2 As New fpr_pesan_vs_dtang2 With {.WindowState = FormWindowState.Maximized, .sql = sql, .periode = periode}
            fkar2.ShowDialog(Me)
        End Using

    End Sub


End Class