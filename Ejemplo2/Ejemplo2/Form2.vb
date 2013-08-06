Imports System.Data
Imports System.Data.SqlClient

Public Class frmSQLServer

    Private Sub cmdExecutar_Click(sender As Object, e As EventArgs) Handles cmdExecutar.Click
        Dim Conexion As New SqlConnection("Server=ANGEL-PC\SQLSERVERANGEL; database=prueba; trusted_connection=yes")
        'Dim Conexion As New SqlConnection("Server=ANGEL-PC\SQLSERVERANGEL; database=prueba;User Id=Angel-PC\Angel; trusted_connection=yes")
        Dim Comando As New SqlCommand("Select * from tbUsuarios", Conexion)
        Dim ResultadoComando As SqlDataReader

        Conexion.Open()
        ResultadoComando = Comando.ExecuteReader
        ResultadoComando.Read()
        txtId.Text = ResultadoComando(0)
        txtNombre.Text = ResultadoComando(1)
        Comando = Nothing
        Conexion.Close()
    End Sub

End Class