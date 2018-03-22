using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 設置變數
            Random rand = new Random();

            // 次數
            int count = 1;

            // 重複
            while (count <= 10)
            {
                // 設置6個隨機變數
                int r1 = rand.Next(3, 100);
                int r2 = rand.Next(3, 100);
                int r3 = rand.Next(3, 100);
                int r4 = rand.Next(3, 100);
                int r5 = rand.Next(3, 100);
                int r6 = rand.Next(3, 100);

                // 顯示
                Console.WriteLine("號碼:[{0:00}] {1:00} {2:00} {3:00} {4:00} {5:00} {6:00}", count, r1, r2, r3, r4, r5, r6);

                // 紀錄次數
                count = count + 1;
               
            }
            // 暫停畫面
                Console.ReadLine();
        }
    }
}
