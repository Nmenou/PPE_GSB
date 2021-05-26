<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class liste_medicaments
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
        Me.NomBox = New System.Windows.Forms.ComboBox()
        Me.text_ajouter_medicament = New System.Windows.Forms.Label()
        Me.text_nombre_medicament = New System.Windows.Forms.Label()
        Me.champ_ajouter_medicament = New System.Windows.Forms.TextBox()
        Me.nombre_medicaments = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(85, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Liste des médicaments"
        '
        'NomBox
        '
        Me.NomBox.FormattingEnabled = True
        Me.NomBox.Location = New System.Drawing.Point(25, 39)
        Me.NomBox.Name = "NomBox"
        Me.NomBox.Size = New System.Drawing.Size(234, 21)
        Me.NomBox.TabIndex = 1
        '
        'text_ajouter_medicament
        '
        Me.text_ajouter_medicament.AutoSize = True
        Me.text_ajouter_medicament.Location = New System.Drawing.Point(85, 161)
        Me.text_ajouter_medicament.Name = "text_ajouter_medicament"
        Me.text_ajouter_medicament.Size = New System.Drawing.Size(114, 13)
        Me.text_ajouter_medicament.TabIndex = 2
        Me.text_ajouter_medicament.Text = "Ajouter médicaments : "
        '
        'text_nombre_medicament
        '
        Me.text_nombre_medicament.AutoSize = True
        Me.text_nombre_medicament.Location = New System.Drawing.Point(57, 216)
        Me.text_nombre_medicament.Name = "text_nombre_medicament"
        Me.text_nombre_medicament.Size = New System.Drawing.Size(177, 13)
        Me.text_nombre_medicament.TabIndex = 3
        Me.text_nombre_medicament.Text = "Nombre de médicaments à ajouter : "
        '
        'champ_ajouter_medicament
        '
        Me.champ_ajouter_medicament.Location = New System.Drawing.Point(88, 177)
        Me.champ_ajouter_medicament.Name = "champ_ajouter_medicament"
        Me.champ_ajouter_medicament.Size = New System.Drawing.Size(100, 20)
        Me.champ_ajouter_medicament.TabIndex = 4
        '
        'nombre_medicaments
        '
        Me.nombre_medicaments.Location = New System.Drawing.Point(88, 245)
        Me.nombre_medicaments.Name = "nombre_medicaments"
        Me.nombre_medicaments.Size = New System.Drawing.Size(100, 20)
        Me.nombre_medicaments.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(99, 293)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Valider"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'liste_medicaments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 328)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.nombre_medicaments)
        Me.Controls.Add(Me.champ_ajouter_medicament)
        Me.Controls.Add(Me.text_nombre_medicament)
        Me.Controls.Add(Me.text_ajouter_medicament)
        Me.Controls.Add(Me.NomBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "liste_medicaments"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NomBox As System.Windows.Forms.ComboBox
    Friend WithEvents text_ajouter_medicament As System.Windows.Forms.Label
    Friend WithEvents text_nombre_medicament As System.Windows.Forms.Label
    Friend WithEvents champ_ajouter_medicament As System.Windows.Forms.TextBox
    Friend WithEvents nombre_medicaments As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
