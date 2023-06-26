int size = GetValidSizeFromUser();

Console.WriteLine("Tablica z zadania 1");
int[,] tab1 = new int[size, size];
Fill2dArrayPattern1(tab1);
Print2dArray(tab1);

Console.WriteLine();

Console.WriteLine("Tablica z zadania 2");
int[,] tab2 = new int[size, size];
Fill2dArrayPattern2(tab2);
Print2dArray(tab2);


int GetValidSizeFromUser()
{
    int size;
    while (true)
    {
        Console.Write("Podaj rozmiar tablicy: ");
        if (int.TryParse(Console.ReadLine(), out size) && size > 0)
        {
            return size;
        }
        else
        {
            Console.WriteLine("Niepoprawny rozmiar tablicy. Podaj poprawną liczbę.");
        }
    }
}

void Fill2dArrayPattern1(int[,] array)
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

void Fill2dArrayPattern2(int[,] array)
{
    int counter = 1;

    int rowStart = 0;
    int rowEnd = array.GetLength(0) - 1;
    int colStart = 0;
    int colEnd = array.GetLength(1) - 1;

    while (counter <= array.GetLength(0) * array.GetLength(1))
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

static void Print2dArray(int[,] array)
{
    int maxNumber = array.GetLength(0) * array.GetLength(1);
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