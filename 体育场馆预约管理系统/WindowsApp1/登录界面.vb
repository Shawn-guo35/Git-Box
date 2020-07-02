Imports System.Data.SqlClient
Public Class 登录界面
    Dim cn As SqlConnection
    Dim cm As SqlCommand

    Private Sub 登陆界面_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        欢迎界面.Show()
        Timer1.Interval = 1 '1000=1秒
        Timer1.Enabled = True
        Timer2.Interval = 3000 '1000=1秒
        Timer2.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Hide()
        Timer1.Enabled = False
    End Sub


    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.Show()
        Timer2.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        注册界面.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MsgBox("请输入账号！")

        End If
        If TextBox2.Text = "" Then
            MsgBox("请输入密码！")
        End If
        Dim cnStr As String = "Data Source=DESKTOP-DSP6URK\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=changguan;"
        cn = New SqlConnection(cnStr)
        cn.Open()

        If RadioButton1.Checked Then
            cm = New SqlCommand("select count(*) from Users where ID='" + TextBox1.Text + "'and Upassword='" + TextBox2.Text + "'", cn)
            Dim num1 = Convert.ToInt32(cm.ExecuteScalar())
            If (num1 > 0) Then
                cn.Close()
                MessageBox.Show("登录成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
                用户界面.Show()
                Me.Visible = False
            Else
                MessageBox.Show("用户名或密码错误", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        ElseIf RadioButton2.Checked Then
            cm = New SqlCommand("select count(*) from Users where ID='" + TextBox1.Text + "'and Upassword='" + TextBox2.Text + "'", cn)
            Dim num2 = Convert.ToInt32(cm.ExecuteScalar())
            If (num2 > 0) Then
                cn.Close()
                MessageBox.Show("登录成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
                管理员界面.Show()
                Me.Visible = False
            Else
                MessageBox.Show("用户名或密码错误", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Else
            MsgBox("请选择登录类型！")
        End If

    End Sub

End Class