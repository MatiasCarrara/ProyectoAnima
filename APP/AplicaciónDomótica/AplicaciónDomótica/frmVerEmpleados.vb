Public Class frmVerEmpleados

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        MsgBox("Se a cerrado sesión")
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
            frmHome.Show()
            Me.Close()
        End Sub

        Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        regEmpleados.Items.Remove(regEmpleados.SelectedItem)
    End Sub

    Private Sub regClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles regEmpleados.SelectedIndexChanged
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        frmRegistrarCliente.Show()
        Me.Close()
    End Sub
End Class