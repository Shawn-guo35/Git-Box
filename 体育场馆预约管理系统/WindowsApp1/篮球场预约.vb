Imports System.String
Public Class orderBasketball

    Private Sub btnGymview_Click(sender As Object, e As EventArgs) Handles btnGymview.Click
        viewBasketball.Show()
    End Sub

    Private Sub btnSubmit1_Click(sender As Object, e As EventArgs) Handles btnSubmit1.Click
        dgvOrder.Rows.Clear()
        dgvOrder.Columns.Clear()
        '显示表格
        Me.dgvOrder.AllowUserToAddRows = False
        dgvOrder.RowTemplate.Height = 50
        dgvOrder.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        Me.dgvOrder.Columns.Add("时间", "时间")
        Me.dgvOrder.Columns(0).Width = 90
        '可预约的时间段规定为以下四个
        Me.dgvOrder.Rows.Add("12:00-13:00")
        Me.dgvOrder.Rows.Add("13:00-14:00")
        Me.dgvOrder.Rows.Add("18:00-19:00")
        Me.dgvOrder.Rows.Add("19:00-20:00")
        For i = 1 To 7
            Me.dgvOrder.Columns.Add(DateAdd(DateInterval.Day, i - 1, Now.Date), DateAdd(DateInterval.Day, i - 1, Now.Date))
            Me.dgvOrder.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
            Me.dgvOrder.Columns(i).Width = 70
        Next
        For i = 1 To 7
            For j = 0 To 3
                Me.dgvOrder.Item(i, j).Value = "可用"
            Next
        Next

        '连接数据库 更改表格
        Dim sql As String
        '查询Lease表 得出空闲的场地
        sql = "select convert(date,Stime),convert(time,Stime,8),convert(time,Etime),Condition from Lease where Vno='" & cbmGymnum.SelectedValue.ToString & "' and Vname='篮球场'"
        dstBasketLease.Reset()
        odadSelBaseket = New OleDb.OleDbDataAdapter(sql, OleDbConnection1)
        odadSelBaseket.Fill(dstBasketLease, "ss")
        If (dstBasketLease.Tables("ss").Rows.Count <> 0) Then
            For j = 1 To dstBasketLease.Tables("ss").Rows.Count
                For i = 1 To 7
                    '填充DateGridView 如果dgv里的时间在select出的表中也存在 则把dgv中相应的场地状态改为已借出
                    If (dgvOrder.Columns(i).Name = dstBasketLease.Tables("ss").Rows(j - 1).Item(0)) Then
                        If (dstBasketLease.Tables("ss").Rows(j - 1).Item(1).ToString = "12:00:00.0000000") Then
                            dgvOrder.Item(i, 0).Value = dstBasketLease.Tables("ss").Rows(j - 1).Item(3)
                        End If
                        If (dstBasketLease.Tables("ss").Rows(j - 1).Item(1).ToString = "13:00:00.0000000") Then
                            dgvOrder.Item(i, 1).Value = dstBasketLease.Tables("ss").Rows(j - 1).Item(3)
                        End If
                        If (dstBasketLease.Tables("ss").Rows(j - 1).Item(1).ToString = "18:00:00.0000000") Then
                            dgvOrder.Item(i, 2).Value = dstBasketLease.Tables("ss").Rows(j - 1).Item(3)
                        End If
                        If (dstBasketLease.Tables("ss").Rows(j - 1).Item(1).ToString = "19:00:00.0000000") Then
                            dgvOrder.Item(i, 3).Value = dstBasketLease.Tables("ss").Rows(j - 1).Item(3)
                        End If
                    End If
                Next
            Next
        End If

    End Sub

    Private Sub dgvOrder_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOrder.CellContentDoubleClick
        Dim str As String
        Dim sql1 As String
        Dim sql2 As String
        Dim sql3 As String
        Dim Vno As String
        Dim Stime As String '开始时间
        Dim Etime As String '结束时间
        Dim fee As Double '租借费用
        Dim uname As String '用户姓名
        Dim userId As String
        userId = 登录界面.txtID.Text
        '获取用户姓名和租金
        odadSelBaseket = New OleDb.OleDbDataAdapter("select Uname,Uidentity,INrental,OUTrental from Users,Vtype where ID='" + userId + "' and Vname='篮球场'", OleDbConnection1)
        odadSelBaseket.Fill(dstBasketLease, "ff")
        If (dstBasketLease.Tables("ff").Rows(0).Item(1) = "校外人员") Then
            fee = dstBasketLease.Tables("ff").Rows(0).Item(3) '校外人员价格
        Else
            fee = dstBasketLease.Tables("ff").Rows(0).Item(2) '校内人员价格
        End If
        uname = dstBasketLease.Tables("ff").Rows(0).Item(0)

        '判断租借场地是否达到上限
        sql3 = "select * from Orders where ID='" & 登录界面.txtID.Text & "' and Stime between '" & Now.Date & "' and '" & Now.Date.AddDays(6) & "'"
        odadSelOrder = New OleDb.OleDbDataAdapter(sql3, OleDbConnection1)
        odadSelOrder.Fill(dstSelOrder, "order")
        If (dstSelOrder.Tables("order").Rows.Count >= 5) Then
            MsgBox("抱歉，一周内预订总时长不能超过五小时。")
        Else
            '时间预定
            If (btnSubmit1.Visible = False) Then
                Vno = dgvOrder.Item(e.ColumnIndex, e.RowIndex).Value.ToString
                Stime = dtpTime.Value.Date.ToString("yyyy-MM-dd") & " " & cmbBegintime.SelectedItem.ToString
                Etime = dtpTime.Value.Date.ToString("yyyy-MM-dd") & " " & txtEndtime.Text
                str = "确定预订" & Stime & "到" & Etime & "的篮球场" & Vno & "吗？"
                If (MsgBox(str, vbOKCancel) = 1) Then
                    If (MsgBox("本次预订租金为" & fee & "元", vbOKCancel) = 1) Then
                        sql1 = "insert into Lease values('篮球场','" & Vno & "','" & Stime & "','" & Etime & "','" & "已借出')"
                        sql2 = "insert into Orders values('" & 登录界面.txtID.Text & "','篮球场','" & Vno & "','" & Stime & "','" & Etime & "',1," & fee &
                         ",'" & Now.ToString("yyyyMMddhhmm") & "b" & Vno & "','" & uname & "','')"
                        odcmdInsLease = New OleDb.OleDbCommand(sql1, OleDbConnection1)
                        odcmdInsOrder = New OleDb.OleDbCommand(sql2, OleDbConnection1)
                        OleDbConnection1.Open()
                        odcmdInsLease.ExecuteNonQuery()
                        odcmdInsOrder.ExecuteNonQuery()
                        OleDbConnection1.Close()
                        MsgBox("预订成功")
                    End If
                End If
            Else
                '场地预定
                Vno = cbmGymnum.SelectedValue.ToString
                str = "确定预订" & dgvOrder.Columns(e.ColumnIndex).Name & " " & dgvOrder.Item(0, e.RowIndex).Value & "的篮球场" & Vno & "吗？"
                If (dgvOrder.Item(e.ColumnIndex, e.RowIndex).Value.ToString <> "可用") Then
                    MsgBox("该时间段不可预订！")
                ElseIf (MsgBox(str, vbOKCancel) = 1) Then
                    If (MsgBox("本次预订租金为" & fee & "元", vbOKCancel) = 1) Then
                        If (e.RowIndex = 0) Then
                            sql1 = "insert into Lease values('篮球场','" & Vno & "','" & dgvOrder.Columns(e.ColumnIndex).Name & " 12:00:00','" & dgvOrder.Columns(e.ColumnIndex).Name & " 13:00:00','" & "已借出')"
                            sql2 = "insert into Orders values('" & 登录界面.txtID.Text & "','篮球场','" & Vno & "','" & dgvOrder.Columns(e.ColumnIndex).Name & " 12:00:00','" & dgvOrder.Columns(e.ColumnIndex).Name & " 13:00:00',1," & fee &
                            ",'" & Now.ToString("yyyyMMddhhmm") & "b" & Vno & "','" & uname & "','')"
                        ElseIf (e.RowIndex = 1) Then
                            sql1 = "insert into Lease values('篮球场','" & Vno & "','" & dgvOrder.Columns(e.ColumnIndex).Name & " 13:00:00','" & dgvOrder.Columns(e.ColumnIndex).Name & " 14:00:00','" & "已借出')"
                            sql2 = "insert into Orders values('" & 登录界面.txtID.Text & "','篮球场','" & Vno & "','" & dgvOrder.Columns(e.ColumnIndex).Name & " 13:00:00','" & dgvOrder.Columns(e.ColumnIndex).Name & " 14:00:00',1," & fee &
                            ",'" & Now.ToString("yyyyMMddhhmm") & "b" & Vno & "','" & uname & "','')"
                        ElseIf (e.RowIndex = 2) Then
                            sql1 = "insert into Lease values('篮球场','" & Vno & "','" & dgvOrder.Columns(e.ColumnIndex).Name & " 18:00:00','" & dgvOrder.Columns(e.ColumnIndex).Name & " 19:00:00','" & "已借出')"
                            sql2 = "insert into Orders values('" & 登录界面.txtID.Text & "','篮球场','" & Vno & "','" & dgvOrder.Columns(e.ColumnIndex).Name & " 18:00:00','" & dgvOrder.Columns(e.ColumnIndex).Name & " 19:00:00',1," & fee &
                            ",'" & Now.ToString("yyyyMMddhhmm") & "b" & Vno & "','" & uname & "','')"
                        ElseIf (e.RowIndex = 3) Then
                            sql1 = "insert into Lease values('篮球场','" & Vno & "','" & dgvOrder.Columns(e.ColumnIndex).Name & " 19:00:00','" & dgvOrder.Columns(e.ColumnIndex).Name & " 20:00:00','" & "已借出')"
                            sql2 = "insert into Orders values('" & 登录界面.txtID.Text & "','篮球场','" & Vno & "','" & dgvOrder.Columns(e.ColumnIndex).Name & " 19:00:00','" & dgvOrder.Columns(e.ColumnIndex).Name & " 20:00:00',1," & fee &
                            ",'" & Now.ToString("yyyyMMddhhmm") & "b" & Vno & "','" & uname & "','')"
                        End If
                        odcmdInsLease = New OleDb.OleDbCommand(sql1, OleDbConnection1)
                        odcmdInsOrder = New OleDb.OleDbCommand(sql2, OleDbConnection1)
                        OleDbConnection1.Open()
                        odcmdInsLease.ExecuteNonQuery()
                        odcmdInsOrder.ExecuteNonQuery()
                        OleDbConnection1.Close()
                        MsgBox("预订成功")
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub cmbBegintime_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbBegintime.SelectedIndexChanged
        If (cmbBegintime.SelectedItem.ToString = "12:00") Then
            txtEndtime.Text = "13:00"
        ElseIf (cmbBegintime.SelectedItem.ToString = "13:00") Then
            txtEndtime.Text = "14:00"
        ElseIf (cmbBegintime.SelectedItem.ToString = "18:00") Then
            txtEndtime.Text = "19:00"
        ElseIf (cmbBegintime.SelectedItem.ToString = "19:00") Then
            txtEndtime.Text = "20:00"
        End If
    End Sub

    Private Sub btnSubmit2_Click(sender As Object, e As EventArgs) Handles btnSubmit2.Click
        '连接数据库
        Dim sql1 As String
        Dim sql2 As String
        sql1 = "select Vno from Venue where Vname='篮球场'"
        dstBasketLease.Reset()
        odadSelBaseket = New OleDb.OleDbDataAdapter(sql1, OleDbConnection1)
        odadSelBaseket.Fill(dstBasketLease, "ss")
        sql2 = "select Vno from Lease where Vname='篮球场' and Stime = '" _
            & dtpTime.Value.Date.ToString("yyyy-MM-dd") & " " & cmbBegintime.SelectedItem.ToString & "'"
        odadSelBaseket = New OleDb.OleDbDataAdapter(sql2, OleDbConnection1)
        odadSelBaseket.Fill(dstBasketLease, "aa")

        '显示表格
        dgvOrder.Rows.Clear()
        dgvOrder.Columns.Clear()
        Me.dgvOrder.AllowUserToAddRows = False
        dgvOrder.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        Me.dgvOrder.Columns.Add("空闲场地", "空闲场地")
        Me.dgvOrder.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        For i = 0 To dstBasketLease.Tables("ss").Rows.Count - 1
            Me.dgvOrder.Rows.Add()
            Me.dgvOrder.Item(0, i).Value = dstBasketLease.Tables("ss").Rows(i).Item(0)
        Next

        '修改表格
        If (dstBasketLease.Tables("aa").Rows.Count <> 0) Then
            For i = dstBasketLease.Tables("aa").Rows.Count - 1 To 0 Step -1
                Me.dgvOrder.Rows.RemoveAt(Integer.Parse(dstBasketLease.Tables("aa").Rows(i).Item(0)) - 1)
            Next
        End If

    End Sub

    Private Sub orderBasketball_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnSubmit1.Visible = False
        Label4.Visible = False
        cbmGymnum.Visible = False
        dtpTime.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        txtEndtime.Visible = False
        cmbBegintime.Visible = False
        btnSubmit2.Visible = False
        dtpTime.MinDate = Now
        dtpTime.MaxDate = Now.AddDays(6)    '只可预订一周的场地
        Dim sql As String = "select Vno from Venue where Vname='篮球场' order by Vno"
        dstSelOrder.Reset()
        odadSelBaseket = New OleDb.OleDbDataAdapter(sql, OleDbConnection1)
        odadSelBaseket.Fill(dstSelOrder, "ss")
        cbmGymnum.DataSource = dstSelOrder.Tables("ss")
        For i = 0 To dstSelOrder.Tables("ss").Rows.Count - 1
            cbmGymnum.ValueMember = dstSelOrder.Tables("ss").Columns(0).ToString    '填充下拉栏里的场地号
        Next
    End Sub

    '按场地预订时点击确认发生的事件
    Private Sub btnGymorder_Click(sender As Object, e As EventArgs) Handles btnGymorder.Click
        btnSubmit1.Visible = True
        Label4.Visible = True
        cbmGymnum.Visible = True
        dtpTime.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        txtEndtime.Visible = False
        cmbBegintime.Visible = False
        btnSubmit2.Visible = False
        Label3.Visible = True
        Label3.Text = "双击表中'可用'即可预订该时间的场地"
        dgvOrder.Rows.Clear()
        dgvOrder.Columns.Clear()
    End Sub

    '按时间预订时点击确认发生的事件
    Private Sub btnTimeorder_Click(sender As Object, e As EventArgs) Handles btnTimeorder.Click
        btnSubmit1.Visible = False
        Label4.Visible = False
        cbmGymnum.Visible = False
        dtpTime.Visible = True
        Label1.Visible = True
        Label2.Visible = True
        txtEndtime.Visible = True
        cmbBegintime.Visible = True
        btnSubmit2.Visible = True
        Label3.Visible = True
        Label3.Text = "双击表中的场地号即可预订该场地"
        dgvOrder.Rows.Clear()
        dgvOrder.Columns.Clear()
    End Sub
End Class
