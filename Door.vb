Public Class Door
    Private selectionSequence(7) As ButtonBase
    Private ready As Boolean = False
    Private selectionIndex As Integer = 0
    Private redPen As New Pen(Color.FromArgb(255, 240, 0, 0), 4)

    Private Sub Door_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Building_Door.TabStop = False
        Me.Apartment_Door.TabStop = False
        Me.Hallway_Door.TabStop = False
        Me.Door_Close.TabStop = False
        Me.Door_Open.TabStop = False
        Me.Door_Lock.TabStop = False
        Me.Door_Unlock.TabStop = False
        Me.Close.TabStop = False

        Me.selectionSequence(0) = Me.Building_Door
        Me.selectionSequence(1) = Me.Apartment_Door
        Me.selectionSequence(2) = Me.Hallway_Door
        Me.selectionSequence(3) = Me.Door_Lock
        Me.selectionSequence(4) = Me.Door_Unlock
        Me.selectionSequence(5) = Me.Door_Open
        Me.selectionSequence(6) = Me.Door_Close
        Me.selectionSequence(7) = Me.Close

        Me.ready = True
        Me.Invalidate()
    End Sub

    Private Sub Door_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
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

    Private Sub Door_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = " " Then
            If Me.selectionSequence(selectionIndex).Name = "Close" Then
                ActiveForm.Close()
            End If
        End If
    End Sub
    Private Sub Apartment_Door_Click(sender As Object, e As EventArgs) Handles Apartment_Door.Click
        Hallway_Door.Checked = False
        Building_Door.Checked = False
    End Sub

    Private Sub Building_Door_Click(sender As Object, e As EventArgs) Handles Building_Door.Click
        Hallway_Door.Checked = False
        Apartment_Door.Checked = False

    End Sub

    Private Sub Hallway_Door_Click(sender As Object, e As EventArgs) Handles Hallway_Door.Click
        Building_Door.Checked = False
        Apartment_Door.Checked = False
    End Sub
End Class