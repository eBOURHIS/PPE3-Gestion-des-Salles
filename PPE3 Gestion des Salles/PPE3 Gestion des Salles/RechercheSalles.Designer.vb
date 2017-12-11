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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MonProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DéconnexionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsulterLagendaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlusDeRechercheToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RechercheParÉtatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabelTableauHoraire25 = New System.Windows.Forms.Label()
        Me.TableauHorairesDispo = New System.Windows.Forms.DataGridView()
        Me.ListeSalles = New System.Windows.Forms.ComboBox()
        Me.DataSet1 = New PPE3_Gestion_des_Salles.DataSet1()
        Me.EMPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EMPTableAdapter = New PPE3_Gestion_des_Salles.DataSet1TableAdapters.EMPTableAdapter()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TableauSallesDispo = New System.Windows.Forms.DataGridView()
        Me.ListeHoraire = New System.Windows.Forms.ComboBox()
        Me.LabelTableauHoraire = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.TableauHorairesDispo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableauSallesDispo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 377)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Rechercher par nom de salle :"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MonProfileToolStripMenuItem, Me.DéconnexionToolStripMenuItem, Me.ConsulterLagendaToolStripMenuItem, Me.PlusDeRechercheToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(848, 29)
        Me.MenuStrip1.TabIndex = 31
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MonProfileToolStripMenuItem
        '
        Me.MonProfileToolStripMenuItem.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonProfileToolStripMenuItem.Name = "MonProfileToolStripMenuItem"
        Me.MonProfileToolStripMenuItem.Size = New System.Drawing.Size(106, 25)
        Me.MonProfileToolStripMenuItem.Text = "Mon profil"
        '
        'DéconnexionToolStripMenuItem
        '
        Me.DéconnexionToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.DéconnexionToolStripMenuItem.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DéconnexionToolStripMenuItem.Name = "DéconnexionToolStripMenuItem"
        Me.DéconnexionToolStripMenuItem.Size = New System.Drawing.Size(123, 25)
        Me.DéconnexionToolStripMenuItem.Text = "Déconnexion"
        '
        'ConsulterLagendaToolStripMenuItem
        '
        Me.ConsulterLagendaToolStripMenuItem.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConsulterLagendaToolStripMenuItem.Name = "ConsulterLagendaToolStripMenuItem"
        Me.ConsulterLagendaToolStripMenuItem.Size = New System.Drawing.Size(163, 25)
        Me.ConsulterLagendaToolStripMenuItem.Text = "Consulter l'agenda"
        '
        'PlusDeRechercheToolStripMenuItem
        '
        Me.PlusDeRechercheToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RechercheParÉtatToolStripMenuItem})
        Me.PlusDeRechercheToolStripMenuItem.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlusDeRechercheToolStripMenuItem.Name = "PlusDeRechercheToolStripMenuItem"
        Me.PlusDeRechercheToolStripMenuItem.Size = New System.Drawing.Size(160, 25)
        Me.PlusDeRechercheToolStripMenuItem.Text = "Plus de recherche"
        '
        'RechercheParÉtatToolStripMenuItem
        '
        Me.RechercheParÉtatToolStripMenuItem.Name = "RechercheParÉtatToolStripMenuItem"
        Me.RechercheParÉtatToolStripMenuItem.Size = New System.Drawing.Size(226, 26)
        Me.RechercheParÉtatToolStripMenuItem.Text = "Recherche par état"
        '
        'LabelTableauHoraire25
        '
        Me.LabelTableauHoraire25.AutoSize = True
        Me.LabelTableauHoraire25.Location = New System.Drawing.Point(462, 35)
        Me.LabelTableauHoraire25.Name = "LabelTableauHoraire25"
        Me.LabelTableauHoraire25.Size = New System.Drawing.Size(0, 13)
        Me.LabelTableauHoraire25.TabIndex = 43
        '
        'TableauHorairesDispo
        '
        Me.TableauHorairesDispo.AllowUserToAddRows = False
        Me.TableauHorairesDispo.AllowUserToDeleteRows = False
        Me.TableauHorairesDispo.AllowUserToResizeRows = False
        Me.TableauHorairesDispo.BackgroundColor = System.Drawing.Color.SlateGray
        Me.TableauHorairesDispo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TableauHorairesDispo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.TableauHorairesDispo.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TableauHorairesDispo.DefaultCellStyle = DataGridViewCellStyle8
        Me.TableauHorairesDispo.Location = New System.Drawing.Point(272, 377)
        Me.TableauHorairesDispo.Name = "TableauHorairesDispo"
        Me.TableauHorairesDispo.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableauHorairesDispo.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.TableauHorairesDispo.Size = New System.Drawing.Size(544, 233)
        Me.TableauHorairesDispo.TabIndex = 45
        '
        'ListeSalles
        '
        Me.ListeSalles.FormattingEnabled = True
        Me.ListeSalles.Location = New System.Drawing.Point(44, 410)
        Me.ListeSalles.Name = "ListeSalles"
        Me.ListeSalles.Size = New System.Drawing.Size(121, 21)
        Me.ListeSalles.TabIndex = 10
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EMPBindingSource
        '
        Me.EMPBindingSource.DataMember = "EMP"
        Me.EMPBindingSource.DataSource = Me.DataSet1
        '
        'EMPTableAdapter
        '
        Me.EMPTableAdapter.ClearBeforeFill = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(2, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(264, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Rechercher par tranche horaire :"
        '
        'TableauSallesDispo
        '
        Me.TableauSallesDispo.AllowDrop = True
        Me.TableauSallesDispo.AllowUserToDeleteRows = False
        Me.TableauSallesDispo.BackgroundColor = System.Drawing.Color.SlateGray
        Me.TableauSallesDispo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Modern No. 20", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TableauSallesDispo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.TableauSallesDispo.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TableauSallesDispo.DefaultCellStyle = DataGridViewCellStyle11
        Me.TableauSallesDispo.Location = New System.Drawing.Point(272, 66)
        Me.TableauSallesDispo.Name = "TableauSallesDispo"
        Me.TableauSallesDispo.ReadOnly = True
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableauSallesDispo.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.TableauSallesDispo.Size = New System.Drawing.Size(544, 233)
        Me.TableauSallesDispo.TabIndex = 39
        '
        'ListeHoraire
        '
        Me.ListeHoraire.FormattingEnabled = True
        Me.ListeHoraire.Location = New System.Drawing.Point(44, 100)
        Me.ListeHoraire.Name = "ListeHoraire"
        Me.ListeHoraire.Size = New System.Drawing.Size(121, 21)
        Me.ListeHoraire.TabIndex = 48
        '
        'LabelTableauHoraire
        '
        Me.LabelTableauHoraire.AutoSize = True
        Me.LabelTableauHoraire.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTableauHoraire.Location = New System.Drawing.Point(450, 353)
        Me.LabelTableauHoraire.Name = "LabelTableauHoraire"
        Me.LabelTableauHoraire.Size = New System.Drawing.Size(0, 21)
        Me.LabelTableauHoraire.TabIndex = 49
        '
        'RechercheSalles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 678)
        Me.Controls.Add(Me.LabelTableauHoraire)
        Me.Controls.Add(Me.ListeSalles)
        Me.Controls.Add(Me.ListeHoraire)
        Me.Controls.Add(Me.TableauHorairesDispo)
        Me.Controls.Add(Me.LabelTableauHoraire25)
        Me.Controls.Add(Me.TableauSallesDispo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "RechercheSalles"
        Me.Text = "Recherche de salles"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.TableauHorairesDispo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableauSallesDispo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MonProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DéconnexionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsulterLagendaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelTableauHoraire25 As System.Windows.Forms.Label
    Friend WithEvents TableauHorairesDispo As System.Windows.Forms.DataGridView
    Friend WithEvents ListeSalles As System.Windows.Forms.ComboBox
    Friend WithEvents DataSet1 As PPE3_Gestion_des_Salles.DataSet1
    Friend WithEvents EMPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EMPTableAdapter As PPE3_Gestion_des_Salles.DataSet1TableAdapters.EMPTableAdapter
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TableauSallesDispo As System.Windows.Forms.DataGridView
    Friend WithEvents ListeHoraire As System.Windows.Forms.ComboBox
    Friend WithEvents PlusDeRechercheToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RechercheParÉtatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelTableauHoraire As System.Windows.Forms.Label

End Class
