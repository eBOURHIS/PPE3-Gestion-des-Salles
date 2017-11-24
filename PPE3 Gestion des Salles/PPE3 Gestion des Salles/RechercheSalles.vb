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

        connString = "DSN=ORA13;Uid=scott;Pwd=estran;"

        myConnection.ConnectionString = connString

        Try
            myConnection.Open()
            MessageBox.Show("Connexion Oracle Réussie")
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try

        Dim query As String = "SELECT table_name FROM user_tables"
        myCommand.Connection = myConnection
        myCommand.CommandText = query
        myReader = myCommand.ExecuteReader

        'While myReader.Read
        'nomBox.Items.Add(myReader.GetString(0))
        'End While
    End Sub

    Private Sub BoutonRechercheparHoraire_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoutonRechercheparHoraire.Click
        Me.TableauSallesDispo.Rows.Add("D22", "D23", "D21")
        Me.TableauSallesDispo.Rows.Add("D24", "D21", "D20")
        Me.ListeHoraire.Enabled = False
        Me.BoutonRechercheparHoraire.Enabled = False
        Me.BoutonNouvelleRecherche1.Enabled = True
        Me.LabelTableauHoraire.Text = ("Salles disponibles pour la tranche horaire : " + Me.ListeHoraire.Text + " h :")
                                        
    End Sub

    Private Sub BoutonNouvelleRecherche_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoutonNouvelleRecherche1.Click
        Me.ListeHoraire.Enabled = True
        Me.BoutonRechercheparHoraire.Enabled = True
        Me.BoutonNouvelleRecherche1.Enabled = False
        Me.TableauSallesDispo.Rows.Clear()
        Me.LabelTableauHoraire.Text = ""
    End Sub

    Private Sub BoutonRechercheparSalles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoutonRechercheparSalle.Click
        Me.TableauHorairesDispo.Rows.Add("Disponible", "Disponible", "Disponible")
        Me.ListeSalles.Enabled = False
        Me.BoutonRechercheparSalle.Enabled = False
        Me.BoutonNouvelleRecherche2.Enabled = True
        Me.LabelTableauSalles.Text = ("La salle " + Me.ListeSalles.Text + " est disponible aux créneaux horaires suivants : ")
    End Sub

    Private Sub BoutonNouvelleRecherche2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoutonNouvelleRecherche2.Click
        Me.ListeSalles.Enabled = True
        Me.BoutonRechercheparSalle.Enabled = True
        Me.BoutonNouvelleRecherche2.Enabled = False
        Me.TableauHorairesDispo.Rows.Clear()
        Me.LabelTableauSalles.Text = ""
        Me.ListeSalles.Text = ""
    End Sub

    Private Sub ListeHoraire_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListeHoraire.SelectedIndexChanged
        Me.BoutonRechercheparHoraire.Enabled = True
    End Sub

    Private Sub ListeSalles_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListeSalles.SelectedIndexChanged
        Me.BoutonRechercheparSalle.Enabled = True
    End Sub

End Class
