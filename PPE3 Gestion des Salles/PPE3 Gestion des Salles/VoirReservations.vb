Public Class VoirReservations
    Dim table As New DataTable("Table")
    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String
    Dim donnee As DataTable


    Private Sub VoirReservations_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        connString = "DSN=GSB;Uid=Admin_GSB;Pwd=estran;"

        myConnection.ConnectionString = connString

        Try
            myConnection.Open()
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try

        Dim query As String = "SELECT NOM_SALLE, DATEDEBUT, DATEFIN FROM RESERVATION, SALLE WHERE salle.id_salle = RESERVATION.ID_SALLE AND RESERVATION.ID_EMPLOYE = 1"
        myCommand.Connection = myConnection
        myCommand.CommandText = query
        myReader = myCommand.ExecuteReader

        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)
        Me.MesReservations.DataSource = donnee
        Me.MesReservations.Columns(0).HeaderText = "Salle"
        Me.MesReservations.Columns(1).HeaderText = "Date de début"
        Me.MesReservations.Columns(2).HeaderText = "Date de fin"

        myConnection.Close()
        myConnection.Open()
    End Sub
End Class