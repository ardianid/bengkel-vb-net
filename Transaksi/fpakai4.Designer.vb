<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fpakai4
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.btclose = New DevExpress.XtraEditors.SimpleButton()
        Me.btsimpan = New DevExpress.XtraEditors.SimpleButton()
        Me.tkerja = New DevExpress.XtraEditors.MemoEdit()
        CType(Me.tkerja.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(28, 20)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(85, 13)
        Me.LabelControl15.TabIndex = 204
        Me.LabelControl15.Text = "Nama Pekerjaan :"
        '
        'btclose
        '
        Me.btclose.Location = New System.Drawing.Point(345, 151)
        Me.btclose.Name = "btclose"
        Me.btclose.Size = New System.Drawing.Size(67, 32)
        Me.btclose.TabIndex = 210
        Me.btclose.Text = "&Keluar"
        '
        'btsimpan
        '
        Me.btsimpan.Location = New System.Drawing.Point(272, 151)
        Me.btsimpan.Name = "btsimpan"
        Me.btsimpan.Size = New System.Drawing.Size(67, 32)
        Me.btsimpan.TabIndex = 209
        Me.btsimpan.Text = "&Simpan"
        '
        'tkerja
        '
        Me.tkerja.Location = New System.Drawing.Point(28, 39)
        Me.tkerja.Name = "tkerja"
        Me.tkerja.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tkerja.Size = New System.Drawing.Size(384, 88)
        Me.tkerja.TabIndex = 203
        '
        'fpakai4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 202)
        Me.Controls.Add(Me.btclose)
        Me.Controls.Add(Me.btsimpan)
        Me.Controls.Add(Me.LabelControl15)
        Me.Controls.Add(Me.tkerja)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fpakai4"
        Me.Text = "Pekerjaan"
        CType(Me.tkerja.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btclose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btsimpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tkerja As DevExpress.XtraEditors.MemoEdit
End Class
