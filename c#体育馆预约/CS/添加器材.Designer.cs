namespace WindowsApp1
{
    partial class 添加器材
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
            this.gvwEq = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEqname = new System.Windows.Forms.TextBox();
            this.txtEqrank = new System.Windows.Forms.TextBox();
            this.txtEqtotal = new System.Windows.Forms.TextBox();
            this.txtEqdeposit = new System.Windows.Forms.TextBox();
            this.txtEqramk = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvwEq)).BeginInit();
            this.SuspendLayout();
            // 
            // gvwEq
            // 
            this.gvwEq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvwEq.Location = new System.Drawing.Point(521, 384);
            this.gvwEq.Name = "gvwEq";
            this.gvwEq.RowTemplate.Height = 23;
            this.gvwEq.Size = new System.Drawing.Size(672, 272);
            this.gvwEq.TabIndex = 0;
            this.gvwEq.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(580, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "器材名称";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(580, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "器材总数";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(578, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "租借价格";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(897, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "押金金额";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(897, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "器材备注";
            // 
            // txtEqname
            // 
            this.txtEqname.Location = new System.Drawing.Point(681, 165);
            this.txtEqname.Name = "txtEqname";
            this.txtEqname.Size = new System.Drawing.Size(100, 21);
            this.txtEqname.TabIndex = 6;
            // 
            // txtEqrank
            // 
            this.txtEqrank.Location = new System.Drawing.Point(681, 230);
            this.txtEqrank.Name = "txtEqrank";
            this.txtEqrank.Size = new System.Drawing.Size(100, 21);
            this.txtEqrank.TabIndex = 7;
            // 
            // txtEqtotal
            // 
            this.txtEqtotal.Location = new System.Drawing.Point(681, 305);
            this.txtEqtotal.Name = "txtEqtotal";
            this.txtEqtotal.Size = new System.Drawing.Size(100, 21);
            this.txtEqtotal.TabIndex = 8;
            // 
            // txtEqdeposit
            // 
            this.txtEqdeposit.Location = new System.Drawing.Point(998, 162);
            this.txtEqdeposit.Name = "txtEqdeposit";
            this.txtEqdeposit.Size = new System.Drawing.Size(100, 21);
            this.txtEqdeposit.TabIndex = 9;
            // 
            // txtEqramk
            // 
            this.txtEqramk.Location = new System.Drawing.Point(998, 223);
            this.txtEqramk.Name = "txtEqramk";
            this.txtEqramk.Size = new System.Drawing.Size(100, 21);
            this.txtEqramk.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(899, 303);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // 添加器材
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1720, 862);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtEqramk);
            this.Controls.Add(this.txtEqdeposit);
            this.Controls.Add(this.txtEqtotal);
            this.Controls.Add(this.txtEqrank);
            this.Controls.Add(this.txtEqname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvwEq);
            this.Name = "添加器材";
            this.Text = "添加器材";
            this.Load += new System.EventHandler(this.添加器材_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvwEq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvwEq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEqname;
        private System.Windows.Forms.TextBox txtEqrank;
        private System.Windows.Forms.TextBox txtEqtotal;
        private System.Windows.Forms.TextBox txtEqdeposit;
        private System.Windows.Forms.TextBox txtEqramk;
        private System.Windows.Forms.Button btnAdd;
    }
}