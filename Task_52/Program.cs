// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] FillMatrix(int rowsCount, int columnsCount, int leftRange = -10, int rightRange = 10)
{
    int[,] matrix = new int[rowsCount, columnsCount];

    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return matrix;
} 
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = FillMatrix(3, 4);
Console.WriteLine("Случайный массив: ");
PrintMatrix(matrix);

Console.WriteLine ("Среднее арифметическое столбцов:");

for (int columnNumber = 0; columnNumber < matrix.GetLength(1); columnNumber++)
{
    double sum = 0;
    for (int rowNumber = 0; rowNumber < matrix.GetLength(0); rowNumber++)
    {
        sum = sum + matrix[rowNumber, columnNumber];
    }
    double average = sum / matrix.GetLength(0);

    if (columnNumber > 0)
    {
        Console.Write(", ");
    }


Console.Write($"{average:f2}");

}
Console.WriteLine (".");
