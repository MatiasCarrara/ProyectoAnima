Public Class frmRegistrarEmpleados
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        MsgBox("Se a cerrado sesión")
        Me.Close()

    End Sub
    Private Sub btnMostrarEmpleados_Click(sender As Object, e As EventArgs) Handles btnMostrarEmpleados.Click
        frmVerEmpleados.Show()
        Me.Close()
    End Sub

End Class