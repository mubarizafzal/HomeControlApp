Public Class TV

    Private selectionSequence(11) As ButtonBase
    Private ready As Boolean = False
    Private selectionIndex As Integer = 0
    Private redPen As New Pen(Color.FromArgb(255, 240, 0, 0), 4)

    Private Sub TV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TV_On.TabStop = False
        Me.TV_Off.TabStop = False
        Me.Channel_Up.TabStop = False
        Me.Channel_Down.TabStop = False
        Me.TV_Select.TabStop = False
        Me.TV_Up.TabStop = False
        Me.TV_Right.TabStop = False
        Me.TV_Down.TabStop = False
        Me.TV_Left.TabStop = False
        Me.TV_Vol_Up.TabStop = False
        Me.TV_Vol_Down.TabStop = False
        Me.Close.TabStop = False

        Me.selectionSequence(0) = Me.TV_On
        Me.selectionSequence(1) = Me.TV_Off
        Me.selectionSequence(2) = Me.Channel_Up
        Me.selectionSequence(3) = Me.Channel_Down
        Me.selectionSequence(4) = Me.TV_Select
        Me.selectionSequence(5) = Me.TV_Up
        Me.selectionSequence(6) = Me.TV_Right
        Me.selectionSequence(7) = Me.TV_Down
        Me.selectionSequence(8) = Me.TV_Left
        Me.selectionSequence(9) = Me.TV_Vol_Up
        Me.selectionSequence(10) = Me.TV_Vol_Down
        Me.selectionSequence(11) = Me.Close

        Me.ready = True
        Me.Invalidate()
    End Sub

    Private Sub TV_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        If (ready) Then
            Dim x As Integer = Me.selectionSequence(selectionIndex).Location.X - 5
            Dim y As Integer = Me.selectionSequence(selectionIndex).Location.Y - 5
            Dim width = Me.selectionSequence(selectionIndex).Size.Width + 10
            Dim height = Me.selectionSequence(selectionIndex).Size.Height + 10
            e.Graphics.DrawRectangle(redPen, x, y, width, height)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.selectionIndex = (selectionIndex + 1) Mod selectionSequence.Length
        Me.Invalidate()
    End Sub

    Private Sub TV_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = " " Then
            If Me.selectionSequence(selectionIndex).Name = "Close" Then
                ActiveForm.Close()
            ElseIf Me.selectionSequence(selectionIndex).Name = "TV_On" Then
                MsgBox("The TV is now on.")
            ElseIf Me.selectionSequence(selectionIndex).Name = "TV_Off" Then
                MsgBox("The TV is now off.")
            ElseIf Me.selectionSequence(selectionIndex).Name = "Channel_Up" Then
                MsgBox("You have changed channels.")
            ElseIf Me.selectionSequence(selectionIndex).Name = "Channel_Down" Then
                MsgBox("You have changed channels.")
            ElseIf Me.selectionSequence(selectionIndex).Name = "TV_Select" Then
                MsgBox("You have selected the show.")
            ElseIf Me.selectionSequence(selectionIndex).Name = "TV_Vol_Up" Then
                Dim volume As Integer = Tv_VolumeValue.Text
                volume = volume + 1
                Tv_VolumeValue.Text = volume
            ElseIf Me.selectionSequence(selectionIndex).Name = "TV_Vol_Down" Then
                Dim volume As Integer = Tv_VolumeValue.Text
                volume = volume - 1
                Tv_VolumeValue.Text = volume
            End If
        End If
        If e.KeyChar = "1" Then
            Dim NewWindow As New PhoneCall()
            NewWindow.Show()
        End If
        If e.KeyChar = "2" Then
            MsgBox("Your doorbell has been rung!")
        End If
    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Close.Click
        ActiveForm.Close()
    End Sub
End Class