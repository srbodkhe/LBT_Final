Imports System.Data.OleDb
Imports System.Data
Public Class Operator_Lo

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        'Me.Close()
        'OK button  
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\user_info.accdb;Jet OLEDB:Support Complex Data=True"
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM Operator WHERE UserName = '" & UsernameTextBox.Text & "' AND Password = '" & PasswordTextBox.Text & "' ", con)
        con.Open()
        Dim sdr As OleDbDataReader = cmd.ExecuteReader()
        ' If the record can be queried, Pass verification and open another form.  
        If (sdr.Read() = True) Then
            'MessageBox.Show("The user is valid!")

            Dim Operator_Selection As New Operator_Selection
            Operator_Selection.Show()
            con.Close()
            Me.Close()
        Else
            MessageBox.Show("Invalid username or password!")
            con.Close()
        End If
        UsernameTextBox.Clear()
        PasswordTextBox.Clear()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        MAIN.Show()
        Me.Close()

    End Sub

    Private Sub ReSet_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub UsernameLabel_Click(sender As Object, e As EventArgs) Handles UsernameLabel.Click

    End Sub

    Private Sub Operator_Lo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
