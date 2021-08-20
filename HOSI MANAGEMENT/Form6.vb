Public Class Form6

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If MsgBox("Are you sure you want to quit?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Form2.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SUPPLIERTABLEDataSet.SUPPLIER' table. You can move, or remove it, as needed.
        Me.SUPPLIERTableAdapter.Fill(Me.SUPPLIERTABLEDataSet.SUPPLIER)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        SUPPLIERBindingSource.AddNew()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MessageBox.Show("Do you really want to delete the DATA?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then

            SUPPLIERBindingSource.RemoveCurrent()
        End If


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        SUPPLIERBindingSource.EndEdit()
        SUPPLIERTableAdapter.Update(SUPPLIERTABLEDataSet)
        MessageBox.Show("IT HAS BEEN SAVED SUCCESFUL")

    End Sub
End Class