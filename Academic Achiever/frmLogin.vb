Public Class frmLogin
    Private Sub pbExit_Click(sender As Object, e As EventArgs) Handles pbExit.Click
        Process.GetCurrentProcess().Kill()
        Application.[Exit]()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUser.Text = "teach" AndAlso txtPass.Text = "pass" Then
            Me.Hide()
            frmGradeAnalyzer.Show()
        ElseIf txtUser.Text = "student" AndAlso txtPass.Text = "pass" Then
            Me.Hide()
            frmStudentProfile.Show()
        Else
            MsgBox("Wrong Profile!!")

        End If
    End Sub
End Class
