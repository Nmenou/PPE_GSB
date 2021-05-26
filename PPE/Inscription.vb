Public Class Inscription
    Dim myCommand As New System.Data.Odbc.OdbcCommand
    Dim myReader1, myReader2 As System.Data.Odbc.OdbcDataReader
    Dim myAdapter As System.Data.Odbc.OdbcDataAdapter
    Dim myBuilder As System.Data.Odbc.OdbcCommandBuilder
    Dim donnee As DataTable
    Dim connString As String = "DSN=CNXORA14;Uid=system;Pwd=estran;"

    Private Sub I_Load() Handles Me.Load
        LabelErreur.Visible = False
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Valider.Click

        Dim query1 As String = "SELECT LOGIN FROM COLLABORATEUR WHERE LOGIN = '" & TxtBoxID.Text & "'"
        myCommand.Connection = Connexion.myConnection
        myCommand.CommandText = query1

        myReader1 = myCommand.ExecuteReader

        If myReader1.HasRows Then
            LabelErreur.Visible = True
        Else
            myReader1.Close()
            Dim query2 As String = "INSERT INTO COLLABORATEUR(NOM_COLLA,PRENOM_COLLA,VILLE_COLLA,CP_COLLA,LOGIN,MOT_DE_PASSE) VALUES('" & TxtboxNom.Text & "','" & TxtboxPrénom.Text & "','" & TxtboxVille.Text & "','" & TxtBoxCP.Text & "','" & TxtBoxID.Text & "','" & TxtBoxMdp.Text & "');"
            myCommand.CommandText = query2

            myReader2 = myCommand.ExecuteReader

            index.Show()
        End If


        myReader1.Close()
        myReader2.Close()
        Me.Hide()
    End Sub
End Class