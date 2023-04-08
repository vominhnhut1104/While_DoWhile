using System;

namespace ExercisesLesson36
{
    class Exercises10
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Nhập 2 số nguyên a, b :");
            var data = Console.ReadLine().Split(' ');
            int a = int.Parse(data[0]);
            int b = int.Parse(data[1]);
            int choice;
            do
            {
                Console.WriteLine("=============== MENU ===============");
            Console.WriteLine("1. Cộng hai số");
            Console.WriteLine("2. Trừ a cho b");
            Console.WriteLine("3. Nhân a với b");
            Console.WriteLine("4. Chia a cho b");
            Console.WriteLine("5. Chia lấy dư a cho b");
            Console.WriteLine("6. Tính a^b, b >=0 ");
            Console.WriteLine("0. Thoát");

             choice = int.Parse(Console.ReadLine());

            
               
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Đã thoát khỏi chương trình");
                        break;
                    case 1:
                        Console.WriteLine($"{a} + {b} = {a+b}" );
                        break;

                    case 2: 
                        Console.WriteLine($"{a} - {b} = {a - b}");
                        break;

                    case 3:
                        Console.WriteLine($"{a} * {b} = {a * b}");
                        break;

                    case 4:
                        Console.WriteLine($"{a} / {b} = {(float)a + b}");
                        break;

                    case 5:
                        Console.WriteLine($"{a} % {b} = {a % b}");
                        break;

                    case 6:
                        Console.WriteLine($"{a} ^ {b} = {Math.Pow(a,b)}");
                        break;

                    

                        default:
                        Console.WriteLine("Vui lòng nhập từ 0-6");
                        break;

                }


            } while (choice!= 0);


        }
    }
}