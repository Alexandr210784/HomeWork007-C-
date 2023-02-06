/* Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами. */

PrintArray(GenerateArray(3, 4));

double[,] GenerateArray(int m, int n)
{
    double[,] result = new double[m, n];
    {
        for(int i = 0; i < result.GetLength(0); i++)
        {
            for(int j = 0; j < result.GetLength(1); j++)
            {
                    result[i, j] = new Random().Next(-10, 10);
            }
        }
    }
    return result;
}

void PrintArray(double[,] arr)
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
