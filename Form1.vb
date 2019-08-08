Imports MaterialSkin
Public Class Form1
    Dim SkinMan As MaterialSkinManager
    Dim canClose = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SkinMan = MaterialSkinManager.Instance
        SkinMan.AddFormToManage(Me)
        SkinMan.Theme = MaterialSkinManager.Themes.LIGHT
        SkinMan.ColorScheme = New ColorScheme(Primary.Red800, Primary.Red900, Primary.Red500, Accent.Red200, TextShade.WHITE)
        Label1.Text = serverCommunicate.privateIP()
    End Sub


    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = Not canClose
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
        If My.Computer.Keyboard.ShiftKeyDown Then
            If serverCommunicate.newOverideRequest() Then
                ' Authorised override request
                My.Application.OpenForms.Cast(Of Form)() _
              .Except({Me, mainRunner}) _
              .ToList() _
              .ForEach(Sub(form) form.Close())
                canClose = True
                mainRunner.webserverCheckTimer.Start()
                Close()
            End If
        End If
    End Sub

    Private Sub DisplayOverFullscreenAndUWA_Tick(sender As Object, e As EventArgs) Handles displayOverFullscreenAndUWA.Tick
        ' Beat full screen software obtaining control (i.e games)
        Activate()
        BringToFront()
    End Sub
End Class
