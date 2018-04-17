<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VoirReservations
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Info = New System.Windows.Forms.Label()
        Me.MesReservations = New System.Windows.Forms.DataGridView()
        CType(Me.MesReservations, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(222, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 20)
        Me.Label1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(101, 541)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(470, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Double cliquez sur une ligne pour supprimer/modifier la réservation associée"
        '
        'Info
        '
        Me.Info.AutoSize = True
        Me.Info.Location = New System.Drawing.Point(42, 22)
        Me.Info.Name = "Info"
        Me.Info.Size = New System.Drawing.Size(0, 13)
        Me.Info.TabIndex = 3
        '
        'MesReservations
        '
        Me.MesReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MesReservations.Location = New System.Drawing.Point(12, 60)
        Me.MesReservations.Name = "MesReservations"
        Me.MesReservations.Size = New System.Drawing.Size(640, 462)
        Me.MesReservations.TabIndex = 0
        '
        'VoirReservations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 570)
        Me.Controls.Add(Me.Info)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MesReservations)
        Me.Name = "VoirReservations"
        Me.Text = "VoirReservations"
        CType(Me.MesReservations, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Info As System.Windows.Forms.Label
    Friend WithEvents MesReservations As System.Windows.Forms.DataGridView
End Class
