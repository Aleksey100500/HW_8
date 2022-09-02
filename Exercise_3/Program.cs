/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/
int[,] arrayOne = new int[2,2]{{2,4},
                               {3,2}};
int[,] arrayTwo = new int[2,2]{{3,4},
                               {3,3}};
int[,] arrayResult = new int[2,2];

OutputArray(arrayOne);
Console.WriteLine("---");
OutputArray(arrayTwo);

MyltArray(arrayOne, arrayTwo, arrayResult);
Console.WriteLine("Результат: ");
OutputArray(arrayResult);

void MyltArray(int[,] arrayOne, int[,] arrayTwo, int[,] arrayResult)
{
    for(int i = 0; i < arrayResult.GetLength(0); i++)
    {
        for (int j = 0; j < arrayResult.GetLength(1); j++)
        {
            int sum = 0;
            for ( int k = 0; k < arrayOne.GetLength(1);k++)
            {
                sum += arrayOne[i,k] * arrayTwo[k,j];
            }
            arrayResult[i,j] = sum;
        }
    }
}


void OutputArray(int[,] arrayOne)
{
    for(int i = 0; i < arrayOne.GetLength(0); i++)
    {
        for(int j =0; j < arrayOne.GetLength(1); j++)
        {
            Console.Write($"{arrayOne[i,j]}" + " ");
        }
        Console.WriteLine();
    }
}