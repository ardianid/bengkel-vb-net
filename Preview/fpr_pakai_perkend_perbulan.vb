Imports System.Data.OleDb

Public Class fpr_pakai_perkend_perbulan

    Private Sub cek_jmlkendaraan()

        Dim cn As OleDbConnection = Nothing
        Try

            cn = New OleDbConnection
            cn = Clsmy.open_conn()

            Dim sql As String = "select COUNT(nopol) from ms_kendaraan"

            If Not tjenis_kend.EditValue.ToString.Equals("ALL") Then
                sql = String.Format("{0} where jenis_kend='{1}'", sql, tjenis_kend.EditValue)
            End If

            Dim cmd As OleDbCommand = New OleDbCommand(sql, cn)
            Dim drd As OleDbDataReader = cmd.ExecuteReader

            Dim jmlkend As Integer = 0
            If drd.Read Then
                If IsNumeric(drd(0).ToString) Then
                    jmlkend = Integer.Parse(drd(0).ToString)
                End If
            End If
            drd.Close()

            tjml_kend.EditValue = jmlkend
            Ttop_n.EditValue = System.Math.Round(0.2 * jmlkend)

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

    Private Sub fpr_pakai_perkend_perbulan_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ttahun.Focus()
    End Sub

    Private Sub fpr_pakai_perkend_perbulan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ttahun.EditValue = Year(Date.Now)
        tbln1.EditValue = Month(Date.Now)
        tbln2.EditValue = Month(Date.Now)

        tjenis_kend.SelectedIndex = 0

    End Sub

    Private Sub btclose_Click(sender As Object, e As EventArgs) Handles btclose.Click
        Me.Close()
    End Sub

    Private Sub btload_Click(sender As Object, e As EventArgs) Handles btload.Click

        Dim thn As Integer = Year(Date.Now)

        Dim sql As String = String.Format("select jenis_kend,nopol,MONTH(tanggal) as bln,SUM(jumlah) as jumlah,case when tahun_beli=0 then 0 else {3}-tahun_beli end as umur " & _
        "from v_pakainett_perkend where YEAR(tanggal)={0} and MONTH(tanggal)>={1} and MONTH(tanggal)<={2} ", ttahun.EditValue, tbln1.EditValue, tbln2.EditValue, thn)

        If Not tjenis_kend.EditValue.ToString.Equals("ALL") Then
            sql = String.Format("{0} and jenis_kend='{1}' ", sql, tjenis_kend.EditValue)
        End If

        sql = String.Format("{0} and nopol in (select top {1} nopol from v_pakainett_perkend " & _
        "where YEAR(tanggal)={2} and MONTH(tanggal)>={3} and MONTH(tanggal)<={4} ", sql, Ttop_n.EditValue, ttahun.EditValue, tbln1.EditValue, tbln2.EditValue)

        If Not tjenis_kend.EditValue.ToString.Equals("ALL") Then
            sql = String.Format("{0} and jenis_kend='{1}' ", sql, tjenis_kend.EditValue)
        End If

        sql = String.Format("{0} group by nopol order by SUM(jumlah) desc) " & _
        "group by jenis_kend,nopol,MONTH(tanggal),tahun_beli", sql)

        Dim periode As String = String.Format("Tahun : {0}", ttahun.EditValue)

        Dim fs As New fpr_pakai_perkend_perbulan2 With {.WindowState = FormWindowState.Maximized, .sql = sql, .periode = periode}
        fs.ShowDialog()

    End Sub

    Private Sub tjenis_kend_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tjenis_kend.SelectedIndexChanged
        cek_jmlkendaraan()
    End Sub

End Class