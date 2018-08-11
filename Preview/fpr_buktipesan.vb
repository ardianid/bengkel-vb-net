Imports System.Data
Imports System.Data.OleDb
Imports StokBengkel.Clsmy

Imports DevExpress.XtraReports.UI

Public Class fpr_buktipesan

    Public sql1 As String
    Public sql2 As String
    Public nobukti As String

    Private Sub loadfaktur()

        Dim cn As OleDbConnection = Nothing

        Try

            cn = New OleDbConnection
            cn = Clsmy.open_conn

            Dim hasilbarang As Boolean = False
            Dim hasiljasa As Boolean = False

            Dim sql2 As String = String.Format("select noid from tr_pesanbeli2 where nobukti='{0}'", nobukti)
            Dim sql3 As String = String.Format("select noid from tr_pesanbeli3 where nobukti='{0}'", nobukti)

            Dim cmd2 As OleDbCommand = New OleDbCommand(sql2, cn)
            Dim drd2 As OleDbDataReader = cmd2.ExecuteReader

            If drd2.Read Then
                If IsNumeric(drd2(0).ToString) Then
                    If Integer.Parse(drd2(0).ToString) > 0 Then
                        hasilbarang = True
                    End If
                End If
            End If
            drd2.Close()

            Dim cmd3 As OleDbCommand = New OleDbCommand(sql3, cn)
            Dim drd3 As OleDbDataReader = cmd3.ExecuteReader

            If drd3.Read Then
                If IsNumeric(drd3(0).ToString) Then
                    If Integer.Parse(drd3(0).ToString) > 0 Then
                        hasiljasa = True
                    End If
                End If
            End If
            drd3.Close()

            If hasilbarang = True And hasiljasa = False Then
                loadfaktur_barang(cn)
            ElseIf hasilbarang = False And hasiljasa = True Then
                loadfaktur_jasa(cn)
            ElseIf hasilbarang = True And hasiljasa = True Then
                loadfaktur_all(cn)
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

    Private Sub loadfaktur_all(ByVal cn As OleDbConnection)

        Dim ds As DataSet = New ds_pesanbeli
        ds = Clsmy.GetDataSet(sql1, cn)

        Dim ds2 As DataSet = New ds_pesanbeli2
        ds2 = Clsmy.GetDataSet(sql2, cn)

        Dim ops As New System.Drawing.Printing.PrinterSettings

        Dim rinvoice As New r_buktipesan() With {.DataSource = ds.Tables(0)}
        rinvoice.xuser.Text = String.Format("User : {0} | Tgl : {1}", userprog, Date.Now)
        rinvoice.DataMember = rinvoice.DataMember
        rinvoice.CreateDocument()

        Dim rinvoice2 As New r_buktipesan2() With {.DataSource = ds2.Tables(0)}
        rinvoice2.xuser.Text = String.Format("User : {0} | Tgl : {1}", userprog, Date.Now)
        rinvoice2.DataMember = rinvoice2.DataMember
        rinvoice2.CreateDocument()

        rinvoice.Pages.AddRange(rinvoice2.Pages)

        rinvoice.PrintingSystem.ContinuousPageNumbering = True

        rinvoice.PrinterName = ops.PrinterName
        '  rinvoice.CreateDocument(True)

        PrintControl1.PrintingSystem = rinvoice.PrintingSystem
       

    End Sub

    Private Sub loadfaktur_barang(ByVal cn As OleDbConnection)

        Dim ds As DataSet = New ds_pesanbeli
        ds = Clsmy.GetDataSet(sql1, cn)

        Dim ops As New System.Drawing.Printing.PrinterSettings

        Dim rinvoice As New r_buktipesan() With {.DataSource = ds.Tables(0)}
        rinvoice.xuser.Text = String.Format("User : {0} | Tgl : {1}", userprog, Date.Now)
        rinvoice.DataMember = rinvoice.DataMember
        rinvoice.CreateDocument()

        rinvoice.PrinterName = ops.PrinterName
        rinvoice.CreateDocument(True)

        PrintControl1.PrintingSystem = rinvoice.PrintingSystem


    End Sub

    Private Sub loadfaktur_jasa(ByVal cn As OleDbConnection)

        Dim ds As DataSet = New ds_pesanbeli2
        ds = Clsmy.GetDataSet(sql2, cn)

        Dim ops As New System.Drawing.Printing.PrinterSettings

        Dim rinvoice As New r_buktipesan2() With {.DataSource = ds.Tables(0)}
        rinvoice.xuser.Text = String.Format("User : {0} | Tgl : {1}", userprog, Date.Now)
        rinvoice.DataMember = rinvoice.DataMember
        rinvoice.CreateDocument()

        rinvoice.PrinterName = ops.PrinterName
        rinvoice.CreateDocument(True)

        PrintControl1.PrintingSystem = rinvoice.PrintingSystem

    End Sub

    Private Sub fpr_invoice2_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        loadfaktur()
    End Sub


End Class