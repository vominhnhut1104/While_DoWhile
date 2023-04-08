using System;

namespace ExercisesLesson36
{
    class Exercises7
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
          
            if (n < 0)
            {
                Console.WriteLine("INVALID");

            }
            else if (n > 27)
            {
                Console.WriteLine("OVERLOAD");
            }
            else
            {
                int i = 1;
                decimal giaithua = 1; // kiêu decimal lưu lớn hơn long
                while (n >= i)
                {
                    giaithua = giaithua * i;
                    i++;
                }
                Console.WriteLine(giaithua);
            }
        }
    }
}
