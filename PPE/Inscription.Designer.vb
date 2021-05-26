<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inscription
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
        Me.TxtBoxID = New System.Windows.Forms.TextBox()
        Me.TxtBoxMdp = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Valider = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtboxVille = New System.Windows.Forms.TextBox()
        Me.TxtboxNom = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtBoxCP = New System.Windows.Forms.TextBox()
        Me.TxtboxPrénom = New System.Windows.Forms.TextBox()
        Me.LabelErreur = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtBoxID
        '
        Me.TxtBoxID.Location = New System.Drawing.Point(133, 133)
        Me.TxtBoxID.Name = "TxtBoxID"
        Me.TxtBoxID.Size = New System.Drawing.Size(145, 20)
        Me.TxtBoxID.TabIndex = 0
        '
        'TxtBoxMdp
        '
        Me.TxtBoxMdp.Location = New System.Drawing.Point(395, 133)
        Me.TxtBoxMdp.Name = "TxtBoxMdp"
        Me.TxtBoxMdp.Size = New System.Drawing.Size(145, 20)
        Me.TxtBoxMdp.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Identifiant :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(308, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Mot de passe :"
        '
        'Valider
        '
        Me.Valider.Location = New System.Drawing.Point(183, 199)
        Me.Valider.Name = "Valider"
        Me.Valider.Size = New System.Drawing.Size(214, 23)
        Me.Valider.TabIndex = 4
        Me.Valider.Text = "Valider"
        Me.Valider.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Ville  :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Nom :"
        '
        'TxtboxVille
        '
        Me.TxtboxVille.Location = New System.Drawing.Point(133, 75)
        Me.TxtboxVille.Name = "TxtboxVille"
        Me.TxtboxVille.Size = New System.Drawing.Size(145, 20)
        Me.TxtboxVille.TabIndex = 6
        '
        'TxtboxNom
        '
        Me.TxtboxNom.Location = New System.Drawing.Point(133, 22)
        Me.TxtboxNom.Name = "TxtboxNom"
        Me.TxtboxNom.Size = New System.Drawing.Size(145, 20)
        Me.TxtboxNom.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(312, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Code Postal  :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(312, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Prénom  :"
        '
        'TxtBoxCP
        '
        Me.TxtBoxCP.Location = New System.Drawing.Point(395, 74)
        Me.TxtBoxCP.Name = "TxtBoxCP"
        Me.TxtBoxCP.Size = New System.Drawing.Size(145, 20)
        Me.TxtBoxCP.TabIndex = 10
        '
        'TxtboxPrénom
        '
        Me.TxtboxPrénom.Location = New System.Drawing.Point(395, 25)
        Me.TxtboxPrénom.Name = "TxtboxPrénom"
        Me.TxtboxPrénom.Size = New System.Drawing.Size(145, 20)
        Me.TxtboxPrénom.TabIndex = 9
        '
        'LabelErreur
        '
        Me.LabelErreur.AutoSize = True
        Me.LabelErreur.ForeColor = System.Drawing.Color.Red
        Me.LabelErreur.Location = New System.Drawing.Point(248, 173)
        Me.LabelErreur.Name = "LabelErreur"
        Me.LabelErreur.Size = New System.Drawing.Size(105, 13)
        Me.LabelErreur.TabIndex = 13
        Me.LabelErreur.Text = "Identifiant déjà utilisé"
        '
        'Inscription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 234)
        Me.Controls.Add(Me.LabelErreur)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtBoxCP)
        Me.Controls.Add(Me.TxtboxPrénom)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtboxVille)
        Me.Controls.Add(Me.TxtboxNom)
        Me.Controls.Add(Me.Valider)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtBoxMdp)
        Me.Controls.Add(Me.TxtBoxID)
        Me.Name = "Inscription"
        Me.Text = "Inscription"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtBoxID As System.Windows.Forms.TextBox
    Friend WithEvents TxtBoxMdp As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Valider As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtboxVille As System.Windows.Forms.TextBox
    Friend WithEvents TxtboxNom As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtBoxCP As System.Windows.Forms.TextBox
    Friend WithEvents TxtboxPrénom As System.Windows.Forms.TextBox
    Friend WithEvents LabelErreur As System.Windows.Forms.Label
End Class
