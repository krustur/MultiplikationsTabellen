using System;
using System.Diagnostics;
using System.Threading;

namespace MultiplikationsTabellen
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random((int) (DateTime.Now.Ticks % 0xffffffff));
            var nyFråga = true;
            int a = 0;
            int b = 0;
            var stoppKlocka = new Stopwatch();
            stoppKlocka.Start();
            var räknare = 0;
            while (true)
            {
                if (nyFråga == true)
                {
                    a = rand.Next(1, 11);
                    b = rand.Next(1, 11);
                    //if (a == 0 || a == 11 || b == 0 || b == 11)
                    //{

                    //}
                }

                Console.Write("Vad är {0} * {1}: ", a, b);
                var svar = Console.ReadLine();
                int svarInt;
                var förstårSvar = Int32.TryParse(svar, out svarInt);

                //var svarInt = a * b;
                //var förstårSvar = true;

                if (förstårSvar)
                {
                    if (svarInt == a * b)
                    {
                        räknare++;
                        Console.WriteLine("Rätt! Du har gjort {0} multiplikationer i sammanlagt {1} minuter och {2} sekunder.", räknare, stoppKlocka.Elapsed.Minutes, stoppKlocka.Elapsed.Seconds);
                        Console.WriteLine("");
                        nyFråga = true;
                    }
                    else
                    {
                        Console.WriteLine("Det var inte riktigt rätt, försök igen!");
                        nyFråga = false;
                    }
                }
                else
                {
                    Console.WriteLine("Jag förstår inte riktigt vad du skriver. Kom ihåg att bara skriva med siffror!");
                    nyFråga = false;

                }
                Thread.Sleep(100);
            }
        }
    }
}