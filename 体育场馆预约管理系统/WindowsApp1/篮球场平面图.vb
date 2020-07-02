Public Class viewBasketball
    'Picturebox均为篮球场平面图
    Private Sub viewBasketball_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String
        sql = "select * from Vtype where Vname='篮球场'"
        OleDbDataAdapter1 = New OleDb.OleDbDataAdapter(sql, OleDbConnection1)
        OleDbDataAdapter1.Fill(DataSet1, "ss")
        Label16.Text = "篮球场地址：" & DataSet1.Tables("ss").Rows(0).Item(3).ToString & vbCrLf _
        & "校内人员租金为" & DataSet1.Tables("ss").Rows(0).Item(1) & "元/小时" & vbCrLf _
         & "校外人员租金为" & DataSet1.Tables("ss").Rows(0).Item(2) & "元/小时"
    End Sub

End Class