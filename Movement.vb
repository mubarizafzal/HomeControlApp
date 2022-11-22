Public Class Movement

    Private selectionSequence(4) As Button
    Private ready As Boolean = False
    Private selectionIndex As Integer = 0
    Private redPen As New Pen(Color.FromArgb(255, 240, 0, 0), 4)

    Private Sub Movement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Forward.TabStop = False
        Me.Left.TabStop = False
        Me.Right.TabStop = False
        Me.Reverse.TabStop = False
        Me.Close.TabStop = False

        Me.selectionSequence(0) = Me.Left
        Me.selectionSequence(1) = Me.Forward
        Me.selectionSequence(2) = Me.Right
        Me.selectionSequence(3) = Me.Reverse
        Me.selectionSequence(4) = Me.Close

        Me.ready = True
        Me.Invalidate()
    End Sub

    Private Sub Movement_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
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

    Private Sub Movement_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = " " Then
            If Me.selectionSequence(selectionIndex).Name = "Close" Then
                ActiveForm.Close()
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
End Class