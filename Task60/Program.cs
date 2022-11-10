int[,,] array = new int[2, 2, 2] {{{12, 43}, {77, 47}}, 
                                  {{98, 35,}, {86, 53}}};
System.Console.WriteLine("The array is:");
PrintArray(array);
void PrintArray(int[,,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            for (int k = 0; k < a.GetLength(2); k++)
            {
                System.Console.Write($"{a[i, j, k]}({i}, {j}, {k}) \t");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
}