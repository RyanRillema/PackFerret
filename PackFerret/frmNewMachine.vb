Public Class frmNewMachine
    Private oPackFerret As PackFerret

    Public Sub New(oSetPackFerret As PackFerret)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        oPackFerret = oSetPackFerret

    End Sub

    Private Sub frmNewMachine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set consent message
        lbConsentMessage.Text = "It appears this is the first time using Pack Ferret on this machine. Base parameters will be stored in your registry. Additional parameters can be defined in the registry or in a flat file." & vbCrLf & vbCrLf & " Please confirm if you are happy to create a registry entry."
    End Sub

    Private Sub cmdNo_Click(sender As Object, e As EventArgs) Handles cmdNo.Click
        oPackFerret.frmPackFerret.CloseAndExit()
    End Sub

    Private Sub cmdYes_Click(sender As Object, e As EventArgs) Handles cmdYes.Click

        'Create reg entry
        My.Computer.Registry.CurrentUser.CreateSubKey("SOFTWARE\PackFerret")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\PackFerret", "InUse", "TRUE")

        'Reset NewMachine flag
        oPackFerret.frmPackFerret.bNewMachine = False
        oPackFerret.frmPackFerret.EnableForm()

        'Show the parameter form for initial setup
        oPackFerret.frmParams.ShowForm()
        Me.Close()

    End Sub
End Class