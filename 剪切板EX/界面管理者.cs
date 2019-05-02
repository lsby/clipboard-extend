using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 剪切板EX
{
    class 界面管理者
    {
        private 主窗口 主窗口;

        int 按钮高度 = 50;
        int 剪切板最大值 = 50;

        List<String> 剪切板区域映射 = new List<string>();

        public event Action<String> 剪切板区域点击;

        public 界面管理者(主窗口 主窗口)
        {
            this.主窗口 = 主窗口;
        }

        public void 显示窗口()
        {
            if (主窗口.Visible == true) return;

            主窗口.Visible = true;
            主窗口.TopMost = true;
            主窗口.Width = Screen.PrimaryScreen.Bounds.Width;
            主窗口.Height = Screen.PrimaryScreen.Bounds.Height;
            主窗口.Location = new Point(0, 0);
            主窗口.控件_sp.SplitterDistance = 主窗口.Width / 2;

            主窗口.控件_左边容器.Controls.Clear();
            剪切板区域映射.ForEach((data) =>
            {
                var button = new Button();
                button.Text = data;
                button.Width = 主窗口.控件_左边容器.Width - 2;
                button.Height = 按钮高度;
                button.Margin = new Padding(0);
                button.Click += new EventHandler((object obj, EventArgs e) => 剪切板区域点击(data));
                button.TextAlign = ContentAlignment.TopLeft;
                主窗口.控件_左边容器.Controls.Add(button);
            });
        }
        public void 隐藏窗口()
        {
            if (主窗口.Visible == false) return;

            主窗口.Visible = false;
        }
        public void 剪切板区域增加(String data)
        {
            剪切板区域映射.Insert(0, data);
            剪切板区域映射 = 剪切板区域映射.Take(剪切板最大值 + 1).ToList();
        }
    }
}
