<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RechercheSalles
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MonProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DéconnexionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsulterLagendaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabelTableauSalles = New System.Windows.Forms.Label()
        Me.TableauSallesDispo = New System.Windows.Forms.DataGridView()
        Me.Lundi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mardi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mercredi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Jeudi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vendredi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BoutonRechercheparSalle = New System.Windows.Forms.Button()
        Me.BoutonRechercheparHoraire = New System.Windows.Forms.Button()
        Me.LabelTableauHoraire = New System.Windows.Forms.Label()
        Me.BoutonNouvelleRecherche1 = New System.Windows.Forms.Button()
        Me.BoutonNouvelleRecherche2 = New System.Windows.Forms.Button()
        Me.TableauHorairesDispo = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListeHoraire = New System.Windows.Forms.ComboBox()
        Me.ListeSalles = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.TableauSallesDispo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableauHorairesDispo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 371)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Rechercher par nom de salle :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Rechercher par tranche horaire :"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MonProfileToolStripMenuItem, Me.DéconnexionToolStripMenuItem, Me.ConsulterLagendaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(848, 24)
        Me.MenuStrip1.TabIndex = 31
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MonProfileToolStripMenuItem
        '
        Me.MonProfileToolStripMenuItem.Name = "MonProfileToolStripMenuItem"
        Me.MonProfileToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.MonProfileToolStripMenuItem.Text = "Mon profil"
        '
        'DéconnexionToolStripMenuItem
        '
        Me.DéconnexionToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.DéconnexionToolStripMenuItem.Name = "DéconnexionToolStripMenuItem"
        Me.DéconnexionToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.DéconnexionToolStripMenuItem.Text = "Déconnexion"
        '
        'ConsulterLagendaToolStripMenuItem
        '
        Me.ConsulterLagendaToolStripMenuItem.Name = "ConsulterLagendaToolStripMenuItem"
        Me.ConsulterLagendaToolStripMenuItem.Size = New System.Drawing.Size(118, 20)
        Me.ConsulterLagendaToolStripMenuItem.Text = "Consulter l'agenda"
        '
        'LabelTableauSalles
        '
        Me.LabelTableauSalles.AutoSize = True
        Me.LabelTableauSalles.Location = New System.Drawing.Point(451, 359)
        Me.LabelTableauSalles.Name = "LabelTableauSalles"
        Me.LabelTableauSalles.Size = New System.Drawing.Size(0, 13)
        Me.LabelTableauSalles.TabIndex = 32
        '
        'TableauSallesDispo
        '
        Me.TableauSallesDispo.AllowUserToAddRows = False
        Me.TableauSallesDispo.AllowUserToDeleteRows = False
        Me.TableauSallesDispo.AllowUserToResizeColumns = False
        Me.TableauSallesDispo.AllowUserToResizeRows = False
        Me.TableauSallesDispo.BackgroundColor = System.Drawing.Color.SlateGray
        Me.TableauSallesDispo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TableauSallesDispo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.TableauSallesDispo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Lundi, Me.Mardi, Me.Mercredi, Me.Jeudi, Me.Vendredi})
        Me.TableauSallesDispo.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TableauSallesDispo.DefaultCellStyle = DataGridViewCellStyle2
        Me.TableauSallesDispo.Location = New System.Drawing.Point(272, 66)
        Me.TableauSallesDispo.Name = "TableauSallesDispo"
        Me.TableauSallesDispo.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableauSallesDispo.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.TableauSallesDispo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TableauSallesDispo.Size = New System.Drawing.Size(544, 233)
        Me.TableauSallesDispo.TabIndex = 39
        '
        'Lundi
        '
        Me.Lundi.HeaderText = "Lundi"
        Me.Lundi.Name = "Lundi"
        Me.Lundi.ReadOnly = True
        '
        'Mardi
        '
        Me.Mardi.HeaderText = "Mardi"
        Me.Mardi.Name = "Mardi"
        Me.Mardi.ReadOnly = True
        '
        'Mercredi
        '
        Me.Mercredi.HeaderText = "Mercredi"
        Me.Mercredi.Name = "Mercredi"
        Me.Mercredi.ReadOnly = True
        '
        'Jeudi
        '
        Me.Jeudi.HeaderText = "Jeudi"
        Me.Jeudi.Name = "Jeudi"
        Me.Jeudi.ReadOnly = True
        '
        'Vendredi
        '
        Me.Vendredi.HeaderText = "Vendredi"
        Me.Vendredi.Name = "Vendredi"
        Me.Vendredi.ReadOnly = True
        '
        'BoutonRechercheparSalle
        '
        Me.BoutonRechercheparSalle.Enabled = False
        Me.BoutonRechercheparSalle.Location = New System.Drawing.Point(41, 577)
        Me.BoutonRechercheparSalle.Name = "BoutonRechercheparSalle"
        Me.BoutonRechercheparSalle.Size = New System.Drawing.Size(82, 46)
        Me.BoutonRechercheparSalle.TabIndex = 40
        Me.BoutonRechercheparSalle.Text = "Rechercher"
        Me.BoutonRechercheparSalle.UseVisualStyleBackColor = True
        '
        'BoutonRechercheparHoraire
        '
        Me.BoutonRechercheparHoraire.Enabled = False
        Me.BoutonRechercheparHoraire.Location = New System.Drawing.Point(41, 253)
        Me.BoutonRechercheparHoraire.Name = "BoutonRechercheparHoraire"
        Me.BoutonRechercheparHoraire.Size = New System.Drawing.Size(82, 46)
        Me.BoutonRechercheparHoraire.TabIndex = 41
        Me.BoutonRechercheparHoraire.Text = "Rechercher"
        Me.BoutonRechercheparHoraire.UseVisualStyleBackColor = True
        '
        'LabelTableauHoraire
        '
        Me.LabelTableauHoraire.AutoSize = True
        Me.LabelTableauHoraire.Location = New System.Drawing.Point(462, 35)
        Me.LabelTableauHoraire.Name = "LabelTableauHoraire"
        Me.LabelTableauHoraire.Size = New System.Drawing.Size(0, 13)
        Me.LabelTableauHoraire.TabIndex = 43
        '
        'BoutonNouvelleRecherche1
        '
        Me.BoutonNouvelleRecherche1.Enabled = False
        Me.BoutonNouvelleRecherche1.Location = New System.Drawing.Point(454, 305)
        Me.BoutonNouvelleRecherche1.Name = "BoutonNouvelleRecherche1"
        Me.BoutonNouvelleRecherche1.Size = New System.Drawing.Size(155, 37)
        Me.BoutonNouvelleRecherche1.TabIndex = 42
        Me.BoutonNouvelleRecherche1.Text = "Nouvelle recherche"
        Me.BoutonNouvelleRecherche1.UseVisualStyleBackColor = True
        '
        'BoutonNouvelleRecherche2
        '
        Me.BoutonNouvelleRecherche2.Enabled = False
        Me.BoutonNouvelleRecherche2.Location = New System.Drawing.Point(454, 629)
        Me.BoutonNouvelleRecherche2.Name = "BoutonNouvelleRecherche2"
        Me.BoutonNouvelleRecherche2.Size = New System.Drawing.Size(155, 37)
        Me.BoutonNouvelleRecherche2.TabIndex = 44
        Me.BoutonNouvelleRecherche2.Text = "Nouvelle recherche"
        Me.BoutonNouvelleRecherche2.UseVisualStyleBackColor = True
        '
        'TableauHorairesDispo
        '
        Me.TableauHorairesDispo.AllowUserToAddRows = False
        Me.TableauHorairesDispo.AllowUserToDeleteRows = False
        Me.TableauHorairesDispo.AllowUserToResizeColumns = False
        Me.TableauHorairesDispo.AllowUserToResizeRows = False
        Me.TableauHorairesDispo.BackgroundColor = System.Drawing.Color.SlateGray
        Me.TableauHorairesDispo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TableauHorairesDispo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.TableauHorairesDispo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11})
        Me.TableauHorairesDispo.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TableauHorairesDispo.DefaultCellStyle = DataGridViewCellStyle5
        Me.TableauHorairesDispo.Location = New System.Drawing.Point(272, 390)
        Me.TableauHorairesDispo.Name = "TableauHorairesDispo"
        Me.TableauHorairesDispo.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableauHorairesDispo.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.TableauHorairesDispo.Size = New System.Drawing.Size(544, 233)
        Me.TableauHorairesDispo.TabIndex = 45
        '
        'Column1
        '
        Me.Column1.HeaderText = "8:00 - 9:00"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "9:00 - 10:00"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "10:00 - 11:00"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "11:00 - 12:00"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "12:00 - 13:00"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "13:00 - 14:00"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "14:00 - 15:00"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.HeaderText = "15:00 - 16:00"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.HeaderText = "16:00 - 17:00"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'Column11
        '
        Me.Column11.HeaderText = "17:00 - 18:00"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        '
        'ListeHoraire
        '
        Me.ListeHoraire.FormattingEnabled = True
        Me.ListeHoraire.Items.AddRange(New Object() {"8:00 - 9:00", "9:00 - 10:00", "10:00 - 11:00", "11:00 - 12:00", "12:00 - 13:00", "13:00 - 14:00", "14:00 - 15:00", "15:00 - 16:00", "16:00 - 17:00", "17:00 - 18:00"})
        Me.ListeHoraire.Location = New System.Drawing.Point(44, 95)
        Me.ListeHoraire.Name = "ListeHoraire"
        Me.ListeHoraire.Size = New System.Drawing.Size(121, 21)
        Me.ListeHoraire.TabIndex = 48
        '
        'ListeSalles
        '
        Me.ListeSalles.FormattingEnabled = True
        Me.ListeSalles.Items.AddRange(New Object() {"D20", "D21", "D22", "D23", "D24"})
        Me.ListeSalles.Location = New System.Drawing.Point(44, 401)
        Me.ListeSalles.Name = "ListeSalles"
        Me.ListeSalles.Size = New System.Drawing.Size(121, 21)
        Me.ListeSalles.TabIndex = 49
        '
        'RechercheSalles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 678)
        Me.Controls.Add(Me.ListeSalles)
        Me.Controls.Add(Me.ListeHoraire)
        Me.Controls.Add(Me.TableauHorairesDispo)
        Me.Controls.Add(Me.BoutonNouvelleRecherche2)
        Me.Controls.Add(Me.LabelTableauHoraire)
        Me.Controls.Add(Me.BoutonNouvelleRecherche1)
        Me.Controls.Add(Me.BoutonRechercheparHoraire)
        Me.Controls.Add(Me.BoutonRechercheparSalle)
        Me.Controls.Add(Me.TableauSallesDispo)
        Me.Controls.Add(Me.LabelTableauSalles)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "RechercheSalles"
        Me.Text = "Recherche de salles"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.TableauSallesDispo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableauHorairesDispo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MonProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DéconnexionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelTableauSalles As System.Windows.Forms.Label
    Friend WithEvents TableauSallesDispo As System.Windows.Forms.DataGridView
    Friend WithEvents Lundi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Mardi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Mercredi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Jeudi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Vendredi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConsulterLagendaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BoutonRechercheparSalle As System.Windows.Forms.Button
    Friend WithEvents BoutonRechercheparHoraire As System.Windows.Forms.Button
    Friend WithEvents LabelTableauHoraire As System.Windows.Forms.Label
    Friend WithEvents BoutonNouvelleRecherche1 As System.Windows.Forms.Button
    Friend WithEvents BoutonNouvelleRecherche2 As System.Windows.Forms.Button
    Friend WithEvents TableauHorairesDispo As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ListeHoraire As System.Windows.Forms.ComboBox
    Friend WithEvents ListeSalles As System.Windows.Forms.ComboBox

End Class
