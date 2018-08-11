Imports System.Data
Imports System.Data.OleDb
Imports StokBengkel.Clsmy

Public Class fpr_pakai

    Private dvmanager As Data.DataViewManager
    Private dv1 As Data.DataView

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


    Private Sub set_autocomplete_nopol()
        Dim cn As OleDbConnection = Nothing

        Try

            cn = New OleDbConnection
            cn = Clsmy.open_conn

            Dim sql As String = "select * from ms_kendaraan"
            Dim cmd As OleDbCommand = New OleDbCommand(sql, cn)
            Dim drd As OleDbDataReader = cmd.ExecuteReader

            Dim aucom As New AutoCompleteStringCollection
            While drd.Read
                aucom.Add(drd(0).ToString)
            End While
            drd.Close()

            tnopol.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource
            tnopol.MaskBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            tnopol.MaskBox.AutoCompleteCustomSource = aucom

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, "Informasi")
        Finally


            If Not cn Is Nothing Then
                If cn.State = ConnectionState.Open Then
                    cn.Close()
                End If
            End If
        End Try

    End Sub

    Private Sub tkode_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles tkode.KeyDown
        If e.KeyCode = Keys.F4 Then
            bts_barang_Click(sender, Nothing)
        End If
    End Sub

    Private Sub tkode_LostFocus(sender As Object, e As System.EventArgs) Handles tkode.LostFocus
        If tkode.Text.Trim.Length = 0 Then
            tnama.Text = ""
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

    Private Sub bts_barang_Click(sender As System.Object, e As System.EventArgs) Handles bts_barang.Click

        Dim fs As New fsbarang With {.StartPosition = FormStartPosition.CenterParent, .WindowState = FormWindowState.Normal}
        fs.ShowDialog(Me)

        tkode.EditValue = fs.get_KODE

        tkode_Validated(sender, Nothing)

    End Sub


    Private Sub fpr_belibyitem_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        RadioGroup1.EditValue = 1

        openbarang()

        set_autocomplete_nopol()

        ttgl.EditValue = DateValue(Date.Now)
        ttgl2.EditValue = DateValue(Date.Now)

    End Sub

    Private Sub btload_Click(sender As System.Object, e As System.EventArgs) Handles btload.Click

        Dim sql As String = String.Format("SELECT tr_pakai.nobukti, tr_pakai.tgl_pakai, tr_pakai.keperluan, tr_pakai.nama_pengambil, ms_barang.kd_barang, ms_barang.nama_barang, tr_pakai2.qty, tr_pakai2.satuan,ms_proyek.nama_group,ms_subproyek.nama_sub,tr_pakai.nopol,tr_pakai2.harga,tr_pakai2.jumlah " & _
            "FROM tr_pakai INNER JOIN tr_pakai2 ON tr_pakai.nobukti = tr_pakai2.nobukti INNER JOIN " & _
            "ms_barang ON tr_pakai2.kd_barang = ms_barang.kd_barang inner join ms_subproyek on tr_pakai.kd_sub=ms_subproyek.kd_sub inner join ms_proyek on ms_subproyek.kd_group=ms_proyek.kd_group " & _
            "WHERE tr_pakai.sbatal=0 and tr_pakai.tgl_pakai>='{0}' and tr_pakai.tgl_pakai<='{1}'", convert_date_to_eng(ttgl.EditValue), convert_date_to_eng(ttgl2.EditValue))

        Dim sql2 As String = String.Format("SELECT tr_beli.nobukti, tr_beli.tanggal_beli,'' as keperluan,'' as pengambil,ms_barang.kd_barang, ms_barang.nama_barang, " & _
        "tr_beli2.qty, tr_beli2.satuan,'' as namagroup,'' as namasub, tr_beli.nopol,tr_beli2.harga,tr_beli2.jumlah " & _
        "FROM tr_beli INNER JOIN " & _
        "tr_beli2 ON tr_beli.nobukti = tr_beli2.nobukti INNER JOIN " & _
        "ms_barang ON tr_beli2.kd_barang = ms_barang.kd_barang " & _
        "WHERE tr_beli.sbatal=0 and tr_beli.beliperbaikan=1 and tr_beli.tanggal_beli>='{0}' and tr_beli.tanggal_beli<='{1}'", convert_date_to_eng(ttgl.EditValue), convert_date_to_eng(ttgl2.EditValue))


        'If tkode.Text.Trim.Length > 0 Then
        '    sql = String.Format(" {0} and ms_barang.kd_barang='{1}'", sql, tkode.Text.Trim)
        '    sql2 = String.Format(" {0} and ms_barang.kd_barang='{1}'", sql2, tkode.Text.Trim)
        'End If

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
            sql2 = String.Format(" {0} and ms_barang.kd_barang in ({1})", sql2, kdbar)
        End If


        If tperlu.Text.Trim.Length > 0 Then
            sql = String.Format(" {0} and tr_pakai.keperluan like '%{1}%'", sql, tperlu.Text.Trim)
        End If

        If tjawab.Text.Trim.Length > 0 Then
            sql = String.Format(" {0} and tr_pakai.nama_pengambil like '%{1}%'", sql, tjawab.Text.Trim)
        End If

        If tkode_proyek.Text.Trim.Length > 0 Then
            sql = String.Format(" {0} and ms_proyek.kd_group='{1}'", sql, tkode_proyek.Text.Trim)
        End If

        If tkode_sub.Text.Trim.Length > 0 Then
            sql = String.Format(" {0} and ms_subproyek.kd_sub='{1}'", sql, tkode_sub.Text.Trim)
        End If

        If tnopol.Text.Trim.Length > 0 Then
            sql = String.Format(" {0} and tr_pakai.nopol='{1}'", sql, tnopol.Text.Trim)
            sql2 = String.Format(" {0} and tr_beli.nopol='{1}'", sql2, tnopol.Text.Trim)
        End If

        Dim sqlgab As String = String.Format("{0} union all {1}", sql, sql2)

        Dim periode As String = String.Format("Periode : {0} s.d {1}", ttgl.Text, ttgl2.Text)

        Dim jenislap As Integer = 0
        If RadioGroup1.EditValue = 1 Then
            jenislap = 1
        Else
            jenislap = 2
        End If

        Using fkar2 As New fpr_pakai2 With {.WindowState = FormWindowState.Maximized, .sql = sqlgab, .periode = periode, .jenislap = jenislap}
            fkar2.ShowDialog(Me)
        End Using

    End Sub

    Private Sub btkeluar_Click(sender As System.Object, e As System.EventArgs) Handles btkeluar.Click
        Me.Close()
    End Sub


    Private Sub tkode_proyek_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles tkode_proyek.KeyDown
        If e.KeyCode = Keys.F4 Then
            bts_proyek_Click(sender, Nothing)
        End If
    End Sub

    Private Sub tkode_proyek_Validated(sender As System.Object, e As System.EventArgs) Handles tkode_proyek.Validated

        If tkode_proyek.Text.Trim.Length > 0 Then

            Dim cn As OleDbConnection = Nothing

            ' Dim sql As String = String.Format("select ms_proyek.kd_group,ms_proyek.nama_group,ms_subproyek.kd_sub,ms_subproyek.nama_sub from ms_subproyek inner join ms_proyek on ms_subproyek.kd_group=ms_proyek.kd_group where ms_subproyek.kd_sub='{0}'", tkode_proyek.Text.Trim)
            Dim sql As String = String.Format("select * from ms_proyek where kd_group='{0}'", tkode_proyek.Text.Trim)

            Try

                cn = New OleDbConnection
                cn = Clsmy.open_conn

                Dim cmd As OleDbCommand = New OleDbCommand(sql, cn)
                Dim drd As OleDbDataReader = cmd.ExecuteReader

                Dim ada As Boolean = False

                If drd.Read Then

                    If Not drd("kd_group").ToString.Equals("") Then
                        ada = True

                        tkode_proyek.Text = drd("kd_group").ToString
                        tnama_proyek.Text = drd("nama_group").ToString
                        '  tkode_sub.Text = drd("kd_group").ToString
                        '  tnama_sub.Text = drd("nama_group").ToString

                    End If

                End If
                drd.Close()

                If ada = False Then
                    tkode_proyek.Text = ""
                    tnama_proyek.Text = ""
                    '  tkode_sub.Text = ""
                    ' tnama_sub.Text = ""
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

        Else
            tnama_proyek.Text = ""
            ' tkode_sub.Text = ""
            'tnama_sub.Text = ""
        End If

    End Sub

    Private Sub bts_proyek_Click(sender As System.Object, e As System.EventArgs) Handles bts_proyek.Click

        Dim fs As New fsproyek With {.StartPosition = FormStartPosition.CenterParent, .WindowState = FormWindowState.Normal}
        fs.ShowDialog(Me)

        tkode_proyek.EditValue = fs.get_KODE

        tkode_proyek_Validated(sender, Nothing)

    End Sub



    Private Sub tkode_sub_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles tkode_sub.KeyDown
        If e.KeyCode = Keys.F4 Then
            bts_sub_Click(sender, Nothing)
        End If
    End Sub

    Private Sub tkode_sub_Validated(sender As System.Object, e As System.EventArgs) Handles tkode_sub.Validated

        If tkode_sub.Text.Trim.Length > 0 Then

            Dim cn As OleDbConnection = Nothing

            Dim sql As String = String.Format("select ms_proyek.kd_group,ms_proyek.nama_group,ms_subproyek.kd_sub,ms_subproyek.nama_sub from ms_subproyek inner join ms_proyek on ms_subproyek.kd_group=ms_proyek.kd_group where ms_subproyek.kd_sub='{0}'", tkode_sub.Text.Trim)


            Try

                cn = New OleDbConnection
                cn = Clsmy.open_conn

                Dim cmd As OleDbCommand = New OleDbCommand(sql, cn)
                Dim drd As OleDbDataReader = cmd.ExecuteReader

                Dim ada As Boolean = False

                If drd.Read Then

                    If Not drd("kd_group").ToString.Equals("") Then
                        ada = True

                        tkode_sub.Text = drd("kd_sub").ToString
                        tnama_sub.Text = drd("nama_sub").ToString

                    End If

                End If
                drd.Close()

                If ada = False Then
                    
                    tkode_sub.Text = ""
                    tnama_sub.Text = ""
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

        Else
            tnama_sub.Text = ""
        End If

    End Sub

    Private Sub bts_sub_Click(sender As System.Object, e As System.EventArgs) Handles bts_sub.Click

        Dim fs As New fsproyeksub With {.StartPosition = FormStartPosition.CenterParent, .WindowState = FormWindowState.Normal}
        fs.ShowDialog(Me)

        tkode_sub.EditValue = fs.get_KODE

        tkode_sub_Validated(sender, Nothing)

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


End Class