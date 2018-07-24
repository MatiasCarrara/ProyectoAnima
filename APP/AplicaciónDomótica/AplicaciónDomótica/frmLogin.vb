Public Class frmLogin
    Dim textUsr As String = "Username"
    Dim textPwd As String = "Password"

    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim userName As String = UsernameTextBox.Text
        Dim password As String = PasswordTextBox.Text
        If userName = "" Or userName = textUsr Then
            MsgBox("Ingrese Nombre de Usuario")
        ElseIf password = "" Or password = textPwd Then
            MsgBox("Ingrese contraseña")
        ElseIf userName <> "Franco" Or password <> "12345" Then
            MsgBox("Usuario o contraseña incorrecta")
        Else
            frmHome.mnuUsuario.Text = userName
            frmMiCuenta.mnuUser.Text = userName
            frmServicios.mnuUser.Text = userName
            frmVerEmpleados.mnuUser.Text = userName
            frmRegistrarEmpleados.mnuUser.Text = userName
            frmVerCliente.mnuUser.Text = userName
            frmSatisfacciones.mnuUser.Text = userName
            frmFinanzas.mnuUser.Text = userName
            frmRegistrarCliente.mnuUser.Text = userName
            frmHome.Show()

            Me.Close()
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub UsernameTextBox_Enter(sender As Object, e As EventArgs) Handles UsernameTextBox.Enter
        UsernameTextBox.Clear()
    End Sub

    Private Sub UsernameTextBox_Leave(sender As Object, e As EventArgs) Handles UsernameTextBox.Leave
        If Trim(UsernameTextBox.Text) = "" Then
            UsernameTextBox.Text = textUsr
        End If
    End Sub

    Private Sub PasswordTextBox_Enter(sender As Object, e As EventArgs) Handles PasswordTextBox.Enter
        PasswordTextBox.Clear()
        PasswordTextBox.PasswordChar = "*"

    End Sub

    Private Sub PasswordTextBox_Leave(sender As Object, e As EventArgs) Handles PasswordTextBox.Leave
        If Trim(PasswordTextBox.Text) = "" Then
            PasswordTextBox.PasswordChar = ""
            PasswordTextBox.Text = textPwd
        End If
    End Sub

End Class
