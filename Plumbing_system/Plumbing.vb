Imports System.Drawing.Printing
Public Class Plumbing
    Dim mcSubTotal As Integer
    Dim mcTotalDue As Integer
    Const cLabour_Price As Integer = 40
    Const cTravel_Price As Integer = 1
    Const cPlastic_Price As Integer = 1
    Const cCopper_Price As Integer = 2
    Const cChrome_Price As Integer = 4
    Dim mcPackagin_Rate As Integer = 20
    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        btnCalculate.Enabled = True
        TxtName.Text = ""
        txtLabourP.Text = ""
        TxtTraveP.Text = ""
        txtCopperP.Text = ""
        TxtPlasticP.Text = ""
        txtChromeP.Text = ""
        lblSubTotal.Text = ""
        lblPackaging.Text = ""
        lblTotalDue.Text = ""
        txtTravel.Text = ""
        txtLabour.Text = ""
        txtChrome.Text = ""
        txtPlastic.Text = ""
        txtCopper.Text = ""

        chkChrome.Checked = False
        chkCopper.Checked = False
        chkPlastic.Checked = False
        chkTravel.Checked = False
        chkLabour.Checked = False
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click

        Dim cPackaging As Double
       
        'Creates variables to hold the values added by user'

       
        txtLabourP.Text = Val(txtLabour.Text) * cLabour_Price
        TxtTraveP.Text = Val(txtTravel.Text) * cTravel_Price
        TxtPlasticP.Text = Val(txtPlastic.Text) * cPlastic_Price
        txtCopperP.Text = Val(txtCopper.Text) * cCopper_Price
        txtChromeP.Text = Val(txtChrome.Text) * cChrome_Price
       

        mcSubTotal = Val(txtLabourP.Text) + Val(TxtTraveP.Text) + Val(TxtPlasticP.Text) + Val(txtCopperP.Text) + Val(txtChrome.Text)


        If chkCollection.Checked = True Then
            cPackaging = cFindPackaging(mcSubTotal) ' call a function procedure
        End If
        mcTotalDue = mcSubTotal + mcPackagin_Rate
        lblSubTotal.Text = FormatCurrency(mcSubTotal)
        lblPackaging.Text = FormatCurrency(mcPackagin_Rate)
        lblTotalDue.Text = FormatCurrency(mcTotalDue)



        btnCalculate.Enabled = False


    End Sub
    Private Function cFindPackaging(ByVal cAmount As Double) As Double
        cFindPackaging = cAmount * mcPackagin_Rate

    End Function

    Private Sub chkCollection_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCollection.CheckedChanged
        If chkCollection.Checked = True Then
            chkTravel.Enabled = False
        ElseIf chkCollection.Checked = False Then
            chkTravel.Enabled = True
        End If
        If chkCollection.Checked = True Then
            chkLabour.Enabled = False
        ElseIf chkCollection.Checked = False Then
            chkLabour.Enabled = True
        End If
    End Sub

    

    Private Sub txtQuantity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click

    End Sub

    Private Sub HelpInfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpInfoToolStripMenuItem.Click
        Help.Show()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub PToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PToolStripMenuItem.Click
        Try
            Dim PrintDoc As New PrintDocument
            AddHandler PrintDoc.PrintPage, AddressOf Me.btnPrint_Click
            PrintDoc.Print()

        Catch ex As Exception
            MessageBox.Show("Printer Error", ex.ToString())
        End Try

    End Sub

    Private Sub PrintPrToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPrToolStripMenuItem.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        'PrintPreviewDialog1.ShowDialog()

        TextBox1.AppendText(" " + vbNewLine)
        TextBox1.AppendText(vbTab & "Pumbling recipt for printng" + vbNewLine)
        TextBox1.AppendText("================================================== " + vbNewLine)
        TextBox1.AppendText(vbTab + lblName.Text + "   " + TxtName.Text & vbTab & vbNewLine)
        TextBox1.AppendText("Items Bought and the amount " + vbNewLine)
        TextBox1.AppendText("================================================== " + vbNewLine)
        TextBox1.AppendText(vbTab + chkTravel.Text + "    " + txtTravel.Text & vbTab & vbNewLine)
        TextBox1.AppendText(vbTab + chkLabour.Text + "    " + txtLabour.Text & vbTab & vbNewLine)
        TextBox1.AppendText(vbTab + chkPlastic.Text + "    " + txtPlastic.Text & vbTab & vbNewLine)
        TextBox1.AppendText(vbTab + chkCopper.Text + "    " + txtCopper.Text & vbTab & vbNewLine)
        TextBox1.AppendText(vbTab + chkChrome.Text + "    " + txtChrome.Text & vbTab & vbNewLine)
        TextBox1.AppendText("Totals " + vbNewLine)
        TextBox1.AppendText("================================================== " + vbNewLine)
        TextBox1.AppendText(vbTab + Label3.Text + "    " + lblSubTotal.Text & vbTab & vbNewLine)
        TextBox1.AppendText(vbTab + Label4.Text + "     " + lblPackaging.Text & vbTab & vbNewLine)
        TextBox1.AppendText(vbTab + Label5.Text + "     " + lblTotalDue.Text & vbTab & vbNewLine)

    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(lblTotalDue.Text, New Font("Arial", 11, FontStyle.Regular), Brushes.Black, 120, 120)

    End Sub

    Private Sub PrintPreviewDialog1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewDialog1.Load

    End Sub

    Private Sub chkTravel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTravel.CheckedChanged

    End Sub

    Private Sub chkTravel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkTravel.Click
       


    End Sub

    Private Sub txtTravel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTravel.KeyPress, txtChromeP.KeyPress, txtCopperP.KeyPress, TxtPlasticP.KeyPress, txtLabourP.KeyPress, TxtTraveP.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If


    End Sub





    Private Sub txtTravel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTravel.TextChanged, TxtTraveP.TextChanged, txtLabourP.TextChanged, TxtPlasticP.TextChanged, txtCopperP.TextChanged, txtChromeP.TextChanged

    End Sub

    Private Sub txtLabour_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLabour.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If


    End Sub

    Private Sub txtLabour_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLabour.TextChanged

    End Sub

    Private Sub txtPlastic_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPlastic.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If


    End Sub

    Private Sub txtPlastic_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPlastic.TextChanged

    End Sub

    Private Sub txtCopper_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCopper.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If


    End Sub

    Private Sub txtCopper_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCopper.TextChanged

    End Sub

    Private Sub txtChrome_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtChrome.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If


    End Sub

    Private Sub txtChrome_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtChrome.TextChanged

    End Sub

    Private Sub lblItemAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPackaging.TextChanged, lblTotalDue.TextChanged

    End Sub

    Private Sub TxtName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtName.TextChanged

    End Sub
End Class
