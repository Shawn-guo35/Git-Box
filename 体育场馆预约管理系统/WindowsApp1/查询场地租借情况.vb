Public Class 查询场地租借情况

    Private Sub 场地管理系统_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“ChangguanDataSet6.Lease”中。您可以根据需要移动或删除它。
        Me.LeaseTableAdapter.Fill(Me.ChangguanDataSet6.Lease)

    End Sub



    Private Sub btnSelectLease_Click(sender As Object, e As EventArgs) Handles btnSelectLease.Click
        Dim s As String

        If txtGymName.Text = "" Then
            MsgBox("请输入查询条件", MsgBoxStyle.Exclamation, "警告")
            Exit Sub
        End If
        Select Case cbmGym.SelectedItem
            Case "场地名称"
                ChangguanDataSet1.Tables("Lease").Clear()
                s = "select  *  from  Lease  where  Vname ='" + txtGymName.Text + "'"
                SqlDataAdapter1.SelectCommand.CommandText = s
                SqlDataAdapter1.Fill(ChangguanDataSet1)
                txtGymLease.DataSource = ChangguanDataSet1.Tables("Lease")
            Case "场地名称&场地编号"
                ChangguanDataSet1.Tables("Lease").Clear()
                s = "select  *  from Lease where  Vno ='" + txtGymNum.Text.Trim + "'and Vname ='" + txtGymName.Text.Trim + "'"


                SqlDataAdapter1.SelectCommand.CommandText = s
                SqlDataAdapter1.Fill(ChangguanDataSet1)
                txtGymLease.DataSource = ChangguanDataSet1.Tables("Lease")
        End Select
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()
    End Sub



    Private Sub cbmGym_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbmGym.SelectedIndexChanged
        If cbmGym.SelectedItem = "场地名称&场地编号" Then txtGymNum.Visible = True Else txtGymNum.Visible = False

        If cbmGym.SelectedItem = "场地名称&场地编号" Then lblResults14.Visible = True Else lblResults14.Visible = False
    End Sub


End Class