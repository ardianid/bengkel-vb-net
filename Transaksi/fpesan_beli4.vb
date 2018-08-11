Public Class fpesan_beli4 

    Public dv As DataView
    Public position As Integer
    Public addstat As Boolean

    Private Sub kosongkan()

        tjasa.Text = ""
        tsatuan.Text = ""

        tjml.EditValue = 0
        
    End Sub

    Private Sub insertview()

        Dim dta As DataTable = dv.ToTable

        Dim rows() As DataRow = dta.Select(String.Format("nama_jasa='{0}' and satuan_jasa='{1}'", tjasa.EditValue.ToString.Trim, tsatuan.EditValue.ToString.Trim))

        If rows.Length > 0 Then
            MsgBox("Jasa sudah ada dalam daftar...", vbOKOnly + vbInformation, "Informasi")
            tjasa.Focus()
            Return
        End If

        Dim orow As DataRowView = dv.AddNew
        orow("noid") = 0
        orow("nama_jasa") = tjasa.EditValue
        orow("jml_jasa") = tjml.EditValue
        orow("satuan_jasa") = tsatuan.EditValue

        dv.EndInit()

        kosongkan()
        tjasa.Focus()

    End Sub

    Private Sub btclose_Click(sender As System.Object, e As System.EventArgs) Handles btclose.Click
        Me.Close()
    End Sub

    Private Sub ffaktur_to3_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        tjasa.Focus()
    End Sub

    Private Sub btsimpan_Click(sender As System.Object, e As System.EventArgs) Handles btsimpan.Click

        If tjasa.EditValue = "" Then
            MsgBox("Jasa harus diisi...", vbOKOnly + vbInformation, "Informasi")
            tjasa.Focus()
            Return
        End If

        If tjml.EditValue = 0 Then
            MsgBox("Jml harus diisi...", vbOKOnly + vbInformation, "Informasi")
            tjml.Focus()
            Return
        End If

        If tsatuan.EditValue = "" Then
            MsgBox("Satuan harus diisi...", vbOKOnly + vbInformation, "Informasi")
            tsatuan.Focus()
            Return
        End If

        If addstat = True Then
            insertview()
        Else

        End If

    End Sub


End Class