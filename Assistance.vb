Public Class Assistance

    Private selectionSequence(3) As Button
    Private ready As Boolean = False
    Private selectionIndex As Integer = 0
    Private redPen As New Pen(Color.FromArgb(255, 240, 0, 0), 4)

    Private Sub Assistance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Assist_Confirm.TabStop = False
        Me.Assist_Again.TabStop = False
        Me.Cancel.TabStop = False
        Me.Close.TabStop = False

        Me.selectionSequence(0) = Me.Assist_Confirm
        Me.selectionSequence(1) = Me.Assist_Again
        Me.selectionSequence(2) = Me.Cancel
        Me.selectionSequence(3) = Me.Close

        Me.ready = True
        Me.Invalidate()
    End Sub

    Private Sub Assistance_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
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

    Private Sub Assistance_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = " " Then
            If Me.selectionSequence(selectionIndex).Name = "Close" Then
                ActiveForm.Close()
            End If
        End If
    End Sub
End Class