using System;

namespace ExercisesLesson36
{
    class Exercises2
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            int dem = 0;
            if (n < 2)
            {
                Console.WriteLine("NO");
            }
            while (i<=n)
            {
                if (n % i == 0)
                {
                    dem++;
                    
                }

                i++;
            }
            if (dem == 2) Console.WriteLine("YES");
            if (dem > 2) Console.WriteLine("NO");

            /*Cách 2:
             *  bool isPrime = true;
                int bound = (int)Math.Sqrt(n);
                int index = 2;
                while (index <= bound) // nếu n có ước khác 1 và n thì n không nguyên tố
                {
                    if(n % index == 0)
                    {
                        isPrime = false;
                    }
                    index++;
                }
                Console.WriteLine(isPrime ? "YES" : "NO");
            */

        }
    }
}