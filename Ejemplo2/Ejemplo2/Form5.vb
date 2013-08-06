Public Class frmEnlazado

    Private Sub TbUsuariosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TbUsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PruebaDataSet)

    End Sub


    Private Sub TbUsuariosBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TbUsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PruebaDataSet)

    End Sub

    Private Sub frmEnlazado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PruebaDataSet.tbUsuarios' Puede moverla o quitarla según sea necesario.
        Me.TbUsuariosTableAdapter.Fill(Me.PruebaDataSet.tbUsuarios)

    End Sub
End Class