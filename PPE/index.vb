Public Class index

    ' Le boutton "remplir rapports de visite"

    Private Sub bo_remplir_rapports_Click(sender As System.Object, e As System.EventArgs) Handles bo_remplir_rapports.Click
        rapports_visite.Show()

    End Sub


    ' Le boutton "remplir liste de médicament"

    Private Sub bo_remplir_medicaments_Click(sender As System.Object, e As System.EventArgs) Handles bo_remplir_medicaments.Click
        liste_medicaments.Show()

    End Sub

    
    Private Sub index_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
