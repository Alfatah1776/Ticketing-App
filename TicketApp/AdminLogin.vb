Public Class AdminLogin
    Private Sub BtnAdminLogin_Click(sender As Object, e As EventArgs) Handles BtnAdminLogin.Click
        If (AdminUsername.Text = "Minuteman1776" And AdminPassword.Text = "slavaukrainiheroiamslava") Then
            MsgBox("Login Successful", vbInformation, "Notification")

            AdminPanel.Controls.Clear()
            AdminForm.TopLevel = False
            AdminPanel.Controls.Add(AdminForm)
            AdminForm.Show()

            BtnAdminLogin.Visible = False
            AdminUsername.Visible = False
            AdminPassword.Visible = False
            UsernameLabel.Visible = False
            PasswordLabel.Visible = False
            AdminPictureBox.Visible = False
        Else
            MsgBox("Incorrect Username or Password", vbInformation, "Notification")
        End If
    End Sub
End Class