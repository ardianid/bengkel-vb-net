<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fkendaraan2
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
        Me.components = New System.ComponentModel.Container()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.tnopol = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.tjenis = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btclose = New DevExpress.XtraEditors.SimpleButton()
        Me.btsimpan = New DevExpress.XtraEditors.SimpleButton()
        Me.ttahun = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.tsupir = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.ttipe = New DevExpress.XtraEditors.TextEdit()
        Me.ToolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.tbanding = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.caktif = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.tnopol.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tjenis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ttahun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tsupir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ttipe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbanding.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.caktif.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(33, 50)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl2.TabIndex = 5
        Me.LabelControl2.Text = "Jenis Kend :"
        '
        'tnopol
        '
        Me.tnopol.Location = New System.Drawing.Point(103, 21)
        Me.tnopol.Name = "tnopol"
        Me.tnopol.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tnopol.Size = New System.Drawing.Size(152, 20)
        Me.tnopol.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(57, 24)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "Nopol :"
        '
        'tjenis
        '
        Me.tjenis.Location = New System.Drawing.Point(103, 47)
        Me.tjenis.Name = "tjenis"
        Me.tjenis.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tjenis.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tjenis.Properties.Items.AddRange(New Object() {"MOBIL EXPEDISI", "MOBIL WTL", "LAIN-LAIN"})
        Me.tjenis.Size = New System.Drawing.Size(214, 20)
        Me.tjenis.TabIndex = 1
        '
        'btclose
        '
        Me.btclose.Location = New System.Drawing.Point(242, 226)
        Me.btclose.Name = "btclose"
        Me.btclose.Size = New System.Drawing.Size(75, 24)
        Me.btclose.TabIndex = 7
        Me.btclose.Text = "&Keluar"
        '
        'btsimpan
        '
        Me.btsimpan.Location = New System.Drawing.Point(161, 226)
        Me.btsimpan.Name = "btsimpan"
        Me.btsimpan.Size = New System.Drawing.Size(75, 24)
        Me.btsimpan.TabIndex = 6
        Me.btsimpan.Text = "&Simpan"
        '
        'ttahun
        '
        Me.ttahun.EditValue = "0"
        Me.ttahun.Location = New System.Drawing.Point(103, 73)
        Me.ttahun.Name = "ttahun"
        Me.ttahun.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ttahun.Properties.Appearance.Options.UseFont = True
        Me.ttahun.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ttahun.Properties.Mask.EditMask = "f0"
        Me.ttahun.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.ttahun.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.ttahun.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ttahun.Size = New System.Drawing.Size(47, 20)
        Me.ttahun.TabIndex = 2
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(35, 76)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl3.TabIndex = 7
        Me.LabelControl3.Text = "Tahun Beli :"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(60, 101)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl4.TabIndex = 8
        Me.LabelControl4.Text = "Supir :"
        '
        'tsupir
        '
        Me.tsupir.Location = New System.Drawing.Point(103, 98)
        Me.tsupir.Name = "tsupir"
        Me.tsupir.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tsupir.Size = New System.Drawing.Size(214, 20)
        Me.tsupir.TabIndex = 3
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(37, 127)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl5.TabIndex = 10
        Me.LabelControl5.Text = "Tipe Kend :"
        '
        'ttipe
        '
        Me.ttipe.Location = New System.Drawing.Point(103, 124)
        Me.ttipe.Name = "ttipe"
        Me.ttipe.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ttipe.Size = New System.Drawing.Size(214, 20)
        Me.ttipe.TabIndex = 4
        Me.ttipe.ToolTip = "Contoh Tipe Kend : DOUBLE,ENGKEL,BOX DLL"
        Me.ttipe.ToolTipController = Me.ToolTipController1
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(28, 153)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl6.TabIndex = 12
        Me.LabelControl6.Text = "Perb Bensin :"
        '
        'TextEdit1
        '
        Me.TextEdit1.EditValue = "1"
        Me.TextEdit1.Enabled = False
        Me.TextEdit1.Location = New System.Drawing.Point(103, 150)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit1.Properties.Appearance.Options.UseFont = True
        Me.TextEdit1.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextEdit1.Properties.Mask.EditMask = "f0"
        Me.TextEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TextEdit1.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TextEdit1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextEdit1.Size = New System.Drawing.Size(47, 20)
        Me.TextEdit1.TabIndex = 13
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(156, 153)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(20, 13)
        Me.LabelControl7.TabIndex = 14
        Me.LabelControl7.Text = "Ltr /"
        '
        'tbanding
        '
        Me.tbanding.EditValue = "0"
        Me.tbanding.Location = New System.Drawing.Point(182, 150)
        Me.tbanding.Name = "tbanding"
        Me.tbanding.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbanding.Properties.Appearance.Options.UseFont = True
        Me.tbanding.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbanding.Properties.Mask.EditMask = "f0"
        Me.tbanding.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.tbanding.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.tbanding.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbanding.Size = New System.Drawing.Size(47, 20)
        Me.tbanding.TabIndex = 5
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(235, 153)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(14, 13)
        Me.LabelControl8.TabIndex = 16
        Me.LabelControl8.Text = "KM"
        '
        'caktif
        '
        Me.caktif.Location = New System.Drawing.Point(103, 176)
        Me.caktif.Name = "caktif"
        Me.caktif.Properties.Caption = "Ya"
        Me.caktif.Size = New System.Drawing.Size(146, 19)
        Me.caktif.TabIndex = 17
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(62, 179)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl9.TabIndex = 18
        Me.LabelControl9.Text = "Aktif :"
        '
        'fkendaraan2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 274)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.caktif)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.tbanding)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.TextEdit1)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.ttipe)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.tsupir)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.ttahun)
        Me.Controls.Add(Me.btclose)
        Me.Controls.Add(Me.btsimpan)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.tnopol)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.tjenis)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fkendaraan2"
        Me.Text = "Kendaraan"
        CType(Me.tnopol.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tjenis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ttahun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tsupir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ttipe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbanding.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.caktif.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tnopol As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tjenis As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btclose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btsimpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ttahun As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tsupir As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ttipe As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ToolTipController1 As DevExpress.Utils.ToolTipController
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tbanding As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents caktif As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
End Class
