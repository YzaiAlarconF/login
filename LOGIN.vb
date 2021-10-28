Public Class LOGIN
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bt1_Click(sender As Object, e As EventArgs) Handles bt1.Click
        Close()
    End Sub

    Private Sub usuario_TextChanged(sender As Object, e As EventArgs) Handles usuario.TextChanged

    End Sub

    Private Sub usuario_Click(sender As Object, e As EventArgs) Handles usuario.Click
        usuario.Text = ""
        usuario.Focus()
    End Sub

    Private Sub contraseña_TextChanged(sender As Object, e As EventArgs) Handles contraseña.TextChanged

    End Sub

    Private Sub contraseña_Click(sender As Object, e As EventArgs) Handles contraseña.Click
        contraseña.Text = ""
        contraseña.Focus()

    End Sub
End Class
