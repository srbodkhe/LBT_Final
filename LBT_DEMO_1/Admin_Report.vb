Imports System.Data.OleDb
Imports System.Data
Imports System.Drawing.Printing


Public Class Admin_Report
    Dim mRow As Integer = 0
    Dim newpage As Boolean = True
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\user_info.accdb;Jet OLEDB:Support Complex Data=True")
    Dim cmd As OleDbCommand
    Dim da As OleDbDataAdapter
    Dim ds As New DataSet
    Dim id As Integer
    Public Connstring As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\user_info.accdb;Jet OLEDB:Support Complex Data=True"

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        da = New OleDbDataAdapter("select max(ID) from Master_Table", con)
        Dim dt As New DataTable()
        da.Fill(dt)
        TextBox19.Text = Convert.ToString(Int32.Parse(dt.Rows(0)(0).ToString()) + 1)
        'TextBox1.Text = ""
        ' TextBox2.Text = ""
        ' TextBox3.Text = ""
        ' TextBox4.Text = ""
        ' TextBox5.Text = ""
        ' TextBox12.Text = ""
        ' TextBox17.Text = ""
        ' TextBox18.Text = ""
        ' TextBox1.Focus()
    End Sub

    Private Sub TextBox18_TextChanged(sender As Object, e As EventArgs) Handles TextBox18.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If con.State.ToString() = "Open" Then con.Close()
        con.Open()

        If String.IsNullOrEmpty(TextBox19.Text) Then
            MessageBox.Show("Please Click on New Button:")
            Return
        End If

        If String.IsNullOrEmpty(TextBox1.Text) Then
            MessageBox.Show("Please Enter Seller Name:")
            Return
        End If
        If String.IsNullOrEmpty(TextBox2.Text) Then
            MessageBox.Show("Please Enter Product Name:")
            Return
        End If
        If String.IsNullOrEmpty(TextBox3.Text) Then
            MessageBox.Show("Please Enter Product ID  Name:")
            Return
        End If
        If String.IsNullOrEmpty(TextBox4.Text) Then
            MessageBox.Show("Please Enter Quantity ")
            Return
        End If
        If String.IsNullOrEmpty(TextBox5.Text) Then
            MessageBox.Show("Please Enter Price of Product:")
            Return
        End If
        If String.IsNullOrEmpty(TextBox12.Text) Then
            MessageBox.Show("Please Enter Tax:")
            Return
        End If
        If String.IsNullOrEmpty(TextBox17.Text) Then
            MessageBox.Show("Please Click on Calculate Tax Button:")
            Return
        End If
        If String.IsNullOrEmpty(TextBox18.Text) Then
            MessageBox.Show("Please Click on Calculate Tax Button:")
            Return
        End If

        Try
            Dim SqlQuery As String = "INSERT INTO Master_Table(Seller_N,Pro_N,Pro_I,Qut,Price,Tax,Total,Total_Tax,DOE) VALUES ( '" & TextBox1.Text & "','" & TextBox2.Text & "',' " & TextBox3.Text & "',' " & Val(TextBox4.Text) & "',' " & Val(TextBox5.Text) & "',' " & Val(TextBox12.Text) & "',' " & TextBox17.Text & "', ' " & TextBox18.Text & "',' " & DateValue(DateTimePicker1.Text) & "')"
            Dim SqlCommand As New OleDbCommand
            With SqlCommand
                .CommandText = SqlQuery
                .Connection = con
                .ExecuteNonQuery()
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
                TextBox12.Text = ""
                TextBox17.Text = ""
                TextBox18.Text = ""
                TextBox19.Text = ""
                TextBox1.Focus()
            End With
            MsgBox("Record Save Successfully")
        Catch ex As Exception
            'MsgBox = ("Wrong Data Enter Please Enter Proper Data ")
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Qty As Double = CInt(TextBox4.Text)
        Dim i As Double = 100
        Dim Price As Double = CInt(TextBox5.Text)
        Dim T_Tax As Double = (Qty * Price) / i 'LBT Tax Total_T
        Dim Total_amount As Double = (Qty * Price) + T_Tax 'LBT Tax+Amount TT
        TextBox17.Text = Total_amount.ToString("C")
        TextBox18.Text = T_Tax.ToString("C")
    End Sub

    Private Sub Admin_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If con.State.ToString() = "Open" Then con.Close()
        con.Open()
        da = New OleDbDataAdapter("select ID from Master_Table", con)
        Dim dt As New DataTable()
        da.Fill(dt)
        ComboBox1.DataSource = dt
        ComboBox1.DisplayMember = "ID"
        con.Close()
        'for printing code
        Dim dt1 As New DataTable
        DataGridView1.DataSource = dt1
    End Sub
    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        If TextBox5.TextLength = 0 Then
            TextBox5.Text = "0"
        End If
        If Not IsNumeric(TextBox5.Text) Then
            MessageBox.Show("Please enter Numeric  Values only In Price Textbox")
            Me.TextBox5.Text = ""
        End If
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles btUpdate.Click
        'con.Open()
        cmd = New OleDbCommand("update Master_Table set Seller_N= '" & TextBox24.Text & "',Pro_N= '" & TextBox23.Text & "',Pro_I= '" & TextBox22.Text & "',Qut= '" & TextBox21.Text & "',Price= '" & TextBox20.Text & "',Tax= '" & TextBox16.Text & "',Total= '" & TextBox15.Text & "',Total_Tax= '" & TextBox14.Text & "' where ID= " & ComboBox1.Text & "", con)
        cmd.ExecuteNonQuery()
        con.Close()
        TextBox24.Text = ""
        TextBox23.Text = ""
        TextBox22.Text = ""
        TextBox21.Text = ""
        TextBox20.Text = ""
        TextBox20.Text = ""
        TextBox16.Text = ""
        TextBox15.Text = ""
        TextBox14.Text = ""

        MsgBox("Records Save Successfuly")
        con.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If con.State.ToString() = "Open" Then con.Close()
        con.Open()
        Try
            da = New OleDbDataAdapter("select * from Master_Table where ID =" & ComboBox1.Text & "", con)
            Dim dt As New DataTable()
            da.Fill(dt)
            TextBox24.Text = dt.Rows(0)(1).ToString()
            TextBox23.Text = dt.Rows(0)(2).ToString()
            TextBox22.Text = dt.Rows(0)(3).ToString()
            TextBox21.Text = dt.Rows(0)(4).ToString()
            TextBox20.Text = dt.Rows(0)(5).ToString()
            TextBox16.Text = dt.Rows(0)(6).ToString()
            TextBox15.Text = dt.Rows(0)(7).ToString()
            TextBox14.Text = dt.Rows(0)(8).ToString()
        Catch ex As Exception
            'MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If TextBox21.TextLength = 0 Then
            TextBox21.Text = "0"
        End If
        If Not IsNumeric(TextBox21.Text) Then
            MessageBox.Show("Please enter Numeric  Values only In Quantity Textbox")
            Me.TextBox21.Text = ""
        End If
        If TextBox20.TextLength = 0 Then
            TextBox20.Text = "0"
        End If
        If Not IsNumeric(TextBox20.Text) Then
            MessageBox.Show("Please enter Numeric  Values only In Price Textbox")
            Me.TextBox20.Text = ""
        End If
        If TextBox16.TextLength = 0 Then
            TextBox16.Text = "0"
        End If
        If Not IsNumeric(TextBox16.Text) Then
            MessageBox.Show("Please enter Numeric  Values only In LBT Tax/Product Textbox")
            Me.TextBox16.Text = ""
        End If
        Try
            Dim Q As Double = CInt(TextBox21.Text)
            Dim i As Double = 100
            Dim Price1 As Double = CInt(TextBox20.Text)
            Dim T_Tax1 As Double = (Q * Price1) / i 'LBT Tax Total_T
            Dim Total_amount1 As Double = (Q * Price1) + T_Tax1 'LBT Tax+Amount TT
            TextBox15.Text = Total_amount1.ToString("C")
            TextBox14.Text = T_Tax1.ToString("C")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox12.Text = ""
        TextBox17.Text = ""
        TextBox18.Text = ""

        TextBox1.Focus()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Close()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox12.Text = ""
        TextBox17.Text = ""
        TextBox18.Text = ""
        MAIN.Show()

    End Sub

    Private Sub Button_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        'Me.Close()

        TextBox24.Text = ""
        TextBox23.Text = ""
        TextBox22.Text = ""
        TextBox21.Text = ""
        TextBox20.Text = ""
        TextBox20.Text = ""
        TextBox16.Text = ""
        TextBox15.Text = ""
        TextBox14.Text = ""
        'TabPage1.Show()
        TabPage1.Focus()


    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox24.Text = ""
        TextBox23.Text = ""
        TextBox22.Text = ""
        TextBox21.Text = ""
        TextBox20.Text = ""
        TextBox20.Text = ""
        TextBox16.Text = ""
        TextBox15.Text = ""
        TextBox14.Text = ""
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        'Me.Close()
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox13.Text = ""
        TextBox25.Text = ""
        TextBox26.Text = ""
        TextBox27.Text = ""
        TabPage1.Show()

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox13.Text = ""
        TextBox25.Text = ""
        TextBox26.Text = ""
        TextBox27.Text = ""
    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            If TextBox27.Text = Nothing Then
                MsgBox("Please Enter Transaction ID In "" Transaction ID ""Text Box")
            Else
                id = Convert.ToInt32(TextBox27.Text)
                da = New OleDbDataAdapter("SELECT * FROM Master_Table WHERE ID=" & id & "", con)
                ds = New DataSet
                da.Fill(ds, "Master_table")
                ShowTable1(0)
            End If
        Catch ex As Exception
            MsgBox("Record not found")
        End Try
    End Sub
    Public Sub ShowTable1(ByRef i As Integer)
        TextBox6.Text = ds.Tables("Master_Table")(i)(1).ToString()
        TextBox7.Text = ds.Tables("Master_Table")(i)(2).ToString()
        TextBox8.Text = ds.Tables("Master_Table")(i)(3).ToString()
        TextBox9.Text = ds.Tables("Master_Table")(i)(4).ToString()
        TextBox10.Text = ds.Tables("Master_Table")(i)(5).ToString()
        TextBox13.Text = ds.Tables("Master_Table")(i)(6).ToString()
        TextBox25.Text = ds.Tables("Master_Table")(i)(7).ToString()
        TextBox26.Text = ds.Tables("Master_Table")(i)(8).ToString()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            If TextBox11.Text <> "" Then
                If con.State.ToString() = "Open" Then con.Close()
                con.Open()
                cmd = New OleDbCommand("DELETE FROM Master_Table WHERE ID=" & Convert.ToInt32(TextBox11.Text) & "", con)
                cmd.ExecuteNonQuery()
                MsgBox(" Record Details are Deleted ")
                da = New OleDbDataAdapter("SELECT * FROM Master_Table", con)
                ds = New DataSet
                da.Fill(ds, "Master_Table")
                TextBox11.Text = ""
                If (ds.Tables("Master_Table").Rows.Count > 0) Then
                    id = 0
                    ShowTable1(id)
                End If
            End If
        Catch ex As Exception
            MsgBox("record information is not found ")

        End Try
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        TextBox11.Text = ""
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        'Me.Close()
        TextBox11.Text = ""
        TabPage1.Show()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Dim ds As New DataSet
        Using da As New OleDb.OleDbDataAdapter _
            ("SELECT * FROM Master_Table WHERE (DOE > ?) AND (DOE < ?)", "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\user_info.accdb")
            da.SelectCommand.Parameters.AddWithValue("?", CDate(DateTimePicker3.Text))
            da.SelectCommand.Parameters.AddWithValue("?", CDate(DateTimePicker4.Text))
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
        End Using
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        'Me.Close()
        TabPage1.Show()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub


    Private Sub Button19_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        With DataGridView1
            Dim fmt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
            fmt.LineAlignment = StringAlignment.Center
            fmt.Trimming = StringTrimming.EllipsisCharacter
            Dim y As Single = e.MarginBounds.Top
            Do While mRow < .RowCount
                Dim row As DataGridViewRow = .Rows(mRow)
                Dim x As Single = e.MarginBounds.Left
                Dim h As Single = 0
                For Each cell As DataGridViewCell In row.Cells
                    Dim rc As RectangleF = New RectangleF(x, y, cell.Size.Width, cell.Size.Height)

                    e.Graphics.DrawRectangle(Pens.Black, rc.Left, rc.Top, rc.Width, rc.Height)

                    If (newpage) Then

                        e.Graphics.DrawString(DataGridView1.Columns(cell.ColumnIndex).HeaderText, .Font, Brushes.Black, rc, fmt)

                    Else
                        e.Graphics.DrawString(DataGridView1.Rows(cell.RowIndex).Cells(cell.ColumnIndex).FormattedValue.ToString(), .Font, Brushes.Black, rc, fmt)
                    End If
                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                Next

                newpage = False
                y += h
                mRow += 1
                If y + h > e.MarginBounds.Bottom Then
                    e.HasMorePages = True
                    mRow -= 1
                    newpage = True
                    Exit Sub
                End If
            Loop
            mRow = 0
        End With
    End Sub
End Class