<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PhoneCall
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PhoneCall))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Pick_Up = New System.Windows.Forms.Button()
        Me.Decline = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(400, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Incoming Call"
        '
        'Pick_Up
        '
        Me.Pick_Up.Location = New System.Drawing.Point(255, 237)
        Me.Pick_Up.Name = "Pick_Up"
        Me.Pick_Up.Size = New System.Drawing.Size(75, 75)
        Me.Pick_Up.TabIndex = 1
        Me.Pick_Up.Text = "Pick Up"
        Me.Pick_Up.UseVisualStyleBackColor = True
        '
        'Decline
        '
        Me.Decline.Location = New System.Drawing.Point(535, 237)
        Me.Decline.Name = "Decline"
        Me.Decline.Size = New System.Drawing.Size(75, 75)
        Me.Decline.TabIndex = 2
        Me.Decline.Text = "Decline"
        Me.Decline.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'PhoneCall
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(859, 565)
        Me.Controls.Add(Me.Decline)
        Me.Controls.Add(Me.Pick_Up)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "PhoneCall"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PhoneCall"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Pick_Up As Button
    Friend WithEvents Decline As Button
    Friend WithEvents Timer1 As Timer
End Class
