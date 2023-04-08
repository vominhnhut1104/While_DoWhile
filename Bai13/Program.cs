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

            int thang;
            do
            {
                Console.WriteLine("================================");
                Console.WriteLine("Nhập ngày ,tháng :");
                Console.WriteLine("Nhập 0 để thoát ");
                var data = Console.ReadLine().Split(' ');
                ngay = int.Parse(data[0]);
                thang = int.Parse(data[1]);



                switch (thang)
                {
                    case 0:
                        Console.WriteLine("Đã thoát khỏi chương trình");
                        break;
                    case 1:
                        if (ngay >= 1 && ngay <= 19)
                            Console.WriteLine("Ma kết");
                        else if (ngay >= 20 && ngay <= 31)
                            Console.WriteLine("Bảo Bình");
                        else Console.WriteLine("INVALID");
                        break;

                    case 2:
                        if (ngay >= 1 && ngay <= 18)
                            Console.WriteLine("Bảo Bình");
                        else if (ngay >= 19 && ngay <= 29)
                            Console.WriteLine("Song Ngư");
                        else Console.WriteLine("INVALID");
                        break;

                    case 3:
                        if (ngay >= 1 && ngay <= 20)
                            Console.WriteLine("Song Ngư");
                        else if (ngay >= 21 && ngay <= 31)
                            Console.WriteLine("Bạch Dương");
                        else Console.WriteLine("INVALID");
                        break;

                    case 4:
                        if (ngay >= 1 && ngay <= 20)
                            Console.WriteLine("Bạch Dương");
                        else if (ngay >= 21 && ngay <= 30)
                            Console.WriteLine("Kim Ngưu");
                        else Console.WriteLine("INVALID");
                        break;

                    case 5:
                        if (ngay >= 1 && ngay <= 20)
                            Console.WriteLine("Kim Ngưu");
                        else if (ngay >= 21 && ngay < 31)
                            Console.WriteLine("Song Tử");
                        else Console.WriteLine("INVALID");
                        break;

                    case 6:
                        if (ngay >= 1 && ngay <= 21)
                            Console.WriteLine("Song Tử");
                        else if (ngay >= 22 && ngay < 30)
                            Console.WriteLine("Cự Giải");
                        else Console.WriteLine("INVALID");
                        break;

                    case 7:
                        if (ngay >= 1 && ngay <= 22)
                            Console.WriteLine("Cự Giải");
                        else if (ngay >= 23 && ngay < 31)
                            Console.WriteLine("Sư Tử");
                        else Console.WriteLine("INVALID"); Console.WriteLine("July");
                        break;

                    case 8:
                        if (ngay >= 1 && ngay <= 22)
                            Console.WriteLine("Sư Tử");
                        else if (ngay >= 23 && ngay < 31)
                            Console.WriteLine("Xử Nữ");
                        else Console.WriteLine("INVALID");
                        break;

                    case 9:
                        if (ngay >= 1 && ngay <= 22)
                            Console.WriteLine("Xử Nữ");
                        else if (ngay >= 23 && ngay < 30)
                            Console.WriteLine("Thiên Bình");
                        else Console.WriteLine("INVALID");
                        break;

                    case 10:
                        if (ngay >= 1 && ngay <= 23)
                            Console.WriteLine("Thiên Bình");
                        else if (ngay >= 24 && ngay < 31)
                            Console.WriteLine("Bọ Cạp");
                        else Console.WriteLine("INVALID");
                        break;

                    case 11:
                        if (ngay >= 1 && ngay <= 22)
                            Console.WriteLine("Bò Cạp");
                        else if (ngay >= 23 && ngay < 30)
                            Console.WriteLine("Nhân Mã");
                        else Console.WriteLine("INVALID");
                        break;

                    case 12:
                        if (ngay >= 1 && ngay <= 21)
                            Console.WriteLine("Nhân Mã");
                        else if (ngay >= 22 && ngay < 31)
                            Console.WriteLine("Ma Kết");
                        else Console.WriteLine("INVALID");
                        break;


                    default:
                        if (ngay >= 1 && ngay <= 19)
                            Console.WriteLine("Ma kết");
                        else if (ngay >= 20 && ngay < 31)
                            Console.WriteLine("Bảo Bình");
                        else Console.WriteLine("INVALID");
                        break;

                }


            } while (thang != 0);


        }
    }
}


