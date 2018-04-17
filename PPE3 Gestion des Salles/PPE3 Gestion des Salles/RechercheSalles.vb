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
        myConnection.Close()
        connString = "DSN=ORA13;Uid=Admin_GSB;Pwd=estran;"

        myConnection.ConnectionString = connString

        Try
            myConnection.Open()
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try

        Dim querySalle As String = "SELECT NOM_SALLE FROM SALLE"
        myCommand.Connection = myConnection
        myCommand.CommandText = querySalle
        myReader = myCommand.ExecuteReader

        While myReader.Read
            Me.ListeSalles.Items.Add(myReader.GetString(0))
        End While
        myConnection.Close()
        myConnection.Open()

        '----------------------------------------------------

        Me.Label7.Text = "Connecté : " & Main.nomEmploye & " " & Main.prenomEmploye

    End Sub

    Private Sub RechercheHoraire_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RechercheHoraire.Click

        myConnection.Close()
        myConnection.Open()
        Dim datechoisie = Me.datechoisie.Text
        Dim query As String = "CREATE OR REPLACE FORCE VIEW ""ADMIN_GSB"".""V_SALLE_DISPO"" (""ID_SALLE"") AS SELECT SALLE.ID_SALLE FROM SALLE MINUS SELECT RESERVATION.ID_SALLE FROM RESERVATION WHERE TO_CHAR(DATEDEBUT, 'DD-MM-YYYY HH24:MI:SS') = '" & datechoisie & "';"
        Me.LabelTableauSalles.Text = ("Voici les salles disponibles à cette horaire :")
        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)
        TableauSallesDispo.DataSource = donnee
        myConnection.Close()
        myConnection.Open()

        Dim query2 As String = "SELECT SALLE.NOM_SALLE FROM V_SALLE_DISPO, SALLE WHERE v_salle_dispo.id_salle = SALLE.ID_SALLE;"
        Me.LabelTableauSalles.Text = ("Voici les salles disponibles à cette horaire :")
        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query2, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)
        TableauSallesDispo.DataSource = donnee
        Me.TableauSallesDispo.Columns(0).HeaderText = "Salle"
        myConnection.Close()
        myConnection.Open()
    End Sub

    Private Sub ListeSalles_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListeSalles.SelectedIndexChanged
        Dim salle_name As String = ListeSalles.SelectedItem.ToString()
        Dim query As String = "SELECT DATEDEBUT, DATEFIN FROM SALLE, RESERVATION, ETAT WHERE SALLE.ID_SALLE = RESERVATION.ID_SALLE AND RESERVATION.ID_ETAT = ETAT.ID_ETAT AND ETAT.ID_ETAT = 1 AND NOM_SALLE = '" & salle_name & "';"
        'MsgBox(query)
        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)
        TableauHorairesDispo.DataSource = donnee
        Me.TableauHorairesDispo.Columns(0).HeaderText = "Date de Début"
        Me.TableauHorairesDispo.Columns(1).HeaderText = "Date de Fin"

        If Me.TableauHorairesDispo.Rows.Count < 1 Then
            Me.LabelTableauHoraire.Text = ("La salle " & salle_name & " n'a pas été réservée !")
        Else
            Me.LabelTableauHoraire.Text = ("La salle " & salle_name & " est réservée aux horaires suivants :")
        End If
    End Sub


    Private Sub PlusDeRechercheTool_Click(sender As System.Object, e As System.EventArgs) Handles PlusDeRechercheTool.Click
        VoirReservations.ShowDialog()
    End Sub

    Private Sub RéserverUneSalleToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RéserverUneSalleToolStripMenuItem.Click
        Reservation.ShowDialog()
    End Sub

    Private Sub DéconnexionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DéconnexionToolStripMenuItem.Click

        Dim result As Integer = MessageBox.Show("Se déconnecter et quitter ?", "Se déconnecter", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles datechoisie.TextChanged
       
    End Sub
End Class
