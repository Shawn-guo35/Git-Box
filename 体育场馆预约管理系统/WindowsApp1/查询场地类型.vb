Public Class 查询场地类型
    Private Sub 查询场地类型_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“ChangguanDataSet3.Vtype”中。您可以根据需要移动或删除它。
        Me.VtypeTableAdapter.Fill(Me.ChangguanDataSet3.Vtype)

    End Sub

    Private Sub btnSubmit4_Click(sender As Object, e As EventArgs) Handles btnSubmit4.Click
        Dim s As String
        If txtCondition.Text = "" Then
            MsgBox("请输入查询条件", MsgBoxStyle.Exclamation, "警告")
            Exit Sub
        End If
        Select Case cbmGym.SelectedItem
            Case "场地名称"
                ChangguanDataSet1.Tables("Vtype").Clear()
                s = "select  *  from  Vtype  where  Vname ='" + txtCondition.Text + "'"
                SqlDataAdapter1.SelectCommand.CommandText = s
                SqlDataAdapter1.Fill(ChangguanDataSet1)
                gvwVtype.DataSource = ChangguanDataSet1.Tables("Vtype")

        End Select
    End Sub

    Private Sub btnSubmit2_Click(sender As Object, e As EventArgs) Handles btnSubmit2.Click
        SqlDataAdapter1.Update(ChangguanDataSet1)
        MsgBox("数据已修改", MsgBoxStyle.Information, "恭喜")
    End Sub

    Private Sub btnSubmit3_Click(sender As Object, e As EventArgs) Handles btnSubmit3.Click
        Dim x As Integer
        If MsgBox("您真的删除该条数据吗？", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "删除数据") = DialogResult.Yes Then
            x = gvwVtype.CurrentRow.Index()
            ChangguanDataSet1.Tables("Vtype").Rows(x).Delete()
            SqlDataAdapter1.Update(ChangguanDataSet1)
            MsgBox("删除成功", MsgBoxStyle.Information, "恭喜")
        End If
    End Sub

    Private Sub btnSubmit5_Click(sender As Object, e As EventArgs) Handles btnSubmit5.Click
        Me.Close()
    End Sub

End Class