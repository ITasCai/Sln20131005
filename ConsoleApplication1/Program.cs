using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Person();
            //p.

            #region 通过反射调用私有成员
            //Type typePerson = typeof(Person);

            ////通过这种方式就可以调用到那些私有成员。
            //MethodInfo method = typePerson.GetMethod("SayHi", BindingFlags.NonPublic | BindingFlags.Instance);
            //object obj = Activator.CreateInstance(typePerson);
            //method.Invoke(obj, null);
            //Console.WriteLine("ok");

            //Console.Read();

            #endregion

            // Assembly.LoadFrom("");


            #region 匿名类型

            ////类型推断
            //var n = 10;
            ////类型推断
            //var x = "aaaaa";



            //Person p = new Person();
            //p.

            //匿名类型
            //这里并没有先定义一个类，然后再new对象，而是直接创建对象，其实编译器会帮我们生成一个类型，这个类型就是匿名类型
            var che = new { Brand = "凯迪拉卡", PaiLiang = "6.0", Owner = "ylp" };
            Console.WriteLine(che.Brand);
            Console.WriteLine(che.PaiLiang);
            Console.WriteLine(che.Owner);
            
            //匿名类型中的属性都是只读的，不能赋值，只有在定义类型的时候才能赋值。
            //che.Brand = "宝马";
            Console.WriteLine(che.Brand);
            Console.Read();





            #endregion


        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }


        private void SayHi()
        {
            Console.WriteLine("我是私有的方法，能调到吗？");
        }
    }
}
