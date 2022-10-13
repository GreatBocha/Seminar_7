void homework47()
{
    // Задача 47. Задайте двумерный массив размером m×n,
    // заполненный случайными вещественными числами.

    Console.Clear();
    Console.Write("Введите m: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите n: ");
    int n = Convert.ToInt32(Console.ReadLine());
    double[,] array = new double[m, n];
    FillArray(array);
    PrintArray(array);

}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(Math.Round(array[i, j], 2) + "\t");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] array)
{
    Random generator = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = generator.Next(-100, 100) * 0.15;
        }
    }
}