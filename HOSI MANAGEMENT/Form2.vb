Public Class Form2

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BunifuFlatButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuFlatButton1.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuFlatButton2.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuFlatButton3.Click
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuFlatButton4.Click
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuFlatButton5.Click
        Form7.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuFlatButton6.Click
        Form8.Show()
        Me.Hide()

    End Sub

    Private Sub BunifuFlatButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuFlatButton7.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuFlatButton8.Click
        If MsgBox("Are you sure you want to quit?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class