using System;

namespace ExercisesLesson36
{
    class Exercises3
    {
        // phan tich 1 so thanh tich cac thua so nguyen to
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if ( n <= 0)
            {
                Console.WriteLine("INVALID");
            }
            else
            {
                int dem;

                for (int i = 2; i <= n; i++)
                {
                    dem = 0;
                    while (n % i == 0)
                    {
                        ++dem;
                        n /= i;
                    }
                    if (dem!=0)
                    {
                        Console.Write(i);
                        if (dem > 1) Console.Write( "^" + dem);
                        if (n > i)
                        {
                            Console.Write("*");
                        }
                    }

                    /*
                     * cách 2
                     * int k = 2;
                while (n > 1)
                {
                    if(n % k == 0)
                    {
                        Console.Write(k + " ");
                        n /= k; // giảm n đi k lần
                    } else
                    {
                        k++;
                    }
                }
                Console.WriteLine();
                     */



                }
            } 
                
        }
    }
}
