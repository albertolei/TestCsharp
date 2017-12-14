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
            //Test t = new Test();
            //t.名称 = "雷刚";
            //t.修改名称("alberto");
            //Console.WriteLine(t.名称);
            //Console.Read();
            //Person1 p1 = new Person1();
            //p1.name = "alberto";
            //Person2 p2 = new Person2();
            //p2.Name = "lleigang";
            //Console.WriteLine(p1.name + ", " + p2.Name);
            //Console.Read();
            TestVar tv = new TestVar();
            tv.testVar();
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
    class Person1 //Field字段
    {
        public string name;
    }
    class Person2 //Property属性
    {
        private string name;
        public string Name
        {
            get 
            {
                return this.name;
            }
            set
            {
                if(value!="leigang")
                {
                    this.name = "not leigang";
                }
                else
                {
                    this.name = value;
                }
            }
        }
    }

    class TestVar
    {
        public void testVar()
        {
            var name = 12f;
            name = 43;
            Console.WriteLine(name + ", " + name.GetType());//输入 43, System.Single
        }
    }
}
