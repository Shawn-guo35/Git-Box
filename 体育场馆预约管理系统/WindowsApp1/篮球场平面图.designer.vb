<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class viewBasketball
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(viewBasketball))
        Me.lblResults1 = New System.Windows.Forms.Label()
        Me.lblResults2 = New System.Windows.Forms.Label()
        Me.lblResults3 = New System.Windows.Forms.Label()
        Me.lblResults4 = New System.Windows.Forms.Label()
        Me.lblResults5 = New System.Windows.Forms.Label()
        Me.lblResults6 = New System.Windows.Forms.Label()
        Me.lblResults7 = New System.Windows.Forms.Label()
        Me.lblResults8 = New System.Windows.Forms.Label()
        Me.lblResults9 = New System.Windows.Forms.Label()
        Me.lblResults10 = New System.Windows.Forms.Label()
        Me.lblResults11 = New System.Windows.Forms.Label()
        Me.lblResults12 = New System.Windows.Forms.Label()
        Me.lblResults13 = New System.Windows.Forms.Label()
        Me.lblResults14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.DataSet1 = New System.Data.DataSet()
        Me.picBasketball14 = New System.Windows.Forms.PictureBox()
        Me.picBasketball13 = New System.Windows.Forms.PictureBox()
        Me.picBasketball12 = New System.Windows.Forms.PictureBox()
        Me.picBasketball11 = New System.Windows.Forms.PictureBox()
        Me.picBasketball10 = New System.Windows.Forms.PictureBox()
        Me.picBasketball9 = New System.Windows.Forms.PictureBox()
        Me.picBasketball8 = New System.Windows.Forms.PictureBox()
        Me.picBasketball7 = New System.Windows.Forms.PictureBox()
        Me.picBasketball6 = New System.Windows.Forms.PictureBox()
        Me.picBasketball5 = New System.Windows.Forms.PictureBox()
        Me.picBasketball3 = New System.Windows.Forms.PictureBox()
        Me.picBasketball2 = New System.Windows.Forms.PictureBox()
        Me.picBasketball4 = New System.Windows.Forms.PictureBox()
        Me.picBasketball1 = New System.Windows.Forms.PictureBox()
        Me.lblResults16 = New System.Windows.Forms.Label()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBasketball14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBasketball13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBasketball12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBasketball11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBasketball10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBasketball9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBasketball8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBasketball7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBasketball6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBasketball5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBasketball3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBasketball2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBasketball4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBasketball1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblResults1
        '
        Me.lblResults1.AutoSize = True
        Me.lblResults1.Location = New System.Drawing.Point(93, 66)
        Me.lblResults1.Name = "lblResults1"
        Me.lblResults1.Size = New System.Drawing.Size(23, 15)
        Me.lblResults1.TabIndex = 22
        Me.lblResults1.Text = "01"
        '
        'lblResults2
        '
        Me.lblResults2.AutoSize = True
        Me.lblResults2.Location = New System.Drawing.Point(250, 66)
        Me.lblResults2.Name = "lblResults2"
        Me.lblResults2.Size = New System.Drawing.Size(23, 15)
        Me.lblResults2.TabIndex = 23
        Me.lblResults2.Text = "02"
        '
        'lblResults3
        '
        Me.lblResults3.AutoSize = True
        Me.lblResults3.Location = New System.Drawing.Point(405, 66)
        Me.lblResults3.Name = "lblResults3"
        Me.lblResults3.Size = New System.Drawing.Size(23, 15)
        Me.lblResults3.TabIndex = 24
        Me.lblResults3.Text = "03"
        '
        'lblResults4
        '
        Me.lblResults4.AutoSize = True
        Me.lblResults4.Location = New System.Drawing.Point(543, 66)
        Me.lblResults4.Name = "lblResults4"
        Me.lblResults4.Size = New System.Drawing.Size(23, 15)
        Me.lblResults4.TabIndex = 25
        Me.lblResults4.Text = "04"
        '
        'lblResults5
        '
        Me.lblResults5.AutoSize = True
        Me.lblResults5.Location = New System.Drawing.Point(641, 66)
        Me.lblResults5.Name = "lblResults5"
        Me.lblResults5.Size = New System.Drawing.Size(23, 15)
        Me.lblResults5.TabIndex = 26
        Me.lblResults5.Text = "05"
        '
        'lblResults6
        '
        Me.lblResults6.AutoSize = True
        Me.lblResults6.Location = New System.Drawing.Point(641, 434)
        Me.lblResults6.Name = "lblResults6"
        Me.lblResults6.Size = New System.Drawing.Size(23, 15)
        Me.lblResults6.TabIndex = 27
        Me.lblResults6.Text = "06"
        '
        'lblResults7
        '
        Me.lblResults7.AutoSize = True
        Me.lblResults7.Location = New System.Drawing.Point(738, 66)
        Me.lblResults7.Name = "lblResults7"
        Me.lblResults7.Size = New System.Drawing.Size(23, 15)
        Me.lblResults7.TabIndex = 28
        Me.lblResults7.Text = "07"
        '
        'lblResults8
        '
        Me.lblResults8.AutoSize = True
        Me.lblResults8.Location = New System.Drawing.Point(738, 434)
        Me.lblResults8.Name = "lblResults8"
        Me.lblResults8.Size = New System.Drawing.Size(23, 15)
        Me.lblResults8.TabIndex = 29
        Me.lblResults8.Text = "08"
        '
        'lblResults9
        '
        Me.lblResults9.AutoSize = True
        Me.lblResults9.Location = New System.Drawing.Point(838, 66)
        Me.lblResults9.Name = "lblResults9"
        Me.lblResults9.Size = New System.Drawing.Size(23, 15)
        Me.lblResults9.TabIndex = 30
        Me.lblResults9.Text = "09"
        '
        'lblResults10
        '
        Me.lblResults10.AutoSize = True
        Me.lblResults10.Location = New System.Drawing.Point(838, 434)
        Me.lblResults10.Name = "lblResults10"
        Me.lblResults10.Size = New System.Drawing.Size(23, 15)
        Me.lblResults10.TabIndex = 31
        Me.lblResults10.Text = "10"
        '
        'lblResults11
        '
        Me.lblResults11.AutoSize = True
        Me.lblResults11.Location = New System.Drawing.Point(932, 66)
        Me.lblResults11.Name = "lblResults11"
        Me.lblResults11.Size = New System.Drawing.Size(23, 15)
        Me.lblResults11.TabIndex = 32
        Me.lblResults11.Text = "11"
        '
        'lblResults12
        '
        Me.lblResults12.AutoSize = True
        Me.lblResults12.Location = New System.Drawing.Point(932, 434)
        Me.lblResults12.Name = "lblResults12"
        Me.lblResults12.Size = New System.Drawing.Size(23, 15)
        Me.lblResults12.TabIndex = 33
        Me.lblResults12.Text = "12"
        '
        'lblResults13
        '
        Me.lblResults13.AutoSize = True
        Me.lblResults13.Location = New System.Drawing.Point(1035, 66)
        Me.lblResults13.Name = "lblResults13"
        Me.lblResults13.Size = New System.Drawing.Size(23, 15)
        Me.lblResults13.TabIndex = 34
        Me.lblResults13.Text = "13"
        '
        'lblResults14
        '
        Me.lblResults14.AutoSize = True
        Me.lblResults14.Location = New System.Drawing.Point(1035, 434)
        Me.lblResults14.Name = "lblResults14"
        Me.lblResults14.Size = New System.Drawing.Size(23, 15)
        Me.lblResults14.TabIndex = 35
        Me.lblResults14.Text = "14"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(75, 212)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 15)
        Me.Label15.TabIndex = 36
        Me.Label15.Text = "入  口"
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=SQLNCLI11;Data Source=DESKTOP-DSP6URK\SQLEXPRESS;Integrated Security=SSP" &
    "I;Initial Catalog=changguan"
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT  Vaddress, INrental, OUTrental" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM      Vtype" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE   (Vname = '篮球场')"
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Vtype", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Vaddress", "Vaddress"), New System.Data.Common.DataColumnMapping("INrental", "INrental"), New System.Data.Common.DataColumnMapping("OUTrental", "OUTrental")})})
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        '
        'picBasketball14
        '
        Me.picBasketball14.BackgroundImage = CType(resources.GetObject("picBasketball14.BackgroundImage"), System.Drawing.Image)
        Me.picBasketball14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBasketball14.Location = New System.Drawing.Point(994, 259)
        Me.picBasketball14.Name = "picBasketball14"
        Me.picBasketball14.Size = New System.Drawing.Size(100, 160)
        Me.picBasketball14.TabIndex = 21
        Me.picBasketball14.TabStop = False
        '
        'picBasketball13
        '
        Me.picBasketball13.BackgroundImage = CType(resources.GetObject("picBasketball13.BackgroundImage"), System.Drawing.Image)
        Me.picBasketball13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBasketball13.Location = New System.Drawing.Point(994, 93)
        Me.picBasketball13.Name = "picBasketball13"
        Me.picBasketball13.Size = New System.Drawing.Size(100, 160)
        Me.picBasketball13.TabIndex = 20
        Me.picBasketball13.TabStop = False
        '
        'picBasketball12
        '
        Me.picBasketball12.BackgroundImage = CType(resources.GetObject("picBasketball12.BackgroundImage"), System.Drawing.Image)
        Me.picBasketball12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBasketball12.Location = New System.Drawing.Point(897, 259)
        Me.picBasketball12.Name = "picBasketball12"
        Me.picBasketball12.Size = New System.Drawing.Size(100, 160)
        Me.picBasketball12.TabIndex = 19
        Me.picBasketball12.TabStop = False
        '
        'picBasketball11
        '
        Me.picBasketball11.BackgroundImage = CType(resources.GetObject("picBasketball11.BackgroundImage"), System.Drawing.Image)
        Me.picBasketball11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBasketball11.Location = New System.Drawing.Point(897, 93)
        Me.picBasketball11.Name = "picBasketball11"
        Me.picBasketball11.Size = New System.Drawing.Size(100, 160)
        Me.picBasketball11.TabIndex = 18
        Me.picBasketball11.TabStop = False
        '
        'picBasketball10
        '
        Me.picBasketball10.BackgroundImage = CType(resources.GetObject("picBasketball10.BackgroundImage"), System.Drawing.Image)
        Me.picBasketball10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBasketball10.Location = New System.Drawing.Point(800, 259)
        Me.picBasketball10.Name = "picBasketball10"
        Me.picBasketball10.Size = New System.Drawing.Size(100, 160)
        Me.picBasketball10.TabIndex = 17
        Me.picBasketball10.TabStop = False
        '
        'picBasketball9
        '
        Me.picBasketball9.BackgroundImage = CType(resources.GetObject("picBasketball9.BackgroundImage"), System.Drawing.Image)
        Me.picBasketball9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBasketball9.Location = New System.Drawing.Point(800, 93)
        Me.picBasketball9.Name = "picBasketball9"
        Me.picBasketball9.Size = New System.Drawing.Size(100, 160)
        Me.picBasketball9.TabIndex = 16
        Me.picBasketball9.TabStop = False
        '
        'picBasketball8
        '
        Me.picBasketball8.BackgroundImage = CType(resources.GetObject("picBasketball8.BackgroundImage"), System.Drawing.Image)
        Me.picBasketball8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBasketball8.Location = New System.Drawing.Point(703, 259)
        Me.picBasketball8.Name = "picBasketball8"
        Me.picBasketball8.Size = New System.Drawing.Size(100, 160)
        Me.picBasketball8.TabIndex = 15
        Me.picBasketball8.TabStop = False
        '
        'picBasketball7
        '
        Me.picBasketball7.BackgroundImage = CType(resources.GetObject("picBasketball7.BackgroundImage"), System.Drawing.Image)
        Me.picBasketball7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBasketball7.Location = New System.Drawing.Point(703, 93)
        Me.picBasketball7.Name = "picBasketball7"
        Me.picBasketball7.Size = New System.Drawing.Size(100, 160)
        Me.picBasketball7.TabIndex = 14
        Me.picBasketball7.TabStop = False
        '
        'picBasketball6
        '
        Me.picBasketball6.BackgroundImage = CType(resources.GetObject("picBasketball6.BackgroundImage"), System.Drawing.Image)
        Me.picBasketball6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBasketball6.Location = New System.Drawing.Point(603, 259)
        Me.picBasketball6.Name = "picBasketball6"
        Me.picBasketball6.Size = New System.Drawing.Size(100, 160)
        Me.picBasketball6.TabIndex = 13
        Me.picBasketball6.TabStop = False
        '
        'picBasketball5
        '
        Me.picBasketball5.BackgroundImage = CType(resources.GetObject("picBasketball5.BackgroundImage"), System.Drawing.Image)
        Me.picBasketball5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBasketball5.Location = New System.Drawing.Point(603, 93)
        Me.picBasketball5.Name = "picBasketball5"
        Me.picBasketball5.Size = New System.Drawing.Size(100, 160)
        Me.picBasketball5.TabIndex = 12
        Me.picBasketball5.TabStop = False
        '
        'picBasketball3
        '
        Me.picBasketball3.BackgroundImage = CType(resources.GetObject("picBasketball3.BackgroundImage"), System.Drawing.Image)
        Me.picBasketball3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBasketball3.Location = New System.Drawing.Point(337, 93)
        Me.picBasketball3.Name = "picBasketball3"
        Me.picBasketball3.Size = New System.Drawing.Size(160, 100)
        Me.picBasketball3.TabIndex = 11
        Me.picBasketball3.TabStop = False
        '
        'picBasketball2
        '
        Me.picBasketball2.BackgroundImage = CType(resources.GetObject("picBasketball2.BackgroundImage"), System.Drawing.Image)
        Me.picBasketball2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBasketball2.Location = New System.Drawing.Point(180, 93)
        Me.picBasketball2.Name = "picBasketball2"
        Me.picBasketball2.Size = New System.Drawing.Size(160, 100)
        Me.picBasketball2.TabIndex = 10
        Me.picBasketball2.TabStop = False
        '
        'picBasketball4
        '
        Me.picBasketball4.BackgroundImage = CType(resources.GetObject("picBasketball4.BackgroundImage"), System.Drawing.Image)
        Me.picBasketball4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBasketball4.Location = New System.Drawing.Point(503, 93)
        Me.picBasketball4.Name = "picBasketball4"
        Me.picBasketball4.Size = New System.Drawing.Size(100, 160)
        Me.picBasketball4.TabIndex = 9
        Me.picBasketball4.TabStop = False
        '
        'picBasketball1
        '
        Me.picBasketball1.BackgroundImage = CType(resources.GetObject("picBasketball1.BackgroundImage"), System.Drawing.Image)
        Me.picBasketball1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBasketball1.Location = New System.Drawing.Point(23, 93)
        Me.picBasketball1.Name = "picBasketball1"
        Me.picBasketball1.Size = New System.Drawing.Size(160, 100)
        Me.picBasketball1.TabIndex = 7
        Me.picBasketball1.TabStop = False
        '
        'lblResults16
        '
        Me.lblResults16.AutoSize = True
        Me.lblResults16.Location = New System.Drawing.Point(78, 315)
        Me.lblResults16.Name = "lblResults16"
        Me.lblResults16.Size = New System.Drawing.Size(71, 15)
        Me.lblResults16.TabIndex = 37
        Me.lblResults16.Text = "lblInfor"
        '
        'viewBasketball
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1121, 497)
        Me.Controls.Add(Me.lblResults16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lblResults14)
        Me.Controls.Add(Me.lblResults13)
        Me.Controls.Add(Me.lblResults12)
        Me.Controls.Add(Me.lblResults11)
        Me.Controls.Add(Me.lblResults10)
        Me.Controls.Add(Me.lblResults9)
        Me.Controls.Add(Me.lblResults8)
        Me.Controls.Add(Me.lblResults7)
        Me.Controls.Add(Me.lblResults6)
        Me.Controls.Add(Me.lblResults5)
        Me.Controls.Add(Me.lblResults4)
        Me.Controls.Add(Me.lblResults3)
        Me.Controls.Add(Me.lblResults2)
        Me.Controls.Add(Me.lblResults1)
        Me.Controls.Add(Me.picBasketball14)
        Me.Controls.Add(Me.picBasketball13)
        Me.Controls.Add(Me.picBasketball12)
        Me.Controls.Add(Me.picBasketball11)
        Me.Controls.Add(Me.picBasketball10)
        Me.Controls.Add(Me.picBasketball9)
        Me.Controls.Add(Me.picBasketball8)
        Me.Controls.Add(Me.picBasketball7)
        Me.Controls.Add(Me.picBasketball6)
        Me.Controls.Add(Me.picBasketball5)
        Me.Controls.Add(Me.picBasketball3)
        Me.Controls.Add(Me.picBasketball2)
        Me.Controls.Add(Me.picBasketball4)
        Me.Controls.Add(Me.picBasketball1)
        Me.Name = "viewBasketball"
        Me.Text = "篮球场"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBasketball14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBasketball13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBasketball12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBasketball11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBasketball10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBasketball9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBasketball8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBasketball7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBasketball6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBasketball5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBasketball3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBasketball2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBasketball4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBasketball1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picBasketball1 As PictureBox
    Friend WithEvents picBasketball4 As PictureBox
    Friend WithEvents picBasketball2 As PictureBox
    Friend WithEvents picBasketball3 As PictureBox
    Friend WithEvents picBasketball5 As PictureBox
    Friend WithEvents picBasketball6 As PictureBox
    Friend WithEvents picBasketball7 As PictureBox
    Friend WithEvents picBasketball8 As PictureBox
    Friend WithEvents picBasketball9 As PictureBox
    Friend WithEvents picBasketball10 As PictureBox
    Friend WithEvents picBasketball11 As PictureBox
    Friend WithEvents picBasketball12 As PictureBox
    Friend WithEvents picBasketball13 As PictureBox
    Friend WithEvents picBasketball14 As PictureBox
    Friend WithEvents lblResults1 As Label
    Friend WithEvents lblResults2 As Label
    Friend WithEvents lblResults3 As Label
    Friend WithEvents lblResults4 As Label
    Friend WithEvents lblResults5 As Label
    Friend WithEvents lblResults6 As Label
    Friend WithEvents lblResults7 As Label
    Friend WithEvents lblResults8 As Label
    Friend WithEvents lblResults9 As Label
    Friend WithEvents lblResults10 As Label
    Friend WithEvents lblResults11 As Label
    Friend WithEvents lblResults12 As Label
    Friend WithEvents lblResults13 As Label
    Friend WithEvents lblResults14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
    Friend WithEvents OleDbSelectCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter1 As OleDb.OleDbDataAdapter
    Friend WithEvents DataSet1 As DataSet
    Friend WithEvents lblResults16 As Label
End Class
