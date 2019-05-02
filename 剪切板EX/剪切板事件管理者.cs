using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace 剪切板EX
{
    class 剪切板事件管理者
    {
        public event Action<String> 剪切板回调;

        private 主窗口 主窗口;

        public 剪切板事件管理者(主窗口 主窗口)
        {
            this.主窗口 = 主窗口;

            主窗口.AddClipboardFormatListener(主窗口.Handle);

            主窗口.剪切板回调 += new Action(() =>
              {
                  剪切板回调(Clipboard.GetText());
              });
        }
        ~剪切板事件管理者()
        {
            主窗口.RemoveClipboardFormatListener(主窗口.Handle);
        }

        public void 设置剪切板内容(String str)
        {
            Clipboard.SetDataObject(str, true);
        }
    }
}
