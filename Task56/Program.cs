int[,] array = new int[5, 5];
FillArray(array, 0, 10);
System.Console.WriteLine("The array is:");
PrintArray(array);
FindMin(SumOfArrayRows(array));
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
int[] SumOfArrayRows(int[,] a)
{
    int[] holder = new int[a.GetLength(0)];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < a.GetLength(1); j++)
        {
            sum += a[i, j];
        }
        holder[i] = sum;
    }
    return holder;
}
void FindMin(int[] a)
{
    int index = 0;
    int min = a[0];
    for (int i = 1; i < a.Length; i++)
    {
        if (a[i] < min)
        {
            min = a[i];
            index = i;
        }
    }
    System.Console.WriteLine($"The lowest sum of the elements is in the {index + 1} row and is equal to: {min}");
}