Public Class Form1
    Private Sub Elevator_Click(sender As Object, e As EventArgs) Handles Elevator.Click
        Dim NewWindow As New Elevator()
        NewWindow.Show()
    End Sub

    Private Sub Movement_Click(sender As Object, e As EventArgs) Handles Movement.Click
        Dim NewWindow As New Movement()
        NewWindow.Show()
    End Sub

    Private Sub Door_Click(sender As Object, e As EventArgs) Handles Door.Click
        Dim NewWindow As New Door()
        NewWindow.Show()
    End Sub

    Private Sub Apartment_Click(sender As Object, e As EventArgs) Handles Apartment.Click
        Dim NewWindow As New Environment()
        NewWindow.Show()
    End Sub

    Private Sub Entertainment_Click(sender As Object, e As EventArgs) Handles Entertainment.Click
        Dim NewWindow As New Entertainment()
        NewWindow.Show()
    End Sub

    Private Sub Visiting_Click(sender As Object, e As EventArgs) Handles Visiting.Click
        Dim NewWindow As New Visiting()
        NewWindow.Show()
    End Sub

    Private Sub CallAssist_Click(sender As Object, e As EventArgs) Handles CallAssist.Click
        Dim NewWindow As New Assistance()
        NewWindow.Show()
    End Sub
End Class
