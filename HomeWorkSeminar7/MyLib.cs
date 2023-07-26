using System.Security.Cryptography.X509Certificates;

namespace HomeWorkSeminar7;
class MyLib
{
    public static int Input(string text)
    {
        Console.WriteLine(text);
        int number = Convert.ToInt32(Console.ReadLine());
        return number;
    }

    public static double[,] FillMultArray(int height, int weight)
    {
        Random random = new Random();
        double[,] multArray = new double[height, weight];
        double minValue = -10.5;
        double maxValue = 10.5;
        for (int i = 0; i < multArray.GetLength(0); i++)
        {
            for (int j = 0; j < multArray.GetLength(1); j++)
            {
                multArray[i, j] =Math.Round(random.NextDouble() * (maxValue -minValue) + minValue,1);
            }
        }
        return multArray;
    }
    public static void PrintMultArray(double[,] multArray)
    {
        for (int i = 0; i < multArray.GetLength(0); i++)
        {
            for (int j = 0; j < multArray.GetLength(1); j++)
            {
                Console.Write(multArray[i, j] + " ");
            }
            Console.WriteLine();
        }
        
    }
    public static int[,] FillMultArrayInt(int height, int weight)
    {
        int[,] multArray = new int[height,weight];
        Random random= new Random();
        for (int i = 0; i < multArray.GetLength(0);i++)
        {
            for(int j = 0; j < multArray.GetLength(1);j++)
            {
                multArray[i,j] = random.Next(1,10);
            }

        }
        return multArray;
    }
    public static void PrintArray(int [,] multArray)
    {
        for(int i = 0; i < multArray.GetLength(0);i++)
        {
            for(int j = 0;j < multArray.GetLength(1);j++)
            {
                Console.Write(multArray[i,j] +" ");
            }
            Console.WriteLine();
        }
    }
    public static void FindElementMultArray( int [,] multArray, int index1, int index2)
    {
        if(index1>multArray.GetLength(0)||index1<0||index2>multArray.GetLength(1)||index2<0)
        {
            Console.WriteLine($"Элемента с индексами ({index1}, {index2}) не существует в этом массиве! ");
        }
        else
        {
        for (int i = 0;i < multArray.GetLength(0); i++)
        {
            for(int j=0;j < multArray.GetLength(1);j++)
            {
                if(i==index1 && j==index2) Console.WriteLine($"На позиции ({index1}, {index2}) находится элемент {multArray[i,j]} ");
                
            }
        }
        }
    }


}

