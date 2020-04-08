Imports System.Net

Public Class actualizacion

    Private Sub actualizacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim webClient As WebClient = New WebClient()
            Dim left As String = webClient.DownloadString("https://www.dropbox.com/s/nopysfrhlc43g9k/Version.txt?dl=1")
            If left <= 0 Then
                ' Me.Recv.Text = "Indectetable"
                ' Me.Recv.ForeColor = Color.Green
                MessageBox.Show("Hack totalmente seguro, Puedes utilizarlo", "zDarkHax", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Else
                ' Me.Recv.Text = "Detectado"
                'Me.Recv.ForeColor = Color.Red
                If MessageBox.Show("Hack detectado; Por favor Borre Esta Version Por Seguridad y Descargue La Nueva Version que saldra en mi canal", "zDarkHax", MessageBoxButtons.OK, MessageBoxIcon.Hand) = Windows.Forms.DialogResult.OK Then
                    Process.Start("https://www.youtube.com/channel/UCu4yzfdAfXW7VHzXtJb8cvw?view_as=subscriber")
                    Me.Close()
                End If

                '  Me.Button1.Enabled = False
                '  Me.Close()
            End If
        Catch ex As Exception
            Me.Close()
            ' error de programacion, por ejemplo si desconectas la pc del internet puedes usar el hack gracias a esto.
            ' MessageBox.Show("¡Disfrute Del Hack!", "zDarkHax", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("Hack totalmente seguro, Puedes utilizarlo", "zDarkHax", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Form2.Show()
        Me.Hide()
    End Sub

End Class