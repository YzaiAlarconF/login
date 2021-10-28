'incertar variable de importacion
Imports System.Data.SqlClient
Public Class usuarios
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("insertar_usuario", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@nombres", txtnombre.Text)
            cmd.Parameters.AddWithValue("@login", txtlogin.Text)
            cmd.Parameters.AddWithValue("@password", txtpassword.Text)
            cmd.ExecuteNonQuery()
            cerrar()
            Mostrar()
        Catch ex As Exception : MsgBox(ex.Message)
        End Try
    End Sub

    Sub Mostrar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            da = New SqlDataAdapter("mostrar_usuario", conexion)
            da.Fill(dt)
            datalist.DataSource = dt
            cerrar()
        Catch ex As Exception : MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar()
    End Sub

    Private Sub datalist_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalist.CellContentClick

    End Sub

    Private Sub datalist_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalist.CellDoubleClick
        Try
            Panel4.Visible = True
            txtnombre.Text = datalist.SelectedCells.Item(1).Value
            txtlogin.Text = datalist.SelectedCells.Item(2).Value
            txtpassword.Text = datalist.SelectedCells.Item(3).Value
            lb6.Text = datalist.SelectedCells.Item(0).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cambios_Click(sender As Object, e As EventArgs) Handles cambios.Click
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("editar_usuario", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@idusuario", txtnombre.Text)
            cmd.Parameters.AddWithValue("@nombres", txtnombre.Text)
            cmd.Parameters.AddWithValue("@login", txtlogin.Text)
            cmd.Parameters.AddWithValue("@password", txtpassword.Text)
            cmd.ExecuteNonQuery()
            cerrar()
            Mostrar()
        Catch ex As Exception : MsgBox(ex.Message)
        End Try
    End Sub
End Class