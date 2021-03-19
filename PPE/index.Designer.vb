<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class index
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
        Me.bo_remplir_rapports = New System.Windows.Forms.Button()
        Me.bo_remplir_medicaments = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.SuspendLayout()
        '
        'bo_remplir_rapports
        '
        Me.bo_remplir_rapports.Location = New System.Drawing.Point(85, 60)
        Me.bo_remplir_rapports.Name = "bo_remplir_rapports"
        Me.bo_remplir_rapports.Size = New System.Drawing.Size(113, 53)
        Me.bo_remplir_rapports.TabIndex = 0
        Me.bo_remplir_rapports.Text = "Remplir rapports de visite"
        Me.bo_remplir_rapports.UseVisualStyleBackColor = True
        '
        'bo_remplir_medicaments
        '
        Me.bo_remplir_medicaments.Location = New System.Drawing.Point(85, 158)
        Me.bo_remplir_medicaments.Name = "bo_remplir_medicaments"
        Me.bo_remplir_medicaments.Size = New System.Drawing.Size(113, 47)
        Me.bo_remplir_medicaments.TabIndex = 1
        Me.bo_remplir_medicaments.Text = "Remplir liste médicaments"
        Me.bo_remplir_medicaments.UseVisualStyleBackColor = True
        '
        'index
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.bo_remplir_medicaments)
        Me.Controls.Add(Me.bo_remplir_rapports)
        Me.Name = "index"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bo_remplir_rapports As System.Windows.Forms.Button
    Friend WithEvents bo_remplir_medicaments As System.Windows.Forms.Button
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog

End Class
