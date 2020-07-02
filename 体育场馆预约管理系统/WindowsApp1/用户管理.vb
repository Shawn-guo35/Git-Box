Public Class 用户管理
    Inherits System.Windows.Forms.Form



    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub 用户管理系统_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“ChangguanDataSet1.Users”中。您可以根据需要移动或删除它。
        Me.UsersTableAdapter.Fill(Me.ChangguanDataSet1.Users)



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SqlDataAdapter1.Update(ChangguanDataSet)
        MsgBox("数据已修改", MsgBoxStyle.Information, "恭喜")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim x As Integer
        If MsgBox("您真的删除该条数据吗？", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "删除数据") = DialogResult.Yes Then
            x = DataGridView1.CurrentRow.Index()
            ChangguanDataSet.Tables("Users").Rows(x).Delete()
            SqlDataAdapter1.Update(ChangguanDataSet)
            MsgBox("删除成功", MsgBoxStyle.Information, "恭喜")
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim s As String
        If TextBox1.Text = "" Then
            MsgBox("请输入查询条件", MsgBoxStyle.Exclamation, "警告")
            Exit Sub
        End If
        Select Case ComboBox1.SelectedItem
            Case "帐号"
                ChangguanDataSet.Tables("Users").Clear()
                s = "select  *  from  Users  where  ID ='" + TextBox1.Text + "'"
                SqlDataAdapter1.SelectCommand.CommandText = s
                SqlDataAdapter1.Fill(ChangguanDataSet)
                DataGridView1.DataSource = ChangguanDataSet.Tables("Users")
            Case "姓名"
                ChangguanDataSet.Tables("Users").Clear()
                s = "select  *  from  Users  where  Uname = '" + TextBox1.Text + "'"
                SqlDataAdapter1.SelectCommand.CommandText = s
                SqlDataAdapter1.Fill(ChangguanDataSet)
                DataGridView1.DataSource = ChangguanDataSet.Tables("Users")
            Case "身份"
                ChangguanDataSet.Tables("Users").Clear()
                s = "select  *  from  Users  where Uidentity = '" + TextBox1.Text + "'"
                SqlDataAdapter1.SelectCommand.CommandText = s
                SqlDataAdapter1.Fill(ChangguanDataSet)
                DataGridView1.DataSource = ChangguanDataSet.Tables("Users")
        End Select
    End Sub



    Private Sub SqlDataAdapter1_RowUpdated(sender As Object, e As SqlClient.SqlRowUpdatedEventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub SqlDataAdapter1_RowUpdated_1(sender As Object, e As SqlClient.SqlRowUpdatedEventArgs)

    End Sub

    Private Sub Users1BindingSource_CurrentChanged(sender As Object, e As EventArgs)

    End Sub
End Class

