Public Class Form1

    Private homePageNavigationSequence() As Button = {
        Me.NavSettingsBtn,
        Me.CallAssistanceBtn,
        Me.WheelchairBtn,
        Me.DoorOpsBtn,
        Me.VisitAptsBtn,
        Me.EnvCtrlBtn,
        Me.CommBtn,
        Me.ExitBtn
    }

    Private currentSelection As Button

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Do While True
        'currentSelection = homePageNavigationSequence.
        'Loop
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        If currentSelection Is Nothing Then
            currentSelection = Me.NavSettingsBtn
        End If

        Dim redPen As New Pen(Color.Red, 4)
        Dim outlineDistance As Integer = 10
        Dim rect As New Rectangle(currentSelection.Location.X - outlineDistance, currentSelection.Location.Y - outlineDistance, currentSelection.Width + (outlineDistance * 2), currentSelection.Height + (outlineDistance * 2))

        e.Graphics.DrawRectangle(redPen, rect)
    End Sub
End Class
