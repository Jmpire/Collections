using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<int> ages = new List<int>(){ 65, 34, 3, 45, 34, 76, 23 };
            ages.Add(19);
            int count = 0;

            foreach(int age in ages)
            {
                if(age > 20)
                {
                    count++;
                }
                 
            }
            Console.WriteLine(count);

            Stack<double> prices  = new Stack<double>();
            prices.Push(25.0);
            prices.Push(47.5);
            prices.Push(192.0);
            prices.Push(19.2);

            Stack<double> backUp = new Stack<double>(); // Backup location
            int countt = 0;
            while (prices.Count != 0)
            {
                
                double top = prices.Pop(); // Removes element on top
                if (top == 19.2)
                {
                    countt++;
                }
                Console.WriteLine(top);
                backUp.Push(top); // Add to back up

            }
            Console.WriteLine(countt);
            while(backUp.Count != 0)
            {
                // Taking from the backup and into the original
                prices.Push(backUp.Pop());
            }

            // Bouncer let's first 4 people enter
            int a = 0;
            while (a < 4 )
            {
                Console.WriteLine("You may enter");
                a++;
            }
        }
    }
}