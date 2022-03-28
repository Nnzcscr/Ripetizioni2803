Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim string1, string2, string3, string4, stringaReplaced, stringa5 As String
        Dim length1, length2, length3 As Integer
        Dim contaa, contae, contai, contao, contau, volte, contastringa, contastringa2, contastringa3 As Integer
        string1 = txt1.Text
        string2 = txt2.Text
        string3 = txt3.Text
        length1 = string1.Length
        length2 = string2.Length
        length3 = string3.Length
        contaa = 0
        contae = 0
        contai = 0
        contau = 0
        contao = 0
        '1o punto dell'esercizio
        If length1 = length3 And length2 = length3 And length1 = length2 Then
            contaa = contaa + (length1 - string1.Replace("a", "").Length)
            contaa = contaa + (length2 - string2.Replace("a", "").Length)
            contaa = contaa + (length3 - string3.Replace("a", "").Length)
            txtcontaa.Text = contaa
            contae = contae + (length1 - string1.Replace("e", "").Length)
            contae = contae + (length2 - string2.Replace("e", "").Length)
            contae = contae + (length3 - string3.Replace("e", "").Length)
            txtcontae.Text = contae
            contai = contai + (length1 - string1.Replace("i", "").Length)
            contai = contai + (length2 - string2.Replace("i", "").Length)
            contai = contai + (length3 - string3.Replace("i", "").Length)
            txtcontai.Text = contai
            contao = contao + (length1 - string1.Replace("o", "").Length)
            contao = contao + (length2 - string2.Replace("o", "").Length)
            contao = contao + (length3 - string3.Replace("o", "").Length)
            txtcontao.Text = contao
            contau = contau + (length1 - string1.Replace("u", "").Length)
            contau = contau + (length2 - string2.Replace("u", "").Length)
            contau = contau + (length3 - string3.Replace("u", "").Length)
            txtcontau.Text = contau

            '3o punto dell'esercizio, come l'altra volta
            stringa5 = ""
            For i = 0 To length1 - 1

                stringa5 = stringa5 & string1.Substring(i, 1)
                stringa5 = stringa5 & string2.Substring(i, 1)
                stringa5 = stringa5 & string3.Substring(i, 1)
            Next
            txtoutput.Text = stringa5

            '2o punto dell'esercizio
            string4 = txt4.Text
            contastringa = 0
            contastringa2 = 0
            contastringa3 = 0
            If string4.Length < length1 And string4.Length > 0 Then
                stringaReplaced = string1.Replace(string4, "") 'sostituisco la stringa
                If stringaReplaced.Length < length1 Then 'se la stringa ottenuta è più corta di quella di partenza
                    contastringa = (length1 - stringaReplaced.Length) / string4.Length 'vuol dire che è contenuta
                End If 'quindi per vedere quante volte è presente faccio la differenza e divido
                stringaReplaced = string2.Replace(string4, "")
                If stringaReplaced.Length < length2 Then
                    contastringa2 = (length2 - stringaReplaced.Length) / string4.Length
                End If
                stringaReplaced = string3.Replace(string4, "")
                If stringaReplaced.Length < length3 Then
                    contastringa3 = (length3 - stringaReplaced.Length) / string4.Length
                End If
                txtdiv1.Text = contastringa
                txtdiv2.Text = contastringa2
                txtdiv3.Text = contastringa3
            End If
        Else
            txtcontaa.Text = "Hai"
            txtcontae.Text = "messo"
            txtcontai.Text = "stringhe"
            txtcontao.Text = "di lunghezza"
            txtcontau.Text = "diverse"
        End If


    End Sub

End Class
