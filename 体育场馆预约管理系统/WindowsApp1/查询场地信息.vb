Public Class 查询场地信息



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim s As String
        If TextBox1.Text = "" Then
            MsgBox("请输入查询条件", MsgBoxStyle.Exclamation, "警告")
            Exit Sub
        End If
        Select Case ComboBox1.SelectedItem
            Case "场地名称"
                ChangguanDataSet1.Tables("Venue").Clear()
                s = "select  *  from  Venue  where  Vname ='" + TextBox1.Text + "'"
                SqlDataAdapter1.SelectCommand.CommandText = s
                SqlDataAdapter1.Fill(ChangguanDataSet1)
                DataGridView1.DataSource = ChangguanDataSet1.Tables("Venue")
                'Case "场地编号"
                '    DataDataSet.Tables("Venue").Clear()
                '    s = "select  *  from  Venue  where  Vno ='" + TextBox1.Text + "'"
                '    SqlDataAdapter1.SelectCommand.CommandText = s
                '    SqlDataAdapter1.Fill(DataDataSet)
                '    DataGridView1.DataSource = DataDataSet.Tables("Venue")

        End Select
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim x As Integer
        If MsgBox("您真的删除该条数据吗？", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "删除数据") = DialogResult.Yes Then
            x = DataGridView1.CurrentRow.Index()
            ChangguanDataSet1.Tables("Venue").Rows(x).Delete()
            SqlDataAdapter1.Update(ChangguanDataSet1)
            MsgBox("删除成功", MsgBoxStyle.Information, "恭喜")
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub 查询场地信息_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“ChangguanDataSet5.Venue”中。您可以根据需要移动或删除它。
        Me.VenueTableAdapter.Fill(Me.ChangguanDataSet5.Venue)

    End Sub
End Class