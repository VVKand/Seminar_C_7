// Задача HARD SORT необязательная. Считается за три обязательных
// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. 
// Отсортировать элементы по возрастанию слева направо и сверху вниз.

// Например, задан массив:
// 1 4 7 2
// 5 9 10 3

// После сортировки
// 1 2 3 4
// 5 7 9 10


Console.Write($"Введите количество строк массива: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int b = Convert.ToInt32(Console.ReadLine());
int c = a * b;
int[] mas = new int[c];
int[,] matrix = new int[a, b];

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
Conv(matrix);
Console.WriteLine();
BubbleSort(mas);
Console.WriteLine();
Conv2(matrix);
PrintArray(matrix);


void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(10, 100);
        }
    }
}

void Conv(int[,] matr)
{
    int z = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            mas[z] = matr[i, j]; 
            // Console.Write(mas[z] + " ");
            z++;
        }
}

void BubbleSort(int[] sort)
{
    for (int i = 0; i < sort.Length; i++)
    {
        for (int j = i + 1; j < sort.Length; j++)
        {
            if (sort[i] > sort[j])
            {
                int temp = sort[i];
                sort[i] = sort[j];
                sort[j] = temp;
                
            }
        }
        
        // Console.Write(sort[i] +" ");
    }

}

void Conv2(int[,] matr)
{
    int e = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = mas[e];
            e++;
        }
    }
}