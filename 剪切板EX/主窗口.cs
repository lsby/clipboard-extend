using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace 剪切板EX
{
    public partial class 主窗口 : 带有剪切板回调的窗口
    {
        鼠标事件管理者 鼠标事件管理者 = null;
        剪切板事件管理者 剪切板事件管理者 = null;
        界面管理者 界面管理者 = null;

        public 主窗口()
        {
            InitializeComponent();

            var 鼠标事件管理者 = new 鼠标事件管理者();
            var 剪切板管理者 = new 剪切板事件管理者(this);
            var 界面管理者 = new 界面管理者(this);

            鼠标事件管理者.显示命令 += 界面管理者.显示窗口;
            鼠标事件管理者.隐藏命令 += 界面管理者.隐藏窗口;
            剪切板管理者.剪切板回调 += 界面管理者.剪切板区域增加;
            界面管理者.剪切板区域点击 += 剪切板管理者.设置剪切板内容;

            BeginInvoke(new Action(() => { 界面管理者.隐藏窗口(); }));
        }
    }
}
