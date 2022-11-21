<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Elevator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Elevator))
        Me.CallElevator = New System.Windows.Forms.Button()
        Me.SelectFloor = New System.Windows.Forms.Button()
        Me.Ele_back = New System.Windows.Forms.Button()
        Me.Ele_Home = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CallElevator
        '
        Me.CallElevator.Location = New System.Drawing.Point(329, 278)
        Me.CallElevator.Name = "CallElevator"
        Me.CallElevator.Size = New System.Drawing.Size(75, 75)
        Me.CallElevator.TabIndex = 0
        Me.CallElevator.Text = "Call Elevator"
        Me.CallElevator.UseVisualStyleBackColor = True
        '
        'SelectFloor
        '
        Me.SelectFloor.Location = New System.Drawing.Point(546, 278)
        Me.SelectFloor.Name = "SelectFloor"
        Me.SelectFloor.Size = New System.Drawing.Size(75, 75)
        Me.SelectFloor.TabIndex = 1
        Me.SelectFloor.Text = "Select Floor"
        Me.SelectFloor.UseVisualStyleBackColor = True
        '
        'Ele_back
        '
        Me.Ele_back.Location = New System.Drawing.Point(97, 501)
        Me.Ele_back.Name = "Ele_back"
        Me.Ele_back.Size = New System.Drawing.Size(75, 75)
        Me.Ele_back.TabIndex = 2
        Me.Ele_back.Text = "Back"
        Me.Ele_back.UseVisualStyleBackColor = True
        '
        'Ele_Home
        '
        Me.Ele_Home.Location = New System.Drawing.Point(798, 501)
        Me.Ele_Home.Name = "Ele_Home"
        Me.Ele_Home.Size = New System.Drawing.Size(75, 75)
        Me.Ele_Home.TabIndex = 3
        Me.Ele_Home.Text = "Home"
        Me.Ele_Home.UseVisualStyleBackColor = True
        '
        'Elevator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(968, 671)
        Me.Controls.Add(Me.Ele_Home)
        Me.Controls.Add(Me.Ele_back)
        Me.Controls.Add(Me.SelectFloor)
        Me.Controls.Add(Me.CallElevator)
        Me.Name = "Elevator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Elevator"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CallElevator As Button
    Friend WithEvents SelectFloor As Button
    Friend WithEvents Ele_back As Button
    Friend WithEvents Ele_Home As Button
End Class
