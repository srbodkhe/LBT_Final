
Public Class MAIN

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Admin.Click
    ' back.Show()
    ' Admin_Lo.Show()
    ' Me.Hide()
    ' End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Dispose() 'Close all Form from Primery Memory
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub MAIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Opeartor_Click(sender As Object, e As EventArgs) Handles Operator_B.Click
        Operator_Lo.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Admin_Click(sender As Object, e As EventArgs) Handles Admin.Click
        Me.Hide()
        Admin_Lo.Show()

    End Sub
End Class
