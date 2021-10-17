Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim browseimage As New OpenFileDialog
        browseimage.Filter = "image Filter |*.jpg;*.jpeg*.png"

        If browseimage.ShowDialog() = Windows.Forms.DialogResult.OK Then
            asli.Image = Image.FromFile(browseimage.FileName)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim gambar As New Bitmap(asli.Image)
        Dim merah, hijau, biru, abu As Integer

        For x As Integer = 0 To gambar.Width - 1
            For y As Integer = 0 To gambar.Height - 1
                merah = gambar.GetPixel(x, y).R
                hijau = gambar.GetPixel(x, y).G
                biru = gambar.GetPixel(x, y).B
                abu = ((merah + hijau + biru) / 3)

                gambar.SetPixel(x, y, Color.FromArgb(abu, abu, abu))

                gray.Image = gambar
            Next
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim savefile As New SaveFileDialog
        savefile.Filter = "image Filter|.jpg;.jpeg;.png;.JPG;"

        If savefile.ShowDialog() = Windows.Forms.DialogResult.OK Then
            gray.Image.Save(savefile.FileName)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim gambar As New Bitmap(asli.Image)
        Dim merah, hijau, biru, abu As Integer

        For x As Integer = 0 To gambar.Width - 1
            For y As Integer = 0 To gambar.Height - 1
                merah = gambar.GetPixel(x, y).R
                hijau = gambar.GetPixel(x, y).G
                biru = gambar.GetPixel(x, y).B
                abu = ((merah + hijau + biru) / 3)
                If abu < 128 Then
                    gambar.SetPixel(x, y, Color.FromArgb(0, 0, 0))
                Else
                    gambar.SetPixel(x, y, Color.FromArgb(abu, abu, abu))
                End If

                biner.Image = gambar
            Next
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim savefile As New SaveFileDialog
        savefile.Filter = "image Filter|.jpg;.jpeg;.png;.JPG;"

        If savefile.ShowDialog() = Windows.Forms.DialogResult.OK Then
            biner.Image.Save(savefile.FileName)
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        asli.Image = Nothing
        gray.Image = Nothing
        biner.Image = Nothing
    End Sub
End Class
