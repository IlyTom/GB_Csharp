// Task2
/*Дан двумерный массив.

732

496

185

Отсортировать данные в нем по возрастанию.

123

456

789*/

int[,] a = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };

int[] arraySort = new int[a.GetLength(0) * a.GetLength(1)];

for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        if (i == 0)
        {
            arraySort[j] = a[i, j];
        }
        else if (i == 1)
        {
            arraySort[a.GetLength(0) + j] = a[i, j];
        }
        else if (i == 2)
        {
            arraySort[a.GetLength(1) + a.GetLength(0) + j] = a[i, j];
        }
    }
}

Array.Sort(arraySort);

for (int i = 0; i < arraySort.Length; i++)
{
    if (i <= 2)
    {
        a[0,i] = arraySort[i];
    }
    else if ((i > 2) && (i <= 5))
    {
        a[1,i-a.GetLength(0)] = arraySort[i];
    }
    else if ((i > 5) && (i <= 8))
    {
        a[2,i-a.GetLength(0)-a.GetLength(1)] = arraySort[i];
    }
}


for (int i = 0;i< a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        Console.Write($" {a[i,j]} ");
    }
    Console.WriteLine();
}
