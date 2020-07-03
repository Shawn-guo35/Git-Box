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

    Private Sub tsmiSelectVenue_Click(sender As Object, e As EventArgs) Handles tsmiSelectVenue.Click
        场地管理.Show()
    End Sub

    Private Sub tsmiSelectUsers_Click(sender As Object, e As EventArgs) Handles tsmiSelectUsers.Click
        用户管理.Show()
    End Sub

    Private Sub tsmiSelectIncome_Click(sender As Object, e As EventArgs) Handles tsmiSelectIncome.Click
        收入统计.Show()
    End Sub

    Private Sub tsmiSelectOrders_Click(sender As Object, e As EventArgs) Handles tsmiSelectOrders.Click
        订单查询.Show()
    End Sub

    Private Sub tsmiAdmin_Click(sender As Object, e As EventArgs) Handles tsmiAdmin.Click

    End Sub
End Class