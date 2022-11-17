<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Door
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Door_lock = New System.Windows.Forms.Button()
        Me.Door_Close = New System.Windows.Forms.Button()
        Me.Door_Unlock = New System.Windows.Forms.Button()
        Me.Door_Open = New System.Windows.Forms.Button()
        Me.Door_Back = New System.Windows.Forms.Button()
        Me.Door_Home = New System.Windows.Forms.Button()
        Me.Building_Door = New System.Windows.Forms.RadioButton()
        Me.Apartment_Door = New System.Windows.Forms.RadioButton()
        Me.Hallway_Door = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(123, 74)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 75)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Building Front Door"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(356, 74)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 75)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Apartment Door"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(581, 74)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 75)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Hallway Door"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Door_lock
        '
        Me.Door_lock.Location = New System.Drawing.Point(123, 285)
        Me.Door_lock.Name = "Door_lock"
        Me.Door_lock.Size = New System.Drawing.Size(75, 75)
        Me.Door_lock.TabIndex = 3
        Me.Door_lock.Text = "Lock"
        Me.Door_lock.UseVisualStyleBackColor = True
        '
        'Door_Close
        '
        Me.Door_Close.Location = New System.Drawing.Point(581, 285)
        Me.Door_Close.Name = "Door_Close"
        Me.Door_Close.Size = New System.Drawing.Size(75, 75)
        Me.Door_Close.TabIndex = 4
        Me.Door_Close.Text = "Close"
        Me.Door_Close.UseVisualStyleBackColor = True
        '
        'Door_Unlock
        '
        Me.Door_Unlock.Location = New System.Drawing.Point(283, 285)
        Me.Door_Unlock.Name = "Door_Unlock"
        Me.Door_Unlock.Size = New System.Drawing.Size(75, 75)
        Me.Door_Unlock.TabIndex = 5
        Me.Door_Unlock.Text = "Unlock"
        Me.Door_Unlock.UseVisualStyleBackColor = True
        '
        'Door_Open
        '
        Me.Door_Open.Location = New System.Drawing.Point(437, 285)
        Me.Door_Open.Name = "Door_Open"
        Me.Door_Open.Size = New System.Drawing.Size(75, 75)
        Me.Door_Open.TabIndex = 6
        Me.Door_Open.Text = "Open"
        Me.Door_Open.UseVisualStyleBackColor = True
        '
        'Door_Back
        '
        Me.Door_Back.Location = New System.Drawing.Point(12, 363)
        Me.Door_Back.Name = "Door_Back"
        Me.Door_Back.Size = New System.Drawing.Size(75, 75)
        Me.Door_Back.TabIndex = 7
        Me.Door_Back.Text = "Back"
        Me.Door_Back.UseVisualStyleBackColor = True
        '
        'Door_Home
        '
        Me.Door_Home.Location = New System.Drawing.Point(713, 363)
        Me.Door_Home.Name = "Door_Home"
        Me.Door_Home.Size = New System.Drawing.Size(75, 75)
        Me.Door_Home.TabIndex = 8
        Me.Door_Home.Text = "Home"
        Me.Door_Home.UseVisualStyleBackColor = True
        '
        'Building_Door
        '
        Me.Building_Door.AutoSize = True
        Me.Building_Door.Location = New System.Drawing.Point(113, 197)
        Me.Building_Door.Name = "Building_Door"
        Me.Building_Door.Size = New System.Drawing.Size(129, 19)
        Me.Building_Door.TabIndex = 9
        Me.Building_Door.Text = "Building Front Door"
        Me.Building_Door.UseVisualStyleBackColor = True
        '
        'Apartment_Door
        '
        Me.Apartment_Door.AutoSize = True
        Me.Apartment_Door.Location = New System.Drawing.Point(334, 197)
        Me.Apartment_Door.Name = "Apartment_Door"
        Me.Apartment_Door.Size = New System.Drawing.Size(111, 19)
        Me.Apartment_Door.TabIndex = 10
        Me.Apartment_Door.Text = "Apartment Door"
        Me.Apartment_Door.UseVisualStyleBackColor = True
        '
        'Hallway_Door
        '
        Me.Hallway_Door.AutoSize = True
        Me.Hallway_Door.Location = New System.Drawing.Point(545, 197)
        Me.Hallway_Door.Name = "Hallway_Door"
        Me.Hallway_Door.Size = New System.Drawing.Size(96, 19)
        Me.Hallway_Door.TabIndex = 11
        Me.Hallway_Door.Text = "Hallway Door"
        Me.Hallway_Door.UseVisualStyleBackColor = True
        '
        'Door
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Hallway_Door)
        Me.Controls.Add(Me.Apartment_Door)
        Me.Controls.Add(Me.Building_Door)
        Me.Controls.Add(Me.Door_Home)
        Me.Controls.Add(Me.Door_Back)
        Me.Controls.Add(Me.Door_Open)
        Me.Controls.Add(Me.Door_Unlock)
        Me.Controls.Add(Me.Door_Close)
        Me.Controls.Add(Me.Door_lock)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Door"
        Me.Text = "Door"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Door_lock As Button
    Friend WithEvents Door_Close As Button
    Friend WithEvents Door_Unlock As Button
    Friend WithEvents Door_Open As Button
    Friend WithEvents Door_Back As Button
    Friend WithEvents Door_Home As Button
    Friend WithEvents Building_Door As RadioButton
    Friend WithEvents Apartment_Door As RadioButton
    Friend WithEvents Hallway_Door As RadioButton
End Class
