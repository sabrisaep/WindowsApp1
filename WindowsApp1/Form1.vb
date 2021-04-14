Public Class Form1

    Private Sub BtnKira_Click(sender As Object, e As EventArgs) Handles BtnKira.Click
        Const intMaksima As Integer = 40
        Dim intJumlahPelajar As Integer = nudJumlahPelajar.Value
        Dim intMakmal As Integer

        intMakmal = Math.Ceiling(intJumlahPelajar / intMaksima)
        lblJumlahMakmal.Text = intMakmal.ToString & " makmal"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strNamaHari() As String = {"Ahad", "Isnin", "Selasa", "Rabu", "Khamis", "Jumaat", "Sabtu"}

        ' terbalikkan
        Array.Sort(strNamaHari)
        For X As Integer = 0 To 6
            ListBox1.Items.Add(strNamaHari(X))
        Next

        Label1.Text = "SIAP"
    End Sub
End Class
