Public Class Form1

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If (ListBox1.SelectedIndex = 0) Then
            PictureBox1.Image = My.Resources.apple
            Label2.Text = "ຫມກໂປ່ມ"
        ElseIf (ListBox1.SelectedIndex = 1) Then
            PictureBox1.Image = My.Resources.banana
            Label2.Text = "ຫມກກ້ວຍ"
        ElseIf (ListBox1.SelectedIndex = 2) Then
            PictureBox1.Image = My.Resources.orange
            Label2.Text = "ຫມາກກ້ຽງ"
        ElseIf (ListBox1.SelectedIndex = 3) Then
            PictureBox1.Image = My.Resources.coconut
            Label2.Text = "ຫມກພ້າວ"
        ElseIf (ListBox1.SelectedIndex = 4) Then
            PictureBox1.Image = My.Resources.mango
            Label2.Text = "ຫມກມ່ວງ"
        Else
            PictureBox1.Image = Nothing
            Label2.Text = "ແປລາວ"

        End If


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click





        If (ListBox1.SelectedIndex = 0) Then
            'My.Computer.Audio.Play("C:\Users\Saysomphon\Desktop\appleSound.wav")
            My.Computer.Audio.Play(My.Resources.appleSound, AudioPlayMode.Background)

        ElseIf (ListBox1.SelectedIndex = 1) Then
            My.Computer.Audio.Play(My.Resources.bananaSound, AudioPlayMode.Background)

        ElseIf (ListBox1.SelectedIndex = 2) Then
            My.Computer.Audio.Play(My.Resources.orangeSound, AudioPlayMode.Background)

        ElseIf (ListBox1.SelectedIndex = 3) Then
            My.Computer.Audio.Play(My.Resources.coconutSound, AudioPlayMode.Background)

        ElseIf (ListBox1.SelectedIndex = 4) Then
            My.Computer.Audio.Play(My.Resources.mangoSound, AudioPlayMode.Background)
        End If


    End Sub
End Class
