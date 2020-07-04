Public Class 场地管理
    Private Sub btnSubmit5_Click(sender As Object, e As EventArgs) Handles btnInsertVtype.Click
        Dim fm As New 添加场地信息
        fm.Show()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnSelectLease_Click(sender As Object, e As EventArgs) Handles btnSelectLease.Click
        Dim fm As New 查询场地租借情况
        fm.Show()
    End Sub

    Private Sub btnSelectVenue_Click(sender As Object, e As EventArgs) Handles btnSelectVenue.Click
        Dim fm As New 查询场地类型
        fm.Show()
    End Sub

    Private Sub btnSelectVtype_Click(sender As Object, e As EventArgs) Handles btnSelectVtype.Click
        Dim fm As New 查询场地信息
        fm.Show()
    End Sub

    Private Sub btnInsertVenue_Click(sender As Object, e As EventArgs) Handles btnInsertVenue.Click
        Dim fm As New 添加场地类型
        fm.Show()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class