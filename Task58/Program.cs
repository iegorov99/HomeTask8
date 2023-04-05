// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] GenerateArray(int rows)
{
    int[,] array = new int[rows, rows];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < rows; j++)
            array[i, j] = new Random().Next(1, 10);
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
}

int[,] Proisvedenie(int[,] array1, int[,] array2, int[,] proisvedenie)
{
    for (int i = 0; i < array1.GetLength(0); i++)
        for (int j = 0; j < array2.GetLength(1); j++)
            for (int k = 0; k < array1.GetLength(0); k++)
                proisvedenie[i, j] += array1[i, k] * array2[k, j];
    return proisvedenie;
}

try
{
Console.Write("Введите количество строки столбцов: ");
int rows = Convert.ToInt32(Console.ReadLine());
int[,] array1 = GenerateArray(rows);
int[,] array2 = GenerateArray(rows);
int[,] proisvedenie = new int[rows, rows];
PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();
PrintArray(Proisvedenie(array1, array2, proisvedenie));
}
catch
{
    Console.WriteLine("Введено некорректное значение!");
}