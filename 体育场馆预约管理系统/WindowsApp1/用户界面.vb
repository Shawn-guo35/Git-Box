
Public Class 用户界面
    Private Sub tsmiClose1_Click(sender As Object, e As EventArgs) Handles tsmiClose1.Click
        End
    End Sub

    Private Sub tsmiCancellation_Click(sender As Object, e As EventArgs) Handles tsmiCancellation.Click
        Me.Close()
        登录界面.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub tsmiUser1_Click(sender As Object, e As EventArgs) Handles tsmiUser1.Click
        修改密码.ShowDialog()
    End Sub

    Private Sub tsmiUser2_Click(sender As Object, e As EventArgs) Handles tsmiUser2.Click
        用户订单查询.Show()
    End Sub

    Private Sub tsmiAppointment_Click(sender As Object, e As EventArgs) Handles tsmiAppointment.Click
        Yuyue.Show()
    End Sub

    Private Sub tsmiClose_Click(sender As Object, e As EventArgs) Handles tsmiClose.Click

    End Sub
End Class
