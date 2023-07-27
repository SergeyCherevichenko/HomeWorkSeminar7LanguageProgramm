using System.Globalization;
using System.Runtime.Serialization.Formatters;

namespace HomeWorkSeminar7;
class Program
{
    static void Main(string[] args)
    {
        void task47()
        {
            // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, округлёнными до одного знака.

            // m = 3, n = 4.
            // 0,5 7 -2 -0,2
            // 1 -3,3 8 -9,9
            // 8 7,8 -7,1 9

            int m = MyLib.Input("Введите высоту двумерного массива: ");
            int n = MyLib.Input("Введите ширину двумерного массива: ");
            double[,] multArray = MyLib.FillMultArray(m, n);
            MyLib.PrintMultArray(multArray);
        }

        void task50()
        {
            // Задача 50. Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, и возвращает значение
            // этого элемента или же указание, что такого элемента нет. Например, задан массив:

            // 1 4 7 2
            // 5 9 2 3
            // 8 4 2 4

            // 1, 3 -> 3

            int[,] multArray = MyLib.FillMultArrayInt(5, 6);

            MyLib.PrintArray(multArray);
            int height = MyLib.Input("Введите индекс 1 элемента двумерного массива, значение который вы хотите узнать: ");
            int weight = MyLib.Input("Введите индекс 2 элемента двумерного массива,значение который вы хотите узнать:  ");
            MyLib.FindElementMultArray(multArray, height, weight);


        }

        void task52()
        {
            // Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
            // Например, задан массив:
            // 1 4 7 2
            // 5 9 2 3
            // 8 4 2 4
            //Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

            int[,] multArray = MyLib.FillMultArrayInt(3, 4);
            MyLib.PrintArray(multArray);

            for (int i = 0; i < multArray.GetLength(1); i++)
            {
                double sumColumn = 0;
                int count = 0;
                for (int j = 0; j < multArray.GetLength(0); j++)
                {
                    sumColumn += multArray[j, i];
                    count++;
                }
                Console.WriteLine($"Среднее арифметическое  {i} столбца = {Math.Round(sumColumn / count, 1)}");
            }
        }

        void task1()
        {
            // Задача 1. Даны две матрицы, количество строк и столбцов которых может быть 3 или 4, заполнены числами от -9 до 9.
            // Выполните умножение матриц.

            int[,] matrix1 = MyLib.FillMultArrayInt(3, 4);
            int[,] matrix2 = MyLib.FillMultArrayInt(4, 3);

            MyLib.PrintArray(matrix1);
            Console.WriteLine("---------------------");
            MyLib.PrintArray(matrix2);
            Console.WriteLine("------------------------");

            if (matrix1.GetLength(1) == matrix2.GetLength(0))
            {
                int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

                for (int i = 0; i < matrix1.GetLength(0); i++)
                {

                    for (int j = 0; j < matrix2.GetLength(1); j++)
                    {
                        matrix3[i, j] = 0;
                        for (int k = 0; k < matrix1.GetLength(1); k++)
                        {
                            matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
                        }
                    }
                }

                MyLib.PrintArray(matrix3);


            }

            else if (matrix1.GetLength(0) == matrix2.GetLength(1))
            {
                int[,] matrix3 = new int[matrix1.GetLength(1), matrix2.GetLength(0)];

                for (int i = 0; i < matrix3.GetLength(1); i++)
                {
                    for (int j = 0; j < matrix3.GetLength(0); j++)
                    {
                        matrix3[i, j] = 0;
                        for (int k = 0; k < matrix1.GetLength(0); k++)
                        {
                            matrix3[i, j] += matrix1[i, k] * matrix2[k, j];

                        }
                    }
                }

                MyLib.PrintArray(matrix3);

            }
            else
            {
                Console.WriteLine("Матрицы не соответствуют правилу умноженния матриц!");
            }
        }

        void task2()
        {
            // Задача 2. Двумерный массив размером 3х4 заполнен числами от 100 до 9999.
            // Найдите в этом массиве и сохраните в одномерный массив все числа, сумма цифр которых
            // больше их произведения. Выведите оба массива.

            int[,] multArray = MyLib.FillMultArrayInt(3, 4);
            int count = 0;



            for (int i = 0; i < multArray.GetLength(0); i++)// Цикл чтобы узнать на какой размер будет одномерный массив
            {
                for (int j = 0; j < multArray.GetLength(1); j++)
                {
                    int sum = 0;
                    int mult = 1;
                    int temp = multArray[i, j];

                    while (temp > 0)
                    {
                        sum = sum + temp % 10;
                        mult = mult * (temp % 10);

                        temp = temp / 10;
                    }
                    if (sum > mult)
                    {
                        count++;
                    }


                }

            }

            int[] array = new int[count];
            int k = 0;

            for (int i = 0; i < multArray.GetLength(0); i++)// Заполняем одномерный массив исходя из условия
            {
                for (int j = 0; j < multArray.GetLength(1); j++)
                {
                    int sum = 0;
                    int mult = 1;
                    int temp = multArray[i, j];

                    while (temp > 1)
                    {
                        sum = sum + temp % 10;
                        mult = mult * (temp % 10);
                        temp = temp / 10;
                    }
                    if (sum > mult)
                    {
                        array[k] = multArray[i, j];
                        k++;
                    }

                }

            }
            MyLib.PrintArray(multArray);
            Console.WriteLine("-------------------------");
            for (int i = 0; i < k; i++)
            {
                Console.Write(array[i] + "  ");
            }

        }

        void task3()
        {
            // Задача 3. Двумерный массив размером 5х5 заполнен случайными нулями и единицами.
            // Игрок может ходить только по полям, заполненным единицами. Проверьте, существует ли путь
            // из точки [0, 0] в точку [4, 4] (эти поля требуется принудительно задать равными единице).


            int[,] multArray = MyLib.FillMultArrayInt(5, 5);
            multArray[0, 0] = 1;
            multArray[4, 4] = 1;
            string str = "Ура";
            MyLib.PrintArray(multArray);
            for (int i = 0; i < 4; i++)
            {
                
                for (int j = 0; j < 4; j++)
                {
                    if (multArray[i + 1, j] != 1 || multArray[i, j + 1] != 1) str = "Пути нет!";
                    
                }
            }
            Console.WriteLine(str);








           




        }




        int task = MyLib.Input("Введите номер задачи 47, 50, 52, 1, 2 или 3:");
        switch (task)
        {
            case 47: task47(); break;
            case 50: task50(); break;
            case 52: task52(); break;
            case 1: task1(); break;
            case 2: task2(); break;
            case 3: task3(); break;
            default: Console.WriteLine("Задачи с таким номмером не существует!"); break;
        }



    }
}
