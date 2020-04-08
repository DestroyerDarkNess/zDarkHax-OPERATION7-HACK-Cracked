Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports NewHack.My

'###################### CRACKED BY DHANAX26 ######################

Namespace NewHack
    <DesignerGenerated()>
    Partial Public Class Form2
        Inherits Form

        Public Sub New()
            AddHandler MyBase.MouseUp, AddressOf Me.MoveForm_MouseUp
            AddHandler MyBase.MouseDown, AddressOf Me.MoveForm_MouseDown
            AddHandler MyBase.MouseMove, AddressOf Me.MoveForm_MouseMove
            Form2.__ENCAddToList(Me)
            Me.SuPerraMadre = 0
            Me.HolaEkisde = 0
            Me.Proceso = "OPERATION7"
            Me.InitializeComponent()
        End Sub

        <DebuggerNonUserCode()>
        Private Shared Sub __ENCAddToList(value As Object)
            Dim _ENCList As List(Of WeakReference) = Form2.__ENCList
            SyncLock _ENCList
                If Form2.__ENCList.Count = Form2.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = 0
                    Dim num3 As Integer = Form2.__ENCList.Count - 1
                    Dim num4 As Integer = num2
                    While True
                        Dim num5 As Integer = num4
                        Dim num6 As Integer = num3
                        If num5 > num6 Then
                            Exit For
                        End If
                        Dim weakReference As WeakReference = Form2.__ENCList(num4)
                        If weakReference.IsAlive Then
                            If num4 <> num Then
                                Form2.__ENCList(num) = Form2.__ENCList(num4)
                            End If
                            num += 1
                        End If
                        num4 += 1
                    End While
                    Form2.__ENCList.RemoveRange(num, Form2.__ENCList.Count - num)
                    Form2.__ENCList.Capacity = Form2.__ENCList.Count
                End If
                Form2.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Friend Overridable Property Bypass As Timer
            <DebuggerNonUserCode()>
            Get
                Return Me._Bypass
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As Timer)
                Dim value2 As EventHandler = AddressOf Me.Bypass_Tick
                If Me._Bypass IsNot Nothing Then
                    RemoveHandler Me._Bypass.Tick, value2
                End If
                Me._Bypass = value
                If Me._Bypass IsNot Nothing Then
                    AddHandler Me._Bypass.Tick, value2
                End If
            End Set
        End Property

        Friend Overridable Property Cheats As Timer
            <DebuggerNonUserCode()>
            Get
                Return Me._Cheats
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As Timer)
                Dim value2 As EventHandler = AddressOf Me.Cheats_Tick
                If Me._Cheats IsNot Nothing Then
                    RemoveHandler Me._Cheats.Tick, value2
                End If
                Me._Cheats = value
                If Me._Cheats IsNot Nothing Then
                    AddHandler Me._Cheats.Tick, value2
                End If
            End Set
        End Property

        Friend Overridable Property cambiorapido As CheckBox
            <DebuggerNonUserCode()>
            Get
                Return Me._cambiorapido
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As CheckBox)
                Me._cambiorapido = value
            End Set
        End Property

        Friend Overridable Property mirarapida As CheckBox
            <DebuggerNonUserCode()>
            Get
                Return Me._mirarapida
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As CheckBox)
                Me._mirarapida = value
            End Set
        End Property

        Friend Overridable Property FullControl As CheckBox
            <DebuggerNonUserCode()>
            Get
                Return Me._FullControl
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As CheckBox)
                Me._FullControl = value
            End Set
        End Property

        Friend Overridable Property wall As CheckBox
            <DebuggerNonUserCode()>
            Get
                Return Me._wall
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As CheckBox)
                Me._wall = value
            End Set
        End Property

        Friend Overridable Property recargarapida As CheckBox
            <DebuggerNonUserCode()>
            Get
                Return Me._recargarapida
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As CheckBox)
                Me._recargarapida = value
            End Set
        End Property

        Friend Overridable Property norecoil As CheckBox
            <DebuggerNonUserCode()>
            Get
                Return Me._norecoil
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As CheckBox)
                Me._norecoil = value
            End Set
        End Property

        Friend Overridable Property granadas As CheckBox
            <DebuggerNonUserCode()>
            Get
                Return Me._granadas
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As CheckBox)
                Me._granadas = value
            End Set
        End Property

        Friend Overridable Property Win8 As CheckBox
            <DebuggerNonUserCode()>
            Get
                Return Me._Win8
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As CheckBox)
                Me._Win8 = value
            End Set
        End Property

        Friend Overridable Property Win7 As CheckBox
            <DebuggerNonUserCode()>
            Get
                Return Me._Win7
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As CheckBox)
                Me._Win7 = value
            End Set
        End Property

        Friend Overridable Property Button1 As Button
            <DebuggerNonUserCode()>
            Get
                Return Me._Button1
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As Button)
                Dim value2 As EventHandler = AddressOf Me.Button1_Click
                If Me._Button1 IsNot Nothing Then
                    RemoveHandler Me._Button1.Click, value2
                End If
                Me._Button1 = value
                If Me._Button1 IsNot Nothing Then
                    AddHandler Me._Button1.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property Label1 As Label
            <DebuggerNonUserCode()>
            Get
                Return Me._Label1
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As Label)
                Me._Label1 = value
            End Set
        End Property

        Friend Overridable Property Button4 As Button
            <DebuggerNonUserCode()>
            Get
                Return Me._Button4
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As Button)
                Dim value2 As EventHandler = AddressOf Me.Button4_Click
                If Me._Button4 IsNot Nothing Then
                    RemoveHandler Me._Button4.Click, value2
                End If
                Me._Button4 = value
                If Me._Button4 IsNot Nothing Then
                    AddHandler Me._Button4.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property Label3 As Label
            <DebuggerNonUserCode()>
            Get
                Return Me._Label3
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As Label)
                Me._Label3 = value
            End Set
        End Property

        Friend Overridable Property Label5 As Label
            <DebuggerNonUserCode()>
            Get
                Return Me._Label5
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As Label)
                Me._Label5 = value
            End Set
        End Property

        Friend Overridable Property Label6 As Label
            <DebuggerNonUserCode()>
            Get
                Return Me._Label6
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As Label)
                Me._Label6 = value
            End Set
        End Property

        Friend Overridable Property Label7 As Label
            <DebuggerNonUserCode()>
            Get
                Return Me._Label7
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As Label)
                Me._Label7 = value
            End Set
        End Property

        Friend Overridable Property Label8 As Label
            <DebuggerNonUserCode()>
            Get
                Return Me._Label8
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As Label)
                Me._Label8 = value
            End Set
        End Property

        Friend Overridable Property Label9 As Label
            <DebuggerNonUserCode()>
            Get
                Return Me._Label9
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As Label)
                Me._Label9 = value
            End Set
        End Property

        Friend Overridable Property Label10 As Label
            <DebuggerNonUserCode()>
            Get
                Return Me._Label10
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As Label)
                Me._Label10 = value
            End Set
        End Property

        Friend Overridable Property Timer1 As Timer
            <DebuggerNonUserCode()>
            Get
                Return Me._Timer1
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As Timer)
                Dim value2 As EventHandler = AddressOf Me.Timer1_Tick
                If Me._Timer1 IsNot Nothing Then
                    RemoveHandler Me._Timer1.Tick, value2
                End If
                Me._Timer1 = value
                If Me._Timer1 IsNot Nothing Then
                    AddHandler Me._Timer1.Tick, value2
                End If
            End Set
        End Property

        Friend Overridable Property Label11 As Label
            <DebuggerNonUserCode()>
            Get
                Return Me._Label11
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As Label)
                Me._Label11 = value
            End Set
        End Property

        Friend Overridable Property Label12 As Label
            <DebuggerNonUserCode()>
            Get
                Return Me._Label12
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As Label)
                Me._Label12 = value
            End Set
        End Property

        Friend Overridable Property Timer3 As Timer
            <DebuggerNonUserCode()>
            Get
                Return Me._Timer3
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As Timer)
                Dim value2 As EventHandler = AddressOf Me.Timer3_Tick
                If Me._Timer3 IsNot Nothing Then
                    RemoveHandler Me._Timer3.Tick, value2
                End If
                Me._Timer3 = value
                If Me._Timer3 IsNot Nothing Then
                    AddHandler Me._Timer3.Tick, value2
                End If
            End Set
        End Property

        Friend Overridable Property reloj As Timer
            <DebuggerNonUserCode()>
            Get
                Return Me._reloj
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As Timer)
                Dim value2 As EventHandler = AddressOf Me.reloj_Tick
                If Me._reloj IsNot Nothing Then
                    RemoveHandler Me._reloj.Tick, value2
                End If
                Me._reloj = value
                If Me._reloj IsNot Nothing Then
                    AddHandler Me._reloj.Tick, value2
                End If
            End Set
        End Property

        Friend Overridable Property reloj2 As Timer
            <DebuggerNonUserCode()>
            Get
                Return Me._reloj2
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As Timer)
                Dim value2 As EventHandler = AddressOf Me.reloj2_Tick
                If Me._reloj2 IsNot Nothing Then
                    RemoveHandler Me._reloj2.Tick, value2
                End If
                Me._reloj2 = value
                If Me._reloj2 IsNot Nothing Then
                    AddHandler Me._reloj2.Tick, value2
                End If
            End Set
        End Property

        Friend Overridable Property Label13 As Label
            <DebuggerNonUserCode()>
            Get
                Return Me._Label13
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As Label)
                Me._Label13 = value
            End Set
        End Property

        Friend Overridable Property Label4 As Label
            <DebuggerNonUserCode()>
            Get
                Return Me._Label4
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As Label)
                Me._Label4 = value
            End Set
        End Property

        Friend Overridable Property GroupBox1 As GroupBox
            <DebuggerNonUserCode()>
            Get
                Return Me._GroupBox1
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As GroupBox)
                Me._GroupBox1 = value
            End Set
        End Property

        Friend Overridable Property CTHP As CheckBox
            <DebuggerNonUserCode()>
            Get
                Return Me._CTHP
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As CheckBox)
                Me._CTHP = value
            End Set
        End Property

        Friend Overridable Property CTHS As CheckBox
            <DebuggerNonUserCode()>
            Get
                Return Me._CTHS
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As CheckBox)
                Me._CTHS = value
            End Set
        End Property

        Friend Overridable Property jump As CheckBox
            <DebuggerNonUserCode()>
            Get
                Return Me._jump
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As CheckBox)
                Me._jump = value
            End Set
        End Property

        Friend Overridable Property balasp As CheckBox
            <DebuggerNonUserCode()>
            Get
                Return Me._balasp
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As CheckBox)
                Me._balasp = value
            End Set
        End Property

        Friend Overridable Property balass As CheckBox
            <DebuggerNonUserCode()>
            Get
                Return Me._balass
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As CheckBox)
                Me._balass = value
            End Set
        End Property
        Friend Overridable Property Label16 As Label
            <DebuggerNonUserCode()>
            Get
                Return Me._Label16
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As Label)
                Me._Label16 = value
            End Set
        End Property

        Friend Overridable Property Label18 As Label
            <DebuggerNonUserCode()>
            Get
                Return Me._Label18
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As Label)
                Me._Label18 = value
            End Set
        End Property

        Friend Overridable Property Label19 As Label
            <DebuggerNonUserCode()>
            Get
                Return Me._Label19
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As Label)
                Me._Label19 = value
            End Set
        End Property

        Friend Overridable Property Label14 As Label
            <DebuggerNonUserCode()>
            Get
                Return Me._Label14
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As Label)
                Me._Label14 = value
            End Set
        End Property

        Friend Overridable Property Label20 As Label
            <DebuggerNonUserCode()>
            Get
                Return Me._Label20
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As Label)
                Me._Label20 = value
            End Set
        End Property

        Friend Overridable Property Timer2 As Timer
            <DebuggerNonUserCode()>
            Get
                Return Me._Timer2
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As Timer)
                Dim value2 As EventHandler = AddressOf Me.Timer2_Tick
                If Me._Timer2 IsNot Nothing Then
                    RemoveHandler Me._Timer2.Tick, value2
                End If
                Me._Timer2 = value
                If Me._Timer2 IsNot Nothing Then
                    AddHandler Me._Timer2.Tick, value2
                End If
            End Set
        End Property

        Friend Overridable Property speed As CheckBox
            <DebuggerNonUserCode()>
            Get
                Return Me._speed
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As CheckBox)
                Me._speed = value
            End Set
        End Property

        Friend Overridable Property estamina As CheckBox
            <DebuggerNonUserCode()>
            Get
                Return Me._estamina
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As CheckBox)
                Me._estamina = value
            End Set
        End Property

        Friend Overridable Property rapid As CheckBox
            <DebuggerNonUserCode()>
            Get
                Return Me._rapid
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As CheckBox)
                Me._rapid = value
            End Set
        End Property

        Friend Overridable Property cacha As CheckBox
            <DebuggerNonUserCode()>
            Get
                Return Me._cacha
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As CheckBox)
                Me._cacha = value
            End Set
        End Property

        Friend Overridable Property flash As CheckBox
            <DebuggerNonUserCode()>
            Get
                Return Me._flash
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As CheckBox)
                Me._flash = value
            End Set
        End Property

        Friend Overridable Property autop As CheckBox
            <DebuggerNonUserCode()>
            Get
                Return Me._autop
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As CheckBox)
                Me._autop = value
            End Set
        End Property

        Friend Overridable Property autos As CheckBox
            <DebuggerNonUserCode()>
            Get
                Return Me._autos
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As CheckBox)
                Me._autos = value
            End Set
        End Property

        Friend Overridable Property teleport As Timer
            <DebuggerNonUserCode()>
            Get
                Return Me._teleport
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As Timer)
                Dim value2 As EventHandler = AddressOf Me.teleport_Tick
                If Me._teleport IsNot Nothing Then
                    RemoveHandler Me._teleport.Tick, value2
                End If
                Me._teleport = value
                If Me._teleport IsNot Nothing Then
                    AddHandler Me._teleport.Tick, value2
                End If
            End Set
        End Property

        Friend Overridable Property Label2 As Label
            <DebuggerNonUserCode()>
            Get
                Return Me._Label2
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As Label)
                Me._Label2 = value
            End Set
        End Property

        Friend Overridable Property Label15 As Label
            <DebuggerNonUserCode()>
            Get
                Return Me._Label15
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As Label)
                Me._Label15 = value
            End Set
        End Property

        Friend Overridable Property Label17 As Label
            <DebuggerNonUserCode()>
            Get
                Return Me._Label17
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As Label)
                Me._Label17 = value
            End Set
        End Property

        Friend Overridable Property GroupBox3 As GroupBox
            <DebuggerNonUserCode()>
            Get
                Return Me._GroupBox3
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As GroupBox)
                Me._GroupBox3 = value
            End Set
        End Property

        Friend Overridable Property Label21 As Label
            <DebuggerNonUserCode()>
            Get
                Return Me._Label21
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As Label)
                Me._Label21 = value
            End Set
        End Property

        Friend Overridable Property Label22 As Label
            <DebuggerNonUserCode()>
            Get
                Return Me._Label22
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As Label)
                Me._Label22 = value
            End Set
        End Property
        Friend Overridable Property locap As CheckBox
            <DebuggerNonUserCode()>
            Get
                Return Me._locap
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As CheckBox)
                Me._locap = value
            End Set
        End Property

        Friend Overridable Property locas As CheckBox
            <DebuggerNonUserCode()>
            Get
                Return Me._locas
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As CheckBox)
                Me._locas = value
            End Set
        End Property

        <MethodImpl(MethodImplOptions.NoInlining Or MethodImplOptions.NoOptimization)>
        Private Sub Bypass_Tick(sender As Object, e As EventArgs)
            Try
                Dim folderPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Windows)
                FileSystem.FileClose(New Integer() {1})
                FileSystem.FileClose(New Integer() {2})
                If MyProject.Computer.FileSystem.FileExists(folderPath + "\xspirit.sys") Then
                    FileSystem.FileOpen(1, folderPath + "\xspirit.sys", OpenMode.Append, OpenAccess.ReadWrite, OpenShare.LockReadWrite, -1)
                Else
                    File.WriteAllBytes(folderPath + "\xspirit.sys", New Byte() {0})
                    FileSystem.FileOpen(1, folderPath + "\xspirit.sys", OpenMode.Append, OpenAccess.ReadWrite, OpenShare.LockReadWrite, -1)
                End If
                If MyProject.Computer.FileSystem.FileExists(folderPath + "OPERATION7.exe\xhunter1.sys") Then
                    FileSystem.FileOpen(2, folderPath + "\xhunter1.sys", OpenMode.Append, OpenAccess.ReadWrite, OpenShare.LockReadWrite, -1)
                Else
                    File.WriteAllBytes(folderPath + "\xhunter1.sys", New Byte() {0})
                    FileSystem.FileOpen(2, folderPath + "\xhunter1.sys", OpenMode.Append, OpenAccess.ReadWrite, OpenShare.LockReadWrite, -1)
                End If
            Catch ex As Exception
            End Try
            Me.Bypass.Start()
        End Sub

        Private Sub Cheats_Tick(sender As Object, e As EventArgs)
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

        Private Sub Button1_Click(sender As Object, e As EventArgs)
            Me.Close()
        End Sub

        Private Sub Button4_Click(sender As Object, e As EventArgs)
            Process.Start("https://www.youtube.com/channel/UCu4yzfdAfXW7VHzXtJb8cvw?view_as=subscriber")
        End Sub

        Private Sub Timer1_Tick(sender As Object, e As EventArgs)
            Me.$STATIC$Timer1_Tick$20211C124D$C += 1
			If Me.$STATIC$Timer1_Tick$20211C124D$C = 1 Then
                Me.Label5.ForeColor = Color.Red
            ElseIf Me.$STATIC$Timer1_Tick$20211C124D$C = 2 Then
                Me.Label5.ForeColor = Color.Blue
            ElseIf Me.$STATIC$Timer1_Tick$20211C124D$C = 3 Then
                Me.Label5.ForeColor = Color.Yellow
            ElseIf Me.$STATIC$Timer1_Tick$20211C124D$C = 4 Then
                Me.Label5.ForeColor = Color.White
            Else
                Me.$STATIC$Timer1_Tick$20211C124D$C = 5
                Me.$STATIC$Timer1_Tick$20211C124D$C = 0
            End If
        End Sub

        Private Sub Timer3_Tick(sender As Object, e As EventArgs)
            Me.$STATIC$Timer3_Tick$20211C124D$C += 1
			If Me.$STATIC$Timer3_Tick$20211C124D$C = 1 Then
                Me.Label3.ForeColor = Color.Red
            ElseIf Me.$STATIC$Timer3_Tick$20211C124D$C = 2 Then
                Me.Label3.ForeColor = Color.Blue
            ElseIf Me.$STATIC$Timer3_Tick$20211C124D$C = 3 Then
                Me.Label3.ForeColor = Color.Yellow
            ElseIf Me.$STATIC$Timer3_Tick$20211C124D$C = 4 Then
                Me.Label3.ForeColor = Color.White
            Else
                Me.$STATIC$Timer3_Tick$20211C124D$C = 5
                Me.$STATIC$Timer3_Tick$20211C124D$C = 0
            End If
        End Sub

        Private Sub reloj_Tick(sender As Object, e As EventArgs)
            Me.Label9.Text = Strings.Format(DateAndTime.TimeOfDay, "hh") + ":"
            Me.Label10.Text = Strings.Format(DateAndTime.TimeOfDay, "mm")
            Me.Label11.Text = Strings.Format(DateAndTime.TimeOfDay, "ss")
        End Sub

        Private Sub reloj2_Tick(sender As Object, e As EventArgs)
            If Conversion.Val(Me.Label9.Text) > 12.0 Then
                Me.Label12.Text = "AM"
            Else
                Me.Label12.Text = "PM"
            End If
        End Sub

        Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs)
            If e.Button = MouseButtons.Left Then
                Me.MoveForm = True
                Me.Cursor = Cursors.NoMove2D
                Me.MoveForm_MousePosition = e.Location
            End If
        End Sub

        Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs)
            If Me.MoveForm Then
                Me.Location += CType((e.Location - CType(Me.MoveForm_MousePosition, Size)), Size)
            End If
        End Sub

        Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs)
            If e.Button = MouseButtons.Left Then
                Me.MoveForm = False
                Me.Cursor = Cursors.[Default]
            End If
        End Sub

        Private Sub Timer2_Tick(sender As Object, e As EventArgs)
            Me.$STATIC$Timer2_Tick$20211C124D$C += 1
			If Me.$STATIC$Timer2_Tick$20211C124D$C = 1 Then
                Me.Label20.ForeColor = Color.Red
            ElseIf Me.$STATIC$Timer2_Tick$20211C124D$C = 2 Then
                Me.Label20.ForeColor = Color.Blue
            ElseIf Me.$STATIC$Timer2_Tick$20211C124D$C = 3 Then
                Me.Label20.ForeColor = Color.Yellow
            ElseIf Me.$STATIC$Timer2_Tick$20211C124D$C = 4 Then
                Me.Label20.ForeColor = Color.White
            Else
                Me.$STATIC$Timer2_Tick$20211C124D$C = 5
                Me.$STATIC$Timer2_Tick$20211C124D$C = 0
            End If
        End Sub

        Private Sub teleport_Tick(sender As Object, e As EventArgs)
            Me.Label2.Text = Conversions.ToString(TRAINER.ReadPointerInteger("OPERATION7", 13883841, New Integer(-1) {}))
            Me.Label15.Text = Conversions.ToString(TRAINER.ReadPointerInteger("OPERATION7", 13883831, New Integer(-1) {}))
            Me.Label17.Text = Conversions.ToString(TRAINER.ReadPointerInteger("OPERATION7", 13883835, New Integer(-1) {}))
            Me.Label2.Left = Me.ClientSize.Width / 2 - Me.Label17.Width / 2
            Me.Label15.Left = Me.ClientSize.Width / 2 - Me.Label2.Width / 2
            Me.Label17.Left = Me.ClientSize.Width / 2 - Me.Label15.Width / 2
            If TRAINER.GetAsyncKeyState(116) <> 0S Then
                Me.$STATIC$teleport_Tick$20211C124D$x1 = Conversions.ToInteger(Me.Label2.Text)
                Me.$STATIC$teleport_Tick$20211C124D$y1 = Conversions.ToInteger(Me.Label15.Text)
                Me.$STATIC$teleport_Tick$20211C124D$z1 = Conversions.ToInteger(Me.Label17.Text)
            End If
            If TRAINER.GetAsyncKeyState(117) <> 0S Then
                TRAINER.WritePointerInteger("OPERATION7", 13883841, Me.$STATIC$teleport_Tick$20211C124D$x1, New Integer(-1) {})
                TRAINER.WritePointerInteger("OPERATION7", 13883831, Me.$STATIC$teleport_Tick$20211C124D$y1, New Integer(-1) {})
                TRAINER.WritePointerInteger("OPERATION7", 13883835, Me.$STATIC$teleport_Tick$20211C124D$z1, New Integer(-1) {})
            End If
        End Sub

        Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

        <AccessedThroughProperty("Bypass")>
        Private _Bypass As Timer

        <AccessedThroughProperty("Cheats")>
        Private _Cheats As Timer

        <AccessedThroughProperty("cambiorapido")>
        Private _cambiorapido As CheckBox

        <AccessedThroughProperty("mirarapida")>
        Private _mirarapida As CheckBox

        <AccessedThroughProperty("FullControl")>
        Private _FullControl As CheckBox

        <AccessedThroughProperty("wall")>
        Private _wall As CheckBox

        <AccessedThroughProperty("recargarapida")>
        Private _recargarapida As CheckBox

        <AccessedThroughProperty("norecoil")>
        Private _norecoil As CheckBox

        <AccessedThroughProperty("granadas")>
        Private _granadas As CheckBox

        <AccessedThroughProperty("Win8")>
        Private _Win8 As CheckBox

        <AccessedThroughProperty("Win7")>
        Private _Win7 As CheckBox

        <AccessedThroughProperty("Button1")>
        Private _Button1 As Button

        <AccessedThroughProperty("Label1")>
        Private _Label1 As Label

        <AccessedThroughProperty("Button4")>
        Private _Button4 As Button

        <AccessedThroughProperty("Label3")>
        Private _Label3 As Label

        <AccessedThroughProperty("Label5")>
        Private _Label5 As Label

        <AccessedThroughProperty("Label6")>
        Private _Label6 As Label

        <AccessedThroughProperty("Label7")>
        Private _Label7 As Label

        <AccessedThroughProperty("Label8")>
        Private _Label8 As Label

        <AccessedThroughProperty("Label9")>
        Private _Label9 As Label

        <AccessedThroughProperty("Label10")>
        Private _Label10 As Label

        <AccessedThroughProperty("Timer1")>
        Private _Timer1 As Timer

        <AccessedThroughProperty("Label11")>
        Private _Label11 As Label

        <AccessedThroughProperty("Label12")>
        Private _Label12 As Label

        <AccessedThroughProperty("Timer3")>
        Private _Timer3 As Timer

        <AccessedThroughProperty("reloj")>
        Private _reloj As Timer

        <AccessedThroughProperty("reloj2")>
        Private _reloj2 As Timer

        <AccessedThroughProperty("Label13")>
        Private _Label13 As Label

        <AccessedThroughProperty("Label4")>
        Private _Label4 As Label

        <AccessedThroughProperty("GroupBox1")>
        Private _GroupBox1 As GroupBox

        <AccessedThroughProperty("CTHP")>
        Private _CTHP As CheckBox

        <AccessedThroughProperty("CTHS")>
        Private _CTHS As CheckBox

        <AccessedThroughProperty("jump")>
        Private _jump As CheckBox

        <AccessedThroughProperty("balasp")>
        Private _balasp As CheckBox

        <AccessedThroughProperty("balass")>
        Private _balass As CheckBox

        <AccessedThroughProperty("Label16")>
        Private _Label16 As Label

        <AccessedThroughProperty("Label18")>
        Private _Label18 As Label

        <AccessedThroughProperty("Label19")>
        Private _Label19 As Label

        <AccessedThroughProperty("Label14")>
        Private _Label14 As Label

        <AccessedThroughProperty("Label20")>
        Private _Label20 As Label

        <AccessedThroughProperty("Timer2")>
        Private _Timer2 As Timer

        <AccessedThroughProperty("speed")>
        Private _speed As CheckBox

        <AccessedThroughProperty("estamina")>
        Private _estamina As CheckBox

        <AccessedThroughProperty("rapid")>
        Private _rapid As CheckBox

        <AccessedThroughProperty("cacha")>
        Private _cacha As CheckBox

        <AccessedThroughProperty("flash")>
        Private _flash As CheckBox

        <AccessedThroughProperty("autop")>
        Private _autop As CheckBox

        <AccessedThroughProperty("autos")>
        Private _autos As CheckBox

        <AccessedThroughProperty("teleport")>
        Private _teleport As Timer

        <AccessedThroughProperty("Label2")>
        Private _Label2 As Label

        <AccessedThroughProperty("Label15")>
        Private _Label15 As Label

        <AccessedThroughProperty("Label17")>
        Private _Label17 As Label

        <AccessedThroughProperty("GroupBox3")>
        Private _GroupBox3 As GroupBox

        <AccessedThroughProperty("Label21")>
        Private _Label21 As Label

        <AccessedThroughProperty("Label22")>
        Private _Label22 As Label

        <AccessedThroughProperty("locap")>
        Private _locap As CheckBox

        <AccessedThroughProperty("locas")>
        Private _locas As CheckBox

        Private px As Integer

        Private py As Integer

        Private mover As Boolean

        Private SuPerraMadre As Integer

        Private HolaEkisde As Integer

        Private Proceso As String

        Public MoveForm As Boolean

        Public MoveForm_MousePosition As Point

        Private $STATIC$teleport_Tick$20211C124D$x1 As Integer

		Private $STATIC$teleport_Tick$20211C124D$y1 As Integer

		Private $STATIC$teleport_Tick$20211C124D$z1 As Integer

		Private $STATIC$Timer1_Tick$20211C124D$C As Integer

		Private $STATIC$Timer3_Tick$20211C124D$C As Integer

		Private $STATIC$Timer2_Tick$20211C124D$C As Integer

        Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub
    End Class
End Namespace
