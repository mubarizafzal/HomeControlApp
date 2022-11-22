<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Environment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Environment))
        Me.Env_Apartment = New System.Windows.Forms.RadioButton()
        Me.Env_Bedroom = New System.Windows.Forms.RadioButton()
        Me.Env_Living = New System.Windows.Forms.RadioButton()
        Me.Env_Kitchen = New System.Windows.Forms.RadioButton()
        Me.Env_Light_On = New System.Windows.Forms.Button()
        Me.Env_Lights_Off = New System.Windows.Forms.Button()
        Me.Env_Win_Open = New System.Windows.Forms.Button()
        Me.Env_Win_Close = New System.Windows.Forms.Button()
        Me.Env_Blinds_Open = New System.Windows.Forms.Button()
        Me.Env_Blinds_Close = New System.Windows.Forms.Button()
        Me.Env_Temp_Up = New System.Windows.Forms.Button()
        Me.Env_Temp_Down = New System.Windows.Forms.Button()
        Me.Env_Humid_Up = New System.Windows.Forms.Button()
        Me.Env_Humid_Down = New System.Windows.Forms.Button()
        Me.Env_Fan_On = New System.Windows.Forms.Button()
        Me.Env_Fan_Off = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Temperture_Display = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Close = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Env_Apartment
        '
        Me.Env_Apartment.AutoSize = True
        Me.Env_Apartment.Checked = True
        Me.Env_Apartment.Location = New System.Drawing.Point(158, 79)
        Me.Env_Apartment.Name = "Env_Apartment"
        Me.Env_Apartment.Size = New System.Drawing.Size(82, 19)
        Me.Env_Apartment.TabIndex = 0
        Me.Env_Apartment.TabStop = True
        Me.Env_Apartment.Text = "Apartment"
        Me.Env_Apartment.UseVisualStyleBackColor = True
        '
        'Env_Bedroom
        '
        Me.Env_Bedroom.AutoSize = True
        Me.Env_Bedroom.Location = New System.Drawing.Point(315, 79)
        Me.Env_Bedroom.Name = "Env_Bedroom"
        Me.Env_Bedroom.Size = New System.Drawing.Size(74, 19)
        Me.Env_Bedroom.TabIndex = 1
        Me.Env_Bedroom.TabStop = True
        Me.Env_Bedroom.Text = "Bedroom"
        Me.Env_Bedroom.UseVisualStyleBackColor = True
        '
        'Env_Living
        '
        Me.Env_Living.AutoSize = True
        Me.Env_Living.Location = New System.Drawing.Point(484, 79)
        Me.Env_Living.Name = "Env_Living"
        Me.Env_Living.Size = New System.Drawing.Size(57, 19)
        Me.Env_Living.TabIndex = 2
        Me.Env_Living.TabStop = True
        Me.Env_Living.Text = "Living"
        Me.Env_Living.UseVisualStyleBackColor = True
        '
        'Env_Kitchen
        '
        Me.Env_Kitchen.AutoSize = True
        Me.Env_Kitchen.Location = New System.Drawing.Point(619, 79)
        Me.Env_Kitchen.Name = "Env_Kitchen"
        Me.Env_Kitchen.Size = New System.Drawing.Size(65, 19)
        Me.Env_Kitchen.TabIndex = 3
        Me.Env_Kitchen.TabStop = True
        Me.Env_Kitchen.Text = "Kitchen"
        Me.Env_Kitchen.UseVisualStyleBackColor = True
        '
        'Env_Light_On
        '
        Me.Env_Light_On.Location = New System.Drawing.Point(92, 130)
        Me.Env_Light_On.Name = "Env_Light_On"
        Me.Env_Light_On.Size = New System.Drawing.Size(75, 75)
        Me.Env_Light_On.TabIndex = 4
        Me.Env_Light_On.Text = "Lights On"
        Me.Env_Light_On.UseVisualStyleBackColor = True
        '
        'Env_Lights_Off
        '
        Me.Env_Lights_Off.Location = New System.Drawing.Point(172, 130)
        Me.Env_Lights_Off.Name = "Env_Lights_Off"
        Me.Env_Lights_Off.Size = New System.Drawing.Size(75, 75)
        Me.Env_Lights_Off.TabIndex = 5
        Me.Env_Lights_Off.Text = "Lights Off"
        Me.Env_Lights_Off.UseVisualStyleBackColor = True
        '
        'Env_Win_Open
        '
        Me.Env_Win_Open.Location = New System.Drawing.Point(352, 130)
        Me.Env_Win_Open.Name = "Env_Win_Open"
        Me.Env_Win_Open.Size = New System.Drawing.Size(75, 75)
        Me.Env_Win_Open.TabIndex = 6
        Me.Env_Win_Open.Text = "Open Window"
        Me.Env_Win_Open.UseVisualStyleBackColor = True
        '
        'Env_Win_Close
        '
        Me.Env_Win_Close.Location = New System.Drawing.Point(432, 130)
        Me.Env_Win_Close.Name = "Env_Win_Close"
        Me.Env_Win_Close.Size = New System.Drawing.Size(75, 75)
        Me.Env_Win_Close.TabIndex = 7
        Me.Env_Win_Close.Text = "Close Window"
        Me.Env_Win_Close.UseVisualStyleBackColor = True
        '
        'Env_Blinds_Open
        '
        Me.Env_Blinds_Open.Location = New System.Drawing.Point(600, 130)
        Me.Env_Blinds_Open.Name = "Env_Blinds_Open"
        Me.Env_Blinds_Open.Size = New System.Drawing.Size(75, 75)
        Me.Env_Blinds_Open.TabIndex = 8
        Me.Env_Blinds_Open.Text = "Open Blinds"
        Me.Env_Blinds_Open.UseVisualStyleBackColor = True
        '
        'Env_Blinds_Close
        '
        Me.Env_Blinds_Close.Location = New System.Drawing.Point(681, 130)
        Me.Env_Blinds_Close.Name = "Env_Blinds_Close"
        Me.Env_Blinds_Close.Size = New System.Drawing.Size(75, 75)
        Me.Env_Blinds_Close.TabIndex = 9
        Me.Env_Blinds_Close.Text = "Close Blinds"
        Me.Env_Blinds_Close.UseVisualStyleBackColor = True
        '
        'Env_Temp_Up
        '
        Me.Env_Temp_Up.Location = New System.Drawing.Point(92, 250)
        Me.Env_Temp_Up.Name = "Env_Temp_Up"
        Me.Env_Temp_Up.Size = New System.Drawing.Size(75, 75)
        Me.Env_Temp_Up.TabIndex = 10
        Me.Env_Temp_Up.Text = "Increase"
        Me.Env_Temp_Up.UseVisualStyleBackColor = True
        '
        'Env_Temp_Down
        '
        Me.Env_Temp_Down.Location = New System.Drawing.Point(172, 250)
        Me.Env_Temp_Down.Name = "Env_Temp_Down"
        Me.Env_Temp_Down.Size = New System.Drawing.Size(75, 75)
        Me.Env_Temp_Down.TabIndex = 11
        Me.Env_Temp_Down.Text = "Decrease"
        Me.Env_Temp_Down.UseVisualStyleBackColor = True
        '
        'Env_Humid_Up
        '
        Me.Env_Humid_Up.Location = New System.Drawing.Point(352, 250)
        Me.Env_Humid_Up.Name = "Env_Humid_Up"
        Me.Env_Humid_Up.Size = New System.Drawing.Size(75, 75)
        Me.Env_Humid_Up.TabIndex = 12
        Me.Env_Humid_Up.Text = "Increase"
        Me.Env_Humid_Up.UseVisualStyleBackColor = True
        '
        'Env_Humid_Down
        '
        Me.Env_Humid_Down.Location = New System.Drawing.Point(432, 250)
        Me.Env_Humid_Down.Name = "Env_Humid_Down"
        Me.Env_Humid_Down.Size = New System.Drawing.Size(75, 75)
        Me.Env_Humid_Down.TabIndex = 13
        Me.Env_Humid_Down.Text = "Decrease"
        Me.Env_Humid_Down.UseVisualStyleBackColor = True
        '
        'Env_Fan_On
        '
        Me.Env_Fan_On.Location = New System.Drawing.Point(600, 250)
        Me.Env_Fan_On.Name = "Env_Fan_On"
        Me.Env_Fan_On.Size = New System.Drawing.Size(75, 75)
        Me.Env_Fan_On.TabIndex = 14
        Me.Env_Fan_On.Text = "Fan On"
        Me.Env_Fan_On.UseVisualStyleBackColor = True
        '
        'Env_Fan_Off
        '
        Me.Env_Fan_Off.Location = New System.Drawing.Point(681, 250)
        Me.Env_Fan_Off.Name = "Env_Fan_Off"
        Me.Env_Fan_Off.Size = New System.Drawing.Size(75, 75)
        Me.Env_Fan_Off.TabIndex = 15
        Me.Env_Fan_Off.Text = "Fan Off"
        Me.Env_Fan_Off.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(100, 222)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Temperture"
        '
        'Temperture_Display
        '
        Me.Temperture_Display.AutoSize = True
        Me.Temperture_Display.Location = New System.Drawing.Point(192, 222)
        Me.Temperture_Display.Name = "Temperture_Display"
        Me.Temperture_Display.Size = New System.Drawing.Size(19, 15)
        Me.Temperture_Display.TabIndex = 17
        Me.Temperture_Display.Text = "24"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(401, 222)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 15)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Humidity"
        '
        'Close
        '
        Me.Close.Location = New System.Drawing.Point(660, 343)
        Me.Close.Name = "Close"
        Me.Close.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Close.Size = New System.Drawing.Size(96, 82)
        Me.Close.TabIndex = 20
        Me.Close.Text = "Close"
        Me.Close.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Environment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(859, 565)
        Me.Controls.Add(Me.Close)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Temperture_Display)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Env_Fan_Off)
        Me.Controls.Add(Me.Env_Fan_On)
        Me.Controls.Add(Me.Env_Humid_Down)
        Me.Controls.Add(Me.Env_Humid_Up)
        Me.Controls.Add(Me.Env_Temp_Down)
        Me.Controls.Add(Me.Env_Temp_Up)
        Me.Controls.Add(Me.Env_Blinds_Close)
        Me.Controls.Add(Me.Env_Blinds_Open)
        Me.Controls.Add(Me.Env_Win_Close)
        Me.Controls.Add(Me.Env_Win_Open)
        Me.Controls.Add(Me.Env_Lights_Off)
        Me.Controls.Add(Me.Env_Light_On)
        Me.Controls.Add(Me.Env_Kitchen)
        Me.Controls.Add(Me.Env_Living)
        Me.Controls.Add(Me.Env_Bedroom)
        Me.Controls.Add(Me.Env_Apartment)
        Me.Name = "Environment"
        Me.Text = "Environment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Env_Apartment As RadioButton
    Friend WithEvents Env_Bedroom As RadioButton
    Friend WithEvents Env_Living As RadioButton
    Friend WithEvents Env_Kitchen As RadioButton
    Friend WithEvents Env_Light_On As Button
    Friend WithEvents Env_Lights_Off As Button
    Friend WithEvents Env_Win_Open As Button
    Friend WithEvents Env_Win_Close As Button
    Friend WithEvents Env_Blinds_Open As Button
    Friend WithEvents Env_Blinds_Close As Button
    Friend WithEvents Env_Temp_Up As Button
    Friend WithEvents Env_Temp_Down As Button
    Friend WithEvents Env_Humid_Up As Button
    Friend WithEvents Env_Humid_Down As Button
    Friend WithEvents Env_Fan_On As Button
    Friend WithEvents Env_Fan_Off As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Temperture_Display As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Close As Button

    Private selectionSequence(16) As ButtonBase
    Private ready As Boolean = False
    Private selectionIndex As Integer = 0
    Private redPen As New Pen(Color.FromArgb(255, 240, 0, 0), 4)

    Private Sub Environment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Env_Apartment.TabStop = False
        Me.Env_Bedroom.TabStop = False
        Me.Env_Kitchen.TabStop = False
        Me.Env_Living.TabStop = False
        Me.Env_Lights_Off.TabStop = False
        Me.Env_Light_On.TabStop = False
        Me.Env_Temp_Down.TabStop = False
        Me.Env_Temp_Up.TabStop = False
        Me.Env_Win_Close.TabStop = False
        Me.Env_Win_Open.TabStop = False
        Me.Env_Fan_Off.TabStop = False
        Me.Env_Fan_On.TabStop = False
        Me.Env_Blinds_Close.TabStop = False
        Me.Env_Blinds_Open.TabStop = False
        Me.Env_Humid_Down.TabStop = False
        Me.Env_Humid_Up.TabStop = False
        Me.Close.TabStop = False

        Me.selectionSequence(0) = Me.Env_Apartment
        Me.selectionSequence(1) = Me.Env_Bedroom
        Me.selectionSequence(2) = Me.Env_Living
        Me.selectionSequence(3) = Me.Env_Kitchen
        Me.selectionSequence(4) = Me.Env_Light_On
        Me.selectionSequence(5) = Me.Env_Lights_Off
        Me.selectionSequence(6) = Me.Env_Win_Open
        Me.selectionSequence(7) = Me.Env_Win_Close
        Me.selectionSequence(8) = Me.Env_Blinds_Open
        Me.selectionSequence(9) = Me.Env_Blinds_Close
        Me.selectionSequence(10) = Me.Env_Temp_Up
        Me.selectionSequence(11) = Me.Env_Temp_Down
        Me.selectionSequence(12) = Me.Env_Humid_Up
        Me.selectionSequence(13) = Me.Env_Humid_Down
        Me.selectionSequence(14) = Me.Env_Fan_On
        Me.selectionSequence(15) = Me.Env_Fan_Off
        Me.selectionSequence(16) = Me.Close

        Me.ready = True
        Me.Invalidate()
    End Sub

    Friend WithEvents Timer1 As Timer

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.selectionIndex = (selectionIndex + 1) Mod selectionSequence.Length
        Me.Invalidate()
    End Sub

    Private Sub Environment_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = " " Then
            Dim currentSelection As Object = selectionSequence(selectionIndex)
            ' Open the appropriate window based on the current selection
            Select Case currentSelection.Name
                Case Me.Close.Name
                    ActiveForm.Close()
                Case Me.Env_Apartment.Name
                    Env_Bedroom.Checked = False
                    Env_Kitchen.Checked = False
                    Env_Living.Checked = False
                    Env_Apartment.Checked = True
                Case Me.Env_Bedroom.Name
                    Env_Bedroom.Checked = True
                    Env_Kitchen.Checked = False
                    Env_Living.Checked = False
                    Env_Apartment.Checked = False
                Case Me.Env_Kitchen.Name
                    Env_Kitchen.Checked = True
                    Env_Living.Checked = False
                    Env_Bedroom.Checked = False
                    Env_Apartment.Checked = False
                Case Me.Env_Living.Name
                    Env_Living.Checked = True
                    Env_Bedroom.Checked = False
                    Env_Kitchen.Checked = False
                    Env_Apartment.Checked = False
                Case Me.Env_Light_On.Name
                    MsgBox("The lights are now on.")
                Case Me.Env_Lights_Off.Name
                    MsgBox("The lights are now off.")
                Case Me.Env_Win_Close.Name
                    MsgBox("The windows are noe closed.")
                Case Me.Env_Win_Open.Name
                    MsgBox("The windows are noe opened.")
                Case Me.Env_Blinds_Open.Name
                    MsgBox("The blinds are noe opened.")
                Case Me.Env_Blinds_Close.Name
                    MsgBox("The blinds are noe Closed.")
                Case Me.Env_Fan_On.Name
                    MsgBox("The fan is now On.")
                Case Me.Env_Fan_Off.Name
                    MsgBox("The fan is now off.")
                Case Me.Env_Humid_Up.Name
                    MsgBox("You increase the set humidity.")
                Case Me.Env_Humid_Down.Name
                    MsgBox("You decreased the set humidity.")
                Case Me.Env_Temp_Up.Name
                    Dim temp As Integer = Temperture_Display.Text
                    temp = temp + 1
                    Temperture_Display.Text = temp
                Case Me.Env_Temp_Down.Name
                    Dim temp As Integer = Temperture_Display.Text
                    temp = temp - 1
                    Temperture_Display.Text = temp
            End Select
        End If
    End Sub

    Private Sub Environment_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        If (ready) Then
            Dim x As Integer = Me.selectionSequence(selectionIndex).Location.X - 5
            Dim y As Integer = Me.selectionSequence(selectionIndex).Location.Y - 5
            Dim width = Me.selectionSequence(selectionIndex).Size.Width + 10
            Dim height = Me.selectionSequence(selectionIndex).Size.Height + 10
            e.Graphics.DrawRectangle(redPen, x, y, width, height)
        End If
    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Close.Click
        ActiveForm.Close()
    End Sub
End Class
