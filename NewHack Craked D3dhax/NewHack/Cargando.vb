Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices
Imports NewHack.My

'###################### CRACKED BY DHANAX26 ######################

Namespace NewHack
    <DesignerGenerated()>
    Partial Public Class Cargando
        Inherits Form

        <DebuggerNonUserCode()>
        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.Cargando_Load
            Cargando.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <DebuggerNonUserCode()>
        Private Shared Sub __ENCAddToList(value As Object)
            Dim _ENCList As List(Of WeakReference) = Cargando.__ENCList
            SyncLock _ENCList
                If Cargando.__ENCList.Count = Cargando.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = 0
                    Dim num3 As Integer = Cargando.__ENCList.Count - 1
                    Dim num4 As Integer = num2
                    While True
                        Dim num5 As Integer = num4
                        Dim num6 As Integer = num3
                        If num5 > num6 Then
                            Exit For
                        End If
                        Dim weakReference As WeakReference = Cargando.__ENCList(num4)
                        If weakReference.IsAlive Then
                            If num4 <> num Then
                                Cargando.__ENCList(num) = Cargando.__ENCList(num4)
                            End If
                            num += 1
                        End If
                        num4 += 1
                    End While
                    Cargando.__ENCList.RemoveRange(num, Cargando.__ENCList.Count - num)
                    Cargando.__ENCList.Capacity = Cargando.__ENCList.Count
                End If
                Cargando.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Friend Overridable Property ProgressBar1 As ProgressBar
            <DebuggerNonUserCode()>
            Get
                Return Me._ProgressBar1
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As ProgressBar)
                Dim value2 As EventHandler = AddressOf Me.ProgressBar1_Click
                If Me._ProgressBar1 IsNot Nothing Then
                    RemoveHandler Me._ProgressBar1.Click, value2
                End If
                Me._ProgressBar1 = value
                If Me._ProgressBar1 IsNot Nothing Then
                    AddHandler Me._ProgressBar1.Click, value2
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

        Private Sub ProgressBar1_Click(sender As Object, e As EventArgs)
            Me.ProgressBar1.Value = 0
            Me.ProgressBar1.Maximum = 100
            Me.Timer1.Interval = 40
            Me.Timer1.Enabled = True
        End Sub

        Private Sub Timer1_Tick(sender As Object, e As EventArgs)
            If Me.contador < 100 Then
                Me.ProgressBar1.Value = Me.contador
                Me.contador += 1
            Else
                Me.Timer1.Enabled = False
                MyProject.Forms.actualizacion.Show()
                Me.Close()
            End If
            Me.Label3.Text = Conversions.ToString(Me.ProgressBar1.Value) + " %"
            Me.Label2.Text = "Cargando Hack Espera Un Momento"
        End Sub

        Private Sub Button1_Click(sender As Object, e As EventArgs)
            Me.Close()
        End Sub

        Private Sub Timer2_Tick(sender As Object, e As EventArgs)
            Me.$STATIC$Timer2_Tick$20211C124D$C += 1
			If Me.$STATIC$Timer2_Tick$20211C124D$C = 1 Then
                Me.Label1.ForeColor = Color.Red
            ElseIf Me.$STATIC$Timer2_Tick$20211C124D$C = 2 Then
                Me.Label1.ForeColor = Color.Blue
            ElseIf Me.$STATIC$Timer2_Tick$20211C124D$C = 3 Then
                Me.Label1.ForeColor = Color.Yellow
            ElseIf Me.$STATIC$Timer2_Tick$20211C124D$C = 4 Then
                Me.Label1.ForeColor = Color.White
            Else
                Me.$STATIC$Timer2_Tick$20211C124D$C = 5
                Me.$STATIC$Timer2_Tick$20211C124D$C = 0
            End If
        End Sub

        Private Sub Timer3_Tick(sender As Object, e As EventArgs)
            Me.$STATIC$Timer3_Tick$20211C124D$C += 1
			If Me.$STATIC$Timer3_Tick$20211C124D$C = 1 Then
                Me.Label4.ForeColor = Color.Red
            ElseIf Me.$STATIC$Timer3_Tick$20211C124D$C = 2 Then
                Me.Label4.ForeColor = Color.Blue
            ElseIf Me.$STATIC$Timer3_Tick$20211C124D$C = 3 Then
                Me.Label4.ForeColor = Color.Yellow
            ElseIf Me.$STATIC$Timer3_Tick$20211C124D$C = 4 Then
                Me.Label4.ForeColor = Color.White
            Else
                Me.$STATIC$Timer3_Tick$20211C124D$C = 5
                Me.$STATIC$Timer3_Tick$20211C124D$C = 0
            End If
        End Sub

        Private Sub Cargando_Load(sender As Object, e As EventArgs)
            MessageBox.Show("Chekeando Version", "zDarkHax", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End Sub

        Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

        <AccessedThroughProperty("ProgressBar1")>
        Private _ProgressBar1 As ProgressBar

        <AccessedThroughProperty("Label1")>
        Private _Label1 As Label

        <AccessedThroughProperty("Label3")>
        Private _Label3 As Label

        <AccessedThroughProperty("Label2")>
        Private _Label2 As Label

        <AccessedThroughProperty("Label4")>
        Private _Label4 As Label

        <AccessedThroughProperty("Button1")>
        Private _Button1 As Button

        <AccessedThroughProperty("Timer1")>
        Private _Timer1 As Timer

        <AccessedThroughProperty("Timer2")>
        Private _Timer2 As Timer

        <AccessedThroughProperty("Timer3")>
        Private _Timer3 As Timer

        Public contador As Integer

        Private $STATIC$Timer2_Tick$20211C124D$C As Integer

		Private $STATIC$Timer3_Tick$20211C124D$C As Integer

        Private Sub Cargando_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub
    End Class
End Namespace
