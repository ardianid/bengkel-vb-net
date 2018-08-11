<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fpr_pakai_perkend_perbulan
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
        Me.btclose = New DevExpress.XtraEditors.SimpleButton()
        Me.btload = New DevExpress.XtraEditors.SimpleButton()
        Me.tbln2 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.tbln1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.ttahun = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.tjenis_kend = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.Ttop_n = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.tjml_kend = New DevExpress.XtraEditors.TextEdit()
        CType(Me.tbln2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbln1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ttahun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tjenis_kend.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ttop_n.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tjml_kend.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btclose
        '
        Me.btclose.Location = New System.Drawing.Point(287, 199)
        Me.btclose.Name = "btclose"
        Me.btclose.Size = New System.Drawing.Size(60, 26)
        Me.btclose.TabIndex = 6
        Me.btclose.Text = "&Keluar"
        '
        'btload
        '
        Me.btload.Location = New System.Drawing.Point(221, 199)
        Me.btload.Name = "btload"
        Me.btload.Size = New System.Drawing.Size(60, 26)
        Me.btload.TabIndex = 5
        Me.btload.Text = "&Load"
        '
        'tbln2
        '
        Me.tbln2.Location = New System.Drawing.Point(93, 64)
        Me.tbln2.Name = "tbln2"
        Me.tbln2.Properties.Mask.EditMask = "f0"
        Me.tbln2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.tbln2.Size = New System.Drawing.Size(67, 20)
        Me.tbln2.TabIndex = 2
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(17, 67)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl3.TabIndex = 12
        Me.LabelControl3.Text = "Sampai Bulan :"
        '
        'tbln1
        '
        Me.tbln1.Location = New System.Drawing.Point(93, 38)
        Me.tbln1.Name = "tbln1"

        Me.tbln1.Properties.Mask.EditMask = "f0"
        Me.tbln1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.tbln1.Size = New System.Drawing.Size(67, 20)
        Me.tbln1.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(32, 41)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl2.TabIndex = 9
        Me.LabelControl2.Text = "Dari Bulan :"
        '
        'ttahun
        '
        Me.ttahun.Location = New System.Drawing.Point(93, 12)
        Me.ttahun.Name = "ttahun"
        Me.ttahun.Properties.Mask.EditMask = "f0"
        Me.ttahun.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.ttahun.Size = New System.Drawing.Size(67, 20)
        Me.ttahun.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(50, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "Tahun :"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(29, 93)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl4.TabIndex = 14
        Me.LabelControl4.Text = "Jenis Kend :"
        '
        'tjenis_kend
        '
        Me.tjenis_kend.Location = New System.Drawing.Point(93, 90)
        Me.tjenis_kend.Name = "tjenis_kend"
        Me.tjenis_kend.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tjenis_kend.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tjenis_kend.Properties.Items.AddRange(New Object() {"ALL", "MOBIL EXPEDISI", "MOBIL WTL", "LAIN-LAIN"})
        Me.tjenis_kend.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.tjenis_kend.Size = New System.Drawing.Size(254, 20)
        Me.tjenis_kend.TabIndex = 3
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(17, 130)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(309, 13)
        Me.LabelControl5.TabIndex = 15
        Me.LabelControl5.Text = "Jml No Polisi ditampilkan dari urutan pemakaian terbesar adalah :"
        '
        'Ttop_n
        '
        Me.Ttop_n.Location = New System.Drawing.Point(17, 149)
        Me.Ttop_n.Name = "Ttop_n"
        Me.Ttop_n.Properties.Mask.EditMask = "f0"
        Me.Ttop_n.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.Ttop_n.Size = New System.Drawing.Size(41, 20)
        Me.Ttop_n.TabIndex = 4
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(64, 152)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(108, 13)
        Me.LabelControl6.TabIndex = 17
        Me.LabelControl6.Text = "Dari Total Kendaraan :"
        '
        'tjml_kend
        '
        Me.tjml_kend.Location = New System.Drawing.Point(178, 149)
        Me.tjml_kend.Name = "tjml_kend"
        Me.tjml_kend.Properties.Mask.EditMask = "f0"
        Me.tjml_kend.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.tjml_kend.Properties.ReadOnly = True
        Me.tjml_kend.Size = New System.Drawing.Size(41, 20)
        Me.tjml_kend.TabIndex = 18
        '
        'fpr_pakai_perkend_perbulan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 237)
        Me.Controls.Add(Me.tjml_kend)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.Ttop_n)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.tjenis_kend)
        Me.Controls.Add(Me.btclose)
        Me.Controls.Add(Me.btload)
        Me.Controls.Add(Me.tbln2)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.tbln1)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.ttahun)
        Me.Controls.Add(Me.LabelControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fpr_pakai_perkend_perbulan"
        Me.Text = "Pemakaian Per Kendaraan Per Bulan"
        CType(Me.tbln2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbln1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ttahun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tjenis_kend.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ttop_n.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tjml_kend.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btclose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btload As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tbln2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tbln1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ttahun As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tjenis_kend As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Ttop_n As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tjml_kend As DevExpress.XtraEditors.TextEdit
End Class
