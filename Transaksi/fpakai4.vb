Public Class fpakai4 

    Public dv As DataView
    Public position As Integer
    Public addstat As Boolean

    Private Sub kosongkan()

        tkerja.Text = ""       

    End Sub

    Private Sub insertview()

        Dim dta As DataTable = dv.ToTable

        Dim rows() As DataRow = dta.Select(String.Format("nama_pekerjaan='{0}'", tkerja.EditValue.ToString.Trim))

        If rows.Length > 0 Then
            MsgBox("Pekerjaan sudah ada dalam daftar...", vbOKOnly + vbInformation, "Informasi")
            tkerja.Focus()
            Return
        End If

        Dim orow As DataRowView = dv.AddNew
        orow("noid") = 0
        orow("nama_pekerjaan") = tkerja.EditValue

        dv.EndInit()

        kosongkan()
        tkerja.Focus()

    End Sub

    Private Sub updateview()
        dv(position)("nama_pekerjaan") = tkerja.EditValue
    End Sub

    Private Sub btclose_Click(sender As System.Object, e As System.EventArgs) Handles btclose.Click
        Me.Close()
    End Sub

    Private Sub ffaktur_to3_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        tkerja.Focus()
    End Sub

    Private Sub btsimpan_Click(sender As System.Object, e As System.EventArgs) Handles btsimpan.Click

        If tkerja.EditValue = "" Then
            MsgBox("Pekerjaan harus diisi...", vbOKOnly + vbInformation, "Informasi")
            tkerja.Focus()
            Return
        End If

        If addstat = True Then
            insertview()
            kosongkan()
            tkerja.Focus()
        Else
            updateview()
            Me.Close()
        End If

    End Sub

    Private Sub fpakai4_Load(sender As Object, e As EventArgs) Handles Me.Load

        If addstat = False Then
            tkerja.EditValue = dv(position)("nama_pekerjaan").ToString
        End If

    End Sub

End Class