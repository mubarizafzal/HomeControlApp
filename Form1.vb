Imports System.Threading

Public Class Form1

    Private selectionSequence(8) As Button ' 8 gives 9 elements (0-indexed)
    Private ready As Boolean = False
    Private selectionIndex As Integer = 0
    Private redPen As New Pen(Color.FromArgb(255, 240, 0, 0), 4)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Disable usage of tab
        Me.Movement.TabStop = False
        Me.Door.TabStop = False
        Me.CallAssist.TabStop = False
        Me.Elevator.TabStop = False
        Me.Visiting.TabStop = False
        Me.Apartment.TabStop = False
        Me.Bed.TabStop = False
        Me.Communication.TabStop = False
        Me.Entertainment.TabStop = False
        ' Declare sequence
        Me.selectionSequence(0) = Me.Movement
        Me.selectionSequence(1) = Me.CallAssist
        Me.selectionSequence(2) = Me.Door
        Me.selectionSequence(3) = Me.Elevator
        Me.selectionSequence(4) = Me.Apartment
        Me.selectionSequence(5) = Me.Visiting
        Me.selectionSequence(6) = Me.Entertainment
        Me.selectionSequence(7) = Me.Bed
        Me.selectionSequence(8) = Me.Communication

        Me.ready = True
        Me.Invalidate()
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        If (ready) Then
            Dim x As Integer = Me.selectionSequence(selectionIndex).Location.X - 5
            Dim y As Integer = Me.selectionSequence(selectionIndex).Location.Y - 5
            Dim width = Me.selectionSequence(selectionIndex).Size.Width + 10
            Dim height = Me.selectionSequence(selectionIndex).Size.Height + 10
            e.Graphics.DrawRectangle(redPen, x, y, width, height)
        End If
    End Sub

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = " " Then
            Dim currentSelection As Button = selectionSequence(selectionIndex)
            Select Case currentSelection.Name
                Case Me.Elevator.Name
                    Dim NewWindow As New Elevator()
                    NewWindow.Show()
                Case Me.Movement.Name
                    Dim NewWindow As New Movement()
                    NewWindow.Show()
                Case Me.Door.Name
                    Dim NewWindow As New Door()
                    NewWindow.Show()
                Case Me.Apartment.Name
                    Dim NewWindow As New Environment()
                    NewWindow.Show()
                Case Me.Entertainment.Name
                    Dim NewWindow As New Entertainment()
                    NewWindow.Show()
                Case Me.Visiting.Name
                    Dim NewWindow As New Visiting()
                    NewWindow.Show()
                Case Me.CallAssist.Name
                    Dim NewWindow As New Assistance()
                    NewWindow.Show()
            End Select
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        selectionIndex = (selectionIndex + 1) Mod selectionSequence.Length
        Me.Invalidate()
    End Sub

End Class
