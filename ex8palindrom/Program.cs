// принимаем число пятизначное число, проверяем палиндром или нет. Например 12821 -> да
Console.WriteLine("Введите число:");
int n = int.Parse(Console.ReadLine()!);

int a = n / 10000;
int b = n % 10;
if(a == b)
{
    int c = n % 10000 / 1000;
    int d = n % 100 / 10;
if(c == d)
{
    Console.WriteLine("палиндром");
}
else Console.WriteLine("нет");
}
else Console.WriteLine("нет");