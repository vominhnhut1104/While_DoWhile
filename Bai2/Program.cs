using System;

namespace ExercisesLesson36
{
    class Exercises2
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if ( n<= 0)
            {
                Console.WriteLine("INVALID");
            }
            else
            {
                int sum = 0;
                
                while (n > 0)
                {
                    int m = n % 10;
                    int x = m * m;
                    sum = sum + x;
                    n = n / 10;
                }
                Console.WriteLine(sum);
            }
        }
    }
}