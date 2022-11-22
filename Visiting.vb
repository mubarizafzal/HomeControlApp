Public Class Visiting
    Private selectionSequence(7) As ButtonBase
    Private ready As Boolean = False
    Private selectionIndex As Integer = 0
    Private redPen As New Pen(Color.FromArgb(255, 240, 0, 0), 4)

    Private Sub Visiting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Visit_201.TabStop = False
        Me.Visit_202.TabStop = False
        Me.Visit_203.TabStop = False
        Me.Visit_301.TabStop = False
        Me.Visit_302.TabStop = False
        Me.Visit_303.TabStop = False
        Me.Visit_Doorbell.TabStop = False
        Me.Close.TabStop = False

        Me.selectionSequence(0) = Me.Visit_201
        Me.selectionSequence(1) = Me.Visit_202
        Me.selectionSequence(2) = Me.Visit_203
        Me.selectionSequence(3) = Me.Visit_301
        Me.selectionSequence(4) = Me.Visit_302
        Me.selectionSequence(5) = Me.Visit_303
        Me.selectionSequence(6) = Me.Visit_Doorbell
        Me.selectionSequence(7) = Me.Close

        Me.ready = True
        Me.Invalidate()
    End Sub

    Private Sub Visiting_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
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

    Private Sub Visiting_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = " " Then
            'If Me.selectionSequence(selectionIndex).Name = "Close" Then
            '    ActiveForm.Close()
            'ElseIf Me.selectionSequence(selectionIndex).Name = "Visit_201" Then
            '    Visit_201.Checked = True
            'ElseIf Me.selectionSequence(selectionIndex).Name = "Visit_Doorbell" Then
            '    MsgBox("The doorbell has been rung.")
            'End If
            Dim currentSelection As ButtonBase = selectionSequence(selectionIndex)
            ' Open the appropriate window based on the current selection
            Select Case currentSelection.Name
                Case Me.Close.Name
                    ActiveForm.Close()

                Case Me.Visit_201.Name
                    Visit_201.Checked = True
                    'Visit_202.Checked = False
                    'Visit_203.Checked = False
                    'Visit_301.Checked = False
                    'Visit_302.Checked = False
                    'Visit_303.Checked = False
                Case Me.Visit_202.Name
                    'Visit_201.Checked = False
                    Visit_202.Checked = True
                    'Visit_203.Checked = False
                    'Visit_301.Checked = False
                    'Visit_302.Checked = False
                    'Visit_303.Checked = False
                Case Me.Visit_203.Name
                    'Visit_201.Checked = False
                    'Visit_202.Checked = False
                    Visit_203.Checked = True
                    'Visit_301.Checked = False
                    'Visit_302.Checked = False
                    'Visit_303.Checked = False
                Case Me.Visit_301.Name
                    'Visit_201.Checked = False
                    'Visit_202.Checked = False
                    'Visit_203.Checked = False
                    Visit_301.Checked = True
                    'Visit_302.Checked = False
                    'Visit_303.Checked = False
                Case Me.Visit_302.Name
                    'Visit_201.Checked = False
                    'Visit_202.Checked = False
                    'Visit_203.Checked = False
                    'Visit_301.Checked = False
                    Visit_302.Checked = True
                    'Visit_303.Checked = False
                Case Me.Visit_303.Name
                    'Visit_201.Checked = False
                    'Visit_202.Checked = False
                    'Visit_203.Checked = False
                    'Visit_301.Checked = False
                    'Visit_302.Checked = False
                    Visit_303.Checked = True
                Case Me.Visit_Doorbell.Name
                    MsgBox("The doorbell has been rung.")
            End Select
        End If
    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Close.Click
        ActiveForm.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class