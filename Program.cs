// Найти произведение побочной диагонали матрицы

int[,] CreatedMatrix(int[,] array, int minVal, int maxVal)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minVal, maxVal);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

int SumMainDiagonal(int[,] array)
{
    int sumDiagonal = 0;
    for (int i = 0, j = 4; i < array.GetLength(0); j--, i++)
    {
        sumDiagonal = sumDiagonal + array[i, j];
    }


    return sumDiagonal;
}

int m = 5;
int n = 5;
int[,] Double = new int[m, n];
CreatedMatrix(Double, 1, 10);
PrintArray(Double);
System.Console.WriteLine();
int sumOfDiagonal = SumMainDiagonal(Double);
System.Console.WriteLine(sumOfDiagonal);
