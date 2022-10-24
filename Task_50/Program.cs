// Задача 50. Напишите программу, которая на вход принимает позиции элемента
//в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

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

int m = 4;
int n = 4;

int[,] matrix = FillMatrix(m, n);
Console.WriteLine("Наша матрица:"); 
PrintMatrix(matrix);

Console.WriteLine("Введите позиции элемента i и j через Enter"); 
int numI = Convert.ToInt32(Console.ReadLine());
int numJ = Convert.ToInt32(Console.ReadLine());

if ((numI <= 0 || numI >= matrix.GetLength(0)) || (numJ <= 0 || numJ >= matrix.GetLength(1)))
{
    Console.WriteLine("Такого элемента не существует");
    return;
}

Console.WriteLine($"Заданный элемент равен {matrix[numI - 1, numJ - 1]}");
