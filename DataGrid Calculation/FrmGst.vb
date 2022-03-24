Public Class FrmGst
    Dim particulars As List(Of GstPerticularModel)
    Private Sub FrmGst_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ComboBoxInvoiceType.SelectedIndex = 0
        Me.particulars = New List(Of GstPerticularModel)()
        Me.DGVParticulars.DataSource = Nothing
        Me.DGVParticulars.DataSource = Me.particulars
        Me.TBoxTaxPercentage.Text = 0
    End Sub
    Private Sub DGVCals_DataSourceChanged(sender As Object, e As EventArgs) Handles DGVParticulars.DataSourceChanged
        ' Footer Total Calculation
        'Dim total = 0
        'Dim tax = 0
        'Dim grandtotal = 0
        'For Each row As DataGridViewRow In Me.DGVParticulars.Rows
        'total += Val(row.Cells("Taxable").Value.ToString())
        'tax += Val(row.Cells("Tax").Value.ToString())
        'grandtotal += Val(row.Cells("Subtotal").Value.ToString())
        'Next
        'Me.ValTotal.Text = total
        'Me.ValGST.Text = tax
        'Me.ValGrandTotal.Text = grandtotal


    End Sub
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim data As GstPerticularModel = New GstPerticularModel()
        data.ItemName = Me.TBoxProductName.Text
        data.UnitPrice = Me.TBoxUnitPrice.Text
        data.Qty = Me.TBoxQty.Text
        data.Gst = Val(TBoxTaxPercentage.Text.Replace("%", "").Trim())
        data.GstAmount = Val(Me.TBoxUnitPrice.Text) * Val(Me.TBoxQty.Text) * (Val(TBoxTaxPercentage.Text.Replace("%", "").Trim()) / 100)
        data.Taxable = Val(Me.TBoxUnitPrice.Text) * Val(Me.TBoxQty.Text)
        data.Subtotal = (Val(Me.TBoxUnitPrice.Text) * Val(Me.TBoxQty.Text)) + (Val(Me.TBoxUnitPrice.Text) * Val(Me.TBoxQty.Text) * (Val(TBoxTaxPercentage.Text.Replace("%", "").Trim()) / 100))

        If ComboBoxInvoiceType.Text = "LGST" Then
            data.TaxType = GstType.LGST
            Me.particulars.Add(data)
        ElseIf ComboBoxInvoiceType.Text = "IGST" Then
            data.TaxType = GstType.IGST
            Me.particulars.Add(data)
        Else
            'Do Nothing
        End If

        Me.DGVParticulars.DataSource = Nothing
        Me.DGVParticulars.DataSource = Me.particulars
    End Sub

    Private Sub CBoxGSTPercent_SelectedIndexChanged(sender As Object, e As EventArgs)
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
        Dim taxSummaries As List(Of GstSummaryModel) = New List(Of GstSummaryModel)
        For Each particularRow As DataGridViewRow In Me.DGVParticulars.Rows
            Dim taxType = particularRow.Cells(3).Value
            Dim gst = particularRow.Cells(4).Value
            Dim gstAmount = particularRow.Cells(5).Value
            Dim taxable = particularRow.Cells(6).Value
            Dim i As Integer = taxSummaries.FindIndex(Function(elem)
                                                          If taxType = GstType.LGST Then
                                                              If elem.Gst = $"{Val(gst) / 2}% + {Val(particularRow.Cells("Gst").Value) / 2}%" Then
                                                                  Return True
                                                              End If
                                                          ElseIf taxType = GstType.IGST Then
                                                              If elem.Gst = $"{Format(Val(taxSummaries(i).Gst) + Val(particularRow.Cells("Gst").Value))}" Then
                                                                  Return True
                                                              End If
                                                          End If
                                                          Return False
                                                      End Function)
            If i <> -1 Then
                taxSummaries(i).Taxable += Format(Val(taxSummaries(i).Taxable) + Val(taxable))
                taxSummaries(i).SGSTAmount += Format(Val(gstAmount) / 2)
                taxSummaries(i).CGSTAmount += Format(Val(gstAmount) / 2)
                taxSummaries(i).IGSTAmount += gstAmount


            Else
                Dim taxSummary As GstSummaryModel = New GstSummaryModel
                taxSummary.TaxType = taxType
                taxSummary.Taxable = taxable
                taxSummary.SGSTAmount = Val(gstAmount) / 2
                taxSummary.CGSTAmount = Val(gstAmount) / 2
                taxSummary.IGSTAmount = gstAmount
                If taxType = GstType.LGST Then
                    taxSummary.Gst = $"{Val(gst) / 2}% + {Val(gst) / 2}%"
                    taxSummaries.Add(taxSummary)
                ElseIf taxType = GstType.IGST Then
                    taxSummary.Gst = $"{Format(Val(gst) + Val(gst))}%"
                    taxSummaries.Add(taxSummary)
                Else
                    'Do Nothing
                End If

            End If


        Next
        ' Data Grid View
        Me.DGVTaxSummary.DataSource = Nothing
        Me.DGVTaxSummary.DataSource = taxSummaries


        ' Rich Text Box
        Dim rtbTxt As String = String.Empty
        For Each taxSummary As GstSummaryModel In taxSummaries
            If taxSummary.TaxType = GstType.LGST Then
                rtbTxt += $"LGST  {taxSummary.Gst}%  {taxSummary.Taxable}  {taxSummary.SGSTAmount}  {taxSummary.CGSTAmount}  {taxSummary.IGSTAmount}{Environment.NewLine}"
            ElseIf taxSummary.TaxType = GstType.IGST Then
                rtbTxt += $"IGST  {taxSummary.Gst}%  {taxSummary.Taxable}  {taxSummary.SGSTAmount}  {taxSummary.CGSTAmount}  {taxSummary.IGSTAmount}{Environment.NewLine}"
            Else
                'Do Nothing
            End If
        Next
        RichTextBox1.Text = rtbTxt
    End Sub
End Class