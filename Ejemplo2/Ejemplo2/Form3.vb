Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Establecemos la cadena SQL a utilizar
        SqlDataAdapter1.SelectCommand.CommandText = "Select * from tbUsuarios"
        ' Abrimos la Conexión
        SqlConnection1.Open()
        ' Rellenamos el DataSet con el contenido de la instrucción SQL
        SqlDataAdapter1.Fill(DataSet1)
        ' Cerramos la Conexión
        SqlConnection1.Close()
        ' Declaramos la propiedad Row para recorrer
        ' las filas contenidas en el DataSet
        Dim Row As DataRow
        ' Recorremos todas las filas y las tratamos
        For Each Row In DataSet1.Tables(0).Rows
            TextBox1.Text += Row(0).ToString() & vbTab & Row(1).ToString() & vbCrLf
        Next
    End Sub

    Private Sub cmdExecutar_Click(sender As Object, e As EventArgs) Handles cmdExecutar.Click
        SqlDataAdapter1.SelectCommand.CommandText = "Select * from tbUsuarios"
        ' Abrimos la Conexión
        SqlConnection1.Open()
        ' Rellenamos el DataSet con el contenido de la instrucción SQL
        SqlDataAdapter1.Fill(DataSet1, "Ejemplo")
        ' Cerramos la Conexión
        SqlConnection1.Close()
        ' Asociamos el control DataGridView al DataSet
        DataGridView1.DataSource = DataSet1.Tables("Ejemplo")
    End Sub
End Class