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
        myConnection.Close()
        myConnection.Open()

        '----------------------------------------------------

        Me.Label7.Text = "Connecté : " & Main.nomEmploye & " " & Main.prenomEmploye
        Me.BoxYear.Maximum = Date.Today.Year + 1
        Me.BoxYear.Minimum = Date.Today.Year
        Me.BoxYear.Value = Date.Today.Year

        ' Me.BoxMonth.Value = Date.Today.Month
        ' Me.BoxMonth.Maximum = Date.Today.Month
        Me.BoxMonth.Minimum = Date.Today.Month

        Select Case Today.Date.Month
            Case 1, 3, 5, 7, 8, 10, 12
                Me.BoxDay.Maximum = 31
            Case 2
                Me.BoxDay.Maximum = 28
            Case 4, 6, 9, 11
                Me.BoxDay.Maximum = 30
        End Select
        Me.BoxDay.Value = Date.Today.Day

        Me.BoxHour.Maximum = 23
        Me.BoxHour.Minimum = 0
        Me.BoxHour.Value = Hour(Now())
        '----------------------------------------------------
    End Sub

    Private Sub RechercheHoraire_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RechercheHoraire.Click
        Dim query As String = "SELECT SALLE.NOM_SALLE FROM V_SALLE_DISPO, SALLE WHERE v_salle_dispo.id_salle = SALLE.ID_SALLE;"
        Me.LabelTableauSalles.Text = ("Voici les salles disponibles à cette horaire :")
        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query, myConnection)
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

    Private Sub BoxYear_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoxYear.ValueChanged
        Dim horaire_year As String = Me.BoxYear.Value
        Dim query As String = "CREATE OR REPLACE VIEW v_Salle_Dispo AS SELECT SALLE.ID_SALLE FROM SALLE MINUS SELECT RESERVATION.ID_SALLE FROM RESERVATION WHERE TO_CHAR(DATEDEBUT, 'YYYY') = '" & horaire_year & "' ;"
        myCommand.Connection = myConnection
        myCommand.CommandText = query
        myReader = myCommand.ExecuteReader
        myConnection.Close()
        myConnection.Open()
        If Me.BoxYear.Value = Date.Today.Year + 1 Then
            Me.BoxMonth.Maximum = 12
            Me.BoxMonth.Minimum = 1
        End If

    End Sub
    Private Sub BoxMonth_ValueChanged(sender As System.Object, e As System.EventArgs) Handles BoxMonth.ValueChanged
        Dim horaire_month As String = Me.BoxMonth.Value
        Dim query As String = "CREATE OR REPLACE VIEW v_Salle_Dispo AS SELECT SALLE.ID_SALLE FROM SALLE MINUS SELECT RESERVATION.ID_SALLE FROM RESERVATION WHERE TO_CHAR(DATEDEBUT, 'MM') = '" & horaire_month & "';"
        myCommand.Connection = myConnection
        myCommand.CommandText = query
        myReader = myCommand.ExecuteReader
        myConnection.Close()
        myConnection.Open()
    End Sub

    Private Sub BoxDay_ValueChanged(sender As System.Object, e As System.EventArgs) Handles BoxDay.ValueChanged
        Dim horaire_day As String = Me.BoxDay.Value
        Dim query As String = "CREATE OR REPLACE VIEW v_Salle_Dispo AS SELECT SALLE.ID_SALLE FROM SALLE MINUS SELECT RESERVATION.ID_SALLE FROM RESERVATION WHERE TO_CHAR(DATEDEBUT, 'DD') = '" & horaire_day & "';"
        myCommand.Connection = myConnection
        myCommand.CommandText = query
        myReader = myCommand.ExecuteReader
        myConnection.Close()
        myConnection.Open()
    End Sub

    Private Sub BoxHour_ValueChanged(sender As System.Object, e As System.EventArgs) Handles BoxHour.ValueChanged
        Dim horaire_hour As String = Me.BoxHour.Value
        Dim query As String = "CREATE OR REPLACE VIEW v_Salle_Dispo AS SELECT SALLE.ID_SALLE FROM SALLE MINUS SELECT RESERVATION.ID_SALLE FROM RESERVATION WHERE TO_CHAR(DATEDEBUT, 'HH24') = '" & horaire_hour & "';"
        myCommand.Connection = myConnection
        myCommand.CommandText = query
        myReader = myCommand.ExecuteReader
        myConnection.Close()
        myConnection.Open()
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
End Class
