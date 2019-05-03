using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace 剪切板EX
{
    class 模板文本管理者
    {
        private 主窗口 主窗口;
        public event Action<List<String>> 模板列表加载完毕;

        public 模板文本管理者(主窗口 主窗口)
        {
            this.主窗口 = 主窗口;
        }

        public void 设置模板()
        {
            var arr = new List<String>();
            foreach (var item in 主窗口.配置文件.Root.Element("template").Elements())
                arr.Add(item.Value);
            模板列表加载完毕(arr);
        }
    }
}
