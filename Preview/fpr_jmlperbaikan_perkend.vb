Imports System.Data
Imports System.Data.OleDb
Imports StokBengkel.Clsmy

Public Class fpr_jmlperbaikan_perkend

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

    Private Sub fpr_jmlperbaikan_perkend_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ttgl.Focus()
    End Sub

    Private Sub fpr_jmlperbaikan_perkend_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        set_autocomplete_nopol()

        ttgl.EditValue = DateValue(Date.Now)
        ttgl2.EditValue = DateValue(Date.Now)

        tjenis_kend.SelectedIndex = 0

    End Sub

    Private Sub btkeluar_Click(sender As Object, e As EventArgs) Handles btkeluar.Click
        Me.Close()
    End Sub

    Private Sub btload_Click(sender As Object, e As EventArgs) Handles btload.Click

        Dim sql As String = String.Format("SELECT     ms_kendaraan.jenis_kend,tr_pakai.nopol, COUNT(tr_pakai.nobukti) as jml " & _
        "FROM         tr_pakai INNER JOIN " & _
        "ms_kendaraan ON tr_pakai.nopol = ms_kendaraan.nopol " & _
        "WHERE     tr_pakai.sbatal = 0 and tr_pakai.tgl_pakai>='{0}' and tr_pakai.tgl_pakai<='{1}'", convert_date_to_eng(ttgl.EditValue), convert_date_to_eng(ttgl2.EditValue))

        If tnopol.Text.Trim.ToString.Length > 0 Then
            sql = String.Format("{0} and tr_pakai.nopol='{1}'", sql, tnopol.EditValue)
        End If

        If Not tjenis_kend.EditValue.ToString.Equals("ALL") Then
            sql = String.Format("{0} and ms_kendaraan.jenis_kend='{1}'", sql, tjenis_kend.EditValue)
        End If

        sql = String.Format("{0} group by ms_kendaraan.jenis_kend,tr_pakai.nopol", sql)

        Dim sql1 As String = String.Format("SELECT     ms_kendaraan.jenis_kend, tr_beli.nopol, count(tr_beli2.nobukti) " & _
        "FROM         tr_beli INNER JOIN " & _
        "ms_kendaraan ON tr_beli.nopol = ms_kendaraan.nopol " & _
        "WHERE     tr_beli.sbatal = 0 AND tr_beli.beliperbaikan = 1 and tr_beli.tanggal_beli>='{0}' and tr_beli.tanggal_beli<='{1}'", convert_date_to_eng(ttgl.EditValue), convert_date_to_eng(ttgl2.EditValue))

        If tnopol.Text.Trim.ToString.Length > 0 Then
            sql1 = String.Format("{0} and tr_beli.nopol='{1}'", sql1, tnopol.EditValue)
        End If

        If Not tjenis_kend.EditValue.ToString.Equals("ALL") Then
            sql1 = String.Format("{0} and ms_kendaraan.jenis_kend='{1}'", sql1, tjenis_kend.EditValue)
        End If

        sql1 = String.Format("{0} group by ms_kendaraan.jenis_kend, tr_beli.nopol", sql1)

        Dim sqljadi As String = String.Format("{0} union all {1}", sql, sql1)

        Dim periode As String = String.Format("Periode : {0} s.d {1}", ttgl.EditValue, ttgl2.EditValue)

        Using fkar2 As New fpr_jmlperbaikan_perkend2 With {.WindowState = FormWindowState.Maximized, .sql = sql, .periode = periode}
            fkar2.ShowDialog(Me)
        End Using

    End Sub


End Class