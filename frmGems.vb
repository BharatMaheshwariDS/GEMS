Public Class frmGems

    Private Sub frgGems_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblWelcome_Click(sender As Object, e As EventArgs) Handles lblWelcome.Click

    End Sub

    Private Sub imgGEMS_Click(sender As Object, e As EventArgs) Handles imgGEMS.Click

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub lblEnterPassword_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtPassword.Text = "GEMS" Then
            frmHomepage.Show()
        Else
            MsgBox("Password is Invalid !", MsgBoxStyle.OkOnly)

        End If

    End Sub


    Private Sub lblTo_Click(sender As Object, e As EventArgs) Handles lblTo.Click

    End Sub
End Class