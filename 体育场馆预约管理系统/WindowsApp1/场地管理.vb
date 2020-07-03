Public Class 场地管理
    Private Sub btnSubmit5_Click(sender As Object, e As EventArgs) Handles btnSubmit5.Click
        Dim fm As New 添加场地信息
        fm.Show()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnSubmit3_Click(sender As Object, e As EventArgs) Handles btnSubmit3.Click
        Dim fm As New 查询场地租借情况
        fm.Show()
    End Sub

    Private Sub btnSubmit1_Click(sender As Object, e As EventArgs) Handles btnSubmit1.Click
        Dim fm As New 查询场地类型
        fm.Show()
    End Sub

    Private Sub btnSubmit2_Click(sender As Object, e As EventArgs) Handles btnSubmit2.Click
        Dim fm As New 查询场地信息
        fm.Show()
    End Sub

    Private Sub btnSubmit4_Click(sender As Object, e As EventArgs) Handles btnSubmit4.Click
        Dim fm As New 添加场地类型
        fm.Show()
    End Sub

    Private Sub btnSubmit6_Click(sender As Object, e As EventArgs) Handles btnSubmit6.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class