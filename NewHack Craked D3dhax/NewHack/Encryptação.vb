Imports System
Imports System.Security.Cryptography
Imports System.Text
Imports Microsoft.VisualBasic.CompilerServices

'###################### CRACKED BY DHANAX26 ######################

Namespace NewHack
    Friend NotInheritable Module Encryptação
        Public Function AES_Encrypt(input As String, pass As String) As String
            Dim rijndaelManaged As RijndaelManaged = New RijndaelManaged()
            Dim md5CryptoServiceProvider As MD5CryptoServiceProvider = New MD5CryptoServiceProvider()
            Try
                Dim array As Byte() = New Byte(31) {}
                Dim sourceArray As Byte() = md5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(pass))
                array.Copy(sourceArray, 0, array, 0, 16)
                array.Copy(sourceArray, 0, array, 15, 16)
                rijndaelManaged.Key = array
                rijndaelManaged.Mode = CipherMode.ECB
                Dim cryptoTransform As ICryptoTransform = rijndaelManaged.CreateEncryptor()
                Dim bytes As Byte() = Encoding.ASCII.GetBytes(input)
                Return Convert.ToBase64String(cryptoTransform.TransformFinalBlock(bytes, 0, bytes.Length))
            Catch ex As Exception
            End Try
            Return Conversions.ToString(True)
        End Function

        Public Function AES_Decrypt(input As String, pass As String) As String
            Dim rijndaelManaged As RijndaelManaged = New RijndaelManaged()
            Dim md5CryptoServiceProvider As MD5CryptoServiceProvider = New MD5CryptoServiceProvider()
            Try
                Dim array As Byte() = New Byte(31) {}
                Dim sourceArray As Byte() = md5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(pass))
                array.Copy(sourceArray, 0, array, 0, 16)
                array.Copy(sourceArray, 0, array, 15, 16)
                rijndaelManaged.Key = array
                rijndaelManaged.Mode = CipherMode.ECB
                Dim cryptoTransform As ICryptoTransform = rijndaelManaged.CreateDecryptor()
                Dim array2 As Byte() = Convert.FromBase64String(input)
                Return Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array2, 0, array2.Length))
            Catch ex As Exception
            End Try
            Return Conversions.ToString(True)
        End Function
    End Module
End Namespace
