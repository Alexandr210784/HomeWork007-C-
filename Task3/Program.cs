// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
var arr = GenerateArray(5, 5);
PrintArray(arr);
System.Console.WriteLine();
Sum(arr);

void Sum(int[,] arr)
{
    for(int j = 0; j < arr.GetLength(1); j++)
    {
        double sum = 0;
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            sum = arr[i, j] + sum;
        }
        sum = sum / arr.GetLength(0);
        System.Console.Write(sum + "; ");
    }
}

int[,] GenerateArray(int m, int n)
{
    int[,] result = new int[m, n];
    {
        for(int i = 0; i < result.GetLength(0); i++)
        {
            for(int j = 0; j < result.GetLength(1); j++)
            {
                    result[i, j] = new Random().Next(1, 10);
            }
        }
    }
    return result;
}

void PrintArray(int[,] arr)
{
        {
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            for(int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}