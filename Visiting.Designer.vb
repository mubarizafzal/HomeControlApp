<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Visiting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Visiting))
        Me.Close = New System.Windows.Forms.Button()
        Me.Visit_Floor1 = New System.Windows.Forms.RadioButton()
        Me.Visit_Floor2 = New System.Windows.Forms.RadioButton()
        Me.Visit_Floor3 = New System.Windows.Forms.RadioButton()
        Me.Visit_Apart1 = New System.Windows.Forms.RadioButton()
        Me.Visit_Apart2 = New System.Windows.Forms.RadioButton()
        Me.Visit_Apart3 = New System.Windows.Forms.RadioButton()
        Me.Visit_Doorbell = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Close
        '
        Me.Close.Location = New System.Drawing.Point(742, 448)
        Me.Close.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Close.Name = "Close"
        Me.Close.Size = New System.Drawing.Size(110, 110)
        Me.Close.TabIndex = 2
        Me.Close.Text = "Close"
        Me.Close.UseVisualStyleBackColor = True
        '
        'Visit_Floor1
        '
        Me.Visit_Floor1.AutoSize = True
        Me.Visit_Floor1.Location = New System.Drawing.Point(205, 154)
        Me.Visit_Floor1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Visit_Floor1.Name = "Visit_Floor1"
        Me.Visit_Floor1.Size = New System.Drawing.Size(76, 24)
        Me.Visit_Floor1.TabIndex = 3
        Me.Visit_Floor1.TabStop = True
        Me.Visit_Floor1.Text = "Floor 1"
        Me.Visit_Floor1.UseVisualStyleBackColor = True
        '
        'Visit_Floor2
        '
        Me.Visit_Floor2.AutoSize = True
        Me.Visit_Floor2.Location = New System.Drawing.Point(449, 154)
        Me.Visit_Floor2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Visit_Floor2.Name = "Visit_Floor2"
        Me.Visit_Floor2.Size = New System.Drawing.Size(76, 24)
        Me.Visit_Floor2.TabIndex = 4
        Me.Visit_Floor2.TabStop = True
        Me.Visit_Floor2.Text = "Floor 2"
        Me.Visit_Floor2.UseVisualStyleBackColor = True
        '
        'Visit_Floor3
        '
        Me.Visit_Floor3.AutoSize = True
        Me.Visit_Floor3.Location = New System.Drawing.Point(687, 154)
        Me.Visit_Floor3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Visit_Floor3.Name = "Visit_Floor3"
        Me.Visit_Floor3.Size = New System.Drawing.Size(76, 24)
        Me.Visit_Floor3.TabIndex = 5
        Me.Visit_Floor3.TabStop = True
        Me.Visit_Floor3.Text = "Floor 3"
        Me.Visit_Floor3.UseVisualStyleBackColor = True
        '
        'Visit_Apart1
        '
        Me.Visit_Apart1.AutoSize = True
        Me.Visit_Apart1.Location = New System.Drawing.Point(175, 258)
        Me.Visit_Apart1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Visit_Apart1.Name = "Visit_Apart1"
        Me.Visit_Apart1.Size = New System.Drawing.Size(113, 24)
        Me.Visit_Apart1.TabIndex = 6
        Me.Visit_Apart1.TabStop = True
        Me.Visit_Apart1.Text = "Apartment 1"
        Me.Visit_Apart1.UseVisualStyleBackColor = True
        '
        'Visit_Apart2
        '
        Me.Visit_Apart2.AutoSize = True
        Me.Visit_Apart2.Location = New System.Drawing.Point(433, 258)
        Me.Visit_Apart2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Visit_Apart2.Name = "Visit_Apart2"
        Me.Visit_Apart2.Size = New System.Drawing.Size(113, 24)
        Me.Visit_Apart2.TabIndex = 7
        Me.Visit_Apart2.TabStop = True
        Me.Visit_Apart2.Text = "Apartment 2"
        Me.Visit_Apart2.UseVisualStyleBackColor = True
        '
        'Visit_Apart3
        '
        Me.Visit_Apart3.AutoSize = True
        Me.Visit_Apart3.Location = New System.Drawing.Point(674, 258)
        Me.Visit_Apart3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Visit_Apart3.Name = "Visit_Apart3"
        Me.Visit_Apart3.Size = New System.Drawing.Size(113, 24)
        Me.Visit_Apart3.TabIndex = 8
        Me.Visit_Apart3.TabStop = True
        Me.Visit_Apart3.Text = "Apartment 3"
        Me.Visit_Apart3.UseVisualStyleBackColor = True
        '
        'Visit_Doorbell
        '
        Me.Visit_Doorbell.Location = New System.Drawing.Point(436, 339)
        Me.Visit_Doorbell.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Visit_Doorbell.Name = "Visit_Doorbell"
        Me.Visit_Doorbell.Size = New System.Drawing.Size(110, 110)
        Me.Visit_Doorbell.TabIndex = 9
        Me.Visit_Doorbell.Text = "Ring Doorbell"
        Me.Visit_Doorbell.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(464, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Floor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(425, 214)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Apartment Number"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Visiting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(982, 753)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Visit_Doorbell)
        Me.Controls.Add(Me.Visit_Apart3)
        Me.Controls.Add(Me.Visit_Apart2)
        Me.Controls.Add(Me.Visit_Apart1)
        Me.Controls.Add(Me.Visit_Floor3)
        Me.Controls.Add(Me.Visit_Floor2)
        Me.Controls.Add(Me.Visit_Floor1)
        Me.Controls.Add(Me.Close)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Visiting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visiting"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Close As Button
    Friend WithEvents Visit_Floor1 As RadioButton
    Friend WithEvents Visit_Floor2 As RadioButton
    Friend WithEvents Visit_Floor3 As RadioButton
    Friend WithEvents Visit_Apart1 As RadioButton
    Friend WithEvents Visit_Apart2 As RadioButton
    Friend WithEvents Visit_Apart3 As RadioButton
    Friend WithEvents Visit_Doorbell As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
End Class
