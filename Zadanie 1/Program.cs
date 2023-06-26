const int size = 10;
int[,] tab = new int[size, size];
Fill2dArray(tab);
Print2dArray(tab);

void Fill2dArray(int[,] array)
{
    int counter = 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i % 2 == 0)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = counter++;
            }
        }
        else
        {
            for (int j = array.GetLength(1) - 1; j >= 0; j--)
            {
                array[i, j] = counter++;
            }
        }
    }
}

void Print2dArray(int[,] array)
{
    int maxNumber = array.GetLength(0) * array.GetLength(1) - 1;
    int maxNumberWidth = maxNumber.ToString().Length;
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j].ToString().PadRight(maxNumberWidth)} ");
        }

        Console.WriteLine();
    } 
}

