<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Movement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Movement))
        Me.Forward = New System.Windows.Forms.Button()
        Me.Reverse = New System.Windows.Forms.Button()
        Me.Right = New System.Windows.Forms.Button()
        Me.Left = New System.Windows.Forms.Button()
        Me.Close = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Forward
        '
        Me.Forward.Location = New System.Drawing.Point(376, 98)
        Me.Forward.Name = "Forward"
        Me.Forward.Size = New System.Drawing.Size(96, 82)
        Me.Forward.TabIndex = 0
        Me.Forward.Text = "Forward"
        Me.Forward.UseVisualStyleBackColor = True
        '
        'Reverse
        '
        Me.Reverse.Location = New System.Drawing.Point(376, 248)
        Me.Reverse.Name = "Reverse"
        Me.Reverse.Size = New System.Drawing.Size(96, 82)
        Me.Reverse.TabIndex = 1
        Me.Reverse.Text = "Reverse"
        Me.Reverse.UseVisualStyleBackColor = True
        '
        'Right
        '
        Me.Right.Location = New System.Drawing.Point(508, 172)
        Me.Right.Name = "Right"
        Me.Right.Size = New System.Drawing.Size(96, 82)
        Me.Right.TabIndex = 2
        Me.Right.Text = "Right"
        Me.Right.UseVisualStyleBackColor = True
        '
        'Left
        '
        Me.Left.Location = New System.Drawing.Point(245, 172)
        Me.Left.Name = "Left"
        Me.Left.Size = New System.Drawing.Size(96, 82)
        Me.Left.TabIndex = 3
        Me.Left.Text = "Left"
        Me.Left.UseVisualStyleBackColor = True
        '
        'Close
        '
        Me.Close.Location = New System.Drawing.Point(648, 338)
        Me.Close.Name = "Close"
        Me.Close.Size = New System.Drawing.Size(96, 82)
        Me.Close.TabIndex = 5
        Me.Close.Text = "Close"
        Me.Close.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Movement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(859, 565)
        Me.Controls.Add(Me.Close)
        Me.Controls.Add(Me.Left)
        Me.Controls.Add(Me.Right)
        Me.Controls.Add(Me.Reverse)
        Me.Controls.Add(Me.Forward)
        Me.Name = "Movement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movement"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Forward As Button
    Friend WithEvents Reverse As Button
    Friend WithEvents Right As Button
    Friend WithEvents Left As Button
    Friend WithEvents Close As Button
    Friend WithEvents Timer1 As Timer
End Class
