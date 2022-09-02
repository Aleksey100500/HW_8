/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

int[,] matrix = new int[3,4] {{1,4,7,2}, {5,9,2,3}, {8,4,2,4}};

OutputMatrix(matrix);
Console.WriteLine($"-------");
Sort(matrix);
OutputMatrix(matrix);

void Sort (int[,] matrix)
{

  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      for (int k = 0; k < matrix.GetLength(1) - 1; k++)
      {
        if (matrix[i, k] < matrix[i, k + 1])
        {
          int kap = matrix[i, k + 1];
          matrix[i, k + 1] = matrix[i, k];
          matrix[i, k] = kap;
        }
      }
    }
  }
}

void OutputMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j =0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}" + " ");
        }
        Console.WriteLine();
    }
}