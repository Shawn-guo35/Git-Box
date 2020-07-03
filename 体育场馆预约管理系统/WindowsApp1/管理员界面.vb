Public Class 管理员界面
    Private Sub tsmiCancellation_Click(sender As Object, e As EventArgs) Handles tsmiCancellation.Click
        Me.Hide()
    End Sub

    Private Sub tsmiClose1_Click(sender As Object, e As EventArgs) Handles tsmiClose1.Click
        End
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub tsmiSelect3_Click(sender As Object, e As EventArgs) Handles tsmiSelect3.Click
        场地管理.Show()
    End Sub

    Private Sub tsmiSelect1_Click(sender As Object, e As EventArgs) Handles tsmiSelect1.Click
        用户管理.Show()
    End Sub

    Private Sub tsmiSelect4_Click(sender As Object, e As EventArgs) Handles tsmiSelect4.Click
        收入统计.Show()
    End Sub

    Private Sub tsmiSelect2_Click(sender As Object, e As EventArgs) Handles tsmiSelect2.Click
        订单查询.Show()
    End Sub
End Class