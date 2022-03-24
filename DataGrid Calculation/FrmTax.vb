Public Class FrmTax
    Dim particulars As List(Of ParticularModel)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim data As ParticularModel = New ParticularModel()
        data.ItemName = Me.TBoxProductName.Text
        data.UnitPrice = Me.TBoxUnitPrice.Text
        data.Qty = Me.TBoxQty.Text
        data.Taxable = Val(Me.TBoxUnitPrice.Text) * Val(Me.TBoxQty.Text)
        data.Tax = Val(Me.TBoxUnitPrice.Text) * Val(Me.TBoxQty.Text) * (Val(TBoxTaxPercentage.Text.Replace("%", "").Trim()) / 100)
        data.Subtotal = (Val(Me.TBoxUnitPrice.Text) * Val(Me.TBoxQty.Text)) + (Val(Me.TBoxUnitPrice.Text) * Val(Me.TBoxQty.Text) * (Val(TBoxTaxPercentage.Text.Replace("%", "").Trim()) / 100))
        Me.particulars.Add(data)
        Me.DGVParticulars.DataSource = Nothing
        Me.DGVParticulars.DataSource = Me.particulars
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.particulars = New List(Of ParticularModel)()
        Me.DGVParticulars.DataSource = Nothing
        Me.DGVParticulars.DataSource = Me.particulars
        Me.TBoxTaxPercentage.Text = 0
    End Sub

    Private Sub DGVCals_DataSourceChanged(sender As Object, e As EventArgs) Handles DGVParticulars.DataSourceChanged
        ' Footer Total Calculation
        Dim total = 0
        Dim tax = 0
        Dim grandtotal = 0
        For Each row As DataGridViewRow In Me.DGVParticulars.Rows
            total += Val(row.Cells("Taxable").Value.ToString())
            tax += Val(row.Cells("Tax").Value.ToString())
            grandtotal += Val(row.Cells("Subtotal").Value.ToString())
        Next
        Me.ValTotal.Text = total
        Me.ValGST.Text = tax
        Me.ValGrandTotal.Text = grandtotal


    End Sub

    Private Sub CBoxTaxPercent_SelectedIndexChanged(sender As Object, e As EventArgs)
        Me.TBoxSubtotal.Text = (Val(Me.TBoxUnitPrice.Text) * Val(Me.TBoxQty.Text)) + (Val(Me.TBoxUnitPrice.Text) * Val(Me.TBoxQty.Text) * (Val(TBoxTaxPercentage.Text.Replace("%", "").Trim()) / 100))
    End Sub
    Private Sub TBoxUnitPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBoxUnitPrice.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "."c Then
            e.Handled = True
        End If

        If e.KeyChar = "."c AndAlso (TryCast(sender, TextBox)).Text.IndexOf("."c) > -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TBoxQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBoxQty.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "."c Then
            e.Handled = True
        End If

        If e.KeyChar = "."c AndAlso (TryCast(sender, TextBox)).Text.IndexOf("."c) > -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TBoxSubtotal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBoxSubtotal.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "."c Then
            e.Handled = True
        End If

        If e.KeyChar = "."c AndAlso (TryCast(sender, TextBox)).Text.IndexOf("."c) > -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TBoxQty_TextChanged(sender As Object, e As EventArgs) Handles TBoxQty.TextChanged
        Me.TBoxSubtotal.Text = (Val(Me.TBoxUnitPrice.Text) * Val(Me.TBoxQty.Text)) + (Val(Me.TBoxUnitPrice.Text) * Val(Me.TBoxQty.Text) * (Val(TBoxTaxPercentage.Text.Replace("%", "").Trim()) / 100))
    End Sub

    Private Sub TBoxUnitPrice_TextChanged(sender As Object, e As EventArgs) Handles TBoxUnitPrice.TextChanged
        Me.TBoxSubtotal.Text = (Val(Me.TBoxUnitPrice.Text) * Val(Me.TBoxQty.Text)) + (Val(Me.TBoxUnitPrice.Text) * Val(Me.TBoxQty.Text) * (Val(TBoxTaxPercentage.Text.Replace("%", "").Trim()) / 100))
    End Sub

    Private Sub TBoxTaxPercentage_TextChanged(sender As Object, e As EventArgs) Handles TBoxTaxPercentage.TextChanged
        Me.TBoxTaxPercentage.Text = If(Me.TBoxTaxPercentage.Text.Contains("%"), Me.TBoxTaxPercentage.Text, (Me.TBoxTaxPercentage.Text + "%"))
        If (Me.TBoxTaxPercentage.Text.Contains("%")) Then
            Me.TBoxTaxPercentage.Select(Me.TBoxTaxPercentage.Text.Length - 1, 0)
        End If
        Me.TBoxSubtotal.Text = (Val(Me.TBoxUnitPrice.Text) * Val(Me.TBoxQty.Text)) + (Val(Me.TBoxUnitPrice.Text) * Val(Me.TBoxQty.Text) * (Val(TBoxTaxPercentage.Text.Replace("%", "").Trim()) / 100))
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        ' Tax Summary Calculation
        Dim taxSummaries As List(Of TaxSummaryModel) = New List(Of TaxSummaryModel)
        For Each particularRow As DataGridViewRow In Me.DGVParticulars.Rows

            Dim i As Integer = taxSummaries.FindIndex(Function(taxSummary) taxSummary.TaxPercentage = Format((Val(particularRow.Cells("Tax").Value) * 100) / Val(particularRow.Cells("Taxable").Value)) + "%")
            If i <> -1 Then
                taxSummaries(i).Taxable = Format(Val(taxSummaries(i).Taxable) + Val(particularRow.Cells("Taxable").Value))
                taxSummaries(i).Tax = Format(Val(taxSummaries(i).Tax) + Val(particularRow.Cells("Tax").Value))
            Else
                Dim taxSummary As TaxSummaryModel = New TaxSummaryModel
                taxSummary.Taxable = particularRow.Cells("Taxable").Value
                taxSummary.TaxPercentage = Format((Val(particularRow.Cells("Tax").Value) * 100) / Val(particularRow.Cells("Taxable").Value)) + "%"
                taxSummary.Tax = particularRow.Cells("Tax").Value
                taxSummaries.Add(taxSummary)
            End If
        Next
        ' Data Grid View
        Me.DGVTaxSummary.DataSource = Nothing
        Me.DGVTaxSummary.DataSource = taxSummaries


        ' Rich Text Box
        Dim rtbTxt As String = String.Empty
        For Each taxSummary As TaxSummaryModel In taxSummaries
            rtbTxt += $"{taxSummary.TaxPercentage}  {taxSummary.Taxable}  {taxSummary.Tax}{Environment.NewLine}"
        Next
        RichTextBox1.Text = rtbTxt
    End Sub
End Class
