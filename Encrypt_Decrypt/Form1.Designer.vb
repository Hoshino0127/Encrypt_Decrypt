<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblDisplaySaltValue = New System.Windows.Forms.Label()
        Me.txtSaltValue = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnEncrypt = New System.Windows.Forms.Button()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.txtEncryptedText = New System.Windows.Forms.TextBox()
        Me.lblDisplayEncrypted = New System.Windows.Forms.Label()
        Me.txtPlainText = New System.Windows.Forms.TextBox()
        Me.lblDisplayPlainText = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnDecrypt = New System.Windows.Forms.Button()
        Me.btnCopy2 = New System.Windows.Forms.Button()
        Me.txtDecryptedText = New System.Windows.Forms.TextBox()
        Me.lblDisplayDecrypted = New System.Windows.Forms.Label()
        Me.txtEncryptedText2 = New System.Windows.Forms.TextBox()
        Me.lblDisplayEncrypted2 = New System.Windows.Forms.Label()
        Me.lblDefault = New System.Windows.Forms.Label()
        Me.btnClear2 = New System.Windows.Forms.Button()
        Me.btnClearAll = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDisplaySaltValue
        '
        Me.lblDisplaySaltValue.AutoSize = True
        Me.lblDisplaySaltValue.Location = New System.Drawing.Point(42, 39)
        Me.lblDisplaySaltValue.Name = "lblDisplaySaltValue"
        Me.lblDisplaySaltValue.Size = New System.Drawing.Size(76, 20)
        Me.lblDisplaySaltValue.TabIndex = 0
        Me.lblDisplaySaltValue.Text = "Salt value:"
        '
        'txtSaltValue
        '
        Me.txtSaltValue.Location = New System.Drawing.Point(171, 36)
        Me.txtSaltValue.Name = "txtSaltValue"
        Me.txtSaltValue.Size = New System.Drawing.Size(283, 27)
        Me.txtSaltValue.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.btnEncrypt)
        Me.GroupBox1.Controls.Add(Me.btnCopy)
        Me.GroupBox1.Controls.Add(Me.txtEncryptedText)
        Me.GroupBox1.Controls.Add(Me.lblDisplayEncrypted)
        Me.GroupBox1.Controls.Add(Me.txtPlainText)
        Me.GroupBox1.Controls.Add(Me.lblDisplayPlainText)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(740, 130)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Encryption"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(608, 56)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(94, 29)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnEncrypt
        '
        Me.btnEncrypt.Location = New System.Drawing.Point(448, 38)
        Me.btnEncrypt.Name = "btnEncrypt"
        Me.btnEncrypt.Size = New System.Drawing.Size(94, 29)
        Me.btnEncrypt.TabIndex = 7
        Me.btnEncrypt.Text = "Encrypt"
        Me.btnEncrypt.UseVisualStyleBackColor = True
        '
        'btnCopy
        '
        Me.btnCopy.Location = New System.Drawing.Point(448, 79)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(94, 29)
        Me.btnCopy.TabIndex = 6
        Me.btnCopy.Text = "Copy"
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'txtEncryptedText
        '
        Me.txtEncryptedText.Location = New System.Drawing.Point(149, 79)
        Me.txtEncryptedText.Name = "txtEncryptedText"
        Me.txtEncryptedText.Size = New System.Drawing.Size(283, 27)
        Me.txtEncryptedText.TabIndex = 5
        '
        'lblDisplayEncrypted
        '
        Me.lblDisplayEncrypted.AutoSize = True
        Me.lblDisplayEncrypted.Location = New System.Drawing.Point(20, 82)
        Me.lblDisplayEncrypted.Name = "lblDisplayEncrypted"
        Me.lblDisplayEncrypted.Size = New System.Drawing.Size(104, 20)
        Me.lblDisplayEncrypted.TabIndex = 4
        Me.lblDisplayEncrypted.Text = "Encrypted text"
        '
        'txtPlainText
        '
        Me.txtPlainText.Location = New System.Drawing.Point(149, 39)
        Me.txtPlainText.Name = "txtPlainText"
        Me.txtPlainText.Size = New System.Drawing.Size(283, 27)
        Me.txtPlainText.TabIndex = 3
        '
        'lblDisplayPlainText
        '
        Me.lblDisplayPlainText.AutoSize = True
        Me.lblDisplayPlainText.Location = New System.Drawing.Point(20, 42)
        Me.lblDisplayPlainText.Name = "lblDisplayPlainText"
        Me.lblDisplayPlainText.Size = New System.Drawing.Size(70, 20)
        Me.lblDisplayPlainText.TabIndex = 0
        Me.lblDisplayPlainText.Text = "Plain text"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnClear2)
        Me.GroupBox2.Controls.Add(Me.btnDecrypt)
        Me.GroupBox2.Controls.Add(Me.btnCopy2)
        Me.GroupBox2.Controls.Add(Me.txtDecryptedText)
        Me.GroupBox2.Controls.Add(Me.lblDisplayDecrypted)
        Me.GroupBox2.Controls.Add(Me.txtEncryptedText2)
        Me.GroupBox2.Controls.Add(Me.lblDisplayEncrypted2)
        Me.GroupBox2.Location = New System.Drawing.Point(22, 248)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(740, 130)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Decryption"
        '
        'btnDecrypt
        '
        Me.btnDecrypt.Location = New System.Drawing.Point(448, 39)
        Me.btnDecrypt.Name = "btnDecrypt"
        Me.btnDecrypt.Size = New System.Drawing.Size(94, 29)
        Me.btnDecrypt.TabIndex = 8
        Me.btnDecrypt.Text = "Decrypt"
        Me.btnDecrypt.UseVisualStyleBackColor = True
        '
        'btnCopy2
        '
        Me.btnCopy2.Location = New System.Drawing.Point(448, 79)
        Me.btnCopy2.Name = "btnCopy2"
        Me.btnCopy2.Size = New System.Drawing.Size(94, 29)
        Me.btnCopy2.TabIndex = 6
        Me.btnCopy2.Text = "Copy"
        Me.btnCopy2.UseVisualStyleBackColor = True
        '
        'txtDecryptedText
        '
        Me.txtDecryptedText.Location = New System.Drawing.Point(149, 79)
        Me.txtDecryptedText.Name = "txtDecryptedText"
        Me.txtDecryptedText.Size = New System.Drawing.Size(283, 27)
        Me.txtDecryptedText.TabIndex = 5
        '
        'lblDisplayDecrypted
        '
        Me.lblDisplayDecrypted.AutoSize = True
        Me.lblDisplayDecrypted.Location = New System.Drawing.Point(20, 82)
        Me.lblDisplayDecrypted.Name = "lblDisplayDecrypted"
        Me.lblDisplayDecrypted.Size = New System.Drawing.Size(107, 20)
        Me.lblDisplayDecrypted.TabIndex = 4
        Me.lblDisplayDecrypted.Text = "Decrypted text"
        '
        'txtEncryptedText2
        '
        Me.txtEncryptedText2.Location = New System.Drawing.Point(149, 39)
        Me.txtEncryptedText2.Name = "txtEncryptedText2"
        Me.txtEncryptedText2.Size = New System.Drawing.Size(283, 27)
        Me.txtEncryptedText2.TabIndex = 3
        '
        'lblDisplayEncrypted2
        '
        Me.lblDisplayEncrypted2.AutoSize = True
        Me.lblDisplayEncrypted2.Location = New System.Drawing.Point(20, 42)
        Me.lblDisplayEncrypted2.Name = "lblDisplayEncrypted2"
        Me.lblDisplayEncrypted2.Size = New System.Drawing.Size(104, 20)
        Me.lblDisplayEncrypted2.TabIndex = 0
        Me.lblDisplayEncrypted2.Text = "Encrypted text"
        '
        'lblDefault
        '
        Me.lblDefault.AutoSize = True
        Me.lblDefault.Location = New System.Drawing.Point(42, 74)
        Me.lblDefault.Name = "lblDefault"
        Me.lblDefault.Size = New System.Drawing.Size(452, 20)
        Me.lblDefault.TabIndex = 8
        Me.lblDefault.Text = "Default salt value is ABCDEFGHIJKLMNOPQRSTUVWXYZ123456789" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnClear2
        '
        Me.btnClear2.Location = New System.Drawing.Point(608, 59)
        Me.btnClear2.Name = "btnClear2"
        Me.btnClear2.Size = New System.Drawing.Size(94, 29)
        Me.btnClear2.TabIndex = 9
        Me.btnClear2.Text = "Clear"
        Me.btnClear2.UseVisualStyleBackColor = True
        '
        'btnClearAll
        '
        Me.btnClearAll.Location = New System.Drawing.Point(630, 55)
        Me.btnClearAll.Name = "btnClearAll"
        Me.btnClearAll.Size = New System.Drawing.Size(94, 29)
        Me.btnClearAll.TabIndex = 9
        Me.btnClearAll.Text = "Clear All"
        Me.btnClearAll.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnClearAll)
        Me.Controls.Add(Me.lblDefault)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtSaltValue)
        Me.Controls.Add(Me.lblDisplaySaltValue)
        Me.Name = "Form1"
        Me.Text = "Encrypt and decrypt"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDisplaySaltValue As Label
    Friend WithEvents txtSaltValue As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCopy As Button
    Friend WithEvents txtEncryptedText As TextBox
    Friend WithEvents lblDisplayEncrypted As Label
    Friend WithEvents txtPlainText As TextBox
    Friend WithEvents lblDisplayPlainText As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnCopy2 As Button
    Friend WithEvents txtDecryptedText As TextBox
    Friend WithEvents lblDisplayDecrypted As Label
    Friend WithEvents txtEncryptedText2 As TextBox
    Friend WithEvents lblDisplayEncrypted2 As Label
    Friend WithEvents btnEncrypt As Button
    Friend WithEvents btnDecrypt As Button
    Friend WithEvents lblDefault As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnClear2 As Button
    Friend WithEvents btnClearAll As Button
End Class
