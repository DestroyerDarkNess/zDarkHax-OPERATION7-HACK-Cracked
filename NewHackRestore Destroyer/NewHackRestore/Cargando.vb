Public Class Cargando


#Region "bucle color by Destroyer"

    Dim Red, Blue, Yellow, White As String

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Red = Int(Rnd() * 255)
        Blue = Int(Rnd() * 255)
        Yellow = Int(Rnd() * 255)
        White = Int(Rnd() * 255)

        Label1.ForeColor = Color.FromArgb(Red, Blue, White, Yellow)
        Label2.ForeColor = Color.FromArgb(Red, Blue, White, Yellow)

    End Sub

#End Region

  Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Dim contador As Integer
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Me.contador < 100 Then
            Me.ProgressBar1.Value = Me.contador   ' error de programacion. pero bueno no me importa. este code es basura xd
            Me.contador += 1
        Else
            Me.Timer2.Enabled = False
            actualizacion.Show()
            Me.Hide()
        End If
        Me.Label4.Text = ProgressBar1.Value.ToString + " %"
    End Sub


End Class