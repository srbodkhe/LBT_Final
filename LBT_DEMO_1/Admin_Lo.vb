Imports System.Data.OleDb
Imports System.Data
Public Class Admin_Lo

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        'Me.Close()
        'OK button  
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\user_info.accdb;Jet OLEDB:Support Complex Data=True"
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM UserList WHERE UserName = '" & UsernameTextBox.Text & "' AND Password = '" & PasswordTextBox.Text & "' ", con)
        con.Open()
        Dim sdr As OleDbDataReader = cmd.ExecuteReader()
        ' If the record can be queried, Pass verification and open another form.  
        If (sdr.Read() = True) Then
            'MessageBox.Show("The user is valid!")
            'Dim Admin_Area As New Admin_Area
            'Admin_Area.Show()
            Dim Admin_Report As New Admin_Report
            Admin_Report.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid username or password!")

        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
        MAIN.Show()
    End Sub

    Private Sub UsernameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsernameTextBox.TextChanged

    End Sub

    Private Sub PasswordTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasswordTextBox.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UsernameTextBox.Clear()
        PasswordTextBox.Clear()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Admin_Lo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
