Public Class VerificationEtatSalle
    Dim table As New DataTable("Table")
    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String
    Dim donnee As DataTable

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connString = "DSN=ORA13;Uid=Admin_GSB;Pwd=estran;"

        myConnection.ConnectionString = connString

        Try
            myConnection.Open()
            'MessageBox.Show("Connexion Oracle Réussie")
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try

        Dim querySalle As String = "SELECT LIBELLE FROM ETAT"
        myCommand.Connection = myConnection
        myCommand.CommandText = querySalle
        myReader = myCommand.ExecuteReader

        While myReader.Read
            Me.Liste_Etats.Items.Add(Trim(myReader.GetString(0)))
        End While

    End Sub


    Private Sub Liste_Etats_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Liste_Etats.SelectedIndexChanged

        Dim etat As String = Liste_Etats.SelectedItem
        Dim query As String = "SELECT NOM_SALLE FROM SALLE, RESERVATION, ETAT WHERE SALLE.ID_SALLE = RESERVATION.ID_SALLE AND RESERVATION.ID_ETAT = ETAT.ID_ETAT AND ETAT.LIBELLE ='" & etat & "'"
        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)
        TableauVerifSalleDispo.DataSource = donnee

    End Sub
End Class