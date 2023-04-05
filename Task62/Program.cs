// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void FillArray(int[,] array, int rowsCols)
{
    int rows = rowsCols;
    int cols = rowsCols;
    int s = 1;
    for (int j = 0; j < cols; j++)
    {
        array[0, j] = s;
        s++;
    }
    for (int i = 1; i < rows; i++)
    {
        array[i, cols - 1] = s;
        s++;
    }
    for (int j = cols - 2; j >= 0; j--)
    {
        array[rows - 1, j] = s;
        s++;
    }
    for (int i = rows - 2; i > 0; i--)
    {
        array[i, 0] = s;
        s++;
    }
    int k = 1;
    int l = 1;
    while (s < rows * cols)
    {
        while (array[k, l + 1] == 0)
        {
            array[k, l] = s;
            s++;
            l++;
        }
        while (array[k + 1, l] == 0)
        {
            array[k, l] = s;
            s++;
            k++;
        }
        while (array[k, l - 1] == 0)
        {
            array[k, l] = s;
            s++;
            l--;
        }
        while (array[k - 1, l] == 0)
        {
            array[k, l] = s;
            s++;
            k--;
        }
    }
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            if (array[i, j] == 0)
            {
                array[i, j] = s;
            }
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3} ");
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк и столбцов: ");
int rowsCols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rowsCols, rowsCols];
FillArray(array, rowsCols);
PrintArray(array);