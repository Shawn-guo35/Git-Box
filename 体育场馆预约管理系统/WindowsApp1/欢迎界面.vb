Public Class 欢迎界面

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '计时器到时 该页面关闭
        Timer1.Interval = 3000 '1000=1秒
        Timer1.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Close()
    End Sub


End Class
