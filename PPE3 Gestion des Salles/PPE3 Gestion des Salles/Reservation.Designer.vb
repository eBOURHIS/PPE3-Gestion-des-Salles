﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.BoxDay = New System.Windows.Forms.NumericUpDown()
        Me.BoxMonth = New System.Windows.Forms.NumericUpDown()
        Me.BoxYear = New System.Windows.Forms.NumericUpDown()
        Me.Info = New System.Windows.Forms.Label()
        CType(Me.BoxHour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoxDay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoxMonth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoxYear, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BoutonReservationValide.Location = New System.Drawing.Point(599, 200)
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
        Me.Label6.Location = New System.Drawing.Point(302, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 21)
        Me.Label6.TabIndex = 66
        Me.Label6.Text = "Heure (24h)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(192, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 21)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "Jour"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(328, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 21)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Mois"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(191, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 21)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Année"
        '
        'BoxHour
        '
        Me.BoxHour.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxHour.Location = New System.Drawing.Point(297, 158)
        Me.BoxHour.Name = "BoxHour"
        Me.BoxHour.ReadOnly = True
        Me.BoxHour.Size = New System.Drawing.Size(120, 25)
        Me.BoxHour.TabIndex = 62
        '
        'BoxDay
        '
        Me.BoxDay.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxDay.Location = New System.Drawing.Point(163, 158)
        Me.BoxDay.Name = "BoxDay"
        Me.BoxDay.ReadOnly = True
        Me.BoxDay.Size = New System.Drawing.Size(120, 25)
        Me.BoxDay.TabIndex = 61
        '
        'BoxMonth
        '
        Me.BoxMonth.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxMonth.Location = New System.Drawing.Point(297, 98)
        Me.BoxMonth.Name = "BoxMonth"
        Me.BoxMonth.ReadOnly = True
        Me.BoxMonth.Size = New System.Drawing.Size(120, 25)
        Me.BoxMonth.TabIndex = 60
        '
        'BoxYear
        '
        Me.BoxYear.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxYear.Location = New System.Drawing.Point(163, 98)
        Me.BoxYear.Maximum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.BoxYear.Name = "BoxYear"
        Me.BoxYear.ReadOnly = True
        Me.BoxYear.Size = New System.Drawing.Size(120, 25)
        Me.BoxYear.TabIndex = 59
        '
        'Info
        '
        Me.Info.AutoSize = True
        Me.Info.Location = New System.Drawing.Point(676, 9)
        Me.Info.Name = "Info"
        Me.Info.Size = New System.Drawing.Size(0, 13)
        Me.Info.TabIndex = 68
        '
        'Reservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 279)
        Me.Controls.Add(Me.Info)
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
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelListeSalles)
        Me.Controls.Add(Me.ListeSalles)
        Me.Name = "Reservation"
        Me.Text = "Reservation"
        CType(Me.BoxHour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BoxDay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BoxMonth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BoxYear, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents BoxDay As System.Windows.Forms.NumericUpDown
    Friend WithEvents BoxMonth As System.Windows.Forms.NumericUpDown
    Friend WithEvents BoxYear As System.Windows.Forms.NumericUpDown
    Friend WithEvents Info As System.Windows.Forms.Label
End Class
