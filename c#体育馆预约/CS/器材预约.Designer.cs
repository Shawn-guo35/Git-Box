namespace WindowsApp1
{
    partial class 器材预约
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
            this.txtEndtime = new System.Windows.Forms.TextBox();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.cmbEqintime = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnSubmit2 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtEqmnum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEndtime
            // 
            this.txtEndtime.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtEndtime.Location = new System.Drawing.Point(908, 620);
            this.txtEndtime.Margin = new System.Windows.Forms.Padding(2);
            this.txtEndtime.Name = "txtEndtime";
            this.txtEndtime.Size = new System.Drawing.Size(92, 24);
            this.txtEndtime.TabIndex = 37;
            // 
            // dtpTime
            // 
            this.dtpTime.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpTime.Location = new System.Drawing.Point(543, 604);
            this.dtpTime.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTime.MinDate = new System.DateTime(2019, 7, 2, 0, 0, 0, 0);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(151, 24);
            this.dtpTime.TabIndex = 36;
            // 
            // cmbEqintime
            // 
            this.cmbEqintime.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbEqintime.FormattingEnabled = true;
            this.cmbEqintime.Items.AddRange(new object[] {
            "12:00",
            "13:00",
            "18:00",
            "19:00"});
            this.cmbEqintime.Location = new System.Drawing.Point(908, 588);
            this.cmbEqintime.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEqintime.Name = "cmbEqintime";
            this.cmbEqintime.Size = new System.Drawing.Size(92, 22);
            this.cmbEqintime.TabIndex = 35;
            this.cmbEqintime.Text = "12:00";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2.Location = new System.Drawing.Point(776, 622);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(99, 20);
            this.Label2.TabIndex = 34;
            this.Label2.Text = "租借结束时间";
            // 
            // btnSubmit2
            // 
            this.btnSubmit2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSubmit2.Location = new System.Drawing.Point(1079, 604);
            this.btnSubmit2.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit2.Name = "btnSubmit2";
            this.btnSubmit2.Size = new System.Drawing.Size(56, 22);
            this.btnSubmit2.TabIndex = 33;
            this.btnSubmit2.Text = "确定";
            this.btnSubmit2.UseVisualStyleBackColor = true;
            this.btnSubmit2.Click += new System.EventHandler(this.btnSubmit2_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label1.Location = new System.Drawing.Point(776, 588);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(99, 20);
            this.Label1.TabIndex = 31;
            this.Label1.Text = "租借开始时间";
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AllowUserToDeleteRows = false;
            this.dgvOrder.ColumnHeadersHeight = 40;
            this.dgvOrder.Location = new System.Drawing.Point(509, 241);
            this.dgvOrder.Margin = new System.Windows.Forms.Padding(2);
            this.dgvOrder.MultiSelect = false;
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.RowTemplate.Height = 27;
            this.dgvOrder.Size = new System.Drawing.Size(613, 278);
            this.dgvOrder.TabIndex = 30;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label4.Location = new System.Drawing.Point(507, 552);
            this.Label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(69, 20);
            this.Label4.TabIndex = 29;
            this.Label4.Text = "租借数量";
            // 
            // txtEqmnum
            // 
            this.txtEqmnum.Location = new System.Drawing.Point(597, 555);
            this.txtEqmnum.Name = "txtEqmnum";
            this.txtEqmnum.Size = new System.Drawing.Size(64, 21);
            this.txtEqmnum.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(681, 560);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 41;
            this.label5.Text = "label5";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(776, 552);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "租借人账号：";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(908, 551);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(153, 21);
            this.txtOrderID.TabIndex = 43;
            // 
            // 器材预约
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1720, 862);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEqmnum);
            this.Controls.Add(this.txtEndtime);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.cmbEqintime);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.btnSubmit2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.Label4);
            this.Name = "器材预约";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.器材预约_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.TextBox txtEndtime;
        internal System.Windows.Forms.DateTimePicker dtpTime;
        internal System.Windows.Forms.ComboBox cmbEqintime;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button btnSubmit2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.DataGridView dgvOrder;
        internal System.Windows.Forms.Label Label4;
        private System.Windows.Forms.TextBox txtEqmnum;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOrderID;
    }
}