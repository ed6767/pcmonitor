<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits MaterialSkin.Controls.MaterialForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.dialogMessage = New MaterialSkin.Controls.MaterialLabel()
        Me.dialogAction = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.displayOverFullscreenAndUWA = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'dialogMessage
        '
        Me.dialogMessage.AutoSize = True
        Me.dialogMessage.Depth = 0
        Me.dialogMessage.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.dialogMessage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dialogMessage.Location = New System.Drawing.Point(12, 80)
        Me.dialogMessage.MouseState = MaterialSkin.MouseState.HOVER
        Me.dialogMessage.Name = "dialogMessage"
        Me.dialogMessage.Size = New System.Drawing.Size(176, 19)
        Me.dialogMessage.TabIndex = 0
        Me.dialogMessage.Text = "Dialog Message to Show"
        '
        'dialogAction
        '
        Me.dialogAction.AutoSize = True
        Me.dialogAction.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.dialogAction.Depth = 0
        Me.dialogAction.Icon = Nothing
        Me.dialogAction.Location = New System.Drawing.Point(535, 80)
        Me.dialogAction.MouseState = MaterialSkin.MouseState.HOVER
        Me.dialogAction.Name = "dialogAction"
        Me.dialogAction.Primary = True
        Me.dialogAction.Size = New System.Drawing.Size(70, 36)
        Me.dialogAction.TabIndex = 1
        Me.dialogAction.Text = "Action"
        Me.dialogAction.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 9)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "192.168.?.??"
        '
        'displayOverFullscreenAndUWA
        '
        Me.displayOverFullscreenAndUWA.Enabled = True
        Me.displayOverFullscreenAndUWA.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 140)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dialogAction)
        Me.Controls.Add(Me.dialogMessage)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(617, 140)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(617, 140)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "System Message"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dialogMessage As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents dialogAction As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents displayOverFullscreenAndUWA As Timer
End Class
