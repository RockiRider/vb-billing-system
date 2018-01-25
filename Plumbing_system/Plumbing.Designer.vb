<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Plumbing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Plumbing))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.btnPrint = New System.Windows.Forms.Button
        Me.lblName = New System.Windows.Forms.Label
        Me.TxtName = New System.Windows.Forms.TextBox
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnCalculate = New System.Windows.Forms.Button
        Me.chkCollection = New System.Windows.Forms.CheckBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtChrome = New System.Windows.Forms.TextBox
        Me.txtCopper = New System.Windows.Forms.TextBox
        Me.txtPlastic = New System.Windows.Forms.TextBox
        Me.txtLabour = New System.Windows.Forms.TextBox
        Me.TxtTraveP = New System.Windows.Forms.TextBox
        Me.txtChromeP = New System.Windows.Forms.TextBox
        Me.txtCopperP = New System.Windows.Forms.TextBox
        Me.TxtPlasticP = New System.Windows.Forms.TextBox
        Me.txtLabourP = New System.Windows.Forms.TextBox
        Me.txtTravel = New System.Windows.Forms.TextBox
        Me.chkChrome = New System.Windows.Forms.CheckBox
        Me.chkCopper = New System.Windows.Forms.CheckBox
        Me.chkPlastic = New System.Windows.Forms.CheckBox
        Me.chkLabour = New System.Windows.Forms.CheckBox
        Me.chkTravel = New System.Windows.Forms.CheckBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblTotalDue = New System.Windows.Forms.TextBox
        Me.lblPackaging = New System.Windows.Forms.TextBox
        Me.lblSubTotal = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintPrToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewReciptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.btnPrint)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Controls.Add(Me.TxtName)
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.btnCalculate)
        Me.GroupBox1.Controls.Add(Me.chkCollection)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.MenuStrip1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1371, 711)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Order Information"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(958, 59)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(385, 390)
        Me.TextBox1.TabIndex = 13
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(1029, 520)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(155, 76)
        Me.btnPrint.TabIndex = 12
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(32, 60)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(102, 42)
        Me.lblName.TabIndex = 11
        Me.lblName.Text = "Enter Name"
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(155, 59)
        Me.TxtName.Multiline = True
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(185, 41)
        Me.TxtName.TabIndex = 10
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(289, 267)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(181, 39)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear For Next Item"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(35, 267)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(181, 39)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate Section"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'chkCollection
        '
        Me.chkCollection.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCollection.Location = New System.Drawing.Point(35, 135)
        Me.chkCollection.Name = "chkCollection"
        Me.chkCollection.Size = New System.Drawing.Size(112, 43)
        Me.chkCollection.TabIndex = 4
        Me.chkCollection.Text = "Collection?"
        Me.chkCollection.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtChrome)
        Me.GroupBox3.Controls.Add(Me.txtCopper)
        Me.GroupBox3.Controls.Add(Me.txtPlastic)
        Me.GroupBox3.Controls.Add(Me.txtLabour)
        Me.GroupBox3.Controls.Add(Me.TxtTraveP)
        Me.GroupBox3.Controls.Add(Me.txtChromeP)
        Me.GroupBox3.Controls.Add(Me.txtCopperP)
        Me.GroupBox3.Controls.Add(Me.TxtPlasticP)
        Me.GroupBox3.Controls.Add(Me.txtLabourP)
        Me.GroupBox3.Controls.Add(Me.txtTravel)
        Me.GroupBox3.Controls.Add(Me.chkChrome)
        Me.GroupBox3.Controls.Add(Me.chkCopper)
        Me.GroupBox3.Controls.Add(Me.chkPlastic)
        Me.GroupBox3.Controls.Add(Me.chkLabour)
        Me.GroupBox3.Controls.Add(Me.chkTravel)
        Me.GroupBox3.Location = New System.Drawing.Point(523, 31)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(429, 442)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Service Selection"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(354, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 30)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Price"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(243, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Amount"
        '
        'txtChrome
        '
        Me.txtChrome.Location = New System.Drawing.Point(245, 328)
        Me.txtChrome.Name = "txtChrome"
        Me.txtChrome.Size = New System.Drawing.Size(64, 20)
        Me.txtChrome.TabIndex = 1
        '
        'txtCopper
        '
        Me.txtCopper.Location = New System.Drawing.Point(245, 263)
        Me.txtCopper.Name = "txtCopper"
        Me.txtCopper.Size = New System.Drawing.Size(64, 20)
        Me.txtCopper.TabIndex = 1
        '
        'txtPlastic
        '
        Me.txtPlastic.Location = New System.Drawing.Point(245, 185)
        Me.txtPlastic.Name = "txtPlastic"
        Me.txtPlastic.Size = New System.Drawing.Size(64, 20)
        Me.txtPlastic.TabIndex = 1
        '
        'txtLabour
        '
        Me.txtLabour.Location = New System.Drawing.Point(245, 122)
        Me.txtLabour.Name = "txtLabour"
        Me.txtLabour.Size = New System.Drawing.Size(64, 20)
        Me.txtLabour.TabIndex = 1
        '
        'TxtTraveP
        '
        Me.TxtTraveP.Location = New System.Drawing.Point(340, 49)
        Me.TxtTraveP.Name = "TxtTraveP"
        Me.TxtTraveP.Size = New System.Drawing.Size(64, 20)
        Me.TxtTraveP.TabIndex = 1
        '
        'txtChromeP
        '
        Me.txtChromeP.Location = New System.Drawing.Point(340, 328)
        Me.txtChromeP.Name = "txtChromeP"
        Me.txtChromeP.Size = New System.Drawing.Size(64, 20)
        Me.txtChromeP.TabIndex = 1
        '
        'txtCopperP
        '
        Me.txtCopperP.Location = New System.Drawing.Point(340, 263)
        Me.txtCopperP.Name = "txtCopperP"
        Me.txtCopperP.Size = New System.Drawing.Size(64, 20)
        Me.txtCopperP.TabIndex = 1
        '
        'TxtPlasticP
        '
        Me.TxtPlasticP.Location = New System.Drawing.Point(340, 185)
        Me.TxtPlasticP.Name = "TxtPlasticP"
        Me.TxtPlasticP.Size = New System.Drawing.Size(64, 20)
        Me.TxtPlasticP.TabIndex = 1
        '
        'txtLabourP
        '
        Me.txtLabourP.Location = New System.Drawing.Point(340, 122)
        Me.txtLabourP.Name = "txtLabourP"
        Me.txtLabourP.Size = New System.Drawing.Size(64, 20)
        Me.txtLabourP.TabIndex = 1
        '
        'txtTravel
        '
        Me.txtTravel.Location = New System.Drawing.Point(244, 49)
        Me.txtTravel.Name = "txtTravel"
        Me.txtTravel.Size = New System.Drawing.Size(64, 20)
        Me.txtTravel.TabIndex = 1
        '
        'chkChrome
        '
        Me.chkChrome.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkChrome.Location = New System.Drawing.Point(27, 319)
        Me.chkChrome.Name = "chkChrome"
        Me.chkChrome.Size = New System.Drawing.Size(255, 37)
        Me.chkChrome.TabIndex = 0
        Me.chkChrome.Text = "Chrome Pipes (£3 Per metre)"
        Me.chkChrome.UseVisualStyleBackColor = True
        '
        'chkCopper
        '
        Me.chkCopper.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCopper.Location = New System.Drawing.Point(27, 255)
        Me.chkCopper.Name = "chkCopper"
        Me.chkCopper.Size = New System.Drawing.Size(229, 35)
        Me.chkCopper.TabIndex = 0
        Me.chkCopper.Text = "Copper Pipes(£2 Per Metre)"
        Me.chkCopper.UseVisualStyleBackColor = True
        '
        'chkPlastic
        '
        Me.chkPlastic.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPlastic.Location = New System.Drawing.Point(27, 185)
        Me.chkPlastic.Name = "chkPlastic"
        Me.chkPlastic.Size = New System.Drawing.Size(240, 33)
        Me.chkPlastic.TabIndex = 0
        Me.chkPlastic.Text = "Plastic Pipes(£1 Per Metre)"
        Me.chkPlastic.UseVisualStyleBackColor = True
        '
        'chkLabour
        '
        Me.chkLabour.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLabour.Location = New System.Drawing.Point(27, 115)
        Me.chkLabour.Name = "chkLabour"
        Me.chkLabour.Size = New System.Drawing.Size(183, 32)
        Me.chkLabour.TabIndex = 0
        Me.chkLabour.Text = "Labour(£40 Per Hour"
        Me.chkLabour.UseVisualStyleBackColor = True
        '
        'chkTravel
        '
        Me.chkTravel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTravel.Location = New System.Drawing.Point(27, 45)
        Me.chkTravel.Name = "chkTravel"
        Me.chkTravel.Size = New System.Drawing.Size(204, 41)
        Me.chkTravel.TabIndex = 0
        Me.chkTravel.Text = "Travel (£1 Per Mile)"
        Me.chkTravel.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblTotalDue)
        Me.GroupBox2.Controls.Add(Me.lblPackaging)
        Me.GroupBox2.Controls.Add(Me.lblSubTotal)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 523)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(838, 167)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Payment"
        '
        'lblTotalDue
        '
        Me.lblTotalDue.Location = New System.Drawing.Point(224, 128)
        Me.lblTotalDue.Multiline = True
        Me.lblTotalDue.Name = "lblTotalDue"
        Me.lblTotalDue.Size = New System.Drawing.Size(404, 33)
        Me.lblTotalDue.TabIndex = 2
        '
        'lblPackaging
        '
        Me.lblPackaging.Location = New System.Drawing.Point(224, 78)
        Me.lblPackaging.Multiline = True
        Me.lblPackaging.Name = "lblPackaging"
        Me.lblPackaging.Size = New System.Drawing.Size(404, 33)
        Me.lblPackaging.TabIndex = 2
        '
        'lblSubTotal
        '
        Me.lblSubTotal.Location = New System.Drawing.Point(224, 19)
        Me.lblSubTotal.Multiline = True
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(404, 33)
        Me.lblSubTotal.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 32)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Total Due"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 32)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Packaging (If collected)"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 32)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Sub Total"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 16)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1365, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PToolStripMenuItem, Me.PrintPrToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'PToolStripMenuItem
        '
        Me.PToolStripMenuItem.Name = "PToolStripMenuItem"
        Me.PToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.PToolStripMenuItem.Text = "Print Orders"
        '
        'PrintPrToolStripMenuItem
        '
        Me.PrintPrToolStripMenuItem.Name = "PrintPrToolStripMenuItem"
        Me.PrintPrToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.PrintPrToolStripMenuItem.Text = "Print Preview"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewReciptToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'ViewReciptToolStripMenuItem
        '
        Me.ViewReciptToolStripMenuItem.Name = "ViewReciptToolStripMenuItem"
        Me.ViewReciptToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.ViewReciptToolStripMenuItem.Text = "View Recipt"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpInfoToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'HelpInfoToolStripMenuItem
        '
        Me.HelpInfoToolStripMenuItem.Name = "HelpInfoToolStripMenuItem"
        Me.HelpInfoToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.HelpInfoToolStripMenuItem.Text = "Help Info"
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Plumbing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1438, 758)
        Me.Controls.Add(Me.GroupBox1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Plumbing"
        Me.Text = "Plumbing System"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents chkCollection As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkChrome As System.Windows.Forms.CheckBox
    Friend WithEvents chkCopper As System.Windows.Forms.CheckBox
    Friend WithEvents chkPlastic As System.Windows.Forms.CheckBox
    Friend WithEvents chkLabour As System.Windows.Forms.CheckBox
    Friend WithEvents chkTravel As System.Windows.Forms.CheckBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewReciptToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpInfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents TxtName As System.Windows.Forms.TextBox
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPrToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents txtTravel As System.Windows.Forms.TextBox
    Friend WithEvents txtChrome As System.Windows.Forms.TextBox
    Friend WithEvents txtCopper As System.Windows.Forms.TextBox
    Friend WithEvents txtPlastic As System.Windows.Forms.TextBox
    Friend WithEvents txtLabour As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtTraveP As System.Windows.Forms.TextBox
    Friend WithEvents txtChromeP As System.Windows.Forms.TextBox
    Friend WithEvents txtCopperP As System.Windows.Forms.TextBox
    Friend WithEvents TxtPlasticP As System.Windows.Forms.TextBox
    Friend WithEvents txtLabourP As System.Windows.Forms.TextBox
    Friend WithEvents lblPackaging As System.Windows.Forms.TextBox
    Friend WithEvents lblSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalDue As System.Windows.Forms.TextBox

End Class
