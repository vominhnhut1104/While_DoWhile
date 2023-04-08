using System;

namespace ExercisesLesson36
{
    class Exercises10
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            
            
            int ngay;
            do
            {
                Console.WriteLine("================================");
                Console.WriteLine("Nhập ngày 1-7 :");
                Console.WriteLine("Nhập 0 để thoát ");

                ngay = int.Parse(Console.ReadLine());



                switch (ngay)
                {
                    case 0:
                        Console.WriteLine("Đã thoát khỏi chương trình");
                        break;
                    case 1:
                        Console.WriteLine("Monday");
                        break;

                    case 2:
                        Console.WriteLine("Tuesday");
                        break;

                    case 3:
                        Console.WriteLine("Wednesday");
                        break;

                    case 4:
                        Console.WriteLine("Thursday");
                        break;

                    case 5:
                        Console.WriteLine("Friday");
                        break;

                    case 6:
                        Console.WriteLine("Saturday");
                        break;

                    case 7:
                        Console.WriteLine("Sunday");
                        break;



                    default:
                        Console.WriteLine("Vui lòng nhập từ 0-7");
                        break;

                }


            } while (ngay != 0);


        }
    }
}
