<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmApp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DGVParticulars = New System.Windows.Forms.DataGridView()
        Me.TBoxProductName = New System.Windows.Forms.TextBox()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ValGrandTotal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TBoxSubtotal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBoxUnitPrice = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TBoxQty = New System.Windows.Forms.TextBox()
        Me.ValGST = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ValTotal = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DGVTaxSummary = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBoxTaxPercentage = New System.Windows.Forms.TextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DGVParticulars, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVTaxSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.DGVParticulars.Location = New System.Drawing.Point(12, 58)
        Me.DGVParticulars.Name = "DGVParticulars"
        Me.DGVParticulars.ReadOnly = True
        Me.DGVParticulars.Size = New System.Drawing.Size(776, 253)
        Me.DGVParticulars.TabIndex = 8
        '
        'TBoxProductName
        '
        Me.TBoxProductName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBoxProductName.Location = New System.Drawing.Point(12, 31)
        Me.TBoxProductName.Name = "TBoxProductName"
        Me.TBoxProductName.Size = New System.Drawing.Size(334, 20)
        Me.TBoxProductName.TabIndex = 2
        '
        'BtnAdd
        '
        Me.BtnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAdd.Location = New System.Drawing.Point(713, 29)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 23)
        Me.BtnAdd.TabIndex = 7
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
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
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Grand Total :"
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
        Me.ValGrandTotal.TabIndex = 8
        Me.ValGrandTotal.Text = "0.00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Product Name"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(515, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Tax%"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(594, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Subtotal (Incl tax)"
        '
        'TBoxSubtotal
        '
        Me.TBoxSubtotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBoxSubtotal.Location = New System.Drawing.Point(597, 31)
        Me.TBoxSubtotal.Name = "TBoxSubtotal"
        Me.TBoxSubtotal.Size = New System.Drawing.Size(110, 20)
        Me.TBoxSubtotal.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(349, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Unit Price"
        '
        'TBoxUnitPrice
        '
        Me.TBoxUnitPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBoxUnitPrice.Location = New System.Drawing.Point(352, 31)
        Me.TBoxUnitPrice.Name = "TBoxUnitPrice"
        Me.TBoxUnitPrice.Size = New System.Drawing.Size(76, 20)
        Me.TBoxUnitPrice.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(431, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Qty"
        '
        'TBoxQty
        '
        Me.TBoxQty.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBoxQty.Location = New System.Drawing.Point(434, 31)
        Me.TBoxQty.Name = "TBoxQty"
        Me.TBoxQty.Size = New System.Drawing.Size(78, 20)
        Me.TBoxQty.TabIndex = 4
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
        Me.ValGST.TabIndex = 24
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
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "GST :"
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
        Me.ValTotal.TabIndex = 26
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
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Total :"
        '
        'DGVTaxSummary
        '
        Me.DGVTaxSummary.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DGVTaxSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVTaxSummary.Location = New System.Drawing.Point(12, 359)
        Me.DGVTaxSummary.Name = "DGVTaxSummary"
        Me.DGVTaxSummary.Size = New System.Drawing.Size(343, 79)
        Me.DGVTaxSummary.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 343)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Tax Summary (DataGridView)"
        '
        'TBoxTaxPercentage
        '
        Me.TBoxTaxPercentage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBoxTaxPercentage.Location = New System.Drawing.Point(518, 31)
        Me.TBoxTaxPercentage.Name = "TBoxTaxPercentage"
        Me.TBoxTaxPercentage.Size = New System.Drawing.Size(73, 20)
        Me.TBoxTaxPercentage.TabIndex = 5
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(361, 359)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(204, 79)
        Me.RichTextBox1.TabIndex = 29
        Me.RichTextBox1.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 317)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 23)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Tax Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(358, 343)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Tax Summary (Rich Text Box)"
        '
        'FrmApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
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
        Me.Name = "FrmApp"
        Me.Text = "Form1"
        CType(Me.DGVParticulars, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVTaxSummary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVParticulars As DataGridView
    Friend WithEvents TBoxProductName As TextBox
    Friend WithEvents BtnAdd As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ValGrandTotal As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TBoxSubtotal As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TBoxUnitPrice As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TBoxQty As TextBox
    Friend WithEvents ValGST As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ValTotal As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents DGVTaxSummary As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents TBoxTaxPercentage As TextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
End Class
