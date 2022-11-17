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
        'Door_lock
        '
        Me.Door_lock.Location = New System.Drawing.Point(121, 201)
        Me.Door_lock.Name = "Door_lock"
        Me.Door_lock.Size = New System.Drawing.Size(75, 75)
        Me.Door_lock.TabIndex = 3
        Me.Door_lock.Text = "Lock"
        Me.Door_lock.UseVisualStyleBackColor = True
        '
        'Door_Close
        '
        Me.Door_Close.Location = New System.Drawing.Point(579, 201)
        Me.Door_Close.Name = "Door_Close"
        Me.Door_Close.Size = New System.Drawing.Size(75, 75)
        Me.Door_Close.TabIndex = 4
        Me.Door_Close.Text = "Close"
        Me.Door_Close.UseVisualStyleBackColor = True
        '
        'Door_Unlock
        '
        Me.Door_Unlock.Location = New System.Drawing.Point(281, 201)
        Me.Door_Unlock.Name = "Door_Unlock"
        Me.Door_Unlock.Size = New System.Drawing.Size(75, 75)
        Me.Door_Unlock.TabIndex = 5
        Me.Door_Unlock.Text = "Unlock"
        Me.Door_Unlock.UseVisualStyleBackColor = True
        '
        'Door_Open
        '
        Me.Door_Open.Location = New System.Drawing.Point(435, 201)
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
        Me.Building_Door.Location = New System.Drawing.Point(121, 75)
        Me.Building_Door.Name = "Building_Door"
        Me.Building_Door.Size = New System.Drawing.Size(129, 19)
        Me.Building_Door.TabIndex = 9
        Me.Building_Door.Text = "Building Front Door"
        Me.Building_Door.UseVisualStyleBackColor = True
        '
        'Apartment_Door
        '
        Me.Apartment_Door.AutoSize = True
        Me.Apartment_Door.Location = New System.Drawing.Point(342, 75)
        Me.Apartment_Door.Name = "Apartment_Door"
        Me.Apartment_Door.Size = New System.Drawing.Size(111, 19)
        Me.Apartment_Door.TabIndex = 10
        Me.Apartment_Door.Text = "Apartment Door"
        Me.Apartment_Door.UseVisualStyleBackColor = True
        '
        'Hallway_Door
        '
        Me.Hallway_Door.AutoSize = True
        Me.Hallway_Door.Location = New System.Drawing.Point(553, 75)
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
        Me.Name = "Door"
        Me.Text = "Door"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
