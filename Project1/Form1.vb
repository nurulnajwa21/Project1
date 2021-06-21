Public Class formJobApplication
    Private Sub BtnConditions_Click(sender As Object, e As EventArgs) Handles BtnConditions.Click
        formConditions.Show()
        Me.Show()
    End Sub

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        formRegister.Show()
        Me.Hide()
    End Sub
End Class
