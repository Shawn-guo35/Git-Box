Public Class 添加场地类型
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()
    End Sub

    Private Sub btnInsertVenue_Click(sender As Object, e As EventArgs) Handles btnInsertVenue.Click
        Dim s, n As String
        Dim r As Integer    '查询出的行数
        If txtGymName.Text = "" Then
            MsgBox("场地名称不能为空", MsgBoxStyle.Exclamation, "警告")
            txtGymName.Focus()
            Exit Sub
        End If
        Try
            ChangguanDataSet1.Tables("Vtype").Clear()
            n = "select  *  from Vtype where  Vname ='" + txtGymName.Text.Trim + "'"
            SqlDataAdapter1.SelectCommand.CommandText = n
            SqlDataAdapter1.Fill(ChangguanDataSet1)
            r = ChangguanDataSet1.Vtype.Rows.Count
            If r <> 0 Then
                MsgBox("该场地名称已存在，请重新输入", MsgBoxStyle.Exclamation, "警告")
                txtGymName.Text = ""
                txtGymName.Focus()
                txtGymInrent.Text = ""
                txtGymOutrent.Text = ""
                txtGymAddress.Text = ""
            Else
                s = "insert into Vtype values('" + txtGymName.Text + "','" + txtGymInrent.Text + "','" + txtGymOutrent.Text + "','" + txtGymAddress.Text + "')"
                SqlDataAdapter1.SelectCommand.CommandText = s
                SqlDataAdapter1.Fill(ChangguanDataSet1)
                MsgBox("添加成功", MsgBoxStyle.Information, "恭喜")
                txtGymName.Text = ""
                txtGymName.Focus()
                txtGymInrent.Text = ""
                txtGymOutrent.Text = ""
                txtGymAddress.Text = ""
            End If
        Catch ex As Exception
            MsgBox("请输入正确信息", MsgBoxStyle.Exclamation, "警告")
        End Try

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtGymName.Text = ""
        txtGymInrent.Text = ""
        txtGymOutrent.Text = ""
        txtGymAddress.Text = ""
        txtGymName.Focus()
    End Sub

    Private Sub 添加场地类型_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class