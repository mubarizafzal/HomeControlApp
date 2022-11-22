Imports System.Windows

Public Class Elevator
    Private selectionSequence(2) As Button
    Private ready As Boolean = False
    Private selectionIndex As Integer = 0
    Private redPen As New Pen(Color.FromArgb(255, 240, 0, 0), 4)

    Private Sub Elevator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CallElevator.TabStop = False
        Me.SelectFloor.TabStop = False
        Me.Close.TabStop = False

        Me.selectionSequence(0) = Me.CallElevator
        Me.selectionSequence(1) = Me.SelectFloor
        Me.selectionSequence(2) = Me.Close

        Me.ready = True
        Me.Invalidate()
    End Sub

    Private Sub Elevator_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
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
            ElseIf Me.selectionSequence(selectionIndex).Name = "SelectFloor" Then
                Dim NewWindow As New SelectFloor()
                NewWindow.Show()
            ElseIf Me.selectionSequence(selectionIndex).Name = "CallElevator" Then
                MsgBox("The elevator has been called.")
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



    Private Sub SelectFloor_Click(sender As Object, e As EventArgs) Handles SelectFloor.Click
        Dim NewWindow As New SelectFloor()
        NewWindow.Show()
    End Sub

    Private Sub CallElevator_Click(sender As Object, e As EventArgs) Handles CallElevator.Click
        MsgBox("The elevator has been called.")
        Me.CallElevator.TabStop = False
    End Sub

    Private Sub Elevator_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        Me.CallElevator.TabIndex = 0
        Me.SelectFloor.TabStop = False
        Me.Close.TabStop = False
    End Sub
End Class