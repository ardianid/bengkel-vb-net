<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fkendaraan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fkendaraan))
        Me.RepositoryItemCheckEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.cnama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ckode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ctahun = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.csupir = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ctipe = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ckm = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grid1 = New DevExpress.XtraGrid.GridControl()
        Me.tsfind = New System.Windows.Forms.ToolStripButton()
        Me.tfind = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton9 = New System.Windows.Forms.ToolStripButton()
        Me.tcbofind = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsref = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsdel = New System.Windows.Forms.ToolStripButton()
        Me.tsedit = New System.Windows.Forms.ToolStripButton()
        Me.tsadd = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.bn1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.tsexp = New System.Windows.Forms.ToolStripSplitButton()
        Me.ExportToExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToTextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.raktif = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bn1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bn1.SuspendLayout()
        CType(Me.raktif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RepositoryItemCheckEdit3
        '
        Me.RepositoryItemCheckEdit3.AutoHeight = False
        Me.RepositoryItemCheckEdit3.DisplayValueChecked = "1"
        Me.RepositoryItemCheckEdit3.DisplayValueUnchecked = "0"
        Me.RepositoryItemCheckEdit3.Name = "RepositoryItemCheckEdit3"
        Me.RepositoryItemCheckEdit3.ValueChecked = 1
        Me.RepositoryItemCheckEdit3.ValueUnchecked = 0
        '
        'cnama
        '
        Me.cnama.Caption = "Jenis Kend"
        Me.cnama.FieldName = "jenis_kend"
        Me.cnama.Name = "cnama"
        Me.cnama.OptionsColumn.AllowEdit = False
        Me.cnama.Visible = True
        Me.cnama.VisibleIndex = 3
        Me.cnama.Width = 478
        '
        'ckode
        '
        Me.ckode.Caption = "No Polisi"
        Me.ckode.FieldName = "nopol"
        Me.ckode.Name = "ckode"
        Me.ckode.OptionsColumn.AllowEdit = False
        Me.ckode.Visible = True
        Me.ckode.VisibleIndex = 1
        Me.ckode.Width = 46
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.ckode, Me.cnama, Me.ctahun, Me.csupir, Me.ctipe, Me.ckm})
        Me.GridView1.GridControl = Me.grid1
        Me.GridView1.Name = "GridView1"
        '
        'ctahun
        '
        Me.ctahun.Caption = "Tahun Beli"
        Me.ctahun.FieldName = "tahun_beli"
        Me.ctahun.Name = "ctahun"
        Me.ctahun.OptionsColumn.AllowEdit = False
        Me.ctahun.Visible = True
        Me.ctahun.VisibleIndex = 2
        Me.ctahun.Width = 62
        '
        'csupir
        '
        Me.csupir.Caption = "Supir"
        Me.csupir.FieldName = "nama_supir"
        Me.csupir.Name = "csupir"
        Me.csupir.OptionsColumn.AllowEdit = False
        Me.csupir.Visible = True
        Me.csupir.VisibleIndex = 4
        Me.csupir.Width = 54
        '
        'ctipe
        '
        Me.ctipe.Caption = "Tipe Kend"
        Me.ctipe.FieldName = "tipe_kend"
        Me.ctipe.Name = "ctipe"
        Me.ctipe.OptionsColumn.AllowEdit = False
        Me.ctipe.Visible = True
        Me.ctipe.VisibleIndex = 5
        Me.ctipe.Width = 54
        '
        'ckm
        '
        Me.ckm.AppearanceCell.Options.UseTextOptions = True
        Me.ckm.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ckm.AppearanceHeader.Options.UseTextOptions = True
        Me.ckm.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ckm.Caption = "Perb Bnsin 1Ltr/..Km"
        Me.ckm.FieldName = "km"
        Me.ckm.Name = "ckm"
        Me.ckm.OptionsColumn.AllowEdit = False
        Me.ckm.Visible = True
        Me.ckm.VisibleIndex = 6
        Me.ckm.Width = 67
        '
        'grid1
        '
        Me.grid1.Cursor = System.Windows.Forms.Cursors.Default
        Me.grid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid1.Location = New System.Drawing.Point(0, 36)
        Me.grid1.MainView = Me.GridView1
        Me.grid1.Name = "grid1"
        Me.grid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit3, Me.raktif})
        Me.grid1.Size = New System.Drawing.Size(809, 296)
        Me.grid1.TabIndex = 136
        Me.grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'tsfind
        '
        Me.tsfind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsfind.Image = CType(resources.GetObject("tsfind.Image"), System.Drawing.Image)
        Me.tsfind.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsfind.Name = "tsfind"
        Me.tsfind.Size = New System.Drawing.Size(23, 33)
        Me.tsfind.Text = "&Cari"
        Me.tsfind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsfind.ToolTipText = "Proses pencarian"
        '
        'tfind
        '
        Me.tfind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tfind.Name = "tfind"
        Me.tfind.Size = New System.Drawing.Size(116, 36)
        Me.tfind.ToolTipText = "Data yang akan dicari"
        '
        'ToolStripButton9
        '
        Me.ToolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton9.Image = CType(resources.GetObject("ToolStripButton9.Image"), System.Drawing.Image)
        Me.ToolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton9.Name = "ToolStripButton9"
        Me.ToolStripButton9.Size = New System.Drawing.Size(23, 33)
        Me.ToolStripButton9.Text = "ToolStripButton1"
        Me.ToolStripButton9.ToolTipText = "-"
        '
        'tcbofind
        '
        Me.tcbofind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tcbofind.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.tcbofind.Items.AddRange(New Object() {"Nopol", "Jenis Kend"})
        Me.tcbofind.Name = "tcbofind"
        Me.tcbofind.Size = New System.Drawing.Size(125, 36)
        Me.tcbofind.ToolTipText = "Kriteria pencarian"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.ForeColor = System.Drawing.Color.Black
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(36, 33)
        Me.ToolStripLabel3.Text = "Cari  :"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 36)
        '
        'tsref
        '
        Me.tsref.AutoSize = False
        Me.tsref.ForeColor = System.Drawing.Color.Black
        Me.tsref.Image = CType(resources.GetObject("tsref.Image"), System.Drawing.Image)
        Me.tsref.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsref.Name = "tsref"
        Me.tsref.Size = New System.Drawing.Size(49, 33)
        Me.tsref.Text = "&Refresh"
        Me.tsref.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsref.ToolTipText = "Refresh Data"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 36)
        '
        'tsdel
        '
        Me.tsdel.AutoSize = False
        Me.tsdel.ForeColor = System.Drawing.Color.Black
        Me.tsdel.Image = CType(resources.GetObject("tsdel.Image"), System.Drawing.Image)
        Me.tsdel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsdel.Name = "tsdel"
        Me.tsdel.Size = New System.Drawing.Size(49, 33)
        Me.tsdel.Text = "&Hapus"
        Me.tsdel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsdel.ToolTipText = "Hapus data"
        '
        'tsedit
        '
        Me.tsedit.AutoSize = False
        Me.tsedit.ForeColor = System.Drawing.Color.Black
        Me.tsedit.Image = CType(resources.GetObject("tsedit.Image"), System.Drawing.Image)
        Me.tsedit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsedit.Name = "tsedit"
        Me.tsedit.Size = New System.Drawing.Size(49, 33)
        Me.tsedit.Text = "&Edit"
        Me.tsedit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsedit.ToolTipText = "Rubah data"
        '
        'tsadd
        '
        Me.tsadd.AutoSize = False
        Me.tsadd.ForeColor = System.Drawing.Color.Black
        Me.tsadd.Image = CType(resources.GetObject("tsadd.Image"), System.Drawing.Image)
        Me.tsadd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsadd.Name = "tsadd"
        Me.tsadd.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tsadd.Size = New System.Drawing.Size(49, 33)
        Me.tsadd.Text = "&Tambah"
        Me.tsadd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsadd.ToolTipText = "Tambah data"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 36)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 33)
        Me.ToolStripButton5.Tag = "True"
        Me.ToolStripButton5.Text = "Move last"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 33)
        Me.ToolStripButton4.Tag = "True"
        Me.ToolStripButton4.Text = "Move next"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 36)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.AccessibleName = "Position"
        Me.ToolStripTextBox1.AutoSize = False
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(58, 21)
        Me.ToolStripTextBox1.Text = "0"
        Me.ToolStripTextBox1.ToolTipText = "Current position"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 36)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 33)
        Me.ToolStripButton3.Tag = "True"
        Me.ToolStripButton3.Text = "Move previous"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 33)
        Me.ToolStripButton2.Tag = "True"
        Me.ToolStripButton2.Text = "Move first"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.ForeColor = System.Drawing.Color.Black
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(36, 33)
        Me.ToolStripLabel2.Text = "of {0}"
        Me.ToolStripLabel2.ToolTipText = "Total number of items"
        '
        'bn1
        '
        Me.bn1.AddNewItem = Nothing
        Me.bn1.CountItem = Me.ToolStripLabel2
        Me.bn1.DeleteItem = Nothing
        Me.bn1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bn1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.bn1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripSeparator2, Me.ToolStripTextBox1, Me.ToolStripLabel2, Me.ToolStripSeparator3, Me.ToolStripButton4, Me.ToolStripButton5, Me.ToolStripSeparator4, Me.tsadd, Me.tsedit, Me.tsdel, Me.ToolStripSeparator1, Me.tsref, Me.tsexp, Me.ToolStripSeparator5, Me.ToolStripLabel3, Me.tcbofind, Me.ToolStripButton9, Me.tfind, Me.tsfind})
        Me.bn1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.bn1.Location = New System.Drawing.Point(0, 0)
        Me.bn1.MoveFirstItem = Me.ToolStripButton2
        Me.bn1.MoveLastItem = Me.ToolStripButton5
        Me.bn1.MoveNextItem = Me.ToolStripButton4
        Me.bn1.MovePreviousItem = Me.ToolStripButton3
        Me.bn1.Name = "bn1"
        Me.bn1.PositionItem = Me.ToolStripTextBox1
        Me.bn1.Size = New System.Drawing.Size(809, 36)
        Me.bn1.TabIndex = 135
        Me.bn1.Text = "BindingNavigator1"
        '
        'tsexp
        '
        Me.tsexp.AutoSize = False
        Me.tsexp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportToExcelToolStripMenuItem, Me.ExportToTextToolStripMenuItem})
        Me.tsexp.ForeColor = System.Drawing.Color.Black
        Me.tsexp.Image = CType(resources.GetObject("tsexp.Image"), System.Drawing.Image)
        Me.tsexp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsexp.Name = "tsexp"
        Me.tsexp.Size = New System.Drawing.Size(49, 33)
        Me.tsexp.Text = "E&xport"
        Me.tsexp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsexp.ToolTipText = "Export data"
        '
        'ExportToExcelToolStripMenuItem
        '
        Me.ExportToExcelToolStripMenuItem.Name = "ExportToExcelToolStripMenuItem"
        Me.ExportToExcelToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.ExportToExcelToolStripMenuItem.Text = "Export To Excel"
        '
        'ExportToTextToolStripMenuItem
        '
        Me.ExportToTextToolStripMenuItem.Name = "ExportToTextToolStripMenuItem"
        Me.ExportToTextToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.ExportToTextToolStripMenuItem.Text = "Export To Text"
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "Akt ?"
        Me.GridColumn1.ColumnEdit = Me.raktif
        Me.GridColumn1.FieldName = "saktif"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 30
        '
        'raktif
        '
        Me.raktif.AutoHeight = False
        Me.raktif.DisplayValueChecked = "1"
        Me.raktif.DisplayValueUnchecked = "0"
        Me.raktif.Name = "raktif"
        Me.raktif.ValueChecked = 1
        Me.raktif.ValueUnchecked = 0
        '
        'fkendaraan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 332)
        Me.Controls.Add(Me.grid1)
        Me.Controls.Add(Me.bn1)
        Me.Name = "fkendaraan"
        Me.Text = "Kendaraan"
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bn1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bn1.ResumeLayout(False)
        Me.bn1.PerformLayout()
        CType(Me.raktif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RepositoryItemCheckEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents cnama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ckode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents tsfind As System.Windows.Forms.ToolStripButton
    Friend WithEvents tfind As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripButton9 As System.Windows.Forms.ToolStripButton
    Friend WithEvents tcbofind As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsref As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsdel As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsedit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsadd As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents bn1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents ctahun As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents csupir As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ctipe As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ckm As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tsexp As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents ExportToExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportToTextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents raktif As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
End Class
