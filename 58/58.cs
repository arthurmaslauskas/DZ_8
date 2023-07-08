// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
using System;
using static System.Console;
Clear();

WriteLine($"Write point matrix and Diaposition random elements");
int m = InputNumbers("Write num line first matrix: ");
int n = InputNumbers("Write num colums first matrix(And Line 2): ");
int k = InputNumbers("Write num coliums 2 matrix: ");
int range = InputNumbers("Write diaposition random elemnts:  for 1 to ");

int[,] firstMatrix = new int[m, n];
CreateArray(firstMatrix);
WriteLine($"First Matrix: ");
WriteArray(firstMatrix);

int[,] secomdMatrix = new int[n, k];
CreateArray(secomdMatrix);
WriteLine($"Two Matrix: ");
WriteArray(secomdMatrix);

int[,] resultMatrix = new int[m, k];

MultiplyMatrix(firstMatrix, secomdMatrix, resultMatrix);
WriteLine($"= First and two Matrix:");
WriteArray(resultMatrix);

void MultiplyMatrix(int[,] firstMatrix, int[,] secomdMatrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int l = 0; l < firstMatrix.GetLength(1); l++)
            {
                sum += firstMatrix[i, l] * secomdMatrix[l, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}

int InputNumbers(string input)
{
    Write(input);
    int output = Convert.ToInt32(ReadLine());
    return output;
}

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range);
        }
    }
}

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write(array[i, j] + " ");
        }
        WriteLine();
    }
}