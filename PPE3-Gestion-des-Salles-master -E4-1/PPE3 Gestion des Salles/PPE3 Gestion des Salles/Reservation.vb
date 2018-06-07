Public Class Reservation
    Dim table As New DataTable("Table")
    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String
    Dim donnee As DataTable

    Private Sub Reservation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        myConnection.Close()
        'local
        connString = "DSN=ORA13;Uid=Admin_GSB;Pwd=estran;"

        'prod
        'connString = "DSN=ORAPROD;Uid=PPE3;Pwd=estran;"

        myConnection.ConnectionString = connString

        Try
            myConnection.Open()
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try

        Dim queryNomSalle As String = "SELECT ID_SALLE, NOM_SALLE FROM SALLE"
        myCommand.Connection = myConnection
        myCommand.CommandText = queryNomSalle
        myReader = myCommand.ExecuteReader
        Dim values As New Dictionary(Of Integer, String)

        While myReader.Read
            values.Add(myReader.GetString(0), myReader.GetString(1))
        End While

        Me.ListeSalles.DataSource = New BindingSource(values, Nothing)
        Me.ListeSalles.DisplayMember = "Value"
        Me.ListeSalles.ValueMember = "Key"

        Me.Info.Text = "Connecté : " & Main.nomEmploye & " " & Main.prenomEmploye
        Me.BoxYearDebut.Maximum = Date.Today.Year + 1
        Me.BoxYearDebut.Minimum = Date.Today.Year
        Me.BoxYearDebut.Value = Date.Today.Year

        Me.BoxMonthDebut.Maximum = 12
        Me.BoxMonthDebut.Minimum = Date.Today.Month
        Me.BoxMonthDebut.Value = Date.Today.Month

        Select Case Today.Date.Month
            Case 1, 3, 5, 7, 8, 10, 12
                Me.BoxDayDebut.Maximum = 31
            Case 2
                Me.BoxDayDebut.Maximum = 28
            Case 4, 6, 9, 11
                Me.BoxDayDebut.Maximum = 30
        End Select

        Me.BoxDayDebut.Minimum = Date.Today.Day
        Me.BoxDayDebut.Value = Date.Today.Day

        Me.BoxHour.Maximum = 23
        Me.BoxHour.Minimum = 0
        Me.BoxHour.Value = Hour(Now())

        myConnection.Close()
        myConnection.Open()

    End Sub

    Private Sub BoutonReservationValide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoutonReservationValide.Click

        Dim horaire_year As String = Me.BoxYearDebut.Value
        Dim horaire_month As String = Me.BoxMonthDebut.Value
        Dim horaire_day As String = Me.BoxDayDebut.Value
        Dim horaire_hour As String = Me.BoxHour.Value

        Dim Libelle = Me.DescriptionBox.Text
        Dim idSalle = Me.ListeSalles.SelectedValue.ToString
        Try
            Dim query As String = "INSERT INTO RESERVATION (ID_SALLE, ID_EMPLOYE, ID_ETAT, DATEDEBUT, LIBELLERESERVATION) VALUES (" & idSalle & ", " & Main.idEmploye & ", 1, TO_DATE('" & horaire_day & "-" & horaire_month & "-" & horaire_year & " " & horaire_hour & ":00:00', 'DD-MM-YYYY HH24:MI:SS'),'" & Libelle & "');"
            myCommand.Connection = myConnection
            myCommand.CommandText = query
            myReader = myCommand.ExecuteReader
            MsgBox("Réservation effectuée !")
        Catch ex As Exception
            MsgBox("Erreur !")
        End Try



        myConnection.Close()
        myConnection.Open()

    End Sub

    Private Sub Reservation_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        myConnection.Close()
        myConnection.Open()
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub BoxYear_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoxYearDebut.ValueChanged

    End Sub

    Private Sub Calculer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCalculer.Click

    End Sub

    Private Sub RadioButtonsemaine_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonsemaine.CheckedChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonjour.CheckedChanged

    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click

    End Sub

    Private Sub TableauHorairesDispo_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TableauCalculPeriode.CellContentClick

    End Sub
End Class