﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fpr_jmlperbaikan_perkend
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
        Me.ttgl2 = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.ttgl = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.tnopol = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.tjenis_kend = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btkeluar = New DevExpress.XtraEditors.SimpleButton()
        Me.btload = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.ttgl2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ttgl2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ttgl.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ttgl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tnopol.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tjenis_kend.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ttgl2
        '
        Me.ttgl2.EditValue = Nothing
        Me.ttgl2.Location = New System.Drawing.Point(227, 12)
        Me.ttgl2.Name = "ttgl2"
        Me.ttgl2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ttgl2.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ttgl2.Properties.Mask.EditMask = ""
        Me.ttgl2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.ttgl2.Size = New System.Drawing.Size(113, 20)
        Me.ttgl2.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(205, 15)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(15, 13)
        Me.LabelControl2.TabIndex = 8
        Me.LabelControl2.Text = "s.d"
        '
        'ttgl
        '
        Me.ttgl.EditValue = Nothing
        Me.ttgl.Location = New System.Drawing.Point(86, 12)
        Me.ttgl.Name = "ttgl"
        Me.ttgl.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ttgl.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ttgl.Properties.Mask.EditMask = ""
        Me.ttgl.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.ttgl.Size = New System.Drawing.Size(113, 20)
        Me.ttgl.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(40, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "Tgl Beli :"
        '
        'tnopol
        '
        Me.tnopol.Location = New System.Drawing.Point(86, 38)
        Me.tnopol.Name = "tnopol"
        Me.tnopol.Size = New System.Drawing.Size(254, 20)
        Me.tnopol.TabIndex = 2
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(46, 41)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl6.TabIndex = 206
        Me.LabelControl6.Text = "Nopol :"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(22, 67)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl4.TabIndex = 208
        Me.LabelControl4.Text = "Jenis Kend :"
        '
        'tjenis_kend
        '
        Me.tjenis_kend.Location = New System.Drawing.Point(86, 64)
        Me.tjenis_kend.Name = "tjenis_kend"
        Me.tjenis_kend.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tjenis_kend.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tjenis_kend.Properties.Items.AddRange(New Object() {"ALL", "MOBIL EXPEDISI", "MOBIL WTL", "LAIN-LAIN"})
        Me.tjenis_kend.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.tjenis_kend.Size = New System.Drawing.Size(254, 20)
        Me.tjenis_kend.TabIndex = 3
        '
        'btkeluar
        '
        Me.btkeluar.Location = New System.Drawing.Point(276, 126)
        Me.btkeluar.Name = "btkeluar"
        Me.btkeluar.Size = New System.Drawing.Size(64, 27)
        Me.btkeluar.TabIndex = 5
        Me.btkeluar.Text = "&Keluar"
        '
        'btload
        '
        Me.btload.Location = New System.Drawing.Point(206, 126)
        Me.btload.Name = "btload"
        Me.btload.Size = New System.Drawing.Size(64, 27)
        Me.btload.TabIndex = 4
        Me.btload.Text = "&Load"
        '
        'fpr_jmlperbaikan_perkend
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 167)
        Me.Controls.Add(Me.btkeluar)
        Me.Controls.Add(Me.btload)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.tjenis_kend)
        Me.Controls.Add(Me.tnopol)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.ttgl2)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.ttgl)
        Me.Controls.Add(Me.LabelControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fpr_jmlperbaikan_perkend"
        Me.Text = "Jml Perbaikan Per-Kendaraan"
        CType(Me.ttgl2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ttgl2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ttgl.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ttgl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tnopol.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tjenis_kend.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ttgl2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ttgl As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tnopol As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tjenis_kend As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btkeluar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btload As DevExpress.XtraEditors.SimpleButton
End Class
