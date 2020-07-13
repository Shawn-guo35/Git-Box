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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSelectLease = new System.Windows.Forms.Button();
            this.btnInsertVtype = new System.Windows.Forms.Button();
            this.btnInsertVenue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(470, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(734, 392);
            this.dataGridView1.TabIndex = 9;
            // 
            // btnSelectLease
            // 
            this.btnSelectLease.Font = new System.Drawing.Font("宋体", 12F);
            this.btnSelectLease.Location = new System.Drawing.Point(962, 106);
            this.btnSelectLease.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectLease.Name = "btnSelectLease";
            this.btnSelectLease.Size = new System.Drawing.Size(242, 100);
            this.btnSelectLease.TabIndex = 6;
            this.btnSelectLease.Text = "查询器材租借情况";
            this.btnSelectLease.UseVisualStyleBackColor = true;
            this.btnSelectLease.Click += new System.EventHandler(this.btnSelectLease_Click_1);
            // 
            // btnInsertVtype
            // 
            this.btnInsertVtype.Font = new System.Drawing.Font("宋体", 12F);
            this.btnInsertVtype.Location = new System.Drawing.Point(716, 106);
            this.btnInsertVtype.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsertVtype.Name = "btnInsertVtype";
            this.btnInsertVtype.Size = new System.Drawing.Size(242, 100);
            this.btnInsertVtype.TabIndex = 8;
            this.btnInsertVtype.Text = "修改器材信息";
            this.btnInsertVtype.UseVisualStyleBackColor = true;
            this.btnInsertVtype.Click += new System.EventHandler(this.btnInsertVtype_Click_1);
            // 
            // btnInsertVenue
            // 
            this.btnInsertVenue.Font = new System.Drawing.Font("宋体", 12F);
            this.btnInsertVenue.Location = new System.Drawing.Point(470, 106);
            this.btnInsertVenue.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsertVenue.Name = "btnInsertVenue";
            this.btnInsertVenue.Size = new System.Drawing.Size(242, 100);
            this.btnInsertVenue.TabIndex = 7;
            this.btnInsertVenue.Text = "添加器材类型";
            this.btnInsertVenue.UseVisualStyleBackColor = true;
            this.btnInsertVenue.Click += new System.EventHandler(this.btnInsertVenue_Click_1);
            // 
            // 器材管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1720, 862);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSelectLease);
            this.Controls.Add(this.btnInsertVtype);
            this.Controls.Add(this.btnInsertVenue);
            this.Name = "器材管理";
            this.Text = "器材管理";
            this.Load += new System.EventHandler(this.器材管理_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.Button btnSelectLease;
        internal System.Windows.Forms.Button btnInsertVtype;
        internal System.Windows.Forms.Button btnInsertVenue;
    }
}