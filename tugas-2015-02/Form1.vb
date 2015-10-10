Public Class Form1
    Dim nilai1, nilai2 As Integer
    Dim hasil As Integer
    Dim operasi As String


    Private Sub satu_Click(sender As Object, e As EventArgs) Handles satu.Click
        If hasilbox.Text = "0" Or
            hasilbox.Text = nilai1 Then
            hasilbox.Text = "1"
        Else : hasilbox.Text = hasilbox.Text & "1"
        End If
    End Sub

    Private Sub dua_Click(sender As Object, e As EventArgs) Handles dua.Click
        If hasilbox.Text = "0" Or
            hasilbox.Text = nilai1 Then
            hasilbox.Text = "2"
        Else : hasilbox.Text = hasilbox.Text & "2"
        End If
    End Sub

    Private Sub tiga_Click(sender As Object, e As EventArgs) Handles tiga.Click
        If hasilbox.Text = "0" Or
            hasilbox.Text = nilai1 Then
            hasilbox.Text = "3"
        Else : hasilbox.Text = hasilbox.Text & "3"
        End If
    End Sub

    Private Sub empat_Click(sender As Object, e As EventArgs) Handles empat.Click
        If hasilbox.Text = "0" Or
            hasilbox.Text = nilai1 Then
            hasilbox.Text = "4"
        Else : hasilbox.Text = hasilbox.Text & "4"
        End If
    End Sub

    Private Sub lima_Click(sender As Object, e As EventArgs) Handles lima.Click
        If hasilbox.Text = "0" Or
            hasilbox.Text = nilai1 Then
            hasilbox.Text = "5"
        Else : hasilbox.Text = hasilbox.Text & "5"
        End If
    End Sub

    Private Sub enam_Click(sender As Object, e As EventArgs) Handles enam.Click
        If hasilbox.Text = "0" Or
            hasilbox.Text = nilai1 Then
            hasilbox.Text = "6"
        Else : hasilbox.Text = hasilbox.Text & "6"
        End If
    End Sub

    Private Sub tujuh_Click(sender As Object, e As EventArgs) Handles tujuh.Click
        If hasilbox.Text = "0" Or
            hasilbox.Text = nilai1 Then
            hasilbox.Text = "7"
        Else : hasilbox.Text = hasilbox.Text & "7"
        End If
    End Sub

    Private Sub delapan_Click(sender As Object, e As EventArgs) Handles delapan.Click
        If hasilbox.Text = "0" Or
            hasilbox.Text = nilai1 Then
            hasilbox.Text = "8"
        Else : hasilbox.Text = hasilbox.Text & "8"
        End If
    End Sub

    Private Sub sembilan_Click(sender As Object, e As EventArgs) Handles sembilan.Click
        If hasilbox.Text = "0" Or
            hasilbox.Text = nilai1 Then
            hasilbox.Text = "9"
        Else : hasilbox.Text = hasilbox.Text & "9"
        End If
    End Sub

    Private Sub nol_Click(sender As Object, e As EventArgs) Handles nol.Click
        If hasilbox.Text = "0" Or
            hasilbox.Text = nilai1 Then
            hasilbox.Text = "0"
        Else : hasilbox.Text = hasilbox.Text & "0"
        End If
    End Sub

    Private Sub plusbutton_Click(sender As Object, e As EventArgs) Handles plusbutton.Click
        operasi = "+"
        nilai1 = Convert.ToInt32(hasilbox.Text)


    End Sub

    Private Sub minbutton_Click(sender As Object, e As EventArgs) Handles minbutton.Click
        operasi = "-"
        nilai1 = Convert.ToInt32(hasilbox.Text)
     
        
        
    End Sub

    Private Sub hasilbutton_Click(sender As Object, e As EventArgs) Handles hasilbutton.Click
        nilai2 = Convert.ToInt32(hasilbox.Text)
        If operasi = "+" Then
            hasil = nilai1 + nilai2
            hasilbox.Text = Convert.ToString(hasil)
            nilai1 = Convert.ToInt32(hasilbox.Text)
        Else : hasil = nilai1 - nilai2
            hasilbox.Text = Convert.ToString(hasil)
            nilai1 = Convert.ToInt32(hasilbox.Text)
        End If
    End Sub

    Private Sub clearbutton_Click(sender As Object, e As EventArgs) Handles clearbutton.Click
        hasilbox.Text = "0"
    End Sub
End Class
