<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Entertainment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Entertainment))
        Me.Ent_TV = New System.Windows.Forms.Button()
        Me.Ent_Radio = New System.Windows.Forms.Button()
        Me.Ent_Games = New System.Windows.Forms.Button()
        Me.Close = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Ent_TV
        '
        Me.Ent_TV.Location = New System.Drawing.Point(249, 135)
        Me.Ent_TV.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Ent_TV.Name = "Ent_TV"
        Me.Ent_TV.Size = New System.Drawing.Size(86, 100)
        Me.Ent_TV.TabIndex = 0
        Me.Ent_TV.Text = "TV"
        Me.Ent_TV.UseVisualStyleBackColor = True
        '
        'Ent_Radio
        '
        Me.Ent_Radio.Location = New System.Drawing.Point(447, 135)
        Me.Ent_Radio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Ent_Radio.Name = "Ent_Radio"
        Me.Ent_Radio.Size = New System.Drawing.Size(86, 100)
        Me.Ent_Radio.TabIndex = 1
        Me.Ent_Radio.Text = "Radio"
        Me.Ent_Radio.UseVisualStyleBackColor = True
        '
        'Ent_Games
        '
        Me.Ent_Games.Enabled = False
        Me.Ent_Games.Location = New System.Drawing.Point(638, 135)
        Me.Ent_Games.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Ent_Games.Name = "Ent_Games"
        Me.Ent_Games.Size = New System.Drawing.Size(86, 100)
        Me.Ent_Games.TabIndex = 2
        Me.Ent_Games.Text = "Games"
        Me.Ent_Games.UseVisualStyleBackColor = True
        '
        'Close
        '
        Me.Close.Location = New System.Drawing.Point(749, 449)
        Me.Close.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Close.Name = "Close"
        Me.Close.Size = New System.Drawing.Size(110, 110)
        Me.Close.TabIndex = 4
        Me.Close.Text = "Close"
        Me.Close.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Entertainment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(982, 753)
        Me.Controls.Add(Me.Close)
        Me.Controls.Add(Me.Ent_Games)
        Me.Controls.Add(Me.Ent_Radio)
        Me.Controls.Add(Me.Ent_TV)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Entertainment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entertainment"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Ent_TV As Button
    Friend WithEvents Ent_Radio As Button
    Friend WithEvents Ent_Games As Button
    Friend WithEvents Close As Button
    Friend WithEvents Timer1 As Timer
End Class
