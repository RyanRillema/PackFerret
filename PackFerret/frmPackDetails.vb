Public Class frmPackDetails
    Private oPackFerret As PackFerret
    Private oThisPack As PackDetails
    Private iPack As Integer

    Public Sub New(oSetPackFerret As PackFerret)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        oPackFerret = oSetPackFerret

    End Sub

    Public Sub HideForm()
        Me.Hide()
    End Sub

    Public Sub ShowForm(iSetPack As Integer)
        cmdSave.Text = "Save"
        iPack = iSetPack
        PopulateDetails()
        Me.Show()
    End Sub

    Public Sub ShowFormDelete(iSetPack As Integer)
        cmdSave.Text = "Delete"
        iPack = iSetPack
        PopulateDetails()
        Me.Show()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        HideForm()
    End Sub

    Private Sub PopulateDetails()

        If iPack = -1 Then
            PopulateDetails_New()
            FindNextPackSpot()
        Else
            PopulateDetails_Edit()
        End If

    End Sub

    Private Sub PopulateDetails_Edit()

        oThisPack = oPackFerret.PackDetails(iPack)
        tbName.Text = oThisPack.sName
        tbIdentifier.Text = oThisPack.sIdentifier
        tbServer.Text = oThisPack.sIP
        tbLogin.Text = oThisPack.sLogin
        tbPass.Text = oThisPack.sPass
        tbService.Text = oThisPack.sService

    End Sub

    Private Sub PopulateDetails_New()

        oThisPack = New PackDetails
        tbName.Text = ""
        tbIdentifier.Text = ""
        tbServer.Text = ""
        tbLogin.Text = ""
        tbPass.Text = ""
        tbService.Text = ""

    End Sub

    Private Sub FindNextPackSpot()
        Dim iLoop As Integer

        For iLoop = 0 To oPackFerret.oFerretConst.iTotalPacks
            If oPackFerret.PackDetails(iLoop).sName = "" Then
                iPack = iLoop
                iLoop = oPackFerret.oFerretConst.iTotalPacks
            End If
        Next

    End Sub

    Private Sub PopulateThisPack()

        oThisPack.sName = tbName.Text
        oThisPack.sIdentifier = tbIdentifier.Text
        oThisPack.sIP = tbServer.Text
        oThisPack.sLogin = tbLogin.Text
        oThisPack.sPass = tbPass.Text
        oThisPack.sService = tbService.Text

    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim iLoop As Integer

        If cmdSave.Text = "Save" Then
            PopulateThisPack()
            oPackFerret.PackDetails(iPack) = oThisPack
        ElseIf cmdSave.Text = "Delete" Then
            For iLoop = iPack To oPackFerret.oFerretConst.iTotalPacks - 1
                oPackFerret.PackDetails(iLoop) = oPackFerret.PackDetails(iLoop + 1)
            Next iLoop
        End If

        oPackFerret.frmPackFerret.LoadPacks()

        HideForm()
    End Sub

End Class