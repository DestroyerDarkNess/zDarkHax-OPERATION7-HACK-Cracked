Module TRAINER
    Private Declare Ansi Function ReadMemoryByte Lib "kernel32" Alias "ReadProcessMemory" (Handle As Integer, Address As Integer, ByRef Value As Byte, Optional Size As Integer = 2, Optional ByRef Bytes As Integer = 0) As Byte

    Private Declare Ansi Function ReadMemoryInteger Lib "kernel32" Alias "ReadProcessMemory" (Handle As Integer, Address As Integer, ByRef Value As Integer, Optional Size As Integer = 4, Optional ByRef Bytes As Integer = 0) As Integer

    Private Declare Ansi Function ReadMemoryFloat Lib "kernel32" Alias "ReadProcessMemory" (Handle As Integer, Address As Integer, ByRef Value As Single, Optional Size As Integer = 4, Optional ByRef Bytes As Integer = 0) As Single

    Private Declare Ansi Function ReadMemoryDouble Lib "kernel32" Alias "ReadProcessMemory" (Handle As Integer, Address As Integer, ByRef Value As Double, Optional Size As Integer = 8, Optional ByRef Bytes As Integer = 0) As Double

    Private Declare Ansi Function WriteMemoryByte Lib "kernel32" Alias "WriteProcessMemory" (Handle As Integer, Address As Integer, ByRef Value As Byte, Optional Size As Integer = 2, Optional ByRef Bytes As Integer = 0) As Byte

    Private Declare Ansi Function WriteMemoryInteger Lib "kernel32" Alias "WriteProcessMemory" (Handle As Integer, Address As Integer, ByRef Value As Integer, Optional Size As Integer = 4, Optional ByRef Bytes As Integer = 0) As Integer

    Private Declare Ansi Function WriteMemoryFloat Lib "kernel32" Alias "WriteProcessMemory" (Handle As Integer, Address As Integer, ByRef Value As Single, Optional Size As Integer = 2, Optional ByRef Bytes As Integer = 0) As Single

    Private Declare Ansi Function WriteMemoryDouble Lib "kernel32" Alias "WriteProcessMemory" (Handle As Integer, Address As Integer, ByRef Value As Double, Optional Size As Integer = 2, Optional ByRef Bytes As Integer = 0) As Double

    Public Function ReadByte(EXENAME As String, Address As Integer) As Byte
        Try
            Dim result As Byte
            If Process.GetProcessesByName(EXENAME).Length <> 0 Then
                Dim num As Integer = CInt(Process.GetProcessesByName(EXENAME)(0).Handle)
                If num <> 0 Then
                    Dim handle As Integer = num
                    Dim size As Integer = 2
                    Dim num2 As Integer = 0
                    TRAINER.ReadMemoryByte(handle, Address, result, size, num2)
                End If
            End If
            Return result
        Catch ex As Exception
            Application.[Exit]()
        End Try
        Return Byte.MaxValue
    End Function

    Public Function ReadInteger(EXENAME As String, Address As Integer) As Integer
        Try
            Dim result As Integer
            If Process.GetProcessesByName(EXENAME).Length <> 0 Then
                Dim num As Integer = CInt(Process.GetProcessesByName(EXENAME)(0).Handle)
                If num <> 0 Then
                    Dim handle As Integer = num
                    Dim size As Integer = 4
                    Dim num2 As Integer = 0
                    TRAINER.ReadMemoryInteger(handle, Address, result, size, num2)
                End If
            End If
            Return result
        Catch ex As Exception
            Application.[Exit]()
        End Try
        Return -1
    End Function

    Public Function ReadFloat(EXENAME As String, Address As Integer) As Single
        Try
            Dim result As Single
            If Process.GetProcessesByName(EXENAME).Length <> 0 Then
                Dim num As Integer = CInt(Process.GetProcessesByName(EXENAME)(0).Handle)
                If num <> 0 Then
                    Dim handle As Integer = num
                    Dim size As Integer = 4
                    Dim num2 As Integer = 0
                    TRAINER.ReadMemoryFloat(handle, Address, result, size, num2)
                End If
            End If
            Return result
        Catch ex As Exception
            Application.[Exit]()
        End Try
        Return -1.0F
    End Function

    Public Function ReadDouble(EXENAME As String, Address As Integer) As Double
        Try
            Dim num2 As Double
            If Process.GetProcessesByName(EXENAME).Length <> 0 Then
                Dim num As Integer = CInt(Process.GetProcessesByName(EXENAME)(0).Handle)
                If num <> 0 Then
                    Dim handle As Integer = num
                    Dim b As Byte = CByte(Math.Round(num2))
                    Dim size As Integer = 2
                    Dim num3 As Integer = 0
                    TRAINER.ReadMemoryByte(handle, Address, b, size, num3)
                    num2 = CDbl(b)
                End If
            End If
            Return num2
        Catch ex As Exception
            Application.[Exit]()
        End Try
        Return -1.0
    End Function

    Public Function ReadPointerByte(EXENAME As String, Pointer As Integer, ParamArray Offset As Integer()) As Byte
        Try
            Dim result As Byte
            If Process.GetProcessesByName(EXENAME).Length <> 0 Then
                Dim num As Integer = CInt(Process.GetProcessesByName(EXENAME)(0).Handle)
                If num <> 0 Then
                    Dim num3 As Integer
                    For Each num2 As Integer In Offset
                        Dim handle As Integer = num
                        Dim address As Integer = Pointer
                        Dim size As Integer = 4
                        num3 = 0
                        TRAINER.ReadMemoryInteger(handle, address, Pointer, size, num3)
                        Pointer += num2
                    Next
                    Dim handle2 As Integer = num
                    Dim address2 As Integer = Pointer
                    Dim size2 As Integer = 2
                    num3 = 0
                    TRAINER.ReadMemoryByte(handle2, address2, result, size2, num3)
                End If
            End If
            Return result
        Catch ex As Exception
            Application.[Exit]()
        End Try
        Return Byte.MaxValue
    End Function

    Public Function ReadPointerInteger(EXENAME As String, Pointer As Integer, ParamArray Offset As Integer()) As Integer
        Try
            Dim result As Integer
            If Process.GetProcessesByName(EXENAME).Length <> 0 Then
                Dim num As Integer = CInt(Process.GetProcessesByName(EXENAME)(0).Handle)
                If num <> 0 Then
                    Dim num3 As Integer
                    For Each num2 As Integer In Offset
                        Dim handle As Integer = num
                        Dim address As Integer = Pointer
                        Dim size As Integer = 4
                        num3 = 0
                        TRAINER.ReadMemoryInteger(handle, address, Pointer, size, num3)
                        Pointer += num2
                    Next
                    Dim handle2 As Integer = num
                    Dim address2 As Integer = Pointer
                    Dim size2 As Integer = 4
                    num3 = 0
                    TRAINER.ReadMemoryInteger(handle2, address2, result, size2, num3)
                End If
            End If
            Return result
        Catch ex As Exception
            Application.[Exit]()
        End Try
        Return -1
    End Function

    Public Function ReadPointerFloat(EXENAME As String, Pointer As Integer, ParamArray Offset As Integer()) As Single
        Try
            Dim result As Single
            If Process.GetProcessesByName(EXENAME).Length <> 0 Then
                Dim num As Integer = CInt(Process.GetProcessesByName(EXENAME)(0).Handle)
                If num <> 0 Then
                    Dim num3 As Integer
                    For Each num2 As Integer In Offset
                        Dim handle As Integer = num
                        Dim address As Integer = Pointer
                        Dim size As Integer = 4
                        num3 = 0
                        TRAINER.ReadMemoryInteger(handle, address, Pointer, size, num3)
                        Pointer += num2
                    Next
                    Dim handle2 As Integer = num
                    Dim address2 As Integer = Pointer
                    Dim size2 As Integer = 4
                    num3 = 0
                    TRAINER.ReadMemoryFloat(handle2, address2, result, size2, num3)
                End If
            End If
            Return result
        Catch ex As Exception
            Application.[Exit]()
        End Try
        Return -1.0F
    End Function

    Public Function ReadPointerDouble(EXENAME As String, Pointer As Integer, ParamArray Offset As Integer()) As Double
        Try
            Dim result As Double
            If Process.GetProcessesByName(EXENAME).Length <> 0 Then
                Dim num As Integer = CInt(Process.GetProcessesByName(EXENAME)(0).Handle)
                If num <> 0 Then
                    Dim num3 As Integer
                    For Each num2 As Integer In Offset
                        Dim handle As Integer = num
                        Dim address As Integer = Pointer
                        Dim size As Integer = 4
                        num3 = 0
                        TRAINER.ReadMemoryInteger(handle, address, Pointer, size, num3)
                        Pointer += num2
                    Next
                    Dim handle2 As Integer = num
                    Dim address2 As Integer = Pointer
                    Dim size2 As Integer = 8
                    num3 = 0
                    TRAINER.ReadMemoryDouble(handle2, address2, result, size2, num3)
                End If
            End If
            Return result
        Catch ex As Exception
            Application.[Exit]()
        End Try
        Return -1.0
    End Function

    Public Sub WriteByte(EXENAME As String, Address As Integer, Value As Byte)
        Try
            If Process.GetProcessesByName(EXENAME).Length <> 0 Then
                Dim num As Integer = CInt(Process.GetProcessesByName(EXENAME)(0).Handle)
                If num <> 0 Then
                    Dim handle As Integer = num
                    Dim size As Integer = 2
                    Dim num2 As Integer = 0
                    TRAINER.WriteMemoryByte(handle, Address, Value, size, num2)
                End If
            End If
        Catch ex As Exception
            Application.[Exit]()
        End Try
    End Sub

    Public Sub WriteInteger(EXENAME As String, Address As Integer, Value As Integer)
        Try
            If Process.GetProcessesByName(EXENAME).Length <> 0 Then
                Dim num As Integer = CInt(Process.GetProcessesByName(EXENAME)(0).Handle)
                If num <> 0 Then
                    Dim handle As Integer = num
                    Dim size As Integer = 4
                    Dim num2 As Integer = 0
                    TRAINER.WriteMemoryInteger(handle, Address, Value, size, num2)
                End If
            End If
        Catch ex As Exception
            Application.[Exit]()
        End Try
    End Sub

    Public Sub WriteFloat(EXENAME As String, Address As Integer, Value As Single)
        Try
            If Process.GetProcessesByName(EXENAME).Length <> 0 Then
                Dim num As Integer = CInt(Process.GetProcessesByName(EXENAME)(0).Handle)
                If num <> 0 Then
                    Dim handle As Integer = num
                    Dim size As Integer = 2
                    Dim num2 As Integer = 0
                    TRAINER.WriteMemoryFloat(handle, Address, Value, size, num2)
                End If
            End If
        Catch ex As Exception
            Application.[Exit]()
        End Try
    End Sub

    Public Sub WriteDouble(EXENAME As String, Address As Integer, Value As Double)
        Try
            If Process.GetProcessesByName(EXENAME).Length <> 0 Then
                Dim num As Integer = CInt(Process.GetProcessesByName(EXENAME)(0).Handle)
                If num <> 0 Then
                    Dim handle As Integer = num
                    Dim size As Integer = 2
                    Dim num2 As Integer = 0
                    TRAINER.WriteMemoryDouble(handle, Address, Value, size, num2)
                End If
            End If
        Catch ex As Exception
            Application.[Exit]()
        End Try
    End Sub

    Public Sub WritePointerByte(EXENAME As String, Pointer As Integer, Value As Byte, ParamArray Offset As Integer())
        Try
            If Process.GetProcessesByName(EXENAME).Length <> 0 Then
                Dim num As Integer = CInt(Process.GetProcessesByName(EXENAME)(0).Handle)
                If num <> 0 Then
                    Dim num3 As Integer
                    For Each num2 As Integer In Offset
                        Dim handle As Integer = num
                        Dim address As Integer = Pointer
                        Dim size As Integer = 4
                        num3 = 0
                        TRAINER.ReadMemoryInteger(handle, address, Pointer, size, num3)
                        Pointer += num2
                    Next
                    Dim handle2 As Integer = num
                    Dim address2 As Integer = Pointer
                    Dim size2 As Integer = 2
                    num3 = 0
                    TRAINER.WriteMemoryByte(handle2, address2, Value, size2, num3)
                End If
            End If
        Catch ex As Exception
            Application.[Exit]()
        End Try
    End Sub

    Public Sub WritePointerInteger(EXENAME As String, Pointer As Integer, Value As Integer, ParamArray Offset As Integer())
        Try
            If Process.GetProcessesByName(EXENAME).Length <> 0 Then
                Dim num As Integer = CInt(Process.GetProcessesByName(EXENAME)(0).Handle)
                If num <> 0 Then
                    Dim num3 As Integer
                    For Each num2 As Integer In Offset
                        Dim handle As Integer = num
                        Dim address As Integer = Pointer
                        Dim size As Integer = 4
                        num3 = 0
                        TRAINER.ReadMemoryInteger(handle, address, Pointer, size, num3)
                        Pointer += num2
                    Next
                    Dim handle2 As Integer = num
                    Dim address2 As Integer = Pointer
                    Dim size2 As Integer = 4
                    num3 = 0
                    TRAINER.WriteMemoryInteger(handle2, address2, Value, size2, num3)
                End If
            End If
        Catch ex As Exception
            Application.[Exit]()
        End Try
    End Sub

    Public Sub WritePointerFloat(EXENAME As String, Pointer As Integer, Value As Single, ParamArray Offset As Integer())
        Try
            If Process.GetProcessesByName(EXENAME).Length <> 0 Then
                Dim num As Integer = CInt(Process.GetProcessesByName(EXENAME)(0).Handle)
                If num <> 0 Then
                    Dim num3 As Integer
                    For Each num2 As Integer In Offset
                        Dim handle As Integer = num
                        Dim address As Integer = Pointer
                        Dim size As Integer = 4
                        num3 = 0
                        TRAINER.ReadMemoryInteger(handle, address, Pointer, size, num3)
                        Pointer += num2
                    Next
                    Dim handle2 As Integer = num
                    Dim address2 As Integer = Pointer
                    Dim size2 As Integer = 2
                    num3 = 0
                    TRAINER.WriteMemoryFloat(handle2, address2, Value, size2, num3)
                End If
            End If
        Catch ex As Exception
            Application.[Exit]()
        End Try
    End Sub

    Public Sub WritePointerDouble(EXENAME As String, Pointer As Integer, Value As Double, ParamArray Offset As Integer())
        Try
            If Process.GetProcessesByName(EXENAME).Length <> 0 Then
                Dim num As Integer = CInt(Process.GetProcessesByName(EXENAME)(0).Handle)
                If num <> 0 Then
                    Dim num3 As Integer
                    For Each num2 As Integer In Offset
                        Dim handle As Integer = num
                        Dim address As Integer = Pointer
                        Dim size As Integer = 4
                        num3 = 0
                        TRAINER.ReadMemoryInteger(handle, address, Pointer, size, num3)
                        Pointer += num2
                    Next
                    Dim handle2 As Integer = num
                    Dim address2 As Integer = Pointer
                    Dim size2 As Integer = 2
                    num3 = 0
                    TRAINER.WriteMemoryDouble(handle2, address2, Value, size2, num3)
                End If
            End If
        Catch ex As Exception
            Application.[Exit]()
        End Try
    End Sub

    Public Declare Ansi Function GetAsyncKeyState Lib "user32" (vKey As Integer) As Short

    Public Function GetKeyState(Key1 As Integer, Optional Key2 As Integer = -1, Optional Key3 As Integer = -1) As Boolean
        Return True
    End Function

End Module

