// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. 
// 3 -> 1, 8, 27
Console.WriteLine("Введите число:");
int n = int.Parse(Console.ReadLine()!);

for (int i = 1; i<=n; i++)
{
    double result = Math.Pow(i,3);
    Console.WriteLine(result);
}