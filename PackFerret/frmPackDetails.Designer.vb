<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPackDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPackDetails))
        Me.tlpFull = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpButtons = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.tlpDetailsMain = New System.Windows.Forms.TableLayoutPanel()
        Me.tbPort = New System.Windows.Forms.TextBox()
        Me.lbPort = New System.Windows.Forms.Label()
        Me.tbService = New System.Windows.Forms.TextBox()
        Me.lbService = New System.Windows.Forms.Label()
        Me.tbPass = New System.Windows.Forms.TextBox()
        Me.lbPass = New System.Windows.Forms.Label()
        Me.tbLogin = New System.Windows.Forms.TextBox()
        Me.lbLogin = New System.Windows.Forms.Label()
        Me.lbServer = New System.Windows.Forms.Label()
        Me.tbIdentifier = New System.Windows.Forms.TextBox()
        Me.lbIdentifier = New System.Windows.Forms.Label()
        Me.lbName = New System.Windows.Forms.Label()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.tbServer = New System.Windows.Forms.TextBox()
        Me.tlpFull.SuspendLayout()
        Me.tlpButtons.SuspendLayout()
        Me.tlpDetailsMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpFull
        '
        Me.tlpFull.ColumnCount = 1
        Me.tlpFull.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpFull.Controls.Add(Me.tlpButtons, 0, 1)
        Me.tlpFull.Controls.Add(Me.tlpDetailsMain, 0, 0)
        Me.tlpFull.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpFull.Location = New System.Drawing.Point(0, 0)
        Me.tlpFull.Name = "tlpFull"
        Me.tlpFull.RowCount = 2
        Me.tlpFull.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpFull.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpFull.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpFull.Size = New System.Drawing.Size(280, 311)
        Me.tlpFull.TabIndex = 0
        '
        'tlpButtons
        '
        Me.tlpButtons.ColumnCount = 3
        Me.tlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpButtons.Controls.Add(Me.cmdCancel, 2, 0)
        Me.tlpButtons.Controls.Add(Me.cmdSave, 0, 0)
        Me.tlpButtons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpButtons.Location = New System.Drawing.Point(0, 281)
        Me.tlpButtons.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpButtons.Name = "tlpButtons"
        Me.tlpButtons.RowCount = 1
        Me.tlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpButtons.Size = New System.Drawing.Size(280, 30)
        Me.tlpButtons.TabIndex = 0
        '
        'cmdCancel
        '
        Me.cmdCancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdCancel.Location = New System.Drawing.Point(186, 0)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(94, 30)
        Me.cmdCancel.TabIndex = 0
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdSave.Location = New System.Drawing.Point(0, 0)
        Me.cmdSave.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(93, 30)
        Me.cmdSave.TabIndex = 1
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'tlpDetailsMain
        '
        Me.tlpDetailsMain.ColumnCount = 2
        Me.tlpDetailsMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpDetailsMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpDetailsMain.Controls.Add(Me.tbPort, 1, 6)
        Me.tlpDetailsMain.Controls.Add(Me.lbPort, 0, 6)
        Me.tlpDetailsMain.Controls.Add(Me.tbService, 1, 5)
        Me.tlpDetailsMain.Controls.Add(Me.lbService, 0, 5)
        Me.tlpDetailsMain.Controls.Add(Me.tbPass, 1, 4)
        Me.tlpDetailsMain.Controls.Add(Me.lbPass, 0, 4)
        Me.tlpDetailsMain.Controls.Add(Me.tbLogin, 1, 3)
        Me.tlpDetailsMain.Controls.Add(Me.lbLogin, 0, 3)
        Me.tlpDetailsMain.Controls.Add(Me.lbServer, 0, 2)
        Me.tlpDetailsMain.Controls.Add(Me.tbIdentifier, 1, 1)
        Me.tlpDetailsMain.Controls.Add(Me.lbIdentifier, 0, 1)
        Me.tlpDetailsMain.Controls.Add(Me.lbName, 0, 0)
        Me.tlpDetailsMain.Controls.Add(Me.tbName, 1, 0)
        Me.tlpDetailsMain.Controls.Add(Me.tbServer, 1, 2)
        Me.tlpDetailsMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpDetailsMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpDetailsMain.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpDetailsMain.Name = "tlpDetailsMain"
        Me.tlpDetailsMain.RowCount = 10
        Me.tlpDetailsMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpDetailsMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpDetailsMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpDetailsMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpDetailsMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpDetailsMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpDetailsMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpDetailsMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpDetailsMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpDetailsMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpDetailsMain.Size = New System.Drawing.Size(280, 281)
        Me.tlpDetailsMain.TabIndex = 1
        '
        'tbPort
        '
        Me.tbPort.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbPort.Location = New System.Drawing.Point(143, 171)
        Me.tbPort.Name = "tbPort"
        Me.tbPort.Size = New System.Drawing.Size(134, 20)
        Me.tbPort.TabIndex = 13
        '
        'lbPort
        '
        Me.lbPort.AutoSize = True
        Me.lbPort.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbPort.Location = New System.Drawing.Point(3, 171)
        Me.lbPort.Margin = New System.Windows.Forms.Padding(3)
        Me.lbPort.Name = "lbPort"
        Me.lbPort.Size = New System.Drawing.Size(134, 22)
        Me.lbPort.TabIndex = 12
        Me.lbPort.Text = "Port:"
        Me.lbPort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbService
        '
        Me.tbService.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbService.Location = New System.Drawing.Point(143, 143)
        Me.tbService.Name = "tbService"
        Me.tbService.Size = New System.Drawing.Size(134, 20)
        Me.tbService.TabIndex = 11
        '
        'lbService
        '
        Me.lbService.AutoSize = True
        Me.lbService.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbService.Location = New System.Drawing.Point(3, 143)
        Me.lbService.Margin = New System.Windows.Forms.Padding(3)
        Me.lbService.Name = "lbService"
        Me.lbService.Size = New System.Drawing.Size(134, 22)
        Me.lbService.TabIndex = 10
        Me.lbService.Text = "Service:"
        Me.lbService.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbPass
        '
        Me.tbPass.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbPass.Location = New System.Drawing.Point(143, 115)
        Me.tbPass.Name = "tbPass"
        Me.tbPass.Size = New System.Drawing.Size(134, 20)
        Me.tbPass.TabIndex = 9
        '
        'lbPass
        '
        Me.lbPass.AutoSize = True
        Me.lbPass.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbPass.Location = New System.Drawing.Point(3, 115)
        Me.lbPass.Margin = New System.Windows.Forms.Padding(3)
        Me.lbPass.Name = "lbPass"
        Me.lbPass.Size = New System.Drawing.Size(134, 22)
        Me.lbPass.TabIndex = 8
        Me.lbPass.Text = "Password:"
        Me.lbPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbLogin
        '
        Me.tbLogin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbLogin.Location = New System.Drawing.Point(143, 87)
        Me.tbLogin.Name = "tbLogin"
        Me.tbLogin.Size = New System.Drawing.Size(134, 20)
        Me.tbLogin.TabIndex = 7
        '
        'lbLogin
        '
        Me.lbLogin.AutoSize = True
        Me.lbLogin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbLogin.Location = New System.Drawing.Point(3, 87)
        Me.lbLogin.Margin = New System.Windows.Forms.Padding(3)
        Me.lbLogin.Name = "lbLogin"
        Me.lbLogin.Size = New System.Drawing.Size(134, 22)
        Me.lbLogin.TabIndex = 6
        Me.lbLogin.Text = "Log in:"
        Me.lbLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbServer
        '
        Me.lbServer.AutoSize = True
        Me.lbServer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbServer.Location = New System.Drawing.Point(3, 59)
        Me.lbServer.Margin = New System.Windows.Forms.Padding(3)
        Me.lbServer.Name = "lbServer"
        Me.lbServer.Size = New System.Drawing.Size(134, 22)
        Me.lbServer.TabIndex = 4
        Me.lbServer.Text = "Server:"
        Me.lbServer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbIdentifier
        '
        Me.tbIdentifier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbIdentifier.Location = New System.Drawing.Point(143, 31)
        Me.tbIdentifier.Name = "tbIdentifier"
        Me.tbIdentifier.Size = New System.Drawing.Size(134, 20)
        Me.tbIdentifier.TabIndex = 3
        '
        'lbIdentifier
        '
        Me.lbIdentifier.AutoSize = True
        Me.lbIdentifier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbIdentifier.Location = New System.Drawing.Point(3, 31)
        Me.lbIdentifier.Margin = New System.Windows.Forms.Padding(3)
        Me.lbIdentifier.Name = "lbIdentifier"
        Me.lbIdentifier.Size = New System.Drawing.Size(134, 22)
        Me.lbIdentifier.TabIndex = 2
        Me.lbIdentifier.Text = "Identifier:"
        Me.lbIdentifier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbName
        '
        Me.lbName.AutoSize = True
        Me.lbName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbName.Location = New System.Drawing.Point(3, 3)
        Me.lbName.Margin = New System.Windows.Forms.Padding(3)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(134, 22)
        Me.lbName.TabIndex = 0
        Me.lbName.Text = "Name:"
        Me.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbName
        '
        Me.tbName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbName.Location = New System.Drawing.Point(143, 3)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(134, 20)
        Me.tbName.TabIndex = 1
        '
        'tbServer
        '
        Me.tbServer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbServer.Location = New System.Drawing.Point(143, 59)
        Me.tbServer.Name = "tbServer"
        Me.tbServer.Size = New System.Drawing.Size(134, 20)
        Me.tbServer.TabIndex = 5
        '
        'frmPackDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(280, 311)
        Me.Controls.Add(Me.tlpFull)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPackDetails"
        Me.Text = "PackDetails"
        Me.tlpFull.ResumeLayout(False)
        Me.tlpButtons.ResumeLayout(False)
        Me.tlpDetailsMain.ResumeLayout(False)
        Me.tlpDetailsMain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpFull As TableLayoutPanel
    Friend WithEvents tlpButtons As TableLayoutPanel
    Friend WithEvents cmdCancel As Button
    Friend WithEvents cmdSave As Button
    Friend WithEvents tlpDetailsMain As TableLayoutPanel
    Friend WithEvents lbName As Label
    Friend WithEvents tbName As TextBox
    Friend WithEvents tbPort As TextBox
    Friend WithEvents lbPort As Label
    Friend WithEvents tbService As TextBox
    Friend WithEvents lbService As Label
    Friend WithEvents tbPass As TextBox
    Friend WithEvents lbPass As Label
    Friend WithEvents tbLogin As TextBox
    Friend WithEvents lbLogin As Label
    Friend WithEvents lbServer As Label
    Friend WithEvents tbIdentifier As TextBox
    Friend WithEvents lbIdentifier As Label
    Friend WithEvents tbServer As TextBox
End Class
