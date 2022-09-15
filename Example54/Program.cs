// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] FillMatrix(int rows, int columns)
{
    Random random = new Random();
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = random.Next(100);
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

int[,] SortRows(int[,] matrix)
{
    int columns = matrix.GetLength(1);
    int temp;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int m = 0; m < columns; m++)
        {
            for (int n = m + 1; n < columns; n++)
            {
                if (matrix[i, n] > matrix[i, m])
                {
                    temp = matrix[i, m];
                    matrix[i, m] = matrix[i, n];
                    matrix[i, n] = temp; 
                }
            }
        }
    }
    return matrix;
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

    int[,] sortedRowsMatrix = SortRows(matrix);
    Console.WriteLine("Отсортированная по строкам матрица:");
    PrintMatrix(sortedRowsMatrix);
}
catch 
{
    Console.WriteLine("Ошибка ввода!");
}