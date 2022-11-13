// принимаем число н, получаем таблицу квадратов от 1 до н. Например 3: 1, 4, 9
Console.WriteLine("Введите число:");
int n = int.Parse(Console.ReadLine()!);

for (int i = 1; i<=n; i++)
{
    double result = Math.Pow(i,2);
    Console.WriteLine(result);
}