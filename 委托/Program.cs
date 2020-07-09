using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 委托
{

    delegate void MyDel(int value); //声明委托

    class Program
    {
        void PrintLow(int value)
        {
            Console.WriteLine("{0}-Low Value",value);
        }

        void PrintHight(int value)
        {
            Console.WriteLine("{0}-Hight Value",value);
        }

        static void Main(string[] args)
        {

            Program program = new Program();
            //声明委托
            MyDel del;
            //创建随机整数生成器，并得到0到99之间的一个随机数
            Random rand = new Random();
            int randomValue = rand.Next(99);

            //创建一个包含_PrintLow或PrintHight 的委托对象并将其赋值给del变量
            del = randomValue < 50 ? new MyDel(program.PrintLow) : new MyDel(program.PrintHight);

            //执行委托
            del(randomValue);

            Console.WriteLine("程序结束");
            Console.ReadKey();//卡屏等待按钮按下
        }
    }
}
