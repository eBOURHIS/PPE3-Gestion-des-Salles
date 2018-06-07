<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Authentification
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button_connection = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_login = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_password = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PPE3_Gestion_des_Salles.My.Resources.Resources.GSB_Logo
        Me.PictureBox1.Location = New System.Drawing.Point(5, 11)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(362, 190)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Button_connection
        '
        Me.Button_connection.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button_connection.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_connection.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button_connection.Location = New System.Drawing.Point(124, 350)
        Me.Button_connection.Name = "Button_connection"
        Me.Button_connection.Size = New System.Drawing.Size(142, 60)
        Me.Button_connection.TabIndex = 1
        Me.Button_connection.Text = "Connexion"
        Me.Button_connection.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Location = New System.Drawing.Point(12, 229)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 28)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nom de compte :"
        '
        'TextBox_login
        '
        Me.TextBox_login.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_login.Location = New System.Drawing.Point(185, 229)
        Me.TextBox_login.Multiline = True
        Me.TextBox_login.Name = "TextBox_login"
        Me.TextBox_login.Size = New System.Drawing.Size(174, 30)
        Me.TextBox_login.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label2.Location = New System.Drawing.Point(31, 283)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 28)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Mot de passe :"
        '
        'TextBox_password
        '
        Me.TextBox_password.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_password.Location = New System.Drawing.Point(185, 283)
        Me.TextBox_password.Multiline = True
        Me.TextBox_password.Name = "TextBox_password"
        Me.TextBox_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox_password.Size = New System.Drawing.Size(174, 30)
        Me.TextBox_password.TabIndex = 7
        '
        'Authentification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 422)
        Me.Controls.Add(Me.TextBox_password)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox_login)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_connection)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Authentification"
        Me.Text = "Authentification"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button_connection As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox_login As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox_password As System.Windows.Forms.TextBox
End Class
