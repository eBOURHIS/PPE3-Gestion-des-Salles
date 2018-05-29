Public Class Authentification

    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String

    Private Sub Authentification_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'TextBox_password.PasswordChar = "*"

        'local
        'connString = "DSN=ORA13;Uid=Admin_GSB;Pwd=estran;"

        'prod
        connString = "DSN=ORAPROD;Uid=PPE3;Pwd=estran;"

        myConnection.ConnectionString = connString

        Try
            myConnection.Open()
            'MessageBox.Show("Connexion Oracle Réussie")
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button_connection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_connection.Click

        'MsgBox(TextBox_password.Text)

        Dim login As String = TextBox_login.Text
        Dim password As String = TextBox_password.Text

        TextBox_login.BackColor = Color.White
        TextBox_password.BackColor = Color.White

        If (login.Trim = "" And password.Trim = "") Then

            MsgBox("Veuillez entrer vos identifiants !")
            TextBox_login.BackColor = Color.Red
            TextBox_password.BackColor = Color.Red

        Else

            Dim login_sql As String = ""
            Dim password_sql As String = ""

            Dim sql As String = "SELECT * FROM EMPLOYE WHERE LOGIN = '" + login + "';"
            myCommand.Connection = myConnection
            myCommand.CommandText = sql
            myReader = myCommand.ExecuteReader

            Do While myReader.Read()
                Main.idEmploye = myReader.GetString(0)
                Main.nomEmploye = myReader.GetString(1)
                Main.prenomEmploye = myReader.GetString(2)
                login_sql = myReader.GetString(3)
                password_sql = myReader.GetString(4)
            Loop



            myReader.Close()

            If (login.Trim = "") Then

                MsgBox("Veuillez entrer vos identifiants")
                TextBox_login.BackColor = Color.Red
                TextBox_password.BackColor = Color.Red

            ElseIf (password.Trim = "") Then

                MsgBox("Veuillez entrer un mot de passe !")
                TextBox_password.BackColor = Color.Red

            ElseIf (login_sql <> login) Then

                MsgBox("Ce login n'existe pas !")
                TextBox_login.BackColor = Color.Red

            ElseIf (password_sql <> password) Then

                MsgBox("Mauvais mot de passe !")
                TextBox_password.BackColor = Color.Red

            ElseIf (login_sql = login And password_sql = password) Then

                RechercheSalles.Show()
                'Me.Close()
            End If

        End If

    End Sub

End Class