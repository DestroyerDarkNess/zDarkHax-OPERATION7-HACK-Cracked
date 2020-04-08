Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports NewHack.My

'###################### CRACKED BY DHANAX26 ######################

Namespace NewHack
    <DesignerGenerated()>
    Partial Public Class actualizacion
        Inherits Form

        <DebuggerNonUserCode()>
        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.actualizacion_Load
            actualizacion.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <DebuggerNonUserCode()>
        Private Shared Sub __ENCAddToList(value As Object)
            Dim _ENCList As List(Of WeakReference) = actualizacion.__ENCList
            SyncLock _ENCList
                If actualizacion.__ENCList.Count = actualizacion.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = 0
                    Dim num3 As Integer = actualizacion.__ENCList.Count - 1
                    Dim num4 As Integer = num2
                    While True
                        Dim num5 As Integer = num4
                        Dim num6 As Integer = num3
                        If num5 > num6 Then
                            Exit For
                        End If
                        Dim weakReference As WeakReference = actualizacion.__ENCList(num4)
                        If weakReference.IsAlive Then
                            If num4 <> num Then
                                actualizacion.__ENCList(num) = actualizacion.__ENCList(num4)
                            End If
                            num += 1
                        End If
                        num4 += 1
                    End While
                    actualizacion.__ENCList.RemoveRange(num, actualizacion.__ENCList.Count - num)
                    actualizacion.__ENCList.Capacity = actualizacion.__ENCList.Count
                End If
                actualizacion.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Friend Overridable Property Recv As Label
            <DebuggerNonUserCode()>
            Get
                Return Me._Recv
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As Label)
                Me._Recv = value
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

        Friend Overridable Property Button2 As Button
            <DebuggerNonUserCode()>
            Get
                Return Me._Button2
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As Button)
                Dim value2 As EventHandler = AddressOf Me.Button2_Click
                If Me._Button2 IsNot Nothing Then
                    RemoveHandler Me._Button2.Click, value2
                End If
                Me._Button2 = value
                If Me._Button2 IsNot Nothing Then
                    AddHandler Me._Button2.Click, value2
                End If
            End Set
        End Property

        Private Sub actualizacion_Load(sender As Object, e As EventArgs)
            Try
                Dim webClient As WebClient = New WebClient()
                Dim left As String = webClient.DownloadString("https://www.dropbox.com/s/nopysfrhlc43g9k/Version.txt?dl=1")
                If Operators.CompareString(left, "2", False) = 0 Then
                    Me.Recv.Text = "Indectetable"
                    Me.Recv.ForeColor = Color.Green
                    Interaction.MsgBox("Hack totalmente seguro, Puedes utilizarlo", CType(Conversions.ToInteger("kojh"), MsgBoxStyle), Nothing)
                Else
                    Me.Recv.Text = "Detectado"
                    Me.Recv.ForeColor = Color.Red
                    MessageBox.Show("Hack detectado; Por favor Borre Esta Version Por Seguridad y Descargue La Nueva Version que saldra en mi canal", "zDarkHax", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    Process.Start("https://www.youtube.com/channel/UCu4yzfdAfXW7VHzXtJb8cvw?view_as=subscriber")
                    Me.Button1.Enabled = False
                    Me.Close()
                End If
            Catch ex As Exception
                MessageBox.Show("¡Disfrute Del Hack!", "zDarkHax", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End Try
        End Sub

        Private Sub Button1_Click(sender As Object, e As EventArgs)
            MessageBox.Show("Hack totalmente seguro, Puedes utilizarlo", "zDarkHax", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            MyProject.Forms.Form2.Show()
            Me.Close()
        End Sub

        Private Sub Button2_Click(sender As Object, e As EventArgs)
            Me.Close()
        End Sub

        Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

        <AccessedThroughProperty("Recv")>
        Private _Recv As Label

        <AccessedThroughProperty("Button1")>
        Private _Button1 As Button

        <AccessedThroughProperty("Button2")>
        Private _Button2 As Button
    End Class
End Namespace
