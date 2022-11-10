int[,] array = new int[3, 4];
FillArray(array, 0, 10);
System.Console.WriteLine("The array is:");
PrintArray(array);
SortArray(array);
System.Console.WriteLine("Sorted array is:");
PrintArray(array);
void FillArray(int[,] a, int min, int max)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            a[i, j] = new Random().Next(min, max + 1);
        }
    }
}
void PrintArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            System.Console.Write($"{a[i, j]} \t");
        }
        System.Console.WriteLine();
    }
}
void SortArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            for (int k = 0; k < a.GetLength(1); k++)
            {
                if (a[i, k] < a[i, j]) // Change the comparison here to go from descenging to ascenging and vice versa
                {
                    int temp = a[i, j];
                    a[i, j] = a[i, k];
                    a[i, k] = temp;
                }
            }
        }
    }
}