Imports System.Data.OleDb
Public Class 订单查询
    Dim objdataset As New DataSet
    Dim dataset1 As New DataSet
    Dim dataset2 As New DataSet
    Dim constr$, sqlstr$

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()

    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click

        '三重查询
        If (cmbPlaceNo.Text = "") Then
            sqlstr = "select * from orders where ID='" & txtID.Text & "' AND Stime='" & txtStime.Text & "' AND vname='" & cmbPlaceName.Text & "'"
            dispp(sqlstr)
        End If

        If (txtID.Text = "") Then
            sqlstr = "select * from orders where Stime='" & txtStime.Text & "' AND vname='" & cmbPlaceName.Text & "' AND vno='" & cmbPlaceNo.Text & "'"
            dispp(sqlstr)
        End If
        If (txtStime.Text = "") Then
            sqlstr = "select * from orders where ID='" & txtID.Text & "' AND vname='" & cmbPlaceName.Text & "' AND vno='" & cmbPlaceNo.Text & "'"
            dispp(sqlstr)
        End If


        '双重
        If (txtStime.Text = "" And cmbPlaceNo.Text = "") Then
            sqlstr = "select * from orders where ID='" & txtID.Text & "' AND vname='" & cmbPlaceName.Text & "'"
            dispp(sqlstr)
        End If
        If (txtID.Text = "" And cmbPlaceNo.Text = "") Then
            sqlstr = "select * from orders where Stime='" & txtStime.Text & "' AND vname='" & cmbPlaceName.Text & "'"
            dispp(sqlstr)
        End If
        If (cmbPlaceNo.Text = "" And cmbPlaceName.Text = "") Then
            sqlstr = "select * from orders where Stime='" & txtStime.Text & "' AND ID='" & txtID.Text & "'"
            dispp(sqlstr)
        End If
        If (txtID.Text = "" And txtStime.Text = "") Then
            sqlstr = "select * from orders where vname='" & cmbPlaceName.Text & "' AND vno='" & cmbPlaceNo.Text & "'"
            dispp(sqlstr)
        End If

        '单次查询

        If (txtStime.Text = "" And cmbPlaceName.Text = "" And cmbPlaceNo.Text = "") Then
            sqlstr = "select * from orders where ID='" & txtID.Text & "'"
            dispp(sqlstr)
        End If
        If (txtID.Text = "" And cmbPlaceName.Text = "" And cmbPlaceNo.Text = "") Then
            sqlstr = "select * from orders where Stime='" & txtStime.Text & "'"
            dispp(sqlstr)
        End If
        If (txtID.Text = "" And txtStime.Text = "" And cmbPlaceNo.Text = "") Then
            sqlstr = "select * from orders where vname='" & cmbPlaceName.Text & "'"
            dispp(sqlstr)
        End If

    End Sub
    Sub dispp(ByVal sql$)
        OleDbDataAdapter1 = New OleDbDataAdapter(sqlstr, OleDbConnection1)
        objdataset.Reset()
        OleDbDataAdapter1.Fill(objdataset, "订单查询")
        DataGridView1.DataSource = objdataset.Tables("订单查询")
    End Sub


    '订单查找
    Private Sub btnSelOrder_Click(sender As Object, e As EventArgs) Handles btnSelOrder.Click
        sqlstr = "select * from orders where orderno='" & txtOrderNo.Text & "'"
        dispp(sqlstr)
    End Sub
    '窗体加载
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqlstr = "select * from orders "
        OleDbDataAdapter1 = New OleDbDataAdapter(sqlstr, OleDbConnection1)
        objdataset.Reset()
        OleDbDataAdapter1.Fill(objdataset, "订单")
        DataGridView1.DataSource = objdataset.Tables("订单")
        DataGridView1.Columns(0).HeaderText = "编号"

        Dim sql As String = "select Vno from Venue "
        dataset1.Reset()
        OleDbDataAdapter1 = New OleDb.OleDbDataAdapter(sql, OleDbConnection1)
        OleDbDataAdapter1.Fill(dataset1, "ss")
        cmbPlaceNo.DataSource = dataset1.Tables("ss")
        For i = 0 To dataset1.Tables("ss").Rows.Count - 1
            cmbPlaceNo.ValueMember = dataset1.Tables("ss").Columns(0).ToString
        Next
        cmbPlaceNo.Text = ""
        sql = "select distinct Vname from Venue "
        dataset2.Reset()
        OleDbDataAdapter1 = New OleDb.OleDbDataAdapter(sql, OleDbConnection1)
        OleDbDataAdapter1.Fill(dataset2, "ss")
        cmbPlaceName.DataSource = dataset2.Tables("ss")
        For i = 0 To dataset2.Tables("ss").Rows.Count - 1
            cmbPlaceName.ValueMember = dataset2.Tables("ss").Columns(0).ToString
        Next
        cmbPlaceName.Text = ""
    End Sub
End Class
