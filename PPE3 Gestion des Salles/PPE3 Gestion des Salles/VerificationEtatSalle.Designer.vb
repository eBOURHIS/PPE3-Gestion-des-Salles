﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerificationEtatSalle
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
        Me.Liste_Etats = New System.Windows.Forms.ComboBox()
        Me.TableauVerifSalleDispo = New System.Windows.Forms.DataGridView()
        Me.LabelTableauSalles = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.TableauVerifSalleDispo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Liste_Etats
        '
        Me.Liste_Etats.FormattingEnabled = True
        Me.Liste_Etats.Location = New System.Drawing.Point(15, 59)
        Me.Liste_Etats.Name = "Liste_Etats"
        Me.Liste_Etats.Size = New System.Drawing.Size(121, 21)
        Me.Liste_Etats.TabIndex = 47
        '
        'TableauVerifSalleDispo
        '
        Me.TableauVerifSalleDispo.AllowUserToAddRows = False
        Me.TableauVerifSalleDispo.AllowUserToDeleteRows = False
        Me.TableauVerifSalleDispo.AllowUserToResizeColumns = False
        Me.TableauVerifSalleDispo.AllowUserToResizeRows = False
        Me.TableauVerifSalleDispo.BackgroundColor = System.Drawing.Color.SlateGray
        Me.TableauVerifSalleDispo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TableauVerifSalleDispo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.TableauVerifSalleDispo.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TableauVerifSalleDispo.DefaultCellStyle = DataGridViewCellStyle2
        Me.TableauVerifSalleDispo.Location = New System.Drawing.Point(15, 138)
        Me.TableauVerifSalleDispo.Name = "TableauVerifSalleDispo"
        Me.TableauVerifSalleDispo.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableauVerifSalleDispo.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.TableauVerifSalleDispo.Size = New System.Drawing.Size(691, 407)
        Me.TableauVerifSalleDispo.TabIndex = 49
        '
        'LabelTableauSalles
        '
        Me.LabelTableauSalles.AutoSize = True
        Me.LabelTableauSalles.Location = New System.Drawing.Point(323, 126)
        Me.LabelTableauSalles.Name = "LabelTableauSalles"
        Me.LabelTableauSalles.Size = New System.Drawing.Size(0, 13)
        Me.LabelTableauSalles.TabIndex = 48
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 13)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Vérifier les salles disponibles :"
        '
        'VerificationEtatSalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 557)
        Me.Controls.Add(Me.Liste_Etats)
        Me.Controls.Add(Me.TableauVerifSalleDispo)
        Me.Controls.Add(Me.LabelTableauSalles)
        Me.Controls.Add(Me.Label1)
        Me.Name = "VerificationEtatSalle"
        Me.Text = "Form1"
        CType(Me.TableauVerifSalleDispo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Liste_Etats As System.Windows.Forms.ComboBox
    Friend WithEvents TableauVerifSalleDispo As System.Windows.Forms.DataGridView
    Friend WithEvents LabelTableauSalles As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
