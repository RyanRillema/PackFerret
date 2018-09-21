Public Class frmPackFerret

    Public PackFerret As PackFerret

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

    Private Sub frmPackFerret_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PackFerret = New PackFerret(Me)
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
        Me.Close()

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