Public Class Principal
    Private contardor As Integer
    Dim guardarcordenadas As String
    Dim guardarcordenadas2 As String





    Private Sub Principal_Move(sender As Object, e As EventArgs) Handles MyBase.Move
        Me.Text = "Esquerra" + CStr(Me.Left) + "Dreta" + CStr(Me.Right)



    End Sub

    Private Sub Principal_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            guardarcordenadas = "Coordeanda with LEFT: " + CStr(e.X) + "," + CStr(e.Y)

        ElseIf e.Button = MouseButtons.Right Then
            guardarcordenadas = "Coordeanda with RIGHT: " + CStr(e.X) + "," + CStr(e.Y)
        End If



    End Sub
    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress

        If UCase(e.KeyChar) = Chr(Keys.I) Or UCase(e.KeyChar) = Chr(Keys.Return) Then

            Me.Text = StrReverse(Me.Text)

        Else
            Me.Text = Me.Text + e.KeyChar
        End If
    End Sub

    Private Sub Form1_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        Me.Text = "Amplada " & Me.Width & " Altura " & Me.Height

    End Sub

    Private Sub Principal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        Me.Text = Me.Text + e.KeyChar



    End Sub


    Private Sub Principal_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        guardarcordenadas2 = "Coordeanda: " + CStr(e.X) + "," + CStr(e.Y)
        Me.Text = "Coordenada Origen: " + guardarcordenadas + "Coordenada Desti" + guardarcordenadas2

    End Sub

    Private Sub Principal_DoubleClick(sender As Object, e As EventArgs) Handles MyBase.DoubleClick
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If

    End Sub
End Class