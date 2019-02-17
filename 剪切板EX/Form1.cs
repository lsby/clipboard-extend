using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace 剪切板EX
{
    public partial class 主窗口 : Form
    {
        private int 鼠标y坐标;
        private int 鼠标滚轮参数;
        private int 剪切板最大数量 = 50;
        private int 按钮高度 = 60;
        private int 窗口高度 = 200;

        public 主窗口()
        {
            InitializeComponent();

            设置鼠标钩子();
            设置定时器();
            设置监听剪切板();
            显示();
        }
        ~主窗口()
        {
            设置取消监听剪切板();
        }

        private void 设置取消监听剪切板()
        {
            RemoveClipboardFormatListener(this.Handle);
        }

        private void 设置监听剪切板()
        {
            AddClipboardFormatListener(this.Handle);
        }

        private void 设置剪切板内容(String str)
        {
            Clipboard.SetDataObject(str, true);
        }

        void 设置鼠标钩子()
        {
            var hook = new MouseKeyHook();
            hook.OnMouseActivity += 回调_鼠标;
            hook.Start();
        }

        void 设置定时器()
        {
            Timer t = new Timer();
            t.Interval = 100;
            t.Tick += new EventHandler(回调_定时器);
            t.Enabled = true;
        }

        void 显示()
        {
            Visible = true;

            this.TopMost = true;
            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = 窗口高度;
            Location = new Point(0, 0);
            控件_sp.SplitterDistance = this.Width / 2;
        }

        void 隐藏()
        {
            Visible = false;
        }

        List<Button> 左边按钮 = new List<Button>();
        List<Button> 右边按钮 = new List<Button>();

        void 添加左边按钮(String str)
        {
            var button = new Button();
            button.Text = str;
            button.Width = 控件_左边.Width - 2;
            button.Height = 按钮高度;
            button.Margin = new Padding(0);
            button.Click += 回调_按钮点击;
            button.TextAlign = ContentAlignment.TopLeft;

            for (var i = 0; i < 左边按钮.Count; i++)
                if (左边按钮[i].Text == str)
                    左边按钮.RemoveAt(i);

            左边按钮.Insert(0, button);
            while (左边按钮.Count > 剪切板最大数量)
                左边按钮.RemoveAt(左边按钮.Count - 1);

            渲染左边();
        }

        private void 回调_按钮点击(object sender, EventArgs e)
        {
            设置剪切板内容(((Button)sender).Text);
            隐藏();
        }

        void 渲染左边()
        {
            if (控件_左边.Controls.Count == 0)
            {
                渲染左边_添加(0);
                return;
            }
            while (控件_左边.Controls[控件_左边.Controls.Count - 1].Text != 左边按钮[左边按钮.Count - 1].Text)
                控件_左边.Controls.RemoveAt(控件_左边.Controls.Count - 1);
            渲染左边_添加(0);
        }
        void 渲染左边_添加(int start)
        {
            for (var i = start; i < 左边按钮.Count; i++)
                控件_左边.Controls.Add(左边按钮[i]);
        }

        void 回调_定时器(object sender, EventArgs e)
        {
            if (!Bounds.Contains(MousePosition) && MouseButtons == MouseButtons.Left)
                隐藏();
            else if (鼠标y坐标 <= 0 && 鼠标滚轮参数 < 0)
                显示();
            else if (鼠标y坐标 <= 0 && 鼠标滚轮参数 > 0)
                隐藏();
        }

        void 回调_鼠标(object sender, MouseEventArgs e)
        {
            鼠标y坐标 = e.Y;
            鼠标滚轮参数 = e.Delta;
        }

        void 回调_剪切板()
        {
            添加左边按钮(Clipboard.GetText());
        }

        //===================================================剪切板监听
        [DllImport("user32.dll")]
        public static extern bool AddClipboardFormatListener(IntPtr hwnd);
        [DllImport("user32.dll")]
        public static extern bool RemoveClipboardFormatListener(IntPtr hwnd);

        private static int WM_CLIPBOARDUPDATE = 0x031D;

        protected override void DefWndProc(ref Message m)
        {
            if (m.Msg == WM_CLIPBOARDUPDATE)
                回调_剪切板();
            else
                base.DefWndProc(ref m);
        }
    }
}
