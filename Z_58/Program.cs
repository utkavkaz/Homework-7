// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1, 5);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3}\t");
        Console.WriteLine();
    }
}

void NewArray(int[,] array1, int[,] array2)
{
    int[,] array3 = new int[2, 2];
    for (int i = 0; i < array3.GetLength(1); i++)
        for (int j = 0; j < array3.GetLength(0); j++)
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                array3[i, j] = array3[i, j] + array1[i, k] * array2[k, j];
            }
    Console.WriteLine("Результирующая матрица");
    PrintArray(array3);
}

int[,] array1 = new int[2, 2];
int[,] array2 = new int[2, 2];

FillArray(array1);
FillArray(array2);

Console.WriteLine("Первый массив");
PrintArray(array1);
Console.WriteLine("Второй массив");
PrintArray(array2);

NewArray(array1, array2);