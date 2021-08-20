Public Class Form7

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click

    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
       
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If MsgBox("Are you sure you want to CLOSE the program?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Form2.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If MessageBox.Show("Do you really want to delete the DATA?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            PurchaseBindingSource.RemoveCurrent()


        End If


    End Sub

    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PURCHASEDataSet.purchase' table. You can move, or remove it, as needed.
        Me.PurchaseTableAdapter.Fill(Me.PURCHASEDataSet.purchase)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        PurchaseBindingSource.AddNew()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        PurchaseBindingSource.MoveNext()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If DateTimePicker2.Text <= DateTimePicker3.Text Then
            MessageBox.Show("manufacture date should not be equal OR greater to Expiry date")


        Else
            PurchaseBindingSource.EndEdit()
            PurchaseTableAdapter.Update(PURCHASEDataSet)
            MessageBox.Show("YOUR INFO HAVE BEEN SAVE SUCCESFUL")


        End If
            



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim quantity As Integer
        Dim medicineprice As Integer
        Dim discount As Integer
        Dim vat As Integer
        quantity = TextBox7.Text
        medicineprice = TextBox8.Text
        discount = TextBox9.Text
        vat = TextBox10.Text

        TextBox11.Text = ((quantity * medicineprice) - (discount + vat))

    End Sub

    Private Sub TextBox12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox12.TextChanged
        TextBox12.Text = TextBox11.Text

    End Sub

    Private Sub TextBox11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox11.TextChanged
        TextBox12.Text = TextBox11.Text
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim search As Integer = TextBox13.Text

        Me.PurchaseTableAdapter.FillBysearchpurchaseNo(Me.PURCHASEDataSet.purchase, search)

    End Sub
End Class