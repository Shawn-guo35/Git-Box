Imports System.ComponentModel
Imports System.Data.OleDb
Public Class 用户订单查询
    Dim con As New OleDbConnection
    Dim ads As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim com As New OleDbCommand
    Public ID As String = 登录界面.txtID.Text
    Public data As DateTime
    Public data2 As DateTime
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = str
        '此处缺少将登录页面所输入的ID传递给此页面的字符串变量ID的语句
    End Sub

    Private Sub btnSubmit3_Click_1(sender As Object, e As EventArgs) Handles btnSubmit3.Click
        data = dtpTime.Value.Date.ToShortDateString
        data2 = data.AddDays(1)
        ds.Clear()

        '地点空
        If (cbmGym.Text = "") Then
            com.CommandText = "select Vname,Vno,Stime,Etime,LTime,Fee,Orderno,Remark from Orders where ID='" & ID & "'and Stime >= '" & data & "'and Stime <= '" & data2 & "'  "
            com.Connection = con
            ads.SelectCommand = com
            ads.Fill(ds, "Stable")
            Me.gvwOrders.DataSource = ds.Tables(0)
        End If
        '地点不空
        If (cbmGym.Text <> "") Then
            com.CommandText = "select Vname,Vno,Stime,Etime,LTime,Fee,Orderno,Remark from Orders where ID='" & ID & "'and convert(varchar(10),Stime,120) = '" & data & "'and Vname = '" & cbmGym.Text & "'"
            com.Connection = con
            ads.SelectCommand = com
            ads.Fill(ds, "Stable")
            Me.gvwOrders.DataSource = ds.Tables(0)
        End If

    End Sub

    Private Sub btnSubmit1_Click(sender As Object, e As EventArgs) Handles btnSubmit1.Click
        ds.Clear()
        com.CommandText = "select Vname,Vno,Stime,Etime,LTime,Fee,Orderno,Remark from Orders where ID='" & ID & "'"
        com.Connection = con
        ads.SelectCommand = com
        ads.Fill(ds, "Stable")
        Me.gvwOrders.DataSource = ds.Tables(0)
    End Sub
End Class
