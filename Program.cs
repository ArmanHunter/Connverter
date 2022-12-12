
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
            Console.WriteLine("Введите одну из четырех цифр для выбора систем счисления (При вводе не цифр, программа не сработает!):\r\n 1 - двоичная" + //выбор пользователя систем счисления из еоторой он хочет конвертировать число

                " \r\n 2 - восьмиричная \r\n 3 - десятичная \r\n 4 - шестнадцатиричная ");


            int numberSystem = Convert.ToInt32(Console.ReadLine());

            { 
                if (numberSystem <= 0 || numberSystem >= 5)
                {
                    Console.WriteLine("Ошибка! Диапазон от 1 до 4!");
                }
            
                if (numberSystem == 1) // выбор числа 1-значит двоичная сс.
                {
                    Console.WriteLine("Вы выбрали 2-ую систему. Теперь выберите систему в которую хотите конвертировать число из 2-чной системы");
                    int binaryNumber = Convert.ToInt32(Console.ReadLine());
                    if (binaryNumber <= 0 || binaryNumber >= 5)
                    {
                        Console.WriteLine("Ошибка! Диапазон от 1 до 4!");
                    }
                    if (binaryNumber == 1) // выбор второй сс в которую пол-ль хочет конвертировать число
                    {
                        Console.WriteLine("Вы выбрали 2-ую систему. Переводить из 2-ной системы в 2-ную нет смысла");

                    }
                    if (binaryNumber == 2) // выбор второй сс в которую пол-ль хочет конвертировать число
                    {
                        Console.WriteLine("Вы выбрали 8-ую систему. Теперь наберите число в 2-ной системе для конвертации");
                        int numb2 = Convert.ToInt32(Console.ReadLine(), 2);// запонимаем введенное число
                        string s = Convert.ToString(numb2, 8);// конвертируем в 8-ную сс
                        Console.WriteLine("В восьмеричной системе счисления это: " + s);// выводим готовый результат
                    }
                    if (binaryNumber == 3)
                    {
                        Console.WriteLine("Вы выбрали 10-ую систему. Теперь наберите число в 2-ной системе для конвертации");
                        int numb2 = Convert.ToInt32(Console.ReadLine(), 2);
                        string s = Convert.ToString(numb2, 10);
                        Console.WriteLine("В десятичной системе счисления это: " + s);
                    }
                    if (binaryNumber == 4)
                    {
                        Console.WriteLine("Вы выбрали 16-ую систему. Теперь наберите число в 2-ной системе для конвертации: \r\n");
                        int numb2 = Convert.ToInt32(Console.ReadLine(), 2);
                        string s = Convert.ToString(numb2, 16);
                        Console.WriteLine("В 16-ной системе счисления это: " + s);
                    }
                }
                if (numberSystem == 2)
                {
                    Console.WriteLine("Вы выбрали 8-ную систему. Теперь выберите систему в которую хотите конвертировать число из 8-чной системы");
                    int octalNumber = Convert.ToInt32(Console.ReadLine());
                    if (octalNumber <= 0 || octalNumber >= 5)
                    {
                        Console.WriteLine("Ошибка! Диапазон от 1 до 4!");
                    }
                    if (octalNumber == 1)
                    {
                        Console.WriteLine("Вы выбрали 2-ую систему. Теперь наберите в 8-ной системе число для конвертации");
                        int numb2 = Convert.ToInt32(Console.ReadLine(), 8);
                        string s = Convert.ToString(numb2, 2);
                        Console.WriteLine("В 2-ной системе счисления это: " + s);

                    }
                    if (octalNumber == 2)
                    {
                        Console.WriteLine(" Вы выбрали 8-ую систему. Переводить из 8-ной системы в 8-ную нет смысла");
                        int numb2 = Convert.ToInt32(Console.ReadLine());
                        Convert.ToString(numb2, 8);

                    }
                    if (octalNumber == 3)
                    {
                        Console.WriteLine("Вы выбрали 10-ую систему. Теперь наберите в 8-ной системе число для конвертации");
                        int numb2 = Convert.ToInt32(Console.ReadLine(), 8);
                        string s = Convert.ToString(numb2, 10);
                        Console.WriteLine("В 10-ной системе счисления это: " + s);
                    }
                    if (octalNumber == 4)
                    {
                        Console.WriteLine("Вы выбрали 16-ую систему. Теперь наберите в 8-ной системе число для конвертации");
                        int numb2 = Convert.ToInt32(Console.ReadLine(), 8);
                        string s = Convert.ToString(numb2, 16);
                        Console.WriteLine("В 16-ной системе счисления это: " + s);
                    }
                }
                if (numberSystem == 3)
                {
                    Console.WriteLine("Вы выбрали 10-ую систему. Теперь выберите систему в которую хотите конвертировать число из 10-чной системы");
                    int decimalNumber = Convert.ToInt32(Console.ReadLine());
                    if (decimalNumber <= 0 || decimalNumber >= 5)
                    {
                        Console.WriteLine("Ошибка! Диапазон от 1 до 4!");
                    }
                    if (decimalNumber == 1)
                    {
                        Console.WriteLine("Вы выбрали 2-ую систему.Теперь наберите число в 10-ной системе для конвертации: ");
                        int numb2 = Convert.ToInt32(Console.ReadLine(), 10);
                        string s = Convert.ToString(numb2, 2);
                        Console.WriteLine("В 2-ной системе счисления это: " + s);
                    }
                    if (decimalNumber == 2)
                    {
                        Console.WriteLine("Вы выбрали 8-ую систему.Теперь наберите число в 10-ной системе для конвертации: ");
                        int numb2 = Convert.ToInt32(Console.ReadLine(), 10);
                        string s = Convert.ToString(numb2, 8);
                        Console.WriteLine("В 8-ной системе счисления это: " + s);
                    }
                    if (decimalNumber == 3)
                    {

                        Console.WriteLine("Вы выбрали 10 - ую систему. Переводить из 10-ной системы в 10-ную нет смысла");

                    }
                    if (decimalNumber == 4)
                    {
                        Console.WriteLine("Вы выбрали 16-ую систему. Теперь наберите в 10-ной системе число для конвертации");
                        int numb2 = Convert.ToInt32(Console.ReadLine(), 10);
                        string s = Convert.ToString(numb2, 16);
                        Console.WriteLine("В 16-ной системе счисления это: " + s);
                    }
                }
                if (numberSystem == 4)
                {
                    Console.WriteLine("Вы выбрали 16-ную систему. Теперь выберите систему в которую хотите конвертировать число из 16-чной системы");
                    int hexadecimalNumber = Convert.ToInt32(Console.ReadLine());
                    if (hexadecimalNumber <= 0 || hexadecimalNumber >= 5)
                    {
                        Console.WriteLine("Ошибка! Диапазон от 1 до 4!");
                    }
                    if (hexadecimalNumber == 1)
                    {
                        Console.WriteLine("Вы выбрали 2-ую систему.Теперь наберите число в 16-ной системе для конвертации: ");
                        int numb2 = Convert.ToInt32(Console.ReadLine(), 16);
                        string s = Convert.ToString(numb2, 2);
                        Console.WriteLine("В 2-ной системе счисления это: " + s);

                    }
                    if (hexadecimalNumber == 2)
                    {
                        Console.WriteLine("Вы выбрали 8-ую систему.Теперь наберите число в 16-ной системе для конвертации: ");
                        int numb2 = Convert.ToInt32(Console.ReadLine(), 16);
                        string s = Convert.ToString(numb2, 8);
                        Console.WriteLine("В 8-ной системе счисления это: " + s);
                    }
                    if (hexadecimalNumber == 3)
                    {

                        Console.WriteLine("Вы выбрали 10-ую систему.Теперь наберите число в 16-ной системе для конвертации: ");
                        int numb2 = Convert.ToInt32(Console.ReadLine(), 16);
                        string s = Convert.ToString(numb2, 10);
                        Console.WriteLine("В 10-ной системе счисления это: " + s);

                    }
                    if (hexadecimalNumber == 4)
                    {
                        Console.WriteLine("Вы выбрали 16-ую систему. Переводить из 16-ной системы в 16-ную нет смысла");

                    }
                }
                Console.ReadKey();
            }

        }

    }
}
