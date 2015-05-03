Imports System.Data.OleDb
Imports System.Data

Public Class DATA_View

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        
    End Sub

    Private Sub PrintPreviewControl1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DATA_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'User_infoDataSet.Master_Table' table. You can move, or remove it, as needed.
        Me.Master_TableTableAdapter.Fill(Me.User_infoDataSet.Master_Table)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ds As New DataSet
        Using da As New OleDb.OleDbDataAdapter _
            ("SELECT * FROM Master_Table WHERE (DOE > ?) AND (DOE < ?)", "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\user_info.accdb")
            da.SelectCommand.Parameters.AddWithValue("?", CDate(DateTimePicker1.Text))
            da.SelectCommand.Parameters.AddWithValue("?", CDate(DateTimePicker2.Text))
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
        End Using
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Operator_Selection.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DateTimePicker1_ValueChanged_1(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub DataGridView1_CellContentClick_2(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class