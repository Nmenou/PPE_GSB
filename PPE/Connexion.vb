Public Class Connexion
    Public myConnection As New System.Data.Odbc.OdbcConnection
    Dim myCommand As New System.Data.Odbc.OdbcCommand
    Dim myReader As System.Data.Odbc.OdbcDataReader
    Dim myAdapter As System.Data.Odbc.OdbcDataAdapter
    Dim myBuilder As System.Data.Odbc.OdbcCommandBuilder
    Dim donnee As DataTable
    Dim connString As String = "DSN=test10;Uid=scott;Pwd=tiger;"

    Private Sub C_Load() Handles Me.Load
        myConnection.ConnectionString = connString

        Try
            myConnection.Open()
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try

        LabelErreur.Visible = False
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Inscription.Show()
    End Sub

    Private Sub Valider_Click(sender As System.Object, e As System.EventArgs) Handles Valider.Click

        ' Table collaborateur 
        Dim query As String = "SELECT LOGIN,MOT_DE_PASSE FROM COLLABORATEUR WHERE LOGIN = '" & TextBox1.Text & "' AND MOT_DE_PASSE = '" & TextBox2.Text & "';"
        myCommand.Connection = myConnection
        myCommand.CommandText = query

        myReader = myCommand.ExecuteReader
        If myReader.HasRows Then
            index.Show()
        Else
            LabelErreur.Visible = True
        End If

        myReader.Close()
        Me.Hide()
    End Sub
End Class