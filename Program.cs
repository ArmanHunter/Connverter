using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connverter
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num;
            Console.WriteLine("Введите одну из четырех цифр для выбора систем счисления :\r\n 1 - двоичная" + //выбор пользователя систем счисления из еоторой он хочет конвертировать число

                " \r\n 2 - восьмиричная \r\n 3 - десятичная \r\n 4 - шестнадцатиричная ");

            //Console.WriteLine("выберите число");

            int num = Convert.ToInt32(Console.ReadLine());

            {
                if (num == 1) // выбор числа 1-значит двоичная сс.
                {
                    Console.WriteLine("Вы выбрали 2-ую систему. Теперь выберите систему в которую хотите конвертировать число из 2-чной системы");
                    int number1 = Convert.ToInt32(Console.ReadLine()); 
                    if (number1 == 1) // выбор второй сс в которую пол-ль хочет конвертировать число
                    {
                        Console.WriteLine("Вы выбрали 2-ую систему. Переводить из 2-ной системы в 2-ную нет смысла");

                    }
                    if (number1 == 2) // выбор второй сс в которую пол-ль хочет конвертировать число
                    {
                        Console.WriteLine("Вы выбрали 8-ую систему. Теперь наберите число в 2-ной системе для конвертации");
                        int numb2 = Convert.ToInt32(Console.ReadLine(),2);// запонимаем введенное число
                        string s = Convert.ToString(numb2, 8);// конвертируем в 8-ную сс
                        Console.WriteLine("В восьмеричной системе счисления это: " + s);// выводим готовый результат
                    }
                    if (number1 == 3)
                    {
                        Console.WriteLine("Вы выбрали 10-ую систему. Теперь наберите число в 2-ной системе для конвертации");
                        int numb2 = Convert.ToInt32(Console.ReadLine(), 2);
                        string s = Convert.ToString(numb2, 10);
                        Console.WriteLine("В десятичной системе счисления это: " + s);
                    }
                    if (number1 == 4)
                    {
                        Console.WriteLine("Вы выбрали 16-ую систему. Теперь наберите число в 2-ной системе для конвертации: \r\n");
                        int numb2 = Convert.ToInt32(Console.ReadLine(), 2);
                        string s = Convert.ToString(numb2, 16);
                        Console.WriteLine("В 16-ной системе счисления это: " + s);
                    }
                }
                if (num == 2)
                {
                    Console.WriteLine("Вы выбрали 8-ную систему. Теперь выберите систему в которую хотите конвертировать число из 8-чной системы");
                    int number2 = Convert.ToInt32(Console.ReadLine());
                    if (number2 == 1)
                    {
                        Console.WriteLine("Вы выбрали 2-ую систему. Теперь наберите в 8-ной системе число для конвертации");
                        int numb2 = Convert.ToInt32(Console.ReadLine(), 8);
                        string s = Convert.ToString(numb2, 2);
                        Console.WriteLine("В 2-ной системе счисления это: " + s);

                    }
                    if (number2 == 2)
                    {
                        Console.WriteLine(" Вы выбрали 8-ую систему. Переводить из 8-ной системы в 8-ную нет смысла");
                        int numb2 = Convert.ToInt32(Console.ReadLine());
                        Convert.ToString(numb2, 8);

                    }
                    if (number2 == 3)
                    {
                        Console.WriteLine("Вы выбрали 10-ую систему. Теперь наберите в 8-ной системе число для конвертации");
                        int numb2 = Convert.ToInt32(Console.ReadLine(), 8);
                        string s = Convert.ToString(numb2, 10);
                        Console.WriteLine("В 2-ной системе счисления это: " + s);
                    }
                    if (number2 == 4)
                    {
                        Console.WriteLine("Вы выбрали 16-ую систему. Теперь наберите в 8-ной системе число для конвертации");
                        int numb2 = Convert.ToInt32(Console.ReadLine(), 8);
                        string s = Convert.ToString(numb2, 16);
                        Console.WriteLine("В 2-ной системе счисления это: " + s);
                    }
                }
                    if (num == 3)
                    {
                    Console.WriteLine("Вы выбрали 10-ую систему. Теперь выберите систему в которую хотите конвертировать число из 10-чной системы");
                    int number3 = Convert.ToInt32(Console.ReadLine());
                    if (number3 == 1)
                        {
                        Console.WriteLine("Вы выбрали 2-ую систему.Теперь наберите число в 10-ной системе для конвертации: ");
                        int numb2 = Convert.ToInt32(Console.ReadLine(), 10);
                        string s = Convert.ToString(numb2, 2);
                        Console.WriteLine("В 2-ной системе счисления это: " + s);
                    }
                    if (number3 == 2)
                        {
                        Console.WriteLine("Вы выбрали 8-ую систему.Теперь наберите число в 10-ной системе для конвертации: ");
                        int numb2 = Convert.ToInt32(Console.ReadLine(), 10);
                        string s = Convert.ToString(numb2, 8);
                        Console.WriteLine("В 8-ной системе счисления это: " + s);
                    }
                        if (number3 == 3)
                        {

                            Console.WriteLine("Вы выбрали 10 - ую систему. Переводить из 10-ной системы в 10-ную нет смысла");

                        }
                        if (number3 == 4)
                        {
                            Console.WriteLine("Вы выбрали 16-ую систему. Теперь наберите в 10-ной системе число для конвертации");
                        int numb2 = Convert.ToInt32(Console.ReadLine(), 10);
                        string s = Convert.ToString(numb2, 16);
                        Console.WriteLine("В 16-ной системе счисления это: " + s);
                    }
                     }
                    if (num == 4)
                    {
                        Console.WriteLine("Вы выбрали 16-ную систему. Теперь выберите систему в которую хотите конвертировать число из 16-чной системы");
                        int number4 = Convert.ToInt32(Console.ReadLine());
                        if (number4 == 1)
                        {
                        Console.WriteLine("Вы выбрали 2-ую систему.Теперь наберите число в 16-ной системе для конвертации: ");
                        int numb2 = Convert.ToInt32(Console.ReadLine(), 16);
                        string s = Convert.ToString(numb2, 2);
                        Console.WriteLine("В 2-ной системе счисления это: " + s);

                    }
                        if (number4 == 2)
                        {
                        Console.WriteLine("Вы выбрали 8-ую систему.Теперь наберите число в 16-ной системе для конвертации: ");
                        int numb2 = Convert.ToInt32(Console.ReadLine(), 16);
                        string s = Convert.ToString(numb2, 8);
                        Console.WriteLine("В 8-ной системе счисления это: " + s);
                    }
                        if (number4 == 3)
                        {

                        Console.WriteLine("Вы выбрали 10-ую систему.Теперь наберите число в 16-ной системе для конвертации: ");
                        int numb2 = Convert.ToInt32(Console.ReadLine(), 16);
                        string s = Convert.ToString(numb2, 10);
                        Console.WriteLine("В 10-ной системе счисления это: " + s);

                    }
                        if (number4 == 4)
                        {
                            Console.WriteLine("Вы выбрали 16-ую систему. Переводить из 16-ной системы в 16-ную нет смысла");

                        }
                    }
                Console.ReadKey();
            }

        }

    }
}
