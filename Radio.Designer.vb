<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Radio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Radio))
        Me.Radio_On = New System.Windows.Forms.Button()
        Me.Radio_Off = New System.Windows.Forms.Button()
        Me.Radio_Chan_Up = New System.Windows.Forms.Button()
        Me.Radio_Vol_Up = New System.Windows.Forms.Button()
        Me.Radio_Vol_Down = New System.Windows.Forms.Button()
        Me.Radio_Chan_Down = New System.Windows.Forms.Button()
        Me.Radio_Back = New System.Windows.Forms.Button()
        Me.Radio_Home = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Radio_Vol = New System.Windows.Forms.Label()
        Me.Radio_Chan = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Radio_On
        '
        Me.Radio_On.Location = New System.Drawing.Point(302, 191)
        Me.Radio_On.Name = "Radio_On"
        Me.Radio_On.Size = New System.Drawing.Size(75, 75)
        Me.Radio_On.TabIndex = 0
        Me.Radio_On.Text = "On"
        Me.Radio_On.UseVisualStyleBackColor = True
        '
        'Radio_Off
        '
        Me.Radio_Off.Location = New System.Drawing.Point(454, 191)
        Me.Radio_Off.Name = "Radio_Off"
        Me.Radio_Off.Size = New System.Drawing.Size(75, 75)
        Me.Radio_Off.TabIndex = 1
        Me.Radio_Off.Text = "Off"
        Me.Radio_Off.UseVisualStyleBackColor = True
        '
        'Radio_Chan_Up
        '
        Me.Radio_Chan_Up.Location = New System.Drawing.Point(607, 191)
        Me.Radio_Chan_Up.Name = "Radio_Chan_Up"
        Me.Radio_Chan_Up.Size = New System.Drawing.Size(75, 75)
        Me.Radio_Chan_Up.TabIndex = 2
        Me.Radio_Chan_Up.Text = "Channel Up "
        Me.Radio_Chan_Up.UseVisualStyleBackColor = True
        '
        'Radio_Vol_Up
        '
        Me.Radio_Vol_Up.Location = New System.Drawing.Point(302, 338)
        Me.Radio_Vol_Up.Name = "Radio_Vol_Up"
        Me.Radio_Vol_Up.Size = New System.Drawing.Size(75, 75)
        Me.Radio_Vol_Up.TabIndex = 3
        Me.Radio_Vol_Up.Text = "Volume Up "
        Me.Radio_Vol_Up.UseVisualStyleBackColor = True
        '
        'Radio_Vol_Down
        '
        Me.Radio_Vol_Down.Location = New System.Drawing.Point(454, 338)
        Me.Radio_Vol_Down.Name = "Radio_Vol_Down"
        Me.Radio_Vol_Down.Size = New System.Drawing.Size(75, 75)
        Me.Radio_Vol_Down.TabIndex = 4
        Me.Radio_Vol_Down.Text = "Volume Down"
        Me.Radio_Vol_Down.UseVisualStyleBackColor = True
        '
        'Radio_Chan_Down
        '
        Me.Radio_Chan_Down.Location = New System.Drawing.Point(607, 338)
        Me.Radio_Chan_Down.Name = "Radio_Chan_Down"
        Me.Radio_Chan_Down.Size = New System.Drawing.Size(75, 75)
        Me.Radio_Chan_Down.TabIndex = 5
        Me.Radio_Chan_Down.Text = "Channel Down"
        Me.Radio_Chan_Down.UseVisualStyleBackColor = True
        '
        'Radio_Back
        '
        Me.Radio_Back.Location = New System.Drawing.Point(96, 501)
        Me.Radio_Back.Name = "Radio_Back"
        Me.Radio_Back.Size = New System.Drawing.Size(75, 75)
        Me.Radio_Back.TabIndex = 6
        Me.Radio_Back.Text = "Back"
        Me.Radio_Back.UseVisualStyleBackColor = True
        '
        'Radio_Home
        '
        Me.Radio_Home.Location = New System.Drawing.Point(794, 501)
        Me.Radio_Home.Name = "Radio_Home"
        Me.Radio_Home.Size = New System.Drawing.Size(75, 75)
        Me.Radio_Home.TabIndex = 7
        Me.Radio_Home.Text = "Home"
        Me.Radio_Home.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(475, 481)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Current Channel: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(302, 481)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Volume:"
        '
        'Radio_Vol
        '
        Me.Radio_Vol.AutoSize = True
        Me.Radio_Vol.Location = New System.Drawing.Point(404, 481)
        Me.Radio_Vol.Name = "Radio_Vol"
        Me.Radio_Vol.Size = New System.Drawing.Size(19, 15)
        Me.Radio_Vol.TabIndex = 11
        Me.Radio_Vol.Text = "24"
        '
        'Radio_Chan
        '
        Me.Radio_Chan.AutoSize = True
        Me.Radio_Chan.Location = New System.Drawing.Point(623, 481)
        Me.Radio_Chan.Name = "Radio_Chan"
        Me.Radio_Chan.Size = New System.Drawing.Size(28, 15)
        Me.Radio_Chan.TabIndex = 12
        Me.Radio_Chan.Text = "98.1"
        '
        'Radio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(968, 671)
        Me.Controls.Add(Me.Radio_Chan)
        Me.Controls.Add(Me.Radio_Vol)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Radio_Home)
        Me.Controls.Add(Me.Radio_Back)
        Me.Controls.Add(Me.Radio_Chan_Down)
        Me.Controls.Add(Me.Radio_Vol_Down)
        Me.Controls.Add(Me.Radio_Vol_Up)
        Me.Controls.Add(Me.Radio_Chan_Up)
        Me.Controls.Add(Me.Radio_Off)
        Me.Controls.Add(Me.Radio_On)
        Me.Name = "Radio"
        Me.Text = "Radio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Radio_On As Button
    Friend WithEvents Radio_Off As Button
    Friend WithEvents Radio_Chan_Up As Button
    Friend WithEvents Radio_Vol_Up As Button
    Friend WithEvents Radio_Vol_Down As Button
    Friend WithEvents Radio_Chan_Down As Button
    Friend WithEvents Radio_Back As Button
    Friend WithEvents Radio_Home As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Radio_Vol As Label
    Friend WithEvents Radio_Chan As Label
End Class
