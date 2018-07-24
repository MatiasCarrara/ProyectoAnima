Public Class frmHome

    Private Sub VerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerToolStripMenuItem.Click
        frmVerCliente.MdiParent = Me
        frmVerCliente.Show()

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        MsgBox("Se a cerrado sesión")

    End Sub

    Private Sub RegistrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarToolStripMenuItem.Click
        frmRegistrarCliente.MdiParent = Me
        frmRegistrarCliente.Show()

    End Sub

    Private Sub MiCuentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MiCuentaToolStripMenuItem.Click
        frmMiCuenta.MdiParent = Me
        frmMiCuenta.Show()

    End Sub

    Private Sub AñadirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AñadirToolStripMenuItem.Click
        frmRegistrarEmpleados.MdiParent = Me
        frmRegistrarEmpleados.Show()

    End Sub

    Private Sub VerToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VerToolStripMenuItem1.Click
        frmVerEmpleados.MdiParent = Me
        frmVerEmpleados.Show()

    End Sub

    Private Sub NuevoServicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoServicioToolStripMenuItem.Click
        frmServicios.MdiParent = Me
        frmServicios.Show()

    End Sub

    Private Sub FinanzasEmpresaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FinanzasEmpresaToolStripMenuItem.Click
        frmFinanzas.MdiParent = Me
        frmFinanzas.Show()

    End Sub

    Private Sub SatisfaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SatisfaciónToolStripMenuItem.Click
        frmSatisfacciones.MdiParent = Me
        frmSatisfacciones.Show()

    End Sub

    Private Sub EndimientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EndimientoToolStripMenuItem.Click
        frmRendimientoEmployes.MdiParent = Me
        frmRendimientoEmployes.Show()
    End Sub
End Class