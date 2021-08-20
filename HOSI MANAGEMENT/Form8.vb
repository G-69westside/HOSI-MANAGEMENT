Imports System.Drawing.Printing

Public Class Form8

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If MsgBox("Are you sure you want to quit?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Form2.Show()
            Me.Hide()

        End If
    End Sub

    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SALESTABLEDataSet.SALES' table. You can move, or remove it, as needed.
        Me.SALESTableAdapter.Fill(Me.SALESTABLEDataSet.SALES)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        SALESBindingSource.AddNew()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        SALESBindingSource.EndEdit()
        SALESTableAdapter.Update(SALESTABLEDataSet)




    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font1 As New Font("arial", 16, FontStyle.Regular)
        e.Graphics.DrawString(TextBox1.Text, font1, Brushes.Black, 100, 100)


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        RichTextBox1.AppendText("  TOTAL BILLING SYTEM CALCULATION" + vbNewLine)
        RichTextBox1.AppendText("--------------------------------------" + vbNewLine)
        RichTextBox1.AppendText("     Enter bill no=" + vbTab + TextBox4.Text + vbNewLine)
        RichTextBox1.AppendText("     Total amount=" + vbTab + TextBox5.Text + vbNewLine)
        RichTextBox1.AppendText("     Discount=" + vbTab + TextBox6.Text + vbNewLine)
        RichTextBox1.AppendText("     Amount paid=" + vbTab + TextBox7.Text + vbNewLine)
        RichTextBox1.AppendText("     Change=" + vbTab + TextBox8.Text + vbNewLine)
        RichTextBox1.AppendText("-------------------------------------------------------------------" + vbNewLine)
        RichTextBox1.AppendText("------------------thank you------------------" + vbNewLine)


    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim quantity As Integer
        Dim price As Integer
        quantity = TextBox1.Text
        price = TextBox2.Text
        TextBox3.Text = quantity * price

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        TextBox5.Text = TextBox3.Text

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim totalamount As Integer
        Dim discount As Integer
        Dim amountpaid As Integer
        totalamount = TextBox5.Text
        discount = TextBox6.Text
        amountpaid = TextBox7.Text
        TextBox8.Text = (amountpaid - (totalamount - discount))






    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        If MessageBox.Show("Do you really want to delete the DATA?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            SALESBindingSource.RemoveCurrent()
        End If

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        SALESBindingSource.MoveNext()
    End Sub


    Private Sub BunifuFlatButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class