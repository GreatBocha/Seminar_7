void homework50()
{
    // Задача 50. Напишите программу, которая на вход принимает
    // позиции элемента в двумерном массиве, и возвращает
    // значение этого элемента или же указание, что такого элемента нет.

    Console.Clear();

    Random random = new Random();
    int rows = random.Next(1, 9);
    int columns = random.Next(1, 9);
    int[,] arrayNew = new int[rows, columns];
    FillArrayInt(arrayNew);
    PrintArrayNew(arrayNew);
    FindElementValue(arrayNew, rows, columns);

}
void FillArrayInt(int[,] array)
{
    Random generator = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = generator.Next(-10, 11);
        }
    }
}

void PrintArrayNew(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
void FindElementValue(int[,] elementArray, int rows, int columns)
{
    Console.Write("Введите индекс строки: ");
    int k = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите индекс столбца: ");
    int l = Convert.ToInt32(Console.ReadLine());
    if (k < rows & l < columns)
    { Console.WriteLine(elementArray[k, l]); }
    else { Console.WriteLine("Элемента с такой позицией в массиве нет!"); }
}