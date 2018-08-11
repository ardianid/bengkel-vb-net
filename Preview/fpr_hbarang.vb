Imports System.Data
Imports System.Data.OleDb
Imports StokBengkel.Clsmy

Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class fpr_hbarang

    Dim crReportDocument As r_kartustok

    Dim dvg As DataView

    Private Sub load_print()

        Cursor = Cursors.WaitCursor

        Dim cn As OleDbConnection = Nothing

        Try

            cn = New OleDbConnection
            cn = Clsmy.open_conn()

            'Dim sql As String = String.Format("SELECT hbarang_gudang.noid, hbarang_gudang.nobukti, hbarang_gudang.tanggal, ms_barang.kd_barang, ms_barang.nama_barang, hbarang_gudang.jmlin, " & _
            '    "hbarang_gudang.jmlout, hbarang_gudang.jenis, ms_barang.satuan1, ms_barang.satuan2,ms_barang.qty1, ms_barang.qty2 " & _
            '    "FROM  hbarang_gudang INNER JOIN ms_barang ON hbarang_gudang.kd_barang = ms_barang.kd_barang " & _
            '"WHERE  hbarang_gudang.tanggal >='{0}' and hbarang_gudang.tanggal <='{1}' and hbarang_gudang.kd_barang='{2}'", convert_date_to_eng(ttgl.EditValue), convert_date_to_eng(ttgl2.EditValue), tbarang.EditValue)

            Dim sql As String = String.Format("select a.nobukti,a.tanggal_beli as tanggal,b.kd_barang,c.nama_barang,convert(int,case when b.qtykecil='' then 0 else b.qtykecil end) as jin,convert(int,0) as jout,c.qty1,c.qty2,a.note " & _
            "from tr_beli a inner join tr_beli2 b on a.nobukti=b.nobukti " & _
            "inner join ms_barang c on b.kd_barang=c.kd_barang " & _
            "where sbatal=0 and a.tanggal_beli>='{0}' and a.tanggal_beli<='{1}' and b.kd_barang='{2}' " & _
            "union all " & _
            "select a.nobukti,a.tgl_pakai,b.kd_barang,c.nama_barang,convert(int,0),convert(int,case when b.qtykecil='' then 0 else b.qtykecil end),c.qty1,c.qty2,a.note " & _
            "from tr_pakai a inner join tr_pakai2 b on a.nobukti=b.nobukti inner join ms_barang c on b.kd_barang=c.kd_barang " & _
            "where sbatal=0 and a.tgl_pakai>='{0}' and a.tgl_pakai<='{1}' and b.kd_barang='{2}' " & _
            "union all " & _
            "select a.nobukti,a.tanggal,b.kd_barang,c.nama_barang,convert(int,0),convert(int,case when b.qtykecil='' then 0 else b.qtykecil end),c.qty1,c.qty2,a.alasan " & _
            "from tr_retur a inner join tr_retur2 b on a.nobukti=b.nobukti inner join ms_barang c on b.kd_barang=c.kd_barang " & _
            "where a.sbatal=0 and a.tanggal>='{0}' and a.tanggal<='{1}' and b.kd_barang='{2}' " & _
            "union all " & _
            "select a.nobukti,a.tanggal,b.kd_barang,c.nama_barang,convert(int,case when b.qty_sel='' then 0 else b.qty_sel end),convert(int,0),c.qty1,c.qty2,a.note  " & _
            "from tr_opname a inner join tr_opname2 b on a.nobukti=b.nobukti inner join ms_barang c on b.kd_barang=c.kd_barang " & _
            "where a.sbatal=0 and a.tanggal>='{0}' and a.tanggal<='{1}' and b.kd_barang='{2}'", convert_date_to_eng(ttgl.EditValue), convert_date_to_eng(ttgl2.EditValue), tbarang.EditValue)

            Dim ds As New DataSet
            ds = Clsmy.GetDataSet(sql, cn)

            Dim ds1 As New ds_kartustok
            ds1.Clear()
            ds1.Tables(0).Merge(ds.Tables(0), True, MissingSchemaAction.Ignore)

            crReportDocument = New r_kartustok
            crReportDocument.SetDataSource(ds1)

            Dim jmlold As String = cek_jmlold(cn).ToString

            crReportDocument.SetParameterValue("tgl1", convert_date_to_ind(ttgl.EditValue))
            crReportDocument.SetParameterValue("tgl2", convert_date_to_ind(ttgl2.EditValue))
            crReportDocument.SetParameterValue("ajmlold", jmlold)
            crReportDocument.SetParameterValue("userprint", String.Format("User : {0} | Tgl : {1}", userprog, Date.Now))

            CrystalReportViewer1.ReportSource = crReportDocument
            CrystalReportViewer1.Refresh()

            Cursor = Cursors.Default

        Catch ex As Exception
            Cursor = Cursors.Default
            MsgBox(ex.ToString, MsgBoxStyle.Information, "Informasi")
        Finally

            Cursor = Cursors.Default

            If Not cn Is Nothing Then
                If cn.State = ConnectionState.Open Then
                    cn.Close()
                End If
            End If
        End Try

    End Sub

    Private Function cek_jmlold(ByVal cn As OleDbConnection) As Integer

        Dim jmlold As Integer = 0

        'Dim sql As String = String.Format("select sum(jmlin)- sum(jmlout) as jmlold from hbarang_gudang where tanggal <'{0}' and kd_barang='{1}'", convert_date_to_eng(ttgl.EditValue), tbarang.EditValue)

        Dim sql As String = String.Format("select sum(b.qtykecil) as jin,0 as jout " & _
        "from tr_beli a inner join tr_beli2 b on a.nobukti=b.nobukti " & _
        "inner join ms_barang c on b.kd_barang=c.kd_barang " & _
        "where sbatal=0 and b.kd_barang='{0}' and a.tanggal_beli<'{1}' " & _
        "union all " & _
        "select 0,sum(b.qtykecil) " & _
        "from tr_pakai a inner join tr_pakai2 b on a.nobukti=b.nobukti inner join ms_barang c on b.kd_barang=c.kd_barang " & _
        "where sbatal=0 and b.kd_barang='{0}' and a.tgl_pakai<'{1}' " & _
        "union all " & _
        "select 0,sum(b.qtykecil) " & _
        "from tr_retur a inner join tr_retur2 b on a.nobukti=b.nobukti inner join ms_barang c on b.kd_barang=c.kd_barang " & _
        "where a.sbatal=0 and b.kd_barang='{0}' and a.tanggal<'{1}' " & _
        "union all " & _
        "select sum(b.qty_sel),0 " & _
        "from tr_opname a inner join tr_opname2 b on a.nobukti=b.nobukti inner join ms_barang c on b.kd_barang=c.kd_barang " & _
        "where a.sbatal=0 and b.kd_barang='{0}' and a.tanggal<'{1}'", tbarang.EditValue, convert_date_to_eng(ttgl.EditValue))

        Dim cmd As OleDbCommand = New OleDbCommand(sql, cn)
        Dim drd As OleDbDataReader = cmd.ExecuteReader

        Dim totin As Double = 0
        Dim totout As Double = 0

        If drd.HasRows Then
            While drd.Read
                totin = totin + IIf(drd(0).ToString = "", 0, drd(0).ToString)
                totout = totout + IIf(drd(1).ToString = "", 0, drd(1).ToString)
            End While
        End If

        drd.Close()

        jmlold = totin - totout

        Return jmlold

    End Function

    Private Sub isi_barang()

        Const sql As String = "select kd_barang,nama_barang from ms_barang"

        Dim cn As OleDbConnection = Nothing
        Dim ds As DataSet


        Try

            cn = Clsmy.open_conn
            ds = New DataSet
            ds = Clsmy.GetDataSet(sql, cn)

            Dim dvm As DataViewManager = New DataViewManager(ds)
            dvg = dvm.CreateDataView(ds.Tables(0))

            tbarang.Properties.DataSource = dvg

            If dvg.Count > 0 Then
                tbarang.ItemIndex = 0
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

    End Sub

    Private Sub fpr_rekapaktur_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        ttgl.EditValue = Date.Now
        ttgl2.EditValue = Date.Now

        isi_barang()

    End Sub

    Private Sub btload_Click(sender As System.Object, e As System.EventArgs) Handles btload.Click

        load_print()

    End Sub

    Private Sub tbarang_EditValueChanged(sender As Object, e As System.EventArgs) Handles tbarang.EditValueChanged

        'tnamabarang.Text = dvg(tbarang.ItemIndex)("nama_barang").ToString
        tnamabarang.Text = tbarang.GetColumnValue("nama_barang").ToString

    End Sub


End Class