Imports System.Data.DataTable

Public Class RechercheSalles

    Dim table As New DataTable("Table")
    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String
    Dim donnee As DataTable

    Private Sub RecherchesSalles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        connString = "DSN=ORA13;Uid=Admin_GSB;Pwd=estran;"

        myConnection.ConnectionString = connString

        Try
            myConnection.Open()
            MessageBox.Show("Connexion Oracle Réussie")
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try

        Dim query As String = "SELECT DATEDEBUT, DATEFIN FROM RESERVATION"
        myCommand.Connection = myConnection
        myCommand.CommandText = query
        myReader = myCommand.ExecuteReader
        
        While myReader.Read
            Me.ListeHoraire.Items.Add(myReader.GetString(0))
        End While

        myConnection.Close()
        myConnection.Open()

        Dim querySalle As String = "SELECT NOM_SALLE FROM SALLE"
        myCommand.Connection = myConnection
        myCommand.CommandText = querySalle
        myReader = myCommand.ExecuteReader

        While myReader.Read
            Me.ListeSalles.Items.Add(myReader.GetString(0))
        End While

    End Sub

    Private Sub BoutonRechercheparHoraire_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.TableauSallesDispo.Rows.Add("D22", "D23", "D21")
        Me.TableauSallesDispo.Rows.Add("D24", "D21", "D20")
        Me.ListeHoraire.Enabled = False
        Me.LabelTableauHoraire25.Text = ("Salles disponibles pour la tranche horaire : " + Me.ListeHoraire.Text + " h :")

    End Sub

    Private Sub BoutonNouvelleRecherche_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ListeHoraire.Enabled = True
        Me.TableauSallesDispo.Rows.Clear()
        Me.LabelTableauHoraire25.Text = ""
    End Sub

    Private Sub ListeHoraire_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListeHoraire.SelectedIndexChanged
        Dim horaire_salle As String = ListeHoraire.SelectedItem.ToString()
        Dim query As String = "SELECT NOM_SALLE FROM RESERVATION, SALLE WHERE RESERVATION.ID_SALLE = SALLE.ID_SALLE AND DATEDEBUT = '" & horaire_salle & "';"
        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)
        TableauSallesDispo.DataSource = donnee
        myConnection.Close()
        myConnection.Open()
    End Sub

    Private Sub ListeSalles_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListeSalles.SelectedIndexChanged
        Dim salle_name As String = ListeSalles.SelectedItem.ToString()
        Dim query As String = "SELECT DATEDEBUT, DATEFIN FROM SALLE, RESERVATION, ETAT WHERE SALLE.ID_SALLE = RESERVATION.ID_SALLE AND RESERVATION.ID_ETAT = ETAT.ID_ETAT AND ETAT.ID_ETAT = 1 OR ETAT.ID_ETAT = 2 AND NOM_SALLE = '" & salle_name & "';"
        Me.LabelTableauHoraire.Text = ("La salle " & salle_name & " est disponible aux horaires suivants")
        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)
        TableauHorairesDispo.DataSource = donnee
    End Sub

    Private Sub RechercheParÉtatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RechercheParÉtatToolStripMenuItem.Click
        VerificationEtatSalle.ShowDialog()
    End Sub
End Class
