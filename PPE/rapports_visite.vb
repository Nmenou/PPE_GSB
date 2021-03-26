Public Class rapports_visite


    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String
    Dim donnee As DataTable

    'Text principal

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


        'connString = "Driver={Microsoft ODBC for Oracle};CONNECTSTRING=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=10.0.23.80)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=ORCL)));Uid=MESGUEN3;Pwd=Estran;"
        'SERVEUR DE TEST
        'connString = "Driver={Microsoft ODBC for Oracle};CONNECTSTRING=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=10.0.220.100)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=ORAPROF)));Uid=SCOTT;Pwd=tiger;"
        ''connString = "DSN=Test10;Uid=SCOTT;Pwd=tiger;"
        connString = "DSN=CNXORA15;Uid=system;Pwd=estran;"
        'connString = "DSN=FERME;Uid=SCOTT;Pwd=tiger;"

        myConnection.ConnectionString = connString



        Try
            myConnection.Open()
            MessageBox.Show("Connexion Oracle Réussie")
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try



    End Sub




    ' Text echanntillon données

    Private Sub label_echantillon_Click(sender As System.Object, e As System.EventArgs) Handles label_echantillon.Click

    End Sub



    ' checkbox oui

    Private Sub check_oui_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles check_oui.CheckedChanged

    End Sub


    ' checkbox non

    Private Sub check_non_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles check_non.CheckedChanged

    End Sub



    ' Le texte nom du visiteur médical
    Private Sub label_nom_visiteur_Click(sender As System.Object, e As System.EventArgs) Handles label_nom_visiteur.Click

    End Sub



    'Le nom et prénom du visiteur médical
    Private Sub nom_visiteur_TextChanged(sender As System.Object, e As System.EventArgs) Handles nom_visiteur.TextChanged

    End Sub


    'Le texte prenom du visiteur médical

    Private Sub label_prenom_visiteur_Click_1(sender As System.Object, e As System.EventArgs) Handles label_prenom_visiteur.Click

    End Sub


    ' le prénom du visiteur médical
    Private Sub prenom_visiteur_TextChanged(sender As System.Object, e As System.EventArgs) Handles prenom_visiteur.TextChanged

    End Sub



    ' Le label informations sur le médecins
    Private Sub label_info_Click(sender As System.Object, e As System.EventArgs) Handles label_info.Click

    End Sub



    ' Les informations sur le médecins
    Private Sub info_medecin_TextChanged(sender As System.Object, e As System.EventArgs) Handles info_medecin.TextChanged

    End Sub



End Class