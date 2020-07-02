Public Class 添加场地类型
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim s, n As String
        Dim r As Integer
        If TextBox1.Text = "" Then
            MsgBox("场地名称不能为空", MsgBoxStyle.Exclamation, "警告")
            TextBox1.Focus()
            Exit Sub
        End If
        Try
            ChangguanDataSet1.Tables("Vtype").Clear()
            n = "select  *  from Vtype where  Vname ='" + TextBox1.Text.Trim + "'"
            SqlDataAdapter1.SelectCommand.CommandText = n
            SqlDataAdapter1.Fill(ChangguanDataSet1)
            r = ChangguanDataSet1.Vtype.Rows.Count
            If r <> 0 Then
                MsgBox("该场地名称已存在，请重新输入", MsgBoxStyle.Exclamation, "警告")
                TextBox1.Text = ""
                TextBox1.Focus()
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
            Else
                s = "insert into Vtype values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')"
                SqlDataAdapter1.SelectCommand.CommandText = s
                SqlDataAdapter1.Fill(ChangguanDataSet1)
                MsgBox("添加成功", MsgBoxStyle.Information, "恭喜")
                TextBox1.Text = ""
                TextBox1.Focus()
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
            End If
        Catch ex As Exception
            MsgBox("请输入正确信息", MsgBoxStyle.Exclamation, "警告")
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub 添加场地类型_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class