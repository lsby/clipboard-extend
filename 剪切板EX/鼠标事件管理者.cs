using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 剪切板EX
{
    class 鼠标事件管理者
    {
        public event Action 显示命令;
        public event Action 隐藏命令;

        鼠标键盘钩子 鼠标键盘钩子 = null;
        Timer 轮询定时器 = null;

        public 鼠标事件管理者()
        {
            int 鼠标y坐标 = 0;
            int 鼠标滚轮参数 = 0;

            鼠标键盘钩子 = new 鼠标键盘钩子();
            鼠标键盘钩子.OnMouseActivity += new MouseEventHandler((object sender, MouseEventArgs e) =>
            {
                鼠标y坐标 = e.Y;
                鼠标滚轮参数 = e.Delta;
            });
            鼠标键盘钩子.Start();

            轮询定时器 = new Timer();
            轮询定时器.Interval = 100;
            轮询定时器.Tick += new EventHandler(new EventHandler((object sender, EventArgs e) =>
            {
                if (鼠标y坐标 != 0)
                    return;
                if (鼠标滚轮参数 < 0)
                    显示命令();
                if (鼠标滚轮参数 > 0)
                    隐藏命令();
            }));
            轮询定时器.Enabled = true;
        }

        ~鼠标事件管理者()
        {
            鼠标键盘钩子.Stop();
            轮询定时器.Stop();
        }
    }
}
