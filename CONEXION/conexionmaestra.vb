'Importar libreria de sql
Imports System.Data.SqlClient
Module conexionmaestra
    'crear variable publica de coneccion
    Public conexion As New SqlConnection("Data Source=ROKURO\SQLEXPRESS;Initial Catalog=login;Integrated Security=True")
    'Nombre del servidor del server sql (Data Source="~~"), Localizarle en que base de datos se tiene que conectar (Initial Catalog="~~"), Conexion de autotificacion de windows (Integrated Security=True)

    'decirle cuando vamos abrir una coneccion y cuando cerarla
    Sub abrir()
        If conexion.State = 0 Then
            conexion.Open()
        End If
    End Sub
    Sub cerrar()
        If conexion.State = 1 Then
            conexion.Close()
        End If
    End Sub

End Module
