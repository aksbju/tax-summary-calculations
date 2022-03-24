Public Class FrmApp
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frmTax As FrmTax = New FrmTax()
        Me.Visible = False
        frmTax.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frmGst As FrmGst = New FrmGst()
        Me.Visible = False
        frmGst.ShowDialog()
        Me.Close()
    End Sub
End Class