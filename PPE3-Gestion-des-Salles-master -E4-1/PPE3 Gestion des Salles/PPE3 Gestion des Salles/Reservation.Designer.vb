<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reservation
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
        Me.ListeSalles = New System.Windows.Forms.ComboBox()
        Me.LabelListeSalles = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BoutonReservationValide = New System.Windows.Forms.Button()
        Me.DescriptionBox = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BoxHour = New System.Windows.Forms.NumericUpDown()
        Me.BoxDayDebut = New System.Windows.Forms.NumericUpDown()
        Me.BoxMonthDebut = New System.Windows.Forms.NumericUpDown()
        Me.BoxYearDebut = New System.Windows.Forms.NumericUpDown()
        Me.Info = New System.Windows.Forms.Label()
        Me.RadioButtonjour = New System.Windows.Forms.RadioButton()
        Me.RadioButtonsemaine = New System.Windows.Forms.RadioButton()
        Me.RadioButtonmois = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BoxDayFin = New System.Windows.Forms.NumericUpDown()
        Me.BoxMonthFin = New System.Windows.Forms.NumericUpDown()
        Me.BoxYearFin = New System.Windows.Forms.NumericUpDown()
        Me.ButtonCalculer = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TableauCalculPeriode = New System.Windows.Forms.DataGridView()
        CType(Me.BoxHour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoxDayDebut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoxMonthDebut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoxYearDebut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoxDayFin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoxMonthFin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoxYearFin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableauCalculPeriode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListeSalles
        '
        Me.ListeSalles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ListeSalles.FormattingEnabled = True
        Me.ListeSalles.Location = New System.Drawing.Point(12, 99)
        Me.ListeSalles.Name = "ListeSalles"
        Me.ListeSalles.Size = New System.Drawing.Size(121, 21)
        Me.ListeSalles.TabIndex = 0
        '
        'LabelListeSalles
        '
        Me.LabelListeSalles.AutoSize = True
        Me.LabelListeSalles.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelListeSalles.Location = New System.Drawing.Point(12, 59)
        Me.LabelListeSalles.Name = "LabelListeSalles"
        Me.LabelListeSalles.Size = New System.Drawing.Size(125, 20)
        Me.LabelListeSalles.TabIndex = 1
        Me.LabelListeSalles.Text = "Modifier la salle :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(233, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Modifier l'horaire :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(451, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(318, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Entrez une nouvelle description (Facultatif) :"
        '
        'BoutonReservationValide
        '
        Me.BoutonReservationValide.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoutonReservationValide.Location = New System.Drawing.Point(679, 696)
        Me.BoutonReservationValide.Name = "BoutonReservationValide"
        Me.BoutonReservationValide.Size = New System.Drawing.Size(107, 47)
        Me.BoutonReservationValide.TabIndex = 7
        Me.BoutonReservationValide.Text = "Réserver"
        Me.BoutonReservationValide.UseVisualStyleBackColor = True
        '
        'DescriptionBox
        '
        Me.DescriptionBox.Location = New System.Drawing.Point(455, 77)
        Me.DescriptionBox.Name = "DescriptionBox"
        Me.DescriptionBox.Size = New System.Drawing.Size(386, 108)
        Me.DescriptionBox.TabIndex = 8
        Me.DescriptionBox.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(159, 384)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 21)
        Me.Label6.TabIndex = 66
        Me.Label6.Text = "Heure (24h)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(159, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 21)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "Jour Début"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(328, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 21)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Mois Début"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(159, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 21)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Année Début"
        '
        'BoxHour
        '
        Me.BoxHour.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxHour.Location = New System.Drawing.Point(163, 408)
        Me.BoxHour.Name = "BoxHour"
        Me.BoxHour.ReadOnly = True
        Me.BoxHour.Size = New System.Drawing.Size(120, 25)
        Me.BoxHour.TabIndex = 62
        '
        'BoxDayDebut
        '
        Me.BoxDayDebut.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxDayDebut.Location = New System.Drawing.Point(163, 158)
        Me.BoxDayDebut.Name = "BoxDayDebut"
        Me.BoxDayDebut.ReadOnly = True
        Me.BoxDayDebut.Size = New System.Drawing.Size(120, 25)
        Me.BoxDayDebut.TabIndex = 61
        '
        'BoxMonthDebut
        '
        Me.BoxMonthDebut.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxMonthDebut.Location = New System.Drawing.Point(297, 98)
        Me.BoxMonthDebut.Name = "BoxMonthDebut"
        Me.BoxMonthDebut.ReadOnly = True
        Me.BoxMonthDebut.Size = New System.Drawing.Size(120, 25)
        Me.BoxMonthDebut.TabIndex = 60
        '
        'BoxYearDebut
        '
        Me.BoxYearDebut.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxYearDebut.Location = New System.Drawing.Point(163, 98)
        Me.BoxYearDebut.Maximum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.BoxYearDebut.Name = "BoxYearDebut"
        Me.BoxYearDebut.ReadOnly = True
        Me.BoxYearDebut.Size = New System.Drawing.Size(120, 25)
        Me.BoxYearDebut.TabIndex = 59
        '
        'Info
        '
        Me.Info.AutoSize = True
        Me.Info.Location = New System.Drawing.Point(676, 9)
        Me.Info.Name = "Info"
        Me.Info.Size = New System.Drawing.Size(0, 13)
        Me.Info.TabIndex = 68
        '
        'RadioButtonjour
        '
        Me.RadioButtonjour.AutoSize = True
        Me.RadioButtonjour.Location = New System.Drawing.Point(73, 471)
        Me.RadioButtonjour.Name = "RadioButtonjour"
        Me.RadioButtonjour.Size = New System.Drawing.Size(42, 17)
        Me.RadioButtonjour.TabIndex = 69
        Me.RadioButtonjour.TabStop = True
        Me.RadioButtonjour.Text = "jour"
        Me.RadioButtonjour.UseVisualStyleBackColor = True
        '
        'RadioButtonsemaine
        '
        Me.RadioButtonsemaine.AutoSize = True
        Me.RadioButtonsemaine.Location = New System.Drawing.Point(73, 508)
        Me.RadioButtonsemaine.Name = "RadioButtonsemaine"
        Me.RadioButtonsemaine.Size = New System.Drawing.Size(64, 17)
        Me.RadioButtonsemaine.TabIndex = 70
        Me.RadioButtonsemaine.TabStop = True
        Me.RadioButtonsemaine.Text = "semaine"
        Me.RadioButtonsemaine.UseVisualStyleBackColor = True
        '
        'RadioButtonmois
        '
        Me.RadioButtonmois.AutoSize = True
        Me.RadioButtonmois.Location = New System.Drawing.Point(73, 541)
        Me.RadioButtonmois.Name = "RadioButtonmois"
        Me.RadioButtonmois.Size = New System.Drawing.Size(46, 17)
        Me.RadioButtonmois.TabIndex = 71
        Me.RadioButtonmois.TabStop = True
        Me.RadioButtonmois.Text = "mois"
        Me.RadioButtonmois.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(159, 293)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 21)
        Me.Label7.TabIndex = 77
        Me.Label7.Text = "Jour Fin"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(328, 241)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 21)
        Me.Label8.TabIndex = 76
        Me.Label8.Text = "Mois Fin"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(159, 241)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 21)
        Me.Label9.TabIndex = 75
        Me.Label9.Text = "Année Fin"
        '
        'BoxDayFin
        '
        Me.BoxDayFin.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxDayFin.Location = New System.Drawing.Point(163, 317)
        Me.BoxDayFin.Name = "BoxDayFin"
        Me.BoxDayFin.ReadOnly = True
        Me.BoxDayFin.Size = New System.Drawing.Size(120, 25)
        Me.BoxDayFin.TabIndex = 74
        '
        'BoxMonthFin
        '
        Me.BoxMonthFin.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxMonthFin.Location = New System.Drawing.Point(297, 265)
        Me.BoxMonthFin.Name = "BoxMonthFin"
        Me.BoxMonthFin.ReadOnly = True
        Me.BoxMonthFin.Size = New System.Drawing.Size(120, 25)
        Me.BoxMonthFin.TabIndex = 73
        '
        'BoxYearFin
        '
        Me.BoxYearFin.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxYearFin.Location = New System.Drawing.Point(163, 265)
        Me.BoxYearFin.Maximum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.BoxYearFin.Name = "BoxYearFin"
        Me.BoxYearFin.ReadOnly = True
        Me.BoxYearFin.Size = New System.Drawing.Size(120, 25)
        Me.BoxYearFin.TabIndex = 72
        '
        'ButtonCalculer
        '
        Me.ButtonCalculer.Location = New System.Drawing.Point(45, 585)
        Me.ButtonCalculer.Name = "ButtonCalculer"
        Me.ButtonCalculer.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCalculer.TabIndex = 78
        Me.ButtonCalculer.Text = "Calculer"
        Me.ButtonCalculer.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(42, 447)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 79
        Me.Label10.Text = "Periode"
        '
        'TableauCalculPeriode
        '
        Me.TableauCalculPeriode.AllowUserToAddRows = False
        Me.TableauCalculPeriode.AllowUserToDeleteRows = False
        Me.TableauCalculPeriode.AllowUserToResizeRows = False
        Me.TableauCalculPeriode.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.TableauCalculPeriode.BackgroundColor = System.Drawing.Color.SlateGray
        Me.TableauCalculPeriode.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TableauCalculPeriode.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.TableauCalculPeriode.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TableauCalculPeriode.DefaultCellStyle = DataGridViewCellStyle2
        Me.TableauCalculPeriode.Location = New System.Drawing.Point(45, 614)
        Me.TableauCalculPeriode.Name = "TableauCalculPeriode"
        Me.TableauCalculPeriode.ReadOnly = True
        Me.TableauCalculPeriode.RowHeadersWidth = 60
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableauCalculPeriode.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.TableauCalculPeriode.Size = New System.Drawing.Size(551, 198)
        Me.TableauCalculPeriode.TabIndex = 80
        '
        'Reservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 845)
        Me.Controls.Add(Me.TableauCalculPeriode)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ButtonCalculer)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.BoxDayFin)
        Me.Controls.Add(Me.BoxMonthFin)
        Me.Controls.Add(Me.BoxYearFin)
        Me.Controls.Add(Me.RadioButtonmois)
        Me.Controls.Add(Me.RadioButtonsemaine)
        Me.Controls.Add(Me.RadioButtonjour)
        Me.Controls.Add(Me.Info)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BoxHour)
        Me.Controls.Add(Me.BoxDayDebut)
        Me.Controls.Add(Me.BoxMonthDebut)
        Me.Controls.Add(Me.BoxYearDebut)
        Me.Controls.Add(Me.DescriptionBox)
        Me.Controls.Add(Me.BoutonReservationValide)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelListeSalles)
        Me.Controls.Add(Me.ListeSalles)
        Me.Name = "Reservation"
        Me.Text = "Reservation"
        CType(Me.BoxHour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BoxDayDebut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BoxMonthDebut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BoxYearDebut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BoxDayFin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BoxMonthFin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BoxYearFin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableauCalculPeriode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListeSalles As System.Windows.Forms.ComboBox
    Friend WithEvents LabelListeSalles As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BoutonReservationValide As System.Windows.Forms.Button
    Friend WithEvents DescriptionBox As System.Windows.Forms.RichTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BoxHour As System.Windows.Forms.NumericUpDown
    Friend WithEvents BoxDayDebut As System.Windows.Forms.NumericUpDown
    Friend WithEvents BoxMonthDebut As System.Windows.Forms.NumericUpDown
    Friend WithEvents BoxYearDebut As System.Windows.Forms.NumericUpDown
    Friend WithEvents Info As System.Windows.Forms.Label
    Friend WithEvents RadioButtonjour As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonsemaine As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonmois As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents BoxDayFin As System.Windows.Forms.NumericUpDown
    Friend WithEvents BoxMonthFin As System.Windows.Forms.NumericUpDown
    Friend WithEvents BoxYearFin As System.Windows.Forms.NumericUpDown
    Friend WithEvents ButtonCalculer As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TableauCalculPeriode As System.Windows.Forms.DataGridView
End Class
