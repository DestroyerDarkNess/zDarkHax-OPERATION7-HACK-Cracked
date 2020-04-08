Imports System.IO

Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub


#Region "bucle color by Destroyer"

    Dim Red, Blue, Yellow, White As String

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Red = Int(Rnd() * 255)
        Blue = Int(Rnd() * 255)
        Yellow = Int(Rnd() * 255)
        White = Int(Rnd() * 255)

        Label1.ForeColor = Color.FromArgb(Red, Blue, White, Yellow)
        Label2.ForeColor = Color.FromArgb(Red, Blue, White, Yellow)
        Label3.ForeColor = Color.FromArgb(Red, Blue, White, Yellow)
    End Sub

#End Region

#Region " Move Form "

    ' [ Move Form ]
    '
    ' // By Elektro 

    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles _
     Panel1.MouseDown ' Add more handles here (Example: PictureBox1.MouseDown)

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D

            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles _
    Panel1.MouseMove ' Add more handles here (Example: PictureBox1.MouseMove)

        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles _
     Panel1.MouseUp ' Add more handles here (Example: PictureBox1.MouseUp)

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If

    End Sub

#End Region

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Process.Start("https://www.youtube.com/channel/UCu4yzfdAfXW7VHzXtJb8cvw?view_as=subscriber")
    End Sub

    Private Sub Cheats_Tick(sender As Object, e As EventArgs) Handles Cheats.Tick
        If Me.Win7.Checked Then
            If Me.FullControl.Checked Then
                TRAINER.WriteInteger("OPERATION7", 14048556, 6)
            End If
            If Me.mirarapida.Checked Then
                TRAINER.WriteInteger("OPERATION7", 5536212, 74059659)
            End If
            If Me.cambiorapido.Checked Then
                TRAINER.WriteInteger("OPERATION7", 5536132, 74059659)
            End If
            If Me.recargarapida.Checked Then
                TRAINER.WriteInteger("OPERATION7", 5535749, 74058635)
            End If
            If Me.wall.Checked Then
                TRAINER.WriteInteger("OPERATION7", 14032232, 4654192)
                TRAINER.WriteInteger("OPERATION7", 14032240, 4655424)
            End If
            If Me.granadas.Checked Then
                TRAINER.WriteInteger("OPERATION7", 13994384, 5)
            End If
            If Me.norecoil.Checked Then
                TRAINER.WriteInteger("OPERATION7", 14048552, 6)
            End If
            If Me.CTHP.Checked Then
                TRAINER.WriteInteger("OPERATION7", 13994232, 19)
            End If
            If Me.CTHS.Checked Then
                TRAINER.WriteInteger("OPERATION7", 13994304, 19)
            End If
            If Me.jump.Checked Then
                TRAINER.WriteInteger("OPERATION7", 13886828, 1152851553)
            End If
            If Me.balasp.Checked Then
                TRAINER.WriteInteger("OPERATION7", 13994240, 50)
            End If
            If Me.balass.Checked Then
                TRAINER.WriteInteger("OPERATION7", 13994312, 50)
            End If
            If Me.speed.Checked Then
                TRAINER.WriteInteger("OPERATION7", 13886824, 1127805109)
            End If
            If Me.estamina.Checked Then
                TRAINER.WriteInteger("OPERATION7", 5091642, 203703299)
            End If
            If Me.rapid.Checked Then
                TRAINER.WritePointerInteger("OPERATION7", 5535915, 1340608393, New Integer(-1) {})
                TRAINER.WriteFloat("OPERATION7", 5535819, -0.000000000422115926F)
            End If
            If Me.cacha.Checked Then
                TRAINER.WriteInteger("OPERATION7", 5536021, 74058635)
            End If
            If Me.flash.Checked Then
                TRAINER.WriteInteger("OPERATION7", 14013612, 0)
            End If
            If Me.autop.Checked Then
                TRAINER.WriteInteger("OPERATION7", 13994220, 5)
            End If
            If Me.autos.Checked Then
                TRAINER.WriteInteger("OPERATION7", 13994292, 5)
            End If
            If Me.locap.Checked Then
                TRAINER.WriteInteger("OPERATION7", 13994220, 10)
            End If
            If Me.locas.Checked Then
                TRAINER.WriteInteger("OPERATION7", 13994292, 10)
            End If
        End If
        If Me.Win8.Checked Then
            If Me.FullControl.Checked Then
                TRAINER.WriteInteger("OPERATION7", 14048540, 6)
            End If
            If Me.mirarapida.Checked Then
                TRAINER.WriteInteger("OPERATION7", 5536212, 74059659)
            End If
            If Me.cambiorapido.Checked Then
                TRAINER.WriteInteger("OPERATION7", 5536132, 74059659)
            End If
            If Me.recargarapida.Checked Then
                TRAINER.WriteInteger("OPERATION7", 5535749, 74058635)
            End If
            If Me.wall.Checked Then
                TRAINER.WriteInteger("OPERATION7", 14032216, 4654192)
                TRAINER.WriteInteger("OPERATION7", 14032224, 4655424)
            End If
            If Me.granadas.Checked Then
                TRAINER.WriteInteger("OPERATION7", 13994368, 5)
            End If
            If Me.norecoil.Checked Then
                TRAINER.WriteInteger("OPERATION7", 14048536, 6)
            End If
            If Me.CTHP.Checked Then
                TRAINER.WriteInteger("OPERATION7", 13994216, 19)
            End If
            If Me.CTHS.Checked Then
                TRAINER.WriteInteger("OPERATION7", 13994288, 19)
            End If
            If Me.jump.Checked Then
                TRAINER.WriteInteger("OPERATION7", 13886812, 1152851553)
            End If
            If Me.balasp.Checked Then
                TRAINER.WriteInteger("OPERATION7", 13994224, 50)
            End If
            If Me.balass.Checked Then
                TRAINER.WriteInteger("OPERATION7", 13994296, 50)
            End If
            If Me.speed.Checked Then
                TRAINER.WriteInteger("OPERATION7", 13886808, 1127805109)
            End If
            If Me.estamina.Checked Then
                TRAINER.WriteInteger("OPERATION7", 5091642, 203703299)
            End If
            If Me.rapid.Checked Then
                TRAINER.WritePointerInteger("OPERATION7", 5535915, 1340608393, New Integer(-1) {})
                TRAINER.WriteFloat("OPERATION7", 5535819, -0.000000000422115926F)
            End If
            If Me.cacha.Checked Then
                TRAINER.WriteInteger("OPERATION7", 5536021, 74058635)
            End If
            If Me.flash.Checked Then
                TRAINER.WriteInteger("OPERATION7", 14013596, 0)
            End If
            If Me.autop.Checked Then
                TRAINER.WriteInteger("OPERATION7", 13994204, 5)
            End If
            If Me.autos.Checked Then
                TRAINER.WriteInteger("OPERATION7", 13994276, 5)
            End If
            If Me.locap.Checked Then
                TRAINER.WriteInteger("OPERATION7", 13994204, 10)
            End If
            If Me.locas.Checked Then
                TRAINER.WriteInteger("OPERATION7", 13994276, 10)
            End If
        End If
    End Sub


    Private Sub teleport_Tick(sender As Object, e As EventArgs) Handles teleport.Tick
        ' Demasiado dañado, no posible de recuperar
        ' Me.Label2.Text = Conversions.ToString(TRAINER.ReadPointerInteger("OPERATION7", 13883841, New Integer(-1) {})) ' sirve
        ' Me.Label15.Text = Conversions.ToString(TRAINER.ReadPointerInteger("OPERATION7", 13883831, New Integer(-1) {}))' sirve
        ' Me.Label17.Text = Conversions.ToString(TRAINER.ReadPointerInteger("OPERATION7", 13883835, New Integer(-1) {}))' sirve
        ' Me.Label2.Left = Me.ClientSize.Width / 2 - Me.Label17.Width / 2  'basura
        ' Me.Label15.Left = Me.ClientSize.Width / 2 - Me.Label2.Width / 2'basura
        ' Me.Label17.Left = Me.ClientSize.Width / 2 - Me.Label15.Width / 2'basura
        If TRAINER.GetAsyncKeyState(116) <> 0S Then ' deteccion de tecla y guarda posicion en los labels
            ' Me.$STATIC$teleport_Tick$20211C124D$x1 = Conversions.ToInteger(Me.Label2.Text)   'guarda pos
            ' Me.$STATIC$teleport_Tick$20211C124D$y1 = Conversions.ToInteger(Me.Label15.Text)  'guarda pos
            ' Me.$STATIC$teleport_Tick$20211C124D$z1 = Conversions.ToInteger(Me.Label17.Text)  'guarda pos
        End If
        If TRAINER.GetAsyncKeyState(117) <> 0S Then ' Deteccion de tecla, teletransporta. pos X Y Z
            ' TRAINER.WritePointerInteger("OPERATION7", 13883841, Me.$STATIC$teleport_Tick$20211C124D$x1, New Integer(-1) {})
            ' TRAINER.WritePointerInteger("OPERATION7", 13883831, Me.$STATIC$teleport_Tick$20211C124D$y1, New Integer(-1) {})
            ' TRAINER.WritePointerInteger("OPERATION7", 13883835, Me.$STATIC$teleport_Tick$20211C124D$z1, New Integer(-1) {})
        End If
    End Sub

    Private Sub Bypass_Tick(sender As Object, e As EventArgs) Handles Bypass.Tick
        On Error Resume Next
        Dim folderPath As String = System.Environment.ExpandEnvironmentVariables("%WinDir%")
        FileSystem.FileClose(New Integer() {1})
        FileSystem.FileClose(New Integer() {2})
        If My.Computer.FileSystem.FileExists(folderPath + "\xspirit.sys") Then
            FileSystem.FileOpen(1, folderPath + "\xspirit.sys", OpenMode.Append, OpenAccess.ReadWrite, OpenShare.LockReadWrite, -1)
        Else
            File.WriteAllBytes(folderPath + "\xspirit.sys", New Byte() {0})
            FileSystem.FileOpen(1, folderPath + "\xspirit.sys", OpenMode.Append, OpenAccess.ReadWrite, OpenShare.LockReadWrite, -1)
        End If
        If My.Computer.FileSystem.FileExists(folderPath + "OPERATION7.exe\xhunter1.sys") Then
            FileSystem.FileOpen(2, folderPath + "\xhunter1.sys", OpenMode.Append, OpenAccess.ReadWrite, OpenShare.LockReadWrite, -1)
        Else
            File.WriteAllBytes(folderPath + "\xhunter1.sys", New Byte() {0})
            FileSystem.FileOpen(2, folderPath + "\xhunter1.sys", OpenMode.Append, OpenAccess.ReadWrite, OpenShare.LockReadWrite, -1)
        End If
    End Sub

   
End Class
