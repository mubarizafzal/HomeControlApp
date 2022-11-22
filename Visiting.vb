Public Class Visiting
    Private selectionSequence(7) As ButtonBase
    Private ready As Boolean = False
    Private selectionIndex As Integer = 0
    Private redPen As New Pen(Color.FromArgb(255, 240, 0, 0), 4)

    Private Sub Visiting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Visit_Floor1.TabStop = False
        Me.Visit_Floor2.TabStop = False
        Me.Visit_Floor3.TabStop = False
        Me.Visit_Apart1.TabStop = False
        Me.Visit_Apart2.TabStop = False
        Me.Visit_Apart3.TabStop = False
        Me.Visit_Doorbell.TabStop = False
        Me.Close.TabStop = False

        Me.selectionSequence(0) = Me.Visit_Floor1
        Me.selectionSequence(1) = Me.Visit_Floor2
        Me.selectionSequence(2) = Me.Visit_Floor3
        Me.selectionSequence(3) = Me.Visit_Apart1
        Me.selectionSequence(4) = Me.Visit_Apart2
        Me.selectionSequence(5) = Me.Visit_Apart3
        Me.selectionSequence(6) = Me.Visit_Doorbell
        Me.selectionSequence(7) = Me.Close

        Me.ready = True
        Me.Invalidate()
    End Sub

    Private Sub Visiting_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
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

    Private Sub Visiting_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = " " Then
            If Me.selectionSequence(selectionIndex).Name = "Close" Then
                ActiveForm.Close()
            End If
        End If
    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Close.Click
        ActiveForm.Close()
    End Sub
End Class