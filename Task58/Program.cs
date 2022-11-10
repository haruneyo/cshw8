int[,] array1 = new int[2, 2];
int[,] array2 = new int[2, 2];
FillArray(array1, 0, 10);
FillArray(array2, 0, 10);
System.Console.WriteLine("The first array is:");
PrintArray(array1);
System.Console.WriteLine("The second array is:");
PrintArray(array2);
System.Console.WriteLine("The pdocut of the two arrays is:");
PrintArray(MatrixProduct(array1, array2));
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
int[,] MatrixProduct(int[,] a1, int[,] a2)
{
    int[,] product = new int[2, 2];
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int k = 0; k < 2; k++)
            {
                product[i, j] += a1[i, k] * a2[k, j];
            }
        }
    }
    return product;
}