using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Helloy!!");


            bool fuck = true;

            do
            {
                Console.WriteLine("Введите два числа!");


                try
                {
                    string str1 = Console.ReadLine();
                    int a = Convert.ToInt32(str1);
                    string str2 = Console.ReadLine();
                    int b = Convert.ToInt32(str2);
                    int result = (a + b) / 2;
                    Console.WriteLine("Результат: " + result);
                    fuck = false;
                }
                catch
                {
                    Console.WriteLine("вы ввели не число(");
                    fuck = true;
                }
            }
            while (fuck);




            Console.ReadKey();
            Console.WriteLine("Введите три числа!");
            string str3 = Console.ReadLine();
            int c = Convert.ToInt32(str3);
            string str4 = Console.ReadLine();
            int d = Convert.ToInt32(str4);
            string str5 = Console.ReadLine();
            int e = Convert.ToInt32(str5);
            int result2 = c + d + e;
            int result3 = c * d * e;
            Console.WriteLine("Результат сложения " + result2 + " и произведения " + result3);
            Console.ReadKey();

            Console.WriteLine("Введите число");
            int a = int.Parse(Console.ReadLine());
            //int b=a%2;

            if (a % 2 == 0)
            {
                Console.WriteLine("Четное");
            }
            else
            {
                Console.WriteLine("Не четное");
            }
            Console.ReadLine();

            while (true)
            {
                Console.WriteLine("Введите диапазон в котором будет выполнен подсчет");

                Console.WriteLine();

                int minNumber;
                int maxNumber;

                try
                {
                    Console.WriteLine("начало диапазона:");
                    minNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("Конец диапазона");
                    maxNumber = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Неправильный ввод!");
                    Console.ReadLine();
                    continue;
                }


                int chetnoeChislo = 0;
                int heChetnoeChislo = 0;

                while (minNumber < maxNumber)
                {
                    if (minNumber % 2 == 0)
                    {
                        chetnoeChislo++;
                    }
                    else
                    {
                        heChetnoeChislo++;
                    }
                    minNumber++;
                }

                Console.WriteLine("Количество четных чисел равно " + chetnoeChislo);
                Console.WriteLine("Количество не четных чисел равно " + chetnoeChislo);
                Console.ReadLine();

                int count = 1;
                int heights = 5;


                for (int k = 0; k < count; k++)
                {
                    for (int i = 0; i < heights; i++)
                    {

                        for (int j = 0; j <= i; j++)
                        {
                            Console.Write("#");
                        }

                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    for (int i = 0; i < heights; i++)
                    {

                        for (int j = heights; j > i; j--)
                        {
                            Console.Write("#");
                        }

                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    ///////////////////////////////////////////////////////

                    for (int i = 0; i < heights; i++)
                    {

                        for (int j = heights; j > i; j--)
                        {
                            Console.Write(" ");

                        }
                        for (int h = 0; h <= i; h++)
                        {
                            Console.Write("#");
                        }


                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();


                    for (int i = 0; i < heights; i++)
                    {

                        for (int j = heights - i; j > 0; j--)
                        {
                            Console.Write("#");

                        }
                        for (int h = 0; h <= i; h++)
                        {
                            Console.Write(" ");
                        }


                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }

                Console.ReadLine();

                Console.Write("Введите размер масива:\t");
                int sizeArrey = int.Parse(Console.ReadLine());
                int[] myArrey = new int[sizeArrey];
                int sum = 0;
                int min = int.MaxValue;
                Console.WriteLine();
                for (int i = 0; i < myArrey.Length; i++)
                {
                    Console.Write("Заполните " + i + " элемент массива:\t");
                    myArrey[i] = int.Parse(Console.ReadLine());
                    if (myArrey[i] % 2 == 0)
                        sum += myArrey[i];
                    if (min > myArrey[i])
                        min = myArrey[i];

                }
                Console.WriteLine();
                Console.WriteLine("Молодец");
                Console.WriteLine();
                Console.WriteLine("Вот массив в обратном порядке:");
                for (int i = myArrey.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine(myArrey[i]);
                }
                Console.WriteLine();

                Console.WriteLine("А вот сумма четных чисел в этом масиве: " + sum);
                Console.WriteLine();

                Console.WriteLine("А это самое маленькое число в масиве: " + min);
                Console.WriteLine();

                Console.ReadLine();

                //Console.WriteLine(myArray.Rank); //количество измерений массива
                //Console.WriteLine(myArray.GetLength(0));  //количество элементов в измерении

                int[,] myArray = new int[,]
                {
                {34,45,56,67,78 },
                {23,65,79,12,3 },
                {92,69,3,17,92 }
                };

                int height = myArray.GetLength(0);
                int width = myArray.GetLength(1);

                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        Console.Write(myArray[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

                Console.Read();
                //Console.WriteLine(myArray.Rank); //количество измерений массива
                //Console.WriteLine(myArray.GetLength(0));  //количество элементов в измерении

                string[,] myArray = new string[2, 3];


                int height = myArray.GetLength(0);
                int width = myArray.GetLength(1);

                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        myArray[i, j] = Console.ReadLine();
                    }
                    Console.WriteLine();
                }

                Console.Read();
            }
        }
        public static void Resize<T>(ref T[] arr, int add)
        {
            T[] tempArray = new T[arr.Length];
            int length;

            for (int i = 0; i < arr.Length; i++)
            {
                tempArray[i] = arr[i];
            }

            length = arr.Length + add;

            if (length >= 0)
                arr = new T[length];
            else
                length = 0;
            arr = new T[length];

            length = tempArray.Length < arr.Length ? length = tempArray.Length : length = arr.Length;

            for (int i = 0; i < length; i++)
            {

                arr[i] = tempArray[i];
            }
        }

        private static void Resize3(ref int[] arr, int element, int index)
        {
            int[] tempArrey = new int[arr.Length + 1];

            if (index > tempArrey.Length)
                index = tempArrey.Length - 1;
            if (index < 0) index = 0;
            tempArrey[index] = element;

            int rightAdd = 0;

            for (int i = 0; i < tempArrey.Length; i++)
            {


                if (i == index)
                {
                    rightAdd = -1;
                    continue;
                }

                tempArrey[i] = arr[i + rightAdd];
            }

            arr = tempArrey;

        }
    }
}
