namespace 剪切板EX
{
    partial class 主窗口
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.控件_sp = new System.Windows.Forms.SplitContainer();
            this.控件_左边容器 = new System.Windows.Forms.FlowLayoutPanel();
            this.控件_右边容器 = new System.Windows.Forms.FlowLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.控件_文本框 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.控件_sp)).BeginInit();
            this.控件_sp.Panel1.SuspendLayout();
            this.控件_sp.Panel2.SuspendLayout();
            this.控件_sp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // 控件_sp
            // 
            this.控件_sp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.控件_sp.Location = new System.Drawing.Point(0, 0);
            this.控件_sp.Name = "控件_sp";
            // 
            // 控件_sp.Panel1
            // 
            this.控件_sp.Panel1.Controls.Add(this.控件_左边容器);
            // 
            // 控件_sp.Panel2
            // 
            this.控件_sp.Panel2.Controls.Add(this.控件_右边容器);
            this.控件_sp.Size = new System.Drawing.Size(870, 98);
            this.控件_sp.SplitterDistance = 458;
            this.控件_sp.TabIndex = 0;
            // 
            // 控件_左边
            // 
            this.控件_左边容器.AutoScroll = true;
            this.控件_左边容器.AutoSize = true;
            this.控件_左边容器.Dock = System.Windows.Forms.DockStyle.Fill;
            this.控件_左边容器.Location = new System.Drawing.Point(0, 0);
            this.控件_左边容器.Margin = new System.Windows.Forms.Padding(0);
            this.控件_左边容器.Name = "控件_左边";
            this.控件_左边容器.Size = new System.Drawing.Size(458, 98);
            this.控件_左边容器.TabIndex = 0;
            // 
            // 控件_右边
            // 
            this.控件_右边容器.AutoScroll = true;
            this.控件_右边容器.Dock = System.Windows.Forms.DockStyle.Fill;
            this.控件_右边容器.Location = new System.Drawing.Point(0, 0);
            this.控件_右边容器.Name = "控件_右边";
            this.控件_右边容器.Size = new System.Drawing.Size(408, 98);
            this.控件_右边容器.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.控件_sp);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.控件_文本框);
            this.splitContainer1.Size = new System.Drawing.Size(870, 250);
            this.splitContainer1.SplitterDistance = 98;
            this.splitContainer1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.控件_文本框.Dock = System.Windows.Forms.DockStyle.Fill;
            this.控件_文本框.Location = new System.Drawing.Point(0, 0);
            this.控件_文本框.MaxLength = 0;
            this.控件_文本框.Multiline = true;
            this.控件_文本框.Name = "textBox1";
            this.控件_文本框.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.控件_文本框.Size = new System.Drawing.Size(870, 148);
            this.控件_文本框.TabIndex = 0;
            // 
            // 主窗口
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 250);
            this.Controls.Add(this.splitContainer1);
            this.Name = "主窗口";
            this.Text = "ClipboardEx";
            this.控件_sp.Panel1.ResumeLayout(false);
            this.控件_sp.Panel1.PerformLayout();
            this.控件_sp.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.控件_sp)).EndInit();
            this.控件_sp.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.SplitContainer 控件_sp;
        public System.Windows.Forms.FlowLayoutPanel 控件_左边容器;
        public System.Windows.Forms.FlowLayoutPanel 控件_右边容器;
        public System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.TextBox 控件_文本框;
    }
}

