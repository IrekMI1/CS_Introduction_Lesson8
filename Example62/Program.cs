// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

void PrintMatrix(string[,] table)
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

string[,] FillSpiralMatrix(int rows, int columns)
{
    string[,] matrix = new string[rows, columns];
    int row, column, cycle, number, lastNumber;
    row = column = cycle = 0;
    number = 1;
    lastNumber = rows * columns;

    while (number <= lastNumber)
    {
        while (column < columns - cycle && number <= lastNumber)
        {
            if (number < 10) matrix[row, column] = "0" + $"{number}";
            else matrix[row, column] = $"{number}";
            number++;
            column++;
        }

        row++; column--;

        while (row < rows - cycle && number <= lastNumber)
        {
            if (number < 10) matrix[row, column] = "0" + $"{number}";
            else matrix[row, column] = $"{number}";
            number++;
            row++;
        }

        row--; column--;

        while (column >= 0 + cycle && number <= lastNumber)
        {
            if (number < 10) matrix[row, column] = "0" + $"{number}";
            else matrix[row, column] = $"{number}";
            number++;
            column--;
        }

        row--; column++;

        while (row > 0 + cycle && number <= lastNumber)
        {
            if (number < 10) matrix[row, column] = "0" + $"{number}";
            else matrix[row, column] = $"{number}";
            number++;
            row--;
        }

        row++; column++;
        cycle++;
    }
    return matrix;
}

try
{
    Console.Write("Введите число строк: \t");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число столбцов:\t");
    int columns = Convert.ToInt32(Console.ReadLine());

    string[,] spiralMatrix = FillSpiralMatrix(rows, columns);
    Console.WriteLine("Спиральный массив {0}x{1}:", rows, columns);
    PrintMatrix(spiralMatrix);
}
catch
{
    Console.WriteLine("Ошибка ввода!");
}