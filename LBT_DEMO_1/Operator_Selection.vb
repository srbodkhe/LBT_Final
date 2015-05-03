Public Class Operator_Selection

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Operator_Work As New Operator_Work
        Operator_Work.Show()
        Me.Hide()

    End Sub

    Private Sub Operator_Selection_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DATA_View.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        MAIN.Show()

    End Sub
End Class