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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Assistance))
        Me.Assist_Confirm = New System.Windows.Forms.Button()
        Me.Assist_Again = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Close = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Assist_Confirm
        '
        Me.Assist_Confirm.Location = New System.Drawing.Point(130, 450)
        Me.Assist_Confirm.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Assist_Confirm.Name = "Assist_Confirm"
        Me.Assist_Confirm.Size = New System.Drawing.Size(110, 110)
        Me.Assist_Confirm.TabIndex = 0
        Me.Assist_Confirm.Text = "Confrim Arrival of Assistance"
        Me.Assist_Confirm.UseVisualStyleBackColor = True
        '
        'Assist_Again
        '
        Me.Assist_Again.Location = New System.Drawing.Point(304, 450)
        Me.Assist_Again.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Assist_Again.Name = "Assist_Again"
        Me.Assist_Again.Size = New System.Drawing.Size(110, 110)
        Me.Assist_Again.TabIndex = 1
        Me.Assist_Again.Text = "Request For Assistance Again"
        Me.Assist_Again.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(473, 450)
        Me.Cancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(110, 110)
        Me.Cancel.TabIndex = 2
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(234, 248)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(506, 31)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Your Request of Assistance was sucessfully sent. "
        '
        'Close
        '
        Me.Close.Location = New System.Drawing.Point(739, 450)
        Me.Close.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Close.Name = "Close"
        Me.Close.Size = New System.Drawing.Size(110, 110)
        Me.Close.TabIndex = 4
        Me.Close.Text = "Close"
        Me.Close.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Assistance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(982, 753)
        Me.Controls.Add(Me.Close)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Assist_Again)
        Me.Controls.Add(Me.Assist_Confirm)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Assistance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Assistance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Assist_Confirm As Button
    Friend WithEvents Assist_Again As Button
    Friend WithEvents Cancel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Close As Button
    Friend WithEvents Timer1 As Timer
End Class
