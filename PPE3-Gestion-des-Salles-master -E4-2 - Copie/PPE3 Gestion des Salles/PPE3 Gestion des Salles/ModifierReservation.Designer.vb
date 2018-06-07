<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifierReservation
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
        Me.Info = New System.Windows.Forms.Label()
        Me.LabelListeSalles = New System.Windows.Forms.Label()
        Me.ListeSalles = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BoxHour = New System.Windows.Forms.NumericUpDown()
        Me.BoxDay = New System.Windows.Forms.NumericUpDown()
        Me.BoxMonth = New System.Windows.Forms.NumericUpDown()
        Me.BoxYear = New System.Windows.Forms.NumericUpDown()
        Me.DescriptionBox = New System.Windows.Forms.RichTextBox()
        Me.BoutonReservationValide = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.oldsallename = New System.Windows.Forms.Label()
        Me.NomSalle = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.BoxHour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoxDay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoxMonth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoxYear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Info
        '
        Me.Info.AutoSize = True
        Me.Info.Location = New System.Drawing.Point(511, -2)
        Me.Info.Name = "Info"
        Me.Info.Size = New System.Drawing.Size(0, 13)
        Me.Info.TabIndex = 83
        '
        'LabelListeSalles
        '
        Me.LabelListeSalles.AutoSize = True
        Me.LabelListeSalles.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelListeSalles.Location = New System.Drawing.Point(-153, 48)
        Me.LabelListeSalles.Name = "LabelListeSalles"
        Me.LabelListeSalles.Size = New System.Drawing.Size(160, 20)
        Me.LabelListeSalles.TabIndex = 70
        Me.LabelListeSalles.Text = "Choisissez une salle :"
        '
        'ListeSalles
        '
        Me.ListeSalles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ListeSalles.FormattingEnabled = True
        Me.ListeSalles.Location = New System.Drawing.Point(-153, 88)
        Me.ListeSalles.Name = "ListeSalles"
        Me.ListeSalles.Size = New System.Drawing.Size(121, 21)
        Me.ListeSalles.TabIndex = 69
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(682, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 98
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(308, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 21)
        Me.Label6.TabIndex = 97
        Me.Label6.Text = "Heure (24h)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(198, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 21)
        Me.Label5.TabIndex = 96
        Me.Label5.Text = "Jour"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(334, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 21)
        Me.Label4.TabIndex = 95
        Me.Label4.Text = "Mois"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(197, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 21)
        Me.Label3.TabIndex = 94
        Me.Label3.Text = "Année"
        '
        'BoxHour
        '
        Me.BoxHour.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxHour.Location = New System.Drawing.Point(303, 169)
        Me.BoxHour.Name = "BoxHour"
        Me.BoxHour.ReadOnly = True
        Me.BoxHour.Size = New System.Drawing.Size(120, 25)
        Me.BoxHour.TabIndex = 93
        '
        'BoxDay
        '
        Me.BoxDay.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxDay.Location = New System.Drawing.Point(169, 169)
        Me.BoxDay.Name = "BoxDay"
        Me.BoxDay.ReadOnly = True
        Me.BoxDay.Size = New System.Drawing.Size(120, 25)
        Me.BoxDay.TabIndex = 92
        '
        'BoxMonth
        '
        Me.BoxMonth.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxMonth.Location = New System.Drawing.Point(303, 109)
        Me.BoxMonth.Name = "BoxMonth"
        Me.BoxMonth.ReadOnly = True
        Me.BoxMonth.Size = New System.Drawing.Size(120, 25)
        Me.BoxMonth.TabIndex = 91
        '
        'BoxYear
        '
        Me.BoxYear.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxYear.Location = New System.Drawing.Point(169, 109)
        Me.BoxYear.Maximum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.BoxYear.Name = "BoxYear"
        Me.BoxYear.ReadOnly = True
        Me.BoxYear.Size = New System.Drawing.Size(120, 25)
        Me.BoxYear.TabIndex = 90
        '
        'DescriptionBox
        '
        Me.DescriptionBox.Location = New System.Drawing.Point(461, 88)
        Me.DescriptionBox.Name = "DescriptionBox"
        Me.DescriptionBox.Size = New System.Drawing.Size(386, 108)
        Me.DescriptionBox.TabIndex = 89
        Me.DescriptionBox.Text = ""
        '
        'BoutonReservationValide
        '
        Me.BoutonReservationValide.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoutonReservationValide.Location = New System.Drawing.Point(569, 211)
        Me.BoutonReservationValide.Name = "BoutonReservationValide"
        Me.BoutonReservationValide.Size = New System.Drawing.Size(185, 47)
        Me.BoutonReservationValide.TabIndex = 88
        Me.BoutonReservationValide.Text = "Modifier la réservation"
        Me.BoutonReservationValide.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(457, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(256, 20)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "Entrez une description (Facultatif) :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(214, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(168, 20)
        Me.Label7.TabIndex = 86
        Me.Label7.Text = "Choisissez un horaire :"
        '
        'oldsallename
        '
        Me.oldsallename.AutoSize = True
        Me.oldsallename.Location = New System.Drawing.Point(325, 133)
        Me.oldsallename.Name = "oldsallename"
        Me.oldsallename.Size = New System.Drawing.Size(0, 13)
        Me.oldsallename.TabIndex = 99
        '
        'NomSalle
        '
        Me.NomSalle.AutoSize = True
        Me.NomSalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomSalle.Location = New System.Drawing.Point(34, 122)
        Me.NomSalle.Name = "NomSalle"
        Me.NomSalle.Size = New System.Drawing.Size(0, 24)
        Me.NomSalle.TabIndex = 101
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 70)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 20)
        Me.Label8.TabIndex = 85
        Me.Label8.Text = "Salle actuelle"
        '
        'ModifierReservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 279)
        Me.Controls.Add(Me.NomSalle)
        Me.Controls.Add(Me.oldsallename)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BoxHour)
        Me.Controls.Add(Me.BoxDay)
        Me.Controls.Add(Me.BoxMonth)
        Me.Controls.Add(Me.BoxYear)
        Me.Controls.Add(Me.DescriptionBox)
        Me.Controls.Add(Me.BoutonReservationValide)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Info)
        Me.Controls.Add(Me.LabelListeSalles)
        Me.Controls.Add(Me.ListeSalles)
        Me.Name = "ModifierReservation"
        Me.Text = "UpdateReservation"
        CType(Me.BoxHour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BoxDay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BoxMonth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BoxYear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Info As System.Windows.Forms.Label
    Friend WithEvents LabelListeSalles As System.Windows.Forms.Label
    Friend WithEvents ListeSalles As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BoxHour As System.Windows.Forms.NumericUpDown
    Friend WithEvents BoxDay As System.Windows.Forms.NumericUpDown
    Friend WithEvents BoxMonth As System.Windows.Forms.NumericUpDown
    Friend WithEvents BoxYear As System.Windows.Forms.NumericUpDown
    Friend WithEvents DescriptionBox As System.Windows.Forms.RichTextBox
    Friend WithEvents BoutonReservationValide As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents oldsallename As System.Windows.Forms.Label
    Friend WithEvents NomSalle As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
