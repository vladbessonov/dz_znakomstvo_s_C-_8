/* Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

// функции
int[,] CriateBaseArray(int str = 3, int col = 4)
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
int[,] ChangedArray(int[,] baseArray)
{
    for (int str = 0; str < baseArray.GetLength(0); str++)
        for (int i = 0; i < baseArray.GetLength(1); i++)
            for (int j = baseArray.GetLength(1) - 1; j > i; j--)
                if (baseArray[str, j] > baseArray[str, j - 1])
                {
                    int tmp = baseArray[str, j];
                    baseArray[str, j] = baseArray[str, j - 1];
                    baseArray[str, j - 1] = tmp;
                }
    return baseArray;
}

// Создаем двумерный массив
int[,] baseArray = CriateBaseArray();
// выводим двумерный массив
PrintArray(baseArray, "Базовый массив: ");
// выводим отсортированный массив
PrintArray(ChangedArray(baseArray), "Отсортированный массив: ");












