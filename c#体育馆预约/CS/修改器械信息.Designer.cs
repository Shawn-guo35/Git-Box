namespace WindowsApp1
{
    partial class 修改器械信息
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnInsertEq = new System.Windows.Forms.Button();
            this.txtCondition = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnDeleteEq = new System.Windows.Forms.Button();
            this.btnUpdateEq = new System.Windows.Forms.Button();
            this.DataGridView2 = new System.Windows.Forms.DataGridView();
            this.gvwEq = new System.Windows.Forms.DataGridView();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwEq)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GroupBox1.AutoSize = true;
            this.GroupBox1.Controls.Add(this.btnClose);
            this.GroupBox1.Controls.Add(this.btnInsertEq);
            this.GroupBox1.Controls.Add(this.txtCondition);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.btnDeleteEq);
            this.GroupBox1.Controls.Add(this.btnUpdateEq);
            this.GroupBox1.Controls.Add(this.DataGridView2);
            this.GroupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GroupBox1.Location = new System.Drawing.Point(541, 97);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.GroupBox1.Size = new System.Drawing.Size(615, 183);
            this.GroupBox1.TabIndex = 2;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "器材管理系统";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(500, 86);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 41);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "退出";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnInsertEq
            // 
            this.btnInsertEq.Location = new System.Drawing.Point(388, 86);
            this.btnInsertEq.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsertEq.Name = "btnInsertEq";
            this.btnInsertEq.Size = new System.Drawing.Size(80, 41);
            this.btnInsertEq.TabIndex = 7;
            this.btnInsertEq.Text = "查询";
            this.btnInsertEq.UseVisualStyleBackColor = true;
            this.btnInsertEq.Click += new System.EventHandler(this.btnInsertEq_Click);
            // 
            // txtCondition
            // 
            this.txtCondition.Location = new System.Drawing.Point(255, 106);
            this.txtCondition.Margin = new System.Windows.Forms.Padding(2);
            this.txtCondition.Multiline = true;
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.Size = new System.Drawing.Size(102, 21);
            this.txtCondition.TabIndex = 6;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(278, 81);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(72, 16);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "器材名称";
            // 
            // btnDeleteEq
            // 
            this.btnDeleteEq.Location = new System.Drawing.Point(103, 90);
            this.btnDeleteEq.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteEq.Name = "btnDeleteEq";
            this.btnDeleteEq.Size = new System.Drawing.Size(51, 33);
            this.btnDeleteEq.TabIndex = 2;
            this.btnDeleteEq.Text = "删除";
            this.btnDeleteEq.UseVisualStyleBackColor = true;
            this.btnDeleteEq.Click += new System.EventHandler(this.btnDeleteEq_Click);
            // 
            // btnUpdateEq
            // 
            this.btnUpdateEq.Location = new System.Drawing.Point(4, 90);
            this.btnUpdateEq.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateEq.Name = "btnUpdateEq";
            this.btnUpdateEq.Size = new System.Drawing.Size(49, 33);
            this.btnUpdateEq.TabIndex = 1;
            this.btnUpdateEq.Text = "修改";
            this.btnUpdateEq.UseVisualStyleBackColor = true;
            this.btnUpdateEq.Click += new System.EventHandler(this.btnUpdateEq_Click);
            // 
            // DataGridView2
            // 
            this.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView2.Location = new System.Drawing.Point(592, 152);
            this.DataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridView2.Name = "DataGridView2";
            this.DataGridView2.RowTemplate.Height = 27;
            this.DataGridView2.Size = new System.Drawing.Size(8, 8);
            this.DataGridView2.TabIndex = 2;
            // 
            // gvwEq
            // 
            this.gvwEq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gvwEq.BackgroundColor = System.Drawing.Color.Silver;
            this.gvwEq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvwEq.Location = new System.Drawing.Point(455, 297);
            this.gvwEq.Margin = new System.Windows.Forms.Padding(2);
            this.gvwEq.Name = "gvwEq";
            this.gvwEq.RowTemplate.Height = 27;
            this.gvwEq.Size = new System.Drawing.Size(811, 468);
            this.gvwEq.TabIndex = 3;
            // 
            // 修改器械信息
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1720, 862);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.gvwEq);
            this.Name = "修改器械信息";
            this.Text = "修改器械信息";
            this.Load += new System.EventHandler(this.修改器械信息_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwEq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Button btnInsertEq;
        internal System.Windows.Forms.TextBox txtCondition;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button btnDeleteEq;
        internal System.Windows.Forms.Button btnUpdateEq;
        internal System.Windows.Forms.DataGridView DataGridView2;
        internal System.Windows.Forms.DataGridView gvwEq;
    }
}