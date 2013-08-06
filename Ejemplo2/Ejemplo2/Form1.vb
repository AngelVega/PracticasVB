Imports MySql.Data.MySqlClient

Public Class frmMySQL

    Private Sub cmdExecutar_Click(sender As Object, e As EventArgs) Handles cmdExecutar.Click

        Dim Conexion As New MySqlConnection("server=localhost;user=root;password=root;database=dbprueba")
        Dim Comando As New MySqlCommand("Select * from tbUsuarios", Conexion)
        Dim ResultadoComando As MySqlDataReader

        Conexion.Open()
        ResultadoComando = Comando.ExecuteReader
        ResultadoComando.Read()
        txtId.Text = ResultadoComando(0)
        txtNombre.Text = ResultadoComando(1)
        Comando = Nothing
        Conexion.Close()
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub

    Private Sub txtId_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged

    End Sub
End Class
