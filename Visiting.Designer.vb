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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Visiting))
        Me.Visit_back = New System.Windows.Forms.Button()
        Me.Visit_home = New System.Windows.Forms.Button()
        Me.Visit_Floor1 = New System.Windows.Forms.RadioButton()
        Me.Visit_Floor2 = New System.Windows.Forms.RadioButton()
        Me.Visit_Floor3 = New System.Windows.Forms.RadioButton()
        Me.Visit_Apart1 = New System.Windows.Forms.RadioButton()
        Me.Visit_Apart2 = New System.Windows.Forms.RadioButton()
        Me.Visit_Apart3 = New System.Windows.Forms.RadioButton()
        Me.Visit_Doorbell = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Visit_back
        '
        Me.Visit_back.Location = New System.Drawing.Point(97, 496)
        Me.Visit_back.Name = "Visit_back"
        Me.Visit_back.Size = New System.Drawing.Size(75, 75)
        Me.Visit_back.TabIndex = 1
        Me.Visit_back.Text = "Back"
        Me.Visit_back.UseVisualStyleBackColor = True
        '
        'Visit_home
        '
        Me.Visit_home.Location = New System.Drawing.Point(796, 496)
        Me.Visit_home.Name = "Visit_home"
        Me.Visit_home.Size = New System.Drawing.Size(75, 75)
        Me.Visit_home.TabIndex = 2
        Me.Visit_home.Text = "Home"
        Me.Visit_home.UseVisualStyleBackColor = True
        '
        'Visit_Floor1
        '
        Me.Visit_Floor1.AutoSize = True
        Me.Visit_Floor1.Location = New System.Drawing.Point(262, 204)
        Me.Visit_Floor1.Name = "Visit_Floor1"
        Me.Visit_Floor1.Size = New System.Drawing.Size(61, 19)
        Me.Visit_Floor1.TabIndex = 3
        Me.Visit_Floor1.TabStop = True
        Me.Visit_Floor1.Text = "Floor 1"
        Me.Visit_Floor1.UseVisualStyleBackColor = True
        '
        'Visit_Floor2
        '
        Me.Visit_Floor2.AutoSize = True
        Me.Visit_Floor2.Location = New System.Drawing.Point(421, 204)
        Me.Visit_Floor2.Name = "Visit_Floor2"
        Me.Visit_Floor2.Size = New System.Drawing.Size(61, 19)
        Me.Visit_Floor2.TabIndex = 4
        Me.Visit_Floor2.TabStop = True
        Me.Visit_Floor2.Text = "Floor 2"
        Me.Visit_Floor2.UseVisualStyleBackColor = True
        '
        'Visit_Floor3
        '
        Me.Visit_Floor3.AutoSize = True
        Me.Visit_Floor3.Location = New System.Drawing.Point(601, 204)
        Me.Visit_Floor3.Name = "Visit_Floor3"
        Me.Visit_Floor3.Size = New System.Drawing.Size(61, 19)
        Me.Visit_Floor3.TabIndex = 5
        Me.Visit_Floor3.TabStop = True
        Me.Visit_Floor3.Text = "Floor 3"
        Me.Visit_Floor3.UseVisualStyleBackColor = True
        '
        'Visit_Apart1
        '
        Me.Visit_Apart1.AutoSize = True
        Me.Visit_Apart1.Location = New System.Drawing.Point(262, 351)
        Me.Visit_Apart1.Name = "Visit_Apart1"
        Me.Visit_Apart1.Size = New System.Drawing.Size(91, 19)
        Me.Visit_Apart1.TabIndex = 6
        Me.Visit_Apart1.TabStop = True
        Me.Visit_Apart1.Text = "Apartment 1"
        Me.Visit_Apart1.UseVisualStyleBackColor = True
        '
        'Visit_Apart2
        '
        Me.Visit_Apart2.AutoSize = True
        Me.Visit_Apart2.Location = New System.Drawing.Point(421, 351)
        Me.Visit_Apart2.Name = "Visit_Apart2"
        Me.Visit_Apart2.Size = New System.Drawing.Size(91, 19)
        Me.Visit_Apart2.TabIndex = 7
        Me.Visit_Apart2.TabStop = True
        Me.Visit_Apart2.Text = "Apartment 2"
        Me.Visit_Apart2.UseVisualStyleBackColor = True
        '
        'Visit_Apart3
        '
        Me.Visit_Apart3.AutoSize = True
        Me.Visit_Apart3.Location = New System.Drawing.Point(601, 351)
        Me.Visit_Apart3.Name = "Visit_Apart3"
        Me.Visit_Apart3.Size = New System.Drawing.Size(91, 19)
        Me.Visit_Apart3.TabIndex = 8
        Me.Visit_Apart3.TabStop = True
        Me.Visit_Apart3.Text = "Apartment 3"
        Me.Visit_Apart3.UseVisualStyleBackColor = True
        '
        'Visit_Doorbell
        '
        Me.Visit_Doorbell.Location = New System.Drawing.Point(443, 426)
        Me.Visit_Doorbell.Name = "Visit_Doorbell"
        Me.Visit_Doorbell.Size = New System.Drawing.Size(75, 75)
        Me.Visit_Doorbell.TabIndex = 9
        Me.Visit_Doorbell.Text = "Ring Doorbell"
        Me.Visit_Doorbell.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(449, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 15)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Floor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(414, 288)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 15)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Apartment Number"
        '
        'Visiting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(968, 671)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Visit_Doorbell)
        Me.Controls.Add(Me.Visit_Apart3)
        Me.Controls.Add(Me.Visit_Apart2)
        Me.Controls.Add(Me.Visit_Apart1)
        Me.Controls.Add(Me.Visit_Floor3)
        Me.Controls.Add(Me.Visit_Floor2)
        Me.Controls.Add(Me.Visit_Floor1)
        Me.Controls.Add(Me.Visit_home)
        Me.Controls.Add(Me.Visit_back)
        Me.Name = "Visiting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visiting"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Visit_back As Button
    Friend WithEvents Visit_home As Button
    Friend WithEvents Visit_Floor1 As RadioButton
    Friend WithEvents Visit_Floor2 As RadioButton
    Friend WithEvents Visit_Floor3 As RadioButton
    Friend WithEvents Visit_Apart1 As RadioButton
    Friend WithEvents Visit_Apart2 As RadioButton
    Friend WithEvents Visit_Apart3 As RadioButton
    Friend WithEvents Visit_Doorbell As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
