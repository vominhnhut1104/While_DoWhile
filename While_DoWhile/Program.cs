using System;

namespace ExercisesLesson36
{
    class Exercises1
    {
        static void Main(string[] args)
        {
            var data = Console.ReadLine().Split(' ');
            int a = int.Parse(data[0]); 
            int b = int.Parse(data[1]);

            if ( a< 0 || b<0 )
            {
                Console.WriteLine("INVALID");

            }
            else
            {
                int BCLN = a * b;
                while (a != b) // tim UCLN
                {
                    if (a > b)
                    {
                        a = a - b;
                    }
                    else if (a < b)
                    {
                        b = b - a;
                    }
                }
                int UCLN = a; // UClN lúc này có thể là a hoặc b vì sau khi chạy vòng lăp a và b đêu băng nhau
                int BCNN = BCLN / UCLN;
                Console.WriteLine($"{UCLN} {BCNN}");
            }
        }
    }
}