Public Class SelectFloor
    Private selectionSequence(3) As Button
    Private ready As Boolean = False
    Private selectionIndex As Integer = 0
    Private redPen As New Pen(Color.FromArgb(255, 240, 0, 0), 4)
    Private Sub SelectFloor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Ele_Floor1.TabStop = False
        Me.Ele_Floor2.TabStop = False
        Me.Ele_Floor3.TabStop = False
        Me.Close.TabStop = False

        Me.selectionSequence(0) = Me.Ele_Floor1
        Me.selectionSequence(1) = Me.Ele_Floor2
        Me.selectionSequence(2) = Me.Ele_Floor3
        Me.selectionSequence(3) = Me.Close

        Me.ready = True
        Me.Invalidate()
    End Sub

    Private Sub SelectFloor_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
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

    Private Sub Elevator_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = " " Then
            If Me.selectionSequence(selectionIndex).Name = "Close" Then
                ActiveForm.Close()
            ElseIf Me.selectionSequence(selectionIndex).Name = "Ele_Floor1" Then
                MsgBox("Floor 1 has been selected.")
                ActiveForm.Close()
            ElseIf Me.selectionSequence(selectionIndex).Name = "Ele_Floor2" Then
                MsgBox("Floor 2 has been selected.")
                ActiveForm.Close()
            ElseIf Me.selectionSequence(selectionIndex).Name = "Ele_Floor3" Then
                MsgBox("Floor 3 has been selected.")
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

    Private Sub Ele_Floor1_Click(sender As Object, e As EventArgs) Handles Ele_Floor1.Click
        MsgBox("Floor 1 has been selected.")
        ActiveForm.Close()
    End Sub

    Private Sub Ele_Floor2_Click(sender As Object, e As EventArgs) Handles Ele_Floor2.Click
        MsgBox("Floor 2 has been selected.")
        ActiveForm.Close()
    End Sub

    Private Sub Ele_Floor3_Click(sender As Object, e As EventArgs) Handles Ele_Floor3.Click
        MsgBox("Floor 3 has been selected.")
        ActiveForm.Close()
    End Sub
End Class