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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TV))
        Me.TV_On = New System.Windows.Forms.Button()
        Me.TV_Off = New System.Windows.Forms.Button()
        Me.TV_Vol_Up = New System.Windows.Forms.Button()
        Me.TV_Vol_Down = New System.Windows.Forms.Button()
        Me.Close = New System.Windows.Forms.Button()
        Me.Channel_Up = New System.Windows.Forms.Button()
        Me.Channel_Down = New System.Windows.Forms.Button()
        Me.TV_Up = New System.Windows.Forms.Button()
        Me.TV_Down = New System.Windows.Forms.Button()
        Me.TV_Right = New System.Windows.Forms.Button()
        Me.TV_Left = New System.Windows.Forms.Button()
        Me.Tv_volume = New System.Windows.Forms.Label()
        Me.Tv_VolumeValue = New System.Windows.Forms.Label()
        Me.TV_Select = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'TV_On
        '
        Me.TV_On.Location = New System.Drawing.Point(111, 99)
        Me.TV_On.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TV_On.Name = "TV_On"
        Me.TV_On.Size = New System.Drawing.Size(86, 100)
        Me.TV_On.TabIndex = 0
        Me.TV_On.Text = "On"
        Me.TV_On.UseVisualStyleBackColor = True
        '
        'TV_Off
        '
        Me.TV_Off.Location = New System.Drawing.Point(203, 99)
        Me.TV_Off.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TV_Off.Name = "TV_Off"
        Me.TV_Off.Size = New System.Drawing.Size(86, 100)
        Me.TV_Off.TabIndex = 1
        Me.TV_Off.Text = "Off"
        Me.TV_Off.UseVisualStyleBackColor = True
        '
        'TV_Vol_Up
        '
        Me.TV_Vol_Up.Location = New System.Drawing.Point(679, 158)
        Me.TV_Vol_Up.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TV_Vol_Up.Name = "TV_Vol_Up"
        Me.TV_Vol_Up.Size = New System.Drawing.Size(86, 100)
        Me.TV_Vol_Up.TabIndex = 2
        Me.TV_Vol_Up.Text = "Volume Up"
        Me.TV_Vol_Up.UseVisualStyleBackColor = True
        '
        'TV_Vol_Down
        '
        Me.TV_Vol_Down.Location = New System.Drawing.Point(771, 158)
        Me.TV_Vol_Down.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TV_Vol_Down.Name = "TV_Vol_Down"
        Me.TV_Vol_Down.Size = New System.Drawing.Size(86, 100)
        Me.TV_Vol_Down.TabIndex = 3
        Me.TV_Vol_Down.Text = "Volume Down"
        Me.TV_Vol_Down.UseVisualStyleBackColor = True
        '
        'Close
        '
        Me.Close.Location = New System.Drawing.Point(747, 451)
        Me.Close.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Close.Name = "Close"
        Me.Close.Size = New System.Drawing.Size(110, 110)
        Me.Close.TabIndex = 5
        Me.Close.Text = "Close"
        Me.Close.UseVisualStyleBackColor = True
        '
        'Channel_Up
        '
        Me.Channel_Up.Location = New System.Drawing.Point(111, 229)
        Me.Channel_Up.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Channel_Up.Name = "Channel_Up"
        Me.Channel_Up.Size = New System.Drawing.Size(86, 100)
        Me.Channel_Up.TabIndex = 6
        Me.Channel_Up.Text = "Channel Up"
        Me.Channel_Up.UseVisualStyleBackColor = True
        '
        'Channel_Down
        '
        Me.Channel_Down.Location = New System.Drawing.Point(203, 229)
        Me.Channel_Down.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Channel_Down.Name = "Channel_Down"
        Me.Channel_Down.Size = New System.Drawing.Size(86, 100)
        Me.Channel_Down.TabIndex = 7
        Me.Channel_Down.Text = "Channel Down"
        Me.Channel_Down.UseVisualStyleBackColor = True
        '
        'TV_Up
        '
        Me.TV_Up.Location = New System.Drawing.Point(446, 158)
        Me.TV_Up.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TV_Up.Name = "TV_Up"
        Me.TV_Up.Size = New System.Drawing.Size(86, 31)
        Me.TV_Up.TabIndex = 8
        Me.TV_Up.Text = "Up"
        Me.TV_Up.UseVisualStyleBackColor = True
        '
        'TV_Down
        '
        Me.TV_Down.Location = New System.Drawing.Point(446, 251)
        Me.TV_Down.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TV_Down.Name = "TV_Down"
        Me.TV_Down.Size = New System.Drawing.Size(86, 31)
        Me.TV_Down.TabIndex = 9
        Me.TV_Down.Text = "Down"
        Me.TV_Down.UseVisualStyleBackColor = True
        '
        'TV_Right
        '
        Me.TV_Right.Location = New System.Drawing.Point(535, 203)
        Me.TV_Right.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TV_Right.Name = "TV_Right"
        Me.TV_Right.Size = New System.Drawing.Size(86, 31)
        Me.TV_Right.TabIndex = 10
        Me.TV_Right.Text = "Right"
        Me.TV_Right.UseVisualStyleBackColor = True
        '
        'TV_Left
        '
        Me.TV_Left.Location = New System.Drawing.Point(357, 203)
        Me.TV_Left.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TV_Left.Name = "TV_Left"
        Me.TV_Left.Size = New System.Drawing.Size(86, 31)
        Me.TV_Left.TabIndex = 11
        Me.TV_Left.Text = "Left"
        Me.TV_Left.UseVisualStyleBackColor = True
        '
        'Tv_volume
        '
        Me.Tv_volume.AutoSize = True
        Me.Tv_volume.Location = New System.Drawing.Point(701, 111)
        Me.Tv_volume.Name = "Tv_volume"
        Me.Tv_volume.Size = New System.Drawing.Size(59, 20)
        Me.Tv_volume.TabIndex = 12
        Me.Tv_volume.Text = "Volume"
        '
        'Tv_VolumeValue
        '
        Me.Tv_VolumeValue.AutoSize = True
        Me.Tv_VolumeValue.Location = New System.Drawing.Point(790, 111)
        Me.Tv_VolumeValue.Name = "Tv_VolumeValue"
        Me.Tv_VolumeValue.Size = New System.Drawing.Size(25, 20)
        Me.Tv_VolumeValue.TabIndex = 13
        Me.Tv_VolumeValue.Text = "24"
        '
        'TV_Select
        '
        Me.TV_Select.Location = New System.Drawing.Point(156, 355)
        Me.TV_Select.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TV_Select.Name = "TV_Select"
        Me.TV_Select.Size = New System.Drawing.Size(86, 100)
        Me.TV_Select.TabIndex = 14
        Me.TV_Select.Text = "Select Show"
        Me.TV_Select.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'TV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(982, 753)
        Me.Controls.Add(Me.TV_Select)
        Me.Controls.Add(Me.Tv_VolumeValue)
        Me.Controls.Add(Me.Tv_volume)
        Me.Controls.Add(Me.TV_Left)
        Me.Controls.Add(Me.TV_Right)
        Me.Controls.Add(Me.TV_Down)
        Me.Controls.Add(Me.TV_Up)
        Me.Controls.Add(Me.Channel_Down)
        Me.Controls.Add(Me.Channel_Up)
        Me.Controls.Add(Me.Close)
        Me.Controls.Add(Me.TV_Vol_Down)
        Me.Controls.Add(Me.TV_Vol_Up)
        Me.Controls.Add(Me.TV_Off)
        Me.Controls.Add(Me.TV_On)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "TV"
        Me.Text = "TV"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TV_On As Button
    Friend WithEvents TV_Off As Button
    Friend WithEvents TV_Vol_Up As Button
    Friend WithEvents TV_Vol_Down As Button
    Friend WithEvents Close As Button
    Friend WithEvents Channel_Up As Button
    Friend WithEvents Channel_Down As Button
    Friend WithEvents TV_Up As Button
    Friend WithEvents TV_Down As Button
    Friend WithEvents TV_Right As Button
    Friend WithEvents TV_Left As Button
    Friend WithEvents Tv_volume As Label
    Friend WithEvents Tv_VolumeValue As Label
    Friend WithEvents TV_Select As Button
    Friend WithEvents Timer1 As Timer
End Class
