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
                int i = 1;
                double sum = 0;
                while (n>= i)
                {
                    sum = sum + 1.0f / (i * i * i);
                    i++;
                }
                Console.WriteLine($"{sum:F6}");
            }    
        }
    }
}
