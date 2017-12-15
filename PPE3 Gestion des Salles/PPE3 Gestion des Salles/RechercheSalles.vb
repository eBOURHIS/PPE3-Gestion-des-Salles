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

        Me.BoxYear.Maximum = Date.Today.Year
        Me.BoxYear.Minimum = Date.Today.Year
        Me.BoxYear.Value = Date.Today.Year

        Me.BoxMonth.Maximum = Date.Today.Month
        Me.BoxMonth.Minimum = Date.Today.Month
        Me.BoxMonth.Value = Date.Today.Month

        Me.BoxDay.Minimum = Date.Today.Day
        Me.BoxDay.Value = Date.Today.Day

        Me.BoxHour.Maximum = 24
        Me.BoxHour.Minimum = 1
        Me.BoxHour.Value = Hour(Now())
    End Sub

    Private Sub RechercheHoraire_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RechercheHoraire.Click
        Dim horaire_year As String = Me.BoxYear.Value
        Dim horaire_month As String = Me.BoxMonth.Value
        Dim horaire_day As String = Me.BoxDay.Value
        Dim horaire_hour As String = Me.BoxHour.Value
        Dim query As String = "SELECT NOM_SALLE FROM RESERVATION, SALLE WHERE RESERVATION.ID_SALLE = SALLE.ID_SALLE AND TO_CHAR(DATEDEBUT, 'DD') != '" & horaire_day & "' AND TO_CHAR(DATEDEBUT,'HH') != '" & horaire_hour & "';"
        Me.LabelTableauSalles.Text = ("Voici le(s) salle(s) disponible(s) à cette horaire")
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
        Me.LabelTableauHoraire.Text = ("La salle " & salle_name & " est indisponible aux horaires suivants")
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
