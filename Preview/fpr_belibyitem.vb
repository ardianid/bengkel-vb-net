Imports System.Data
Imports System.Data.OleDb
Imports StokBengkel.Clsmy

Public Class fpr_belibyitem

    Private dvmanager As Data.DataViewManager
    Private dv1 As Data.DataView

    Private dvmanager2 As Data.DataViewManager
    Private dv2 As Data.DataView

    Private Sub openbarang()

        Const sql As String = "select kd_barang,nama_barang,0 as scek from ms_barang order by nama_barang"
        Dim cn As OleDbConnection = Nothing

        grid1.DataSource = Nothing

        Try

            'open_wait()

            dv1 = Nothing

            cn = New OleDbConnection
            cn = Clsmy.open_conn

            Dim ds As DataSet
            ds = New DataSet()
            ds = Clsmy.GetDataSet(sql, cn)

            dvmanager = New DataViewManager(ds)
            dv1 = dvmanager.CreateDataView(ds.Tables(0))

            grid1.DataSource = dv1

            'close_wait()


        Catch ex As OleDb.OleDbException
            'close_wait()
            MsgBox(ex.ToString, MsgBoxStyle.Information, "Informasi")
        Finally


            If Not cn Is Nothing Then
                If cn.State = ConnectionState.Open Then
                    cn.Close()
                End If
            End If

        End Try

    End Sub

    Private Sub open_penjual()

        Const sql As String = "select kode,nama,0 as scek from ms_penjual order by nama"
        Dim cn As OleDbConnection = Nothing

        grid2.DataSource = Nothing

        Try

            'open_wait()

            dv2 = Nothing

            cn = New OleDbConnection
            cn = Clsmy.open_conn

            Dim ds As DataSet
            ds = New DataSet()
            ds = Clsmy.GetDataSet(sql, cn)

            dvmanager2 = New DataViewManager(ds)
            dv2 = dvmanager2.CreateDataView(ds.Tables(0))

            grid2.DataSource = dv2

            'close_wait()


        Catch ex As OleDb.OleDbException
            'close_wait()
            MsgBox(ex.ToString, MsgBoxStyle.Information, "Informasi")
        Finally


            If Not cn Is Nothing Then
                If cn.State = ConnectionState.Open Then
                    cn.Close()
                End If
            End If

        End Try

    End Sub


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

    Private Sub fpr_belibyitem_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        ttgl.EditValue = DateValue(Date.Now)
        ttgl2.EditValue = DateValue(Date.Now)

        RadioGroup1.SelectedIndex = 0

        openbarang()
        open_penjual()

    End Sub

    Private Sub btload_Click(sender As System.Object, e As System.EventArgs) Handles btload.Click

        Dim sql As String = ""

        If cek_kecil.Checked = False Then

            sql = String.Format("SELECT tr_beli.nobukti, tr_beli.no_nota, tr_beli.tanggal_beli, ms_penjual.kode AS kd_toko, ms_penjual.nama AS nama_toko, ms_barang.kd_barang, ms_barang.nama_barang, " & _
            "tr_beli2.qty, tr_beli2.satuan, tr_beli2.harga, tr_beli2.disc_rp, tr_beli2.jumlah,ms_barang.satuan1,ms_barang.satuan2,ms_barang.qty1,ms_barang.qty2 " & _
            "FROM  tr_beli INNER JOIN tr_beli2 ON tr_beli.nobukti = tr_beli2.nobukti INNER JOIN " & _
            "ms_barang ON tr_beli2.kd_barang = ms_barang.kd_barang INNER JOIN ms_penjual ON tr_beli.kd_penjual = ms_penjual.kode " & _
            "where tr_beli.sbatal = 0 and tr_beli.tanggal_beli>='{0}' and tr_beli.tanggal_beli<='{1}'", convert_date_to_eng(ttgl.EditValue), convert_date_to_eng(ttgl2.EditValue))

        Else

            sql = String.Format("SELECT tr_beli.nobukti, tr_beli.no_nota, tr_beli.tanggal_beli, ms_penjual.kode AS kd_toko, ms_penjual.nama AS nama_toko, ms_barang.kd_barang,ms_barang.nama_barang, " & _
            " tr_beli2.qtykecil AS qty, " & _
            " case when tr_beli2.satuan=ms_barang.satuan1 then " & _
            " ms_barang.satuan2 else " & _
            " tr_beli2.satuan end as satuan,  " & _
            " case when tr_beli2.satuan=ms_barang.satuan1 then " & _
            " tr_beli2.harga /  (ms_barang.qty1 * ms_barang.qty2) " & _
            " else tr_beli2.harga end harga,  " & _
            " tr_beli2.disc_rp, tr_beli2.jumlah, ms_barang.satuan1, ms_barang.satuan2, ms_barang.qty1, ms_barang.qty2 " & _
            " FROM  tr_beli INNER JOIN tr_beli2 ON tr_beli.nobukti = tr_beli2.nobukti INNER JOIN " & _
            " ms_barang ON tr_beli2.kd_barang = ms_barang.kd_barang INNER JOIN ms_penjual ON tr_beli.kd_penjual = ms_penjual.kode " & _
            "where tr_beli.sbatal = 0 and tr_beli.tanggal_beli>='{0}' and tr_beli.tanggal_beli<='{1}'", convert_date_to_eng(ttgl.EditValue), convert_date_to_eng(ttgl2.EditValue))

        End If

        Dim ada As Boolean = False
        Dim kdbar As String = ""
        For i As Integer = 0 To dv1.Count - 1

            If dv1(i)("scek") = 1 Then

                ada = True

                If kdbar.Length = 0 Then
                    kdbar = "'" & dv1(i)("kd_barang").ToString & "'"
                Else
                    kdbar = String.Format("{0},'{1}'", kdbar, dv1(i)("kd_barang").ToString)
                End If

            End If

        Next

        If ada Then
            sql = String.Format(" {0} and ms_barang.kd_barang in ({1})", sql, kdbar)
        End If


        ada = False
        Dim kdtok As String = ""
        For i As Integer = 0 To dv2.Count - 1

            If dv2(i)("scek") = 1 Then

                ada = True

                If kdtok.Length = 0 Then
                    kdtok = "'" & dv2(i)("kode").ToString & "'"
                Else
                    kdtok = String.Format("{0},'{1}'", kdtok, dv2(i)("kode").ToString)
                End If

            End If

        Next

        If ada Then
            sql = String.Format(" {0} and ms_penjual.kode in ({1})", sql, kdtok)
        End If

        'If tkd_toko.Text.Trim.Length > 0 Then
        '    sql = String.Format(" {0} and ms_penjual.kode='{1}'", sql, tkd_toko.Text.Trim)
        'End If

        'If tkode.Text.Trim.Length > 0 Then
        '    sql = String.Format(" {0} and ms_barang.kd_barang='{1}'", sql, tkode.Text.Trim)
        'End If

        Dim jnislap As Integer = RadioGroup1.SelectedIndex
        Dim periode As String = String.Format("Periode : {0} s.d {1}", ttgl.Text, ttgl2.Text)

        Using fkar2 As New fpr_belibyitem2 With {.WindowState = FormWindowState.Maximized, .sql = sql, .periode = periode, .jenislap = jnislap}
            fkar2.ShowDialog(Me)
        End Using

    End Sub

    Private Sub btkeluar_Click(sender As System.Object, e As System.EventArgs) Handles btkeluar.Click
        Me.Close()
    End Sub

    Private Sub ccek1_CheckedChanged(sender As Object, e As EventArgs) Handles ccek1.CheckedChanged
        If ccek1.Checked Then
            For i As Integer = 0 To dv1.Count - 1
                dv1(i)("scek") = 1
            Next
        Else
            For i As Integer = 0 To dv1.Count - 1
                dv1(i)("scek") = 0
            Next
        End If

    End Sub

    Private Sub ccek2_CheckedChanged(sender As Object, e As EventArgs) Handles ccek2.CheckedChanged
        If ccek2.Checked Then
            For i As Integer = 0 To dv2.Count - 1
                dv2(i)("scek") = 1
            Next
        Else
            For i As Integer = 0 To dv2.Count - 1
                dv2(i)("scek") = 0
            Next
        End If

    End Sub

End Class