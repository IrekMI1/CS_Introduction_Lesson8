// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] FillMatrix3D(int rows, int columns, int layers)
{
    List<int> uniqueNumers = new List<int>();
    int number;
    Random random = new Random();
    int[,,] matrix3D = new int[rows, columns, layers];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < layers; k++)
            {
                do
                {
                    number = random.Next(100);
                } while (uniqueNumers.Contains(number));
                uniqueNumers.Add(number);
                matrix3D[i, j, k] = number;
            }
        }
    }
    return matrix3D;
}

void PrintMatrix3D(int[,,] matrix3D)
{
    for (int k = 0; k < matrix3D.GetLength(2); k++)
    {
        for (int i = 0; i < matrix3D.GetLength(0); i++)
        {
            for (int j = 0; j < matrix3D.GetLength(1); j++)
            {
                Console.Write($"{matrix3D[i, j, k]}({i},{j},{k})\t");
            }
            Console.WriteLine();
        }
    }
}

try
{
    Console.Write("Введите число строк: \t");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число столбцов:\t");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число слоев:  \t");
    int layers = Convert.ToInt32(Console.ReadLine());

    int[,,] matrix3D = FillMatrix3D(rows, columns, layers);
    Console.WriteLine("Трехмерный массив {0}x{1}x{2}:", rows, columns, layers);
    PrintMatrix3D(matrix3D);   
}
catch 
{
    Console.WriteLine("Ошибка ввода!");
}