﻿Imports System.Data
Imports System.Data.OleDb
Imports StokBengkel.Clsmy

Imports DevExpress.XtraReports.UI
Public Class fpr_buktibeli
    Public sql1 As String
    Public beliperbaikan As Integer

    Private Sub loadfaktur()

        Dim cn As OleDbConnection = Nothing

        Try

            cn = New OleDbConnection
            cn = Clsmy.open_conn

            Dim ds As DataSet = New ds_buktibeli
            ds = Clsmy.GetDataSet(sql1, cn)

            'dsinvoice_ku = New DataSet
            'dsinvoice_ku = ds

            Dim ops As New System.Drawing.Printing.PrinterSettings

            Dim rinvoice As New r_buktibeli() With {.DataSource = ds.Tables(0)}
            rinvoice.xuser.Text = String.Format("User : {0} | Tgl : {1}", userprog, Date.Now)
            rinvoice.DataMember = rinvoice.DataMember

            If beliperbaikan <> 1 Then
                rinvoice.xlnote.Visible = False
            End If


            rinvoice.PrinterName = ops.PrinterName
            rinvoice.CreateDocument(True)

            PrintControl1.PrintingSystem = rinvoice.PrintingSystem

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

    Private Sub fpr_invoice2_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        loadfaktur()
    End Sub

End Class