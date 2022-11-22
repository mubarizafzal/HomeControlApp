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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Door))
        Me.Door_Lock = New System.Windows.Forms.Button()
        Me.Door_Close = New System.Windows.Forms.Button()
        Me.Door_Unlock = New System.Windows.Forms.Button()
        Me.Door_Open = New System.Windows.Forms.Button()
        Me.Close = New System.Windows.Forms.Button()
        Me.Building_Door = New System.Windows.Forms.RadioButton()
        Me.Apartment_Door = New System.Windows.Forms.RadioButton()
        Me.Hallway_Door = New System.Windows.Forms.RadioButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Door_Lock
        '
        Me.Door_Lock.Location = New System.Drawing.Point(371, 238)
        Me.Door_Lock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Door_Lock.Name = "Door_Lock"
        Me.Door_Lock.Size = New System.Drawing.Size(90, 90)
        Me.Door_Lock.TabIndex = 3
        Me.Door_Lock.Text = "Lock"
        Me.Door_Lock.UseVisualStyleBackColor = True
        '
        'Door_Close
        '
        Me.Door_Close.Location = New System.Drawing.Point(483, 346)
        Me.Door_Close.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Door_Close.Name = "Door_Close"
        Me.Door_Close.Size = New System.Drawing.Size(90, 90)
        Me.Door_Close.TabIndex = 4
        Me.Door_Close.Text = "Close"
        Me.Door_Close.UseVisualStyleBackColor = True
        '
        'Door_Unlock
        '
        Me.Door_Unlock.Location = New System.Drawing.Point(483, 238)
        Me.Door_Unlock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Door_Unlock.Name = "Door_Unlock"
        Me.Door_Unlock.Size = New System.Drawing.Size(90, 90)
        Me.Door_Unlock.TabIndex = 5
        Me.Door_Unlock.Text = "Unlock"
        Me.Door_Unlock.UseVisualStyleBackColor = True
        '
        'Door_Open
        '
        Me.Door_Open.Location = New System.Drawing.Point(371, 346)
        Me.Door_Open.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Door_Open.Name = "Door_Open"
        Me.Door_Open.Size = New System.Drawing.Size(90, 90)
        Me.Door_Open.TabIndex = 6
        Me.Door_Open.Text = "Open"
        Me.Door_Open.UseVisualStyleBackColor = True
        '
        'Close
        '
        Me.Close.Location = New System.Drawing.Point(749, 460)
        Me.Close.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Close.Name = "Close"
        Me.Close.Size = New System.Drawing.Size(110, 110)
        Me.Close.TabIndex = 8
        Me.Close.Text = "Close"
        Me.Close.UseVisualStyleBackColor = True
        '
        'Building_Door
        '
        Me.Building_Door.AutoSize = True
        Me.Building_Door.Location = New System.Drawing.Point(142, 146)
        Me.Building_Door.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Building_Door.Name = "Building_Door"
        Me.Building_Door.Size = New System.Drawing.Size(161, 24)
        Me.Building_Door.TabIndex = 9
        Me.Building_Door.Text = "Building Front Door"
        Me.Building_Door.UseVisualStyleBackColor = True
        '
        'Apartment_Door
        '
        Me.Apartment_Door.AutoSize = True
        Me.Apartment_Door.Location = New System.Drawing.Point(418, 146)
        Me.Apartment_Door.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Apartment_Door.Name = "Apartment_Door"
        Me.Apartment_Door.Size = New System.Drawing.Size(139, 24)
        Me.Apartment_Door.TabIndex = 10
        Me.Apartment_Door.Text = "Apartment Door"
        Me.Apartment_Door.UseVisualStyleBackColor = True
        '
        'Hallway_Door
        '
        Me.Hallway_Door.AutoSize = True
        Me.Hallway_Door.Location = New System.Drawing.Point(691, 146)
        Me.Hallway_Door.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Hallway_Door.Name = "Hallway_Door"
        Me.Hallway_Door.Size = New System.Drawing.Size(121, 24)
        Me.Hallway_Door.TabIndex = 11
        Me.Hallway_Door.Text = "Hallway Door"
        Me.Hallway_Door.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Door
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(982, 753)
        Me.Controls.Add(Me.Hallway_Door)
        Me.Controls.Add(Me.Apartment_Door)
        Me.Controls.Add(Me.Building_Door)
        Me.Controls.Add(Me.Close)
        Me.Controls.Add(Me.Door_Open)
        Me.Controls.Add(Me.Door_Unlock)
        Me.Controls.Add(Me.Door_Close)
        Me.Controls.Add(Me.Door_Lock)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Door"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Door"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Door_Lock As Button
    Friend WithEvents Door_Close As Button
    Friend WithEvents Door_Unlock As Button
    Friend WithEvents Door_Open As Button
    Friend WithEvents Close As Button
    Friend WithEvents Building_Door As RadioButton
    Friend WithEvents Apartment_Door As RadioButton
    Friend WithEvents Hallway_Door As RadioButton
    Friend WithEvents Timer1 As Timer
End Class
