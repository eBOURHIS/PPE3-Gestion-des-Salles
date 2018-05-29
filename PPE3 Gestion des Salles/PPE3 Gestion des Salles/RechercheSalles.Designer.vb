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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DéconnexionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlusDeRechercheTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.RéserverUneSalleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabelTableauSalles = New System.Windows.Forms.Label()
        Me.TableauHorairesDispo = New System.Windows.Forms.DataGridView()
        Me.ListeSalles = New System.Windows.Forms.ComboBox()
        Me.DataSet1 = New PPE3_Gestion_des_Salles.DataSet1()
        Me.EMPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EMPTableAdapter = New PPE3_Gestion_des_Salles.DataSet1TableAdapters.EMPTableAdapter()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TableauSallesDispo = New System.Windows.Forms.DataGridView()
        Me.LabelTableauHoraire = New System.Windows.Forms.Label()
        Me.RechercheHoraire = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.datechoisie = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 377)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Rechercher par nom de salle :"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DéconnexionToolStripMenuItem, Me.PlusDeRechercheTool, Me.RéserverUneSalleToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(848, 31)
        Me.MenuStrip1.TabIndex = 31
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DéconnexionToolStripMenuItem
        '
        Me.DéconnexionToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.DéconnexionToolStripMenuItem.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DéconnexionToolStripMenuItem.Name = "DéconnexionToolStripMenuItem"
        Me.DéconnexionToolStripMenuItem.Size = New System.Drawing.Size(115, 27)
        Me.DéconnexionToolStripMenuItem.Text = "Déconnexion"
        '
        'PlusDeRechercheTool
        '
        Me.PlusDeRechercheTool.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlusDeRechercheTool.Name = "PlusDeRechercheTool"
        Me.PlusDeRechercheTool.Size = New System.Drawing.Size(172, 27)
        Me.PlusDeRechercheTool.Text = "Voir mes réservations"
        '
        'RéserverUneSalleToolStripMenuItem
        '
        Me.RéserverUneSalleToolStripMenuItem.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RéserverUneSalleToolStripMenuItem.Name = "RéserverUneSalleToolStripMenuItem"
        Me.RéserverUneSalleToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RéserverUneSalleToolStripMenuItem.Size = New System.Drawing.Size(152, 27)
        Me.RéserverUneSalleToolStripMenuItem.Text = "Réserver une salle"
        '
        'LabelTableauSalles
        '
        Me.LabelTableauSalles.AutoSize = True
        Me.LabelTableauSalles.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTableauSalles.Location = New System.Drawing.Point(369, 40)
        Me.LabelTableauSalles.Name = "LabelTableauSalles"
        Me.LabelTableauSalles.Size = New System.Drawing.Size(0, 21)
        Me.LabelTableauSalles.TabIndex = 43
        '
        'TableauHorairesDispo
        '
        Me.TableauHorairesDispo.AllowUserToAddRows = False
        Me.TableauHorairesDispo.AllowUserToDeleteRows = False
        Me.TableauHorairesDispo.AllowUserToResizeRows = False
        Me.TableauHorairesDispo.BackgroundColor = System.Drawing.Color.SlateGray
        Me.TableauHorairesDispo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TableauHorairesDispo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.TableauHorairesDispo.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TableauHorairesDispo.DefaultCellStyle = DataGridViewCellStyle2
        Me.TableauHorairesDispo.Location = New System.Drawing.Point(272, 377)
        Me.TableauHorairesDispo.Name = "TableauHorairesDispo"
        Me.TableauHorairesDispo.ReadOnly = True
        Me.TableauHorairesDispo.RowHeadersWidth = 60
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableauHorairesDispo.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.TableauHorairesDispo.Size = New System.Drawing.Size(544, 233)
        Me.TableauHorairesDispo.TabIndex = 45
        '
        'ListeSalles
        '
        Me.ListeSalles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
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
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Rechercher par Date :"
        '
        'TableauSallesDispo
        '
        Me.TableauSallesDispo.AllowDrop = True
        Me.TableauSallesDispo.AllowUserToAddRows = False
        Me.TableauSallesDispo.AllowUserToDeleteRows = False
        Me.TableauSallesDispo.BackgroundColor = System.Drawing.Color.SlateGray
        Me.TableauSallesDispo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Modern No. 20", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TableauSallesDispo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.TableauSallesDispo.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TableauSallesDispo.DefaultCellStyle = DataGridViewCellStyle5
        Me.TableauSallesDispo.Location = New System.Drawing.Point(272, 66)
        Me.TableauSallesDispo.Name = "TableauSallesDispo"
        Me.TableauSallesDispo.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableauSallesDispo.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.TableauSallesDispo.Size = New System.Drawing.Size(544, 233)
        Me.TableauSallesDispo.TabIndex = 39
        '
        'LabelTableauHoraire
        '
        Me.LabelTableauHoraire.AutoSize = True
        Me.LabelTableauHoraire.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTableauHoraire.Location = New System.Drawing.Point(369, 353)
        Me.LabelTableauHoraire.Name = "LabelTableauHoraire"
        Me.LabelTableauHoraire.Size = New System.Drawing.Size(0, 21)
        Me.LabelTableauHoraire.TabIndex = 49
        '
        'RechercheHoraire
        '
        Me.RechercheHoraire.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RechercheHoraire.Location = New System.Drawing.Point(31, 191)
        Me.RechercheHoraire.Name = "RechercheHoraire"
        Me.RechercheHoraire.Size = New System.Drawing.Size(163, 48)
        Me.RechercheHoraire.TabIndex = 54
        Me.RechercheHoraire.Text = "Lancer la recherche"
        Me.RechercheHoraire.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(543, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 60
        '
        'datechoisie
        '
        Me.datechoisie.Location = New System.Drawing.Point(44, 121)
        Me.datechoisie.Name = "datechoisie"
        Me.datechoisie.Size = New System.Drawing.Size(146, 20)
        Me.datechoisie.TabIndex = 61
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 13)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Ex : 01-12-2018 10:00:00"
        '
        'RechercheSalles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 678)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.datechoisie)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.RechercheHoraire)
        Me.Controls.Add(Me.LabelTableauHoraire)
        Me.Controls.Add(Me.ListeSalles)
        Me.Controls.Add(Me.TableauHorairesDispo)
        Me.Controls.Add(Me.LabelTableauSalles)
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
    Friend WithEvents DéconnexionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelTableauSalles As System.Windows.Forms.Label
    Friend WithEvents TableauHorairesDispo As System.Windows.Forms.DataGridView
    Friend WithEvents ListeSalles As System.Windows.Forms.ComboBox
    Friend WithEvents DataSet1 As PPE3_Gestion_des_Salles.DataSet1
    Friend WithEvents EMPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EMPTableAdapter As PPE3_Gestion_des_Salles.DataSet1TableAdapters.EMPTableAdapter
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TableauSallesDispo As System.Windows.Forms.DataGridView
    Friend WithEvents PlusDeRechercheTool As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelTableauHoraire As System.Windows.Forms.Label
    Friend WithEvents RechercheHoraire As System.Windows.Forms.Button
    Friend WithEvents RéserverUneSalleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents datechoisie As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
