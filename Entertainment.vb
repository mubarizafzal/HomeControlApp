Public Class Entertainment
    Private Sub Entertainment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Ent_Radio_Click(sender As Object, e As EventArgs) Handles Ent_Radio.Click
        Dim NewWindow As New Radio()
        NewWindow.Show()
    End Sub

    Private Sub Ent_TV_Click(sender As Object, e As EventArgs) Handles Ent_TV.Click
        Dim NewWindow As New TV()
        NewWindow.Show()
    End Sub
End Class