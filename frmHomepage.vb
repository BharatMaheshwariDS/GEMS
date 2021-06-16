Public Class frmHomepage

    Private Sub btnDutyOrder_Click(sender As Object, e As EventArgs) Handles btnDutyOrder.Click
        frmDutyOrder.MdiParent = Me
        frmDutyOrder.Show()
        frmDutyOrder.BringToFront()


    End Sub

    Private Sub frmHomepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBlockReport_Click(sender As Object, e As EventArgs) Handles btnBlockReport.Click
        frmBlockReport.MdiParent = Me
        frmBlockReport.Show()
        frmBlockReport.BringToFront()

    End Sub

   

    Private Sub btnRemunerationBill_Click(sender As Object, e As EventArgs) Handles btnRemunerationBill.Click
        frmRenumerationBill.MdiParent = Me
        frmRenumerationBill.Show()
        frmRenumerationBill.BringToFront()
    End Sub

    Private Sub btnDailyReport_Click(sender As Object, e As EventArgs) Handles btnDailyReport.Click
        frmDailyReport.MdiParent = Me
        frmDailyReport.Show()
        frmDailyReport.BringToFront()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()


    End Sub

    Private Sub tsModules_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tsModules.ItemClicked

    End Sub
End Class
