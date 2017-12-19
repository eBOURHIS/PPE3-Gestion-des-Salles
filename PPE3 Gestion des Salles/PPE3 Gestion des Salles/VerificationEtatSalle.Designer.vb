<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Liste_Etats = New System.Windows.Forms.ComboBox()
        Me.TableauVerifSalleDispo = New System.Windows.Forms.DataGridView()
        Me.LabelTableauSalles = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.TableauVerifSalleDispo.BackgroundColor = System.Drawing.Color.SlateGray
        Me.TableauVerifSalleDispo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TableauVerifSalleDispo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.TableauVerifSalleDispo.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TableauVerifSalleDispo.DefaultCellStyle = DataGridViewCellStyle8
        Me.TableauVerifSalleDispo.Location = New System.Drawing.Point(15, 138)
        Me.TableauVerifSalleDispo.Name = "TableauVerifSalleDispo"
        Me.TableauVerifSalleDispo.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableauVerifSalleDispo.RowsDefaultCellStyle = DataGridViewCellStyle9
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
        Me.Label1.Size = New System.Drawing.Size(210, 13)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Vérifier les salles réservées ou en attentes :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(307, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 50
        '
        'VerificationEtatSalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 557)
        Me.Controls.Add(Me.Label2)
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
