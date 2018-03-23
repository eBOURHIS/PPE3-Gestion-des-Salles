﻿Public Class VoirReservations
    Dim table As New DataTable("Table")
    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String
    Dim donnee As DataTable


    Private Sub VoirReservations_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        connString = "DSN=ORA13;Uid=Admin_GSB;Pwd=estran;"

        myConnection.ConnectionString = connString

        Try
            myConnection.Open()
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try

        Dim query As String = "SELECT RESERVATION.ID_SALLE, NOM_SALLE, DATEDEBUT, DATEFIN, LIBELLERESERVATION FROM RESERVATION, SALLE WHERE salle.id_salle = RESERVATION.ID_SALLE AND RESERVATION.ID_EMPLOYE = " & Main.idEmploye & ""
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
        Me.MesReservations.Columns(2).HeaderText = "Commentaire"
        Me.Info.Text = "Connecté : " & Main.nomEmploye & " " & Main.prenomEmploye

        myConnection.Close()

    End Sub

    Private Sub MesReservations_CellMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MesReservations.CellMouseDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow = Me.MesReservations.Rows(e.RowIndex)
            Dim values As New Collection
            For i As Integer = 0 To Me.MesReservations.ColumnCount - 1
                Debug.Print(selectedRow.Cells.Item(i).Value.ToString())
                values.Add(selectedRow.Cells.Item(i).Value.ToString())
            Next
            myConnection.Open()
            Select Case MsgBox("Voulez vous supprimer cette réservation ?", MsgBoxStyle.YesNo, "Supprimer une réservation")
                Case MsgBoxResult.Yes
                    Try
                        Dim queryGetId As String = "DELETE FROM RESERVATION WHERE ID_SALLE = '" & values(1) & "' AND DATEDEBUT = to_date('" & values(3) & "','DD-MM-YYYY HH24:MI:SS')"
                        Debug.Print(queryGetId)
                        myCommand.Connection = myConnection
                        myCommand.CommandText = queryGetId
                        myReader = myCommand.ExecuteReader
                        MessageBox.Show("Réservation supprimée !")
                    Catch ex As Exception
                        MessageBox.Show("Erreur !")
                    End Try
                Case MsgBoxResult.No
                    MessageBox.Show("Opération annulée.")
            End Select
            myConnection.Close()
        End If


    End Sub
End Class