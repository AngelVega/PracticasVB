Public Class Form4

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ventana As New frmEnlazado
        ventana.MdiParent = Me

        ventana.Show()
    End Sub

End Class