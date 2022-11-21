<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Movement = New System.Windows.Forms.Button()
        Me.CallAssist = New System.Windows.Forms.Button()
        Me.Door = New System.Windows.Forms.Button()
        Me.Elevator = New System.Windows.Forms.Button()
        Me.Apartment = New System.Windows.Forms.Button()
        Me.Visiting = New System.Windows.Forms.Button()
        Me.Entertainment = New System.Windows.Forms.Button()
        Me.Bed = New System.Windows.Forms.Button()
        Me.Communication = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Movement
        '
        Me.Movement.Location = New System.Drawing.Point(166, 142)
        Me.Movement.Name = "Movement"
        Me.Movement.Size = New System.Drawing.Size(75, 75)
        Me.Movement.TabIndex = 0
        Me.Movement.Text = "Movement"
        Me.Movement.UseVisualStyleBackColor = True
        '
        'CallAssist
        '
        Me.CallAssist.Location = New System.Drawing.Point(349, 142)
        Me.CallAssist.Name = "CallAssist"
        Me.CallAssist.Size = New System.Drawing.Size(75, 75)
        Me.CallAssist.TabIndex = 1
        Me.CallAssist.Text = "Call For Assistance"
        Me.CallAssist.UseVisualStyleBackColor = True
        '
        'Door
        '
        Me.Door.Location = New System.Drawing.Point(530, 142)
        Me.Door.Name = "Door"
        Me.Door.Size = New System.Drawing.Size(75, 75)
        Me.Door.TabIndex = 2
        Me.Door.Text = "Door Controls"
        Me.Door.UseVisualStyleBackColor = True
        '
        'Elevator
        '
        Me.Elevator.Location = New System.Drawing.Point(702, 142)
        Me.Elevator.Name = "Elevator"
        Me.Elevator.Size = New System.Drawing.Size(75, 75)
        Me.Elevator.TabIndex = 3
        Me.Elevator.Text = "Elevator"
        Me.Elevator.UseVisualStyleBackColor = True
        '
        'Apartment
        '
        Me.Apartment.Location = New System.Drawing.Point(166, 301)
        Me.Apartment.Name = "Apartment"
        Me.Apartment.Size = New System.Drawing.Size(75, 75)
        Me.Apartment.TabIndex = 4
        Me.Apartment.Text = "Apartment Control"
        Me.Apartment.UseVisualStyleBackColor = True
        '
        'Visiting
        '
        Me.Visiting.Location = New System.Drawing.Point(349, 301)
        Me.Visiting.Name = "Visiting"
        Me.Visiting.Size = New System.Drawing.Size(75, 75)
        Me.Visiting.TabIndex = 5
        Me.Visiting.Text = "Visiting Apartment"
        Me.Visiting.UseVisualStyleBackColor = True
        '
        'Entertainment
        '
        Me.Entertainment.Location = New System.Drawing.Point(530, 301)
        Me.Entertainment.Name = "Entertainment"
        Me.Entertainment.Size = New System.Drawing.Size(75, 75)
        Me.Entertainment.TabIndex = 6
        Me.Entertainment.Text = "Entertaiment"
        Me.Entertainment.UseVisualStyleBackColor = True
        '
        'Bed
        '
        Me.Bed.Location = New System.Drawing.Point(702, 301)
        Me.Bed.Name = "Bed"
        Me.Bed.Size = New System.Drawing.Size(75, 75)
        Me.Bed.TabIndex = 7
        Me.Bed.Text = "Bed Controls"
        Me.Bed.UseVisualStyleBackColor = True
        '
        'Communication
        '
        Me.Communication.Location = New System.Drawing.Point(166, 440)
        Me.Communication.Name = "Communication"
        Me.Communication.Size = New System.Drawing.Size(75, 75)
        Me.Communication.TabIndex = 8
        Me.Communication.Text = "Communication"
        Me.Communication.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(968, 671)
        Me.Controls.Add(Me.Communication)
        Me.Controls.Add(Me.Bed)
        Me.Controls.Add(Me.Entertainment)
        Me.Controls.Add(Me.Visiting)
        Me.Controls.Add(Me.Apartment)
        Me.Controls.Add(Me.Elevator)
        Me.Controls.Add(Me.Door)
        Me.Controls.Add(Me.CallAssist)
        Me.Controls.Add(Me.Movement)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Movement As Button
    Friend WithEvents CallAssist As Button
    Friend WithEvents Door As Button
    Friend WithEvents Elevator As Button
    Friend WithEvents Apartment As Button
    Friend WithEvents Visiting As Button
    Friend WithEvents Entertainment As Button
    Friend WithEvents Bed As Button
    Friend WithEvents Communication As Button
End Class
