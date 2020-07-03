Imports System.ComponentModel
Imports System.Data.OleDb
Public Class 修改密码
    Dim con As New OleDbConnection
    Dim ads As New OleDbDataAdapter
    Dim ds As New DataSet
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If txtOldPwd.Text = "" Then
            MsgBox("请输入旧密码",, "系统提示")
            Exit Sub
        End If
        If txtNewPwd.Text = "" Then
            MsgBox("新密码不得为空",, "系统提示")
            Exit Sub
        End If
        If txtNewPwd.Text <> txtNewPwd1.Text Then
            MsgBox("新密码不一致，请重新输入",, "系统提示")
            Exit Sub
        End If
        Dim com As New OleDbCommand
        com.CommandText = "select Upassword from Users where ID='" & 登录界面.txtID.Text & "'"
        com.Connection = con
        ads.SelectCommand = com
        ads.Fill(ds, "Stable")
        If (txtOldPwd.Text <> ds.Tables("Stable").Rows(0).Item("Upassword")) Then
            MsgBox("密码不正确", , "系统提示")
            Exit Sub
        End If
        com.CommandText = "update Users set Upassword= '" & txtNewPwd.Text & "' where ID='" & 登录界面.txtID.Text & "'"
        con.Open()
        com.ExecuteNonQuery()
        con.Close()
        MsgBox("修改完成", , "系统提示")
        Me.Hide()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = str
    End Sub


End Class