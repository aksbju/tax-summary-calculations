<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGst
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.TBoxTaxPercentage = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DGVTaxSummary = New System.Windows.Forms.DataGridView()
        Me.ValTotal = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ValGST = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TBoxQty = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBoxUnitPrice = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TBoxSubtotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ValGrandTotal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.TBoxProductName = New System.Windows.Forms.TextBox()
        Me.DGVParticulars = New System.Windows.Forms.DataGridView()
        Me.ComboBoxInvoiceType = New System.Windows.Forms.ComboBox()
        CType(Me.DGVTaxSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVParticulars, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(358, 343)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 13)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Tax Summary (Rich Text Box)"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 317)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 23)
        Me.Button1.TabIndex = 53
        Me.Button1.Text = "Tax Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(361, 359)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(204, 79)
        Me.RichTextBox1.TabIndex = 52
        Me.RichTextBox1.Text = ""
        '
        'TBoxTaxPercentage
        '
        Me.TBoxTaxPercentage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBoxTaxPercentage.Location = New System.Drawing.Point(518, 64)
        Me.TBoxTaxPercentage.Name = "TBoxTaxPercentage"
        Me.TBoxTaxPercentage.Size = New System.Drawing.Size(73, 20)
        Me.TBoxTaxPercentage.TabIndex = 35
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 343)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 13)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Tax Summary (DataGridView)"
        '
        'DGVTaxSummary
        '
        Me.DGVTaxSummary.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DGVTaxSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVTaxSummary.Location = New System.Drawing.Point(12, 359)
        Me.DGVTaxSummary.Name = "DGVTaxSummary"
        Me.DGVTaxSummary.Size = New System.Drawing.Size(343, 79)
        Me.DGVTaxSummary.TabIndex = 50
        '
        'ValTotal
        '
        Me.ValTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ValTotal.AutoSize = True
        Me.ValTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValTotal.Location = New System.Drawing.Point(705, 354)
        Me.ValTotal.Margin = New System.Windows.Forms.Padding(3)
        Me.ValTotal.Name = "ValTotal"
        Me.ValTotal.Size = New System.Drawing.Size(36, 16)
        Me.ValTotal.TabIndex = 49
        Me.ValTotal.Text = "0.00"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(631, 354)
        Me.Label12.Margin = New System.Windows.Forms.Padding(3)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 16)
        Me.Label12.TabIndex = 48
        Me.Label12.Text = "Total :"
        '
        'ValGST
        '
        Me.ValGST.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ValGST.AutoSize = True
        Me.ValGST.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValGST.Location = New System.Drawing.Point(705, 376)
        Me.ValGST.Margin = New System.Windows.Forms.Padding(3)
        Me.ValGST.Name = "ValGST"
        Me.ValGST.Size = New System.Drawing.Size(36, 16)
        Me.ValGST.TabIndex = 47
        Me.ValGST.Text = "0.00"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(634, 376)
        Me.Label10.Margin = New System.Windows.Forms.Padding(3)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 16)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "GST :"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(431, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 13)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Qty"
        '
        'TBoxQty
        '
        Me.TBoxQty.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBoxQty.Location = New System.Drawing.Point(434, 64)
        Me.TBoxQty.Name = "TBoxQty"
        Me.TBoxQty.Size = New System.Drawing.Size(78, 20)
        Me.TBoxQty.TabIndex = 34
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(349, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Unit Price"
        '
        'TBoxUnitPrice
        '
        Me.TBoxUnitPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBoxUnitPrice.Location = New System.Drawing.Point(352, 64)
        Me.TBoxUnitPrice.Name = "TBoxUnitPrice"
        Me.TBoxUnitPrice.Size = New System.Drawing.Size(76, 20)
        Me.TBoxUnitPrice.TabIndex = 33
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(594, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 13)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Subtotal (Incl tax)"
        '
        'TBoxSubtotal
        '
        Me.TBoxSubtotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBoxSubtotal.Location = New System.Drawing.Point(597, 64)
        Me.TBoxSubtotal.Name = "TBoxSubtotal"
        Me.TBoxSubtotal.Size = New System.Drawing.Size(110, 20)
        Me.TBoxSubtotal.TabIndex = 36
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(515, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Gst%"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Product Name"
        '
        'ValGrandTotal
        '
        Me.ValGrandTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ValGrandTotal.AutoSize = True
        Me.ValGrandTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValGrandTotal.Location = New System.Drawing.Point(705, 398)
        Me.ValGrandTotal.Margin = New System.Windows.Forms.Padding(3)
        Me.ValGrandTotal.Name = "ValGrandTotal"
        Me.ValGrandTotal.Size = New System.Drawing.Size(36, 16)
        Me.ValGrandTotal.TabIndex = 39
        Me.ValGrandTotal.Text = "0.00"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(591, 398)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 16)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Grand Total :"
        '
        'BtnAdd
        '
        Me.BtnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAdd.Location = New System.Drawing.Point(713, 62)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 23)
        Me.BtnAdd.TabIndex = 37
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'TBoxProductName
        '
        Me.TBoxProductName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBoxProductName.Location = New System.Drawing.Point(12, 64)
        Me.TBoxProductName.Name = "TBoxProductName"
        Me.TBoxProductName.Size = New System.Drawing.Size(334, 20)
        Me.TBoxProductName.TabIndex = 32
        '
        'DGVParticulars
        '
        Me.DGVParticulars.AllowUserToAddRows = False
        Me.DGVParticulars.AllowUserToDeleteRows = False
        Me.DGVParticulars.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVParticulars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVParticulars.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVParticulars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVParticulars.Location = New System.Drawing.Point(12, 91)
        Me.DGVParticulars.Name = "DGVParticulars"
        Me.DGVParticulars.ReadOnly = True
        Me.DGVParticulars.Size = New System.Drawing.Size(776, 220)
        Me.DGVParticulars.TabIndex = 40
        '
        'ComboBoxInvoiceType
        '
        Me.ComboBoxInvoiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxInvoiceType.FormattingEnabled = True
        Me.ComboBoxInvoiceType.Items.AddRange(New Object() {"LGST", "IGST"})
        Me.ComboBoxInvoiceType.Location = New System.Drawing.Point(15, 13)
        Me.ComboBoxInvoiceType.Name = "ComboBoxInvoiceType"
        Me.ComboBoxInvoiceType.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxInvoiceType.TabIndex = 55
        '
        'FrmGst
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ComboBoxInvoiceType)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.TBoxTaxPercentage)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DGVTaxSummary)
        Me.Controls.Add(Me.ValTotal)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.ValGST)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TBoxQty)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TBoxUnitPrice)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TBoxSubtotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ValGrandTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.TBoxProductName)
        Me.Controls.Add(Me.DGVParticulars)
        Me.Name = "FrmGst"
        Me.Text = "FrmGst"
        CType(Me.DGVTaxSummary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVParticulars, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents TBoxTaxPercentage As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DGVTaxSummary As DataGridView
    Friend WithEvents ValTotal As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents ValGST As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TBoxQty As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TBoxUnitPrice As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TBoxSubtotal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ValGrandTotal As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnAdd As Button
    Friend WithEvents TBoxProductName As TextBox
    Friend WithEvents DGVParticulars As DataGridView
    Friend WithEvents ComboBoxInvoiceType As ComboBox
End Class
