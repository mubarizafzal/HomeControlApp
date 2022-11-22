Public Class Entertainment
    Private selectionSequence(3) As ButtonBase
    Private ready As Boolean = False
    Private selectionIndex As Integer = 0
    Private redPen As New Pen(Color.FromArgb(255, 240, 0, 0), 4)

    Private Sub Entertainment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Ent_Games.TabStop = False
        Me.Ent_Radio.TabStop = False
        Me.Ent_TV.TabStop = False
        Me.Close.TabStop = False

        Me.selectionSequence(0) = Me.Ent_TV
        Me.selectionSequence(1) = Me.Ent_Radio
        Me.selectionSequence(2) = Me.Ent_Games
        Me.selectionSequence(3) = Me.Close

        Me.ready = True
        Me.Invalidate()
    End Sub

    Private Sub Entertainment_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
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

    Private Sub Entertainment_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = " " Then
            If Me.selectionSequence(selectionIndex).Name = "Close" Then
                ActiveForm.Close()
            ElseIf Me.selectionSequence(selectionIndex).Name = "Ent_Radio" Then
                Dim NewWindow As New Radio()
                NewWindow.Show()
            ElseIf Me.selectionSequence(selectionIndex).Name = "Ent_TV" Then
                Dim NewWindow As New TV()
                NewWindow.Show()
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

    Private Sub Ent_Radio_Click(sender As Object, e As EventArgs) Handles Ent_Radio.Click
        Dim NewWindow As New Radio()
        NewWindow.Show()
    End Sub

    Private Sub Ent_TV_Click(sender As Object, e As EventArgs) Handles Ent_TV.Click
        Dim NewWindow As New TV()
        NewWindow.Show()
    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Close.Click
        ActiveForm.Close()
    End Sub
End Class