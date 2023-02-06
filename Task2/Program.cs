/* Задача 50. Напишите программу, которая на вход принимает 
позиции элемента в двумерном массиве, и возвращает значение 
этого элемента или же указание, что такого элемента нет.*/ 
System.Console.WriteLine("Введите номер строки");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите номер столбца");
int n = Convert.ToInt32(Console.ReadLine());
var mass = GenerateArray(5, 5);
PrintArray(mass);
System.Console.WriteLine();
FindPosition(mass, m, n);

void FindPosition(int[,] arr, int m, int n)
{
  if(m > arr.GetLength(0) || n > arr.GetLength(1))
  {
    System.Console.WriteLine("Элемента нет");
  }
  else
  {
    System.Console.WriteLine(arr[m, n]);
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
