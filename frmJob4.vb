Public Class frmJob4

    Private Sub btnCalTax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalTax.Click
        Dim decR_BONUS = 0.2
        Dim decR_ALLOW = 0.01
        Dim decR_TAX = 0.07
        Dim dblYearSalary As Integer
        Dim dblBonus As Integer
        Dim dblAllIncome As Integer
        Dim dblAllowance As Integer
        Dim dblTax As Integer

        dblYearSalary = Val(txtSalary.Text) * 12
        dblBonus = Val(txtSale.Text) * decR_BONUS
        dblAllIncome = dblYearSalary + dblBonus
        dblAllowance = dblAllIncome * decR_ALLOW
        dblTax = (dblAllIncome - dblAllowance) * decR_TAX

        lblYearSalary.Text = dblYearSalary.ToString("##,###")
        lblBonus.Text = dblBonus.ToString("##,###")
        lblAllIncome.Text = dblAllIncome.ToString("##,###")
        lblAllowance.Text = dblAllowance.ToString("##,###")
        lblTax.Text = dblTax.ToString("##,###")

    End Sub

    Private Sub frmJob4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblDate.Text = Date.Now
    End Sub

    Private Sub radShortDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radShortDate.CheckedChanged
        lblDate.Text = Date.UtcNow
    End Sub

    Private Sub radLongDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radLongDate.CheckedChanged
        lblDate.Text = Now.ToLongDateString
    End Sub

    Private Sub radGeneralDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radGeneralDate.CheckedChanged
        lblDate.Text = Date.Now
    End Sub
End Class