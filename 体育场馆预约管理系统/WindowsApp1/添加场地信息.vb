Public Class 添加场地信息
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtGymName.Text = ""
        txtGymNum.Text = ""
        txtGymName.Focus()
    End Sub

    Private Sub btnInsertVtype_Click(sender As Object, e As EventArgs) Handles btnInsertVtype.Click
        Dim s, n As String
        Dim r As Integer    '查询出的行数
        If txtGymName.Text = "" Then
            MsgBox("场地名称不能为空", MsgBoxStyle.Exclamation, "警告")
            txtGymName.Focus()
            Exit Sub
        End If
        If txtGymNum.Text = "" Then
            MsgBox("场地编号不能为空", MsgBoxStyle.Exclamation, "警告")
            txtGymNum.Focus()
            Exit Sub
        End If
        Try
            ChangguanDataSet1.Tables("Venue").Clear()
            n = "select  *  from Venue where  Vno ='" + txtGymNum.Text.Trim + "'and Vname ='" + txtGymName.Text.Trim + "'"
            SqlDataAdapter1.SelectCommand.CommandText = n
            SqlDataAdapter1.Fill(ChangguanDataSet1)
            r = ChangguanDataSet1.Venue.Rows.Count
            If r <> 0 Then
                MsgBox("该场地已存在，请重新输入", MsgBoxStyle.Exclamation, "警告")
                txtGymName.Text = ""
                txtGymName.Focus()
                txtGymNum.Text = ""
            Else
                s = "insert into Venue values('" + txtGymName.Text + "','" + txtGymNum.Text + "')"
                SqlDataAdapter1.SelectCommand.CommandText = s
                SqlDataAdapter1.Fill(ChangguanDataSet1)
                MsgBox("添加成功", MsgBoxStyle.Information, "恭喜")
                txtGymName.Text = ""
                txtGymName.Focus()
                txtGymNum.Text = ""

            End If
        Catch ex As Exception
            MsgBox("请输入正确信息", MsgBoxStyle.Exclamation, "警告")
        End Try
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()
    End Sub

    Private Sub 添加场地信息_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class