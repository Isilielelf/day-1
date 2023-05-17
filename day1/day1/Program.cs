using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1
{
    internal class Program
    {
        static int at (int hp, int dm, int pt)
        {
            return hp = dm / pt;

        }
        static void Main(string[] args)
        {
            string hello = "hello";
            string world = "world";
            Console.WriteLine(hello + " " + world);

            int a = 4;
            int b = 2;
            Console.WriteLine(a - b);
            Console.WriteLine(a + b);
            Console.WriteLine(a / b);
            Console.WriteLine(a * b);


            Console.Write("фамилия");
            string fn = Console.ReadLine();
            Console.Write("имя");
            string nm = Console.ReadLine();
            Console.Write("отчество");
            string om = Console.ReadLine();
            Console.Write("hello," + " " + fn + " " + nm + " " + om);


            int hpP = 50;
            int dmP = 15;
            int ptP = 4;

            int hpM = 35;
            int dmM = 10;
            int ptM = 4;


            Console.WriteLine("start a fight?(yes or no)");
            if (Console.ReadLine() == "yes")
            {
                Console.WriteLine("Let's go!");
                while (hpP > 0 && hpM > 0)
                {
                    // Рассчитываем урон, который игрок нанесет монстру
                    int dmP2 = dmP - ptM;
                    if (dmP2 <= 0)
                    {
                        dmP2 = 0;
                    }

                    // Отнимаем здоровье у монстра
                    hpM -= dmP2;
                    Console.WriteLine("Игрок нанес {0} урона монстру", dmP2);

                    // Проверяем, умер ли монстр
                    if (hpM <= 0)
                    {
                        Console.WriteLine("Игрок победил!");
                        break;
                    }

                    // Рассчитываем урон, который монстр нанесет игроку
                    int dmM2 = dmM - ptP;
                    if (dmM2 <= 0)
                    {
                        dmM2 = 0;
                    }

                    // Отнимаем здоровье у игрока
                    hpP -= dmM2;
                    Console.WriteLine("Монстр нанес {0} урона игроку", dmM2);

                    // Проверяем, умер ли игрок
                    if (hpP <= 0)
                    {
                        Console.WriteLine("Монстр победил!");
                        break;
                    }

                    Console.WriteLine("Здоровье игрока: {0}", hpP);
                    Console.WriteLine("Здоровье монстра: {0}", hpM);
                    Console.WriteLine("-----");
                }
            }

          
            Console.ReadKey();
        }
    }
}
