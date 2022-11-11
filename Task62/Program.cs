int[,] array = new int[4, 4];
FillArray(array);
PrintArray(array);
void FillArray(int[,] a)
{
    int i = 0;
    int j = 0;
    int count = 1;
    int iteration = 0;
    while (count <= a.GetLength(0) * a.GetLength(1))
    {
        while (j < a.GetLength(1) - iteration)
        {
            a[i, j] = count;
            j++;
            count++;
        }
        j--;
        i++;
        while (i < a.GetLength(0) - iteration)
        {
            a[i, j] = count;
            i++;
            count++;
        }
        i--;
        j--;
        while (j >= 0 + iteration)
        {
            a[i, j] = count;
            j--;
            count++;
        }
        j++;
        i--;
        while (i >= 1 + iteration)
        {
            a[i, j] = count;
            i--;
            count++;
        }
        i++;
        j++;
        iteration++;
    }
}
void PrintArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            Console.Write("{0,10:D2}", array[i, j]);
        }
        System.Console.WriteLine();
    }
}