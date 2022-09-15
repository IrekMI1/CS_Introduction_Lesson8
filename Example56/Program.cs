// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] FillMatrix(int rows, int columns)
{
    Random random = new Random();
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = random.Next(20);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write("{0} \t", table[i, j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int FindLeastSumRow(int[,] matrix)
{
    int[] sum = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum[i] += matrix[i, j];
        }
    }
    return Array.IndexOf(sum, sum.Min()) + 1;
}

try
{
    Console.Write("Введите число строк: \t");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число столбцов:\t");
    int columns = Convert.ToInt32(Console.ReadLine());

    int[,] matrix = FillMatrix(rows, columns);
    Console.WriteLine("Исходный массив {0}x{1}:", rows, columns);
    PrintMatrix(matrix);
    Console.WriteLine("Строка с наименьшей суммой элементов: {0}", FindLeastSumRow(matrix));
}
catch 
{
    Console.WriteLine("Ошибка ввода!");
}