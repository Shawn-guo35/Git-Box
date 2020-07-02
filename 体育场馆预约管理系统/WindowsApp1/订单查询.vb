Imports System.Data.OleDb
Public Class 订单查询
    Dim objdataset As New DataSet
    Dim dataset1 As New DataSet
    Dim dataset2 As New DataSet
    Dim constr$, sqlstr$

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        '三重查询
        If (ComboBox2.Text = "") Then
            sqlstr = "select * from orders where ID='" & TextBox2.Text & "' AND Stime='" & TextBox3.Text & "' AND vname='" & ComboBox1.Text & "'"
            dispp(sqlstr)
        End If

        If (TextBox2.Text = "") Then
            sqlstr = "select * from orders where Stime='" & TextBox3.Text & "' AND vname='" & ComboBox1.Text & "' AND vno='" & ComboBox2.Text & "'"
            dispp(sqlstr)
        End If
        If (TextBox3.Text = "") Then
            sqlstr = "select * from orders where ID='" & TextBox2.Text & "' AND vname='" & ComboBox1.Text & "' AND vno='" & ComboBox2.Text & "'"
            dispp(sqlstr)
        End If


        '双重
        If (TextBox3.Text = "" And ComboBox2.Text = "") Then
            sqlstr = "select * from orders where ID='" & TextBox2.Text & "' AND vname='" & ComboBox1.Text & "'"
            dispp(sqlstr)
        End If
        If (TextBox2.Text = "" And ComboBox2.Text = "") Then
            sqlstr = "select * from orders where Stime='" & TextBox3.Text & "' AND vname='" & ComboBox1.Text & "'"
            dispp(sqlstr)
        End If
        If (ComboBox2.Text = "" And ComboBox1.Text = "") Then
            sqlstr = "select * from orders where Stime='" & TextBox3.Text & "' AND ID='" & TextBox2.Text & "'"
            dispp(sqlstr)
        End If
        If (TextBox2.Text = "" And TextBox3.Text = "") Then
            sqlstr = "select * from orders where vname='" & ComboBox1.Text & "' AND vno='" & ComboBox2.Text & "'"
            dispp(sqlstr)
        End If

        '单次查询

        If (TextBox3.Text = "" And ComboBox1.Text = "" And ComboBox2.Text = "") Then
            sqlstr = "select * from orders where ID='" & TextBox2.Text & "'"
            dispp(sqlstr)
        End If
        If (TextBox2.Text = "" And ComboBox1.Text = "" And ComboBox2.Text = "") Then
            sqlstr = "select * from orders where Stime='" & TextBox3.Text & "'"
            dispp(sqlstr)
        End If
        If (TextBox2.Text = "" And TextBox3.Text = "" And ComboBox2.Text = "") Then
            sqlstr = "select * from orders where vname='" & ComboBox1.Text & "'"
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
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sqlstr = "select * from orders where orderno='" & TextBox1.Text & "'"
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
        ComboBox2.DataSource = dataset1.Tables("ss")
        For i = 0 To dataset1.Tables("ss").Rows.Count - 1
            ComboBox2.ValueMember = dataset1.Tables("ss").Columns(0).ToString
        Next
        ComboBox2.Text = ""
        sql = "select distinct Vname from Venue "
        dataset2.Reset()
        OleDbDataAdapter1 = New OleDb.OleDbDataAdapter(sql, OleDbConnection1)
        OleDbDataAdapter1.Fill(dataset2, "ss")
        ComboBox1.DataSource = dataset2.Tables("ss")
        For i = 0 To dataset2.Tables("ss").Rows.Count - 1
            ComboBox1.ValueMember = dataset2.Tables("ss").Columns(0).ToString
        Next
        ComboBox1.Text = ""
    End Sub
End Class
