﻿Imports System.Data.OleDb
Imports System.Data

Public Class Operator_Work
    Public Connstring As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\user_info.accdb;Jet OLEDB:Support Complex Data=True"
    Public conn As New OleDbConnection
    Private Sub Save_D_Click(sender As Object, e As EventArgs) Handles Save_D.Click
        Try
            'Dim SqlQuery As String = "INSERT INTO Master_Table(Seller_N,Pro_N,Pro_I,Qut,Price,Tax,Total,Total_Tax,DOE)
            ' VALUES ( '" & SN.Text & "','" & PN.Text & "',' " & PI.Text & "',' " & Val(QN.Text) & "',' " & Val(PR.Text) & "',' " & Val(TX.Text) & "',' " & Val(TT.Text) & "', ' " & Val(TOTAL_T.Text) & "',' " & DateValue(ED.Text) & "')"
            Dim SqlQuery As String = "INSERT INTO Master_Table(Seller_N,Pro_N,Pro_I,Qut,Price,Tax,Total,Total_Tax,DOE) VALUES ( '" & SN.Text & "','" & PN.Text & "',' " & PI.Text & "',' " & Val(QN.Text) & "',' " & Val(PR.Text) & "',' " & Val(TX.Text) & "',' " & TOTAL_T.Text & "', ' " & TT.Text & "',' " & DateValue(ED1.Text) & "')"
            Dim SqlCommand As New OleDbCommand
            With SqlCommand
                .CommandText = SqlQuery
                .Connection = conn
                .ExecuteNonQuery()
                SN.Text = ""
                PN.Text = ""
                PI.Text = ""
                QN.Text = ""
                TX.Text = ""
                TT.Text = ""
                PR.Text = ""
                TOTAL_T.Text = ""
                SN.Focus()

            End With
            MsgBox("Record Save Successfully")
        Catch ex As Exception
            'MsgBox = ("Wrong Data Enter Please Enter Proper Data ")
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SN.Text = ""
        PN.Text = ""
        PI.Text = ""
        QN.Text = ""
        TX.Text = ""
        TT.Text = ""
        PR.Text = ""
        TOTAL_T.Text = ""
        Me.Close()
        Operator_Selection.Show()
    End Sub

    Private Sub Operator_Work_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = Connstring
        If conn.State = ConnectionState.Closed Then
            conn.Open()
            ' MsgBox("Connection Open")
        Else
            MsgBox("Database Connection Closed")

        End If
    End Sub

 
    Private Sub SN_TextChanged(sender As Object, e As EventArgs) Handles SN.TextChanged
       
    End Sub


    Private Sub Calculation_Click(sender As Object, e As EventArgs) Handles Calculation.Click
        Dim Qty As Double = CInt(QN.Text)
        Dim i As Double = 100
        Dim Price As Double = CInt(PR.Text)
        'Dim Tax As Double = CInt(TX.Text)

        Dim T_Tax As Double = (Qty * Price) / i 'LBT Tax Total_T
        Dim Total_amount As Double = (Qty * Price) + T_Tax 'LBT Tax+Amount TT
        TOTAL_T.Text = Total_amount.ToString("C")
        TT.Text = T_Tax.ToString("C")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SN.Clear()
        PN.Clear()
        PI.Clear()
        QN.Clear()
        PR.Clear()
        TX.Clear()
        TOTAL_T.Clear()
        TT.Clear()
        SN.Focus()
    End Sub

    Private Sub TT_TextChanged(sender As Object, e As EventArgs) Handles TT.TextChanged

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles ED1.ValueChanged

    End Sub

    Private Sub TX_TextChanged(sender As Object, e As EventArgs) Handles TX.TextChanged
        If TX.TextLength = 0 Then
            TX.Text = "0"
        End If
        If Not IsNumeric(TX.Text) Then
            MessageBox.Show("Please enter numeric  Values only In LBT Tax/ Textbox")
            Me.TX.Text = ""
        End If
    End Sub

    Private Sub TOTAL_T_TextChanged(sender As Object, e As EventArgs) Handles TOTAL_T.TextChanged

    End Sub

    Private Sub QN_TextChanged(sender As Object, e As EventArgs) Handles QN.TextChanged
        If QN.TextLength = 0 Then
            QN.Text = "0"
        End If
        If Not IsNumeric(QN.Text) Then
            MessageBox.Show("Please enter numeric  Values only In Quantity Textbox")
            Me.QN.Text = ""
        End If
    End Sub

    Private Sub PR_TextChanged(sender As Object, e As EventArgs) Handles PR.TextChanged
        If PR.TextLength = 0 Then
            PR.Text = "0"
        End If
        If Not IsNumeric(PR.Text) Then
            MessageBox.Show("Please enter numeric  Values only In Price Textbox")
            Me.PR.Text = ""
        End If
    End Sub
End Class