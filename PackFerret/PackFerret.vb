Public Class PackFerret

    Public frmPackFerret As frmPackFerret
    Public frmPackDetails As frmPackDetails
    Public frmParams As frmParams
    Public PackDetails(20) As PackDetails
    Public oParams As Params
    Public oFerretConst As FerretConst
    Public oIOObject As IO
    Public iCurrentPack As Integer = 1
    Public KClientHandler As KClientHandler

    Public Sub New(oSetFrmPackFerret As frmPackFerret)

        Dim iPackLoop As Integer

        oFerretConst = New FerretConst

        oIOObject = New IO(Me)

        frmPackFerret = oSetFrmPackFerret
        frmPackDetails = New frmPackDetails(Me)
        frmPackDetails.HideForm()
        oParams = New Params
        frmParams = New frmParams(Me)
        frmParams.HideForm()

        For iPackLoop = 0 To 20
            PackDetails(iPackLoop) = New PackDetails
        Next

        'Load Packs
        'CreateTestPacks()

        KClientHandler = New KClientHandler

    End Sub

    Public Sub CreateClient(sSetName As String, sSetIdentifier As String, sSetIp As String, sSetLogin As String, sSetPass As String, sSetService As String)

        PackDetails(iCurrentPack).Setup(sSetName, sSetIdentifier, sSetIp, sSetLogin, sSetPass, sSetService)

    End Sub

    Public Sub Run(iPack)
        Dim sExe As String

        sExe = PackDetails(iPack).CreateExe()

        Process.Start(sExe)

    End Sub

    Public Sub CreateTestPacks()

        PackDetails(1).sName = "Daisy"
        PackDetails(1).sIP = "gbhiss01"
        PackDetails(1).sLogin = "rrill"
        PackDetails(1).sPass = "myXbox360"
        PackDetails(1).sService = "DAISYCOMM"

        PackDetails(0).sName = "Test Pack"
        PackDetails(0).sIP = "gbhsk8-qa-vm0016"
        PackDetails(0).sLogin = "kcc"
        PackDetails(0).sPass = "kcc123"
        PackDetails(0).sService = "K8_B_11_BIN"

    End Sub

End Class
