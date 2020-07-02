Public Class 管理员界面
    Private Sub 注销ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 注销ToolStripMenuItem.Click
        Me.Hide()
    End Sub

    Private Sub 退出ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 退出ToolStripMenuItem.Click
        End
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub 查询场地信息ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 查询场地信息ToolStripMenuItem.Click
        场地管理.Show()
    End Sub

    Private Sub 查询订单信息ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 查询用户信息.Click
        用户管理.Show()
    End Sub

    Private Sub 统计订单信息ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 统计收入信息ToolStripMenuItem.Click
        收入统计.Show()
    End Sub

    Private Sub 查询ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 查询订单信息.Click
        订单查询.Show()
    End Sub
End Class