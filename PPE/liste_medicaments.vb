Public Class liste_medicaments


    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder

    Dim donnee As DataTable

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        

        Dim query As String = "SELECT NOM_MEDICAMENT FROM medicament"
        myCommand.Connection = Connexion.myConnection
        myCommand.CommandText = query
        myReader = myCommand.ExecuteReader

        While myReader.Read
            NomBox.Items.Add(myReader.GetString(0))
        End While
        myReader.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click


        Dim query2 As String = "INSERT INTO MEDICAMENT(NOM_MEDICAMENT,NB_MEDICAMENT) VALUES ('" & champ_ajouter_medicament.Text & "'," & nombre_medicaments.Text & ") "

        myCommand.Connection = Connexion.myConnection
        myCommand.CommandText = query2
        myReader = myCommand.ExecuteReader

        index.Show()

        Me.Hide()

        myReader.Close()
    End Sub





End Class