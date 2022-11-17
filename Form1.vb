Public Class Form1
    Private Sub Elevator_Click(sender As Object, e As EventArgs) Handles Elevator.Click
        Dim NewWindow As New Elevator()
        NewWindow.Show()
    End Sub

    Private Sub Movement_Click(sender As Object, e As EventArgs) Handles Movement.Click
        Dim NewWindow As New Movement()
        NewWindow.Show()
    End Sub
End Class
