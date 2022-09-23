Console.WriteLine("Введите количество строк: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int b = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[a, b];
FillArray(numbers);

for (int j = 0; j < numbers.GetLength(1); j++)
{
    double avg = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        avg = (avg + numbers[i, j]);
    }
    avg = avg / a;
    Console.Write(avg + "; ");
}

Console.WriteLine();


PrintArray(numbers);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 15);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}