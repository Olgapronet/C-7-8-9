// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int n=4;
int[,] arr = new int[n, n];

int num = 1;
int i = 0;
int j = 0;

while (num <= 4 * 4)
{
    arr[i, j] = num;
    if (i <= j + 1 && i + j < n - 1)
        ++j;
    else if (i < j && i + j >= n - 1)
        ++i;
    else if (i >= j && i + j > n - 1)
        --j;
    else
        --i;
    ++num;
}

PrintArray(arr);

void PrintArray(int[,] arr)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
        System.Console.Write(String.Format("{0,5}", (arr[i, j])));
        }
    System.Console.WriteLine();
    }
}
