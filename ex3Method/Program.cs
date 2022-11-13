Console.WriteLine("Введите любое трехзначное число: ");
int a = int.Parse(Console.ReadLine());

int temp = a % 100;
int temp2 = temp / 10;
Console.WriteLine(temp2);