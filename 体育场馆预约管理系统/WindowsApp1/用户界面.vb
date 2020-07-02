
Public Class 用户界面
    Private Sub 退出ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles 退出ToolStripMenuItem2.Click
        End
    End Sub

    Private Sub 注销ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 注销ToolStripMenuItem1.Click
        Me.Close()
        登录界面.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub 注销ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 注销ToolStripMenuItem.Click
        修改密码.ShowDialog()
    End Sub

    Private Sub 查询历史订单ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 查询历史订单ToolStripMenuItem.Click
        用户订单查询.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Yuyue.Show()
    End Sub

    Private Sub 退出ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 退出ToolStripMenuItem1.Click

    End Sub
End Class
