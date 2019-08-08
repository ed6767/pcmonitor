Imports Newtonsoft.Json
Public Class serverCommunicate
    Public Shared mainDisplay As Screen
    Shared Function currentStatusfromServer() As Dictionary(Of String, String)
        ' Fetch config from webserver that will apply regardless if a client connects to the server
        Return JsonConvert.DeserializeObject(Of Dictionary(Of String, String))((New Net.WebClient).DownloadString("urltojson.json"))
    End Function

    Shared Function newOverideRequest() As Boolean
        Dim overridecode = (New Random(Guid.NewGuid().GetHashCode())).Next(1000, 10000)
        MsgBox("Override code: " & vbNewLine & overridecode & vbNewLine & vbNewLine & "Click OK when code has been entered")
        If currentStatusfromServer()("overrideCode") = overridecode Then
            MsgBox("Override Request Successful", MsgBoxStyle.Information)
            Return True
        Else
            MsgBox("Override Request Failed", MsgBoxStyle.Critical)
            Return False
        End If
    End Function
    Shared Function privateIP() As String
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim iphe As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(strHostName)

        Try
            For Each ipheal As System.Net.IPAddress In iphe.AddressList
                If ipheal.AddressFamily = System.Net.Sockets.AddressFamily.InterNetwork Then
                    Return ipheal.ToString()
                End If
            Next
        Catch ex As Exception
            Return "ER UNKNOWN IP" 'errored out
        End Try

        Return "PS UNKNOWN IP" 'passed to end
    End Function

    Shared Sub blackout()
        Dim scr As Screen
        For Each scr In Screen.AllScreens
            Dim frm As New blackout
            frm.StartPosition = FormStartPosition.Manual
            frm.Location = scr.Bounds.Location + New Point(100, 100)
            If scr.Primary Then mainDisplay = scr
            frm.Show()
        Next
    End Sub

    Shared Sub showAlert(ByVal dial As Form1)
        blackout()
        dial.StartPosition = FormStartPosition.Manual
        dial.Location = mainDisplay.Bounds.Location
        dial.ShowDialog()
    End Sub

    Shared Sub actionLogout(sender As Object, e As EventArgs)
        Process.Start("shutdown.exe", "/l /y")
        End
    End Sub
End Class

