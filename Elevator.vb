Imports System.Windows

Public Class Elevator
    Private Sub Elevator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SelectFloor_Click(sender As Object, e As EventArgs) Handles SelectFloor.Click
        Dim NewWindow As New SelectFloor()
        NewWindow.Show()
    End Sub

    Private Sub CallElevator_Click(sender As Object, e As EventArgs) Handles CallElevator.Click

    End Sub

    Private Sub Ele_back_Click(sender As Object, e As EventArgs) Handles Ele_back.Click

    End Sub

    Private Sub Ele_Home_Click(sender As Object, e As EventArgs) Handles Ele_Home.Click

    End Sub
End Class