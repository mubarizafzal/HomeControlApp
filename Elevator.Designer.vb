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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Elevator))
        Me.CallElevator = New System.Windows.Forms.Button()
        Me.SelectFloor = New System.Windows.Forms.Button()
        Me.Close = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'CallElevator
        '
        Me.CallElevator.Location = New System.Drawing.Point(350, 251)
        Me.CallElevator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CallElevator.Name = "CallElevator"
        Me.CallElevator.Size = New System.Drawing.Size(110, 110)
        Me.CallElevator.TabIndex = 0
        Me.CallElevator.Text = "Call Elevator"
        Me.CallElevator.UseVisualStyleBackColor = True
        '
        'SelectFloor
        '
        Me.SelectFloor.Location = New System.Drawing.Point(527, 251)
        Me.SelectFloor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SelectFloor.Name = "SelectFloor"
        Me.SelectFloor.Size = New System.Drawing.Size(110, 110)
        Me.SelectFloor.TabIndex = 1
        Me.SelectFloor.Text = "Select Floor"
        Me.SelectFloor.UseVisualStyleBackColor = True
        '
        'Close
        '
        Me.Close.Location = New System.Drawing.Point(735, 440)
        Me.Close.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Close.Name = "Close"
        Me.Close.Size = New System.Drawing.Size(110, 110)
        Me.Close.TabIndex = 3
        Me.Close.Text = "Close"
        Me.Close.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Elevator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(982, 753)
        Me.Controls.Add(Me.Close)
        Me.Controls.Add(Me.SelectFloor)
        Me.Controls.Add(Me.CallElevator)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Elevator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Elevator"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CallElevator As Button
    Friend WithEvents SelectFloor As Button
    Friend WithEvents Close As Button
    Friend WithEvents Timer1 As Timer
End Class
