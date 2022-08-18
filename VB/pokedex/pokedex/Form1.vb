Public Class Form1
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles displayPictureBox.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        displayPictureBox.Image = pikachuePictureBox.Image
        namelabel.Text = "pikachue"
        legslabel.Text = "4"
        hightlabel.Text = "1 foot"
        candylabel.Text = "ketchup"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        displayPictureBox.Image = squrtilePictureBox.Image
        namelabel.Text = "squirtle"
        legslabel.Text = "2"
        hightlabel.Text = "1 foot"
        candylabel.Text = "acorns"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        displayPictureBox.Image = bulbasourPictureBox.Image
        namelabel.Text = "bulbasaur"
        legslabel.Text = "4"
        hightlabel.Text = "2 foot"
        candylabel.Text = "sunlight"

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        displayPictureBox.Image = charmanderPictureBox.Image
        namelabel.Text = "charmander"
        legslabel.Text = "2"
        hightlabel.Text = "2 foot"
        candylabel.Text = "apples"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        displayPictureBox.Image = mewtwoPictureBox.Image
        namelabel.Text = "mewtwo"
        legslabel.Text = "2"
        hightlabel.Text = "6 foot"
        candylabel.Text = "oran berry"
    End Sub
End Class
