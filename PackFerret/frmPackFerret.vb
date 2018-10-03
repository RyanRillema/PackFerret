Public Class frmPackFerret

    Public PackFerret As PackFerret
    Public frmNewMachine As frmNewMachine
    Public bNewMachine As Boolean

    Public Sub New()
        Dim bRegExists As Boolean

        ' This call is required by the designer.
        InitializeComponent()

        'Create classes
        PackFerret = New PackFerret(Me)

        'Check the reg
        bRegExists = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\PackFerret", "InUse", "FALSE")

        If Not bRegExists Then

            'Reg does not exist - Prompt the user
            frmNewMachine = New frmNewMachine(PackFerret)
            frmNewMachine.Show()
            DisableForm()
            bNewMachine = True

        Else

            EnableForm()
            bNewMachine = False

        End If

    End Sub

    Public Sub DisableForm()
        Me.Hide()
        Me.Enabled = False
        Me.Visible = False
    End Sub

    Public Sub EnableForm()
        Me.Show()
        Me.Enabled = True
        Me.Visible = True
    End Sub

    Public Sub LoadPacks()
        Dim iPackLoop As Integer

        'Çlear packs first
        lbPacks.Items.Clear()

        For iPackLoop = 0 To 20
            If PackFerret.PackDetails(iPackLoop).sName <> "" Then
                lbPacks.Items.Add(PackFerret.PackDetails(iPackLoop).sName)
            End If
        Next

    End Sub

    Public Sub CloseAndExit()
        Me.Close()
    End Sub

    Private Sub frmPackFerret_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove

        If bNewMachine Then
            frmNewMachine.BringToFront()
        End If

    End Sub

    Private Sub frmPackFerret_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Reg exists - Open normally
        PackFerret.oIOObject.ReadPacksFromDisk()
        LoadPacks()

        'Set version
        lbVerControl.Text = PackFerret.oFerretConst.getFormattedVersion

    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        PackFerret.frmPackDetails.ShowForm(-1)
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click

        'Save pack details
        PackFerret.oIOObject.SavePacksToDisk()
        CloseAndExit()

    End Sub

    Private Sub cmdRun_Click(sender As Object, e As EventArgs) Handles cmdRun.Click
        If lbPacks.SelectedIndex <> 0 Then
            PackFerret.Run(lbPacks.SelectedIndex)
        End If
    End Sub

    Private Sub lbpacks_DoubleClick(sender As Object, e As EventArgs) Handles lbPacks.DoubleClick
        If lbPacks.SelectedIndex <> 0 Then
            PackFerret.Run(lbPacks.SelectedIndex)
        End If
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        PackFerret.frmPackDetails.ShowForm(lbPacks.SelectedIndex)
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        PackFerret.frmPackDetails.ShowFormDelete(lbPacks.SelectedIndex)
    End Sub

    Private Sub cmdParams_Click(sender As Object, e As EventArgs) Handles cmdParams.Click
        PackFerret.frmParams.ShowForm()
    End Sub
End Class