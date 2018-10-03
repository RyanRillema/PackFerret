<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewMachine
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewMachine))
        Me.tlpFull = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpMessageMain = New System.Windows.Forms.TableLayoutPanel()
        Me.lbConsentMessage = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdYes = New System.Windows.Forms.Button()
        Me.cmdNo = New System.Windows.Forms.Button()
        Me.tlpFull.SuspendLayout()
        Me.tlpMessageMain.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpFull
        '
        Me.tlpFull.ColumnCount = 1
        Me.tlpFull.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpFull.Controls.Add(Me.tlpMessageMain, 0, 0)
        Me.tlpFull.Controls.Add(Me.TableLayoutPanel1, 0, 1)
        Me.tlpFull.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpFull.Location = New System.Drawing.Point(0, 0)
        Me.tlpFull.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpFull.Name = "tlpFull"
        Me.tlpFull.RowCount = 2
        Me.tlpFull.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpFull.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpFull.Size = New System.Drawing.Size(317, 191)
        Me.tlpFull.TabIndex = 0
        '
        'tlpMessageMain
        '
        Me.tlpMessageMain.ColumnCount = 1
        Me.tlpMessageMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMessageMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMessageMain.Controls.Add(Me.lbConsentMessage, 0, 0)
        Me.tlpMessageMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMessageMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpMessageMain.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpMessageMain.Name = "tlpMessageMain"
        Me.tlpMessageMain.RowCount = 1
        Me.tlpMessageMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMessageMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 166.0!))
        Me.tlpMessageMain.Size = New System.Drawing.Size(317, 166)
        Me.tlpMessageMain.TabIndex = 0
        '
        'lbConsentMessage
        '
        Me.lbConsentMessage.AutoSize = True
        Me.lbConsentMessage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbConsentMessage.Location = New System.Drawing.Point(3, 0)
        Me.lbConsentMessage.Name = "lbConsentMessage"
        Me.lbConsentMessage.Size = New System.Drawing.Size(311, 166)
        Me.lbConsentMessage.TabIndex = 0
        Me.lbConsentMessage.Text = "Consent message"
        Me.lbConsentMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.cmdYes, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdNo, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 166)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(317, 25)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'cmdYes
        '
        Me.cmdYes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdYes.Location = New System.Drawing.Point(158, 0)
        Me.cmdYes.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdYes.Name = "cmdYes"
        Me.cmdYes.Size = New System.Drawing.Size(159, 25)
        Me.cmdYes.TabIndex = 1
        Me.cmdYes.Text = "Yes, write to my registry"
        Me.cmdYes.UseVisualStyleBackColor = True
        '
        'cmdNo
        '
        Me.cmdNo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdNo.Location = New System.Drawing.Point(0, 0)
        Me.cmdNo.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdNo.Name = "cmdNo"
        Me.cmdNo.Size = New System.Drawing.Size(158, 25)
        Me.cmdNo.TabIndex = 0
        Me.cmdNo.Text = "No, dont write to my registry"
        Me.cmdNo.UseVisualStyleBackColor = True
        '
        'frmNewMachine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 191)
        Me.Controls.Add(Me.tlpFull)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmNewMachine"
        Me.Text = "New Machine"
        Me.tlpFull.ResumeLayout(False)
        Me.tlpMessageMain.ResumeLayout(False)
        Me.tlpMessageMain.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpFull As TableLayoutPanel
    Friend WithEvents tlpMessageMain As TableLayoutPanel
    Friend WithEvents lbConsentMessage As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents cmdYes As Button
    Friend WithEvents cmdNo As Button
End Class
