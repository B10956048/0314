using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string [,] score ={ { "1","Jack", "80", "75", "60" },
                               { "2","Mary", "65", "67", "62" },
                               { "3","Tom", "100", "93", "91" },
                               { "4","Grace", "98", "25", "50" }, 
                               { "5","Alice", "83", "82", "87" } };
            string number;
            int a;
            Console.Write("座號1~5");
            number = Console.ReadLine();
            a = Convert.ToInt32(number);
            a = a - 1;
            string name = score[a, 1];
            string comp = score[a, 2];
            string cod = score[a, 3];
            string des = score[a, 4];
            Console.Write("1.姓名:" + name + "\n2.電腦概論:" + comp + "\n3.程式設計:" + cod + "\n4.動畫設計:" + des);
        }
    }
}

