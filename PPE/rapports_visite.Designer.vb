<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rapports_visite
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
        Me.label_echantillon = New System.Windows.Forms.Label()
        Me.label_visite = New System.Windows.Forms.Label()
        Me.check_oui = New System.Windows.Forms.CheckBox()
        Me.check_non = New System.Windows.Forms.CheckBox()
        Me.label_nom_visiteur = New System.Windows.Forms.Label()
        Me.nom_visiteur = New System.Windows.Forms.TextBox()
        Me.label_info = New System.Windows.Forms.Label()
        Me.label_prenom_visiteur = New System.Windows.Forms.Label()
        Me.prenom_visiteur = New System.Windows.Forms.TextBox()
        Me.info_medecin = New System.Windows.Forms.TextBox()
        Me.info_medicament = New System.Windows.Forms.TextBox()
        Me.nom_echantillons = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'label_echantillon
        '
        Me.label_echantillon.AutoSize = True
        Me.label_echantillon.Location = New System.Drawing.Point(24, 108)
        Me.label_echantillon.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.label_echantillon.Name = "label_echantillon"
        Me.label_echantillon.Size = New System.Drawing.Size(213, 25)
        Me.label_echantillon.TabIndex = 0
        Me.label_echantillon.Text = "Echantillon donnés : "
        '
        'label_visite
        '
        Me.label_visite.AutoSize = True
        Me.label_visite.Location = New System.Drawing.Point(336, 17)
        Me.label_visite.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.label_visite.Name = "label_visite"
        Me.label_visite.Size = New System.Drawing.Size(185, 25)
        Me.label_visite.TabIndex = 1
        Me.label_visite.Text = "Rapports de visite"
        '
        'check_oui
        '
        Me.check_oui.AutoSize = True
        Me.check_oui.Location = New System.Drawing.Point(480, 108)
        Me.check_oui.Margin = New System.Windows.Forms.Padding(6)
        Me.check_oui.Name = "check_oui"
        Me.check_oui.Size = New System.Drawing.Size(73, 29)
        Me.check_oui.TabIndex = 2
        Me.check_oui.Text = "oui"
        Me.check_oui.UseVisualStyleBackColor = True
        '
        'check_non
        '
        Me.check_non.AutoSize = True
        Me.check_non.Location = New System.Drawing.Point(592, 106)
        Me.check_non.Margin = New System.Windows.Forms.Padding(6)
        Me.check_non.Name = "check_non"
        Me.check_non.Size = New System.Drawing.Size(80, 29)
        Me.check_non.TabIndex = 3
        Me.check_non.Text = "non"
        Me.check_non.UseVisualStyleBackColor = True
        '
        'label_nom_visiteur
        '
        Me.label_nom_visiteur.AutoSize = True
        Me.label_nom_visiteur.Location = New System.Drawing.Point(24, 212)
        Me.label_nom_visiteur.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.label_nom_visiteur.Name = "label_nom_visiteur"
        Me.label_nom_visiteur.Size = New System.Drawing.Size(259, 25)
        Me.label_nom_visiteur.TabIndex = 4
        Me.label_nom_visiteur.Text = "Nom du visiteur médical : "
        '
        'nom_visiteur
        '
        Me.nom_visiteur.Location = New System.Drawing.Point(480, 198)
        Me.nom_visiteur.Margin = New System.Windows.Forms.Padding(6)
        Me.nom_visiteur.Name = "nom_visiteur"
        Me.nom_visiteur.Size = New System.Drawing.Size(196, 31)
        Me.nom_visiteur.TabIndex = 5
        '
        'label_info
        '
        Me.label_info.AutoSize = True
        Me.label_info.Location = New System.Drawing.Point(24, 394)
        Me.label_info.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.label_info.Name = "label_info"
        Me.label_info.Size = New System.Drawing.Size(293, 25)
        Me.label_info.TabIndex = 6
        Me.label_info.Text = "Informations sur le médecin : "
        '
        'label_prenom_visiteur
        '
        Me.label_prenom_visiteur.AutoSize = True
        Me.label_prenom_visiteur.Location = New System.Drawing.Point(24, 306)
        Me.label_prenom_visiteur.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.label_prenom_visiteur.Name = "label_prenom_visiteur"
        Me.label_prenom_visiteur.Size = New System.Drawing.Size(289, 25)
        Me.label_prenom_visiteur.TabIndex = 7
        Me.label_prenom_visiteur.Text = "Prénom du visiteur médical : "
        '
        'prenom_visiteur
        '
        Me.prenom_visiteur.Location = New System.Drawing.Point(480, 292)
        Me.prenom_visiteur.Margin = New System.Windows.Forms.Padding(6)
        Me.prenom_visiteur.Name = "prenom_visiteur"
        Me.prenom_visiteur.Size = New System.Drawing.Size(196, 31)
        Me.prenom_visiteur.TabIndex = 8
        '
        'info_medecin
        '
        Me.info_medecin.Location = New System.Drawing.Point(480, 388)
        Me.info_medecin.Margin = New System.Windows.Forms.Padding(6)
        Me.info_medecin.Name = "info_medecin"
        Me.info_medecin.Size = New System.Drawing.Size(290, 31)
        Me.info_medecin.TabIndex = 9
        '
        'info_medicament
        '
        Me.info_medicament.Location = New System.Drawing.Point(492, 482)
        Me.info_medicament.Name = "info_medicament"
        Me.info_medicament.Size = New System.Drawing.Size(277, 31)
        Me.info_medicament.TabIndex = 10
        '
        'nom_echantillons
        '
        Me.nom_echantillons.AutoSize = True
        Me.nom_echantillons.Location = New System.Drawing.Point(29, 490)
        Me.nom_echantillons.Name = "nom_echantillons"
        Me.nom_echantillons.Size = New System.Drawing.Size(281, 25)
        Me.nom_echantillons.TabIndex = 11
        Me.nom_echantillons.Text = "Nom d'échantillons vendus :"
        '
        'rapports_visite
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 644)
        Me.Controls.Add(Me.nom_echantillons)
        Me.Controls.Add(Me.info_medicament)
        Me.Controls.Add(Me.info_medecin)
        Me.Controls.Add(Me.prenom_visiteur)
        Me.Controls.Add(Me.label_prenom_visiteur)
        Me.Controls.Add(Me.label_info)
        Me.Controls.Add(Me.nom_visiteur)
        Me.Controls.Add(Me.label_nom_visiteur)
        Me.Controls.Add(Me.check_non)
        Me.Controls.Add(Me.check_oui)
        Me.Controls.Add(Me.label_visite)
        Me.Controls.Add(Me.label_echantillon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "rapports_visite"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents label_echantillon As System.Windows.Forms.Label
    Friend WithEvents label_visite As System.Windows.Forms.Label
    Friend WithEvents check_oui As System.Windows.Forms.CheckBox
    Friend WithEvents check_non As System.Windows.Forms.CheckBox
    Friend WithEvents label_nom_visiteur As System.Windows.Forms.Label
    Friend WithEvents nom_visiteur As System.Windows.Forms.TextBox
    Friend WithEvents label_info As System.Windows.Forms.Label
    Friend WithEvents label_prenom_visiteur As System.Windows.Forms.Label
    Friend WithEvents prenom_visiteur As System.Windows.Forms.TextBox
    Friend WithEvents info_medecin As System.Windows.Forms.TextBox
    Friend WithEvents info_medicament As TextBox
    Friend WithEvents nom_echantillons As Label
End Class
