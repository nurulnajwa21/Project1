Public Class formRegister
    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        If (NudAge.Text) < "20" Then
            MessageBox.Show("Sorry you are not eligible . You are under 21 years old . Try again later . ")
            NudAge.Focus()
        ElseIf (txtboxLicense.Text) = "NO" Then
            MessageBox.Show("Sorry you are not eligible . You dont have a valid driving license . Try again later . ")
            txtboxLicense.Focus()
        ElseIf (txtboxCar.Text) = "NO" Then
            MessageBox.Show("Sorry you are not eligible . You dont have a car . Try again later . ")
            txtboxCar.Focus()
        ElseIf (NudWorking.Text) < "1" Then
            MessageBox.Show("Sorry you are not eligible . You dont have a driving experience . Try again later .")
            NudWorking.Focus()
        ElseIf (txtboxCitizenship.Text) <> "MALAYSIA" Then
            MessageBox.Show("Sorry you are not eligible . You are not Malaysia citizen . Try again later .")
        Else
            Eligible.Show()
            Me.Show()
        End If
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        If SureExit() Then
            End
        End If
    End Sub

    Private Function SureExit() As Boolean
        Dim result As DialogResult
        result = MessageBox.Show("Are you sure ?", " Exit ", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Return True
        Else
            Return False
        End If
    End Function
End Class