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
        Me.Visit_Doorbell = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Visit_201 = New System.Windows.Forms.CheckBox()
        Me.Visit_301 = New System.Windows.Forms.CheckBox()
        Me.Visit_202 = New System.Windows.Forms.CheckBox()
        Me.Visit_203 = New System.Windows.Forms.CheckBox()
        Me.Visit_303 = New System.Windows.Forms.CheckBox()
        Me.Visit_302 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Close
        '
        Me.Close.Location = New System.Drawing.Point(649, 336)
        Me.Close.Name = "Close"
        Me.Close.Size = New System.Drawing.Size(96, 82)
        Me.Close.TabIndex = 2
        Me.Close.Text = "Close"
        Me.Close.UseVisualStyleBackColor = True
        '
        'Visit_Doorbell
        '
        Me.Visit_Doorbell.Location = New System.Drawing.Point(382, 254)
        Me.Visit_Doorbell.Name = "Visit_Doorbell"
        Me.Visit_Doorbell.Size = New System.Drawing.Size(96, 82)
        Me.Visit_Doorbell.TabIndex = 9
        Me.Visit_Doorbell.Text = "Ring Doorbell"
        Me.Visit_Doorbell.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(370, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 15)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Apartment Number"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Visit_201
        '
        Me.Visit_201.AutoSize = True
        Me.Visit_201.Location = New System.Drawing.Point(184, 130)
        Me.Visit_201.Name = "Visit_201"
        Me.Visit_201.Size = New System.Drawing.Size(44, 19)
        Me.Visit_201.TabIndex = 12
        Me.Visit_201.Text = "201"
        Me.Visit_201.UseVisualStyleBackColor = True
        '
        'Visit_301
        '
        Me.Visit_301.AutoSize = True
        Me.Visit_301.Location = New System.Drawing.Point(184, 201)
        Me.Visit_301.Name = "Visit_301"
        Me.Visit_301.Size = New System.Drawing.Size(44, 19)
        Me.Visit_301.TabIndex = 13
        Me.Visit_301.Text = "301"
        Me.Visit_301.UseVisualStyleBackColor = True
        '
        'Visit_202
        '
        Me.Visit_202.AutoSize = True
        Me.Visit_202.Location = New System.Drawing.Point(385, 130)
        Me.Visit_202.Name = "Visit_202"
        Me.Visit_202.Size = New System.Drawing.Size(44, 19)
        Me.Visit_202.TabIndex = 14
        Me.Visit_202.Text = "202"
        Me.Visit_202.UseVisualStyleBackColor = True
        '
        'Visit_203
        '
        Me.Visit_203.AutoSize = True
        Me.Visit_203.Location = New System.Drawing.Point(589, 130)
        Me.Visit_203.Name = "Visit_203"
        Me.Visit_203.Size = New System.Drawing.Size(44, 19)
        Me.Visit_203.TabIndex = 15
        Me.Visit_203.Text = "203"
        Me.Visit_203.UseVisualStyleBackColor = True
        '
        'Visit_303
        '
        Me.Visit_303.AutoSize = True
        Me.Visit_303.Location = New System.Drawing.Point(589, 201)
        Me.Visit_303.Name = "Visit_303"
        Me.Visit_303.Size = New System.Drawing.Size(44, 19)
        Me.Visit_303.TabIndex = 16
        Me.Visit_303.Text = "303"
        Me.Visit_303.UseVisualStyleBackColor = True
        '
        'Visit_302
        '
        Me.Visit_302.AutoSize = True
        Me.Visit_302.Location = New System.Drawing.Point(385, 201)
        Me.Visit_302.Name = "Visit_302"
        Me.Visit_302.Size = New System.Drawing.Size(44, 19)
        Me.Visit_302.TabIndex = 17
        Me.Visit_302.Text = "302"
        Me.Visit_302.UseVisualStyleBackColor = True
        '
        'Visiting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(859, 565)
        Me.Controls.Add(Me.Visit_302)
        Me.Controls.Add(Me.Visit_303)
        Me.Controls.Add(Me.Visit_203)
        Me.Controls.Add(Me.Visit_202)
        Me.Controls.Add(Me.Visit_301)
        Me.Controls.Add(Me.Visit_201)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Visit_Doorbell)
        Me.Controls.Add(Me.Close)
        Me.DoubleBuffered = True
        Me.Name = "Visiting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visiting"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Close As Button
    Friend WithEvents Visit_Doorbell As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Visit_201 As CheckBox
    Friend WithEvents Visit_301 As CheckBox
    Friend WithEvents Visit_202 As CheckBox
    Friend WithEvents Visit_203 As CheckBox
    Friend WithEvents Visit_303 As CheckBox
    Friend WithEvents Visit_302 As CheckBox
End Class
