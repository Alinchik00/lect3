// принимает координаты 2х точек, находит между ними расстояние
double distance (int[] dotsA, int[] dotsB)
{
    return Math.Sqrt(Math.Pow(dotsA[0]-dotsB[0], 2)+Math.Pow(dotsA[1]-dotsB[1], 2));
}

int[] dotsA = new int[2];
int[] dotsB = new int[2];

Console.WriteLine("Enter the X(A):");
dotsA[0] = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter the Y(A):");
dotsA[1] = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter the X(B):");
dotsA[0] = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter the Y(B):");
dotsA[1] = int.Parse(Console.ReadLine()!);

Console.WriteLine(Math.Round(distance(dotsA, dotsB),2));