Public Class Form3

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If MsgBox("Are you sure you want to quit?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Form2.Show()
            Me.Hide()

        End If
    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'STAFFTABLEDataSet.staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.STAFFTABLEDataSet.staff)
        'TODO: This line of code loads data into the 'STAFFTABLEDataSet.staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.STAFFTABLEDataSet.staff)


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        StaffBindingSource.AddNew()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        StaffBindingSource.EndEdit()
        StaffTableAdapter.Update(STAFFTABLEDataSet)
        MessageBox.Show("THE DATA HAS BEEN SAVED SUCCESFULLY")

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        StaffBindingSource.MoveNext()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        StaffBindingSource.MovePrevious()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click


        If MessageBox.Show("Do you really want to delete the DATA?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            StaffBindingSource.RemoveCurrent()

        End If


    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Validate()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim search As Integer = TextBox11.Text

        Me.StaffTableAdapter.FillBysearchID(Me.STAFFTABLEDataSet.staff, search)


    End Sub

    Private Sub TextBox11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox11.TextChanged
       
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click


        Dim deduction As Integer
        Dim allowances As Integer
        Dim salary As Integer
        deduction = TextBox8.Text



        allowances = TextBox7.Text
        salary = TextBox6.Text

        TextBox10.Text = ((salary + allowances) - deduction)
       

        





    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        TextBox5.Text = TextBox1.Text

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        TextBox5.Text = TextBox1.Text
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Reset()

    End Sub
End Class