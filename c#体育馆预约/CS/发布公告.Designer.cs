namespace WindowsApp1
{
    partial class 发布公告
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bulletinTitle = new System.Windows.Forms.TextBox();
            this.bulletin = new System.Windows.Forms.RichTextBox();
            this.submit = new System.Windows.Forms.Button();
            this.oldContent = new System.Windows.Forms.RichTextBox();
            this.gridtitle = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridtitle)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(431, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "公告发布界面";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(34, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "标题：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(34, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "公告内容：";
            // 
            // bulletinTitle
            // 
            this.bulletinTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.bulletinTitle.Location = new System.Drawing.Point(38, 138);
            this.bulletinTitle.Name = "bulletinTitle";
            this.bulletinTitle.Size = new System.Drawing.Size(224, 21);
            this.bulletinTitle.TabIndex = 3;
            // 
            // bulletin
            // 
            this.bulletin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bulletin.Location = new System.Drawing.Point(38, 232);
            this.bulletin.Name = "bulletin";
            this.bulletin.Size = new System.Drawing.Size(224, 261);
            this.bulletin.TabIndex = 4;
            this.bulletin.Text = "";
            // 
            // submit
            // 
            this.submit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.submit.Location = new System.Drawing.Point(116, 527);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 5;
            this.submit.Text = "发布";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // oldContent
            // 
            this.oldContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.oldContent.Location = new System.Drawing.Point(1131, 187);
            this.oldContent.Name = "oldContent";
            this.oldContent.Size = new System.Drawing.Size(244, 456);
            this.oldContent.TabIndex = 6;
            this.oldContent.Text = "";
            // 
            // gridtitle
            // 
            this.gridtitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gridtitle.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridtitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridtitle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridtitle.Location = new System.Drawing.Point(855, 187);
            this.gridtitle.Name = "gridtitle";
            this.gridtitle.RowTemplate.Height = 23;
            this.gridtitle.Size = new System.Drawing.Size(245, 456);
            this.gridtitle.TabIndex = 7;
            this.gridtitle.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridtitle_CellMouseDown);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(858, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 46);
            this.label4.TabIndex = 8;
            this.label4.Text = "往期公告：";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.submit);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bulletinTitle);
            this.groupBox1.Controls.Add(this.bulletin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(400, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 571);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // 发布公告
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1720, 862);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gridtitle);
            this.Controls.Add(this.oldContent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "发布公告";
            this.Opacity = 0.5D;
            this.Text = "发布公告";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.发布公告_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridtitle)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bulletinTitle;
        private System.Windows.Forms.RichTextBox bulletin;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.RichTextBox oldContent;
        private System.Windows.Forms.DataGridView gridtitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}