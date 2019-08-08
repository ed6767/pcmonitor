Public Class mainRunner
    Private Sub MainRunner_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        runningWSCheck()
    End Sub

    Public Sub runningWSCheck()
        'Check webserver while running, timer runs this every 60 seconds
        Dim p = serverCommunicate.currentStatusfromServer()
        If p("allowLogin") = False Then
            webserverCheckTimer.Stop()
            Dim alertDia As New Form1
            alertDia.dialogMessage.Text = "You aren't authorised to use the computer"
            alertDia.dialogAction.Text = "Log Out"
            AddHandler alertDia.dialogAction.Click, AddressOf serverCommunicate.actionLogout
            serverCommunicate.showAlert(alertDia)
        End If
    End Sub

    Private Sub WebserverCheckTimer_Tick(sender As Object, e As EventArgs) Handles webserverCheckTimer.Tick
        runningWSCheck()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Hide()
        Timer1.Stop()
    End Sub
End Class