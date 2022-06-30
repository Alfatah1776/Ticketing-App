Public Class Lufthansa_Main_Form
    Private Sub PasengerBtn_Click(sender As Object, e As EventArgs) Handles PasengerBtn.Click
        MainCentrePanel.Controls.Clear()
        PassengerForm.TopLevel = False
        MainCentrePanel.Controls.Add(PassengerForm)
        PassengerForm.Show()
    End Sub

    'Stand alone Version
    Private Sub AdminBtn_Click(sender As Object, e As EventArgs) Handles AdminBtn.Click
        MainCentrePanel.Controls.Clear()
        AdminLogin.TopLevel = False
        MainCentrePanel.Controls.Add(AdminLogin)
        AdminLogin.Show()

        'MainCentrePanel.Controls.Clear()
        'AdminLogin.TopLevel = False
        'MainCentrePanel.Controls.Add(AdminLogin)
        'AdminLogin.Show()
    End Sub

    Private Sub ManifestBtn_Click(sender As Object, e As EventArgs) Handles ManifestBtn.Click
        MainCentrePanel.Controls.Clear()
        PassengerManifest.TopLevel = False
        MainCentrePanel.Controls.Add(PassengerManifest)
        PassengerManifest.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MainCentrePanel.Controls.Clear()
        LufthansaMainMenu.TopLevel = False
        MainCentrePanel.Controls.Add(LufthansaMainMenu)
        LufthansaMainMenu.Show()
    End Sub

    Private Sub GalleryBtn_Click(sender As Object, e As EventArgs) Handles GalleryBtn.Click
        MainCentrePanel.Controls.Clear()
        Lufthansa_Gallery.TopLevel = False
        MainCentrePanel.Controls.Add(Lufthansa_Gallery)
        Lufthansa_Gallery.Show()
    End Sub

    Private Sub TeamBtn_Click(sender As Object, e As EventArgs) Handles TeamBtn.Click
        MainCentrePanel.Controls.Clear()
        Lufthansa_Credits.TopLevel = False
        MainCentrePanel.Controls.Add(Lufthansa_Credits)
        Lufthansa_Credits.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        MainCentrePanel.Controls.Clear()
        LufthansaEasterEgg.TopLevel = False
        MainCentrePanel.Controls.Add(LufthansaEasterEgg)
        LufthansaEasterEgg.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Application.Exit()
    End Sub
End Class