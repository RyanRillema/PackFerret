<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParams
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmParams))
        Me.tlpAll = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpCenter = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpButtons = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.tlpParamMain = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpPathParam = New System.Windows.Forms.TableLayoutPanel()
        Me.lbPath = New System.Windows.Forms.Label()
        Me.lbParamLocal = New System.Windows.Forms.Label()
        Me.tlpStorageLocal = New System.Windows.Forms.TableLayoutPanel()
        Me.rbReg = New System.Windows.Forms.RadioButton()
        Me.rbPath = New System.Windows.Forms.RadioButton()
        Me.tbPath = New System.Windows.Forms.TextBox()
        Me.tlpAbout = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpAll.SuspendLayout()
        Me.tlpMain.SuspendLayout()
        Me.tlpCenter.SuspendLayout()
        Me.tlpButtons.SuspendLayout()
        Me.tlpParamMain.SuspendLayout()
        Me.tlpPathParam.SuspendLayout()
        Me.tlpStorageLocal.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpAll
        '
        Me.tlpAll.ColumnCount = 1
        Me.tlpAll.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpAll.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpAll.Controls.Add(Me.tlpMain, 0, 0)
        Me.tlpAll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpAll.Location = New System.Drawing.Point(0, 0)
        Me.tlpAll.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpAll.Name = "tlpAll"
        Me.tlpAll.RowCount = 1
        Me.tlpAll.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpAll.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpAll.Size = New System.Drawing.Size(800, 450)
        Me.tlpAll.TabIndex = 0
        '
        'tlpMain
        '
        Me.tlpMain.ColumnCount = 1
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.Controls.Add(Me.tlpCenter, 0, 0)
        Me.tlpMain.Controls.Add(Me.tlpAbout, 0, 1)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpMain.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 2
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpMain.Size = New System.Drawing.Size(800, 450)
        Me.tlpMain.TabIndex = 0
        '
        'tlpCenter
        '
        Me.tlpCenter.ColumnCount = 2
        Me.tlpCenter.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCenter.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpCenter.Controls.Add(Me.tlpButtons, 1, 0)
        Me.tlpCenter.Controls.Add(Me.tlpParamMain, 0, 0)
        Me.tlpCenter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpCenter.Location = New System.Drawing.Point(0, 0)
        Me.tlpCenter.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpCenter.Name = "tlpCenter"
        Me.tlpCenter.RowCount = 1
        Me.tlpCenter.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCenter.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 425.0!))
        Me.tlpCenter.Size = New System.Drawing.Size(800, 425)
        Me.tlpCenter.TabIndex = 0
        '
        'tlpButtons
        '
        Me.tlpButtons.ColumnCount = 1
        Me.tlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpButtons.Controls.Add(Me.cmdClose, 0, 9)
        Me.tlpButtons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpButtons.Location = New System.Drawing.Point(700, 0)
        Me.tlpButtons.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpButtons.Name = "tlpButtons"
        Me.tlpButtons.RowCount = 10
        Me.tlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpButtons.Size = New System.Drawing.Size(100, 425)
        Me.tlpButtons.TabIndex = 0
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(3, 381)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 0
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'tlpParamMain
        '
        Me.tlpParamMain.ColumnCount = 2
        Me.tlpParamMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpParamMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpParamMain.Controls.Add(Me.tlpPathParam, 1, 0)
        Me.tlpParamMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpParamMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpParamMain.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpParamMain.Name = "tlpParamMain"
        Me.tlpParamMain.RowCount = 2
        Me.tlpParamMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpParamMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpParamMain.Size = New System.Drawing.Size(700, 425)
        Me.tlpParamMain.TabIndex = 1
        '
        'tlpPathParam
        '
        Me.tlpPathParam.ColumnCount = 2
        Me.tlpPathParam.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.tlpPathParam.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpPathParam.Controls.Add(Me.lbPath, 0, 1)
        Me.tlpPathParam.Controls.Add(Me.lbParamLocal, 0, 0)
        Me.tlpPathParam.Controls.Add(Me.tlpStorageLocal, 1, 0)
        Me.tlpPathParam.Controls.Add(Me.tbPath, 1, 1)
        Me.tlpPathParam.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpPathParam.Location = New System.Drawing.Point(350, 0)
        Me.tlpPathParam.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpPathParam.Name = "tlpPathParam"
        Me.tlpPathParam.RowCount = 6
        Me.tlpPathParam.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlpPathParam.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlpPathParam.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlpPathParam.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlpPathParam.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlpPathParam.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlpPathParam.Size = New System.Drawing.Size(350, 212)
        Me.tlpPathParam.TabIndex = 0
        '
        'lbPath
        '
        Me.lbPath.AutoSize = True
        Me.lbPath.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbPath.Location = New System.Drawing.Point(3, 35)
        Me.lbPath.Name = "lbPath"
        Me.lbPath.Size = New System.Drawing.Size(84, 35)
        Me.lbPath.TabIndex = 2
        Me.lbPath.Text = "Path"
        Me.lbPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbParamLocal
        '
        Me.lbParamLocal.AutoSize = True
        Me.lbParamLocal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbParamLocal.Location = New System.Drawing.Point(3, 0)
        Me.lbParamLocal.Name = "lbParamLocal"
        Me.lbParamLocal.Size = New System.Drawing.Size(84, 35)
        Me.lbParamLocal.TabIndex = 0
        Me.lbParamLocal.Text = "Storage locale"
        Me.lbParamLocal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpStorageLocal
        '
        Me.tlpStorageLocal.ColumnCount = 2
        Me.tlpStorageLocal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpStorageLocal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpStorageLocal.Controls.Add(Me.rbReg, 1, 0)
        Me.tlpStorageLocal.Controls.Add(Me.rbPath, 0, 0)
        Me.tlpStorageLocal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpStorageLocal.Location = New System.Drawing.Point(90, 0)
        Me.tlpStorageLocal.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpStorageLocal.Name = "tlpStorageLocal"
        Me.tlpStorageLocal.RowCount = 1
        Me.tlpStorageLocal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpStorageLocal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpStorageLocal.Size = New System.Drawing.Size(260, 35)
        Me.tlpStorageLocal.TabIndex = 1
        '
        'rbReg
        '
        Me.rbReg.AutoSize = True
        Me.rbReg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rbReg.Location = New System.Drawing.Point(133, 3)
        Me.rbReg.Name = "rbReg"
        Me.rbReg.Size = New System.Drawing.Size(124, 29)
        Me.rbReg.TabIndex = 1
        Me.rbReg.Text = "Use Registry"
        Me.rbReg.UseVisualStyleBackColor = True
        '
        'rbPath
        '
        Me.rbPath.AutoSize = True
        Me.rbPath.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rbPath.Location = New System.Drawing.Point(3, 3)
        Me.rbPath.Name = "rbPath"
        Me.rbPath.Size = New System.Drawing.Size(124, 29)
        Me.rbPath.TabIndex = 0
        Me.rbPath.Text = "Use Path"
        Me.rbPath.UseVisualStyleBackColor = True
        '
        'tbPath
        '
        Me.tbPath.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbPath.Location = New System.Drawing.Point(90, 43)
        Me.tbPath.Margin = New System.Windows.Forms.Padding(0, 8, 0, 3)
        Me.tbPath.Name = "tbPath"
        Me.tbPath.Size = New System.Drawing.Size(260, 20)
        Me.tbPath.TabIndex = 3
        Me.tbPath.Text = "C:\PackFerret"
        '
        'tlpAbout
        '
        Me.tlpAbout.ColumnCount = 3
        Me.tlpAbout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpAbout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpAbout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpAbout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpAbout.Location = New System.Drawing.Point(0, 425)
        Me.tlpAbout.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpAbout.Name = "tlpAbout"
        Me.tlpAbout.RowCount = 1
        Me.tlpAbout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpAbout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpAbout.Size = New System.Drawing.Size(800, 25)
        Me.tlpAbout.TabIndex = 1
        '
        'frmParams
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tlpAll)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmParams"
        Me.Text = "Pack Ferret Parameters"
        Me.tlpAll.ResumeLayout(False)
        Me.tlpMain.ResumeLayout(False)
        Me.tlpCenter.ResumeLayout(False)
        Me.tlpButtons.ResumeLayout(False)
        Me.tlpParamMain.ResumeLayout(False)
        Me.tlpPathParam.ResumeLayout(False)
        Me.tlpPathParam.PerformLayout()
        Me.tlpStorageLocal.ResumeLayout(False)
        Me.tlpStorageLocal.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpAll As TableLayoutPanel
    Friend WithEvents tlpMain As TableLayoutPanel
    Friend WithEvents tlpCenter As TableLayoutPanel
    Friend WithEvents tlpButtons As TableLayoutPanel
    Friend WithEvents tlpParamMain As TableLayoutPanel
    Friend WithEvents tlpPathParam As TableLayoutPanel
    Friend WithEvents lbParamLocal As Label
    Friend WithEvents tlpStorageLocal As TableLayoutPanel
    Friend WithEvents rbReg As RadioButton
    Friend WithEvents rbPath As RadioButton
    Friend WithEvents tlpAbout As TableLayoutPanel
    Friend WithEvents cmdClose As Button
    Friend WithEvents lbPath As Label
    Friend WithEvents tbPath As TextBox
End Class
