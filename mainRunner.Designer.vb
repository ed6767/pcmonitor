<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainRunner
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.webserverCheckTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'webserverCheckTimer
        '
        Me.webserverCheckTimer.Enabled = True
        Me.webserverCheckTimer.Interval = 15000
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'mainRunner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(254, 147)
        Me.Name = "mainRunner"
        Me.Text = "mainRunner"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents webserverCheckTimer As Timer
    Friend WithEvents Timer1 As Timer
End Class
