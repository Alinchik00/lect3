// принимает координаты 2х точек, находит между ними расстояние A (3,6,8); B (2,1,-7), -> 15.84
double distance (int[] dotsA, int[] dotsB)
{
    return Math.Sqrt(Math.Pow(dotsA[0]-dotsB[0], 2)+Math.Pow(dotsA[1]-dotsB[1], 2)+Math.Pow(dotsA[2]-dotsB[2], 2));
}

int[] dotsA = new int[3];
int[] dotsB = new int[3];

Console.WriteLine("Enter the X(A):");
dotsA[0] = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter the Y(A):");
dotsA[1] = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter the Z(A):");
dotsA[2] = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter the X(B):");
dotsA[0] = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter the Y(B):");
dotsA[1] = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter the Z(A):");
dotsA[2] = int.Parse(Console.ReadLine()!);

Console.WriteLine(Math.Round(distance(dotsA, dotsB),2));
