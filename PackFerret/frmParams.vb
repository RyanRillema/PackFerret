Public Class frmParams
    Public oPackFerret As PackFerret
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
        Me.Show()
    End Sub

    Private Sub frmParams_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadParams()
    End Sub

    Private Sub LoadParams()

        'First load the path from the registry

        'Check if the rest of the params are in the reg or path
        If 1 = 0 Then
            'Load params from reg
        Else
            'Load params from path
            oPackFerret.oIOObject.LoadParamsFromPath("C:\PackFerret")

        End If

    End Sub

    Private Sub SaveParams()

    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.HideForm()
    End Sub
End Class