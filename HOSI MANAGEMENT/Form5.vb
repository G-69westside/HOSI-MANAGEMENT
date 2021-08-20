Public Class Form5

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If MsgBox("Are you sure you want to quit?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Form2.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MEDICINETABLEDataSet.MEDICINE' table. You can move, or remove it, as needed.
        Me.MEDICINETableAdapter.Fill(Me.MEDICINETABLEDataSet.MEDICINE)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim search As String = TextBox6.Text

        Me.MEDICINETableAdapter.FillBysearchMEDICINECODE(Me.MEDICINETABLEDataSet.MEDICINE, search)
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        MEDICINEBindingSource.AddNew()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MEDICINEBindingSource.MoveNext()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        MEDICINEBindingSource.MovePrevious()

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If DateTimePicker1.Text <= DateTimePicker2.Text Then
            MessageBox.Show("manufacture date should not be equal or greater than Expiry date")
        Else

            MEDICINETableAdapter.Update(MEDICINETABLEDataSet)
            MEDICINEBindingSource.EndEdit()



        End If


    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If MessageBox.Show("Do you really want to delete the DATA?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then

            MEDICINEBindingSource.RemoveCurrent()
        End If


    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class