Public Class ModifierReservation
    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String

    Private Sub Reservation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'local
        'connString = "DSN=ORA13;Uid=Admin_GSB;Pwd=estran;"

        'prod
        connString = "DSN=ORAPROD;Uid=PPE3;Pwd=estran;"

        myConnection.ConnectionString = connString

        Try
            myConnection.Open()
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try

        'Dim queryNomSalle As String = "SELECT ID_SALLE, NOM_SALLE FROM SALLE"
        'myCommand.Connection = myConnection
        'myCommand.CommandText = queryNomSalle
        'myReader = myCommand.ExecuteReader
        'Dim values As New Dictionary(Of Integer, String)

        'While myReader.Read
        '    values.Add(myReader.GetString(0), myReader.GetString(1))
        'End While

        'Me.ListeSallesModif.DataSource = New BindingSource(values, Nothing)
        'Me.ListeSallesModif.DisplayMember = "Value"
        'Me.ListeSallesModif.ValueMember = "Key"

        Me.NomSalle.Text = Main.nomSalle

        myConnection.Close()
        myConnection.Open()

        Me.Info.Text = "Connecté : " & Main.nomEmploye & " " & Main.prenomEmploye
        Me.BoxYear.Maximum = Date.Today.Year + 1
        Me.BoxYear.Minimum = Date.Today.Year
        Me.BoxYear.Value = Date.Today.Year

        Me.BoxMonth.Maximum = 12
        'Me.BoxMonth.Minimum = Date.Today.Month
        Me.BoxMonth.Value = Date.Today.Month

        Select Case Today.Date.Month
            Case 1, 3, 5, 7, 8, 10, 12
                Me.BoxDay.Maximum = 31
            Case 2
                Me.BoxDay.Maximum = 28
            Case 4, 6, 9, 11
                Me.BoxDay.Maximum = 30
        End Select

        'Me.BoxDay.Minimum = Date.Today.Day
        Me.BoxDay.Value = Date.Today.Day

        Me.BoxHour.Maximum = 23
        Me.BoxHour.Minimum = 0
        Me.BoxHour.Value = Hour(Now())

    End Sub

    Private Sub BoutonReservationValide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoutonReservationValide.Click
        myConnection.Close()
        myConnection.Open()

        Dim Libelle = Me.DescriptionBox.Text

        Try
            Dim query As String = "UPDATE RESERVATION SET DATEDEBUT = TO_DATE('" & Me.BoxDay.Value & "-" & Me.BoxMonth.Value & "-" & Me.BoxYear.Value & " " & Me.BoxHour.Value & ":00:00', 'DD-MM-YYYY HH24:MI:SS'), LIBELLERESERVATION = '" & Libelle & "' WHERE ID_SALLE = '" & Main.idSalle & "' AND DATEDEBUT = TO_DATE('" & Main.dateDebut & "','DD-MM-YYYY HH24:MI:SS');"
            Debug.Print(query)
            myCommand.Connection = myConnection
            myCommand.CommandText = query
            myReader = myCommand.ExecuteReader
            MsgBox("Réservation modifiée !")
        Catch ex As Exception
            MsgBox("Erreur !")
        End Try

        myConnection.Close()
        myConnection.Open()

        Me.Close()

    End Sub

    Private Sub ModifierReservation_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        myConnection.Close()
    End Sub
End Class
