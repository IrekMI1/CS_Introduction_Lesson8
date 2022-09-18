// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] FillMatrix(int rows, int columns)
{
    Random random = new Random();
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = random.Next(11);
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

int[,] MultiplyMatrix(int[,] table1, int[,] table2)
{
    int[,] result = new int[table1.GetLength(0), table2.GetLength(1)];

    for (int i = 0; i < table1.GetLength(0); i++)
    {
        for (int j = 0; j < table2.GetLength(1); j++)
        {
            for (int m = 0; m < table1.GetLength(1); m++)
            {
                result[i, j] +=  table1[i, m] * table2[m, j];
            }
        }
    }
    return result;
}

try
{
    int[] rows = new int[2];
    int[] columns = new int[2];
    int[][,] tables = new int[2][,];

    for (int i = 0; i < 2; i++)
    {
        Console.Write("Введите число строк {0}-й матрицы: \t", i + 1);
        rows[i] = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число столбцов {0}-й матрицы:\t", i + 1);
        columns[i] = Convert.ToInt32(Console.ReadLine());
        tables[i] = FillMatrix(rows[i], columns[i]);
        Console.WriteLine("{0}-й исходный массив {1}x{2}:", i + 1, rows[i], columns[i]);
        PrintMatrix(tables[i]);
    }

    if (columns[0] == rows[1])
    {
        Console.WriteLine("Результат произведения двух матриц:");
        PrintMatrix(MultiplyMatrix(tables[0], tables[1]));
    }
    else Console.WriteLine("Матрицы не согласованные, произведение невозможно.");
    
}
catch 
{
    Console.WriteLine("Ошибка ввода!");
}