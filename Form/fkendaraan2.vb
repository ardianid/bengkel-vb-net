Imports System.Data
Imports System.Data.OleDb
Public Class fkendaraan2

    Public dv As DataView
    Public position As Integer
    Public addstat As Boolean
    Public sother_form As Boolean = False
    Public nopol_other As String

    Private Sub set_autocomplete_tipekend()
        Dim cn As OleDbConnection = Nothing

        Try

            cn = New OleDbConnection
            cn = Clsmy.open_conn

            Dim sql As String = "select distinct tipe_kend from ms_kendaraan"
            Dim cmd As OleDbCommand = New OleDbCommand(sql, cn)
            Dim drd As OleDbDataReader = cmd.ExecuteReader

            Dim aucom As New AutoCompleteStringCollection
            While drd.Read
                aucom.Add(drd(0).ToString)
            End While
            drd.Close()

            ttipe.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource
            ttipe.MaskBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            ttipe.MaskBox.AutoCompleteCustomSource = aucom

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

    Private Sub kosongkan()
        tnopol.Text = ""
        ttahun.EditValue = 0

        tsupir.EditValue = ""
        ttipe.EditValue = ""
        tbanding.EditValue = 0

        caktif.Checked = True
        caktif.Text = "Ya"

    End Sub

    Private Sub isi()
        tnopol.EditValue = dv(position)("nopol").ToString
        tjenis.EditValue = dv(position)("jenis_kend").ToString
        ttahun.EditValue = IIf(Not IsNumeric(dv(position)("tahun_beli").ToString), 0, dv(position)("tahun_beli").ToString)

        tsupir.EditValue = dv(position)("nama_supir").ToString
        ttipe.EditValue = dv(position)("tipe_kend").ToString

        If dv(position)("km").ToString = "" Then
            tbanding.EditValue = 0
        Else
            tbanding.EditValue = Integer.Parse(dv(position)("km").ToString)
        End If


        If dv(position)("saktif").ToString = "1" Then
            caktif.Checked = True
            caktif.Text = "Ya"
        Else
            caktif.Checked = False
            caktif.Text = "Tidak"
        End If

    End Sub

    Private Sub simpan()

        Dim cn As OleDbConnection = Nothing
        Dim sqltrans As OleDbTransaction = Nothing

        Try


            Dim cakt As Integer = 0
            If caktif.Checked = True Then
                cakt = 1
            End If

            cn = New OleDbConnection
            cn = Clsmy.open_conn

            Dim sqlc As String = String.Format("select nopol from ms_kendaraan where nopol='{0}'", tnopol.Text.Trim)
            Dim sql_insert As String = String.Format("insert into ms_kendaraan (nopol,jenis_kend,tahun_beli,nama_supir,tipe_kend,km,saktif) values('{0}','{1}',{2},'{3}','{4}',{5},{6})", tnopol.Text.Trim, tjenis.Text.Trim, ttahun.EditValue, tsupir.EditValue, ttipe.EditValue, Replace(tbanding.EditValue, ",", "."), cakt)
            Dim sql_update As String = String.Format("update ms_kendaraan set jenis_kend='{0}',tahun_beli={1},nama_supir='{2}',tipe_kend='{3}',km={4},saktif={5} where nopol='{6}'", tjenis.Text.Trim, ttahun.EditValue, tsupir.EditValue, ttipe.EditValue, Replace(tbanding.EditValue, ",", "."), cakt, tnopol.Text.Trim)

            sqltrans = cn.BeginTransaction

            Dim comd As OleDbCommand

            If addstat = True Then

                Dim cmdc As OleDbCommand = New OleDbCommand(sqlc, cn, sqltrans)
                Dim dread As OleDbDataReader = cmdc.ExecuteReader

                If dread.HasRows Then
                    If dread.Read Then

                        Dim kdka As String = dread(0).ToString

                        If kdka.Trim.Length = 0 Then
                            comd = New OleDbCommand(sql_insert, cn, sqltrans)
                            comd.ExecuteNonQuery()

                            Clsmy.InsertToLog(cn, "btkendaraan", 1, 0, 0, 0, tnopol.Text.Trim, "", sqltrans)

                            If sother_form Then
                                sqltrans.Commit()
                                Me.Close()
                                Return
                            End If

                            insertview()
                        Else

                            If Not IsNothing(sqltrans) Then
                                sqltrans.Rollback()
                            End If

                            MsgBox("Kode sudah ada ...", vbOKOnly + vbExclamation, "Informasi")
                            tnopol.Focus()
                            Return
                        End If
                    Else
                        comd = New OleDbCommand(sql_insert, cn, sqltrans)
                        comd.ExecuteNonQuery()

                        Clsmy.InsertToLog(cn, "btkendaraan", 1, 0, 0, 0, tnopol.Text.Trim, "", sqltrans)

                        If sother_form Then
                            sqltrans.Commit()
                            Me.Close()
                            Return
                        End If

                        insertview()
                    End If
                Else
                    comd = New OleDbCommand(sql_insert, cn, sqltrans)
                    comd.ExecuteNonQuery()

                    Clsmy.InsertToLog(cn, "btkendaraan", 1, 0, 0, 0, tnopol.Text.Trim, "", sqltrans)

                    If sother_form Then
                        sqltrans.Commit()
                        Me.Close()
                        Return
                    End If

                    insertview()
                End If

                dread.Close()


            Else



                comd = New OleDbCommand(sql_update, cn, sqltrans)
                comd.ExecuteNonQuery()

                Clsmy.InsertToLog(cn, "btkendaraan", 0, 1, 0, 0, tnopol.Text.Trim, "", sqltrans)

                updateview()

            End If

            sqltrans.Commit()
            MsgBox("Data telah disimpan...", vbOKOnly + vbInformation, "Informasi")

            If addstat = True Then
                kosongkan()
                tnopol.Focus()

                set_autocomplete_tipekend()

            Else
                Me.Close()
            End If


        Catch ex As Exception
            close_wait()

            If Not IsNothing(sqltrans) Then
                sqltrans.Rollback()
            End If

            MsgBox(ex.ToString)
        Finally

            If Not cn Is Nothing Then
                If cn.State = ConnectionState.Open Then
                    cn.Close()
                End If
            End If
        End Try


    End Sub

    Private Sub updateview()

        dv(position)("nopol") = tnopol.Text.Trim
        dv(position)("jenis_kend") = tjenis.Text.Trim
        dv(position)("tahun_beli") = ttahun.EditValue
        dv(position)("nama_supir") = tsupir.EditValue
        dv(position)("tipe_kend") = ttipe.EditValue
        dv(position)("km") = tbanding.EditValue

        If caktif.Checked = True Then
            dv(position)("saktif") = 1
        Else
            dv(position)("saktif") = 0
        End If

    End Sub

    Private Sub insertview()

        Dim orow As DataRowView = dv.AddNew

        orow("nopol") = tnopol.Text.Trim
        orow("jenis_kend") = tjenis.Text.Trim
        orow("tahun_beli") = ttahun.EditValue
        orow("nama_supir") = tsupir.EditValue
        orow("tipe_kend") = ttipe.EditValue
        orow("km") = tbanding.EditValue

        If caktif.Checked = True Then
            orow("saktif") = 1
        Else
            orow("saktif") = 0
        End If

        dv.EndInit()

    End Sub

    Private Sub btsimpan_Click(sender As System.Object, e As System.EventArgs) Handles btsimpan.Click

        If tnopol.Text.Trim.Length = 0 Then
            MsgBox("No Polisi tidak boleh kosong...", vbOKOnly + vbExclamation, "Informasi")
            tnopol.Focus()
            Return
        End If

        If tjenis.Text.Trim.Length = 0 Then
            MsgBox("Jenis kendaraan boleh kosong...", vbOKOnly + vbExclamation, "Informasi")
            tjenis.Focus()
            Return
        End If

        simpan()

    End Sub

    Private Sub btclose_Click(sender As System.Object, e As System.EventArgs) Handles btclose.Click
        Me.Close()
    End Sub

    Private Sub fkab2_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated

        If sother_form Then
            tjenis.Focus()
            Return
        End If


        If addstat = True Then
            tnopol.Focus()
        Else
            tjenis.Focus()
        End If
    End Sub

    Private Sub fkab2_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        set_autocomplete_tipekend()

        If sother_form Then
            tnopol.EditValue = nopol_other
            tnopol.Enabled = False
            Return
        End If

        If addstat = True Then

            tjenis.SelectedIndex = 0
            tnopol.Enabled = True
            kosongkan()
        Else
            tnopol.Enabled = False
            isi()
        End If

    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles caktif.CheckedChanged

        If caktif.Checked = True Then
            caktif.Text = "Ya"
        Else
            caktif.Text = "Tidak"
        End If

    End Sub

End Class