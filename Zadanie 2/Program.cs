const int size = 10;
int[,] tab = new int[size, size];
Fill2dArray(tab);
Print2dArray(tab);

void Fill2dArray(int[,] array)
{
    int counter = 1;
    int rowStart = 0;
    int rowEnd = array.GetLength(0) - 1;
    int colStart = 0;
    int colEnd = array.GetLength(1) - 1;
    
    while (counter <= size * size)
    {
        for (int i = colStart; i <= colEnd; i++)
        {
            array[rowStart, i] = counter++;
        }

        rowStart++;

        for (int i = rowStart; i <= rowEnd; i++)
        {
            array[i, colEnd] = counter++;
        }

        colEnd--;

        for (int i = colEnd; i >= colStart; i--)
        {
            array[rowEnd, i] = counter++;
        }

        rowEnd--;

        for (int i = rowEnd; i >= rowStart; i--)
        {
            array[i, colStart] = counter++;
        }

        colStart++;
    }
}

void Print2dArray(int[,] array)
{
    int maxNumber = array.GetLength(0) * array.GetLength(1);
    int maxNumberWidth = maxNumber.ToString().Length;
    
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            Console.Write($"{array[i, j].ToString().PadRight(maxNumberWidth)} ");
        }

        Console.WriteLine();
    }
}