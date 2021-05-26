Imports System.Data.Odbc

Public Class rapports_visite

    Dim myCommand As New System.Data.Odbc.OdbcCommand
    Dim myReader As System.Data.Odbc.OdbcDataReader
    Dim myAdapter As System.Data.Odbc.OdbcDataAdapter
    Dim myBuilder As System.Data.Odbc.OdbcCommandBuilder
    Dim donnee As DataTable

    ' checkbox oui

    Private Sub check_oui_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles check_oui.CheckedChanged
        check_non.Checked = False

        LabelInvisible.Text = "Oui"
    End Sub


    ' checkbox non

    Private Sub check_non_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles check_non.CheckedChanged
        check_oui.Checked = False

        LabelInvisible.Text = "Non"
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Dim query As String = "INSERT INTO MEDECIN(ID_VISITE,NOM_MEDECIN,PRENOM_MEDECIN,INFOPERSO_MEDECIN,ECHANTDON) VALUES(1,'" & nom_visiteur.Text & "','" & prenom_visiteur.Text & "','" & info_medecin.Text & "','" & LabelInvisible.Text & "');"
        myCommand.Connection = Connexion.myConnection
        myCommand.CommandText = query

        myReader = myCommand.ExecuteReader
        MessageBox.Show("Succès de l'opération")
        Me.Hide()
    End Sub
End Class