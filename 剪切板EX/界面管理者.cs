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
        int 剪切板最大数量 = 50;

        List<String> 剪切板区域映射 = new List<string>();
        List<String> 模板区域映射 = new List<string>();

        public event Action<String> 剪切板区域点击;

        public 界面管理者(主窗口 主窗口)
        {
            this.主窗口 = 主窗口;

            foreach (var item in 主窗口.配置文件.Root.Element("config").Elements())
            {
                if (item.Name.ToString() == "剪切板最大数量")
                    剪切板最大数量 = int.Parse(item.Value);
                else if (item.Name.ToString() == "按钮高度")
                    按钮高度 = int.Parse(item.Value);
            }
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

            new List<Tuple<FlowLayoutPanel, List<String>>>
            {
                new Tuple<FlowLayoutPanel, List<string>>(主窗口.控件_左边容器,剪切板区域映射),
                new Tuple<FlowLayoutPanel, List<string>>(主窗口.控件_右边容器,模板区域映射)
            }.ForEach(容器 =>
            {
                var 控件 = 容器.Item1;
                var 映射 = 容器.Item2;

                控件.Controls.Clear();
                映射.ForEach((data) =>
                {
                    var button = new Button();
                    button.Text = data;
                    button.Width = 控件.Width - 2;
                    button.Height = 按钮高度;
                    button.Margin = new Padding(0);
                    button.Click += new EventHandler((object obj, EventArgs e) => 剪切板区域点击(data));
                    button.Click += new EventHandler((object obj, EventArgs e) => 隐藏窗口());
                    button.TextAlign = ContentAlignment.TopLeft;
                    控件.Controls.Add(button);
                });
            });
        }

        internal void 添加模板列表(List<string> arr)
        {
            arr.ForEach(s => 模板区域映射.Add(s));
        }

        public void 隐藏窗口()
        {
            if (主窗口.Visible == false) return;

            主窗口.Visible = false;
        }
        public void 剪切板区域增加(String data)
        {
            if (剪切板区域映射.Count > 0 && 剪切板区域映射[0] == data) return;
            剪切板区域映射.Insert(0, data);
            剪切板区域映射 = 剪切板区域映射.Take(剪切板最大数量 + 1).ToList();
        }
    }
}
