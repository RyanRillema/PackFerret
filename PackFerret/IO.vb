Imports System.IO

Public Class IO

    Public oPackFerret As PackFerret
    Public oFileWriter As StreamWriter
    Public oFileReader As StreamReader

    Public Sub New(oSetPackFerret As PackFerret)
        oPackFerret = oSetPackFerret
    End Sub

    Public Function LoadParamsFromPath(sPath As String) As Boolean
        Dim sReadLine As String
        Dim sParamPath As String

        'Open stream reader
        If Dir(sPath & "\Params.txt") = "" Then
            Return False
        End If

        oFileReader = New StreamReader(sPath & "\Params.txt")

        sReadLine = oFileReader.ReadLine()

        sParamPath = sReadLine.Substring(sReadLine.IndexOf("#P") + 2)

        oPackFerret.oParams.sPath = sParamPath

        oFileReader.Close()

        Return True

    End Function

    Public Function SavePacksToDisk()
        '#N - Name, #M - Identifier (My identifier), #D - Server (DNS Name), #L - Login, #P - Password, #S - Service
        Dim bReturn As Boolean
        Dim iLoop As Integer
        Dim sWriteLine As String

        'Open the stream writer
        oFileWriter = New StreamWriter(oPackFerret.oFerretConst.sSavePath & "\Packs.txt")

        'Build a write string and write for each pack
        For iLoop = 0 To oPackFerret.oFerretConst.iTotalPacks
            If oPackFerret.PackDetails(iLoop).sName <> "" Then

                sWriteLine = RTrim("#N" & oPackFerret.PackDetails(iLoop).sName)
                sWriteLine = sWriteLine & RTrim(" #M" & oPackFerret.PackDetails(iLoop).sIdentifier)
                sWriteLine = sWriteLine & RTrim(" #D" & oPackFerret.PackDetails(iLoop).sIP)
                sWriteLine = sWriteLine & RTrim(" #L" & oPackFerret.PackDetails(iLoop).sLogin)
                sWriteLine = sWriteLine & RTrim(" #P" & oPackFerret.PackDetails(iLoop).sPass)
                sWriteLine = sWriteLine & RTrim(" #S" & oPackFerret.PackDetails(iLoop).sService)

                oFileWriter.WriteLine(sWriteLine)

            End If
        Next

        oFileWriter.Close()

        Return bReturn
    End Function

    Public Function ReadPacksFromDisk() As Boolean
        Dim bReturn As Boolean
        Dim iLoop As Integer
        Dim iReadPackCount As Integer
        Dim sReadLine As String
        Dim sName As String
        Dim sIdentifier As String
        Dim sIP As String
        Dim sLogin As String
        Dim sPass As String
        Dim sService As String

        'Open stream reader
        'If Dir(oPackFerret.oFerretConst.sSavePath & "\Packs.txt") = "" Then
        If Dir(oPackFerret.oParams.sPath & "\Packs.txt") = "" Then
            Return False
        End If

        oFileReader = New StreamReader(oPackFerret.oParams.sPath & "\Packs.txt")

        'Build a read string and read for each pack
        For iLoop = 1 To oPackFerret.oFerretConst.iTotalPacks

            sReadLine = oFileReader.ReadLine()

            If sReadLine <> "" Then

                sName = sReadLine.Substring(sReadLine.IndexOf("#N") + 2, sReadLine.IndexOf("#M") - sReadLine.IndexOf("#N") - 2)
                sIdentifier = sReadLine.Substring(sReadLine.IndexOf("#M") + 2, sReadLine.IndexOf("#D") - sReadLine.IndexOf("#M") - 2)
                sIP = sReadLine.Substring(sReadLine.IndexOf("#D") + 2, sReadLine.IndexOf("#L") - sReadLine.IndexOf("#D") - 2)
                sLogin = sReadLine.Substring(sReadLine.IndexOf("#L") + 2, sReadLine.IndexOf("#P") - sReadLine.IndexOf("#L") - 2)
                sPass = sReadLine.Substring(sReadLine.IndexOf("#P") + 2, sReadLine.IndexOf("#S") - sReadLine.IndexOf("#P") - 2)
                sService = sReadLine.Substring(sReadLine.IndexOf("#S") + 2)

                'Set the pack details
                oPackFerret.PackDetails(iReadPackCount).Setup(sName, sIdentifier, sIP, sLogin, sPass, sService)
                iReadPackCount = iReadPackCount + 1

            End If
        Next

        oFileReader.Close()

        Return bReturn
    End Function

End Class
