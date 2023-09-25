namespace ConsoleApp4 // №1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x % 3 == 0 && x % 5 == 0)
            {
                Console.WriteLine("FIZZ,BUZZ");
            }
            else if (x % 3 == 0)
            {
                Console.WriteLine("FIZZ");
            }
            else if (x % 5 == 0)
            {
                Console.WriteLine("BUZZ");
            }
            else
            {
                Console.WriteLine(x);
            }
        }
    }
}
namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите процент");
            double y = Convert.ToDouble(Console.ReadLine());
            y /= 100;
            x *= y;
            Console.WriteLine(x);
        }
    }
}//№2
namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите цифру");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите цифру");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите цифру");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите цифру");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}{1}{2}{3}", x, y, z, l);

        }
    }
}//№3
namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Укажите разряды для замены");
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());
            int temp1, temp2, temp3, temp4, temp5, temp6;
            temp1 = x / 100000;
            temp2 = (x % 100000) / 10000;
            temp3 = (x % 10000) / 1000;
            temp4 = (x % 1000) / 100;
            temp5 = (x % 100) / 10;
            temp6 = x % 10;
            if (y == 1 & z == 6 || y == 6 & z == 1)
            {
                Console.WriteLine("{5}{1}{2}{3}{4}{0}", temp1, temp2, temp3, temp4, temp5, temp6);
            }
            if (y == 1 & z == 5 || y == 5 & z == 1)
            {
                Console.WriteLine("{4}{1}{2}{3}{0}{5}", temp1, temp2, temp3, temp4, temp5, temp6);
            }
            if (y == 1 & z == 4 || y == 4 & z == 1)
            {
                Console.WriteLine("{4}{1}{2}{0}{4}{5}", temp1, temp2, temp3, temp4, temp5, temp6);
            }
            if (y == 1 & z == 3 || y == 3 & z == 1)
            {
                Console.WriteLine("{3}{1}{0}{3}{4}{5}", temp1, temp2, temp3, temp4, temp5, temp6);
            }
            if (y == 1 & z == 2 || y == 2 & z == 1)
            {
                Console.WriteLine("{1}{0}{2}{3}{4}{5}", temp1, temp2, temp3, temp4, temp5, temp6);
            }
            if (y == 2 & z == 6 || y == 6 & z == 2)
            {
                Console.WriteLine("{0}{5}{2}{3}{4}{1}", temp1, temp2, temp3, temp4, temp5, temp6);
            }
            if (y == 2 & z == 5 || y == 5 & z == 2)
            {
                Console.WriteLine("{0}{4}{2}{3}{1}{5}", temp1, temp2, temp3, temp4, temp5, temp6);
            }
            if (y == 2 & z == 4 || y == 4 & z == 2)
            {
                Console.WriteLine("{0}{3}{2}{1}{4}{5}", temp1, temp2, temp3, temp4, temp5, temp6);
            }
            if (y == 2 & z == 3 || y == 3 & z == 2)
            {
                Console.WriteLine("{0}{2}{1}{3}{4}{5}", temp1, temp2, temp3, temp4, temp5, temp6);
            }
            if (y == 3 & z == 6 || y == 6 & z == 3)
            {
                Console.WriteLine("{0}{1}{5}{3}{4}{2}", temp1, temp2, temp3, temp4, temp5, temp6);
            }
            if (y == 3 & z == 5 || y == 5 & z == 3)
            {
                Console.WriteLine("{0}{1}{4}{3}{2}{5}", temp1, temp2, temp3, temp4, temp5, temp6);
            }
            if (y == 3 & z == 4 || y == 4 & z == 3)
            {
                Console.WriteLine("{0}{1}{2}{3}{4}{5}", temp1, temp2, temp3, temp4, temp5, temp6);
            }
            if (y == 4 & z == 6 || y == 6 & z == 4)
            {
                Console.WriteLine("{0}{1}{2}{5}{4}{3}", temp1, temp2, temp3, temp4, temp5, temp6);
            }
            if (y == 4 & z == 5 || y == 5 & z == 4)
            {
                Console.WriteLine("{0}{1}{2}{4}{3}{5}", temp1, temp2, temp3, temp4, temp5, temp6);
            }
            if (y == 5 & z == 6 || y == 6 & z == 5)
            {
                Console.WriteLine("{0}{1}{2}{3}{5}{4}", temp1, temp2, temp3, temp4, temp5, temp6);
            }
        }
    }
}//№4
namespace ConsoleApp8
{
    internal class Program
    {
        static void datee(int tx, int y)
        {
            if (tx == 0)
            {
                Console.Write("Суббота");
                if (y == 12 || y == 1 || y == 2)
                {
                    Console.WriteLine(", Зима");
                }
                if (y == 3 || y == 4 || y == 5)
                {
                    Console.WriteLine(", Весна");
                }
                if (y == 6 || y == 7 || y == 8)
                {
                    Console.WriteLine(", Лето");
                }
                if (y == 9 || y == 10 || y == 11)
                {
                    Console.WriteLine(", осень");
                }
            }
            if (tx == 1)
            {
                Console.Write("Воскресенье");
                if (y == 12 || y == 1 || y == 2)
                {
                    Console.WriteLine(", Зима");
                }
                if (y == 3 || y == 4 || y == 5)
                {
                    Console.WriteLine(", Весна");
                }
                if (y == 6 || y == 7 || y == 8)
                {
                    Console.WriteLine(", Лето");
                }
                if (y == 9 || y == 10 || y == 11)
                {
                    Console.WriteLine(", осень");
                }
            }
            if (tx == 2)
            {
                Console.Write("Понедельник");
                if (y == 12 || y == 1 || y == 2)
                {
                    Console.WriteLine(", Зима");
                }
                if (y == 3 || y == 4 || y == 5)
                {
                    Console.WriteLine(", Весна");
                }
                if (y == 6 || y == 7 || y == 8)
                {
                    Console.WriteLine(", Лето");
                }
                if (y == 9 || y == 10 || y == 11)
                {
                    Console.WriteLine(", осень");
                }
            }
            if (tx == 3)
            {
                Console.Write("Вторник");
                if (y == 12 || y == 1 || y == 2)
                {
                    Console.WriteLine(", Зима");
                }
                if (y == 3 || y == 4 || y == 5)
                {
                    Console.WriteLine(", Весна");
                }
                if (y == 6 || y == 7 || y == 8)
                {
                    Console.WriteLine(", Лето");
                }
                if (y == 9 || y == 10 || y == 11)
                {
                    Console.WriteLine(", осень");
                }
            }
            if (tx == 4)
            {
                Console.Write("Среда");
                if (y == 12 || y == 1 || y == 2)
                {
                    Console.WriteLine(", Зима");
                }
                if (y == 3 || y == 4 || y == 5)
                {
                    Console.WriteLine(", Весна");
                }
                if (y == 6 || y == 7 || y == 8)
                {
                    Console.WriteLine(", Лето");
                }
                if (y == 9 || y == 10 || y == 11)
                {
                    Console.WriteLine(", осень");
                }
            }
            if (tx == 5)
            {
                Console.Write("Четверг");
                if (y == 12 || y == 1 || y == 2)
                {
                    Console.WriteLine(", Зима");
                }
                if (y == 3 || y == 4 || y == 5)
                {
                    Console.WriteLine(", Весна");
                }
                if (y == 6 || y == 7 || y == 8)
                {
                    Console.WriteLine(", Лето");
                }
                if (y == 9 || y == 10 || y == 11)
                {
                    Console.WriteLine(", осень");
                }
            }
            if (tx == 6)
            {
                Console.Write("Пятница");
                if (y == 12 || y == 1 || y == 2)
                {
                    Console.WriteLine(", Зима");
                }
                if (y == 3 || y == 4 || y == 5)
                {
                    Console.WriteLine(", Весна");
                }
                if (y == 6 || y == 7 || y == 8)
                {
                    Console.WriteLine(", Лето");
                }
                if (y == 9 || y == 10 || y == 11)
                {
                    Console.WriteLine(", осень");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите день");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите месяц");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите год");
            int z = Convert.ToInt32(Console.ReadLine());
            int ty, tx;
            int tz = z % 100;
            int ttz = (6 + tz + tz / 4) % 7;
            // код месяца 1 — январь, октябрь;
            //2 — май;
            //3 — август;
            //4 — февраль, март, ноябрь;
            //5 — июнь;
            //6 — декабрь, сентябрь;
            //0 — апрель, июль.
            if (y == 5)
            {
                ty = 2;
                tx = (x + ty + ttz) % 7;
                datee(tx, y);
            }
            if (y == 8)
            {
                ty = 3;
                tx = (x + ty + ttz) % 7;
                datee(tx, y);
            }
            if (y == 2 || y == 3 || y == 11)
            {
                ty = 4;
                tx = (x + ty + ttz) % 7;
                datee(tx, y);
            }
            if (y == 5)
            {
                ty = 5;
                tx = (x + ty + ttz) % 7;
                datee(tx, y);
            }
            if (y == 9 || y == 12)
            {
                ty = 6;
                tx = (x + ty + ttz) % 7;
                datee(tx, y);
            }
            if (y == 4 || y == 7)
            {
                ty = 0;
                tx = (x + ty + ttz) % 7;
                datee(tx, y);
            }
            Console.WriteLine();
        }
    }
}//№5
namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите тип(1-Цельсия, 2-Фаренгейт)");
            int z = Convert.ToInt32(Console.ReadLine());
            double tx;
            if (z == 1)
            {
                Console.WriteLine("Укажите температуру");
                double x = Convert.ToDouble(Console.ReadLine());
                tx = 1.8 * x + 32;
                Console.WriteLine("Темература в Фаренгетах состовляет {0}", tx);
            }
            if (z == 2)
            {
                Console.WriteLine("Укажите температуру");
                double x = Convert.ToDouble(Console.ReadLine());
                tx = (x - 32) / 1.8;
                Console.WriteLine("Темература в Цельсиях состовляет {0}", tx);

            }

        }
    }
}//№6
namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите первое число");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Укажите второе число");
            int y = Convert.ToInt32(Console.ReadLine());
            int temp1, temp2;
            if (x > y)
            {
                temp1 = x; temp2 = y;
            }
            else
            {
                temp1 = y; temp2 = x;
            }
            for (int i = temp2; i <= temp1; i++)
            {
                Console.Write("{0},", i);
            }
        }
    }
}//№7