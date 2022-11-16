<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectFloor
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
        Me.Ele_Floor1 = New System.Windows.Forms.Button()
        Me.Ele_Floor2 = New System.Windows.Forms.Button()
        Me.Ele_Floor3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Ele_Floor1
        '
        Me.Ele_Floor1.Location = New System.Drawing.Point(168, 175)
        Me.Ele_Floor1.Name = "Ele_Floor1"
        Me.Ele_Floor1.Size = New System.Drawing.Size(75, 75)
        Me.Ele_Floor1.TabIndex = 0
        Me.Ele_Floor1.Text = "Floor 1"
        Me.Ele_Floor1.UseVisualStyleBackColor = True
        '
        'Ele_Floor2
        '
        Me.Ele_Floor2.Location = New System.Drawing.Point(337, 175)
        Me.Ele_Floor2.Name = "Ele_Floor2"
        Me.Ele_Floor2.Size = New System.Drawing.Size(75, 75)
        Me.Ele_Floor2.TabIndex = 1
        Me.Ele_Floor2.Text = "Floor 2"
        Me.Ele_Floor2.UseVisualStyleBackColor = True
        '
        'Ele_Floor3
        '
        Me.Ele_Floor3.Location = New System.Drawing.Point(518, 175)
        Me.Ele_Floor3.Name = "Ele_Floor3"
        Me.Ele_Floor3.Size = New System.Drawing.Size(75, 75)
        Me.Ele_Floor3.TabIndex = 2
        Me.Ele_Floor3.Text = "Floor 3"
        Me.Ele_Floor3.UseVisualStyleBackColor = True
        '
        'SelectFloor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Ele_Floor3)
        Me.Controls.Add(Me.Ele_Floor2)
        Me.Controls.Add(Me.Ele_Floor1)
        Me.Name = "SelectFloor"
        Me.Text = "SelectFloor"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Ele_Floor1 As Button
    Friend WithEvents Ele_Floor2 As Button
    Friend WithEvents Ele_Floor3 As Button
End Class
