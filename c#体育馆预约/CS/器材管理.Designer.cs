namespace WindowsApp1
{
    partial class 器材管理
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnSelectVenue = new System.Windows.Forms.Button();
            this.btnSelectLease = new System.Windows.Forms.Button();
            this.btnInsertVtype = new System.Windows.Forms.Button();
            this.btnSelectVtype = new System.Windows.Forms.Button();
            this.btnInsertVenue = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GroupBox1.Controls.Add(this.btnReturn);
            this.GroupBox1.Controls.Add(this.btnSelectVenue);
            this.GroupBox1.Controls.Add(this.btnSelectLease);
            this.GroupBox1.Controls.Add(this.btnInsertVtype);
            this.GroupBox1.Controls.Add(this.btnSelectVtype);
            this.GroupBox1.Controls.Add(this.btnInsertVenue);
            this.GroupBox1.Font = new System.Drawing.Font("宋体", 48F);
            this.GroupBox1.Location = new System.Drawing.Point(218, 59);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.GroupBox1.Size = new System.Drawing.Size(1043, 500);
            this.GroupBox1.TabIndex = 6;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "场地管理系统";
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReturn.Font = new System.Drawing.Font("宋体", 24F);
            this.btnReturn.Location = new System.Drawing.Point(650, 377);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(242, 100);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "退出";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // btnSelectVenue
            // 
            this.btnSelectVenue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSelectVenue.Font = new System.Drawing.Font("宋体", 24F);
            this.btnSelectVenue.Location = new System.Drawing.Point(158, 273);
            this.btnSelectVenue.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectVenue.Name = "btnSelectVenue";
            this.btnSelectVenue.Size = new System.Drawing.Size(242, 100);
            this.btnSelectVenue.TabIndex = 0;
            this.btnSelectVenue.Text = "查询场地类型";
            this.btnSelectVenue.UseVisualStyleBackColor = true;
            // 
            // btnSelectLease
            // 
            this.btnSelectLease.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSelectLease.Font = new System.Drawing.Font("宋体", 24F);
            this.btnSelectLease.Location = new System.Drawing.Point(650, 273);
            this.btnSelectLease.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectLease.Name = "btnSelectLease";
            this.btnSelectLease.Size = new System.Drawing.Size(242, 100);
            this.btnSelectLease.TabIndex = 2;
            this.btnSelectLease.Text = "查询场地租借情况";
            this.btnSelectLease.UseVisualStyleBackColor = true;
            // 
            // btnInsertVtype
            // 
            this.btnInsertVtype.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnInsertVtype.Font = new System.Drawing.Font("宋体", 24F);
            this.btnInsertVtype.Location = new System.Drawing.Point(404, 377);
            this.btnInsertVtype.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsertVtype.Name = "btnInsertVtype";
            this.btnInsertVtype.Size = new System.Drawing.Size(242, 100);
            this.btnInsertVtype.TabIndex = 4;
            this.btnInsertVtype.Text = "添加场地信息";
            this.btnInsertVtype.UseVisualStyleBackColor = true;
            // 
            // btnSelectVtype
            // 
            this.btnSelectVtype.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSelectVtype.Font = new System.Drawing.Font("宋体", 24F);
            this.btnSelectVtype.Location = new System.Drawing.Point(404, 273);
            this.btnSelectVtype.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectVtype.Name = "btnSelectVtype";
            this.btnSelectVtype.Size = new System.Drawing.Size(242, 100);
            this.btnSelectVtype.TabIndex = 1;
            this.btnSelectVtype.Text = "查询场地信息";
            this.btnSelectVtype.UseVisualStyleBackColor = true;
            // 
            // btnInsertVenue
            // 
            this.btnInsertVenue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnInsertVenue.Font = new System.Drawing.Font("宋体", 24F);
            this.btnInsertVenue.Location = new System.Drawing.Point(158, 377);
            this.btnInsertVenue.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsertVenue.Name = "btnInsertVenue";
            this.btnInsertVenue.Size = new System.Drawing.Size(242, 100);
            this.btnInsertVenue.TabIndex = 3;
            this.btnInsertVenue.Text = "添加场地类型";
            this.btnInsertVenue.UseVisualStyleBackColor = true;
            // 
            // 器材管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 845);
            this.Controls.Add(this.GroupBox1);
            this.Name = "器材管理";
            this.Text = "器材管理";
            this.Load += new System.EventHandler(this.器材管理_Load);
            this.GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button btnReturn;
        internal System.Windows.Forms.Button btnSelectVenue;
        internal System.Windows.Forms.Button btnSelectLease;
        internal System.Windows.Forms.Button btnInsertVtype;
        internal System.Windows.Forms.Button btnSelectVtype;
        internal System.Windows.Forms.Button btnInsertVenue;
    }
}