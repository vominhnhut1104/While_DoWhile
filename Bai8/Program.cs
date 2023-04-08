using System;

namespace ExercisesLesson36
{
    class Exercises8
    {

        /*
         * Nhập vào hai số nguyên dương a, b sau đó kiểm tra xem chúng có nguyên tố cùng nhau
hay không. Hai số nguyên tố cùng nhau là hai số có ước số chung lớn nhất là 1.
        */
        static void Main(string[] args)
        {
            var data = Console.ReadLine().Split(' ');
            int a = int.Parse(data[0]);
            int b = int.Parse(data[1]);
            if (a <= 0 || b <= 0) Console.WriteLine("INVALID");
            else
            {
                while (a != b)
                {
                    if (a > b)
                    {
                        a = a - b;
                    }
                    if (b > a)
                    {
                        b = b - a;
                    }
                }

                Console.WriteLine(a == 1 ? "YES":"YES"); 
               
            }

           

            
        }
    }
}

