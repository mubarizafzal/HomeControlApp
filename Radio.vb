Public Class Radio
    Private selectionSequence(6) As ButtonBase
    Private ready As Boolean = False
    Private selectionIndex As Integer = 0
    Private redPen As New Pen(Color.FromArgb(255, 240, 0, 0), 4)

    Private Sub Radio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Radio_On.TabStop = False
        Me.Radio_Off.TabStop = False
        Me.Radio_Vol_Up.TabStop = False
        Me.Radio_Vol_Down.TabStop = False
        Me.Radio_Chan_Up.TabStop = False
        Me.Radio_Chan_Down.TabStop = False
        Me.Close.TabStop = False

        Me.selectionSequence(0) = Me.Radio_On
        Me.selectionSequence(1) = Me.Radio_Off
        Me.selectionSequence(2) = Me.Radio_Vol_Up
        Me.selectionSequence(3) = Me.Radio_Vol_Down
        Me.selectionSequence(4) = Me.Radio_Chan_Up
        Me.selectionSequence(5) = Me.Radio_Chan_Down
        Me.selectionSequence(6) = Me.Close

        Me.ready = True
        Me.Invalidate()
    End Sub

    Private Sub Radio_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        If (ready) Then
            Dim x As Integer = Me.selectionSequence(selectionIndex).Location.X - 5
            Dim y As Integer = Me.selectionSequence(selectionIndex).Location.Y - 5
            Dim width = Me.selectionSequence(selectionIndex).Size.Width + 10
            Dim height = Me.selectionSequence(selectionIndex).Size.Height + 10
            e.Graphics.DrawRectangle(redPen, x, y, width, height)
        End If
    End Sub

    Private Sub Radio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = " " Then
            If Me.selectionSequence(selectionIndex).Name = "Close" Then
                ActiveForm.Close()
            ElseIf Me.selectionSequence(selectionIndex).Name = "Radio_On" Then
                MsgBox("The radio is now on")
            ElseIf Me.selectionSequence(selectionIndex).Name = "Radio_Off" Then
                MsgBox("The radio is now off")
            ElseIf Me.selectionSequence(selectionIndex).Name = "Radio_Vol_Up" Then
                Dim volume As Integer = Radio_Vol.Text
                volume = volume + 1
                Radio_Vol.Text = volume
            ElseIf Me.selectionSequence(selectionIndex).Name = "Radio_Vol_Down" Then
                Dim volume As Integer = Radio_Vol.Text
                volume = volume - 1
                Radio_Vol.Text = volume
            ElseIf Me.selectionSequence(selectionIndex).Name = "Radio_Chan_Up" Then
                Dim channel As Decimal = Radio_Chan.Text
                channel = channel + 0.1
                Radio_Chan.Text = channel
            ElseIf Me.selectionSequence(selectionIndex).Name = "Radio_Chan_Down" Then
                Dim channel As Decimal = Radio_Chan.Text
                channel = channel - 0.1
                Radio_Chan.Text = channel
            End If
        End If
    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Close.Click
        ActiveForm.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.selectionIndex = (selectionIndex + 1) Mod selectionSequence.Length
        Me.Invalidate()
    End Sub
End Class