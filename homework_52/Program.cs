void homework52()
{
    // Задача 52. Задайте двумерный массив из целых чисел.
    // Найдите среднее арифметическое элементов в каждом столбце.

    Console.Clear();

    Random random = new Random();
    int rows = random.Next(2, 9);
    int columns = random.Next(2, 9);
    int[,] arrayOfInteger = new int[rows, columns];
    FillArrayInt(arrayOfInteger);
    PrintArrayNew(arrayOfInteger);
    AverageElementArray(arrayOfInteger);
}

void AverageElementArray(int[,] arrayElemAverage)
{
    double rowsSize = arrayElemAverage.GetLength(0);
    int columnsSize = arrayElemAverage.GetLength(1);
    for (int iColumns = 0; iColumns < columnsSize; iColumns++)
    {
        double sumColumnsElement = 0;
        double сolumnsAverage = 0;
        for (int iRows = 0; iRows < rowsSize; iRows++)
        {
            sumColumnsElement = sumColumnsElement + arrayElemAverage[iRows, iColumns];
        }
        сolumnsAverage = sumColumnsElement / rowsSize;   //мы здесь переменную rowsSize использовали вместо количества элементов столбца массива
        Console.WriteLine($"Среднее арифметическое элементов {iColumns + 1}го столбца:  {Math.Round(сolumnsAverage, 2)}");
    }
}
