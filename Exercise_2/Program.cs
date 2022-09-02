/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

int[,] array = new int[4,4]{{1,4,7,2}, {5,9,2,3}, {8,4,2,4,}, {5,2,6,7}};



int minHorSum = 0;
int horSum = Sum(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int horSumLine = Sum(array, i);
  if (horSum > horSumLine)
  {
    horSum = horSumLine;
    minHorSum = i;
  }
}

OutputArray(array);

Console.WriteLine($"{minHorSum+1} - строкa");
Console.WriteLine($"{minHorSum+1} = {horSum}");


int Sum(int[,] array, int i)
{
  int horSum = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    horSum += array[i,j];
  }
  return horSum;
}

void OutputArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j =0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}" + " ");
        }
        Console.WriteLine();
    }
}