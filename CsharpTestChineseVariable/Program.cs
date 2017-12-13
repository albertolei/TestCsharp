using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTestChineseVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            t.名称 = "雷刚";
            t.修改名称("alberto");
            Console.WriteLine(t.名称);
            Console.Read();
        }
    }
    class Test
    {
        public string 名称;
        public void 修改名称(string 新名称)
        {
            this.名称 = 新名称;
        }
    }
}
