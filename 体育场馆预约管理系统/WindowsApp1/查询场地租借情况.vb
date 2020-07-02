Public Class 查询场地租借情况
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub 场地管理系统_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“ChangguanDataSet6.Lease”中。您可以根据需要移动或删除它。
        Me.LeaseTableAdapter.Fill(Me.ChangguanDataSet6.Lease)

    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim s As String

        If TextBox1.Text = "" Then
            MsgBox("请输入查询条件", MsgBoxStyle.Exclamation, "警告")
            Exit Sub
        End If
        Select Case ComboBox1.SelectedItem
            Case "场地名称"
                ChangguanDataSet1.Tables("Lease").Clear()
                s = "select  *  from  Lease  where  Vname ='" + TextBox1.Text + "'"
                SqlDataAdapter1.SelectCommand.CommandText = s
                SqlDataAdapter1.Fill(ChangguanDataSet1)
                DataGridView1.DataSource = ChangguanDataSet1.Tables("Lease")
            Case "场地名称&场地编号"
                ChangguanDataSet1.Tables("Lease").Clear()
                s = "select  *  from Lease where  Vno ='" + TextBox2.Text.Trim + "'and Vname ='" + TextBox1.Text.Trim + "'"


                SqlDataAdapter1.SelectCommand.CommandText = s
                SqlDataAdapter1.Fill(ChangguanDataSet1)
                DataGridView1.DataSource = ChangguanDataSet1.Tables("Lease")
        End Select
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub



    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "场地名称&场地编号" Then TextBox2.Visible = True Else TextBox2.Visible = False

        If ComboBox1.SelectedItem = "场地名称&场地编号" Then Label4.Visible = True Else Label4.Visible = False
    End Sub

End Class