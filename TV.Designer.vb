<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TV
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TV))
        Me.Tv_On = New System.Windows.Forms.Button()
        Me.Tv_Off = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TV_Back = New System.Windows.Forms.Button()
        Me.TV_Home = New System.Windows.Forms.Button()
        Me.Channel_Up = New System.Windows.Forms.Button()
        Me.Channel_Down = New System.Windows.Forms.Button()
        Me.Tv_up = New System.Windows.Forms.Button()
        Me.Tv_down = New System.Windows.Forms.Button()
        Me.Tv_right = New System.Windows.Forms.Button()
        Me.Tv_left = New System.Windows.Forms.Button()
        Me.Tv_volume = New System.Windows.Forms.Label()
        Me.Tv_VolumeValue = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Tv_On
        '
        Me.Tv_On.Location = New System.Drawing.Point(158, 142)
        Me.Tv_On.Name = "Tv_On"
        Me.Tv_On.Size = New System.Drawing.Size(75, 75)
        Me.Tv_On.TabIndex = 0
        Me.Tv_On.Text = "On"
        Me.Tv_On.UseVisualStyleBackColor = True
        '
        'Tv_Off
        '
        Me.Tv_Off.Location = New System.Drawing.Point(239, 142)
        Me.Tv_Off.Name = "Tv_Off"
        Me.Tv_Off.Size = New System.Drawing.Size(75, 75)
        Me.Tv_Off.TabIndex = 1
        Me.Tv_Off.Text = "Off"
        Me.Tv_Off.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(624, 142)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 75)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Volume Up"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(624, 223)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 75)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Volume Down"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TV_Back
        '
        Me.TV_Back.Location = New System.Drawing.Point(97, 499)
        Me.TV_Back.Name = "TV_Back"
        Me.TV_Back.Size = New System.Drawing.Size(75, 75)
        Me.TV_Back.TabIndex = 4
        Me.TV_Back.Text = "Back"
        Me.TV_Back.UseVisualStyleBackColor = True
        '
        'TV_Home
        '
        Me.TV_Home.Location = New System.Drawing.Point(795, 499)
        Me.TV_Home.Name = "TV_Home"
        Me.TV_Home.Size = New System.Drawing.Size(75, 75)
        Me.TV_Home.TabIndex = 5
        Me.TV_Home.Text = "Home"
        Me.TV_Home.UseVisualStyleBackColor = True
        '
        'Channel_Up
        '
        Me.Channel_Up.Location = New System.Drawing.Point(158, 272)
        Me.Channel_Up.Name = "Channel_Up"
        Me.Channel_Up.Size = New System.Drawing.Size(75, 75)
        Me.Channel_Up.TabIndex = 6
        Me.Channel_Up.Text = "Channel Up"
        Me.Channel_Up.UseVisualStyleBackColor = True
        '
        'Channel_Down
        '
        Me.Channel_Down.Location = New System.Drawing.Point(239, 272)
        Me.Channel_Down.Name = "Channel_Down"
        Me.Channel_Down.Size = New System.Drawing.Size(75, 75)
        Me.Channel_Down.TabIndex = 7
        Me.Channel_Down.Text = "Channel Down"
        Me.Channel_Down.UseVisualStyleBackColor = True
        '
        'Tv_up
        '
        Me.Tv_up.Location = New System.Drawing.Point(449, 374)
        Me.Tv_up.Name = "Tv_up"
        Me.Tv_up.Size = New System.Drawing.Size(75, 23)
        Me.Tv_up.TabIndex = 8
        Me.Tv_up.Text = "Up"
        Me.Tv_up.UseVisualStyleBackColor = True
        '
        'Tv_down
        '
        Me.Tv_down.Location = New System.Drawing.Point(449, 499)
        Me.Tv_down.Name = "Tv_down"
        Me.Tv_down.Size = New System.Drawing.Size(75, 23)
        Me.Tv_down.TabIndex = 9
        Me.Tv_down.Text = "Down"
        Me.Tv_down.UseVisualStyleBackColor = True
        '
        'Tv_right
        '
        Me.Tv_right.Location = New System.Drawing.Point(551, 438)
        Me.Tv_right.Name = "Tv_right"
        Me.Tv_right.Size = New System.Drawing.Size(75, 23)
        Me.Tv_right.TabIndex = 10
        Me.Tv_right.Text = "Right"
        Me.Tv_right.UseVisualStyleBackColor = True
        '
        'Tv_left
        '
        Me.Tv_left.Location = New System.Drawing.Point(350, 438)
        Me.Tv_left.Name = "Tv_left"
        Me.Tv_left.Size = New System.Drawing.Size(75, 23)
        Me.Tv_left.TabIndex = 11
        Me.Tv_left.Text = "Left"
        Me.Tv_left.UseVisualStyleBackColor = True
        '
        'Tv_volume
        '
        Me.Tv_volume.AutoSize = True
        Me.Tv_volume.Location = New System.Drawing.Point(758, 172)
        Me.Tv_volume.Name = "Tv_volume"
        Me.Tv_volume.Size = New System.Drawing.Size(47, 15)
        Me.Tv_volume.TabIndex = 12
        Me.Tv_volume.Text = "Volume"
        '
        'Tv_VolumeValue
        '
        Me.Tv_VolumeValue.AutoSize = True
        Me.Tv_VolumeValue.Location = New System.Drawing.Point(768, 253)
        Me.Tv_VolumeValue.Name = "Tv_VolumeValue"
        Me.Tv_VolumeValue.Size = New System.Drawing.Size(19, 15)
        Me.Tv_VolumeValue.TabIndex = 13
        Me.Tv_VolumeValue.Text = "24"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(196, 374)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 75)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Select Show"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(968, 671)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Tv_VolumeValue)
        Me.Controls.Add(Me.Tv_volume)
        Me.Controls.Add(Me.Tv_left)
        Me.Controls.Add(Me.Tv_right)
        Me.Controls.Add(Me.Tv_down)
        Me.Controls.Add(Me.Tv_up)
        Me.Controls.Add(Me.Channel_Down)
        Me.Controls.Add(Me.Channel_Up)
        Me.Controls.Add(Me.TV_Home)
        Me.Controls.Add(Me.TV_Back)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Tv_Off)
        Me.Controls.Add(Me.Tv_On)
        Me.Name = "TV"
        Me.Text = "TV"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Tv_On As Button
    Friend WithEvents Tv_Off As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TV_Back As Button
    Friend WithEvents TV_Home As Button
    Friend WithEvents Channel_Up As Button
    Friend WithEvents Channel_Down As Button
    Friend WithEvents Tv_up As Button
    Friend WithEvents Tv_down As Button
    Friend WithEvents Tv_right As Button
    Friend WithEvents Tv_left As Button
    Friend WithEvents Tv_volume As Label
    Friend WithEvents Tv_VolumeValue As Label
    Friend WithEvents Button1 As Button
End Class
