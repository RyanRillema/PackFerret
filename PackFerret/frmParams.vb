Public Class frmParams
    Public oPackFerret As PackFerret
    Public bUseRegForAll As Boolean
    Public bUsePath As Boolean
    Public sPath As String

    Public Sub New(oSetPackFerret As PackFerret)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        oPackFerret = oSetPackFerret
        LoadParams()

    End Sub

    Public Sub HideForm()
        Me.Hide()
    End Sub

    Public Sub ShowForm()
        ValidateControls()
        Me.Show()
    End Sub

    Private Sub frmParams_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadParams()
    End Sub

    Private Sub LoadParams()

        'First load the path from the registry
        sPath = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\PackFerret", "RegPath", "FALSE")

        'Check if the rest of the params are in the reg or path
        If sPath <> "" Then
            'Load params from reg
            bUseRegForAll = True
            'Load params from reg
        Else
            'Load params from path 
            bUseRegForAll = False
            oPackFerret.oIOObject.LoadParamsFromPath("C:\PackFerret")

        End If

    End Sub

    Private Sub SaveParams()

        If bUseRegForAll Then

        Else

        End If

    End Sub

    Private Sub ValidateControls()
        If rbPath.Checked = False And rbReg.Checked = False Then
            cmdClose.Enabled = False
        Else
            cmdClose.Enabled = True
        End If
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.HideForm()
    End Sub

    Private Sub rbPath_CheckedChanged(sender As Object, e As EventArgs) Handles rbPath.CheckedChanged
        ValidateControls()
    End Sub

    Private Sub rbReg_CheckedChanged(sender As Object, e As EventArgs) Handles rbReg.CheckedChanged
        ValidateControls()
    End Sub

End Class