/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

// функции
int[,] CriateBaseArray(int str = 2, int col = 2) 
{
    int[,] array = new int[str, col];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
}
void PrintArray(int[,] array, string msg)
{
    Console.WriteLine(msg);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
    }
    Console.WriteLine();
}

int[,] RezaltMatrix(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) != matrix2.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
    int[,] r = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                r[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return r;
}

// Создаем две матрицы
int[,] matrix1 = CriateBaseArray();
int[,] matrix2 = CriateBaseArray();
// выводим двумерные массивы
PrintArray(matrix1, "Матрица 1: ");
PrintArray(matrix2, "Матрица 2: ");
// перемножаем матрицы
int[,] compmatrix = RezaltMatrix(matrix1, matrix2);
// выводим результирующую матрицу
PrintArray(compmatrix, "Результирующая матрица: ");

