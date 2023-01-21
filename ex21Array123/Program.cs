Console.WriteLine("");

Console.WriteLine("Введите длину массива");
int length = int.Parse(Console.ReadLine()!);

int[] array = new int[length];

void RandomArray(int[] array) // Функция заполнения массива в случайном порядке
{
    Random random = new Random();
    for (int i= 0; i < length; i++)
{
    array[i] = random.Next(0, 123);
}
}

void PrintArray(int[] array) // Функция вывода массива в консоль
{
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine(array[i] + " ");
    }
}

RandomArray(array);
Console.Write("Массив в строку ");
Console.WriteLine();
PrintArray(array);
Console.WriteLine();

int count = 0;
for (int i = 0; i < length; i++)
{
    if (array[i] > 10 && array[i] < 100)
    count++;
}
Console.WriteLine("Количество 2ч значных чисел: " + count);