Public Class frmjob4

    Private Sub btnCalTax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalTax.Click
        Dim decR_BONUS = 0.2
        Dim decR_ALLOW = 0.01
        Dim decR_TAX = 0.07
        Dim dblBonus As Long
        Dim dblAllIncome As Long
        Dim dblAllowance As Long
        Dim dblTax As Long
        Dim dblYearSalary As Integer

        dblYearSalary = Val(txtSalary.Text) * 12
        
        dblBonus = Val(txtSale.Text) * decR_BONUS
        lblBonus.Text = (dblBonus.ToString("##,###"))

        dblAllIncome = dblYearSalary + dblBonus
        lblAllIncome.Text = (dblAllIncome.ToString("##,###"))

        dblAllowance = dblAllIncome * decR_ALLOW
        lblAllowance.Text = (dblAllowance.ToString("##,###"))

        dblTax = (lblAllIncome.Text - lblAllowance.Text) * decR_TAX
        lblTax.Text = (dblTax.ToString("##,###"))


        lblYearSalary.Text = (dblYearSalary.ToString("##,###"))
         lblBonus.Text = (dblBonus.ToString("##,###"))
        



    End Sub

    Private Sub frmjob4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblDate.Text = Date.Now
    End Sub

    Private Sub radShortDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radShortDate.CheckedChanged
        lblDate.Text = Date.Today
    End Sub

    Private Sub radLongDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radLongDate.CheckedChanged
        lblDate.Text = Now.ToLongDateString
    End Sub

    Private Sub radGeneralDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radGeneralDate.CheckedChanged
        lblDate.Text = Date.Now
    End Sub




End Class