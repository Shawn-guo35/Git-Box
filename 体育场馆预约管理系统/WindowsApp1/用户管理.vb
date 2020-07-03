Public Class 用户管理
    Inherits System.Windows.Forms.Form



    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub


    Private Sub gvwUsers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub gvwUsers_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles gvwUsers.CellContentClick

    End Sub

    Private Sub 用户管理系统_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“ChangguanDataSet1.Users”中。您可以根据需要移动或删除它。
        Me.UsersTableAdapter.Fill(Me.ChangguanDataSet1.Users)



    End Sub

    Private Sub btnSubmit2_Click(sender As Object, e As EventArgs) Handles btnSubmit2.Click
        SqlDataAdapter1.Update(ChangguanDataSet)
        MsgBox("数据已修改", MsgBoxStyle.Information, "恭喜")
    End Sub

    Private Sub btnSubmit3_Click(sender As Object, e As EventArgs) Handles btnSubmit3.Click
        Dim x As Integer
        If MsgBox("您真的删除该条数据吗？", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "删除数据") = DialogResult.Yes Then
            x = gvwUsers.CurrentRow.Index()
            ChangguanDataSet.Tables("Users").Rows(x).Delete()
            SqlDataAdapter1.Update(ChangguanDataSet)
            MsgBox("删除成功", MsgBoxStyle.Information, "恭喜")
        End If
    End Sub

    Private Sub cbmGym_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbmGym.SelectedIndexChanged

    End Sub

    Private Sub btnSubmit4_Click(sender As Object, e As EventArgs) Handles btnSubmit4.Click
        Dim s As String
        If txtCondition.Text = "" Then
            MsgBox("请输入查询条件", MsgBoxStyle.Exclamation, "警告")
            Exit Sub
        End If
        Select Case cbmGym.SelectedItem
            Case "帐号"
                ChangguanDataSet.Tables("Users").Clear()
                s = "select  *  from  Users  where  ID ='" + txtCondition.Text + "'"
                SqlDataAdapter1.SelectCommand.CommandText = s
                SqlDataAdapter1.Fill(ChangguanDataSet)
                gvwUsers.DataSource = ChangguanDataSet.Tables("Users")
            Case "姓名"
                ChangguanDataSet.Tables("Users").Clear()
                s = "select  *  from  Users  where  Uname = '" + txtCondition.Text + "'"
                SqlDataAdapter1.SelectCommand.CommandText = s
                SqlDataAdapter1.Fill(ChangguanDataSet)
                gvwUsers.DataSource = ChangguanDataSet.Tables("Users")
            Case "身份"
                ChangguanDataSet.Tables("Users").Clear()
                s = "select  *  from  Users  where Uidentity = '" + txtCondition.Text + "'"
                SqlDataAdapter1.SelectCommand.CommandText = s
                SqlDataAdapter1.Fill(ChangguanDataSet)
                gvwUsers.DataSource = ChangguanDataSet.Tables("Users")
        End Select
    End Sub



    Private Sub SqlDataAdapter1_RowUpdated(sender As Object, e As SqlClient.SqlRowUpdatedEventArgs)

    End Sub

    Private Sub btnSubmit5_Click(sender As Object, e As EventArgs) Handles btnSubmit5.Click
        Me.Close()
    End Sub

    Private Sub SqlDataAdapter1_RowUpdated_1(sender As Object, e As SqlClient.SqlRowUpdatedEventArgs)

    End Sub

    Private Sub Users1BindingSource_CurrentChanged(sender As Object, e As EventArgs)

    End Sub
End Class

