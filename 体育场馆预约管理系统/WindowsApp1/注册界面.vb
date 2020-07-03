Imports System.Data.SqlClient
Public Class 注册界面
    Dim cn As SqlConnection
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim cm As SqlCommand
    Dim sqlstr As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()
        登录界面.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If txtID.Text = "" Then
            MsgBox("请输入账号！")
        End If
        If txtPwd.Text = "" Then
            MsgBox("请输入密码！")
        End If
        If txtCpwd.Text = "" Then
            MsgBox("请再次输入密码！")
        End If
        If txtPwd.Text = "" Then
            MsgBox("请输入姓名！")
        End If
        If txtPwd.Text <> txtCpwd.Text Then
            MsgBox("两次输入密码不一致")
        End If
        Dim cnStr As String = "Data Source=DESKTOP-DSP6URK\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=changguan"
        cn = New SqlConnection(cnStr)
        cn.Open()
        If (radInside.Checked) Then
            cm = New SqlCommand("select count(*) from Users where ID='" + txtID.Text + "'", cn)
            Dim num1 = Convert.ToInt32(cm.ExecuteScalar())
            If (num1 = 0) Then

                sqlstr = "insert into  Users values('" + txtID.Text + "','" + txtName.Text + "','" + “校内人员" + "','" + txtPwd.Text + "')"
                cm = New SqlCommand(sqlstr, cn)
                cm.ExecuteNonQuery()
                cn.Close()
                MessageBox.Show("注册成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
                登录界面.Show()
                Me.Visible = False
            Else
                MessageBox.Show("该账户已存在", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        ElseIf (radOutside.Checked) Then
            cm = New SqlCommand("select count(*) from Users where ID='" + txtID.Text + "'", cn)
            Dim num2 = Convert.ToInt32(cm.ExecuteScalar())
            If (num2 = 0) Then

                sqlstr = "insert into  Users values('" + txtID.Text + "','" + txtName.Text + "','" + "校外人员" + "','" + txtPwd.Text + "')"
                cm = New SqlCommand(sqlstr, cn)
                cm.ExecuteNonQuery()
                cn.Close()
                MessageBox.Show("注册成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
                登录界面.Show()
                Me.Visible = False
            Else
                MessageBox.Show("该账户已存在", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Else
            MsgBox("请选择身份！")
        End If

    End Sub

    Private Sub 注册界面_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles radOutside.CheckedChanged

        Label6.Text = "(手机号码注册)"

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles radInside.CheckedChanged
        Label6.Text = "(学号/工号注册)"
    End Sub
End Class