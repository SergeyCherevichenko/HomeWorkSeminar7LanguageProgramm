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
                Console.WriteLine($"Среднее арифметическое  {i} столбца = {Math.Round(sumColumn/count,1)}");
            }
        }

        int task = MyLib.Input("Введите номер задачи 47, 50 или 52");
        switch (task)
        {
            case 47:task47(); break;
            case 50:task50(); break;
            case 52:task52(); break;
            default:Console.WriteLine("Задачи с таким номмером не существует!");break;
        }
        
        
        
    }
}
