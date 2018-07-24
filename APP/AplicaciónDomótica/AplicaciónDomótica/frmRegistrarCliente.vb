Public Class frmRegistrarCliente
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        MsgBox("Se a cerrado sesión")
        Me.Close()

    End Sub

    Private Sub btnMostrarCLientes_Click(sender As Object, e As EventArgs) Handles btnMostrarCLientes.Click
        frmVerCliente.Show()
        Me.Close()
    End Sub


End Class