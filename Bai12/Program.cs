using System;

namespace ExercisesLesson36
{
    class Exercises10
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;


            int thang;
            do
            {
                Console.WriteLine("================================");
                Console.WriteLine("Nhập ngày 1-12 :");
                Console.WriteLine("Nhập 0 để thoát ");

                thang = int.Parse(Console.ReadLine());



                switch (thang)
                {
                    case 0:
                        Console.WriteLine("Đã thoát khỏi chương trình");
                        break;
                    case 1:
                        Console.WriteLine("January");
                        break;

                    case 2:
                        Console.WriteLine("February");
                        break;

                    case 3:
                        Console.WriteLine("March");
                        break;

                    case 4:
                        Console.WriteLine("April");
                        break;

                    case 5:
                        Console.WriteLine("May");
                        break;

                    case 6:
                        Console.WriteLine("Jun");
                        break;

                    case 7:
                        Console.WriteLine("July");
                        break;

                    case 8:
                        Console.WriteLine("August");
                        break;

                    case 9:
                        Console.WriteLine("September");
                        break;

                    case 10:
                        Console.WriteLine("October");
                        break;

                    case 11:
                        Console.WriteLine("November");
                        break;

                    case 12:
                        Console.WriteLine("December");
                        break;


                    default:
                        Console.WriteLine("Vui lòng nhập từ 0-12");
                        break;

                }


            } while (thang != 0);


        }
    }
}

