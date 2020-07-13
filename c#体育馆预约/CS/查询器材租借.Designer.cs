namespace WindowsApp1
{
    partial class 查询器材租借
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
            this.btnInsertEql = new System.Windows.Forms.Button();
            this.txtCondition = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnUpdateEql = new System.Windows.Forms.Button();
            this.DataGridView2 = new System.Windows.Forms.DataGridView();
            this.gvwEql = new System.Windows.Forms.DataGridView();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwEql)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GroupBox1.AutoSize = true;
            this.GroupBox1.Controls.Add(this.btnClose);
            this.GroupBox1.Controls.Add(this.btnInsertEql);
            this.GroupBox1.Controls.Add(this.txtCondition);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.btnUpdateEql);
            this.GroupBox1.Controls.Add(this.DataGridView2);
            this.GroupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GroupBox1.Location = new System.Drawing.Point(541, 97);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.GroupBox1.Size = new System.Drawing.Size(615, 191);
            this.GroupBox1.TabIndex = 2;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "查询器材租借";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(365, 82);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 41);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "退出";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnInsertEql
            // 
            this.btnInsertEql.Location = new System.Drawing.Point(253, 82);
            this.btnInsertEql.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsertEql.Name = "btnInsertEql";
            this.btnInsertEql.Size = new System.Drawing.Size(80, 41);
            this.btnInsertEql.TabIndex = 7;
            this.btnInsertEql.Text = "查询";
            this.btnInsertEql.UseVisualStyleBackColor = true;
            this.btnInsertEql.Click += new System.EventHandler(this.btnInsertEql_Click);
            // 
            // txtCondition
            // 
            this.txtCondition.Location = new System.Drawing.Point(120, 102);
            this.txtCondition.Margin = new System.Windows.Forms.Padding(2);
            this.txtCondition.Multiline = true;
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.Size = new System.Drawing.Size(102, 21);
            this.txtCondition.TabIndex = 6;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(143, 77);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(72, 16);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "器材名称";
            // 
            // btnUpdateEql
            // 
            this.btnUpdateEql.Location = new System.Drawing.Point(253, 127);
            this.btnUpdateEql.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateEql.Name = "btnUpdateEql";
            this.btnUpdateEql.Size = new System.Drawing.Size(80, 41);
            this.btnUpdateEql.TabIndex = 1;
            this.btnUpdateEql.Text = "修改";
            this.btnUpdateEql.UseVisualStyleBackColor = true;
            this.btnUpdateEql.Click += new System.EventHandler(this.btnUpdateUsers_Click);
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
            // gvwEql
            // 
            this.gvwEql.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gvwEql.BackgroundColor = System.Drawing.Color.Silver;
            this.gvwEql.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvwEql.Location = new System.Drawing.Point(455, 297);
            this.gvwEql.Margin = new System.Windows.Forms.Padding(2);
            this.gvwEql.Name = "gvwEql";
            this.gvwEql.RowTemplate.Height = 27;
            this.gvwEql.Size = new System.Drawing.Size(811, 468);
            this.gvwEql.TabIndex = 3;
            // 
            // 查询器材租借
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1720, 862);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.gvwEql);
            this.Name = "查询器材租借";
            this.Text = "查询器材租借";
            this.Load += new System.EventHandler(this.查询器材租借_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwEql)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Button btnInsertEql;
        internal System.Windows.Forms.TextBox txtCondition;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button btnUpdateEql;
        internal System.Windows.Forms.DataGridView DataGridView2;
        internal System.Windows.Forms.DataGridView gvwEql;
    }
}