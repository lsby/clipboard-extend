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
            this.控件_左边 = new System.Windows.Forms.FlowLayoutPanel();
            this.控件_右边 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.控件_sp)).BeginInit();
            this.控件_sp.Panel1.SuspendLayout();
            this.控件_sp.Panel2.SuspendLayout();
            this.控件_sp.SuspendLayout();
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
            this.控件_sp.Panel1.Controls.Add(this.控件_左边);
            // 
            // 控件_sp.Panel2
            // 
            this.控件_sp.Panel2.Controls.Add(this.控件_右边);
            this.控件_sp.Size = new System.Drawing.Size(870, 105);
            this.控件_sp.SplitterDistance = 458;
            this.控件_sp.TabIndex = 0;
            // 
            // 控件_左边
            // 
            this.控件_左边.AutoScroll = true;
            this.控件_左边.AutoSize = true;
            this.控件_左边.Dock = System.Windows.Forms.DockStyle.Fill;
            this.控件_左边.Location = new System.Drawing.Point(0, 0);
            this.控件_左边.Margin = new System.Windows.Forms.Padding(0);
            this.控件_左边.Name = "控件_左边";
            this.控件_左边.Size = new System.Drawing.Size(458, 105);
            this.控件_左边.TabIndex = 0;
            // 
            // 控件_右边
            // 
            this.控件_右边.AutoScroll = true;
            this.控件_右边.Dock = System.Windows.Forms.DockStyle.Fill;
            this.控件_右边.Location = new System.Drawing.Point(0, 0);
            this.控件_右边.Name = "控件_右边";
            this.控件_右边.Size = new System.Drawing.Size(408, 105);
            this.控件_右边.TabIndex = 0;
            // 
            // 主窗口
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 105);
            this.Controls.Add(this.控件_sp);
            this.Name = "主窗口";
            this.Text = "ClipboardEx";
            this.控件_sp.Panel1.ResumeLayout(false);
            this.控件_sp.Panel1.PerformLayout();
            this.控件_sp.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.控件_sp)).EndInit();
            this.控件_sp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer 控件_sp;
        private System.Windows.Forms.FlowLayoutPanel 控件_左边;
        private System.Windows.Forms.FlowLayoutPanel 控件_右边;
    }
}

