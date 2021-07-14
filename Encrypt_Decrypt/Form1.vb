Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Public Class Form1
    Private Sub btnEncrypt_Click(sender As Object, e As EventArgs) Handles btnEncrypt.Click
        If ValidateError("Encrypt") Then
            txtEncryptedText.Text = Encrypt(txtPlainText.Text)
        End If
    End Sub

    Private Sub btnDecrypt_Click(sender As Object, e As EventArgs) Handles btnDecrypt.Click
        If ValidateError("Encrypt") Then
            txtDecryptedText.Text = Decrypt(txtEncryptedText2.Text)
        End If
    End Sub

    Private Function ValidateError(ByVal Action As String) As Boolean
        Try
            If Action.Equals("Encrypt") Then
                If txtPlainText.Text.Equals("") Then
                    MessageBox.Show("Please enter plain text to encrypt")
                    Return False
                End If
            Else
                If txtEncryptedText2.Text.Equals("") Then
                    MessageBox.Show("Please enter encrypted text to decrypt")
                    Return False
                End If
            End If

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Function Encrypt(clearText As String) As String
        Try
            Dim EncryptionKey As String = ""

            If txtSaltValue.Text <> "" Then
                EncryptionKey = txtSaltValue.Text
            Else
                EncryptionKey = "ABCDEFGHIJKLMNOPQRSTUVWXYZ123456789"
            End If

            'Dim EncryptionKey As String = ConfigurationManager.AppSettings("EncryptionKey")
            Dim clearBytes As Byte() = Encoding.Unicode.GetBytes(clearText)
            Using encryptor As Aes = Aes.Create()
                Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D,
                 &H65, &H64, &H76, &H65, &H64, &H65,
                 &H76})
                encryptor.Key = pdb.GetBytes(32)
                encryptor.IV = pdb.GetBytes(16)
                Using ms As New MemoryStream()
                    Using cs As New CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write)
                        cs.Write(clearBytes, 0, clearBytes.Length)
                        cs.Close()
                    End Using
                    clearText = Convert.ToBase64String(ms.ToArray())
                End Using
            End Using
            Return clearText
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return String.Empty
        End Try
    End Function

    Private Function Decrypt(cipherText As String) As String
        Try
            Dim EncryptionKey As String = ""

            If txtSaltValue.Text <> "" Then
                EncryptionKey = txtSaltValue.Text
            Else
                EncryptionKey = "ABCDEFGHIJKLMNOPQRSTUVWXYZ123456789"
            End If

            Dim cipherBytes As Byte() = Convert.FromBase64String(cipherText)
            Using encryptor As Aes = Aes.Create()
                Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D,
                 &H65, &H64, &H76, &H65, &H64, &H65,
                 &H76})
                encryptor.Key = pdb.GetBytes(32)
                encryptor.IV = pdb.GetBytes(16)
                Using ms As New MemoryStream()
                    Using cs As New CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write)
                        cs.Write(cipherBytes, 0, cipherBytes.Length)
                        cs.Close()
                    End Using
                    cipherText = Encoding.Unicode.GetString(ms.ToArray())
                End Using
            End Using
            Return cipherText
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return String.Empty
        End Try
    End Function

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        txtEncryptedText.SelectAll()
        txtEncryptedText.Copy()
    End Sub

    Private Sub btnCopy2_Click(sender As Object, e As EventArgs) Handles btnCopy2.Click
        txtDecryptedText.SelectAll()
        txtDecryptedText.Copy()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPlainText.Text = ""
        txtEncryptedText.Text = ""
    End Sub

    Private Sub btnClear2_Click(sender As Object, e As EventArgs) Handles btnClear2.Click
        txtEncryptedText2.Text = ""
        txtDecryptedText.Text = ""
    End Sub

    Private Sub btnClearAll_Click(sender As Object, e As EventArgs) Handles btnClearAll.Click
        txtSaltValue.Text = ""
        txtPlainText.Text = ""
        txtEncryptedText.Text = ""
        txtEncryptedText2.Text = ""
        txtDecryptedText.Text = ""
    End Sub
End Class
