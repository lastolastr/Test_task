using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Test_task_nasonov
{
    class Program
    {
        //Составить алгоритм: если введенное число больше 7, то вывести “Привет”
        private static void Hello()
        {

            Console.WriteLine("Введите число");
            int a = Convert.ToInt32(Console.ReadLine()); //Считываем нажатую кнопку, конвертируем в int и записываем в переменную

            if (a > 7)                                  // проверяем условие
            {
                Console.WriteLine("Привет");
            }
        }

        //Составить алгоритм: если введенное имя совпадает с Вячеслав, то вывести “Привет, Вячеслав”, если нет, то вывести "Нет такого имени"
        private static void Name(string name)
        {
            if (name == "Vyacheclav" | name== "Вячеслав") // если имя Vyacheclav или  Вячеслав
            {
                Console.WriteLine("Привет, " + name);
            }
            else                                            // если нет, то выводим сообщение, что такого имени нет
            {
                Console.WriteLine("Нет такого имени");
            }
        }

        //Составить алгоритм: на входе есть числовой массив, необходимо вывести элементы массива кратные 3
        private static void Massiv(int[] nums)
        {
            Console.WriteLine("\n");
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 3 == 0)   // при остатке от деления на 3 равно нулю, тогда выводим на экран значение ячейки массива
                {
                    Console.Write(nums[i] + ",");
                }
            }

            Console.ReadKey();
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Выберите функцию:\n 1)Число;\n 2)Имя;\n 3)Массив; \n");

            ConsoleKeyInfo key = Console.ReadKey(); //записываем в переменную, кнопку, которую нажал пользователь

            switch (key.Key){                       // проверяем, что именно нажал пользователь

                case ConsoleKey.D1: // если 1, тогда используем функцию  hello
                    Hello();
                    break;
                case ConsoleKey.D2: // если 2, то вводим имя и вызываем функцию Name
                    Console.WriteLine("Введите имя: ");
                    string enter_name = Convert.ToString(Console.ReadLine());
                    Name(enter_name);
                    break;

                case ConsoleKey.D3: // если 3, тогда 
                    List<int> list = new List<int>();  //  создаём List в него будем записывать новые элементы массива как часть списка, чтобы потом весь список конвертировать в массив
                    ConsoleKeyInfo fin;                 // переменная для отслеживания ввода пользователя
                    int a=0;                            // вспомогательная переменная, для того, чтобы содержать в себе добавляемое значение в массив

                    Console.WriteLine("Введите массив и нажмите Enter ");
                    do
                    {
                        fin = Console.ReadKey(); // фиксируем ввод пользователя
                        Console.Write(",");
                        if (int.TryParse(fin.KeyChar.ToString(),out a)) // TryParse возвращает true если конвертация удалась и записалась в значение а
                        {
                            list.Add(a); // добавляемзначение в список
                        }
                        
                    }
                    while (fin.Key != ConsoleKey.Enter); // до тех пор пока пользователь не нажмёт Enter

                    int [] array = list.ToArray(); // конвертируем список в массив
                    Massiv(array);                  // вызываем функцию Massiv
                    break;


            }
        }
    }
}
