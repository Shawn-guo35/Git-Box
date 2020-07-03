Imports System.Data.OleDb
Public Class 收入统计
    Dim objdataset As New DataSet
    Dim dataset1 As New DataSet
    Dim dataset2 As New DataSet
    Dim dataset3 As New DataSet
    Dim dataset4 As New DataSet
    Dim dataset5 As New DataSet
    Dim dataset6 As New DataSet
    Dim constr$, sqlstr$

    Private Sub btnSelIncome_Click(sender As Object, e As EventArgs) Handles btnSelIncome.Click
        sqlstr = "select fee from orders where stime='" & cmbYear.Text & "/" & cmbMon.Text & "/" & cmbDay.Text & "'"
        OleDbDataAdapter1 = New OleDbDataAdapter(sqlstr, OleDbConnection1)
        dataset4.Reset()
        OleDbDataAdapter1.Fill(dataset4, "dfee")
        Dim dsum = 0
        For i = 0 To dataset4.Tables("dfee").Rows.Count - 1
            dsum = dsum + dataset4.Tables("dfee").Rows(i).Item(0)
        Next
        txtDaySum.Text = dsum

        sqlstr = "select fee from orders where stime>='" & cmbYear.Text & "/01/01' And stime<='" & cmbYear.Text & "/12/30'"
        OleDbDataAdapter1 = New OleDbDataAdapter(sqlstr, OleDbConnection1)
        dataset5.Reset()
        OleDbDataAdapter1.Fill(dataset5, "mfee")
        Dim ysum = 0
        For i = 0 To dataset5.Tables("mfee").Rows.Count - 1
            ysum = ysum + dataset5.Tables("mfee").Rows(i).Item(0)
        Next
        txtYearSum.Text = ysum


        sqlstr = "select fee from orders where stime>='" & cmbYear.Text & "/" & cmbMon.Text & "/01' And stime<='" & cmbYear.Text & "/" & cmbMon.Text & "/30'"
        OleDbDataAdapter1 = New OleDbDataAdapter(sqlstr, OleDbConnection1)
        dataset6.Reset()
        OleDbDataAdapter1.Fill(dataset6, "mfee")
        Dim msum = 0
        For i = 0 To dataset6.Tables("mfee").Rows.Count - 1
            msum = msum + dataset6.Tables("mfee").Rows(i).Item(0)
        Next
        txtMonSum.Text = msum


    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()
    End Sub

    '窗体加载
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqlstr = "select orderno,stime,fee from orders "
        OleDbDataAdapter1 = New OleDbDataAdapter(sqlstr, OleDbConnection1)
        objdataset.Reset()
        OleDbDataAdapter1.Fill(objdataset, "收益")
        DataGridView1.DataSource = objdataset.Tables("收益")
        DataGridView1.Columns(0).HeaderText = "订单号"

        Dim sql As String = "select distinct datename(yy,stime) as year from orders "
        dataset2.Reset()
        OleDbDataAdapter1 = New OleDb.OleDbDataAdapter(sql, OleDbConnection1)
        OleDbDataAdapter1.Fill(dataset2, "y")
        cmbYear.DataSource = dataset2.Tables("y")
        For i = 0 To dataset2.Tables("y").Rows.Count - 1
            cmbYear.ValueMember = dataset2.Tables("y").Columns(0).ToString
        Next
        cmbYear.Text = ""
        sql = "select distinct datename(dd,stime) as year from orders "
        dataset3.Reset()
        OleDbDataAdapter1 = New OleDb.OleDbDataAdapter(sql, OleDbConnection1)
        OleDbDataAdapter1.Fill(dataset3, "d")
        cmbDay.DataSource = dataset3.Tables("d")
        For i = 0 To dataset3.Tables("d").Rows.Count - 1
            cmbDay.ValueMember = dataset3.Tables("d").Columns(0).ToString
        Next
        cmbDay.Text = ""
        sql = "select distinct datename(mm,stime) as year from orders "
        dataset1.Reset()
        OleDbDataAdapter1 = New OleDb.OleDbDataAdapter(sql, OleDbConnection1)
        OleDbDataAdapter1.Fill(dataset1, "m")
        cmbMon.DataSource = dataset1.Tables("m")
        For i = 0 To dataset1.Tables("m").Rows.Count - 1
            cmbMon.ValueMember = dataset1.Tables("m").Columns(0).ToString
        Next
        cmbMon.Text = ""
    End Sub


End Class