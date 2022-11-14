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
        Me.NavSettingsBtn = New System.Windows.Forms.Button()
        Me.CallAssistanceBtn = New System.Windows.Forms.Button()
        Me.WheelchairBtn = New System.Windows.Forms.Button()
        Me.DoorOpsBtn = New System.Windows.Forms.Button()
        Me.VisitAptsBtn = New System.Windows.Forms.Button()
        Me.EnvCtrlBtn = New System.Windows.Forms.Button()
        Me.CommBtn = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'NavSettingsBtn
        '
        Me.NavSettingsBtn.Location = New System.Drawing.Point(110, 115)
        Me.NavSettingsBtn.Name = "NavSettingsBtn"
        Me.NavSettingsBtn.Size = New System.Drawing.Size(100, 80)
        Me.NavSettingsBtn.TabIndex = 0
        Me.NavSettingsBtn.Text = "Navigation Settings"
        Me.NavSettingsBtn.UseVisualStyleBackColor = True
        '
        'CallAssistanceBtn
        '
        Me.CallAssistanceBtn.Location = New System.Drawing.Point(235, 115)
        Me.CallAssistanceBtn.Name = "CallAssistanceBtn"
        Me.CallAssistanceBtn.Size = New System.Drawing.Size(100, 80)
        Me.CallAssistanceBtn.TabIndex = 1
        Me.CallAssistanceBtn.Text = "Call For Assistance"
        Me.CallAssistanceBtn.UseVisualStyleBackColor = True
        '
        'WheelchairBtn
        '
        Me.WheelchairBtn.Location = New System.Drawing.Point(360, 115)
        Me.WheelchairBtn.Name = "WheelchairBtn"
        Me.WheelchairBtn.Size = New System.Drawing.Size(100, 80)
        Me.WheelchairBtn.TabIndex = 2
        Me.WheelchairBtn.Text = "Wheelchair"
        Me.WheelchairBtn.UseVisualStyleBackColor = True
        '
        'DoorOpsBtn
        '
        Me.DoorOpsBtn.Location = New System.Drawing.Point(485, 115)
        Me.DoorOpsBtn.Name = "DoorOpsBtn"
        Me.DoorOpsBtn.Size = New System.Drawing.Size(100, 80)
        Me.DoorOpsBtn.TabIndex = 3
        Me.DoorOpsBtn.Text = "Door Operations"
        Me.DoorOpsBtn.UseVisualStyleBackColor = True
        '
        'VisitAptsBtn
        '
        Me.VisitAptsBtn.Location = New System.Drawing.Point(610, 115)
        Me.VisitAptsBtn.Name = "VisitAptsBtn"
        Me.VisitAptsBtn.Size = New System.Drawing.Size(100, 80)
        Me.VisitAptsBtn.TabIndex = 4
        Me.VisitAptsBtn.Text = "Visit Apartments"
        Me.VisitAptsBtn.UseVisualStyleBackColor = True
        '
        'EnvCtrlBtn
        '
        Me.EnvCtrlBtn.Location = New System.Drawing.Point(735, 115)
        Me.EnvCtrlBtn.Name = "EnvCtrlBtn"
        Me.EnvCtrlBtn.Size = New System.Drawing.Size(100, 80)
        Me.EnvCtrlBtn.TabIndex = 5
        Me.EnvCtrlBtn.Text = "Environment Control"
        Me.EnvCtrlBtn.UseVisualStyleBackColor = True
        '
        'CommBtn
        '
        Me.CommBtn.Location = New System.Drawing.Point(110, 230)
        Me.CommBtn.Name = "CommBtn"
        Me.CommBtn.Size = New System.Drawing.Size(100, 80)
        Me.CommBtn.TabIndex = 6
        Me.CommBtn.Text = "Communication"
        Me.CommBtn.UseVisualStyleBackColor = True
        '
        'ExitBtn
        '
        Me.ExitBtn.Location = New System.Drawing.Point(735, 475)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(100, 80)
        Me.ExitBtn.TabIndex = 7
        Me.ExitBtn.Text = "Exit"
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1182, 653)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.CommBtn)
        Me.Controls.Add(Me.EnvCtrlBtn)
        Me.Controls.Add(Me.VisitAptsBtn)
        Me.Controls.Add(Me.DoorOpsBtn)
        Me.Controls.Add(Me.WheelchairBtn)
        Me.Controls.Add(Me.CallAssistanceBtn)
        Me.Controls.Add(Me.NavSettingsBtn)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NavSettingsBtn As Button
    Friend WithEvents CallAssistanceBtn As Button
    Friend WithEvents WheelchairBtn As Button
    Friend WithEvents DoorOpsBtn As Button
    Friend WithEvents VisitAptsBtn As Button
    Friend WithEvents EnvCtrlBtn As Button
    Friend WithEvents CommBtn As Button
    Friend WithEvents ExitBtn As Button
End Class
