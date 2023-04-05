// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],2}\t");
        Console.WriteLine();
    }
}

void MinSumNumberInRows(int[,] array, int[] sumInRows)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            sum += array[i, j];
        sumInRows[i] += sum;
        sum = 0;
    }

}

void IndexOfRow(int[] array)
{
    int indexMin = 0;
    for (int i = 1; i < array.Length; i++)
        if (array[i] < array[indexMin])
            indexMin = i;
    Console.WriteLine($"{indexMin + 1}-я строка имеет наименьшую сумму значений");
}

try
{
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество стобцов: ");
    int cols = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, cols];
    int[] sumInRows = new int[rows];
    FillArray(array);
    PrintArray(array);
    Console.WriteLine();
    MinSumNumberInRows(array, sumInRows);
    IndexOfRow(sumInRows);
}
catch
{
    Console.WriteLine("Введено некорректное значение!");
}