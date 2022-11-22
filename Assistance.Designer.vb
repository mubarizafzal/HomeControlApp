<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Assistance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Assistance))
        Me.Asist_Confirm = New System.Windows.Forms.Button()
        Me.Asist_Again = New System.Windows.Forms.Button()
        Me.Assist_Cancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Asist_Confirm
        '
        Me.Asist_Confirm.Location = New System.Drawing.Point(237, 411)
        Me.Asist_Confirm.Name = "Asist_Confirm"
        Me.Asist_Confirm.Size = New System.Drawing.Size(75, 75)
        Me.Asist_Confirm.TabIndex = 0
        Me.Asist_Confirm.Text = "Confrim Arrival of Assistance"
        Me.Asist_Confirm.UseVisualStyleBackColor = True
        '
        'Asist_Again
        '
        Me.Asist_Again.Location = New System.Drawing.Point(444, 411)
        Me.Asist_Again.Name = "Asist_Again"
        Me.Asist_Again.Size = New System.Drawing.Size(75, 75)
        Me.Asist_Again.TabIndex = 1
        Me.Asist_Again.Text = "Request For Assistance Again"
        Me.Asist_Again.UseVisualStyleBackColor = True
        '
        'Assist_Cancel
        '
        Me.Assist_Cancel.Location = New System.Drawing.Point(639, 411)
        Me.Assist_Cancel.Name = "Assist_Cancel"
        Me.Assist_Cancel.Size = New System.Drawing.Size(75, 75)
        Me.Assist_Cancel.TabIndex = 2
        Me.Assist_Cancel.Text = "Cancel"
        Me.Assist_Cancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(343, 257)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Your Request of Assistance was sucessfully sent. "
        '
        'Assistance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(968, 671)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Assist_Cancel)
        Me.Controls.Add(Me.Asist_Again)
        Me.Controls.Add(Me.Asist_Confirm)
        Me.Name = "Assistance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Assistance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Asist_Confirm As Button
    Friend WithEvents Asist_Again As Button
    Friend WithEvents Assist_Cancel As Button
    Friend WithEvents Label1 As Label
End Class
