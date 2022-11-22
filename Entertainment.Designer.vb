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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Entertainment))
        Me.Ent_TV = New System.Windows.Forms.Button()
        Me.Ent_Radio = New System.Windows.Forms.Button()
        Me.Ent_Games = New System.Windows.Forms.Button()
        Me.Ent_Back = New System.Windows.Forms.Button()
        Me.Ent_Home = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Ent_TV
        '
        Me.Ent_TV.Location = New System.Drawing.Point(263, 281)
        Me.Ent_TV.Name = "Ent_TV"
        Me.Ent_TV.Size = New System.Drawing.Size(75, 75)
        Me.Ent_TV.TabIndex = 0
        Me.Ent_TV.Text = "TV"
        Me.Ent_TV.UseVisualStyleBackColor = True
        '
        'Ent_Radio
        '
        Me.Ent_Radio.Location = New System.Drawing.Point(437, 281)
        Me.Ent_Radio.Name = "Ent_Radio"
        Me.Ent_Radio.Size = New System.Drawing.Size(75, 75)
        Me.Ent_Radio.TabIndex = 1
        Me.Ent_Radio.Text = "Radio"
        Me.Ent_Radio.UseVisualStyleBackColor = True
        '
        'Ent_Games
        '
        Me.Ent_Games.Enabled = False
        Me.Ent_Games.Location = New System.Drawing.Point(621, 281)
        Me.Ent_Games.Name = "Ent_Games"
        Me.Ent_Games.Size = New System.Drawing.Size(75, 75)
        Me.Ent_Games.TabIndex = 2
        Me.Ent_Games.Text = "Games"
        Me.Ent_Games.UseVisualStyleBackColor = True
        '
        'Ent_Back
        '
        Me.Ent_Back.Location = New System.Drawing.Point(97, 500)
        Me.Ent_Back.Name = "Ent_Back"
        Me.Ent_Back.Size = New System.Drawing.Size(75, 75)
        Me.Ent_Back.TabIndex = 3
        Me.Ent_Back.Text = "Back"
        Me.Ent_Back.UseVisualStyleBackColor = True
        '
        'Ent_Home
        '
        Me.Ent_Home.Location = New System.Drawing.Point(798, 500)
        Me.Ent_Home.Name = "Ent_Home"
        Me.Ent_Home.Size = New System.Drawing.Size(75, 75)
        Me.Ent_Home.TabIndex = 4
        Me.Ent_Home.Text = "Home"
        Me.Ent_Home.UseVisualStyleBackColor = True
        '
        'Entertainment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(968, 671)
        Me.Controls.Add(Me.Ent_Home)
        Me.Controls.Add(Me.Ent_Back)
        Me.Controls.Add(Me.Ent_Games)
        Me.Controls.Add(Me.Ent_Radio)
        Me.Controls.Add(Me.Ent_TV)
        Me.Name = "Entertainment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entertainment"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Ent_TV As Button
    Friend WithEvents Ent_Radio As Button
    Friend WithEvents Ent_Games As Button
    Friend WithEvents Ent_Back As Button
    Friend WithEvents Ent_Home As Button
End Class
